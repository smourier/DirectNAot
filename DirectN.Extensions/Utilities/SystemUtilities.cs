namespace DirectN.Utilities;

public static class SystemUtilities
{
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

}
