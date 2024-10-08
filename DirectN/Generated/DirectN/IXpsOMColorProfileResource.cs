﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomcolorprofileresource
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("67bd7d69-1eef-4bb1-b5e7-6f4f87be8abe")]
public partial interface IXpsOMColorProfileResource : IXpsOMResource
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresource-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream stream);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomcolorprofileresource-setcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContent([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream sourceStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri partName);
}
