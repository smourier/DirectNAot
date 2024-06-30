#nullable enable
namespace DirectN;

public partial struct D3DTRANSFORMDATA
{
    public uint dwSize;
    public nint lpIn;
    public uint dwInSize;
    public nint lpOut;
    public uint dwOutSize;
    public nint lpHOut;
    public uint dwClip;
    public uint dwClipIntersection;
    public uint dwClipUnion;
    public D3DRECT drExtent;
}
