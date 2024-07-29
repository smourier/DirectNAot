#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-ipinflowcontrol
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("c56e9858-dbf3-4f6b-8119-384af2060deb")]
public partial interface IPinFlowControl
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-ipinflowcontrol-block
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Block(uint dwBlockFlags, HANDLE hEvent);
}
