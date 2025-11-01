#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d5682e19-6d21-401c-827a-9a51a4ea35d7")]
public partial interface IDXCoreAdapterFactory1 : IDXCoreAdapterFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAdapterListByWorkload(DXCoreWorkload workload, DXCoreRuntimeFilterFlags runtimeFilter, DXCoreHardwareTypeFilterFlags hardwareTypeFilter, in Guid riid, out nint /* void */ ppvAdapterList);
}
