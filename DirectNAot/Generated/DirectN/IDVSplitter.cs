#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvsplitter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("92a3a302-da7c-4a1f-ba7e-1802bb5d2d02")]
public partial interface IDVSplitter
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvsplitter-discardalternatevideoframes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DiscardAlternateVideoFrames(int nDiscard);
}
