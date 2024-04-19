namespace DirectN;

[GeneratedComInterface, Guid("dbd5ae51-3317-4f0a-adf9-1d7cedcaae0b")]
public partial interface ID3D12DeviceRemovedExtendedDataSettings1 : ID3D12DeviceRemovedExtendedDataSettings
{
    [PreserveSig]
    void SetBreadcrumbContextEnablement(D3D12_DRED_ENABLEMENT Enablement);
}
