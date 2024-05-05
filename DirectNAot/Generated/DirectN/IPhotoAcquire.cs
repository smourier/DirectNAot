#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/photoacquire/nn-photoacquire-iphotoacquire
[GeneratedComInterface, Guid("00f23353-e31b-4955-a8ad-ca5ebf31e2ce")]
public partial interface IPhotoAcquire
{
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquire-createphotosource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreatePhotoSource(PWSTR pszDevice, out IPhotoAcquireSource ppPhotoAcquireSource);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquire-acquire
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Acquire(IPhotoAcquireSource? pPhotoAcquireSource, [MarshalAs(UnmanagedType.U4)] bool fShowProgress, HWND hWndParent, PWSTR pszApplicationName, IPhotoAcquireProgressCB? pPhotoAcquireProgressCB);
    
    // https://learn.microsoft.com/windows/win32/api/photoacquire/nf-photoacquire-iphotoacquire-enumresults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumResults(out IEnumString ppEnumFilePaths);
}
