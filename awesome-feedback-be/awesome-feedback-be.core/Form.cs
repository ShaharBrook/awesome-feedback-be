using System;

namespace awesome_feedback_be.core
{
    public class Form
    {
        public Form(FeedbackType type, string appName, string question, string[] tags)
        {
            formId = Guid.NewGuid();
            formType = type;
            application = appName;
            this.question = question;
            this.tags = tags;
        }

        public Guid formId { get; set; }
        public FeedbackType formType { get; set; }
        public string application { get; set; }
        public int high { get; set; }
        public string question { get; set; }
        public string[] tags { get; set; }

    }
}
