using Newtonsoft.Json;

namespace QuestionApp.Models
{
    public class Question
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("questionText")]
        public string QuestionText { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("commentText")]
        public string CommentText { get; set; }
    }
}
