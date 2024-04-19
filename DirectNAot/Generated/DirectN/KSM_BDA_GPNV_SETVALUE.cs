namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_GPNV_SETVALUE
{
    public KSIDENTIFIER Method;
    public uint ulDialogRequest;
    public InlineArrayFoundationCHAR12 cLanguage;
    public uint ulNameLength;
    public uint ulValueLength;
    public InlineArrayByte1 argbName; // variable-length array placeholder
}
