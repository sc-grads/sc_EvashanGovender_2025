def get_length(text: str) -> int:
    print(f'Getting the length of: "{text}"...')
    return len(text)

name:str = "Mario"
length:int = get_length(name)
print(f'The length of "{name}" is: {length}')