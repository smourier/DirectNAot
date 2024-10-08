﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomimagebrush
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("3df0b466-d382-49ef-8550-dd94c80242e4")]
public partial interface IXpsOMImageBrush : IXpsOMTileBrush
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimagebrush-getimageresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetImageResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] out IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimagebrush-setimageresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetImageResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageResource>))] IXpsOMImageResource imageResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimagebrush-getcolorprofileresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetColorProfileResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] out IXpsOMColorProfileResource colorProfileResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimagebrush-setcolorprofileresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetColorProfileResource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMColorProfileResource>))] IXpsOMColorProfileResource colorProfileResource);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomimagebrush-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMImageBrush>))] out IXpsOMImageBrush imageBrush);
}
