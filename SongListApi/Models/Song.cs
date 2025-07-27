using System.ComponentModel.DataAnnotations;

namespace SongListApi.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Required]
        public string Artist { get; set; } = string.Empty;

        [Required]
        public string Title { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Length { get; set; } // in seconds

        [Required]
        public string Category { get; set; } = string.Empty;
    }
}
