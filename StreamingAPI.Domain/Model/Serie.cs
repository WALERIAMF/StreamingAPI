using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingAPI.Domain.Model
{
    public class Serie : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public int Seasons { get; set; }
        public bool Excluded { get; set; }
        public Genre Genre { get; set; }
    }

}
