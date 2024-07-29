#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamphysicalpininfo
[GeneratedComInterface, Guid("f938c991-3029-11cf-8c44-00aa006b6814")]
public partial interface IAMPhysicalPinInfo
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamphysicalpininfo-getphysicaltype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPhysicalType(out int pType, out PWSTR ppszType);
}
