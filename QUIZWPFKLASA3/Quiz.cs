using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QUIZWPFKLASA3
{
    class Quiz
    {
        [JsonPropertyName("pytanie")]
        public string Pytanie { get; set; }

        [JsonPropertyName("odpowiedzi")]
        public Dictionary<string, string> Odpowiedzi { get; set; }

        [JsonPropertyName("poprawna")]
        public string Poprawna { get; set; }
    }
}
