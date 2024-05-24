#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixerlinea
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERLINEA
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct _Target_e__Struct
    {
        public uint dwType;
        public uint dwDeviceID;
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        public InlineArrayFoundationCHAR_32 szPname;
    }
    
    public uint cbStruct;
    public uint dwDestination;
    public uint dwSource;
    public uint dwLineID;
    public uint fdwLine;
    public nuint dwUser;
    public MIXERLINE_COMPONENTTYPE dwComponentType;
    public uint cChannels;
    public uint cConnections;
    public uint cControls;
    public InlineArrayFoundationCHAR_16 szShortName;
    public InlineArrayFoundationCHAR_64 szName;
    public _Target_e__Struct Target;
}
