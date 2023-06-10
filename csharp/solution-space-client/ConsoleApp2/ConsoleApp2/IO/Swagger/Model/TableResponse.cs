using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The representation of a table response. 
  /// </summary>
  [DataContract]
  public class TableResponse {
    /// <summary>
    /// The `language` used in the request. 
    /// </summary>
    /// <value>The `language` used in the request. </value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// The `packagePath` used in the request. If a version wasn't specified, the latest versioned path is returned. 
    /// </summary>
    /// <value>The `packagePath` used in the request. If a version wasn't specified, the latest versioned path is returned. </value>
    [DataMember(Name="packagePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "packagePath")]
    public string PackagePath { get; set; }

    /// <summary>
    /// The table headers.
    /// </summary>
    /// <value>The table headers.</value>
    [DataMember(Name="headerCells", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headerCells")]
    public List<TableHeaderCell> HeaderCells { get; set; }

    /// <summary>
    /// The table rows. Each row represents a solution of compatible values. 
    /// </summary>
    /// <value>The table rows. Each row represents a solution of compatible values. </value>
    [DataMember(Name="rows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rows")]
    public List<List<TableDataCell>> Rows { get; set; }

    /// <summary>
    /// The total number of solutions. 
    /// </summary>
    /// <value>The total number of solutions. </value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Whether the solution space is constrained or not. An unconstrained solution space means that all combinations of values from the requested variables are valid. 
    /// </summary>
    /// <value>Whether the solution space is constrained or not. An unconstrained solution space means that all combinations of values from the requested variables are valid. </value>
    [DataMember(Name="isUnconstrained", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isUnconstrained")]
    public bool? IsUnconstrained { get; set; }

    /// <summary>
    /// Issues, if any, found while processing the `assignments`. 
    /// </summary>
    /// <value>Issues, if any, found while processing the `assignments`. </value>
    [DataMember(Name="issues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "issues")]
    public List<Issue> Issues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TableResponse {\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  PackagePath: ").Append(PackagePath).Append("\n");
      sb.Append("  HeaderCells: ").Append(HeaderCells).Append("\n");
      sb.Append("  Rows: ").Append(Rows).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  IsUnconstrained: ").Append(IsUnconstrained).Append("\n");
      sb.Append("  Issues: ").Append(Issues).Append("\n");
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
