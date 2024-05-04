#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmreader2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("befe7a75-9f1d-4075-b9d9-a3c37bda49a0")]
public partial interface IWMDRMReader2 : IWMDRMReader
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader2-setevaluateoutputlevellicenses
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEvaluateOutputLevelLicenses([MarshalAs(UnmanagedType.U4)] bool fEvaluate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader2-getplayoutputlevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayOutputLevels([MarshalUsing(CountElementName = nameof(pcbLength))] out DRM_PLAY_OPL[] pPlayOPL, ref uint pcbLength, out uint pdwMinAppComplianceLevel);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader2-getcopyoutputlevels
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCopyOutputLevels([MarshalUsing(CountElementName = nameof(pcbLength))] out DRM_COPY_OPL[] pCopyOPL, ref uint pcbLength, out uint pdwMinAppComplianceLevel);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader2-trynextlicense
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TryNextLicense();
}
