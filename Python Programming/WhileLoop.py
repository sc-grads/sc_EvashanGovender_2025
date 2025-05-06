import time
from operator import truediv

connected : bool = True
while connected:
    print("Using internet...")
    time.sleep(5)
    connected = False
print("Connection ended...")