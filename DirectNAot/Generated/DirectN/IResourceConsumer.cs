namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iresourceconsumer
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868ad-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IResourceConsumer
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourceconsumer-acquireresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AcquireResource(int idResource);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iresourceconsumer-releaseresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseResource(int idResource);
}
