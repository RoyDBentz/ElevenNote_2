using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItem // remember to check if you need the class to be public IMMEEDIATELY
    {
        /* First Model Creation
         * This first model created will handle the task of 
         * collecting property data for a list of notes. When
         * a user enters information, we will want them to 
         * enter specific data.When we show information, we 
         * will want to show specific data in specific views.*/
        public int NoteId { get; set; }
        public string Title { get; set; }

        /* these are the properties that will show up in the view
         * data annotations can be added to these properties.
         * example below    
         * uses 'System.ComponentModel.DataAnnotations'*/
        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc {get; set;}


    }
}
