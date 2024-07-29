#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpmedia2
[GeneratedComInterface, Guid("ab7c88bb-143e-4ea4-acc3-e4350b2106c3")]
public partial interface IWMPMedia2 : IWMPMedia
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpmedia2-get_error
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_error([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPErrorItem>))] out IWMPErrorItem ppIWMPErrorItem);
}
