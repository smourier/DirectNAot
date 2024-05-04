#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DSCEFFECTDESC
{
    public uint dwSize;
    public uint dwFlags;
    public Guid guidDSCFXClass;
    public Guid guidDSCFXInstance;
    public uint dwReserved1;
    public uint dwReserved2;
}
