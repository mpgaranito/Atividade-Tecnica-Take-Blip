using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GitTake.Models
{
    public class CarrosselInfo
    {

        [JsonPropertyName("full_name")]
        public string Nome { get; set; }
        [JsonPropertyName("language")]
        public string Linguagem { get; set; }
        [JsonPropertyName("description")]
        public string Descricao { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime Criado { get; set; }
    }
}
