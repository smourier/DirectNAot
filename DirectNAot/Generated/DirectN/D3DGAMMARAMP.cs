namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3dgammaramp
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DGAMMARAMP
{
    public InlineArrayUInt16256 red;
    public InlineArrayUInt16256 green;
    public InlineArrayUInt16256 blue;
}
