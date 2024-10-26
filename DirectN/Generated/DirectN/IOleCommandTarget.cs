#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/docobj/nn-docobj-iolecommandtarget
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b722bccb-4e68-101b-a2bc-00aa00404770")]
public partial interface IOleCommandTarget
{
    // https://learn.microsoft.com/windows/win32/api/docobj/nf-docobj-iolecommandtarget-querystatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryStatus(in Guid pguidCmdGroup, uint cCmds, ref OLECMD prgCmds, ref OLECMDTEXT pCmdText);
    
    // https://learn.microsoft.com/windows/win32/api/docobj/nf-docobj-iolecommandtarget-exec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Exec(in Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, in VARIANT pvaIn, ref VARIANT pvaOut);
}
