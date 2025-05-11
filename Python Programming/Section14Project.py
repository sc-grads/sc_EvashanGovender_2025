from dataclasses import dataclass,field
from uuid import UUID,uuid4

from pip._internal import self_outdated_check


@dataclass
class Note:
    id: UUID = field(init=False)
    title: str
    body: str

    def __post_init__(self) -> None:
        self.id = uuid4()

class NoteApp:
    def __init__(self,author: str, notes: list[Note] | None = None) -> None:
        self.author = author
        if notes is None:
            self.notes = []
        else:
            self._notes = notes
        self.displayInstructions()

    @staticmethod
    def displayInstructions() -> None:
        print("Welcome to Notes!")
        print("Here are the commands: ")
        print("1 - Add new note")
        print("2 - Edit note")
        print("3 - Delete note")
        print("4 - Display all notes")

    def _add_notes(self) -> None:
        title: str = input("Title: ")
        body : str = input("Body: ")

        note : Note = Note(title=title, body=body)
        self.notes.append(note)
        print("Note was added!")

    def _edit_note(self) -> None:
        print("Which note would you like to edit?")
        self._show_notes()

        try:
            note_index:int = int(input("Index: ")) -1
            current_note:Note = self._notes[note_index]

            new_title = str(input("New title: "))
            new_body: str = str(input("New body: "))

            current_note.title = new_title
            current_note.body = new_body
        except IndexError:
            print("Invalid index.")
            self._edit_note()
        except ValueError:
            print("Index cannot be empty.")
            print("Aborting operation")

    def _delete_note(self) -> None:
        print("Which note would you like to delete?")
        self._show_notes()

        try:
           note_index: int = int(input("Index: ")) - 1
           del self._notes[note_index]
           print("Note was deleted!")
        except IndexError:
            print("Invalid index.")
            self._edit_note()
        except ValueError:
            print("Index cannot be empty.")
            print("Aborting operation")

    def _show_notes(self) -> None:
        if not self._notes:
            print("No notes were added.")
            return

        for i, note in enumerate(self._notes):
            print(f"[{i}]. {note.title}: {note.body}")

    def _select_option(self,user_input: str) -> None:
        if user_input not in ("1", "2", "3", "4"):
            print("Invalid input.")
            return
        if user_input == '1':
            self._add_notes()
        elif user_input == '2':
            self._edit_note()
        elif user_input == '3':
            self._delete_note()
        else:
            self._show_notes()

    def _run_app(self) -> None:
        while True:
            user_input: str = input ("You:")
            self._select_option(user_input)




def main() -> None:
    sample_notes: list[Note] = [Note(title="Title1", body="Hello there, Bob!"),
                                Note(title="Title2", body="More Text!")]

    note_app: NoteApp = NoteApp(author="Bob", notes=sample_notes)
    note_app._run_app()

if __name__ == '__main__':
    main()
