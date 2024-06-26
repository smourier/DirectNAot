﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-mixercontroldetails
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIXERCONTROLDETAILS
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HWND hwndOwner;
        
        [FieldOffset(0)]
        public uint cMultipleItems;
    }
    
    public uint cbStruct;
    public uint dwControlID;
    public uint cChannels;
    public _Anonymous_e__Union Anonymous;
    public uint cbDetails;
    public nint paDetails;
}
