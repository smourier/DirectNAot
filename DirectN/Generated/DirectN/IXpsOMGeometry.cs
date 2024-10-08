﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsomgeometry
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("64fcf3d7-4d58-44ba-ad73-a13af6492072")]
public partial interface IXpsOMGeometry : IXpsOMShareable
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-getfigures
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFigures([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometryFigureCollection>))] out IXpsOMGeometryFigureCollection figures);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-getfillrule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFillRule(out XPS_FILL_RULE fillRule);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-setfillrule
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFillRule(XPS_FILL_RULE fillRule);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-gettransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-gettransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] out IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-settransformlocal
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformLocal([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMMatrixTransform>))] IXpsOMMatrixTransform transform);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-gettransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransformLookup(out PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-settransformlookup
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransformLookup(PWSTR lookup);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsomgeometry-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMGeometry>))] out IXpsOMGeometry geometry);
}
