namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nn-mpeg2psiparser-igenericdescriptor
[GeneratedComInterface, Guid("6a5918f8-a77a-4f61-aed0-5702bdcda3e6")]
public partial interface IGenericDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-igenericdescriptor-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(nint /* byte array */ pbDesc, int bCount);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-igenericdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-igenericdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2psiparser/nf-mpeg2psiparser-igenericdescriptor-getbody
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBody(out nint /* byte array */ ppbVal);
}
