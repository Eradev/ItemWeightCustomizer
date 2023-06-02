using System.Collections.Generic;
using Newtonsoft.Json;

namespace ItemWeightCustomizer
{
    public partial class Settings
    {
        [JsonProperty("weightSettings")]
        public WeightSettings WeightSettings { get; set; } = new();

        [JsonProperty("categories")]
        public HashSet<WeightCategory> Categories { get; set; } = new();
    }
}