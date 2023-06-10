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
    public interface ITableApi
    {
        /// <summary>
        /// Get a solution space in table format Gets a solution space in table format. 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="packagePath">Path (case-sensitive) to the package.  For the latest visible version of a package, use the format  &#x60;packagePath&#x3D;{path}&#x60;. For example, &#x60;packagePath&#x3D;samples/ihear&#x60;.   To request a specific package version, use the format  &#x60;packagePath&#x3D;{path}~{version}&#x60;. For example,  &#x60;packagePath&#x3D;samples/ihear~8bd554bc-2dfa-41d0-b1bf-aec97dd81eca&#x60;. </param>
        /// <param name="offset">Zero-based offset of the first row to return. </param>
        /// <param name="limit">Number of rows to return. </param>
        /// <returns>TableResponse</returns>
        TableResponse GetTable (TableRequest body, string packagePath, int? offset, int? limit);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TableApi : ITableApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TableApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TableApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TableApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TableApi(String basePath)
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
        /// Get a solution space in table format Gets a solution space in table format. 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="packagePath">Path (case-sensitive) to the package.  For the latest visible version of a package, use the format  &#x60;packagePath&#x3D;{path}&#x60;. For example, &#x60;packagePath&#x3D;samples/ihear&#x60;.   To request a specific package version, use the format  &#x60;packagePath&#x3D;{path}~{version}&#x60;. For example,  &#x60;packagePath&#x3D;samples/ihear~8bd554bc-2dfa-41d0-b1bf-aec97dd81eca&#x60;. </param>
        /// <param name="offset">Zero-based offset of the first row to return. </param>
        /// <param name="limit">Number of rows to return. </param>
        /// <returns>TableResponse</returns>
        public TableResponse GetTable (TableRequest body, string packagePath, int? offset, int? limit)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling GetTable");
            // verify the required parameter 'packagePath' is set
            if (packagePath == null) throw new ApiException(400, "Missing required parameter 'packagePath' when calling GetTable");
    
            var path = "/table";
            path = path.Replace("{format}", "json");

            //path = "https://syngenta.demo.configit.cloud:9001/solution-space/v1/table";
            //path += "?packagePath=chn1/rel1";


            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (packagePath != null) queryParams.Add("packagePath", ApiClient.ParameterToString(packagePath)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter

            Console.WriteLine("postBody"+postBody);

            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            RestResponse response = (RestResponse) ApiClient.CallApi(path, Method.Post, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TableResponse) ApiClient.Deserialize(response.Content, typeof(TableResponse)); //, response.Headers
        }
    
    }
}
