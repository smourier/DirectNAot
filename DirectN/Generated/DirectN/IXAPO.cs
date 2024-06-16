#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xapo/nn-xapo-ixapo
[GeneratedComInterface, Guid("a410b984-9839-4819-a0be-2856ae6b3adb")]
public partial interface IXAPO
{
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-getregistrationproperties
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRegistrationProperties(out nint ppRegistrationProperties);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-isinputformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsInputFormatSupported(in WAVEFORMATEX pOutputFormat, in WAVEFORMATEX pRequestedInputFormat, nint /* optional WAVEFORMATEX** */ ppSupportedInputFormat);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-isoutputformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsOutputFormatSupported(in WAVEFORMATEX pInputFormat, in WAVEFORMATEX pRequestedOutputFormat, nint /* optional WAVEFORMATEX** */ ppSupportedOutputFormat);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint /* optional void* */ pData, uint DataByteSize);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-reset
    [PreserveSig]
    void Reset();
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-lockforprocess
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockForProcess(uint InputLockedParameterCount, nint /* optional XAPO_LOCKFORPROCESS_PARAMETERS* */ pInputLockedParameters, uint OutputLockedParameterCount, nint /* optional XAPO_LOCKFORPROCESS_PARAMETERS* */ pOutputLockedParameters);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-unlockforprocess
    [PreserveSig]
    void UnlockForProcess();
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-process
    [PreserveSig]
    void Process(uint InputProcessParameterCount, nint /* optional XAPO_PROCESS_BUFFER_PARAMETERS* */ pInputProcessParameters, uint OutputProcessParameterCount, nint /* optional XAPO_PROCESS_BUFFER_PARAMETERS* */ pOutputProcessParameters, BOOL IsEnabled);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-calcinputframes
    [PreserveSig]
    uint CalcInputFrames(uint OutputFrameCount);
    
    // https://learn.microsoft.com/windows/win32/api/xapo/nf-xapo-ixapo-calcoutputframes
    [PreserveSig]
    uint CalcOutputFrames(uint InputFrameCount);
}
