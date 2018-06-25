
namespace QuestionApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int ReviewerId { get; set; }
        public string CommentText { get; set; }
    }
}
