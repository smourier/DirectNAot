#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ed342442-6343-4e16-bb82-a3a577874e56")]
public partial interface ID3D12DeviceConfiguration1 : ID3D12DeviceConfiguration
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(nint pLibraryBlob, nuint Size, PWSTR RootSignatureSubobjectName, in Guid riid, out nint /* void */ ppvDeserializer);
}
