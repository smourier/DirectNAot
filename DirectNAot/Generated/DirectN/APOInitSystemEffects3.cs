namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioengineextensionapo/ns-audioengineextensionapo-apoinitsystemeffects3
[StructLayout(LayoutKind.Sequential)]
public partial struct APOInitSystemEffects3
{
    public APOInitBaseStruct APOInit;
    public nint pAPOEndpointProperties;
    public nint pServiceProvider;
    public nint pDeviceCollection;
    public uint nSoftwareIoDeviceInCollection;
    public uint nSoftwareIoConnectorIndex;
    public Guid AudioProcessingMode;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool InitializeForDiscoveryOnly;
}
