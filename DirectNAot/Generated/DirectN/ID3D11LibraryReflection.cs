namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11libraryreflection
[GeneratedComInterface, Guid("54384f1b-5b3e-4bb7-ae01-60ba3097cbb6")]
public partial interface ID3D11LibraryReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11libraryreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D11_LIBRARY_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11libraryreflection-getfunctionbyindex
    [PreserveSig]
    ID3D11FunctionReflection GetFunctionByIndex(int FunctionIndex);
}
