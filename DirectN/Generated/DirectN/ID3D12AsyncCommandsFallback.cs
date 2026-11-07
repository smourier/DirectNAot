#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("fbddf9e8-33a3-488c-9775-1a970dc54862")]
public partial interface ID3D12AsyncCommandsFallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFallbackLayerEnabled(BOOL Enable);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetFallbackLayerEnabled();
}
