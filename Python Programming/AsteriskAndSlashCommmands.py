# Use of /

def func(var_a: str, /,var_b: str ) -> None:
    print(var_a)
    print(var_b)

func('a','b')

#Use of * , everything after the * must be passed as a keyword argument

def func(var_a: str, *,var_b: str ) -> None:
    print(var_a)
    print(var_b)

func('a',var_b='b')

