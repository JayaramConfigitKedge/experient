using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The representation of an Excel export request. 
  /// </summary>
  [DataContract]
  public class ExcelExportRequest : RequestBase {
    /// <summary>
    /// Metadata to display in the **Details** section of the **Summary** sheet. The `metadata` object is a dictionary of key/value strings.  For example:  ``` \"metadata\": {   \"Extra info\": \"My extra info here\",   \"Contact email\": \"support@example.com\" } ``` 
    /// </summary>
    /// <value>Metadata to display in the **Details** section of the **Summary** sheet. The `metadata` object is a dictionary of key/value strings.  For example:  ``` \"metadata\": {   \"Extra info\": \"My extra info here\",   \"Contact email\": \"support@example.com\" } ``` </value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public Dictionary<string, string> Metadata { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExcelExportRequest {\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
