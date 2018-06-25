using Dapper;
using QuestionApp.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace QuestionApp.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private string _connectionString;

        public QuestionRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Question> GetQuestions()
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<Question>("sp_GetQuestions", commandType: CommandType.StoredProcedure);
            }
        }

        public int AddReviewer(Reviewer reviewer)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                return db.Query<int>("sp_AddReviewer", reviewer, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public void AddComments(IEnumerable<Comment> comments)
        {
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                db.Execute("sp_AddComment", comments, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
