#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbtunerequest
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0d6f567e-a636-42bb-83ba-ce4c1704afa2")]
public partial interface IDVBTuneRequest : ITuneRequest
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtunerequest-get_onid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ONID(out int ONID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtunerequest-put_onid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ONID(int ONID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtunerequest-get_tsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TSID(out int TSID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtunerequest-put_tsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TSID(int TSID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtunerequest-get_sid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SID(out int SID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtunerequest-put_sid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SID(int SID);
}
