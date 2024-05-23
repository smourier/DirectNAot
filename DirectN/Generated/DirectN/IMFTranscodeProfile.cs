#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imftranscodeprofile
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("4adfdba3-7ab0-4953-a62b-461e7ff3da1e")]
public partial interface IMFTranscodeProfile
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodeprofile-setaudioattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAudioAttributes(IMFAttributes? pAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodeprofile-getaudioattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAudioAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodeprofile-setvideoattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVideoAttributes(IMFAttributes? pAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodeprofile-getvideoattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodeprofile-setcontainerattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContainerAttributes(IMFAttributes? pAttrs);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imftranscodeprofile-getcontainerattributes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContainerAttributes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFAttributes>))] out IMFAttributes ppAttrs);
}
