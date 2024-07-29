#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mswmdm/nn-mswmdm-iwmdmprogress3
[GeneratedComInterface, Guid("21de01cb-3bb4-4929-b21a-17af3f80f658")]
public partial interface IWMDMProgress3 : IWMDMProgress2
{
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress3-begin3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Begin3(Guid EventId, uint dwEstimatedTicks, nint /* optional OPAQUECOMMAND* */ pContext);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress3-progress3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Progress3(Guid EventId, uint dwTranspiredTicks, nint /* optional OPAQUECOMMAND* */ pContext);
    
    // https://learn.microsoft.com/windows/win32/api/mswmdm/nf-mswmdm-iwmdmprogress3-end3
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End3(Guid EventId, HRESULT hrCompletionCode, nint /* optional OPAQUECOMMAND* */ pContext);
}
