#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpservices/nn-wmpservices-iwmppluginenable
[GeneratedComInterface, Guid("5fca444c-7ad1-479d-a4ef-40566a5309d6")]
public partial interface IWMPPluginEnable
{
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmppluginenable-setenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEnable(BOOL fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/wmpservices/nf-wmpservices-iwmppluginenable-getenable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnable(ref BOOL pfEnable);
}
