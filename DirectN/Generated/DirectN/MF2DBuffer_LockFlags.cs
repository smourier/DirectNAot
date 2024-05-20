#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mf2dbuffer_lockflags
public enum MF2DBuffer_LockFlags
{
    MF2DBuffer_LockFlags_LockTypeMask = 3,
    MF2DBuffer_LockFlags_Read = 1,
    MF2DBuffer_LockFlags_Write = 2,
    MF2DBuffer_LockFlags_ReadWrite = 3,
    MF2DBuffer_LockFlags_ForceDWORD = int.MaxValue,
}
