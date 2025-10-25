namespace DirectN.Extensions.Utilities;

public static class TaskUtilities
{
    public static async void Forget(this Task task, params Type[] acceptableExceptions)
    {
        if (task == null)
            return;

        try
        {
            await task.ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            if (acceptableExceptions == null || acceptableExceptions.Length == 0)
                throw;

            foreach (var ae in acceptableExceptions)
            {
                if (ae.IsAssignableFrom(ex.GetType()))
                    return;
            }
            throw;
        }
    }

    public static Task<T> RunWithNewSTAThread<T>(Func<T> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        var tcs = new TaskCompletionSource<T>();
        var thread = new Thread(() =>
        {
            try
            {
                tcs.SetResult(func());
            }
            catch (Exception e)
            {
                tcs.SetException(e);
            }
        });

        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        return tcs.Task;
    }

    public static Task<T> RunWithNewSTAThread<T>(Func<Task<T>> func)
    {
        ArgumentNullException.ThrowIfNull(func);
        var tcs = new TaskCompletionSource<T>();
        var thread = new Thread(async () =>
        {
            try
            {
                var item = await func();
                tcs.SetResult(item);
            }
            catch (Exception e)
            {
                tcs.SetException(e);
            }
        });

        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();
        return tcs.Task;
    }

    public static Task<T> RunWithSTAThread<T>(Func<T> func, bool startNew = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (startNew || Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            return RunWithNewSTAThread(func);

        return Task.FromResult(func());
    }

    public static async Task<T> RunWithSTAThread<T>(Func<Task<T>> func, bool startNew = false)
    {
        ArgumentNullException.ThrowIfNull(func);
        if (startNew || Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            return await RunWithNewSTAThread(func);

        return await func();
    }

    public static Task RunWithNewSTAThread(Action action)
    {
        ArgumentNullException.ThrowIfNull(action);
        return RunWithNewSTAThread(() =>
        {
            action();
            return true;
        });
    }

    public static Task RunWithSTAThread(Action action, bool startNew = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (startNew || Thread.CurrentThread.GetApartmentState() != ApartmentState.STA)
            return RunWithNewSTAThread(action);

        action();
        return Task.CompletedTask;
    }

    // https://stackoverflow.com/a/55709530/403671
    // returns true if the call went to completion successfully, false otherwise
    public static bool RunWithAbort(this Action action, int milliseconds) => RunWithAbort(action, new TimeSpan(0, 0, 0, 0, milliseconds));
    public static bool RunWithAbort(this Action action, TimeSpan delay)
    {
        ArgumentNullException.ThrowIfNull(action);
        using var source = new CancellationTokenSource(delay);
        var success = false;
        HANDLE handle = 0;
        uint fn(nint ptr)
        {
            using (source.Token.Register(() => Functions.TerminateThread(handle, 0)))
            {
                action();
                success = true;
            }
            return 0u;
        }

        handle = Functions.CreateThread(0, 0, fn, 0, 0, 0);
        Functions.WaitForSingleObject(handle, (uint)(20 + delay.TotalMilliseconds));
        Functions.CloseHandle(handle);
        return success;
    }

    // returns what's the function should return if the call went to completion successfully, default(T) otherwise
    public static T? RunWithAbort<T>(this Func<T> func, int milliseconds) => RunWithAbort(func, new TimeSpan(0, 0, 0, 0, milliseconds));
    public static T? RunWithAbort<T>(this Func<T> func, TimeSpan delay)
    {
        ArgumentNullException.ThrowIfNull(func);
        using var source = new CancellationTokenSource(delay);
        var item = default(T);
        HANDLE handle = 0;
        uint fn(nint ptr)
        {
            using (source.Token.Register(() => Functions.TerminateThread(handle, 0)))
            {
                item = func();
            }
            return 0u;
        }

        handle = Functions.CreateThread(0, 0, fn, 0, 0, 0);
        Functions.WaitForSingleObject(handle, (uint)(20 + delay.TotalMilliseconds));
        Functions.CloseHandle(handle);
        return item;
    }

    // returns true if the call went to completion successfully, false otherwise
    public static Task<bool> RunWithAbortAsync(this Action action, CancellationToken token)
    {
        ArgumentNullException.ThrowIfNull(action);
        var source = new TaskCompletionSource<bool>();
        HANDLE handle = 0;
        uint fn(nint ptr)
        {
            using (token.Register(() =>
            {
                source.SetResult(false);
                Functions.TerminateThread(handle, 0);
                Functions.CloseHandle(handle);
            }))
            {
                try
                {
                    action();
                    source.SetResult(true);
                }
                catch (Exception ex)
                {
                    source.SetException(ex);
                }
            }
            return 0u;
        }

        handle = Functions.CreateThread(0, 0, fn, 0, 0, 0);
        return source.Task;
    }

    // returns what's the function should return if the call went to completion successfully, default(T) otherwise
    // cancelled can be used to provide a specific value (progress for example) when the operation is cancelled
    public static Task<T?> RunWithAbortAsync<T>(this Func<T> func, CancellationToken token, Func<T?>? cancelled = null)
    {
        ArgumentNullException.ThrowIfNull(func);
        var source = new TaskCompletionSource<T?>();
        HANDLE handle = 0;
        uint fn(nint ptr)
        {
            using (token.Register(() =>
            {
                var result = cancelled != null ? cancelled() : default;
                source.SetResult(result);
                Functions.TerminateThread(handle, 0);
                Functions.CloseHandle(handle);
            }))
            {
                try
                {
                    var result = func();
                    source.SetResult(result);
                }
                catch (Exception ex)
                {
                    source.SetException(ex);
                }
            }
            return 0u;
        }

        handle = Functions.CreateThread(0, 0, fn, 0, 0, 0);
        return source.Task;
    }
}
