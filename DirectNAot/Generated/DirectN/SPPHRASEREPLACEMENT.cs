namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASEREPLACEMENT
{
    public byte bDisplayAttributes;
    public PWSTR pszReplacementText;
    public uint ulFirstElement;
    public uint ulCountOfElements;
}
