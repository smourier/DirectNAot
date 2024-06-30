#nullable enable
namespace DirectN;

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
