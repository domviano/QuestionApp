using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuestionApp.Models;
using QuestionApp.Repository;

namespace QuestionApp.Api
{
    [Route("api")]
    public class QuestionApiController : Controller
    {
        private readonly IQuestionRepository _QuestionRepository;

        public QuestionApiController(IQuestionRepository QuestionRepository)
        {
            _QuestionRepository = QuestionRepository;
        }

        [Route("questions")]
        [HttpGet]
        public IEnumerable<Question> Questions()
        {
            return _QuestionRepository.GetQuestions();
        }

        [Route("submission")]
        [HttpPost]
        public string Submission([FromBody]SubmissionRequest submissionRequest)
        {
            var reviewerId = _QuestionRepository.AddReviewer(submissionRequest.Reviewer);

            var commentList = new List<Comment>();
            foreach (var question in submissionRequest.Questions)
            {
                if (!string.IsNullOrEmpty(question.CommentText))
                    commentList.Add(new Comment { QuestionId = question.Id, ReviewerId = reviewerId, CommentText = question.CommentText });
            }

            _QuestionRepository.AddComments(commentList);

            return (commentList.Any(x => x.CommentText.ToLower().Contains("bizlibrary")) ? "EASTER-EGG-COMMENCE" : "");
        }

    }
}
