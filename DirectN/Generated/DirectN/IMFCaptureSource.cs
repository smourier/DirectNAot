#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nn-mfcaptureengine-imfcapturesource
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("439a42a8-0d2c-4505-be83-f79b2a05d5c4")]
public partial interface IMFCaptureSource
{
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getcapturedevicesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaptureDeviceSource(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, nint /* optional IMFMediaSource* */ ppMediaSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getcapturedeviceactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaptureDeviceActivate(MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, nint /* optional IMFActivate* */ ppActivate);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetService(in Guid rguidService, in Guid riid, nint /* optional nint* */ ppUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-addeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEffect(uint dwSourceStreamIndex, nint pUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-removeeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEffect(uint dwSourceStreamIndex, nint pUnknown);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-removealleffects
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllEffects(uint dwSourceStreamIndex);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getavailabledevicemediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAvailableDeviceMediaType(uint dwSourceStreamIndex, uint dwMediaTypeIndex, nint /* optional IMFMediaType* */ ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-setcurrentdevicemediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentDeviceMediaType(uint dwSourceStreamIndex, IMFMediaType pMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getcurrentdevicemediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentDeviceMediaType(uint dwSourceStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getdevicestreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceStreamCount(out uint pdwStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getdevicestreamcategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeviceStreamCategory(uint dwSourceStreamIndex, out MF_CAPTURE_ENGINE_STREAM_CATEGORY pStreamCategory);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getmirrorstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMirrorState(uint dwStreamIndex, out BOOL pfMirrorState);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-setmirrorstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMirrorState(uint dwStreamIndex, BOOL fMirrorState);
    
    // https://learn.microsoft.com/windows/win32/api/mfcaptureengine/nf-mfcaptureengine-imfcapturesource-getstreamindexfromfriendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamIndexFromFriendlyName(uint uifriendlyName, out uint pdwActualStreamIndex);
}
