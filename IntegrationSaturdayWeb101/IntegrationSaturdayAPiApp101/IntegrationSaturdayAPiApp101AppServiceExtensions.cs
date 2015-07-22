using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace IntegrationSaturdayWeb101
{
    public static class IntegrationSaturdayAPiApp101AppServiceExtensions
    {
        public static IntegrationSaturdayAPiApp101 CreateIntegrationSaturdayAPiApp101(this IAppServiceClient client)
        {
            return new IntegrationSaturdayAPiApp101(client.CreateHandler());
        }

        public static IntegrationSaturdayAPiApp101 CreateIntegrationSaturdayAPiApp101(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new IntegrationSaturdayAPiApp101(client.CreateHandler(handlers));
        }

        public static IntegrationSaturdayAPiApp101 CreateIntegrationSaturdayAPiApp101(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new IntegrationSaturdayAPiApp101(uri, client.CreateHandler(handlers));
        }

        public static IntegrationSaturdayAPiApp101 CreateIntegrationSaturdayAPiApp101(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new IntegrationSaturdayAPiApp101(rootHandler, client.CreateHandler(handlers));
        }
    }
}
