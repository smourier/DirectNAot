﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imeminputpin
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a8689d-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IMemInputPin
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-getallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocator(out IMemAllocator ppAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-notifyallocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyAllocator(IMemAllocator pAllocator, [MarshalAs(UnmanagedType.U4)] bool bReadOnly);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-getallocatorrequirements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocatorRequirements(out ALLOCATOR_PROPERTIES pProps);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-receive
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Receive(IMediaSample pSample);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-receivemultiple
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReceiveMultiple([MarshalUsing(CountElementName = nameof(nSamples))] in IMediaSample[] pSamples, int nSamples, out int nSamplesProcessed);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imeminputpin-receivecanblock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReceiveCanBlock();
}
