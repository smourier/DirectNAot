#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct FD_LIGATURE
{
    public uint culThis;
    public uint ulType;
    public uint cLigatures;
    public InlineArrayLIGATURE1 alig; // variable-length array placeholder
}
