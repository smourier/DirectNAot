#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfsourcebufferlist
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("249981f8-8325-41f3-b80c-3b9e3aad0cbe")]
public partial interface IMFSourceBufferList
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebufferlist-getlength
    [PreserveSig]
    uint GetLength();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfsourcebufferlist-getsourcebuffer
    [PreserveSig]
    [return: MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSourceBuffer>))]
    IMFSourceBuffer GetSourceBuffer(uint index);
}
