namespace DirectN;

[GeneratedComInterface, Guid("3d9f6448-7e95-4cb5-94fb-0180c2883a57")]
public partial interface IFixedPage : IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPrintTicket(out IPartPrintTicket ppPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPagePart(PWSTR uri, out nint ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetWriteStream(out IPrintWriteStream ppWriteStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPrintTicket(IPartPrintTicket ppPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPagePart(nint pUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DeleteResource(PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetXpsPartIterator(out IXpsPartIterator pXpsPartIt);
}
