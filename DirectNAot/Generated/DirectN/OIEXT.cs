namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OIEXT
{
    public ushort cbSize;
    public ushort Flags;
    public HINSTANCE hInstCaller;
    public nint pHelpFile;
    public InlineArrayUIntPtr4 dwReserved;
}
