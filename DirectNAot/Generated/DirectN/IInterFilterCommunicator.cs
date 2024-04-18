namespace DirectN;

[GeneratedComInterface, Guid("4daf1e69-81fd-462d-940f-8cd3ddf56fca")]
public partial interface IInterFilterCommunicator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RequestReader(out nint ppIReader);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RequestWriter(out nint ppIWriter);
}
