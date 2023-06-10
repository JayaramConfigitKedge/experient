using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A table header cell.
  /// </summary>
  [DataContract]
  public class TableHeaderCell {
    /// <summary>
    /// ID of the variable.
    /// </summary>
    /// <value>ID of the variable.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The text to display representing the variable's name. The text is translated based on the language in the request. 
    /// </summary>
    /// <value>The text to display representing the variable's name. The text is translated based on the language in the request. </value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// > For multi-assign variables only.  A value from a multi-assign variable. Otherwise, null. 
    /// </summary>
    /// <value>> For multi-assign variables only.  A value from a multi-assign variable. Otherwise, null. </value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets ValueType
    /// </summary>
    [DataMember(Name="valueType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueType")]
    public string ValueType { get; set; }

    /// <summary>
    /// > For multi-assign variables only.  The text to display representing the value's name. The text is translated based on the language in the request. 
    /// </summary>
    /// <value>> For multi-assign variables only.  The text to display representing the value's name. The text is translated based on the language in the request. </value>
    [DataMember(Name="valueName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueName")]
    public string ValueName { get; set; }

    /// <summary>
    /// Whether the variable is constrained or not.  A variable is constrained if it has at least one value that is incompatible with value(s) from other variables. 
    /// </summary>
    /// <value>Whether the variable is constrained or not.  A variable is constrained if it has at least one value that is incompatible with value(s) from other variables. </value>
    [DataMember(Name="constrainedVariable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "constrainedVariable")]
    public bool? ConstrainedVariable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TableHeaderCell {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
      sb.Append("  ValueName: ").Append(ValueName).Append("\n");
      sb.Append("  ConstrainedVariable: ").Append(ConstrainedVariable).Append("\n");
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
