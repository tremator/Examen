using System;

namespace Examen.Models
{
    public class Event
    {
        public long Id { get; set; }

        public String Description { get; set; }
        public DateTime initialDate { get; set; }
        public DateTime endDate { get; set; }
    }
}