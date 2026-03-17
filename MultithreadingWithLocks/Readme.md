In C# / .NET, there are multiple locking and synchronization mechanisms used to make code thread-safe. These are critical in multi-threaded environments like ASP.NET, background workers, parallel tasks, etc.

1. lock Statement (Most Common)
lock is the simplest and most common mechanism for protecting shared resources.
Internally it uses Monitor.

How it works
1. Thread enters lock
2. Other threads wait
3. When thread exits → lock released

Important rules

✔ Lock private + readonly object only
✔ Never lock string or public objects
