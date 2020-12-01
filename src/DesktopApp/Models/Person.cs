using System;

namespace DesktopApp.Models
{
    /// <summary>
    /// A person which can represent an author or speaker.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Database ID
        /// </summary>
        public int PersonId { get; set; }
        
        /// <summary>
        /// First name of the person.
        /// </summary>
        public string FirstName { get; set; }
        
        /// <summary>
        /// Last name of the person.
        /// </summary>
        public string LastName { get; set; }
        
        /// <summary>
        /// Personal or business website of the person.
        /// </summary>
        public Uri Website { get; set; }
    }
}