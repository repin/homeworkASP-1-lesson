using System.Collections.Generic;
using System.Linq;

namespace MetricsAgent.models
{
    public class AgentPool
    {

        Dictionary<int, AgentInfo> _values;

        public AgentPool()
        {
            _values = new Dictionary<int, AgentInfo>();
        }

        public void Add(AgentInfo value)
        {
            if (!_values.ContainsKey(value.AgentId))
            {
                _values.Add(value.AgentId, value);
            }
        }

        public AgentInfo[] Get()
        {
            return _values.Values.ToArray();
        }
    }
}
