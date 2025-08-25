#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iadvisesinkex
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("3af24290-0c96-11ce-a0cf-00aa00600ab8")]
public partial interface IAdviseSinkEx : IAdviseSink
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iadvisesinkex-onviewstatuschange
    [PreserveSig]
    void OnViewStatusChange(uint dwViewStatus);
}
