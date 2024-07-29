#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/nn-vfw-iavistreaming
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00020022-0000-0000-c000-000000000046")]
public partial interface IAVIStreaming
{
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistreaming-begin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Begin(int lStart, int lEnd, int lRate);
    
    // https://learn.microsoft.com/windows/win32/api/vfw/nf-vfw-iavistreaming-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End();
}
