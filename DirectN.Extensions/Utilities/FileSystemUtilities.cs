namespace DirectN.Extensions.Utilities;

public static class FileSystemUtilities
{
    public const int DefaultWrapSharingViolationsRetryCount = 10;
    public const int DefaultWrapSharingViolationsWaitTime = 100;

    public static void WrapSharingViolations(
        Action action,
        Func<IOException, int, bool>? exceptionsCallback = null,
        int maxRetryCount = DefaultWrapSharingViolationsRetryCount,
        int waitTime = DefaultWrapSharingViolationsWaitTime)
    {
        ArgumentNullException.ThrowIfNull(action);
        for (var i = 0; i < maxRetryCount; i++)
        {
            try
            {
                action();
                return;
            }
            catch (IOException ioe)
            {
                if (IsSharingViolation(ioe) && i < maxRetryCount)
                {
                    if (exceptionsCallback != null)
                    {
                        if (!exceptionsCallback(ioe, i))
                            return;
                    }
                    else
                    {
                        Thread.Sleep(waitTime);
                    }
                }
                else
                {
                    throw;
                }
            }
        }
    }

    public static async Task WrapSharingViolations(
        Func<Task> action,
        Func<IOException, int, bool>? exceptionsCallback = null,
        int maxRetryCount = DefaultWrapSharingViolationsRetryCount,
        int waitTime = DefaultWrapSharingViolationsWaitTime)
    {
        ArgumentNullException.ThrowIfNull(action);
        for (var i = 0; i < maxRetryCount; i++)
        {
            try
            {
                await action();
                return;
            }
            catch (IOException ioe)
            {
                if (IsSharingViolation(ioe) && i < maxRetryCount)
                {
                    if (exceptionsCallback != null)
                    {
                        if (!exceptionsCallback(ioe, i))
                            return;
                    }
                    else
                    {
                        await Task.Delay(waitTime);
                    }
                }
                else
                {
                    throw;
                }
            }
        }
    }

    public static async Task WrapSharingViolations(
        Func<Task> action,
        Func<IOException, int, Task<bool>>? exceptionsCallback = null,
        int maxRetryCount = DefaultWrapSharingViolationsRetryCount,
        int waitTime = DefaultWrapSharingViolationsWaitTime)
    {
        ArgumentNullException.ThrowIfNull(action);
        for (var i = 0; i < maxRetryCount; i++)
        {
            try
            {
                await action();
                return;
            }
            catch (IOException ioe)
            {
                if (IsSharingViolation(ioe) && i < maxRetryCount)
                {
                    if (exceptionsCallback != null)
                    {
                        if (!await exceptionsCallback(ioe, i))
                            return;
                    }
                    else
                    {
                        await Task.Delay(waitTime);
                    }
                }
                else
                {
                    throw;
                }
            }
        }
    }

    public static T? WrapSharingViolations<T>(
        Func<T> func,
        Func<IOException, int, (bool, T?)>? exceptionsCallback = null, int maxRetryCount = DefaultWrapSharingViolationsRetryCount,
        int waitTime = DefaultWrapSharingViolationsWaitTime)
    {
        ArgumentNullException.ThrowIfNull(func);
        for (var i = 0; i < maxRetryCount; i++)
        {
            try
            {
                return func();
            }
            catch (IOException ioe)
            {
                if (IsSharingViolation(ioe) && i < maxRetryCount)
                {
                    if (exceptionsCallback != null)
                    {
                        var x = exceptionsCallback(ioe, i);
                        if (!x.Item1)
                            return x.Item2;
                    }
                    else
                    {
                        Thread.Sleep(waitTime);
                    }
                }
                else
                {
                    throw;
                }
            }
        }
        return default;
    }

    public static async Task<T?> WrapSharingViolations<T>(
        Func<Task<T>> func,
        Func<IOException, int, Task<(bool, T?)>>? exceptionsCallback = null,
        int maxRetryCount = DefaultWrapSharingViolationsRetryCount,
        int waitTime = DefaultWrapSharingViolationsWaitTime)
    {
        ArgumentNullException.ThrowIfNull(func);
        for (var i = 0; i < maxRetryCount; i++)
        {
            try
            {
                var ret = await func();
                return ret;
            }
            catch (IOException ioe)
            {
                if (IsSharingViolation(ioe) && i < maxRetryCount)
                {
                    if (exceptionsCallback != null)
                    {
                        var x = await exceptionsCallback(ioe, i);
                        if (!x.Item1)
                            return x.Item2;
                    }
                    else
                    {
                        await Task.Delay(waitTime);
                    }
                }
                else
                {
                    throw;
                }
            }
        }
        return default;
    }

    public static bool IsSharingViolation(IOException exception)
    {
        if (exception == null)
            return false;

        const int ERROR_SHARING_VIOLATION = unchecked((int)0x80070020);
        return exception.HResult == ERROR_SHARING_VIOLATION;
    }
}
