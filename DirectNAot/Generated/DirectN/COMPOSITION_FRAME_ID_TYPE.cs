#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dcomptypes/ne-dcomptypes-composition_frame_id_type
public enum COMPOSITION_FRAME_ID_TYPE
{
    COMPOSITION_FRAME_ID_CREATED = 0,
    COMPOSITION_FRAME_ID_CONFIRMED = 1,
    COMPOSITION_FRAME_ID_COMPLETED = 2,
}
