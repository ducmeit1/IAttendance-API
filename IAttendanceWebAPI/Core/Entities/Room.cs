﻿using System.Collections.Generic;

namespace IAttendanceWebAPI.Core.Entities
{
    public sealed class Room
    {
        public Room()
        {
            TimesTables = new HashSet<TimeTable>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<TimeTable> TimesTables { get; set; }
    }
}