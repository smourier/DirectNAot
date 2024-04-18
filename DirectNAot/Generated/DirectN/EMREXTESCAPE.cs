namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EMREXTESCAPE
{
    public EMR emr;
    public int iEscape;
    public int cbEscData;
    public InlineArrayByte1 EscData; // variable-length array placeholder
}
