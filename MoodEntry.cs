using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCalendar
{
    internal class MoodEntry
    {
        
            public DateTime Date { get; set; }      // Датата на настроението
            public int MoodType { get; set; }       // Тип на настроението (1-щастлив, 2-неутрален и т.н.)
            public string Note { get; set; }        // Допълнителна бележка (по желание)

            public MoodEntry(DateTime date, int moodType, string note = "")
            {
                Date = date;
                MoodType = moodType;
                Note = note;
            }


            public string GetMoodEmoji()
            {
                switch (MoodType)
                {
                    case 1:
                        return "😊";
                    case 2:
                        return "😐";
                    case 3:
                        return "😢";
                    case 4:
                        return "😠";
                    case 5:
                        return "💪";
                    default:
                        return "❓";
                }
            }

            public override string ToString()
            {
                return $"{Date.ToShortDateString()} - {GetMoodEmoji()} ({MoodType}) {Note}";
            }
    }
}
