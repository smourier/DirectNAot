#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amva/ns-amva-amvabufferinfo
public partial struct AMVABUFFERINFO
{
    public uint dwTypeIndex;
    public uint dwBufferIndex;
    public uint dwDataOffset;
    public uint dwDataSize;
}
