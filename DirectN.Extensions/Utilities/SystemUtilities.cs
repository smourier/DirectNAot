namespace DirectN.Extensions.Utilities;

public static class SystemUtilities
{
    private static readonly Lazy<Process> _currentProcess = new(() => Process.GetCurrentProcess(), true);
    public static Process CurrentProcess => _currentProcess.Value;

    [SupportedOSPlatform("windows8.0")]
    private readonly static Lazy<bool> _isPackagedProcess = new(() =>
    {
        try
        {
            uint len = 0;
            var hr = Functions.GetCurrentPackageFullName(ref len, PWSTR.Null);
            return hr != WIN32_ERROR.APPMODEL_ERROR_NO_PACKAGE;
        }
        catch
        {
            return false;
        }
    });

    [SupportedOSPlatform("windows8.0")]
    public static bool IsPackagedProcess => _isPackagedProcess.Value;

    [SupportedOSPlatform("windows8.0")]
    public static string? GetCurrentPackagePath()
    {
        uint size = 0;
        Functions.GetCurrentPackagePath(ref size, PWSTR.Null);
        if (size == 0)
            return null;

        using var pwstr = new AllocPwstr(size * 2);
        Functions.GetCurrentPackagePath(ref size, pwstr);
        return pwstr.ToString();
    }

    [SupportedOSPlatform("windows8.0")]
    public static string? GetCurrentPackageFamilyName()
    {
        uint size = 0;
        Functions.GetCurrentPackageFamilyName(ref size, PWSTR.Null);
        if (size == 0)
            return null;

        using var pwstr = new AllocPwstr(size * 2);
        Functions.GetCurrentPackageFamilyName(ref size, pwstr);
        return pwstr.ToString();
    }

    public static bool IsAppContainer()
    {
        if (!Functions.OpenProcessToken(Functions.GetCurrentProcess(), TOKEN_ACCESS_MASK.TOKEN_QUERY, out var handle))
            return false;

        try
        {
            using var mem = new ComMemory(4);
            Functions.GetTokenInformation(handle, TOKEN_INFORMATION_CLASS.TokenIsAppContainer, mem.Pointer, mem.Size, out _);
            return Marshal.ReadInt32(mem.Pointer) != 0;
        }
        finally
        {
            Functions.CloseHandle(handle);
        }
    }

    public static TokenElevationType GetTokenElevationType()
    {
        var type = TokenElevationType.Unknown;
        if (!Functions.OpenProcessToken(Functions.GetCurrentProcess(), TOKEN_ACCESS_MASK.TOKEN_QUERY, out var handle))
            return type;

        try
        {
            using var mem = new ComMemory(4);
            Functions.GetTokenInformation(handle, TOKEN_INFORMATION_CLASS.TokenElevationType, mem.Pointer, mem.Size, out _);
            return (TokenElevationType)Marshal.ReadInt32(mem.Pointer);
        }
        finally
        {
            Functions.CloseHandle(handle);
        }
    }

    public static ProcessorArchitecture GetProcessorArchitecture()
    {
        Functions.GetNativeSystemInfo(out var si);
        switch (si.Anonymous.Anonymous.wProcessorArchitecture)
        {
            case PROCESSOR_ARCHITECTURE.PROCESSOR_ARCHITECTURE_AMD64:
                return ProcessorArchitecture.Amd64;

            case PROCESSOR_ARCHITECTURE.PROCESSOR_ARCHITECTURE_IA64:
                return ProcessorArchitecture.IA64;

            case PROCESSOR_ARCHITECTURE.PROCESSOR_ARCHITECTURE_INTEL:
                return ProcessorArchitecture.X86;

            default:
                return ProcessorArchitecture.None;
        }
    }

    public static string LoadIndirectString(string source)
    {
        ArgumentNullException.ThrowIfNull(source);
        if (source.Length == 0 || source[0] != '@')
            return source;

        var size = 256;
        do
        {
            using var p = new AllocPwstr(size);
            var hr = Functions.SHLoadIndirectString(PWSTR.From(source), p, p.SizeInChars, IntPtr.Zero);
            if (hr.IsOk)
                return p.ToString() ?? source;

            if (hr != Constants.E_NOT_SUFFICIENT_BUFFER)
                return source;

            size *= 2;
        }
        while (true);
    }
}
