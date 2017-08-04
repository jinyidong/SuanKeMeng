using Core.Data;
using Core.Data.Attributes;

namespace SuanKeMeng.Models
{
    [Table(Name = "Account", Analyzer = Analyzer.Ms, Db = "SuanKeMeng")]
    public class Account: AbstractModel
    {
        public int AccountId { get; set; }

        public string NiceName { get; set; }

        public string Psw { get; set; }

        public string EMail { get; set; }
    }
}
