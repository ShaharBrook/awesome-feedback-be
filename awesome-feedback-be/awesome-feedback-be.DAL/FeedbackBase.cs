using awesome_feedback_be.core;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public abstract class FeedbackBase
    {
        protected FeedbackBase(string formId, FeedbackType type, string userName)
        {
            this.formId = formId;
            formType = type;
            this.userName = userName;
        }

        public string formId { get; set; }
        public FeedbackType formType { get; set; }
        public string userName { get; set; }
    }
}
