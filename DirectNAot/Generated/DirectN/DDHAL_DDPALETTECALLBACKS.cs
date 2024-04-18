namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDHAL_DDPALETTECALLBACKS
{
    public uint dwSize;
    public uint dwFlags;
    public nint DestroyPalette;
    public nint SetEntries;
}
