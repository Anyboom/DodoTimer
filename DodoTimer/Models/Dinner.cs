using System;

namespace DodoTimer.Models
{
    public class Dinner
    {
        public int Id { get; set; }
        public int IdPerson { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }

    }
}
