#nullable enable
namespace DirectN;

[Flags]
public enum FDEX_PROP_FLAGS : uint
{
    fdexPropCanGet = 1,
    fdexPropCannotGet = 2,
    fdexPropCanPut = 4,
    fdexPropCannotPut = 8,
    fdexPropCanPutRef = 16,
    fdexPropCannotPutRef = 32,
    fdexPropNoSideEffects = 64,
    fdexPropDynamicType = 128,
    fdexPropCanCall = 256,
    fdexPropCannotCall = 512,
    fdexPropCanConstruct = 1024,
    fdexPropCannotConstruct = 2048,
    fdexPropCanSourceEvents = 4096,
    fdexPropCannotSourceEvents = 8192,
}
