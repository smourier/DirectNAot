namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxvacompbufferinfo
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVACompBufferInfo
{
    public uint NumCompBuffers;
    public uint WidthToCreate;
    public uint HeightToCreate;
    public uint BytesToAllocate;
    public uint Usage;
    public D3DPOOL Pool;
    public D3DFORMAT Format;
}
