using System.Collections.Generic;

namespace DesktopApp.Models
{
    /// <summary>
    /// A tag for assets.
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// Name of the tag that can be searched for
        /// and is displayed.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Assets that have this tag.
        /// </summary>
        public List<Asset> Assets { get; set; }
    }
}