#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("28f54683-06fd-11d2-b27a-00a0c9223196")]
public partial interface IKsTopology
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNodeInstance(uint NodeId, uint Flags, uint DesiredAccess, nint UnkOuter, in Guid InterfaceId, out nint Interface);
}
