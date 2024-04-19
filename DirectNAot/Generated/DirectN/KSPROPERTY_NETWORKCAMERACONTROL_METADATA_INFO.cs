namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSPROPERTY_NETWORKCAMERACONTROL_METADATA_INFO
{
    public uint MetadataItems;
    public uint Size;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool PTZStatus;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Events;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Analytics;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool Reserved;
}
