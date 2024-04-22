namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nn-inkpresenterdesktop-iinkcommitrequesthandler
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("fabea3fc-b108-45b6-a9fc-8d08fa9f85cf")]
public partial interface IInkCommitRequestHandler
{
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkcommitrequesthandler-oncommitrequested
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnCommitRequested();
}
