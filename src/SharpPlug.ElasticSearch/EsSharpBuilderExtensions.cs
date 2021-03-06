﻿using System;
using Microsoft.Extensions.DependencyInjection;
using SharpPlug.Core;
using SharpPlug.ElasticSearch.Configuration;

namespace SharpPlug.ElasticSearch
{
    /// <summary>
    ///  Extension methods for setting up Es services in an Microsoft.Extensions.DependencyInjection.IServiceCollection.
    /// </summary>
    public static class EsServiceCollectionExtensions
    {
        public static ISharpPlugBuilder AddElasticSearchPlug(this ISharpPlugBuilder builder, Action<ElasticSearchOptions> setupAction)
        {
            builder.Services.Configure(setupAction);
            builder.Services.AddTransient<ISharpElasticsearch, SharpElasticSearch>();
            return builder;
        }
    }
}
