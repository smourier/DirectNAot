#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dshowasf/nn-dshowasf-iconfigasfwriter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("45086030-f7e4-486a-b504-826bb5792a3b")]
public partial interface IConfigAsfWriter
{
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-configurefilterusingprofileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfigureFilterUsingProfileId(uint dwProfileId);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-getcurrentprofileid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentProfileId(out uint pdwProfileId);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-configurefilterusingprofileguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfigureFilterUsingProfileGuid(in Guid guidProfile);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-getcurrentprofileguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentProfileGuid(out Guid pProfileGuid);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-configurefilterusingprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ConfigureFilterUsingProfile(IWMProfile pProfile);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-getcurrentprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentProfile([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMProfile>))] out IWMProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-setindexmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndexMode(BOOL bIndexFile);
    
    // https://learn.microsoft.com/windows/win32/api/dshowasf/nf-dshowasf-iconfigasfwriter-getindexmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexMode(out BOOL pbIndexFile);
}
