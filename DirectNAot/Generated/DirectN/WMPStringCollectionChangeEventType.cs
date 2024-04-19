namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpstringcollectionchangeeventtype
public enum WMPStringCollectionChangeEventType
{
    wmpsccetUnknown = 0,
    wmpsccetInsert = 1,
    wmpsccetChange = 2,
    wmpsccetDelete = 3,
    wmpsccetClear = 4,
    wmpsccetBeginUpdates = 5,
    wmpsccetEndUpdates = 6,
}
