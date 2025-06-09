using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCalendar
{
    internal class MoodStatistics
    {
        private Dictionary<DateTime, string> _moodEntries;

        public MoodStatistics(Dictionary<DateTime, string> moodEntries)
        {
            _moodEntries = moodEntries;
        }

        public int TotalEntries => _moodEntries.Count;

        public Dictionary<string, int> GetMoodCounts()
        {
            var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var mood in _moodEntries.Values)
            {
                if (string.IsNullOrWhiteSpace(mood))
                    continue;

                if (counts.ContainsKey(mood))
                    counts[mood]++;
                else
                    counts[mood] = 1;
            }

            return counts;
        }

        public string GetMostCommonMood()
        {
            var counts = GetMoodCounts();
            if (counts.Count == 0) return null;

            return counts.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }

    }

}
