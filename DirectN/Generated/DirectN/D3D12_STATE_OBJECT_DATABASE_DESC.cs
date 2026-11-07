#nullable enable
namespace DirectN;

public partial struct D3D12_STATE_OBJECT_DATABASE_DESC
{
    public D3D12_STATE_OBJECT_DATABASE_FLAGS Flags;
    public D3D12_JOURNAL_MODE JournalMode;
    public uint BusyTimeoutMs;
}
