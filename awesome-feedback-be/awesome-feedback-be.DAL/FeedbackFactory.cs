using awesome_feedback_be.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class FeedbackFactory
    {
        public static FeedbackBase GetFeedback(Feedback feedback)
        {
            switch (feedback.Type)
            {
                case FeedbackType.like:
                    return new YesNoFeedback(feedback);
                case FeedbackType.stars:
                    return new RateFeedback(feedback);
                case FeedbackType.tags:
                    return new MultiAnswersFeedback(feedback);
            }
            return null;
        }
    }
}
