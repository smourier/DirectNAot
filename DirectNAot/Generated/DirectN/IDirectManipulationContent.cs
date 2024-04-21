﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationcontent
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("b89962cb-3d89-442b-bb58-5098fa0f9f16")]
public partial interface IDirectManipulationContent
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-getcontentrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentRect(out FoundationRECT contentSize);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-setcontentrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContentRect(FoundationRECT contentSize);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-getviewport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewport(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ @object);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object? /* void */ @object, nint /* optional uint */ id);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-settag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTag(nint @object, uint id);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-getoutputtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputTransform(out float matrix, uint pointCount);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-getcontenttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetContentTransform(out float matrix, uint pointCount);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationcontent-synccontenttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SyncContentTransform(in float matrix, uint pointCount);
}