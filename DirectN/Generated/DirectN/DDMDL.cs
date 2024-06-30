#nullable enable
namespace DirectN;

public partial struct DDMDL
{
    public nint MdlNext;
    public short MdlSize;
    public short MdlFlags;
    public nint Process;
    public nint lpMappedSystemVa;
    public nint lpStartVa;
    public uint ByteCount;
    public uint ByteOffset;
}
