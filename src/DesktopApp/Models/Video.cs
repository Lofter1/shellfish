using System;

namespace DesktopApp.Models
{
    /// <summary>
    /// A video, such as a tutorial.
    /// </summary>
    public class Video : Asset
    {
        /// <summary>
        /// Date on which the video was uploaded
        /// </summary>
        public DateTime UploadDate { get; set; }
        
        /// <summary>
        /// Person who uploaded the video.
        /// </summary>
        public string Uploader { get; set; }
        
        /// <summary>
        /// Length of the video.
        /// </summary>
        public float Length { get; set; }
    }
}