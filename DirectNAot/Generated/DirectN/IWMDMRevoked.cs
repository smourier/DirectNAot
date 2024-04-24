namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmrevoked
[GeneratedComInterface, Guid("ebeccedb-88ee-4e55-b6a4-8d9f07d696aa")]
public partial interface IWMDMRevoked
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmrevoked-getrevocationurl
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRevocationURL([MarshalUsing(CountElementName = nameof(pdwBufferLen))] ref PWSTR[] ppwszRevocationURL, ref uint pdwBufferLen, out uint pdwRevokedBitFlag);
}
