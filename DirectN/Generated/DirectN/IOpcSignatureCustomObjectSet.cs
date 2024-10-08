﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturecustomobjectset
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("8f792ac5-7947-4e11-bc3d-2659ff046ae1")]
public partial interface IOpcSignatureCustomObjectSet
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectset-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(nint /* byte array */ xmlMarkup, uint count, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureCustomObject>))] out IOpcSignatureCustomObject customObject);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectset-delete
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Delete([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureCustomObject>))] IOpcSignatureCustomObject customObject);
    
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobjectset-getenumerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEnumerator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcSignatureCustomObjectEnumerator>))] out IOpcSignatureCustomObjectEnumerator customObjectEnumerator);
}
