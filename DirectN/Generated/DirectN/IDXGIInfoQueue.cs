#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgidebug/nn-dxgidebug-idxgiinfoqueue
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("d67441c7-672a-476f-9e82-cd55b44949ce")]
public partial interface IDXGIInfoQueue
{
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-setmessagecountlimit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMessageCountLimit(Guid Producer, ulong MessageCountLimit);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-clearstoredmessages
    [PreserveSig]
    void ClearStoredMessages(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMessage(Guid Producer, ulong MessageIndex, nint /* optional DXGI_INFO_QUEUE_MESSAGE* */ pMessage, ref nuint pMessageByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getnumstoredmessagesallowedbyretrievalfilters
    [PreserveSig]
    ulong GetNumStoredMessagesAllowedByRetrievalFilters(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getnumstoredmessages
    [PreserveSig]
    ulong GetNumStoredMessages(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getnummessagesdiscardedbymessagecountlimit
    [PreserveSig]
    ulong GetNumMessagesDiscardedByMessageCountLimit(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getmessagecountlimit
    [PreserveSig]
    ulong GetMessageCountLimit(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getnummessagesallowedbystoragefilter
    [PreserveSig]
    ulong GetNumMessagesAllowedByStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getnummessagesdeniedbystoragefilter
    [PreserveSig]
    ulong GetNumMessagesDeniedByStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-addstoragefilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStorageFilterEntries(Guid Producer, in DXGI_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStorageFilter(Guid Producer, nint /* optional DXGI_INFO_QUEUE_FILTER* */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-clearstoragefilter
    [PreserveSig]
    void ClearStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushemptystoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushEmptyStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushdenyallstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushDenyAllStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushcopyofstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushCopyOfStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushstoragefilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushStorageFilter(Guid Producer, in DXGI_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-popstoragefilter
    [PreserveSig]
    void PopStorageFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getstoragefilterstacksize
    [PreserveSig]
    uint GetStorageFilterStackSize(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-addretrievalfilterentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRetrievalFilterEntries(Guid Producer, in DXGI_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRetrievalFilter(Guid Producer, nint /* optional DXGI_INFO_QUEUE_FILTER* */ pFilter, ref nuint pFilterByteLength);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-clearretrievalfilter
    [PreserveSig]
    void ClearRetrievalFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushemptyretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushEmptyRetrievalFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushdenyallretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushDenyAllRetrievalFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushcopyofretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushCopyOfRetrievalFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-pushretrievalfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PushRetrievalFilter(Guid Producer, in DXGI_INFO_QUEUE_FILTER pFilter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-popretrievalfilter
    [PreserveSig]
    void PopRetrievalFilter(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getretrievalfilterstacksize
    [PreserveSig]
    uint GetRetrievalFilterStackSize(Guid Producer);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-addmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMessage(Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, int ID, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-addapplicationmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, PSTR pDescription);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-setbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBreakOnCategory(Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-setbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBreakOnSeverity(Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-setbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBreakOnID(Guid Producer, int ID, [MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getbreakoncategory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetBreakOnCategory(Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getbreakonseverity
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetBreakOnSeverity(Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getbreakonid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetBreakOnID(Guid Producer, int ID);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-setmutedebugoutput
    [PreserveSig]
    void SetMuteDebugOutput(Guid Producer, [MarshalAs(UnmanagedType.U4)] bool bMute);
    
    // https://learn.microsoft.com/windows/win32/api/dxgidebug/nf-dxgidebug-idxgiinfoqueue-getmutedebugoutput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool GetMuteDebugOutput(Guid Producer);
}
