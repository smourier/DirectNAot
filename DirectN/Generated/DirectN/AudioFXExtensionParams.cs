#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ns-audioenginebaseapo-audiofxextensionparams
[StructLayout(LayoutKind.Sequential)]
public partial struct AudioFXExtensionParams
{
    public LPARAM AddPageParam;
    public PWSTR pwstrEndpointID;
    public nint pFxProperties;
}
