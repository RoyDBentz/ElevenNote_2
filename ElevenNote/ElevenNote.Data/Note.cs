using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key] // will always be a unique number
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; } // Globally Unique Identifier being OwnerId

        [Required]
        public string Title { get; set; } // simple string Title

        [Required]
        public string Content { get; set; } // simple string Content

        [Required]
        public DateTimeOffset CreatedUtc { get; set; } // setting point in time Note is created
        public DateTimeOffset? ModifiedUtc { get; set; } // setting point in time Note is modified if modified and ? = can't be null

        /* Examples of attributes that could be added to a property
         * [Required]
         * [Range(1,5, ErrorMessage="please choose a number between 1 and 5)]
         * [MaxLength(100, ErrorMessage = "There are too many characters in this field.")] 
         * 
         * Use the [Display] or [Display(Name)] attribute to change the name of the user is shown for a property.
         * 
         * Display Attribute Example
         * [Display(Name = "Your Note")]
         */
    }
}
