using System;
using System.Collections.Generic;

namespace DesktopApp.Models
{
    /// <summary>
    /// Abstract base class containing meta data present in all assets.
    /// </summary>
    public abstract class Asset
    {
        /// <summary>
        /// Title for the asset.
        /// </summary>
        public string Title { get; set; }
        
        /// <summary>
        /// The asset ID for the database
        /// </summary>
        public int AssetId { get; set; }
        
        /// <summary>
        /// Url representing where the asset can be found.
        /// Whether on network or local.
        /// </summary>
        public Uri Url { get; set; }
        
        /// <summary>
        /// Tags for asset. Can have multiple tags and tags can be used
        /// for multiple assets.
        /// Can be used for searching or filtering.
        /// </summary>
        public List<Tag> Tags { get; set; }
    }
}