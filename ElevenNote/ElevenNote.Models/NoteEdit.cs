using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{       // this model will allow updating a note
    public class NoteEdit
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
