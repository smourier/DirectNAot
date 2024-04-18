namespace DirectN;

[GeneratedComInterface, Guid("fb476970-9bab-4861-811e-3e98b0c5addf")]
public partial interface IPrinterExtensionContextCollection : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get_Count(out uint pulCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetAt(uint ulIndex, out IPrinterExtensionContext ppContext);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT get__NewEnum(out nint ppUnk);
}
