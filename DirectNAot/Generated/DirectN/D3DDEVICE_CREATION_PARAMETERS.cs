namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3d9/d3ddevice-creation-parameters
[StructLayout(LayoutKind.Sequential)]
public partial struct D3DDEVICE_CREATION_PARAMETERS
{
    public uint AdapterOrdinal;
    public D3DDEVTYPE DeviceType;
    public HWND hFocusWindow;
    public uint BehaviorFlags;
}
