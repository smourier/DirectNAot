#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/ns-d3d10sdklayers-d3d10_message
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_MESSAGE
{
    public D3D10_MESSAGE_CATEGORY Category;
    public D3D10_MESSAGE_SEVERITY Severity;
    public D3D10_MESSAGE_ID ID;
    public nint pDescription;
    public nuint DescriptionByteLength;
}
