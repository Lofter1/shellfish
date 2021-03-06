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
        public Person Speaker { get; set; }
        
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