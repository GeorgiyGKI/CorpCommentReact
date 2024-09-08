using CorpCommentReact.Server.Models;

namespace CorpCommentReact.Server.Responses
{
	public class FeedbackResponse
	{
        public bool isPublic { get; set; } = true;
        public bool isSorted { get; set; } = true;
        public List<Feedback> Feedbacks { get; set; }
    }
}
