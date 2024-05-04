#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpevents
[GeneratedComInterface, Guid("19a6627b-da9e-47c1-bb23-00b5e668236a")]
public partial interface IWMPEvents
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-openstatechange
    [PreserveSig]
    void OpenStateChange(int NewState);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playstatechange
    [PreserveSig]
    void PlayStateChange(int NewState);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-audiolanguagechange
    [PreserveSig]
    void AudioLanguageChange(int LangID);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-statuschange
    [PreserveSig]
    void StatusChange();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-scriptcommand
    [PreserveSig]
    void ScriptCommand(BSTR scType, BSTR Param);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-newstream
    [PreserveSig]
    void NewStream();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-disconnect
    [PreserveSig]
    void Disconnect(int Result);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-buffering
    [PreserveSig]
    void Buffering(VARIANT_BOOL Start);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-error
    [PreserveSig]
    void Error();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-warning
    [PreserveSig]
    void Warning(int WarningType, int Param, BSTR Description);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-endofstream
    [PreserveSig]
    void EndOfStream(int Result);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-positionchange
    [PreserveSig]
    void PositionChange(double oldPosition, double newPosition);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-markerhit
    [PreserveSig]
    void MarkerHit(int MarkerNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-durationunitchange
    [PreserveSig]
    void DurationUnitChange(int NewDurationUnit);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-cdrommediachange
    [PreserveSig]
    void CdromMediaChange(int CdromNum);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playlistchange
    [PreserveSig]
    void PlaylistChange(IDispatch Playlist, WMPPlaylistChangeEventType change);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-currentplaylistchange
    [PreserveSig]
    void CurrentPlaylistChange(WMPPlaylistChangeEventType change);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-currentplaylistitemavailable
    [PreserveSig]
    void CurrentPlaylistItemAvailable(BSTR bstrItemName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mediachange
    [PreserveSig]
    void MediaChange(IDispatch Item);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-currentmediaitemavailable
    [PreserveSig]
    void CurrentMediaItemAvailable(BSTR bstrItemName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-currentitemchange
    [PreserveSig]
    void CurrentItemChange(IDispatch pdispMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mediacollectionchange
    [PreserveSig]
    void MediaCollectionChange();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mediacollectionattributestringadded
    [PreserveSig]
    void MediaCollectionAttributeStringAdded(BSTR bstrAttribName, BSTR bstrAttribVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mediacollectionattributestringremoved
    [PreserveSig]
    void MediaCollectionAttributeStringRemoved(BSTR bstrAttribName, BSTR bstrAttribVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mediacollectionattributestringchanged
    [PreserveSig]
    void MediaCollectionAttributeStringChanged(BSTR bstrAttribName, BSTR bstrOldAttribVal, BSTR bstrNewAttribVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playlistcollectionchange
    [PreserveSig]
    void PlaylistCollectionChange();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playlistcollectionplaylistadded
    [PreserveSig]
    void PlaylistCollectionPlaylistAdded(BSTR bstrPlaylistName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playlistcollectionplaylistremoved
    [PreserveSig]
    void PlaylistCollectionPlaylistRemoved(BSTR bstrPlaylistName);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playlistcollectionplaylistsetasdeleted
    [PreserveSig]
    void PlaylistCollectionPlaylistSetAsDeleted(BSTR bstrPlaylistName, VARIANT_BOOL varfIsDeleted);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-modechange
    [PreserveSig]
    void ModeChange(BSTR ModeName, VARIANT_BOOL NewValue);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mediaerror
    [PreserveSig]
    void MediaError(IDispatch pMediaObject);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-openplaylistswitch
    [PreserveSig]
    void OpenPlaylistSwitch(IDispatch pItem);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-domainchange
    [PreserveSig]
    void DomainChange(BSTR strDomain);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-switchedtoplayerapplication
    [PreserveSig]
    void SwitchedToPlayerApplication();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-switchedtocontrol
    [PreserveSig]
    void SwitchedToControl();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playerdockedstatechange
    [PreserveSig]
    void PlayerDockedStateChange();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-playerreconnect
    [PreserveSig]
    void PlayerReconnect();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-click
    [PreserveSig]
    void Click(short nButton, short nShiftState, int fX, int fY);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-doubleclick
    [PreserveSig]
    void DoubleClick(short nButton, short nShiftState, int fX, int fY);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-keydown
    [PreserveSig]
    void KeyDown(short nKeyCode, short nShiftState);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-keypress
    [PreserveSig]
    void KeyPress(short nKeyAscii);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-keyup
    [PreserveSig]
    void KeyUp(short nKeyCode, short nShiftState);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mousedown
    [PreserveSig]
    void MouseDown(short nButton, short nShiftState, int fX, int fY);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mousemove
    [PreserveSig]
    void MouseMove(short nButton, short nShiftState, int fX, int fY);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpevents-mouseup
    [PreserveSig]
    void MouseUp(short nButton, short nShiftState, int fX, int fY);
}
