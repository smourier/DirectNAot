#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamfiltermiscflags
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2dd74950-a890-11d1-abe8-00a0c905f375")]
public partial interface IAMFilterMiscFlags
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamfiltermiscflags-getmiscflags
    [PreserveSig]
    uint GetMiscFlags();
}
