﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace Microsoft.Azure.WebJobs
{
    /// <summary>
    /// Extension methods for Http integration
    /// </summary>
    public static class HttpJobHostConfigurationExtensions
    {
        /// <summary>
        /// Enables use of Http extensions
        /// </summary>
        /// <param name="config">The <see cref="JobHostConfiguration"/> to configure.</param>
        /// <param name="httpConfig">The <see cref="HttpExtensionConfiguration"/> to use.</param>
        public static void UseHttp(this JobHostConfiguration config, HttpExtensionConfiguration httpConfig = null)
        {
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            if (httpConfig == null)
            {
                httpConfig = new HttpExtensionConfiguration();
            }

            config.RegisterExtensionConfigProvider(httpConfig);
        }
    }
}
