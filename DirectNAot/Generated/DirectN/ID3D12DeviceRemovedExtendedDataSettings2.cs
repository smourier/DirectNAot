namespace DirectN;

[GeneratedComInterface, Guid("61552388-01ab-4008-a436-83db189566ea")]
public partial interface ID3D12DeviceRemovedExtendedDataSettings2 : ID3D12DeviceRemovedExtendedDataSettings1
{
    [PreserveSig]
    void UseMarkersOnlyAutoBreadcrumbs([MarshalAs(UnmanagedType.U4)] bool MarkersOnly);
}
