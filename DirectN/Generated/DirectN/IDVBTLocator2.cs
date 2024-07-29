#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbtlocator2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("448a2edf-ae95-4b43-a3cc-747843c453d4")]
public partial interface IDVBTLocator2 : IDVBTLocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator2-get_physicallayerpipeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhysicalLayerPipeId(out int PhysicalLayerPipeIdVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator2-put_physicallayerpipeid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PhysicalLayerPipeId(int PhysicalLayerPipeIdVal);
}
