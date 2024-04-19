namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmdxva/nn-wmdxva-iwmplayertimestamphook
[GeneratedComInterface, Guid("28580dda-d98e-48d0-b7ae-69e473a02825")]
public partial interface IWMPlayerTimestampHook
{
    // https://learn.microsoft.com/windows/win32/api/wmdxva/nf-wmdxva-iwmplayertimestamphook-maptimestamp
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MapTimestamp(long rtIn, out long prtOut);
}
