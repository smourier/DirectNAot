#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/qnetwork/nn-qnetwork-iammediacontent2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("ce8f78c1-74d9-11d2-b09d-00a0c9a81117")]
public partial interface IAMMediaContent2 : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent2-get_mediaparameter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaParameter(int EntryNum, BSTR bstrName, ref BSTR pbstrValue);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent2-get_mediaparametername
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MediaParameterName(int EntryNum, int Index, ref BSTR pbstrName);
    
    // https://learn.microsoft.com/windows/win32/api/qnetwork/nf-qnetwork-iammediacontent2-get_playlistcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PlaylistCount(ref int pNumberEntries);
}
