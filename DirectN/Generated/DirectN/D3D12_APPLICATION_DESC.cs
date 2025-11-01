#nullable enable
namespace DirectN;

public partial struct D3D12_APPLICATION_DESC
{
    public PWSTR pExeFilename;
    public PWSTR pName;
    public D3D12_VERSION_NUMBER Version;
    public PWSTR pEngineName;
    public D3D12_VERSION_NUMBER EngineVersion;
}
