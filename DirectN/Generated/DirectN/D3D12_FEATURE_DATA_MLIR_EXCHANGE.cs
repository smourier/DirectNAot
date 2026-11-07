#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_MLIR_EXCHANGE
{
    public D3D12_MLIR_EXCHANGE_TYPE Type;
    public D3D12_VERSION_NUMBER IRVersion;
    public nint pInputData;
    public nuint InputDataSizeInBytes;
    public nint pOutputData;
    public nint OutputDataSizeInBytes;
}
