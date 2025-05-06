#relative and absolute tolerance
from math import isclose

a: float = 0.1 + 0.2
b: float = 0.3

print(f'{a} == {b}', isclose(a, b, rel_tol=0.001))