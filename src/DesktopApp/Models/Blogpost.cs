using System;

namespace DesktopApp.Models
{
    public class Blogpost : Asset
    {
        public string Author { get; set; }
        public DateTime UploadDate { get; set; }
    }
}