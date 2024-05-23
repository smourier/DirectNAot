namespace DirectN;

[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a96bb1db-172e-4667-82b5-ad97a252318f")]
public partial interface IPrintDocumentPageSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreviewPageCollection(IPrintDocumentPackageTarget docPackageTarget, out IPrintPreviewPageCollection docPageCollection);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeDocument(nint printTaskOptions, IPrintDocumentPackageTarget docPackageTarget);
}
