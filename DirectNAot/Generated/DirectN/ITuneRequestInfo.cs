namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdatif/nn-bdatif-itunerequestinfo
[GeneratedComInterface, Guid("a3b152df-7a90-4218-ac54-9830bee8c0b6")]
public partial interface ITuneRequestInfo
{
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-getlocatordata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocatorData(ITuneRequest Request);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-getcomponentdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponentData(ITuneRequest CurrentRequest);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-createcomponentlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateComponentList(ITuneRequest CurrentRequest);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-getnextprogram
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextProgram(ITuneRequest CurrentRequest, out ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-getpreviousprogram
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreviousProgram(ITuneRequest CurrentRequest, out ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-getnextlocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextLocator(ITuneRequest CurrentRequest, out ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/bdatif/nf-bdatif-itunerequestinfo-getpreviouslocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPreviousLocator(ITuneRequest CurrentRequest, out ITuneRequest TuneRequest);
}
