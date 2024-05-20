#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3ddxgi/dxgi-shared-resource-rw
[Flags]
public enum DXGI_SHARED_RESOURCE_RW : uint
{
    DXGI_SHARED_RESOURCE_READ = 2147483648,
    DXGI_SHARED_RESOURCE_WRITE = 1,
}
