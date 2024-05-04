#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-imfvideopresenter
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("29aff080-182a-4a5d-af3b-448f3a6346cb")]
public partial interface IMFVideoPresenter : IMFClockStateSink
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideopresenter-processmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ProcessMessage(MFVP_MESSAGE_TYPE eMessage, nuint ulParam);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-imfvideopresenter-getcurrentmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentMediaType(out IMFVideoMediaType ppMediaType);
}
