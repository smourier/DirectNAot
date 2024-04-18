namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DDVIDEOPORTCONNECT
{
    public uint dwSize;
    public uint dwPortWidth;
    public Guid guidTypeID;
    public uint dwFlags;
    public nuint dwReserved1;
}
