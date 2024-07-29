#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfcontentprotectionmanager
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("acf92459-6a61-42bd-b57c-b43e51203cb0")]
public partial interface IMFContentProtectionManager
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentprotectionmanager-beginenablecontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginEnableContent(IMFActivate pEnablerActivate, IMFTopology pTopo, IMFAsyncCallback pCallback, nint punkState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfcontentprotectionmanager-endenablecontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndEnableContent(IMFAsyncResult pResult);
}
