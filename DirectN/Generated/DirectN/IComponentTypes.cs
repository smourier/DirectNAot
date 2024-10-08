﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-icomponenttypes
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0dc13d4a-0313-11d3-9d8e-00c04f72d980")]
public partial interface IComponentTypes : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Count(out int Count);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-get__newenum
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NewEnum([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumVARIANT>))] out IEnumVARIANT ppNewEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-enumcomponenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumComponentTypes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumComponentTypes>))] out IEnumComponentTypes ppNewEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-get_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Item(VARIANT Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponentType>))] out IComponentType ComponentType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-put_item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Item(VARIANT Index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponentType>))] IComponentType ComponentType);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Add([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponentType>))] IComponentType ComponentType, out VARIANT NewIndex);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Remove(VARIANT Index);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-icomponenttypes-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponentTypes>))] out IComponentTypes NewList);
}
