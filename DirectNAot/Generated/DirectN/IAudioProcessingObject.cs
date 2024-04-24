namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nn-audioenginebaseapo-iaudioprocessingobject
[GeneratedComInterface, Guid("fd7f2b29-24d0-4b5c-b177-592c39f9ca10")]
public partial interface IAudioProcessingObject
{
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-getlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLatency(out long pTime);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-getregistrationproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRegistrationProperties(out nint ppRegProps);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(uint cbDataSize, nint /* byte array */ pbyData);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-isinputformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsInputFormatSupported(IAudioMediaType pOppositeFormat, IAudioMediaType pRequestedInputFormat, out IAudioMediaType ppSupportedInputFormat);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-isoutputformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOutputFormatSupported(IAudioMediaType pOppositeFormat, IAudioMediaType pRequestedOutputFormat, out IAudioMediaType ppSupportedOutputFormat);
    
    // https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/nf-audioenginebaseapo-iaudioprocessingobject-getinputchannelcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInputChannelCount(out uint pu32ChannelCount);
}
