namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ns-dxva2api-dxva2_valuerange
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA2_ValueRange
{
    public DXVA2_Fixed32 MinValue;
    public DXVA2_Fixed32 MaxValue;
    public DXVA2_Fixed32 DefaultValue;
    public DXVA2_Fixed32 StepSize;
}
