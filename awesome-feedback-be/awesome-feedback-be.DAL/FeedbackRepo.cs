using awesome_feedback_be.core;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class FeedbackRepo
    {
        public void Create(Feedback feedback)
        {
            var client = ElasticConnection.Connect();
            var feedbackToIndex = FeedbackFactory.GetFeedback(feedback);
            var index = client.Index(feedbackToIndex, i => i
                .Index("faas")
                .Type("feedback")
            );
        }
        public IEnumerable<FeedbackBase> GetAll(string FormId)
        {
            List<FeedbackBase> feedbacks = new List<FeedbackBase>();
            var client = ElasticConnection.Connect();
            QueryContainer query = new TermQuery
            {
                Field = "formId",
                Value = FormId
            };

            var searchRequest = new SearchRequest
            {
                Query = query
            };

            var searchResults = client.Search<YesNoFeedback>(searchRequest);
            foreach (FeedbackBase feedback in searchResults.Documents)
                feedbacks.Add(feedback);
            return feedbacks;
        }
    }
}
