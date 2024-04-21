namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_cpu_descriptor_handle
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_CPU_DESCRIPTOR_HANDLE
{
    public static readonly D3D12_CPU_DESCRIPTOR_HANDLE Null = new();
    
    public nuint ptr;
}
