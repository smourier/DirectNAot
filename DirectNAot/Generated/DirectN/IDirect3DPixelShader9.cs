namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dpixelshader9
[GeneratedComInterface, Guid("6d3bdbdc-5b02-4415-b852-ce5e8bccb289")]
public partial interface IDirect3DPixelShader9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dpixelshader9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dpixelshader9-getfunction
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFunction(nint param0, ref uint pSizeOfData);
}
