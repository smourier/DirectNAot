#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioenginebaseapo/ns-audioenginebaseapo-apoinitbasestruct
public partial struct APOInitBaseStruct
{
    public uint cbSize;
    public Guid clsid;
}
