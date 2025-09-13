#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b9ac5783-fcd0-4b21-b119-b4f8da8fd2c3")]
public partial interface ISpeechResourceLoader : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LoadResource(BSTR bstrResourceUri, VARIANT_BOOL fAlwaysReload, out nint pStream, nint /* optional BSTR* */ pbstrMIMEType, ref VARIANT_BOOL pfModified, nint /* optional BSTR* */ pbstrRedirectUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocalCopy(BSTR bstrResourceUri, out BSTR pbstrLocalPath, nint /* optional BSTR* */ pbstrMIMEType, nint /* optional BSTR* */ pbstrRedirectUrl);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseLocalCopy(BSTR pbstrLocalPath);
}
