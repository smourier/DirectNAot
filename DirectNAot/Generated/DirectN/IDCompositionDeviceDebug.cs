namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomp/nn-dcomp-idcompositiondevicedebug
[GeneratedComInterface, Guid("a1a3c64a-224f-4a81-9773-4f03a89d3c6c")]
public partial interface IDCompositionDeviceDebug
{
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevicedebug-enabledebugcounters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnableDebugCounters();
    
    // https://learn.microsoft.com/windows/win32/api/dcomp/nf-dcomp-idcompositiondevicedebug-disabledebugcounters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DisableDebugCounters();
}
