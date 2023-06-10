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
  public class IntervalAllowedValue : AllowedValue {
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntervalAllowedValue {\n");
      sb.Append("  Lower: ").Append(Lower).Append("\n");
      sb.Append("  Upper: ").Append(Upper).Append("\n");
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
