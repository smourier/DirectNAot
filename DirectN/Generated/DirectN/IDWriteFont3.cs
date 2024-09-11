#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefont3
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("29748ed6-8c9c-4a6a-be0b-d912e8538944")]
public partial interface IDWriteFont3 : IDWriteFont2
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-createfontface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateFontFace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFace3>))] out IDWriteFontFace3 fontFace);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-equals
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL Equals([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFont>))] IDWriteFont font);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-getfontfacereference
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFaceReference([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFaceReference>))] out IDWriteFontFaceReference fontFaceReference);
    
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL HasCharacter(uint unicodeValue);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefont3-getlocality
    [PreserveSig]
    DWRITE_LOCALITY GetLocality();
}
