﻿using Microsoft.WindowsAzure.Storage.Table;
using Newtonsoft.Json;

namespace RIPA.Functions.TableStorage.Functions.Schools.Models
{
    public class School : TableEntity
    {
        [JsonProperty(PropertyName = "cdsCode")]
        public int CDSCode { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }
        
        [JsonProperty(PropertyName = "district")]
        public string District { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
