#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontcollection1
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("53585141-d9f8-4095-8321-d73cf6bd116c")]
public partial interface IDWriteFontCollection1 : IDWriteFontCollection
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontcollection1-getfontset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontSet([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontSet>))] out IDWriteFontSet fontSet);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFamily(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFamily1>))] out IDWriteFontFamily1 fontFamily);
}
