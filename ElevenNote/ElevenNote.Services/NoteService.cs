using ElevenNote.Data;
using ElevenNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Services
{   /* The service layer is how the application intereacts with
     * the database. 
     * References are added to use models and poperties of the
     * other projects. */
    public class NoteService
    {
        // constructor and private field of type Guid call _userId:
        private readonly Guid _userId;
        public NoteService(Guid userId)
        {
            _userId = userId;
        }
        
        // This will create an instance of Note
        public bool CreateNote(NoteCreate model)
        {
            var entity =  // entity is being used because it's creating the "Note"
                new Note()
                {
                    OwnerId = _userId,
                    Title = model.Title, 
                    Content = model.Content,
                    CreatedUtc = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Notes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NoteListItem> GetNotes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Notes
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                            e =>
                                new NoteListItem
                                {
                                    NoteId = e.NoteId,
                                    Title = e.Title,
                                    CreatedUtc = e.CreatedUtc
                                }
                          );
                return query.ToArray();
            }
        }
    }
}
