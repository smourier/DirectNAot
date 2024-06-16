#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCFXAec
{
    public BOOL fEnable;
    public BOOL fNoiseFill;
    public uint dwMode;
}
