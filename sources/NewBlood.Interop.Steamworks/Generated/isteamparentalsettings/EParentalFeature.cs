using System;

namespace NewBlood.Interop.Steamworks;

public enum EParentalFeature
{
    k_EFeatureInvalid = 0,
    k_EFeatureStore = 1,
    k_EFeatureCommunity = 2,
    k_EFeatureProfile = 3,
    k_EFeatureFriends = 4,
    k_EFeatureNews = 5,
    k_EFeatureTrading = 6,
    k_EFeatureSettings = 7,
    k_EFeatureConsole = 8,
    k_EFeatureBrowser = 9,
    k_EFeatureParentalSetup = 10,
    k_EFeatureLibrary = 11,
    k_EFeatureTest = 12,
    k_EFeatureSiteLicense = 13,
    [Obsolete]
    k_EFeatureKioskMode = 14,
    k_EFeatureBlockAlways = 15,
    k_EFeatureMax,
}
