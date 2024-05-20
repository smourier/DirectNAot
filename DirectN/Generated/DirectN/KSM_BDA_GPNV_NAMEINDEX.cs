#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_GPNV_NAMEINDEX
{
    public KSIDENTIFIER Method;
    public uint ulValueNameIndex;
}
