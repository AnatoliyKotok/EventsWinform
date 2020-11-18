using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformEvents
{ 
    enum ImportanceLevel {Low,Avarage,High}
    class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public ImportanceLevel impLevel { get; set; }
        public Event(string name, DateTime date,ImportanceLevel impL )
        {
            this.Name = name;
            this.Date = date;
            this.impLevel = impL;
        }
        public override string ToString()
        {
            return $"{Name}\t{Date.ToString()}\t{impLevel.ToString()}";
        }
    }
     class EventPlenning
    {
        public List<Event> Events { get; set; }
        public void AddEvent(Event e)
        {
            Events.Add(e);
        }
        public override string ToString()
        {
            return $"{Events.ToString()}";
        }
    }
}
