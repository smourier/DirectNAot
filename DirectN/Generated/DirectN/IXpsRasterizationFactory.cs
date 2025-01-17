﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("e094808a-24c6-482b-a3a7-c21ac9b55f17")]
public partial interface IXpsRasterizationFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateRasterizer([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPage?>))] IXpsOMPage? xpsPage, float DPI, XPSRAS_RENDERING_MODE nonTextRenderingMode, XPSRAS_RENDERING_MODE textRenderingMode, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsRasterizer>))] out IXpsRasterizer ppIXPSRasterizer);
}
