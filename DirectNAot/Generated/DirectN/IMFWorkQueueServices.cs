namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfworkqueueservices
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("35fe1bb8-a3a9-40fe-bbec-eb569c9ccca3")]
public partial interface IMFWorkQueueServices
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-beginregistertopologyworkqueueswithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-endregistertopologyworkqueueswithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-beginunregistertopologyworkqueueswithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-endunregistertopologyworkqueueswithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-gettopologyworkqueuemmcssclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTopologyWorkQueueMMCSSClass(uint dwTopologyWorkQueueId, out PWSTR pwszClass, ref uint pcchClass);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-gettopologyworkqueuemmcsstaskid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTopologyWorkQueueMMCSSTaskId(uint dwTopologyWorkQueueId, out uint pdwTaskId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-beginregisterplatformworkqueuewithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(uint dwPlatformWorkQueue, PWSTR wszClass, uint dwTaskId, IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-endregisterplatformworkqueuewithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndRegisterPlatformWorkQueueWithMMCSS(IMFAsyncResult pResult, out uint pdwTaskId);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-beginunregisterplatformworkqueuewithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(uint dwPlatformWorkQueue, IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-endunregisterplatformworkqueuewithmmcss
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-getplaftormworkqueuemmcssclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlaftormWorkQueueMMCSSClass(uint dwPlatformWorkQueueId, out PWSTR pwszClass, ref uint pcchClass);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfworkqueueservices-getplatformworkqueuemmcsstaskid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlatformWorkQueueMMCSSTaskId(uint dwPlatformWorkQueueId, out uint pdwTaskId);
}
