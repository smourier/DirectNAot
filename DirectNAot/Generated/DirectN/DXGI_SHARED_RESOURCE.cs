namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/ns-dxgi-dxgi_shared_resource
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_SHARED_RESOURCE
{
    public HANDLE Handle;
}
