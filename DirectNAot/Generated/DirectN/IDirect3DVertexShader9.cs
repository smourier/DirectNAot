#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dvertexshader9
[GeneratedComInterface, Guid("efc5557e-6265-4613-8a94-43857889eb36")]
public partial interface IDirect3DVertexShader9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexshader9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dvertexshader9-getfunction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFunction(nint param0, ref uint pSizeOfData);
}
