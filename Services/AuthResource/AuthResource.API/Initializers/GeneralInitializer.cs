﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthResource.API.Initializers
{
    public class GeneralInitializer : IInitializer {
        public void InitializeServices(IServiceCollection services, IConfiguration configuration) {
            services.AddControllers();
        }
    }
}