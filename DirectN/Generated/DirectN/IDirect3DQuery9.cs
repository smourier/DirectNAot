#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dquery9
[GeneratedComInterface, Guid("d9771460-a695-4f26-bbd3-27b840b541cc")]
public partial interface IDirect3DQuery9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dquery9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dquery9-gettype
    [PreserveSig]
    D3DQUERYTYPE GetType();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dquery9-getdatasize
    [PreserveSig]
    uint GetDataSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dquery9-issue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Issue(uint dwIssueFlags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dquery9-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData(nint pData, uint dwSize, uint dwGetDataFlags);
}
