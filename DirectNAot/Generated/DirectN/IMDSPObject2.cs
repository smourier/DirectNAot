namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-imdspobject2
[GeneratedComInterface, Guid("3f34cd3e-5907-4341-9af9-97f4187c3aa5")]
public partial interface IMDSPObject2 : IMDSPObject
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject2-readonclearchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReadOnClearChannel(nint /* byte array */ pData, ref uint pdwSize);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-imdspobject2-writeonclearchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteOnClearChannel(nint /* byte array */ pData, ref uint pdwSize);
}
