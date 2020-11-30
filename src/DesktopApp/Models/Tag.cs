using System.Collections.Generic;

namespace DesktopApp.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public List<Asset> Assets { get; set; }
    }
}