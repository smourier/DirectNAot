#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-psfeature_output
[StructLayout(LayoutKind.Sequential)]
public partial struct PSFEATURE_OUTPUT
{
    [MarshalAs(UnmanagedType.U4)]
    public bool bPageIndependent;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bSetPageDevice;
}
