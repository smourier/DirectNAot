#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritelocalfontfileloader
[GeneratedComInterface, Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2")]
public partial interface IDWriteLocalFontFileLoader : IDWriteFontFileLoader
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritelocalfontfileloader-getfilepathlengthfromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilePathLengthFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, out uint filePathLength);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritelocalfontfileloader-getfilepathfromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFilePathFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, [MarshalUsing(CountElementName = nameof(filePathSize))] PWSTR filePath, uint filePathSize);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritelocalfontfileloader-getlastwritetimefromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastWriteTimeFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, out FILETIME lastWriteTime);
}
