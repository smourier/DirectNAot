namespace DirectN.Extensions.Utilities;

public sealed class ClrHost : InterlockedComObject<ICLRMetaHost>
{
    public ClrHost()
    {
        Functions.CLRCreateInstance(Constants.CLSID_CLRMetaHost, typeof(ICLRMetaHost).GUID, out var unk).ThrowOnError();
        ExchangeDisposable(Com.ComObject.FromPointer<ICLRMetaHost>(unk));
    }

    public HRESULT ExitProcess(int exitCode, bool throwOnError = true) => ComObject.Object.ExitProcess(exitCode).ThrowOnError(throwOnError);

    public string? GetVersionFromFile(string filePath, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(filePath);
        uint size = 0;
        ComObject.Object.GetVersionFromFile(PWSTR.From(filePath), PWSTR.Null, ref size).ThrowOnError(throwOnError);
        if (size == 0)
            return null;

        using var pwstr = AllocPwstr.FromSizeInChars(size);
        ComObject.Object.GetVersionFromFile(PWSTR.From(filePath), pwstr, ref size).ThrowOnError(throwOnError);
        if (size == 0)
            return null;

        return pwstr.ToString();
    }

    public void RequestRuntimeLoadedNotification(RuntimeLoadedCallbackFnPtr callback, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(callback);
        ComObject.Object.RequestRuntimeLoadedNotification(callback).ThrowOnError(throwOnError);
    }

    public ClrRuntime? GetRuntime(string version, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(version);
        ComObject.Object.GetRuntime(PWSTR.From(version), typeof(ICLRRuntimeInfo).GUID, out var unk).ThrowOnError(throwOnError);
        var obj = Com.ComObject.FromPointer<ICLRRuntimeInfo>(unk);
        return obj != null ? new ClrRuntime(obj) : null;
    }

    private unsafe static List<ClrRuntime> AddRuntimes(IEnumUnknown? enumObj)
    {
        var list = new List<ClrRuntime>();
        if (enumObj != null)
        {
            using var enumComObject = new ComObject<IEnumUnknown>(enumObj);
            var fetched = 0u;
            var unks = new nint[1];
            do
            {
                enumComObject.Object.Next(1, unks, (nint)(&fetched));
                if (fetched > 0)
                {
                    var obj = Com.ComObject.FromPointer<ICLRRuntimeInfo>(unks[0]);
                    if (obj != null)
                    {
                        list.Add(new ClrRuntime(obj));
                    }
                }
            }
            while (fetched > 0);
        }
        return list;
    }

    public IReadOnlyList<ClrRuntime> EnumerateInstalledRuntimes(bool throwOnError = true)
    {
        ComObject.Object.EnumerateInstalledRuntimes(out var enumObj).ThrowOnError(throwOnError);
        return AddRuntimes(enumObj);
    }

    public IReadOnlyList<ClrRuntime> EnumerateLoadedRuntimes(Process process, bool throwOnError = true)
    {
        ArgumentNullException.ThrowIfNull(process);
        return EnumerateLoadedRuntimes(process.Id, throwOnError);
    }

    public IReadOnlyList<ClrRuntime> EnumerateLoadedRuntimes(int processId, bool throwOnError = true)
    {
        var processHandle = Functions.OpenProcess(PROCESS_ACCESS_RIGHTS.PROCESS_QUERY_INFORMATION, false, (uint)processId);
        if (processHandle == HANDLE.Null || processHandle == HANDLE.Invalid)
            throw new Win32Exception();

        try
        {
            return EnumerateLoadedRuntimes(processHandle, throwOnError);
        }
        finally
        {
            Functions.CloseHandle(processHandle);
        }
    }

    public IReadOnlyList<ClrRuntime> EnumerateLoadedRuntimes(HANDLE processHandle, bool throwOnError = true)
    {
        ComObject.Object.EnumerateLoadedRuntimes(processHandle, out var enumObj).ThrowOnError(throwOnError);
        return AddRuntimes(enumObj);
    }
}
