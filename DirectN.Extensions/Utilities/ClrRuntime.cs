namespace DirectN.Extensions.Utilities;

public sealed class ClrRuntime(IComObject<ICLRRuntimeInfo>? comObject)
    : InterlockedComObject<ICLRRuntimeInfo>(comObject)
{
    public string? Version
    {
        get
        {
            uint size = 0;
            ComObject.Object.GetVersionString(PWSTR.Null, ref size);
            if (size == 0)
                return null;

            using var pwstr = AllocPwstr.FromSizeInChars(size);
            if (ComObject.Object.GetVersionString(pwstr, ref size).IsError)
                return null;

            return pwstr.ToString();
        }
    }

    public string? Directory
    {
        get
        {
            uint size = 0;
            ComObject.Object.GetRuntimeDirectory(PWSTR.Null, ref size);
            if (size == 0)
                return null;

            using var pwstr = AllocPwstr.FromSizeInChars(size);
            if (ComObject.Object.GetRuntimeDirectory(pwstr, ref size).IsError)
                return null;

            return pwstr.ToString();
        }
    }

    public STARTUP_FLAGS DefaultStartupFlags
    {
        get
        {
            uint size = 0;
            ComObject.Object.GetDefaultStartupFlags(out var flags, PWSTR.Null, ref size);
            return (STARTUP_FLAGS)flags;
        }
    }

    public STARTUP_FLAGS? IsStarted
    {
        get
        {
            if (ComObject.Object.IsStarted(out var started, out var flags).IsError)
                return null;

            if (started == 0)
                return null;

            return (STARTUP_FLAGS)flags;
        }
    }

    public string? DefaultHostConfigurationFile
    {
        get
        {
            uint size = 0;
            ComObject.Object.GetDefaultStartupFlags(out _, PWSTR.Null, ref size);
            if (size == 0)
                return null;

            using var pwstr = AllocPwstr.FromSizeInChars(size);
            if (ComObject.Object.GetDefaultStartupFlags(out _, pwstr, ref size).IsError)
                return null;

            return pwstr.ToString();
        }
    }

    public bool IsLoaded => IsLoadedByProcess(Environment.ProcessId);
    public bool IsLoadable
    {
        get
        {
            if (ComObject.Object.IsLoadable(out var loadable).IsError)
                return false;

            return loadable != 0;
        }
    }

    public ClrRuntimeHost GetHost() => new ClrRuntimeHost(GetInterface<ICLRRuntimeHost>(Constants.CLSID_CLRRuntimeHost));

    public IComObject<T>? GetInterface<T>(Guid clsid, CreateObjectFlags flags = CreateObjectFlags.UniqueInstance, bool releaseOnDispose = true)
    {
        ComObject.Object.GetInterface(in clsid, typeof(T).GUID, out var ptr);
        if (ptr == 0)
            return default;

        return Com.ComObject.FromPointer<T>(ptr, flags, releaseOnDispose);
    }

    public nint GetInterface(Guid clsid, Guid iid, bool throwOnError = true)
    {
        ComObject.Object.GetInterface(in clsid, in iid, out var ptr).ThrowOnError(throwOnError);
        return ptr;
    }

    public nint GetProcAddress(string procName, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(procName);
        ComObject.Object.GetProcAddress(PSTR.From(procName), out var ptr).ThrowOnError(throwOnError);
        return ptr;
    }

    public HMODULE LoadLibrary(string dllName, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(dllName);
        ComObject.Object.LoadLibraryA(PWSTR.From(dllName), out var module).ThrowOnError(throwOnError);
        return module;
    }

    public bool IsLoadedByProcess(Process process)
    {
        ArgumentNullException.ThrowIfNull(process);
        return IsLoadedByProcess(process.Id);
    }

    public bool IsLoadedByProcess(HANDLE processHandle)
    {
        if (ComObject.Object.IsLoaded(processHandle, out var loaded).IsError)
            return false;

        return loaded != 0;
    }

    public bool IsLoadedByProcess(int processId)
    {
        var processHandle = Functions.OpenProcess(PROCESS_ACCESS_RIGHTS.PROCESS_QUERY_INFORMATION, false, (uint)processId);
        if (processHandle == HANDLE.Null || processHandle == HANDLE.Invalid)
            throw new Win32Exception();

        try
        {
            return IsLoadedByProcess(processHandle);
        }
        finally
        {
            Functions.CloseHandle(processHandle);
        }
    }

    public string? LoadErrorString(int resourceId, int localId, bool throwOnError = true)
    {
        uint size = 0;
        ComObject.Object.LoadErrorString((uint)resourceId, PWSTR.Null, ref size, localId).ThrowOnError(throwOnError);
        if (size == 0)
            return null;

        using var pwstr = AllocPwstr.FromSizeInChars(size);
        var hr = ComObject.Object.LoadErrorString((uint)resourceId, pwstr, ref size, localId).ThrowOnError(throwOnError);
        if (hr.IsError)
            return null;

        return pwstr.ToString();
    }

    public void SetDefaultStartupFlags(STARTUP_FLAGS flags, string hostConfigurationFile, bool throwOnError = true) =>
        ComObject.Object.SetDefaultStartupFlags((uint)flags, PWSTR.From(hostConfigurationFile)).ThrowOnError(throwOnError);
}
