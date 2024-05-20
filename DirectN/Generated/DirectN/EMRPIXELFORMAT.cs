#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-emrpixelformat
[StructLayout(LayoutKind.Sequential)]
public partial struct EMRPIXELFORMAT
{
    public EMR emr;
    public PIXELFORMATDESCRIPTOR pfd;
}
