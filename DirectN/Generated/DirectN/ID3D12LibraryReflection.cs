#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12shader/nn-d3d12shader-id3d12libraryreflection
[GeneratedComInterface, Guid("8e349d19-54db-4a56-9dc9-119d87bdb804")]
public partial interface ID3D12LibraryReflection
{
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12libraryreflection-getdesc
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesc(out D3D12_LIBRARY_DESC pDesc);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12shader/nf-d3d12shader-id3d12libraryreflection-getfunctionbyindex
    [PreserveSig]
    nint GetFunctionByIndex(int FunctionIndex);
}
