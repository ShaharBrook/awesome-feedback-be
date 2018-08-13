using awesome_feedback_be.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class MultiAnswersFeedback : FeedbackBase
    {
        public MultiAnswersFeedback(Feedback feedback) : base(feedback.FormId.ToString(),feedback.Type,feedback.UserName)
        {
            this.answers = feedback.Answers;
        }

        public string[] answers { get; set; }

    }
}
