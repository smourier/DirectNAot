﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("091f7a26-1c1f-4948-904b-e6e3a8a771d5")]
public partial interface IDxcAssembler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AssembleToContainer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcBlob>))] IDxcBlob pShader, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDxcOperationResult>))] out IDxcOperationResult ppResult);
}
