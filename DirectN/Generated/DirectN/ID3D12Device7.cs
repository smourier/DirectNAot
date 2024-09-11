#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device7
[GeneratedComInterface, Guid("5c014b53-68a1-4b9b-8bd1-dd6046b9358b")]
public partial interface ID3D12Device7 : ID3D12Device6
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device7-addtostateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddToStateObject(in D3D12_STATE_OBJECT_DESC pAddition, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12StateObject>))] ID3D12StateObject pStateObjectToGrowFrom, in Guid riid, out nint /* void */ ppNewStateObject);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device7-createprotectedresourcesession1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateProtectedResourceSession1(in D3D12_PROTECTED_RESOURCE_SESSION_DESC1 pDesc, in Guid riid, out nint /* void */ ppSession);
}
