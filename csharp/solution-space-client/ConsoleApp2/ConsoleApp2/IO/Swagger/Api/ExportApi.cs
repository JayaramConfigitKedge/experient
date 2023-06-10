using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IExportApi
    {
        /// <summary>
        /// Get a solution space in Excel spreadsheet format Gets a solution space in Excel spreadsheet format.  Note that the contents of the Excel file are still under development and subject to change between releases. 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="packagePath">Path (case-sensitive) to the package.  For the latest visible version of a package, use the format  &#x60;packagePath&#x3D;{path}&#x60;. For example, &#x60;packagePath&#x3D;samples/ihear&#x60;.   To request a specific package version, use the format  &#x60;packagePath&#x3D;{path}~{version}&#x60;. For example,  &#x60;packagePath&#x3D;samples/ihear~8bd554bc-2dfa-41d0-b1bf-aec97dd81eca&#x60;. </param>
        /// <returns>byte[]</returns>
        byte[] GetExcelExport (ExcelExportRequest body, string packagePath);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExportApi : IExportApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ExportApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExportApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get a solution space in Excel spreadsheet format Gets a solution space in Excel spreadsheet format.  Note that the contents of the Excel file are still under development and subject to change between releases. 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="packagePath">Path (case-sensitive) to the package.  For the latest visible version of a package, use the format  &#x60;packagePath&#x3D;{path}&#x60;. For example, &#x60;packagePath&#x3D;samples/ihear&#x60;.   To request a specific package version, use the format  &#x60;packagePath&#x3D;{path}~{version}&#x60;. For example,  &#x60;packagePath&#x3D;samples/ihear~8bd554bc-2dfa-41d0-b1bf-aec97dd81eca&#x60;. </param>
        /// <returns>byte[]</returns>
        public byte[] GetExcelExport (ExcelExportRequest body, string packagePath)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetExcelExport");
            // verify the required parameter 'packagePath' is set
            if (packagePath == null) throw new ApiException(400, "Missing required parameter 'packagePath' when calling GetExcelExport");
    
            var path = "/export";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (packagePath != null) queryParams.Add("packagePath", ApiClient.ParameterToString(packagePath)); // query parameter
                        postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExcelExport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExcelExport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (byte[]) ApiClient.Deserialize(response.Content, typeof(byte[]));//, response.Headers
        }
    
    }
}
