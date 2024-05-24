#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/Multimedia/mci-generic-parms
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MCI_GENERIC_PARMS
{
    public static readonly MCI_GENERIC_PARMS Null = new();
    
    public nuint dwCallback;
}
