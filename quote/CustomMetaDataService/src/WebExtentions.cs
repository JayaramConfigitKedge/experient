using Configit.Quote.Domain.Quotes;
using Configit.Quote.Public.Interfaces;
using Configit.Quote.Public.Internal;
using Configit.Quote.Public.Models.General;
using Configit.Quote.Public.Models.Quote;
using System.Threading.Tasks;

namespace WebApiExtensionServices.Services
{
    public class CustomMetaDataService : IMetaDataService
    {
        private readonly IQuoteStorage _quoteStorage;
        public CustomMetaDataService(IQuoteStorage quoteStorage)
        {
            _quoteStorage = quoteStorage;
        }

        private async void CreatePartnerInfoMessage(Quotation quote, List<CustomMessage> customMessages)
        {
            
            //var quotePartners = _quoteStorage.GetQuotePartners(quoteId);
          //  var quote =  _quoteStorage.GetQuoteAsync(quoteId);
            //var tquote = await quote;
            if (string.IsNullOrEmpty(quote?.SoldTo?.Partner?.ExternalId))
            {
                var message = "A customer should be added first";
                customMessages.Add(new CustomMessage(message, "info"));
            }
        }


        private async Task<bool> CreateQuoteDiscountWarningMessage(Quotation quote, List<CustomMessage> customMessages)
        {
            //Console.WriteLine("CreateQuoteDiscountWarningMessage **");
            var maxDiscount = 500;
            var quoteTotalValueCondition = 10000;
            if (quote.TotalNetValue < quoteTotalValueCondition)
            {
                
                var modelPrice = _quoteStorage.GetPriceModelAsync(quote.QuoteRevisionId);
                var tModelPrice = await modelPrice;
                var currentDiscount = Math.Abs(tModelPrice.TotalDiscount); // Discount is often written as a negative number
                if (currentDiscount >= maxDiscount)
                {
                    var message = $"When the net value of a quote is less then {quoteTotalValueCondition}, "
                                  + $"the discount should be no more than {maxDiscount}, current discount is {currentDiscount}";
                    customMessages.Add(new CustomMessage(message, "warning"));
                }
            }
            return true;
        }

        private async Task<bool> CreateBlackBikeCountErrorMessage(Quotation quote, List<CustomMessage> customMessages)
        {
           // Console.WriteLine("CreateBlackBikeCountErrorMessage **");
            decimal currentCountOfBlackCentCityAlu = 0;
            var maxCountOfBlackCentCityAlu = 6;
            foreach (var line in quote.Lines)
            {
                if (line.MaterialVariant != null && line.MaterialVariant.Code == "CENT_CITY_ALU")
                {
                    var configurationState =
                      _quoteStorage.GetConfigurationStateAsync(new QuoteRevisionLineId(quote.QuoteRevisionId, line.Id));
                    var tConfigurationState = await configurationState;
                    var frameColor = tConfigurationState.Assignments.FirstOrDefault(x => x.VariableName == "BIKE_FRAME_COLOR");
                    if (frameColor != null && frameColor.ValueName == "BLACK")
                    {
                        currentCountOfBlackCentCityAlu += line.Quantity;
                    }
                }
            }
            if (currentCountOfBlackCentCityAlu > maxCountOfBlackCentCityAlu)
            {
                var message =
                  $"{currentCountOfBlackCentCityAlu} black Cent-City-Alu bikes are sold, maximum allowed are {maxCountOfBlackCentCityAlu}";
                customMessages.Add(new CustomMessage(message, "error"));
            }
            return true;
        }


        async Task<IDictionary<string, object>> IMetaDataService.GetMetaDataAsync(QuoteRevisionId quoteId, CancellationToken cancellationToken)
        {
            IDictionary<string, object> metaData = new Dictionary<string, object>();
            var customMessages = new List<CustomMessage>();
            var quote =  _quoteStorage.GetQuoteAsync(quoteId);
            var tQuote = await quote;
           
            CreatePartnerInfoMessage(tQuote, customMessages);
            var taskOne =  CreateQuoteDiscountWarningMessage(tQuote, customMessages);
            var taskTwo =  CreateBlackBikeCountErrorMessage(tQuote, customMessages);
            metaData.Add("quoteMessages", customMessages);
            //var t = new Task(() => string.Empty);


            Task.WaitAll(taskOne, taskTwo);

            //var k = Task.Run(() => metaData);

            // return (IDictionary<string, object>)k;
            return metaData;
        }
    }
}
