#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c706c811-3663-4bf1-91b9-1e8a7c114ab9")]
public partial interface ID3D12RuntimeValidationControl
{
    [PreserveSig]
    void DisableFailuresFromStricterValidationInAppLocalRuntime(BOOL bDisable);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL FailuresFromStricterValidationInAppLocalRuntimeDisabled();
}
