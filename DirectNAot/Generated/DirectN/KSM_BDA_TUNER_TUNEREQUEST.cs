namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_TUNER_TUNEREQUEST
{
    public KSIDENTIFIER Method;
    public uint ulTuneLength;
    public InlineArrayByte1 argbTuneData; // variable-length array placeholder
}
