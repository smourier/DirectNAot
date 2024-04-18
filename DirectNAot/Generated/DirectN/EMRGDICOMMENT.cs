namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrgdicomment
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRGDICOMMENT
{
    public EMR emr;
    public uint cbData;
    public InlineArrayByte1 Data; // variable-length array placeholder
}
