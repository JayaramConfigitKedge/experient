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
  public class RequestBase {
    /// <summary>
    /// ID of the language to use when translating the `name` properties found on variables and values. If the language doesn't exist, the `name`s are set to the IDs of their objects. 
    /// </summary>
    /// <value>ID of the language to use when translating the `name` properties found on variables and values. If the language doesn't exist, the `name`s are set to the IDs of their objects. </value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// ID of the product to generate the solution space for.
    /// </summary>
    /// <value>ID of the product to generate the solution space for.</value>
    [DataMember(Name="productId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productId")]
    public string ProductId { get; set; }

    /// <summary>
    /// IDs of the variables to include in the solution space. 
    /// </summary>
    /// <value>IDs of the variables to include in the solution space. </value>
    [DataMember(Name="variableIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableIds")]
    public List<string> VariableIds { get; set; }

    /// <summary>
    /// Configuration assignments that constrain the solution space. 
    /// </summary>
    /// <value>Configuration assignments that constrain the solution space. </value>
    [DataMember(Name="assignments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "assignments")]
    public List<VariableAssignment> Assignments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestBase {\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  ProductId: ").Append(ProductId).Append("\n");
      sb.Append("  VariableIds: ").Append(VariableIds).Append("\n");
      sb.Append("  Assignments: ").Append(Assignments).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
