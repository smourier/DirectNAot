#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-imessagefilter
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000016-0000-0000-c000-000000000046")]
public partial interface IMessageFilter
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imessagefilter-handleincomingcall
    [PreserveSig]
    uint HandleInComingCall(uint dwCallType, HTASK htaskCaller, uint dwTickCount, nint /* optional INTERFACEINFO* */ lpInterfaceInfo);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imessagefilter-retryrejectedcall
    [PreserveSig]
    uint RetryRejectedCall(HTASK htaskCallee, uint dwTickCount, uint dwRejectType);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imessagefilter-messagepending
    [PreserveSig]
    uint MessagePending(HTASK htaskCallee, uint dwTickCount, uint dwPendingType);
}
