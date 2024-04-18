namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EMRNAMEDESCAPE
{
    public EMR emr;
    public int iEscape;
    public int cbDriver;
    public int cbEscData;
    public InlineArrayByte1 EscData; // variable-length array placeholder
}
