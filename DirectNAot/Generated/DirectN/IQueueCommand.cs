namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-iqueuecommand
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b7-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IQueueCommand
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iqueuecommand-invokeatstreamtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeAtStreamTime(out IDeferredCommand pCmd, double time, in Guid iid, int dispidMethod, short wFlags, int cArgs, in VARIANT pDispParams, ref VARIANT pvarResult, out short puArgErr);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-iqueuecommand-invokeatpresentationtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InvokeAtPresentationTime(out IDeferredCommand pCmd, double time, in Guid iid, int dispidMethod, short wFlags, int cArgs, in VARIANT pDispParams, ref VARIANT pvarResult, out short puArgErr);
}
