using LiteDB;

using System;

namespace DodoTimer.Models
{
    public class Dinner
    {
        [BsonId]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime? EndAt { get; set; }

    }
}
