

using Newtonsoft.Json;

namespace QuestionApp.Models
{
    public class Reviewer
    {
        public int Id { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}
