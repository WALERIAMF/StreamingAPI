
namespace StreamingAPI
{
    public interface IEntity
    {
        int Id { get; set; }
        string Title { get; set; }
        int Year { get; set; }
        string Description { get; set; }
        public bool Excluded { get; set; }
    }
}
