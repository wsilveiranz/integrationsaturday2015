// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using IntegrationSaturdayWeb101;
using Microsoft.Rest;

namespace IntegrationSaturdayWeb101
{
    public static partial class ValuesExtensions
    {
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static object Delete(this IValues operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).DeleteAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> DeleteAsync(this IValues operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.DeleteWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        public static IList<string> Get(this IValues operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<string>> GetAsync(this IValues operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<string>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static string GetById(this IValues operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).GetByIdAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetByIdAsync(this IValues operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetByIdWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object Post(this IValues operations, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).PostAsync(value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PostAsync(this IValues operations, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PostWithOperationResponseAsync(value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        public static object Put(this IValues operations, int id, string value)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IValues)s).PutAsync(id, value);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the IntegrationSaturdayWeb101.IValues.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='value'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutAsync(this IValues operations, int id, string value, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutWithOperationResponseAsync(id, value, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}