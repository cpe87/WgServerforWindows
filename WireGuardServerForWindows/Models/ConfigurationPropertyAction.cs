﻿using System;

namespace WireGuardServerForWindows.Models
{
    public class ConfigurationPropertyAction
    {
        public string Name { get; set; }

        public Action<ConfigurationBase, ConfigurationProperty> Action { get; set; }
    }

    public class ConfigurationPropertyValidation
    {
        public Func<ConfigurationProperty, string> Validate { get; set; }
    }
}