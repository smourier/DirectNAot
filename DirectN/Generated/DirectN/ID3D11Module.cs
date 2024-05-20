#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shader/nn-d3d11shader-id3d11module
[GeneratedComInterface, Guid("cac701ee-80fc-4122-8242-10b39c8cec34")]
public partial interface ID3D11Module
{
    // https://learn.microsoft.com/windows/win32/api/d3d11shader/nf-d3d11shader-id3d11module-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstance(PSTR pNamespace, out ID3D11ModuleInstance ppModuleInstance);
}
