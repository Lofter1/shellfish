using System;

namespace DesktopApp.Models
{
    public class CBook : CAsset
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Edition { get; set; }
        public Uri Cover { get; set; }
        public string FileType { get; set; }
    }
}