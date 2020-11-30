using System;

namespace DesktopApp.Models
{
    /// <summary>
    /// A podcast on the internet.
    /// </summary>
    public class Podcast : Asset
    {
        /// <summary>
        /// The host of the podcast.
        /// </summary>
        public string Speaker { get; set; } // TODO does a list of speakers make more sense?
        
        /// <summary>
        /// Play-length of the podcast.
        /// </summary>
        public  float Length { get; set; }
        
        /// <summary>
        /// Number of the episode of the podcast.
        /// </summary>
        public int Episode { get; set; }
        
        /// <summary>
        /// Date on which the podcast was published.
        /// </summary>
        public DateTime PublishDate { get; set; }
    }
}