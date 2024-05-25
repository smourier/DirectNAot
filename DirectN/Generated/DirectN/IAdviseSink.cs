#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-iadvisesink
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000010f-0000-0000-c000-000000000046")]
public partial interface IAdviseSink
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-iadvisesink-ondatachange
    [PreserveSig]
    void OnDataChange(in FORMATETC pFormatetc, in STGMEDIUM pStgmed);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-iadvisesink-onviewchange
    [PreserveSig]
    void OnViewChange(uint dwAspect, int lindex);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-iadvisesink-onrename
    [PreserveSig]
    void OnRename(IMoniker pmk);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-iadvisesink-onsave
    [PreserveSig]
    void OnSave();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-iadvisesink-onclose
    [PreserveSig]
    void OnClose();
}
