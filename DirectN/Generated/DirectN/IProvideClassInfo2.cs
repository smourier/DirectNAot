#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iprovideclassinfo2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("a6bc3ac0-dbaa-11ce-9de3-00aa004bb851")]
public partial interface IProvideClassInfo2 : IProvideClassInfo
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iprovideclassinfo2-getguid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGUID(uint dwGuidKind, out Guid pGUID);
}
