#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("fcd01846-0e19-11d3-9d8e-00c04f72d980")]
public partial interface IComponentsOld : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT ppNewEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumComponents([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumComponents>))] out IEnumComponents ppNewEnum);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponent>))] out IComponent ppComponent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponent>))] IComponent Component, out VARIANT NewIndex);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT Index);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponents>))] out IComponents NewList);
}
