Multithreading = Multithreading means running multiple sequences of instructions (threads) at the same time inside a single process. The goal is to utilize multiple CPU cores for parallel work

Problem	                            Solution via Multithreading
Slow operations (DB/API calls)	    Run in parallel
UI freezing	                        Run work in background
CPU heavy tasks	                    Use multiple cores


A Thread is the smallest unit of execution in a process.
Types:
1. Foreground Thread
    - Keeps app alive

2. Background Thread
    - Stops when main thread ends

Problem with raw Threads
    - Manual management
    - No pooling
    - Hard error handling
    - Expensive creation