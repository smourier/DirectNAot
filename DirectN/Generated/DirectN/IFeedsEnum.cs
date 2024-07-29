#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e3cd0028-2eed-4c60-8fae-a3225309a836")]
public partial interface IFeedsEnum : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Item(int index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatch>))] out IDispatch disp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT enumVar);
}
