#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2data/nn-mpeg2data-impeg2data
[GeneratedComInterface, Guid("9b396d40-f380-4e3c-a514-1a82bf6ebfe6")]
public partial interface IMpeg2Data
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2data-getsection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSection(ushort pid, byte tid, in MPEG2_FILTER pFilter, uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] out ISectionList ppSectionList);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2data-gettable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTable(ushort pid, byte tid, in MPEG2_FILTER pFilter, uint dwTimeout, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISectionList>))] out ISectionList ppSectionList);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2data-getstreamofsections
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamOfSections(ushort pid, byte tid, in MPEG2_FILTER pFilter, HANDLE hDataReadyEvent, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMpeg2Stream>))] out IMpeg2Stream ppMpegStream);
}
