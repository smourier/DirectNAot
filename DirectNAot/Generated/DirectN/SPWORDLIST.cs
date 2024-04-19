namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPWORDLIST
{
    public uint ulSize;
    public nint pvBuffer;
    public nint pFirstWord;
}
