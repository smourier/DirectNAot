#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WAVEOPENDESC
{
    public HWAVE hWave;
    public nint lpFormat;
    public nuint dwCallback;
    public nuint dwInstance;
    public uint uMappedDeviceID;
    public nuint dnDevNode;
}
