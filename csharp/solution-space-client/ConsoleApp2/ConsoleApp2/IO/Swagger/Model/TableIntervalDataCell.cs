using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TableIntervalDataCell : TableDataCell {
    /// <summary>
    /// Lower bound (inclusive) of the interval. Applies to `\"Number\"` and `\"Date\"` variables only:  - For `\"Number\"` variables, `lower` is a number, such as `0`. - For `\"Date\"` variables, `lower` is a string representation   of an ISO 8601 date in UTC, such as `\"2011-10-05T00:00:00Z\"`. 
    /// </summary>
    /// <value>Lower bound (inclusive) of the interval. Applies to `\"Number\"` and `\"Date\"` variables only:  - For `\"Number\"` variables, `lower` is a number, such as `0`. - For `\"Date\"` variables, `lower` is a string representation   of an ISO 8601 date in UTC, such as `\"2011-10-05T00:00:00Z\"`. </value>
    [DataMember(Name="lower", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lower")]
    public Object Lower { get; set; }

    /// <summary>
    /// Upper bound (inclusive) of the interval. Applies to `\"Number\"` and `\"Date\"` variables only:  - For `\"Number\"` variables, `upper` is a number, such as `100`. - For `\"Date\"` variables, `upper` is a string representation   of an ISO 8601 date in UTC, such as `\"2021-10-05T00:00:00Z\"`. 
    /// </summary>
    /// <value>Upper bound (inclusive) of the interval. Applies to `\"Number\"` and `\"Date\"` variables only:  - For `\"Number\"` variables, `upper` is a number, such as `100`. - For `\"Date\"` variables, `upper` is a string representation   of an ISO 8601 date in UTC, such as `\"2021-10-05T00:00:00Z\"`. </value>
    [DataMember(Name="upper", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "upper")]
    public Object Upper { get; set; }

    /// <summary>
    /// Whether `lower` is the minimum possible value.
    /// </summary>
    /// <value>Whether `lower` is the minimum possible value.</value>
    [DataMember(Name="isLowerInfinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isLowerInfinity")]
    public bool? IsLowerInfinity { get; set; }

    /// <summary>
    /// Whether `upper` is the maximum possible value.
    /// </summary>
    /// <value>Whether `upper` is the maximum possible value.</value>
    [DataMember(Name="isUpperInfinity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isUpperInfinity")]
    public bool? IsUpperInfinity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TableIntervalDataCell {\n");
      sb.Append("  Lower: ").Append(Lower).Append("\n");
      sb.Append("  Upper: ").Append(Upper).Append("\n");
      sb.Append("  IsLowerInfinity: ").Append(IsLowerInfinity).Append("\n");
      sb.Append("  IsUpperInfinity: ").Append(IsUpperInfinity).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
