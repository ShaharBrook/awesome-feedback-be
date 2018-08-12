using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.core
{
    public class Feedback<T>
    {
    public Guid FormId { get; set; }
    public FeedbackType Type { get; set; }
    public string UserName { get; set; }
    public T Content { get; set; }
    }
}
