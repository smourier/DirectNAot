#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-icomponents
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("39a48091-fffe-4182-a161-3ff802640e26")]
public partial interface IComponents : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT ppNewEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-enumcomponents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumComponents([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumComponents>))] out IEnumComponents ppNewEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponent>))] out IComponent ppComponent);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponent>))] IComponent Component, out VARIANT NewIndex);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT Index);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponents>))] out IComponents NewList);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponents-put_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Item(VARIANT Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponent>))] IComponent ppComponent);
}
