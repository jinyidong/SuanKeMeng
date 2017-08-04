using Core.Data;
using Core.Data.Attributes;

namespace SuanKeMeng.Models
{
    /// <summary>
    /// 论坛版块表
    /// </summary>
    [Table(Name = "Sector", Analyzer = Analyzer.Ms, Db = "SuanKeMeng")]
    public class Sector : AbstractModel
    {
        public int SectorId { get; set; }

        public int AccountId { get; set; }
        //版块名称
        public string SectorName { get; set; }
        //点击率
        public int ClickingRate { get; set; }
        //发帖数
        public int TopicCount { get; set; }
    }

    public class SectorQuery : AbstractQuery<Sector>
    {
        public int? SectorId { get; set; }
        public int? AccountId { get; set; }
        public string SectorName { get; set; }
    }
}
