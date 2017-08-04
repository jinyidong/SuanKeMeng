using Core.Data;
using Core.Data.Attributes;
using System;

namespace SuanKeMeng.Models
{
    [Table(Name = "Reply", Analyzer = Analyzer.Ms, Db = "SuanKeMeng")]
    public class Reply: AbstractModel
    {
        public int ReplyId { get; set; }

        public int TopicId { get; set; }

        public int AccountId { get; set; }

        public string ReplyText { get; set; }

        public DateTime ReplyDate { get; set; }

        public int ClickingRate { get; set; }
    }
}
