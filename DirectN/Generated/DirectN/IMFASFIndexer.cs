#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfindexer
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("53590f48-dc3b-4297-813f-787761ad7b3e")]
public partial interface IMFASFIndexer
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFContentInfo>))] IMFASFContentInfo pIContentInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getindexposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexPosition([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFContentInfo>))] IMFASFContentInfo pIContentInfo, out ulong pcbIndexOffset);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-setindexbytestreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndexByteStreams(in IMFByteStream ppIByteStreams, uint cByteStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getindexbytestreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexByteStreamCount(out uint pcByteStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getindexstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexStatus(in ASF_INDEX_IDENTIFIER pIndexIdentifier, out BOOL pfIsIndexed, nint /* byte array */ pbIndexDescriptor, ref uint pcbIndexDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-setindexstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIndexStatus(nint /* byte array */ pbIndexDescriptor, uint cbIndexDescriptor, BOOL fGenerateIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getseekpositionforvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSeekPositionForValue(in PROPVARIANT pvarValue, in ASF_INDEX_IDENTIFIER pIndexIdentifier, out ulong pcbOffsetWithinData, ref long phnsApproxTime, ref uint pdwPayloadNumberOfStreamWithinPacket);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-generateindexentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GenerateIndexEntries([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] IMFSample pIASFPacketSample);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-commitindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CommitIndex([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFContentInfo>))] IMFASFContentInfo pIContentInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getindexwritespace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIndexWriteSpace(out ulong pcbIndexWriteSpace);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfindexer-getcompletedindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompletedIndex([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaBuffer>))] IMFMediaBuffer pIIndexBuffer, ulong cbOffsetWithinIndex);
}
