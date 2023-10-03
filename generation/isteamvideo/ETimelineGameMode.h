#pragma once

// Temporary header because Steamworks SDK 1.58 contains an outdated isteamvideo.h
// This breaks compilation of steam_api_flat.h, so we need to define it ourselves.
// Luckily, steam_api.json has the actual definitions, so we can copy them here.

enum ETimelineGameMode
{
    k_ETimelineGameMode_Invalid = 0,
    k_ETimelineGameMode_Playing = 1,
    k_ETimelineGameMode_Staging = 2,
    k_ETimelineGameMode_Menus = 3,
    k_ETimelineGameMode_Max = 4,
};
