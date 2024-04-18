namespace DirectN;

[GeneratedComInterface, Guid("67fc5816-e4ca-4915-bf18-42541272da54")]
public partial interface ID3D12DeviceRemovedExtendedData2 : ID3D12DeviceRemovedExtendedData1
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPageFaultAllocationOutput2(out D3D12_DRED_PAGE_FAULT_OUTPUT2 pOutput);
    
    [PreserveSig]
    public D3D12_DRED_DEVICE_STATE GetDeviceState();
}
