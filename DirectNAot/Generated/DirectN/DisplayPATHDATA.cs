namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-pathdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DisplayPATHDATA
{
    public uint flags;
    public uint count;
    public nint pptfx;
}
