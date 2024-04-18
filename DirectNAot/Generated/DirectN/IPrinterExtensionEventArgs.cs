namespace DirectN;

[GeneratedComInterface, Guid("39843bf4-c4d2-41fd-b4b2-aedbee5e1900")]
public partial interface IPrinterExtensionEventArgs : IPrinterExtensionContext
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_BidiNotification(out BSTR pbstrBidiNotification);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_ReasonId(out Guid pReasonId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Request(out IPrinterExtensionRequest ppRequest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_SourceApplication(out BSTR pbstrApplication);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_DetailedReasonId(out Guid pDetailedReasonId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_WindowModal([MarshalAs(UnmanagedType.U4)] out bool pbModal);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_WindowParent(out HANDLE phwndParent);
}
