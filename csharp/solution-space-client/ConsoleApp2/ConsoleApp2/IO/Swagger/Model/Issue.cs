using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an issue that occurred during the operation. 
  /// </summary>
  [DataContract]
  public class Issue {
    /// <summary>
    /// The issue type.
    /// </summary>
    /// <value>The issue type.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// An internal message describing the issue.
    /// </summary>
    /// <value>An internal message describing the issue.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Collection of sources that caused the issue. 
    /// </summary>
    /// <value>Collection of sources that caused the issue. </value>
    [DataMember(Name="sources", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sources")]
    public List<string> Sources { get; set; }

    /// <summary>
    /// Collection of variables affected by the issue, if any. 
    /// </summary>
    /// <value>Collection of variables affected by the issue, if any. </value>
    [DataMember(Name="affectedVariables", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "affectedVariables")]
    public List<string> AffectedVariables { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Issue {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Sources: ").Append(Sources).Append("\n");
      sb.Append("  AffectedVariables: ").Append(AffectedVariables).Append("\n");
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
