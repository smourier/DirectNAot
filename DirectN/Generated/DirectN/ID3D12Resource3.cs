#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b5e58a68-46f3-4ece-a278-2246c1eb4093")]
public partial interface ID3D12Resource3 : ID3D12Resource2
{
    [PreserveSig]
    D3D12_RESOURCE_DESC2 GetDesc2();
    
    [PreserveSig]
    uint GetCastableFormatsCount();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCastableFormats(ref DXGI_FORMAT pCastableFormats);
}
