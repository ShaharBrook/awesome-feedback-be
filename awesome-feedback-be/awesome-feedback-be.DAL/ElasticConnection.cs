using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace awesome_feedback_be.DAL
{
    public class ElasticConnection
    {
        public static ElasticClient Connect()
        {
            var node = new Uri("http://23.97.209.154:9200");

            var settings = new ConnectionSettings(
                node
            ).BasicAuthentication("elastic", "D1234567890h");

             return new ElasticClient(settings);
        }
    }
}
