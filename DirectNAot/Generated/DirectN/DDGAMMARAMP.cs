namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/ns-ddraw-ddgammaramp
[StructLayout(LayoutKind.Sequential)]
public partial struct DDGAMMARAMP
{
    public InlineArrayUInt16256 red;
    public InlineArrayUInt16256 green;
    public InlineArrayUInt16256 blue;
}
