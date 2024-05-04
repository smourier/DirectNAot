#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_ProcAmpControlCaps
{
    public uint Size;
    public uint InputPool;
    public D3DFORMAT d3dOutputFormat;
    public uint ProcAmpControlProps;
    public uint VideoProcessingCaps;
}
