using System.Collections.Generic;

namespace Prometheus.AspNet
{
    public class QueryRequest
    {
        public string OperationName { get; set; }
        public string NamedQuery { get; set; }
        public string Query { get; set; }
        public Dictionary<string, object> Variables { get; set; }
    }
}