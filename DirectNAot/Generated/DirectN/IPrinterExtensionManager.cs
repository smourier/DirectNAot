namespace DirectN;

[GeneratedComInterface, Guid("93c6eb8c-b001-4355-9629-8e8a1b3f8e77")]
public partial interface IPrinterExtensionManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnableEvents(Guid printerDriverId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DisableEvents();
}
