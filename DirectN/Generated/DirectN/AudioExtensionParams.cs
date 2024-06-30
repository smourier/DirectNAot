#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmdeviceapi/ns-mmdeviceapi-audioextensionparams
public partial struct AudioExtensionParams
{
    public LPARAM AddPageParam;
    public nint pEndpoint;
    public nint pPnpInterface;
    public nint pPnpDevnode;
}
