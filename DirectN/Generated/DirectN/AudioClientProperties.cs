#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/ns-audioclient-audioclientproperties~r1
public partial struct AudioClientProperties
{
    public uint cbSize;
    public BOOL bIsOffload;
    public AUDIO_STREAM_CATEGORY eCategory;
    public AUDCLNT_STREAMOPTIONS Options;
}
