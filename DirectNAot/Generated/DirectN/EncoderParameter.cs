#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EncoderParameter
{
    public Guid Guid;
    public uint NumberOfValues;
    public uint Type;
    public nint Value;
}
