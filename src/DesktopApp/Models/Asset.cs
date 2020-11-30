using System;
using System.Collections.Generic;

namespace DesktopApp.Models
{
    public abstract class Asset
    {
        public string Title { get; set; }
        public int AssetId { get; set; }
        public Uri Url { get; set; }
        public List<Tag> Keywords { get; set; }
    }
}