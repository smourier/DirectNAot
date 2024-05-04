#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPPHRASERULE
{
    public PWSTR pszName;
    public uint ulId;
    public uint ulFirstElement;
    public uint ulCountOfElements;
    public nint pNextSibling;
    public nint pFirstChild;
    public float SREngineConfidence;
    public sbyte Confidence;
}
