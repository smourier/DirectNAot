namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct WIDTHTABLE
{
    public uint dwSize;
    public uint dwRunNum;
    public InlineArrayWIDTHRUN1 WidthRun; // variable-length array placeholder
}
