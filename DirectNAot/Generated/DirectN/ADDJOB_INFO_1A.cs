namespace DirectN;

// https://learn.microsoft.com/windows/win32/printdocs/addjob-info-1
[StructLayout(LayoutKind.Sequential)]
public partial struct ADDJOB_INFO_1A
{
    public PSTR Path;
    public uint JobId;
}
