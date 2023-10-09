using Week_4._2.Entites;
using Week_4._2.Persistence;

NoteMasterDbContext _context = new ();
_context.Notes.Add(new Note ("Hello World!"));
_context.Notes.Add(new Note ("Hello World 2!"));
_context.Notes.Add(new Note ("Hello World 3!"));
_context.SaveChanges();

List<Note> notes = _context.Notes.ToList();

Console.WriteLine("Notes:");


bool DeleteNoteById(Guid id)
{
    Note note = _context.Notes.FirstOrDefault(note => note.Id == id);
    if (note == null)
    {
        return false;
    }
    _context.Notes.Remove(note);
    _context.SaveChanges();
    return true;
}

void BulkUpdate()
{
    var  newNotes = new List<Note>();
    for (int i = 0; i < 3; i++)
    {
        newNotes.Add(new Note($"Hello World {i}"));
    }

    _context.Notes.AddRange(newNotes);
    _context.SaveChanges();
}

bool Updates(Guid id)
{
    Note note2 = _context.Notes.FirstOrDefault(note => note.Id == id);
    if (note2 == null)
    {
        return false;
    }
    note2.Text = "Hello World Updated!";
    _context.SaveChanges();
    return true;
}

DeleteNoteById(notes[0].Id);
BulkUpdate();
Updates(notes[1].Id);

foreach (Note note in notes)
{
    Console.WriteLine($"Id: {note.Id} Text: {note.Text}");
}