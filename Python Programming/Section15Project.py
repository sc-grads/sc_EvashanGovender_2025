from datetime import datetime
import asyncio
from asyncio import Future, gather

import requests
from requests import  Response

async def check_status(url: str) -> dict[str, int|str]:
    print("Fetching Results:")
    start_time: datetime = datetime.now()
    response: Response = await asyncio.to_thread(requests.get(),url,None)
    end_time: datetime = datetime.now()

    return {'status':response.status_code,
            'Start Time': f'{start_time:%H:%M:%S}',
            'End Time': f'{end_time:%H:%M:%S}',}

async def main() -> None:
    tasks: Future = asyncio.gather(check_status('https://bing.com'),
                                 check_status('https://google.com'))


    results: list[dict[str, int|str]] = await tasks
    for result in results:
        print(result)

if __name__ == '__main__':
    asyncio.run(main())