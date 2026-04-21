namespace DirectN;

[GeneratedComInterface, Guid("00000036-0000-0000-C000-000000000046")]
public partial interface IAsyncInfo : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Id(out uint id);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Status(out AsyncStatus status);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ErrorCode(out HRESULT errorCode);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Cancel();

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
