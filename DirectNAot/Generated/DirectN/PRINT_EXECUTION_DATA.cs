namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/print-execution-data
[StructLayout(LayoutKind.Sequential)]
public partial struct PRINT_EXECUTION_DATA
{
    public PRINT_EXECUTION_CONTEXT context;
    public uint clientAppPID;
}
