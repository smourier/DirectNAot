namespace DirectN;

[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("0b31cc62-d7ec-4747-9d6e-f2537d870f2b")]
public partial interface IPrintPreviewPageCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Paginate(int currentJobPage, nint printTaskOptions);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakePage(int desiredJobPage, float width, float height);
}
