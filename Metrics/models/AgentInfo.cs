using System;

namespace MetricsAgent.models
{
    public class AgentInfo
    {
        public int AgentId { get; set; }

        public Uri AgentAdress { get; set; }

        public bool Enable { get; set; }
    }
}
