#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3DEXECUTEDATA
{
    public uint dwSize;
    public uint dwVertexOffset;
    public uint dwVertexCount;
    public uint dwInstructionOffset;
    public uint dwInstructionLength;
    public uint dwHVertexOffset;
    public D3DSTATUS dsStatus;
}
