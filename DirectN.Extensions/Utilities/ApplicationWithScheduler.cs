namespace DirectN.Extensions.Utilities;

public class ApplicationWithScheduler : Application
{
    public ApplicationWithScheduler()
    {
        Scheduler = CreateApplicationScheduler() ?? throw new InvalidOperationException(nameof(Scheduler));
    }

    public ApplicationScheduler Scheduler { get; }

    public virtual Task RunTaskOnMainThread(Action action, bool startNew = false)
    {
        ArgumentNullException.ThrowIfNull(action);
        if (!startNew && IsRunningAsUIThread)
        {
            action();
            return Task.CompletedTask;
        }

        return Task.Factory.StartNew(action, CancellationToken.None, TaskCreationOptions.None, Scheduler);
    }

    protected virtual ApplicationScheduler CreateApplicationScheduler() => new();
    protected override BOOL GetMessage(out MSG msg, HWND hWnd, uint wMsgFilterMin, uint wMsgFilterMax) => Scheduler.GetMessage(out msg, hWnd, wMsgFilterMin, wMsgFilterMax);
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Scheduler.Dispose();
        }
        base.Dispose(disposing);
    }
}
