using System;

namespace DesktopApp.Models
{
    /// <summary>
    /// A blog post on the internet.
    /// </summary>
    public class Blogpost : Asset
    {
        /// <summary>
        /// Author of the blog post.
        /// </summary>
        public string Author { get; set; }
        
        /// <summary>
        /// Date on which the blog post was uploaded.
        /// </summary>
        public DateTime UploadDate { get; set; }
    }
}