namespace DirectN.Extensions.Utilities;

public static partial class RunningObjectTable
{
    public static HRESULT Register(CommandTarget commandTarget, out uint cookie, ROT_FLAGS flags = ROT_FLAGS.ROTFLAGS_REGISTRATIONKEEPSALIVE, bool throwOnError = true)
    {
        cookie = 0;
        var hr = Functions.GetRunningObjectTable(0, out var table).ThrowOnError(throwOnError);
        if (hr.IsError)
            return hr;

        var moniker = commandTarget.Moniker + ":" + SystemUtilities.CurrentProcess.Id;
        using var d = new Pwstr(CommandTarget.Delimiter);
        using var m = new Pwstr(moniker);
        hr = Functions.CreateItemMoniker(d, m, out var mk).ThrowOnError(throwOnError);
        if (hr.IsError)
            return hr;

        var unk = ComObject.GetOrCreateComInstance(commandTarget);
        return table.Register(flags, unk, mk, out cookie).ThrowOnError(throwOnError);
    }

    public static HRESULT Revoke(uint cookie, bool throwOnError = true)
    {
        var hr = Functions.GetRunningObjectTable(0, out var table).ThrowOnError(throwOnError);
        if (hr.IsError)
            return hr;

        return table.Revoke(cookie).ThrowOnError(false);
    }

    public static nint GetObject(string itemName, string? delimiter = null, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(itemName);

        delimiter = delimiter.Nullify() ?? "!";
        using var d = new Pwstr(delimiter);
        using var n = new Pwstr(itemName);
        var hr = Functions.CreateItemMoniker(d, n, out var mk).ThrowOnError(throwOnError);
        if (hr.IsError)
            return 0;

        if (mk == null)
            return 0;

        hr = Functions.GetRunningObjectTable(0, out var table).ThrowOnError(throwOnError);
        if (hr.IsError)
            return 0;

        if (table == null)
            return 0;

        hr = table.GetObject(mk, out var unk).ThrowOnError(throwOnError);
        if (hr.IsError)
            return 0;

        return unk;
    }

    public static nint GetObject(IMoniker moniker, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(moniker);
        var hr = Functions.GetRunningObjectTable(0, out var table).ThrowOnError(throwOnError);
        if (hr.IsError)
            return 0;

        if (table == null)
            return 0;

        hr = table.GetObject(moniker, out var unk).ThrowOnError(throwOnError);
        if (hr.IsError)
            return 0;

        return unk;
    }

    public static IEnumerable<IMoniker> Enumerate(bool throwOnError = true)
    {
        var hr = Functions.GetRunningObjectTable(0, out var table).ThrowOnError(throwOnError);
        if (hr.IsError)
            yield break;

        hr = table.EnumRunning(out var enumerator).ThrowOnError(throwOnError);
        if (hr.IsError || enumerator == null)
            yield break;

        var mks = new IMoniker[1];
        do
        {
            if (enumerator.Next(1, mks, nint.Zero) != 0)
                break;

            var mk = mks[0];
            if (mk != null)
                yield return mk;
        }
        while (true);
    }
}
