namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ns-audioenginebaseapo-apoinitsystemeffects
[StructLayout(LayoutKind.Sequential)]
public partial struct APOInitSystemEffects
{
    public APOInitBaseStruct APOInit;
    public nint pAPOEndpointProperties;
    public nint pAPOSystemEffectsProperties;
    public nint pReserved;
    public nint pDeviceCollection;
}
