﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/ne-wmp-wmpopenstate
public enum WMPOpenState
{
    wmposUndefined = 0,
    wmposPlaylistChanging = 1,
    wmposPlaylistLocating = 2,
    wmposPlaylistConnecting = 3,
    wmposPlaylistLoading = 4,
    wmposPlaylistOpening = 5,
    wmposPlaylistOpenNoMedia = 6,
    wmposPlaylistChanged = 7,
    wmposMediaChanging = 8,
    wmposMediaLocating = 9,
    wmposMediaConnecting = 10,
    wmposMediaLoading = 11,
    wmposMediaOpening = 12,
    wmposMediaOpen = 13,
    wmposBeginCodecAcquisition = 14,
    wmposEndCodecAcquisition = 15,
    wmposBeginLicenseAcquisition = 16,
    wmposEndLicenseAcquisition = 17,
    wmposBeginIndividualization = 18,
    wmposEndIndividualization = 19,
    wmposMediaWaiting = 20,
    wmposOpeningUnknownURL = 21,
}
