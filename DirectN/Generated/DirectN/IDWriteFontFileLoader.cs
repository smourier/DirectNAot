#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontfileloader
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49")]
public partial interface IDWriteFontFileLoader
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontfileloader-createstreamfromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStreamFromKey(nint fontFileReferenceKey, uint fontFileReferenceKeySize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFileStream>))] out IDWriteFontFileStream fontFileStream);
}
