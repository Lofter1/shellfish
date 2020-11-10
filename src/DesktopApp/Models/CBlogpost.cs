using System;

namespace DesktopApp.Models
{
    public class CBlogpost : CAsset
    {
        public string Author { get; set; }
        public DateTime UploadDate { get; set; }
    }
}