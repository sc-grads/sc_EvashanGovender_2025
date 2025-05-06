import time
def connect_to_internet(signal: bool, delay: int):
    if delay > 5:
        signal = True

    if signal:
        print('Connected')
    else:
        print(f'Connection failed. Trying again in: {delay} seconds..')
        time.sleep(delay)
        connect_to_internet(signal, delay+2)

connect_to_internet(False, 0)