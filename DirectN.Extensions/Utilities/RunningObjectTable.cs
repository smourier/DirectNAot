namespace DirectN.Extensions.Utilities;

public static partial class RunningObjectTable
{
    public static HRESULT Register(CommandTarget commandTarget, out uint cookie, ROT_FLAGS flags = ROT_FLAGS.ROTFLAGS_REGISTRATIONKEEPSALIVE, bool throwOnError = true)
    {
        cookie = 0;
        var hr = Functions.GetRunningObjectTable(0, out var tablePtr).ThrowOnError(throwOnError);
        if (tablePtr == null)
            return hr;

        using var table = new ComObject<IRunningObjectTable>(tablePtr);
        var moniker = commandTarget.Moniker + ":" + SystemUtilities.CurrentProcess.Id;
        using var d = new Pwstr(CommandTarget.Delimiter);
        using var m = new Pwstr(moniker);
        hr = Functions.CreateItemMoniker(d, m, out var mkPtr).ThrowOnError(throwOnError);
        if (mkPtr == null)
            return hr;

        using var mk = new ComObject<IMoniker>(mkPtr);
        var unk = ComObject.GetOrCreateComInstance(commandTarget);
        return table.Object.Register(flags, unk, mk.Object, out cookie).ThrowOnError(throwOnError);
    }

    public static HRESULT Revoke(uint cookie, bool throwOnError = true)
    {
        var hr = Functions.GetRunningObjectTable(0, out var tablePtr).ThrowOnError(throwOnError);
        if (tablePtr == null)
            return hr;

        using var table = new ComObject<IRunningObjectTable>(tablePtr);
        return table.Object.Revoke(cookie).ThrowOnError(false);
    }

    public static nint GetObject(string itemName, string? delimiter = null, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(itemName);

        delimiter = delimiter.Nullify() ?? "!";
        using var d = new Pwstr(delimiter);
        using var n = new Pwstr(itemName);
        Functions.CreateItemMoniker(d, n, out var mkPtr).ThrowOnError(throwOnError);
        if (mkPtr == null)
            return 0;

        using var mk = new ComObject<IMoniker>(mkPtr);
        if (mk == null)
            return 0;

        Functions.GetRunningObjectTable(0, out var tablePtr).ThrowOnError(throwOnError);
        if (tablePtr == null)
            return 0;

        using var table = new ComObject<IRunningObjectTable>(tablePtr);
        table.Object.GetObject(mk.Object, out var unk).ThrowOnError(throwOnError);
        return unk;
    }

    public static nint GetObject(IMoniker moniker, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(moniker);
        Functions.GetRunningObjectTable(0, out var tablePtr).ThrowOnError(throwOnError);
        if (tablePtr == null)
            return 0;

        using var table = new ComObject<IRunningObjectTable>(tablePtr);
        table.Object.GetObject(moniker, out var unk).ThrowOnError(throwOnError);
        return unk;
    }

    public static IEnumerable<IComObject<IMoniker>> Enumerate(bool throwOnError = true)
    {
        Functions.GetRunningObjectTable(0, out var tablePtr).ThrowOnError(throwOnError);
        if (tablePtr == null)
            yield break;

        using var table = new ComObject<IRunningObjectTable>(tablePtr);
        table.Object.EnumRunning(out var enumeratorPtr).ThrowOnError(throwOnError);
        if (enumeratorPtr == null)
            yield break;

        using var enumerator = new ComObject<IEnumMoniker>(enumeratorPtr);
        var mks = new nint[1];
        do
        {
            if (enumerator.Object.Next(1, mks, nint.Zero) != 0)
                break;

            var mk = mks[0];
            var m = ComObject.FromPointer<IMoniker>(mk);
            if (m != null)
                yield return m; // caller will have to call dispose
        }
        while (true);
    }
}
