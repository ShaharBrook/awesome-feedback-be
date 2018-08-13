using awesome_feedback_be.core;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class FormRepo
    {
        public Guid Create(Form form)
        {
            var client = ElasticConnection.Connect();
            var index = client.Index(form, i => i
                .Index("forms")
                .Type("form")
            );
            return form.formId;
        }
        public IEnumerable<Form> GetAll(string appName)
        {
            List<Form> forms = new List<Form>();
            var client = ElasticConnection.Connect();
            QueryContainer query = new TermQuery
            {
                Field = "application",
                Value = appName
            };

            var searchRequest = new SearchRequest
            {
                Query = query
            };

            var searchResults = client.Search<Form>(searchRequest);
            foreach (Form form in searchResults.Documents)
                forms.Add(form);
            return forms;
        }
    }
}
