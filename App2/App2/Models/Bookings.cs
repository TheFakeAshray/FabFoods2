﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Models
{
    class Bookings
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime Date { get; set; }

        [JsonProperty(PropertyName ="time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "numberOfPeople")]
        public double NumberOfPeople { get; set; }

        [JsonProperty(PropertyName = "extraDetails")]
        public string ExtraDetails { get; set; }
    }
}
