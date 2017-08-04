using Core.Data;
using Core.Data.Attributes;
using System;

namespace SuanKeMeng.Models
{
    [Table(Name = "Topic", Analyzer = Analyzer.Ms, Db = "SuanKeMeng")]
    public class Topic: AbstractModel
    {
        public int TopicId { get; set; }

        public int AccountId { get; set; }

        public int SectorId { get; set; }
        public string Title { get; set; }

        public string TopicText { get; set; }

        public DateTime TopicDate { get; set; }

        public int ReplyCount { get; set; }

        public int ClickingRate { get; set; }

    }

    public class TopicQuery : AbstractQuery<Topic>
    {
        public int? TopicId { get; set; }
        public int? AccountId { get; set; }
        public string Title { get; set; }
        public string TopicText { get; set; }
        public Range<DateTime> TopicDateRange { get; set; }
    }
}
