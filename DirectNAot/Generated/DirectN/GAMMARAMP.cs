namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-gammaramp
[StructLayout(LayoutKind.Sequential)]
public partial struct GAMMARAMP
{
    public InlineArrayUInt16256 Red;
    public InlineArrayUInt16256 Green;
    public InlineArrayUInt16256 Blue;
}
