namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/prnasnot/nn-prnasnot-iprintasyncnotifydataobject
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("77cf513e-5d49-4789-9f30-d0822b335c0d")]
public partial interface IPrintAsyncNotifyDataObject
{
    // https://learn.microsoft.com/windows/win32/api/prnasnot/nf-prnasnot-iprintasyncnotifydataobject-acquiredata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AcquireData(out nint /* byte array */ ppNotificationData, nint/* nint */ pSize, nint/* nint */ ppSchema);
    
    // https://learn.microsoft.com/windows/win32/api/prnasnot/nf-prnasnot-iprintasyncnotifydataobject-releasedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ReleaseData();
}
