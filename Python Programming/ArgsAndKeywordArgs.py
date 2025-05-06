# def add(*args: int) -> int:
#     print(args)
#     return sum(args)
#
# print(add(1,2,3))

def pin_position(**kwargs: int) -> None:
    print(kwargs)

pin_position(x=10, y=20)