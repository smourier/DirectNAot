#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-psfeature_output
public partial struct PSFEATURE_OUTPUT
{
    public BOOL bPageIndependent;
    public BOOL bSetPageDevice;
}
