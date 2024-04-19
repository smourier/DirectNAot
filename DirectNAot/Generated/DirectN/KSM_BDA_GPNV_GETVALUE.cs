namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_GPNV_GETVALUE
{
    public KSIDENTIFIER Method;
    public uint ulNameLength;
    public InlineArrayFoundationCHAR12 cLanguage;
    public InlineArrayByte1 argbData; // variable-length array placeholder
}
