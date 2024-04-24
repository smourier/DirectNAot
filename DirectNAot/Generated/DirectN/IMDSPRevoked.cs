namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdsprevoked
[GeneratedComInterface, Guid("a4e8f2d4-3f31-464d-b53d-4fc335998184")]
public partial interface IMDSPRevoked
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdsprevoked-getrevocationurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRevocationURL([MarshalUsing(CountElementName = nameof(pdwBufferLen))] ref PWSTR[] ppwszRevocationURL, ref uint pdwBufferLen);
}
