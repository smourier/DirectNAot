#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("bfccd196-1244-4840-ab44-480975c4ffe4")]
public partial interface IFileClient
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObjectDiskSize(ref ulong pqwSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(IFileIo pFio);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(IFileIo pFio);
}
