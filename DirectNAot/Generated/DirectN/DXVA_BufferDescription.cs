namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_BufferDescription
{
    public uint dwTypeIndex;
    public uint dwBufferIndex;
    public uint dwDataOffset;
    public uint dwDataSize;
    public uint dwFirstMBaddress;
    public uint dwNumMBsInBuffer;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwStride;
    public uint dwReservedBits;
}
