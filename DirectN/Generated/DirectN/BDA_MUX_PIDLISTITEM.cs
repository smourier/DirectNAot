#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct BDA_MUX_PIDLISTITEM
{
    public ushort usPIDNumber;
    public ushort usProgramNumber;
    public MUX_PID_TYPE ePIDType;
}
