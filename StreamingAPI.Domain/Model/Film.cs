

namespace StreamingAPI.Domain.Model
{
    public class Film : IEntity
    {

        public int Id { get; set; }
        //private Genero Genero { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Excluded { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
    }



}
