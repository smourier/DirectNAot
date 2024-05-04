#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-ipartslist
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6daa848c-5eb0-45cc-aea5-998a2cda1ffb")]
public partial interface IPartsList
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipartslist-getcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCount(out uint pCount);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-ipartslist-getpart
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPart(uint nIndex, out IPart ppPart);
}
