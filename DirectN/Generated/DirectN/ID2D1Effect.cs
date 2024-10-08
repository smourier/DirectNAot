﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1effect
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("28211a43-7d89-476f-8181-2d6159b220ad")]
public partial interface ID2D1Effect : ID2D1Properties
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-setinput
    [PreserveSig]
    void SetInput(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Image?>))] ID2D1Image? input, BOOL invalidate);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-setinputcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputCount(uint inputCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-getinput
    [PreserveSig]
    void GetInput(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Image>))] out ID2D1Image input);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-getinputcount
    [PreserveSig]
    uint GetInputCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1effect-getoutput
    [PreserveSig]
    void GetOutput([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID2D1Image>))] out ID2D1Image outputImage);
}
