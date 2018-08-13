using awesome_feedback_be.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class YesNoFeedback : FeedbackBase
    {
        public YesNoFeedback(Feedback feedback):base(feedback.FormId.ToString(), feedback.Type, feedback.UserName)
        {
            answer = feedback.Answer;
            freeText = feedback.FreeText;
        }

        public bool answer { get; set; } 
        public string freeText { get; set; }
    }
}
