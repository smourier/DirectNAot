#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmplibraryservices
[GeneratedComInterface, Guid("39c2f8d5-1cf2-4d5e-ae09-d73492cf9eaa")]
public partial interface IWMPLibraryServices
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibraryservices-getcountbytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getCountByType(WMPLibraryType wmplt, ref int plCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmplibraryservices-getlibrarybytype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT getLibraryByType(WMPLibraryType wmplt, int lIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPLibrary>))] out IWMPLibrary ppIWMPLibrary);
}
