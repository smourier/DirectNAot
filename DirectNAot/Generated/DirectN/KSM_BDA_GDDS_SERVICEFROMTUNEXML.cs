namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSM_BDA_GDDS_SERVICEFROMTUNEXML
{
    public KSIDENTIFIER Method;
    public uint ulTuneXmlLength;
    public InlineArrayByte1 argbTuneXml; // variable-length array placeholder
}
