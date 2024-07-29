#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("10f63bce-201a-11d3-ac70-00c04f8ee6c0")]
public partial interface ISpTranscript
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTranscript(out PWSTR ppszTranscript);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AppendTranscript(PWSTR pszTranscript);
}
