namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmodshow/nn-dmodshow-idmowrapperfilter
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("52d6f586-9f0f-4824-8fc8-e32ca04930c2")]
public partial interface IDMOWrapperFilter
{
    // https://learn.microsoft.com/windows/win32/api/dmodshow/nf-dmodshow-idmowrapperfilter-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(in Guid clsidDMO, in Guid catDMO);
}
