namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgicommon/ns-dxgicommon-dxgi_sample_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct DXGI_SAMPLE_DESC
{
    public uint Count;
    public uint Quality;
}
