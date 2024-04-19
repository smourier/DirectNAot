namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixerlinew
[StructLayout(LayoutKind.Sequential)]
public partial struct MIXERLINEW
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _Target_e__Struct
    {
        public uint dwType;
        public uint dwDeviceID;
        public ushort wMid;
        public ushort wPid;
        public uint vDriverVersion;
        public InlineArraySystemChar32 szPname;
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
    public InlineArraySystemChar16 szShortName;
    public InlineArraySystemChar64 szName;
    public _Target_e__Struct Target;
}
