using System;
using System.Collections.Generic;

namespace DesktopApp.Models
{
    public abstract class CAsset
    {
        public string Title { get; set; }
        public int AssetId { get; set; }
        public Uri Url { get; set; }
        public List<string> Keywords { get; set; }
    }
}