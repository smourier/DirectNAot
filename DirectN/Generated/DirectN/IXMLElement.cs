﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3f7f31ac-e15f-11d0-9c25-00c04fc99c8e")]
public partial interface IXMLElement : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_tagName(out BSTR p);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_tagName(BSTR p);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_parent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXMLElement>))] out IXMLElement ppParent);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT setAttribute(BSTR strPropertyName, VARIANT PropertyValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getAttribute(BSTR strPropertyName, out VARIANT PropertyValue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT removeAttribute(BSTR strPropertyName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_children([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXMLElementCollection>))] out IXMLElementCollection pp);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_type(out int plType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_text(out BSTR p);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_text(BSTR p);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT addChild([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXMLElement>))] IXMLElement pChildElem, int lIndex, int lReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT removeChild([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXMLElement>))] IXMLElement pChildElem);
}
