using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuestionApp.Models
{
    public class SubmissionRequest
    {
        [JsonProperty("reviewer")]
        public Reviewer Reviewer { get; set; }

        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }
    }
}
