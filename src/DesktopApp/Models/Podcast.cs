using System;

namespace DesktopApp.Models
{
    public class Podcast : Asset
    {
        public string Speaker { get; set; }
        public  float Length { get; set; }
        public int Episode { get; set; }
        public DateTime Date { get; set; }
    }
}