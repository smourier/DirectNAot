namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-idvdcmd
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("5a4a97e4-94ee-4a55-9751-74b5643aa27d")]
public partial interface IDvdCmd
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcmd-waitforstart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForStart();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-idvdcmd-waitforend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WaitForEnd();
}
