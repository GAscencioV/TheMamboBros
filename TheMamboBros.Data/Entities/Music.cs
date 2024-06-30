
namespace TheMamboBros.Data.Entities
{
    public class Music : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ArtistId { get; set; }
        public int ProducerId { get; set; }
        public int PublisherId { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
