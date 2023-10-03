using ShapeMaster.Domain.Entities;
using ShapeMaster.Infastructure.Services;

Square square1 = new Square(5);

NotepadService notepadService = new NotepadService();
notepadService.SaveToNotepad(square);


