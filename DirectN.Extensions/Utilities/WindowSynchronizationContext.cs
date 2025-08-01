﻿namespace DirectN.Extensions.Utilities;

public class WindowSynchronizationContext : SynchronizationContext
{
    public int ManagedThreadId { get; } = Environment.CurrentManagedThreadId;
    public override SynchronizationContext CreateCopy() => new WindowSynchronizationContext();
    public override void Send(SendOrPostCallback d, object? state) => GetWindow()?.RunTaskOnUIThread(() => { d(state); });
    public override void Post(SendOrPostCallback d, object? state) => GetWindow()?.RunTaskOnUIThread(() => { d(state); }, true);

    public static void Install()
    {
        var current = Current;
        if (current is WindowSynchronizationContext)
            return;

        SetSynchronizationContext(new WindowSynchronizationContext());
    }

    private Window? GetWindow()
    {
        var windows = Application.GetApplication(ManagedThreadId)?.Windows;
        if (windows == null || windows.Count == 0)
            return null;

        return windows.FirstOrDefault(w => w.TaskScheduler != null && !w.IsBackground) ?? windows.FirstOrDefault(w => w.TaskScheduler != null);
    }
}
