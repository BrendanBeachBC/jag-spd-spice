﻿using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Gov.Jag.Spice.Public.ViewModels
{
    public class ProgramArea
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public List<ScreeningType> ScreeningTypes { get; set; }

        [JsonConstructor]
        public ProgramArea(string name, List<string> screeningTypes)
        {
            Name = name;
            Value = name;
            ScreeningTypes = screeningTypes.Select(t => new ScreeningType(t)).ToList();
        }
    }
}
