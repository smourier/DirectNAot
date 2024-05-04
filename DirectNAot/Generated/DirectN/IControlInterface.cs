#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-icontrolinterface
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("45d37c3f-5140-444a-ae24-400789f3cbf3")]
public partial interface IControlInterface
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-icontrolinterface-getname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetName(out PWSTR ppwstrName);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-icontrolinterface-getiid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIID(out Guid pIID);
}
