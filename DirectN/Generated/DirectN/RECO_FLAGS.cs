#nullable enable
namespace DirectN;

[Flags]
public enum RECO_FLAGS : uint
{
    RECO_PASTE = 0,
    RECO_DROP = 1,
    RECO_COPY = 2,
    RECO_CUT = 3,
    RECO_DRAG = 4,
}
