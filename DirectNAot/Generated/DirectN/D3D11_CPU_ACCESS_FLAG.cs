namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ne-d3d11-d3d11_cpu_access_flag
[Flags]
public enum D3D11_CPU_ACCESS_FLAG
{
    D3D11_CPU_ACCESS_WRITE = 65536,
    D3D11_CPU_ACCESS_READ = 131072,
}
