using System;

namespace DesktopApp.Models
{
    /// <summary>
    /// Book that could be stored online or offline.
    /// </summary>
    public class Book : Asset
    {
        /// <summary>
        /// The author of the book.
        /// </summary>
        public string Author { get; set; }
        
        /// <summary>
        /// Date on which the book was published.
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// The published edition of the book.
        /// </summary>
        public string Edition { get; set; }
        
        /// <summary>
        /// Location of the cover.
        /// </summary>
        public Uri Cover { get; set; }
        
        /// <summary>
        /// Filetype of the book, such as pdf, ebz etc.
        /// </summary>
        public string FileType { get; set; }
    }
}