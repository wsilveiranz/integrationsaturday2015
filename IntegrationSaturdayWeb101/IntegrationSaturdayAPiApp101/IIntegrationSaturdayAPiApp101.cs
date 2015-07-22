// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using IntegrationSaturdayWeb101;
using Microsoft.Rest;

namespace IntegrationSaturdayWeb101
{
    public partial interface IIntegrationSaturdayAPiApp101 : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// Credentials for authenticating with the service.
        /// </summary>
        ServiceClientCredentials Credentials
        {
            get; set; 
        }
        
        IPresenterOperations Presenter
        {
            get; 
        }
        
        IValues Values
        {
            get; 
        }
    }
}