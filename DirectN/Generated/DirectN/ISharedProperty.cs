#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/comsvcs/nn-comsvcs-isharedproperty
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("2a005c01-a5de-11cf-9e66-00aa00a3f464")]
public partial interface ISharedProperty : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedproperty-get_value
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Value(out VARIANT pVal);
    
    // https://learn.microsoft.com/windows/win32/api/comsvcs/nf-comsvcs-isharedproperty-put_value
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Value(VARIANT val);
}
