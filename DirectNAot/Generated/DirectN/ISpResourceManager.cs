namespace DirectN;

[GeneratedComInterface, Guid("93384e18-5014-43d5-adbb-a78e055926bd")]
public partial interface ISpResourceManager : IServiceProvider
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObject(in Guid guidServiceId, nint pUnkObject);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(in Guid guidServiceId, in Guid ObjectCLSID, in Guid ObjectIID, [MarshalAs(UnmanagedType.U4)] bool fReleaseWhenLastExternalRefReleased, out nint ppObject);
}
