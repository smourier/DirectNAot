#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/ne-dwrite_3-dwrite_locality
public enum DWRITE_LOCALITY
{
    DWRITE_LOCALITY_REMOTE = 0,
    DWRITE_LOCALITY_PARTIAL = 1,
    DWRITE_LOCALITY_LOCAL = 2,
}
