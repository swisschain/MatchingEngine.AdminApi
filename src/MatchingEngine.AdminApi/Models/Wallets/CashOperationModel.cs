namespace MatchingEngine.AdminApi.Models.Wallets
{
    /// <summary>
    /// Represents cash operation.
    /// </summary>
    public class CashOperationModel
    {
        public string WalletId { get; set; }

        public string AssetId { get; set; }

        public decimal Amount { get; set; }
    }
}
