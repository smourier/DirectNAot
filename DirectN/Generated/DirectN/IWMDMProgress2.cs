#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmprogress2
[GeneratedComInterface, Guid("3a43f550-b383-4e92-b04a-e6bbc660fefc")]
public partial interface IWMDMProgress2 : IWMDMProgress
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress2-end2
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End2(HRESULT hrCompletionCode);
}
