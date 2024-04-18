namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nn-d3d11sdklayers-id3d11infoqueue
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6543dbb6-1b48-42f5-ab82-e97ec74326f6")]
public partial interface ID3D11InfoQueue
{
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-setmessagecountlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetMessageCountLimit(ulong MessageCountLimit);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-clearstoredmessages
    [PreserveSig]
    public void ClearStoredMessages();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetMessage(ulong MessageIndex, nint/* nint */ pMessage, ref nuint pMessageByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getnummessagesallowedbystoragefilter
    [PreserveSig]
    public ulong GetNumMessagesAllowedByStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getnummessagesdeniedbystoragefilter
    [PreserveSig]
    public ulong GetNumMessagesDeniedByStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getnumstoredmessages
    [PreserveSig]
    public ulong GetNumStoredMessages();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getnumstoredmessagesallowedbyretrievalfilter
    [PreserveSig]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getnummessagesdiscardedbymessagecountlimit
    [PreserveSig]
    public ulong GetNumMessagesDiscardedByMessageCountLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getmessagecountlimit
    [PreserveSig]
    public ulong GetMessageCountLimit();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-addstoragefilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddStorageFilterEntries(in D3D11_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetStorageFilter(nint/* nint */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-clearstoragefilter
    [PreserveSig]
    public void ClearStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-pushemptystoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushEmptyStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-pushcopyofstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushCopyOfStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-pushstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushStorageFilter(in D3D11_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-popstoragefilter
    [PreserveSig]
    public void PopStorageFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getstoragefilterstacksize
    [PreserveSig]
    public uint GetStorageFilterStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-addretrievalfilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddRetrievalFilterEntries(in D3D11_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetRetrievalFilter(nint/* nint */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-clearretrievalfilter
    [PreserveSig]
    public void ClearRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-pushemptyretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushEmptyRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-pushcopyofretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushCopyOfRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-pushretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT PushRetrievalFilter(in D3D11_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-popretrievalfilter
    [PreserveSig]
    public void PopRetrievalFilter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getretrievalfilterstacksize
    [PreserveSig]
    public uint GetRetrievalFilterStackSize();
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-addmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddMessage(D3D11_MESSAGE_CATEGORY Category, D3D11_MESSAGE_SEVERITY Severity, D3D11_MESSAGE_ID ID, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-addapplicationmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT AddApplicationMessage(D3D11_MESSAGE_SEVERITY Severity, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-setbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnCategory(D3D11_MESSAGE_CATEGORY Category, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-setbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnSeverity(D3D11_MESSAGE_SEVERITY Severity, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-setbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetBreakOnID(D3D11_MESSAGE_ID ID, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnCategory(D3D11_MESSAGE_CATEGORY Category);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnSeverity(D3D11_MESSAGE_SEVERITY Severity);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetBreakOnID(D3D11_MESSAGE_ID ID);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-setmutedebugoutput
    [PreserveSig]
    public void SetMuteDebugOutput([MarshalAs(UnmanagedType.U4)] bool bMute);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11sdklayers/nf-d3d11sdklayers-id3d11infoqueue-getmutedebugoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool GetMuteDebugOutput();
}
