namespace DirectN.Extensions.Utilities;

public class WindowSynchronizationContext : SynchronizationContext
{
    private SynchronizationContext? _previous;

    public int ManagedThreadId { get; } = Environment.CurrentManagedThreadId;
    public override SynchronizationContext CreateCopy() => new WindowSynchronizationContext();
    public override void Send(SendOrPostCallback d, object? state) => GetWindow()?.RunTaskOnUIThread(() => { d(state); });
    public override void Post(SendOrPostCallback d, object? state) => GetWindow()?.RunTaskOnUIThread(() => { d(state); }, true);

    public static void Install()
    {
        var current = Current;
        if (current is WindowSynchronizationContext)
            return;

        SetSynchronizationContext(new WindowSynchronizationContext { _previous = current });
    }

    public static void Uninstall()
    {
        if (Current is WindowSynchronizationContext context)
        {
            SetSynchronizationContext(context._previous);
        }
    }

    public static void WithContext(Action action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            Install();
            action();
        }
        finally
        {
            Uninstall();
        }
    }

    public static async Task WithContext(Func<Task> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            Install();
            await action();
        }
        finally
        {
            Uninstall();
        }
    }

    public static T WithContext<T>(Func<T> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            Install();
            return action();
        }
        finally
        {
            Uninstall();
        }
    }

    public static Task<T> WithContext<T>(Func<Task<T>> action)
    {
        ArgumentNullException.ThrowIfNull(action);
        try
        {
            Install();
            return action();
        }
        finally
        {
            Uninstall();
        }
    }

    protected virtual Window? GetWindow()
    {
        var windows = Application.GetApplication(ManagedThreadId)?.Windows;
        if (windows == null || windows.Count == 0)
            return null;

        return windows.FirstOrDefault(w => w.TaskScheduler != null && !w.IsBackground) ?? windows.FirstOrDefault(w => w.TaskScheduler != null);
    }
}
