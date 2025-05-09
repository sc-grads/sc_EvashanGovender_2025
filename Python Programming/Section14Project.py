from dataclasses import dataclass,field
from uuid import UUID,uuid4

@dataclass
class Note:
    id: UUID = field(init=False)
    title: str
    body: str

    def __post_init__(self) -> None:
        self.id = uuid4()

class NoteApp:
    def __init__(self,author: str, notes1: list[Note]) -> None:
        self.author = author

    if not  is None:
        self.notes = []

def main() -> None:
    note: Note = Note("Hello",'My name is Bob!')
    print(note)

if __name__ == '__main__':
    main()