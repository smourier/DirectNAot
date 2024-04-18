namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/ns-d3d11sdklayers-d3d11_message
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_MESSAGE
{
    public D3D11_MESSAGE_CATEGORY Category;
    public D3D11_MESSAGE_SEVERITY Severity;
    public D3D11_MESSAGE_ID ID;
    public nint pDescription;
    public nuint DescriptionByteLength;
}
