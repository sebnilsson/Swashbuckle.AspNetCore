﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;

namespace Swashbuckle.AspNetCore.Swagger
{
    public class SwaggerOptions
    {
        public const string DefaultRouteTemplate = "swagger/{documentName}/swagger.json";

        public SwaggerOptions()
        {
            PreSerializeFilters = new List<Action<OpenApiDocument, HttpRequest>>();
            SerializeAsV2 = false;
        }

        /// <summary>
        /// Sets a custom route for the Swagger JSON endpoint(s). Must include the {documentName} parameter
        /// </summary>
        public string RouteTemplate { get; set; } = DefaultRouteTemplate;

        
        /// <summary>
        /// Return Swagger JSON in the V2 format rather than V3
        /// </summary>
        public bool SerializeAsV2 { get; set; }

        /// <summary>
        /// Actions that can be applied SwaggerDocument's before they're serialized to JSON.
        /// Useful for setting metadata that's derived from the current request
        /// </summary>
        public List<Action<OpenApiDocument, HttpRequest>> PreSerializeFilters { get; private set; }
    }
}
