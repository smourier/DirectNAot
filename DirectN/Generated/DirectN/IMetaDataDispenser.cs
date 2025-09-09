#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/rometadataapi/nn-rometadataapi-imetadatadispenser
[GeneratedComInterface, Guid("809c652e-7396-11d2-9771-00a0c9b4d50c")]
public partial interface IMetaDataDispenser
{
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenser-definescope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DefineScope(in Guid rclsid, uint dwCreateFlags, in Guid riid, out nint ppIUnk);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenser-openscope
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenScope(PWSTR szScope, uint dwOpenFlags, in Guid riid, out nint ppIUnk);
    
    // https://learn.microsoft.com/windows/win32/api/rometadataapi/nf-rometadataapi-imetadatadispenser-openscopeonmemory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenScopeOnMemory(nint pData, uint cbData, uint dwOpenFlags, in Guid riid, out nint ppIUnk);
}
