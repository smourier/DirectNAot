#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("607be24b-d91b-4e28-a242-61871ce56e35")]
public partial interface IActionOnCLREvent
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnEvent(EClrEvent @event, nint data);
}
