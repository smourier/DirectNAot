namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamfiltergraphcallback
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868fd-0ad4-11ce-b0a3-0020af0ba770")]
public partial interface IAMFilterGraphCallback
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamfiltergraphcallback-unabletorender
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnableToRender(IPin pPin);
}
