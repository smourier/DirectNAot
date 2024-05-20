#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/ns-d3d12sdklayers-d3d12_message
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_MESSAGE
{
    public D3D12_MESSAGE_CATEGORY Category;
    public D3D12_MESSAGE_SEVERITY Severity;
    public D3D12_MESSAGE_ID ID;
    public nint pDescription;
    public nuint DescriptionByteLength;
}
