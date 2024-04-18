namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcompiler/ne-d3dcompiler-d3dcompiler_strip_flags
public enum D3DCOMPILER_STRIP_FLAGS
{
    D3DCOMPILER_STRIP_REFLECTION_DATA = 1,
    D3DCOMPILER_STRIP_DEBUG_INFO = 2,
    D3DCOMPILER_STRIP_TEST_BLOBS = 4,
    D3DCOMPILER_STRIP_PRIVATE_DATA = 8,
    D3DCOMPILER_STRIP_ROOT_SIGNATURE = 16,
}
