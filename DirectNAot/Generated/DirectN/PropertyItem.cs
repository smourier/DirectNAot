namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PropertyItem
{
    public uint id;
    public uint length;
    public ushort type;
    public nint value;
}
