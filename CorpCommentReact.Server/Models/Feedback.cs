using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CorpCommentReact.Server.Models
{
	public class Feedback
	{
        public int Id { get; set; }
		public int UpvoteCount { get; set; }
		public string BadgeLetter { get; set; }
		public string Company { get; set; }
		public string Text { get; set; }
		public int DaysAgo { get; set; }
	}
}

