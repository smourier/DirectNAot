namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nn-d3d10sdklayers-id3d10infoqueue
[GeneratedComInterface, Guid("1b940b17-2642-4d1f-ab1f-b99bad0c395f")]
public partial interface ID3D10InfoQueue
{
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-setmessagecountlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMessageCountLimit(ulong MessageCountLimit);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-clearstoredmessages
    [PreserveSig]
    public void ClearStoredMessages();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMessage(ulong MessageIndex, nint/* nint */ pMessage, ref nuint pMessageByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getnummessagesallowedbystoragefilter
    [PreserveSig]
    public ulong GetNumMessagesAllowedByStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getnummessagesdeniedbystoragefilter
    [PreserveSig]
    public ulong GetNumMessagesDeniedByStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getnumstoredmessages
    [PreserveSig]
    public ulong GetNumStoredMessages();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getnumstoredmessagesallowedbyretrievalfilter
    [PreserveSig]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getnummessagesdiscardedbymessagecountlimit
    [PreserveSig]
    public ulong GetNumMessagesDiscardedByMessageCountLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getmessagecountlimit
    [PreserveSig]
    public ulong GetMessageCountLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-addstoragefilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddStorageFilterEntries(in D3D10_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStorageFilter(nint/* nint */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-clearstoragefilter
    [PreserveSig]
    public void ClearStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-pushemptystoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushEmptyStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-pushcopyofstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushCopyOfStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-pushstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushStorageFilter(in D3D10_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-popstoragefilter
    [PreserveSig]
    public void PopStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getstoragefilterstacksize
    [PreserveSig]
    public uint GetStorageFilterStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-addretrievalfilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddRetrievalFilterEntries(in D3D10_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRetrievalFilter(nint/* nint */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-clearretrievalfilter
    [PreserveSig]
    public void ClearRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-pushemptyretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushEmptyRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-pushcopyofretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushCopyOfRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-pushretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushRetrievalFilter(in D3D10_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-popretrievalfilter
    [PreserveSig]
    public void PopRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getretrievalfilterstacksize
    [PreserveSig]
    public uint GetRetrievalFilterStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-addmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddMessage(D3D10_MESSAGE_CATEGORY Category, D3D10_MESSAGE_SEVERITY Severity, D3D10_MESSAGE_ID ID, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-addapplicationmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddApplicationMessage(D3D10_MESSAGE_SEVERITY Severity, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-setbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-setbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-setbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnID(D3D10_MESSAGE_ID ID, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnID(D3D10_MESSAGE_ID ID);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-setmutedebugoutput
    [PreserveSig]
    public void SetMuteDebugOutput([MarshalAs(UnmanagedType.U4)] bool bMute);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10sdklayers/nf-d3d10sdklayers-id3d10infoqueue-getmutedebugoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetMuteDebugOutput();
}
