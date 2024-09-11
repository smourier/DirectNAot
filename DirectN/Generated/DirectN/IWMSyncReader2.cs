#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmsyncreader2
[GeneratedComInterface, Guid("faed3d21-1b6b-4af7-8cb6-3e189bbc187b")]
public partial interface IWMSyncReader2 : IWMSyncReader
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader2-setrangebytimecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRangeByTimecode(ushort wStreamNum, in WMT_TIMECODE_EXTENSION_DATA pStart, in WMT_TIMECODE_EXTENSION_DATA pEnd);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader2-setrangebyframeex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRangeByFrameEx(ushort wStreamNum, ulong qwFrameNumber, long cFramesToRead, out ulong pcnsStartTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader2-setallocateforoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocateForOutput(uint dwOutputNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMReaderAllocatorEx>))] IWMReaderAllocatorEx pAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader2-getallocateforoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocateForOutput(uint dwOutputNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMReaderAllocatorEx>))] out IWMReaderAllocatorEx ppAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader2-setallocateforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllocateForStream(ushort wStreamNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMReaderAllocatorEx>))] IWMReaderAllocatorEx pAllocator);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmsyncreader2-getallocateforstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllocateForStream(ushort dwSreamNum, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMReaderAllocatorEx>))] out IWMReaderAllocatorEx ppAllocator);
}
