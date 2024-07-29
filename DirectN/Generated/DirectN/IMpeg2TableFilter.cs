#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mpeg2data/nn-mpeg2data-impeg2tablefilter
[GeneratedComInterface, Guid("bdcdd913-9ecd-4fb2-81ae-adf747ea75a5")]
public partial interface IMpeg2TableFilter
{
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2tablefilter-addpid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddPID(ushort p);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2tablefilter-addtable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTable(ushort p, byte t);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2tablefilter-addextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddExtension(ushort p, byte t, ushort e);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2tablefilter-removepid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemovePID(ushort p);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2tablefilter-removetable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveTable(ushort p, byte t);
    
    // https://learn.microsoft.com/windows/win32/api/mpeg2data/nf-mpeg2data-impeg2tablefilter-removeextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveExtension(ushort p, byte t, ushort e);
}
