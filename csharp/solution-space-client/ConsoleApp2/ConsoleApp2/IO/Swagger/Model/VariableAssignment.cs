using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a value assignment to a variable.  An assignment&#x27;s type can be either &#x60;Singleton&#x60; or &#x60;AllowedValues&#x60;. Use &#x60;Singleton&#x60; to indicate a single acceptable value for the variable, and &#x60;AllowedValues&#x60; to indicate multiple acceptable values. 
  /// </summary>
  [DataContract]
  public class VariableAssignment {
    /// <summary>
    /// ID of the variable to assign to.
    /// </summary>
    /// <value>ID of the variable to assign to.</value>
    [DataMember(Name="variableId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variableId")]
    public string VariableId { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// The allowed values for the variable when type is `AllowedValues`. 
    /// </summary>
    /// <value>The allowed values for the variable when type is `AllowedValues`. </value>
    [DataMember(Name="allowedValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedValues")]
    public List<AllowedValue> AllowedValues { get; set; }

    /// <summary>
    /// Unused by the Solution Space API. 
    /// </summary>
    /// <value>Unused by the Solution Space API. </value>
    [DataMember(Name="priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// > For multi-assign variables only.  Whether the value is excluded. 
    /// </summary>
    /// <value>> For multi-assign variables only.  Whether the value is excluded. </value>
    [DataMember(Name="exclude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "exclude")]
    public bool? Exclude { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariableAssignment {\n");
      sb.Append("  VariableId: ").Append(VariableId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Exclude: ").Append(Exclude).Append("\n");
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
