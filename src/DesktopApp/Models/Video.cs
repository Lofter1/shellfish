using System;

namespace DesktopApp.Models
{
    public class Video : Asset
    {
        public DateTime UploadDate { get; set; }
        public string Uploader { get; set; }
        public float Length { get; set; }
    }
}