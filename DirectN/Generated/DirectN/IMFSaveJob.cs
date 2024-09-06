#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsavejob
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("e9931663-80bf-4c6e-98af-5dcf58747d1f")]
public partial interface IMFSaveJob
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsavejob-beginsave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginSave(IMFByteStream pStream, IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsavejob-endsave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndSave(IMFAsyncResult pResult);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsavejob-cancelsave
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CancelSave();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsavejob-getprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProgress(out uint pdwPercentComplete);
}
