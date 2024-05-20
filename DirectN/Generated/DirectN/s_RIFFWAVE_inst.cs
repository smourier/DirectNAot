#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct s_RIFFWAVE_inst
{
    public byte bUnshiftedNote;
    public CHAR chFineTune;
    public CHAR chGain;
    public byte bLowNote;
    public byte bHighNote;
    public byte bLowVelocity;
    public byte bHighVelocity;
}
