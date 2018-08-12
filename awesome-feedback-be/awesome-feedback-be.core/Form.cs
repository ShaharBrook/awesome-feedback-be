using System;

namespace awesome_feedback_be.core
{
    public class Form
    {
        public Guid Id { get; set; }
        public FeedbackType Type { get; set; }
        public string AppName { get; set; }
        public string Html { get; set; }
    }
}
