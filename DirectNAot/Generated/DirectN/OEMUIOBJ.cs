namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct OEMUIOBJ
{
    public uint cbSize;
    public nint pOemUIProcs;
}
