#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediakeys
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("5cb31c05-61ff-418f-afda-caaf41421a38")]
public partial interface IMFMediaKeys
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeys-createsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSession(BSTR mimeType, nint /* optional byte* */ initData, uint? cb, nint /* optional byte* */ customData, uint cbCustomData, IMFMediaKeySessionNotify notify, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaKeySession>))] out IMFMediaKeySession ppSession);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeys-get_keysystem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_KeySystem(out BSTR keySystem);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeys-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediakeys-getsuspendnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSuspendNotify([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFCdmSuspendNotify>))] out IMFCdmSuspendNotify notify);
}
