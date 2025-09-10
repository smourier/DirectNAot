namespace DirectN.Extensions.Utilities;

public sealed class ClrRuntimeHost(IComObject<ICLRRuntimeHost>? comObject)
    : InterlockedComObject<ICLRRuntimeHost>(comObject)
{
    public uint CurrentAppDomainId
    {
        get
        {
            ComObject.Object.GetCurrentAppDomainId(out var id).ThrowOnError();
            return id;
        }
    }

    public override string ToString() => $"CLR Runtime Host (AppDomainId={CurrentAppDomainId})";

    public HRESULT Start(bool throwOnError = true) => ComObject.Object.Start().ThrowOnError(throwOnError);
    public HRESULT Stop(bool throwOnError = true) => ComObject.Object.Stop().ThrowOnError(throwOnError);
    public HRESULT UnloadAppDomain(uint appDomainId, bool waitUntilDone, bool throwOnError = true) => ComObject.Object.UnloadAppDomain(appDomainId, waitUntilDone ? 1 : 0).ThrowOnError(throwOnError);

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            ComObject.Object.Stop();
        }
        base.Dispose(disposing);
    }

    public ClrControl? GetCLRControl(bool throwOnError = true)
    {
        ComObject.Object.GetCLRControl(out var clrControl).ThrowOnError(throwOnError);
        return clrControl != null ? new ClrControl(new ComObject<ICLRControl>(clrControl)) : null;
    }

    public unsafe int ExecuteApplication(string appFullName, IEnumerable<string> manifestPaths, IEnumerable<string> activationDatas, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(appFullName);
        var pathsStringsArray = manifestPaths?.ToArray() ?? [];
        var activationsStingsArray = activationDatas?.ToArray() ?? [];

        Span<PWSTR> paths = stackalloc PWSTR[pathsStringsArray.Length];
        Span<PWSTR> activations = stackalloc PWSTR[activationsStingsArray.Length];

        for (var i = 0; i < pathsStringsArray.Length; i++)
        {
            paths[i] = new Pwstr(pathsStringsArray[i]);
        }

        for (var i = 0; i < activationsStingsArray.Length; i++)
        {
            activations[i] = new Pwstr(activationsStingsArray[i]);
        }

        try
        {
            fixed (PWSTR* pathsPtr = paths)
            {
                fixed (PWSTR* activationsPtr = activations)
                {
                    ComObject.Object.ExecuteApplication(
                        PWSTR.From(appFullName),
                        pathsStringsArray.Length(),
                        new PWSTR((nint)pathsPtr),
                        activationsStingsArray.Length(),
                        new PWSTR((nint)activationsPtr),
                        out var ret).ThrowOnError(throwOnError);
                    return ret;
                }
            }
        }
        finally
        {
            foreach (var p in paths)
            {
                Marshal.FreeCoTaskMem(p.Value);
            }

            foreach (var p in activations)
            {
                Marshal.FreeCoTaskMem(p.Value);
            }
        }
    }

    public HRESULT ExecuteInAppDomain(uint appDomainId, FExecuteInAppDomainCallback callback, nint cookie, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(callback);
        return ComObject.Object.ExecuteInAppDomain(appDomainId, callback, cookie).ThrowOnError(throwOnError);
    }

    public uint ExecuteInDefaultAppDomain(string assemblyPath, string typeName, string methodName, string argument, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(assemblyPath);
        ArgumentNullException.ThrowIfNull(typeName);
        ArgumentNullException.ThrowIfNull(methodName);
        ArgumentNullException.ThrowIfNull(argument);
        ComObject.Object.ExecuteInDefaultAppDomain(PWSTR.From(assemblyPath), PWSTR.From(typeName), PWSTR.From(methodName), PWSTR.From(argument), out var ret).ThrowOnError(throwOnError);
        return ret;
    }

    public HRESULT SetHostControl(IComObject<IHostControl> hostControl, bool throwOnError = true) => SetHostControl(hostControl?.Object!, throwOnError);
    public HRESULT SetHostControl(IHostControl hostControl, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(hostControl);
        return ComObject.Object.SetHostControl(hostControl).ThrowOnError(throwOnError);
    }
}
