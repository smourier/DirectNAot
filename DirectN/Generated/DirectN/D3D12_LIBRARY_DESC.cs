#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/ns-d3d12shader-d3d12_library_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_LIBRARY_DESC
{
    public PSTR Creator;
    public uint Flags;
    public uint FunctionCount;
}
