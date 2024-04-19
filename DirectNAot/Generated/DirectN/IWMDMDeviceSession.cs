namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmdevicesession
[GeneratedComInterface, Guid("82af0a65-9d96-412c-83e5-3c43e4b06cc7")]
public partial interface IWMDMDeviceSession
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicesession-beginsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginSession(WMDM_SESSION_TYPE type, nint /* byte array */ pCtx, uint dwSizeCtx);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmdevicesession-endsession
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndSession(WMDM_SESSION_TYPE type, nint /* byte array */ pCtx, uint dwSizeCtx);
}
