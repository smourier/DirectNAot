namespace DirectN;

// https://learn.microsoft.com/windows/win32/WES/eventmanifestschema-channeltype-complextype
public enum ChannelType
{
    ChannelTypeNone = 0,
    ChannelTypeOther = 1,
    ChannelTypeVideo = 2,
    ChannelTypeAudio = 4,
    ChannelTypeText = 8,
    ChannelTypeSubtitles = 16,
    ChannelTypeCaptions = 32,
    ChannelTypeSuperimpose = 64,
    ChannelTypeData = 128,
}
