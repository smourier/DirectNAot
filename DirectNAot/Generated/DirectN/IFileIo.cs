namespace DirectN;

[GeneratedComInterface, Guid("11993196-1244-4840-ab44-480975c4ffe4")]
public partial interface IFileIo
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(FILE_ACCESSMODE eAccessMode, FILE_OPENMODE eOpenMode, PWSTR pwszFileName);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(ref ulong pqwLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLength(ulong qwLength);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPosition(ref ulong pqwPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCurrentPosition(ulong qwPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsEndOfStream([MarshalAs(UnmanagedType.U4)] ref bool pbEndOfStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(nint /* byte array */ pbt, uint ul, ref uint pulRead);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(nint /* byte array */ pbt, uint ul, ref uint pulWritten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(SEEK_ORIGIN eSeekOrigin, ulong qwSeekOffset, uint dwSeekFlags, ref ulong pqwCurrentPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
