namespace DesktopApp.Models
{
    /// <summary>
    /// Slide from an event that can be accessed.
    /// </summary>
    public class Slide : Asset
    {
        /// <summary>
        /// Event on which the slide was used.
        /// </summary>
        public string Event { get; set; }
        
        /// <summary>
        /// Speaker who used the slide.
        /// </summary>
        public string Speaker { get; set; }
        
        /// <summary>
        /// Filetype of the slide.
        /// </summary>
        public string FileType { get; set; }
    }
}