﻿using System;
using System.Configuration;
using static System.Diagnostics.Contracts.Contract;

namespace RES.Configuration
{
    internal class GetFromEnvironment : IConfigurationGetter
    {
        public string Get(string setting)
        {
            Requires(setting != null);

            return Environment.GetEnvironmentVariable(setting);
        }
    }
}