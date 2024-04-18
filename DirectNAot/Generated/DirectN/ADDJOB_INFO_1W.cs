namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/addjob-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct ADDJOB_INFO_1W
{
    public PWSTR Path;
    public uint JobId;
}
