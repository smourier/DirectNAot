#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audiomediatype/ns-audiomediatype-uncompressedaudioformat
[StructLayout(LayoutKind.Sequential)]
public partial struct UNCOMPRESSEDAUDIOFORMAT
{
    public Guid guidFormatType;
    public uint dwSamplesPerFrame;
    public uint dwBytesPerSampleContainer;
    public uint dwValidBitsPerSample;
    public float fFramesPerSecond;
    public uint dwChannelMask;
}
