#nullable enable
namespace DirectN;

public partial struct DetectedFaceBound
{
    public uint sizeInBytes;
    public float normalizedXPosition;
    public float normalizedYPosition;
    public float normalizedWidth;
    public float normalizedHeight;
    public int confidenceValue;
    public ulong flags;
}
