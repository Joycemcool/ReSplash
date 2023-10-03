using System.ComponentModel.DataAnnotations;

namespace RePlash.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }

        public string FileName { get; set; } = string.Empty;

        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; }

        public int NumViews { get; set; }

        public int numDownloads { get; set; }

        public string Description { get; set; } = string.Empty;

        User User { get; set; } = new User();


        //List<Tag> PhotoTags
        //Category
    }
}
