using QuestionApp.Models;
using System.Collections.Generic;

namespace QuestionApp.Repository
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions();

        int AddReviewer(Reviewer reviewer);

        void AddComments(IEnumerable<Comment> comments);
    }
}
