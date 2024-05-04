#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12device5
[SupportedOSPlatform("windows10.0.17763")]
[GeneratedComInterface, Guid("8b4f173b-2fea-4b80-8f58-4307191ab95d")]
public partial interface ID3D12Device5 : ID3D12Device4
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-createlifetimetracker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateLifetimeTracker(ID3D12LifetimeOwner pOwner, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvTracker);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-removedevice
    [PreserveSig]
    void RemoveDevice();
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-enumeratemetacommands
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateMetaCommands(ref uint pNumMetaCommands, nint /* optional D3D12_META_COMMAND_DESC* */ pDescs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-enumeratemetacommandparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumerateMetaCommandParameters(in Guid CommandId, D3D12_META_COMMAND_PARAMETER_STAGE Stage, nint /* optional uint* */ pTotalStructureSizeInBytes, ref uint pParameterCount, nint /* optional D3D12_META_COMMAND_PARAMETER_DESC* */ pParameterDescs);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-createmetacommand
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMetaCommand(in Guid CommandId, uint NodeMask, nint /* optional void* */ pCreationParametersData, nuint CreationParametersDataSizeInBytes, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppMetaCommand);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-createstateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStateObject(in D3D12_STATE_OBJECT_DESC pDesc, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppStateObject);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-getraytracingaccelerationstructureprebuildinfo
    [PreserveSig]
    void GetRaytracingAccelerationStructurePrebuildInfo(in D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS pDesc, out D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO pInfo);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12device5-checkdrivermatchingidentifier
    [PreserveSig]
    D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS CheckDriverMatchingIdentifier(D3D12_SERIALIZED_DATA_TYPE SerializedDataType, in D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER pIdentifierToCheck);
}
