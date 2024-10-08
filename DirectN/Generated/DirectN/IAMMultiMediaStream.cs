﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amstream/nn-amstream-iammultimediastream
[GeneratedComInterface, Guid("bebe595c-9a6f-11d0-8fde-00c04fd9189d")]
public partial interface IAMMultiMediaStream : IMultiMediaStream
{
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(STREAM_TYPE StreamType, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] IGraphBuilder pFilterGraph);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-getfiltergraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilterGraph([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGraphBuilder>))] out IGraphBuilder ppGraphBuilder);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-getfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaStreamFilter>))] out IMediaStreamFilter ppFilter);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-addmediastream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMediaStream(nint pStreamObject, in Guid PurposeId, uint dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMediaStream>))] out IMediaStream ppNewStream);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-openfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenFile(PWSTR pszFileName, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-openmoniker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenMoniker([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pCtx, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pMoniker, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/amstream/nf-amstream-iammultimediastream-render
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Render(uint dwFlags);
}
