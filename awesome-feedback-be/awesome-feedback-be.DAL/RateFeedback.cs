using awesome_feedback_be.core;
using awesome_feedback_be.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class RateFeedback : FeedbackBase
    {
        public RateFeedback(Feedback feedback) : base(feedback.FormId.ToString(),feedback.Type,feedback.UserName)
        {
            this.rating = feedback.Rating;
        }

        public double rating { get; set; }
    }
}
