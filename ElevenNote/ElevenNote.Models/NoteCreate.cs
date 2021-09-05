using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{   /* When creating models think about what needs to be
     * captured by the model. We know this Note model will
     * need to create Title, Content, and DateCreated, but
     * is an id necessary?
     * In this instance the answer is no because the id will 
     * be created AFTER the POST request happens, after filling 
     * out a form with the two properties below.
     * .Service and .Data layer will work together to take care
     * of that. */
    public class NoteCreate
    {
        // We can add annotations to require or limit the number of
        // characters in each field 'among other options as well'
        [Required]
        [MinLength(2, ErrorMessage="Please enter at least 2 characters.")]
        [MaxLength(8000)]
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
