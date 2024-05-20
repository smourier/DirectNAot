#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_WAVEARTDL
{
    public uint ulDownloadIdIdx;
    public uint ulBus;
    public uint ulBuffers;
    public uint ulMasterDLId;
    public ushort usOptions;
}
