#nullable enable
namespace DirectN;

public partial struct VIDEO_HARDWARE_STATE_HEADER
{
    public uint Length;
    public InlineArrayByte_48 PortValue;
    public uint AttribIndexDataState;
    public uint BasicSequencerOffset;
    public uint BasicCrtContOffset;
    public uint BasicGraphContOffset;
    public uint BasicAttribContOffset;
    public uint BasicDacOffset;
    public uint BasicLatchesOffset;
    public uint ExtendedSequencerOffset;
    public uint ExtendedCrtContOffset;
    public uint ExtendedGraphContOffset;
    public uint ExtendedAttribContOffset;
    public uint ExtendedDacOffset;
    public uint ExtendedValidatorStateOffset;
    public uint ExtendedMiscDataOffset;
    public uint PlaneLength;
    public uint Plane1Offset;
    public uint Plane2Offset;
    public uint Plane3Offset;
    public uint Plane4Offset;
    public uint VGAStateFlags;
    public uint DIBOffset;
    public uint DIBBitsPerPixel;
    public uint DIBXResolution;
    public uint DIBYResolution;
    public uint DIBXlatOffset;
    public uint DIBXlatLength;
    public uint VesaInfoOffset;
    public nint FrameBufferData;
}
