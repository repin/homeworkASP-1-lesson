using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class WeatherHolder
    {
        public WeatherHolder()
        {
            _weather = new Dictionary<DateTime, float>();
        }

        private Dictionary<DateTime,float> _weather;

        public void Add (DateTime dateTime, float tempCels)
        {
            _weather.Add(dateTime, tempCels);
        }

        public void Delete(DateTime dateTime)
        {
            if (_weather.ContainsKey(dateTime))
            {
                _weather.Remove(dateTime);
            }
        }

        public void Edit(DateTime dateTime, float tempCels)
        {
            if (_weather.ContainsKey(dateTime))
            {
                _weather[dateTime] = tempCels;
            }
        }

        public string TakeTempToSpan(DateTime startDateTime, DateTime endDateTime)
        {
            List<string> tempToInterval = new List<string>();
            if (_weather is null) return null;
            foreach (DateTime dateTime in _weather.Keys)
            {
                if(startDateTime <= dateTime && dateTime <= endDateTime)
                {
                    tempToInterval.Add(_weather[dateTime].ToString() +" - " +dateTime.ToString());
                }
            }
            return string.Join(',',tempToInterval.ToArray());
        }
    }
}
