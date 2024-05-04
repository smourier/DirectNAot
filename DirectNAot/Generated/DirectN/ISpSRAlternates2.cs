#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f338f437-cb33-4020-9cab-c71ff9ce12d3")]
public partial interface ISpSRAlternates2 : ISpSRAlternates
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitText(in SPPHRASEALTREQUEST pAltRequest, PWSTR? pcszNewText, SPCOMMITFLAGS commitFlags);
}
