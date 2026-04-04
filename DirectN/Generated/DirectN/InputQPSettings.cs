#nullable enable
namespace DirectN;

public partial struct InputQPSettings
{
    public uint minBlockSize;
    public uint maxBlockSize;
    public uint stepsBlockSize;
    public eAVEncVideoQPMapElementDataType dataType;
    public short minValue;
    public short maxValue;
    public ushort step;
}
