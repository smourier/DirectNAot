#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("412bd695-f84b-46c1-ac73-54196dbc8fa7")]
public partial interface IKsNotifyEvent
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsNotifyEvent(uint Event, nuint lParam1, nuint lParam2);
}
