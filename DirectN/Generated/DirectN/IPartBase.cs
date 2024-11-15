#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("36d51e28-369e-43ba-a666-9540c62c3f58")]
public partial interface IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUri(out BSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPrintReadStream>))] out IPrintReadStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPartCompression(out EXpsCompressionOptions pCompression);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPartCompression(EXpsCompressionOptions compression);
}
