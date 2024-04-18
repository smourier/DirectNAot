namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nn-d3d12sdklayers-id3d12infoqueue
[GeneratedComInterface, Guid("0742a90b-c387-483f-b946-30a7e4e61458")]
public partial interface ID3D12InfoQueue
{
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-setmessagecountlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMessageCountLimit(ulong MessageCountLimit);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-clearstoredmessages
    [PreserveSig]
    public void ClearStoredMessages();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMessage(ulong MessageIndex, nint/* nint */ pMessage, ref nuint pMessageByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getnummessagesallowedbystoragefilter
    [PreserveSig]
    public ulong GetNumMessagesAllowedByStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getnummessagesdeniedbystoragefilter
    [PreserveSig]
    public ulong GetNumMessagesDeniedByStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getnumstoredmessages
    [PreserveSig]
    public ulong GetNumStoredMessages();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getnumstoredmessagesallowedbyretrievalfilter
    [PreserveSig]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getnummessagesdiscardedbymessagecountlimit
    [PreserveSig]
    public ulong GetNumMessagesDiscardedByMessageCountLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getmessagecountlimit
    [PreserveSig]
    public ulong GetMessageCountLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-addstoragefilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddStorageFilterEntries(in D3D12_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStorageFilter(nint/* nint */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-clearstoragefilter
    [PreserveSig]
    public void ClearStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-pushemptystoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushEmptyStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-pushcopyofstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushCopyOfStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-pushstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushStorageFilter(in D3D12_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-popstoragefilter
    [PreserveSig]
    public void PopStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getstoragefilterstacksize
    [PreserveSig]
    public uint GetStorageFilterStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-addretrievalfilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddRetrievalFilterEntries(in D3D12_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRetrievalFilter(nint/* nint */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-clearretrievalfilter
    [PreserveSig]
    public void ClearRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-pushemptyretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushEmptyRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-pushcopyofretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushCopyOfRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-pushretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushRetrievalFilter(in D3D12_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-popretrievalfilter
    [PreserveSig]
    public void PopRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getretrievalfilterstacksize
    [PreserveSig]
    public uint GetRetrievalFilterStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-addmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddMessage(D3D12_MESSAGE_CATEGORY Category, D3D12_MESSAGE_SEVERITY Severity, D3D12_MESSAGE_ID ID, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-addapplicationmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddApplicationMessage(D3D12_MESSAGE_SEVERITY Severity, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-setbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-setbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-setbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnID(D3D12_MESSAGE_ID ID, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnID(D3D12_MESSAGE_ID ID);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-setmutedebugoutput
    [PreserveSig]
    public void SetMuteDebugOutput([MarshalAs(UnmanagedType.U4)] bool bMute);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12sdklayers/nf-d3d12sdklayers-id3d12infoqueue-getmutedebugoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetMuteDebugOutput();
}
