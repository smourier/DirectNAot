namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1effectauthor/ns-d2d1effectauthor-d2d1_custom_vertex_buffer_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES
{
    public nint shaderBufferWithInputSignature;
    public uint shaderBufferSize;
    public nint inputElements;
    public uint elementCount;
    public uint stride;
}
