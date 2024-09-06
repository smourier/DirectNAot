#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2data/nn-mpeg2data-isectionlist
[GeneratedComInterface, Guid("afec1eb5-2a64-46c6-bf4b-ae3ccb6afdb0")]
public partial interface ISectionList
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(MPEG_REQUEST_TYPE requestType, IMpeg2Data pMpeg2Data, in MPEG_CONTEXT pContext, ushort pid, byte tid, in MPEG2_FILTER pFilter, uint timeout, HANDLE hDoneEvent);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-initializewithrawsections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InitializeWithRawSections(in MPEG_PACKET_LIST pmplSections);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-cancelpendingrequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelPendingRequest();
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-getnumberofsections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfSections(out ushort pCount);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-getsectiondata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSectionData(ushort sectionNumber, out uint pdwRawPacketLength, out nint ppSection);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-getprogramidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProgramIdentifier(in ushort pPid);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-isectionlist-gettableidentifier
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableIdentifier(nint /* byte array */ pTableId);
}
