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
}
