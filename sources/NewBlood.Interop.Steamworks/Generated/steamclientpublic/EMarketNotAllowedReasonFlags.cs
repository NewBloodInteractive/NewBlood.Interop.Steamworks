using System;

namespace NewBlood.Interop.Steamworks;

[Flags]
public enum EMarketNotAllowedReasonFlags
{
    k_EMarketNotAllowedReason_None = 0,
    k_EMarketNotAllowedReason_TemporaryFailure = (1 << 0),
    k_EMarketNotAllowedReason_AccountDisabled = (1 << 1),
    k_EMarketNotAllowedReason_AccountLockedDown = (1 << 2),
    k_EMarketNotAllowedReason_AccountLimited = (1 << 3),
    k_EMarketNotAllowedReason_TradeBanned = (1 << 4),
    k_EMarketNotAllowedReason_AccountNotTrusted = (1 << 5),
    k_EMarketNotAllowedReason_SteamGuardNotEnabled = (1 << 6),
    k_EMarketNotAllowedReason_SteamGuardOnlyRecentlyEnabled = (1 << 7),
    k_EMarketNotAllowedReason_RecentPasswordReset = (1 << 8),
    k_EMarketNotAllowedReason_NewPaymentMethod = (1 << 9),
    k_EMarketNotAllowedReason_InvalidCookie = (1 << 10),
    k_EMarketNotAllowedReason_UsingNewDevice = (1 << 11),
    k_EMarketNotAllowedReason_RecentSelfRefund = (1 << 12),
    k_EMarketNotAllowedReason_NewPaymentMethodCannotBeVerified = (1 << 13),
    k_EMarketNotAllowedReason_NoRecentPurchases = (1 << 14),
    k_EMarketNotAllowedReason_AcceptedWalletGift = (1 << 15),
}
