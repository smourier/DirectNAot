#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclientactivationparams/ns-audioclientactivationparams-audioclient_activation_params
public partial struct AUDIOCLIENT_ACTIVATION_PARAMS
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS ProcessLoopbackParams;
    }
    
    public AUDIOCLIENT_ACTIVATION_TYPE ActivationType;
    public _Anonymous_e__Union Anonymous;
}
