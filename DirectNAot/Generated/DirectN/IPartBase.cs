namespace DirectN;

[GeneratedComInterface, Guid("36d51e28-369e-43ba-a666-9540c62c3f58")]
public partial interface IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUri(out BSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStream(out IPrintReadStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPartCompression(out EXpsCompressionOptions pCompression);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPartCompression(EXpsCompressionOptions compression);
}
