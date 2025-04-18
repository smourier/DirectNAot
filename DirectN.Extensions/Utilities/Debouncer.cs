namespace DirectN.Extensions.Utilities;

public sealed class Debouncer : IDisposable
{
    private ConcurrentDictionary<string, DebouncedAction> _debouncedActions = new();

    public bool FlushOnDispose { get; set; } = true;

    // dueTime = 0 do it if was requested before ("flush if any")
    // duetime = -1 do it anyway
    public void Debounce(Action action, int dueTime, [CallerMemberName] string? actionKey = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        ArgumentNullException.ThrowIfNull(actionKey);

        if (dueTime <= 0)
        {
            if (_debouncedActions.TryRemove(actionKey, out var t))
            {
                t.Dispose();
            }
            else if (dueTime == 0)
                return;

            action();
            return;
        }

        if (!_debouncedActions.TryGetValue(actionKey, out var debouncedAction))
        {
            debouncedAction = new DebouncedAction(action, new Timer(state =>
            {
                if (_debouncedActions.TryRemove(actionKey, out var a))
                {
                    a.Dispose();
                }
                action();
            }, null, Timeout.Infinite, Timeout.Infinite));
            debouncedAction = _debouncedActions.AddOrUpdate(actionKey, debouncedAction, (k, o) =>
            {
                // clear the old one
                o.Dispose();
                return debouncedAction;
            });
        }
        debouncedAction.Change(dueTime);
    }

    public void Cancel() => Finish(false);
    public void Flush() => Finish(true);
    public void Dispose() => Finish(FlushOnDispose);
    private void Finish(bool invoke)
    {
        var debouncedActions = Interlocked.Exchange(ref _debouncedActions, new());
        foreach (var debouncedAction in debouncedActions)
        {
            if (invoke)
            {
                debouncedAction.Value.Action.Invoke();
            }
            debouncedAction.Value.Dispose();
        }
    }

    private readonly struct DebouncedAction(Action action, Timer timer)
    {
        public Action Action { get; } = action;

        public void Change(int dueTime)
        {
            try
            {
                timer.Change(dueTime, Timeout.Infinite);
            }
            catch
            {
                // continue;
            }
        }

        public void Dispose()
        {
            try
            {
                timer.Dispose();
            }
            catch
            {
                // continue;
            }
        }
    }
}
