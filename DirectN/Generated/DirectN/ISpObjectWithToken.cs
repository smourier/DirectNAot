﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5b559f40-e952-11d2-bb91-00c04f8ee6c0")]
public partial interface ISpObjectWithToken
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetObjectToken([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken?>))] ISpObjectToken? pToken);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectToken([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpObjectToken>))] out ISpObjectToken ppToken);
}
