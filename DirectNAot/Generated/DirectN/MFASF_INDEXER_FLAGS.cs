namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/ne-wmcontainer-mfasf_indexer_flags
public enum MFASF_INDEXER_FLAGS
{
    MFASF_INDEXER_WRITE_NEW_INDEX = 1,
    MFASF_INDEXER_READ_FOR_REVERSEPLAYBACK = 2,
    MFASF_INDEXER_WRITE_FOR_LIVEREAD = 4,
}
