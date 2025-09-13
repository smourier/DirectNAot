#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpfoldermonitorservices
[GeneratedComInterface, Guid("788c8743-e57f-439d-a468-5bc77f2e59c6")]
public partial interface IWMPFolderMonitorServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-get_count
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_count(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-item
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT item(int lIndex, out BSTR pbstrFolder);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-add
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT add(BSTR bstrFolder);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-remove
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT remove(int lIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-get_scanstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_scanState(ref WMPFolderScanState pwmpfss);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-get_currentfolder
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentFolder(out BSTR pbstrFolder);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-get_scannedfilescount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_scannedFilesCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-get_addedfilescount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_addedFilesCount(ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-get_updateprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_updateProgress(ref int plProgress);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-startscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT startScan();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpfoldermonitorservices-stopscan
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT stopScan();
}
