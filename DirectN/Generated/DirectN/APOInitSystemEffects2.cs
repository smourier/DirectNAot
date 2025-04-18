#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ns-audioenginebaseapo-apoinitsystemeffects2
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
    public BOOL InitializeForDiscoveryOnly;
}
