using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.core
{
    public class Feedback
    {
    public Guid FormId { get; set; }
    public FeedbackType Type { get; set; }
    public string UserName { get; set; }
    public string[] Answers { get; set; }
     public double Rating { get; set; }
     public bool Answer { get; set; }
     public string FreeText { get; set; }
    }
}
