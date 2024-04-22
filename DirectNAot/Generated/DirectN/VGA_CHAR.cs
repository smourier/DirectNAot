namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct VGA_CHAR
{
    public CHAR Char;
    public CHAR Attributes;
}
