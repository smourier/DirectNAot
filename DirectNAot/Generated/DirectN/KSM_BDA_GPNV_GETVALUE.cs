#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_GPNV_GETVALUE
{
    public KSIDENTIFIER Method;
    public uint ulNameLength;
    public InlineArrayFoundationCHAR_12 cLanguage;
    public InlineArrayByte_1 argbData; // variable-length array placeholder
}
