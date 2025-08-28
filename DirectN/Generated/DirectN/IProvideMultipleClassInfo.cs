#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iprovidemultipleclassinfo
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a7aba9c1-8983-11cf-8f20-00805f2cd064")]
public partial interface IProvideMultipleClassInfo : IProvideClassInfo2
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iprovidemultipleclassinfo-getmultitypeinfocount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMultiTypeInfoCount(out uint pcti);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iprovidemultipleclassinfo-getinfoofindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInfoOfIndex(uint iti, MULTICLASSINFO_FLAGS dwFlags, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITypeInfo>))] out ITypeInfo pptiCoClass, out uint pdwTIFlags, out uint pcdispidReserved, out Guid piidPrimary, out Guid piidSource);
}
