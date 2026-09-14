namespace DirectN.Extensions.Utilities;

public sealed class Debouncer : IDisposable
{
    private readonly Lock _sync = new();
    private readonly Dictionary<string, DebouncedAction> _debouncedActions = [];
    public bool FlushOnDispose { get; set; } = true;

    public void Debounce(Action action, int dueTime, [CallerMemberName] string? actionKey = null)
    {
        ArgumentNullException.ThrowIfNull(action);
        ArgumentNullException.ThrowIfNull(actionKey);
        lock (_sync)
        {
            var hadPending = _debouncedActions.Remove(actionKey, out var previous);
            previous?.Timer.Dispose();
            if (dueTime > 0)
            {
                var pending = new DebouncedAction(action);
                pending.Timer = new Timer(_ => Invoke(actionKey, pending), null, Timeout.Infinite, Timeout.Infinite);
                _debouncedActions.Add(actionKey, pending);
                pending.Timer.Change(dueTime, Timeout.Infinite);
                return;
            }

            if (dueTime == 0 && !hadPending)
                return;
        }

        action();
    }

    private void Invoke(string key, DebouncedAction pending)
    {
        lock (_sync)
        {
            if (!_debouncedActions.TryGetValue(key, out var current) || !ReferenceEquals(current, pending))
                return;

            _debouncedActions.Remove(key);
            pending.Timer.Dispose();
        }

        pending.Action();
    }

    public void Cancel() => Finish(false);
    public void Flush() => Finish(true);
    public void Dispose() => Finish(FlushOnDispose);
    private void Finish(bool invoke)
    {
        DebouncedAction[] pending;
        lock (_sync)
        {
            pending = [.. _debouncedActions.Values];
            _debouncedActions.Clear();
            foreach (var item in pending)
            {
                item.Timer.Dispose();
            }
        }

        if (invoke)
        {
            List<Exception>? errors = null;
            foreach (var item in pending)
            {
                try
                {
                    item.Action();
                }
                catch (Exception error)
                {
                    (errors ??= []).Add(error);
                }
            }

            if (errors?.Count == 1)
            {
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(errors[0]).Throw();
            }

            if (errors != null)
                throw new AggregateException(errors);
        }
    }

    private sealed class DebouncedAction(Action action)
    {
        public Action Action { get; } = action;
        public Timer Timer { get; set; } = null!;
    }
}
