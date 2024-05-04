#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DMATRIXMULTIPLY
{
    public uint hDestMatrix;
    public uint hSrcMatrix1;
    public uint hSrcMatrix2;
}
