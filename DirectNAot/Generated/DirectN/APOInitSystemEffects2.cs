namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ns-audioenginebaseapo-apoinitsystemeffects2
[StructLayout(LayoutKind.Sequential)]
public partial struct APOInitSystemEffects2
{
    public APOInitBaseStruct APOInit;
    public nint pAPOEndpointProperties;
    public nint pAPOSystemEffectsProperties;
    public nint pReserved;
    public nint pDeviceCollection;
    public uint nSoftwareIoDeviceInCollection;
    public uint nSoftwareIoConnectorIndex;
    public Guid AudioProcessingMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool InitializeForDiscoveryOnly;
}
