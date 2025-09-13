#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamexttransport
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a03cd5f0-3045-11cf-8c44-00aa006b6814")]
public partial interface IAMExtTransport
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-getcapability
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapability(int Capability, out int pValue, out double pdblValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-put_mediastate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MediaState(int State);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-get_mediastate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaState(out int pState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-put_localcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LocalControl(int State);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-get_localcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LocalControl(out int pState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(int StatusItem, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-gettransportbasicparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransportBasicParameters(int Param, ref int pValue, out PWSTR ppszData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-settransportbasicparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransportBasicParameters(int Param, int Value, PWSTR pszData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-gettransportvideoparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransportVideoParameters(int Param, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-settransportvideoparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransportVideoParameters(int Param, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-gettransportaudioparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransportAudioParameters(int Param, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-settransportaudioparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransportAudioParameters(int Param, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-put_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Mode(int Mode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-get_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Mode(out int pMode);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-put_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Rate(double dblRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-get_rate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Rate(out double pdblRate);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-getchase
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetChase(out int pEnabled, out int pOffset, out nuint phEvent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-setchase
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChase(int Enable, int Offset, nuint hEvent);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-getbump
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBump(out int pSpeed, out int pDuration);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-setbump
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBump(int Speed, int Duration);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-get_anticlogcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AntiClogControl(out int pEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-put_anticlogcontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AntiClogControl(int Enable);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-geteditpropertyset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEditPropertySet(int EditID, out int pState);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-seteditpropertyset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEditPropertySet(ref int pEditID, int State);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-geteditproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEditProperty(int EditID, int Param, out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-seteditproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEditProperty(int EditID, int Param, int Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-get_editstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_EditStart(out int pValue);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamexttransport-put_editstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_EditStart(int Value);
}
