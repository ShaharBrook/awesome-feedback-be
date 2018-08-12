using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.core
{
    public class Stats<T>
    {
        public Guid FormId { get; set; }
        public string Type { get; set; }
        public T Content { get; set; }
    }
}
