#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxmini/ns-dxmini-dx_irqdata
[StructLayout(LayoutKind.Sequential)]
public partial struct DX_IRQDATA
{
    public uint dwIrqFlags;
}
