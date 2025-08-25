#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iquickactivate
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("cf51ed10-62fe-11cf-bf86-00a0c9034836")]
public partial interface IQuickActivate
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iquickactivate-quickactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QuickActivate(in QACONTAINER pQaContainer, ref QACONTROL pQaControl);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iquickactivate-setcontentextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContentExtent(in SIZE pSizel);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iquickactivate-getcontentextent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentExtent(out SIZE pSizel);
}
