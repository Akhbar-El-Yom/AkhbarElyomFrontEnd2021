using System;
using System.Collections.Generic;

#nullable disable

namespace MVC.Data
{
    public partial class NewsVersion
    {
        public long VersionId { get; set; }
        public int? NewId { get; set; }
        public int SectionId { get; set; }
        public int? CategoryId { get; set; }
        public int ParentId { get; set; }
        public int NewsType { get; set; }
        public byte NewsSource { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Story { get; set; }
        public string Brief { get; set; }
        public string Quote { get; set; }
        public string Keywords { get; set; }
        public int PictureId1 { get; set; }
        public int PictureId2 { get; set; }
        public string PictureCaption1 { get; set; }
        public string PictureCaption2 { get; set; }
        public DateTime? PublishDate { get; set; }
        public int EditorId { get; set; }
        public string ByLine { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? AddedBy { get; set; }
        public int Version { get; set; }
        public int? JournalId { get; set; }
        public string Notes { get; set; }
        public string SocialTitle { get; set; }
        public int? SocialPictureId { get; set; }
        public string SocialPictureCaption { get; set; }
        public int? SocialEditorId { get; set; }
        public DateTime? SdeskDate { get; set; }
        public int? SectionId1 { get; set; }
        public int? SectionId2 { get; set; }
        public int? SectionId3 { get; set; }
        public int? SectionId4 { get; set; }
        public int? SectionId5 { get; set; }
        public int? SectionId6 { get; set; }
        public int? SectionId7 { get; set; }
        public int? SectionId8 { get; set; }
        public int? SectionId9 { get; set; }
    }
}
