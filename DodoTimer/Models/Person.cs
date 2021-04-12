using LiteDB;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodoTimer.Models
{
    class Person
    {
        [BsonId]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Deleted { get; set; }
        public List<Dinner> Dinners { get; set; }
    }
}
