using System.ComponentModel.DataAnnotations.Schema;

namespace GameDB
{
    public enum ProviderType
    {
        None = 0,
        Guest = 1,
        Google = 2,
    }

    [Table("Account")]
    public class AccountDb
    {
        public int AccountDbId { get; set; } // PK
        public string LoginProviderUserId { get; set; } = string.Empty;
        public ProviderType LoginProviderType { get; set; }
    }
}

