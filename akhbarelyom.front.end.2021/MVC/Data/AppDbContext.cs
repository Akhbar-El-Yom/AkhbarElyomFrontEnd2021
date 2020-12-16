using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVC.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminEditor> AdminEditors { get; set; }
        public virtual DbSet<AdminLog> AdminLogs { get; set; }
        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<BlocksZone> BlocksZones { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<ByLine> ByLines { get; set; }
        public virtual DbSet<ByLineTitle> ByLineTitles { get; set; }
        public virtual DbSet<ComicsofDay> ComicsofDays { get; set; }
        public virtual DbSet<Editor> Editors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Gallery> Galleries { get; set; }
        public virtual DbSet<GalleryPicture> GalleryPictures { get; set; }
        public virtual DbSet<GalleryType> GalleryTypes { get; set; }
        public virtual DbSet<HomeMostCommented> HomeMostCommenteds { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Issues2> Issues2s { get; set; }
        public virtual DbSet<IssuesNews> IssuesNews { get; set; }
        public virtual DbSet<IssuesTopNews> IssuesTopNews { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<LeadsReg> LeadsRegs { get; set; }
        public virtual DbSet<LinkedNews> LinkedNews { get; set; }
        public virtual DbSet<MainSection> MainSections { get; set; }
        public virtual DbSet<NatigaPrep2019Swe> NatigaPrep2019Swes { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsBlock> NewsBlocks { get; set; }
        public virtual DbSet<NewsByline> NewsBylines { get; set; }
        public virtual DbSet<NewsCategory> NewsCategories { get; set; }
        public virtual DbSet<NewsGallery> NewsGalleries { get; set; }
        public virtual DbSet<NewsGallery1> NewsGalleries1 { get; set; }
        public virtual DbSet<NewsPicture> NewsPictures { get; set; }
        public virtual DbSet<NewsPicturesCat> NewsPicturesCats { get; set; }
        public virtual DbSet<NewsPoll> NewsPolls { get; set; }
        public virtual DbSet<NewsSearch> NewsSearches { get; set; }
        public virtual DbSet<NewsSection> NewsSections { get; set; }
        public virtual DbSet<NewsStatus> NewsStatuses { get; set; }
        public virtual DbSet<NewsTag> NewsTags { get; set; }
        public virtual DbSet<NewsTicker> NewsTickers { get; set; }
        public virtual DbSet<NewsVersion> NewsVersions { get; set; }
        public virtual DbSet<NewsVideo> NewsVideos { get; set; }
        public virtual DbSet<NewsView> NewsViews { get; set; }
        public virtual DbSet<NewsViewsLog> NewsViewsLogs { get; set; }
        public virtual DbSet<PictureofDay> PictureofDays { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<PollsOption> PollsOptions { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<QuestionSelect> QuestionSelects { get; set; }
        public virtual DbSet<Quetion> Quetions { get; set; }
        public virtual DbSet<QuetionResult> QuetionResults { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<RelatedNews> RelatedNews { get; set; }
        public virtual DbSet<Reviewer> Reviewers { get; set; }
        public virtual DbSet<ReviewerNews> ReviewerNews { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleService> RoleServices { get; set; }
        public virtual DbSet<SectionLatestNews> SectionLatestNews { get; set; }
        public virtual DbSet<SesstionText> SesstionTexts { get; set; }
        public virtual DbSet<SportMal3b> SportMal3bs { get; set; }
        public virtual DbSet<SportMatch> SportMatches { get; set; }
        public virtual DbSet<SportTeam> SportTeams { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<TempDeskShift> TempDeskShifts { get; set; }
        public virtual DbSet<TempDifferntBylineShape> TempDifferntBylineShapes { get; set; }
        public virtual DbSet<TopNews> TopNews { get; set; }
        public virtual DbSet<TraceTable> TraceTables { get; set; }
        public virtual DbSet<Trend> Trends { get; set; }
        public virtual DbSet<Ummodule> Ummodules { get; set; }
        public virtual DbSet<Umservice> Umservices { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UsersOpinion> UsersOpinions { get; set; }
        public virtual DbSet<VTopNewsToday> VTopNewsTodays { get; set; }
        public virtual DbSet<VersionTag> VersionTags { get; set; }
        public virtual DbSet<VideoFeed> VideoFeeds { get; set; }
        public virtual DbSet<VuserPermission> VuserPermissions { get; set; }
        public virtual DbSet<Wdgt> Wdgts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminEditor>(entity =>
            {
                entity.HasKey(e => e.EditorId);

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.EditorName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<AdminLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("AdminLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogQueryString).HasMaxLength(200);

                entity.Property(e => e.LogRemoteAddress).HasMaxLength(50);

                entity.Property(e => e.LogServerName).HasMaxLength(50);

                entity.Property(e => e.LogUrl)
                    .HasMaxLength(200)
                    .HasColumnName("LogURL");

                entity.Property(e => e.LogUserId).HasColumnName("LogUserID");
            });

            modelBuilder.Entity<AdminUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_Admin_Users");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AboutYourSelf).HasColumnType("ntext");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BirthDay).HasColumnType("datetime");

                entity.Property(e => e.BirthPlace).HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EducationalQualification).HasMaxLength(1000);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LastLive).HasColumnType("datetime");

                entity.Property(e => e.NickName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Type).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserEmail).HasMaxLength(50);

                entity.Property(e => e.UserFb)
                    .HasMaxLength(50)
                    .HasColumnName("UserFB");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhoto).HasMaxLength(50);

                entity.Property(e => e.UserTwitter).HasMaxLength(50);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_Attachment");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Discription).HasMaxLength(500);

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.NewId).HasColumnName("NewID");
            });

            modelBuilder.Entity<BlocksZone>(entity =>
            {
                entity.HasKey(e => e.ZoneId);

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ZoneDescription).HasMaxLength(1000);

                entity.Property(e => e.ZoneName).HasMaxLength(100);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("books");

                entity.Property(e => e.Author)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("author");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<ByLine>(entity =>
            {
                entity.ToTable("ByLine");

                entity.HasIndex(e => e.ByLineName, "NonClusteredIndex-20181103-183546");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ByLineName).HasMaxLength(100);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ByLineTitle>(entity =>
            {
                entity.HasKey(e => e.TitleId);

                entity.Property(e => e.TitleDescription).HasMaxLength(50);
            });

            modelBuilder.Entity<ComicsofDay>(entity =>
            {
                entity.HasKey(e => e.PictureId);

                entity.ToTable("ComicsofDay");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Added")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PictureTitle)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Editor>(entity =>
            {
                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.ArticleName)
                    .HasMaxLength(100)
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Picture)
                    .HasMaxLength(500)
                    .HasColumnName("picture");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Displayorder).HasColumnName("displayorder");

                entity.Property(e => e.EmplyeeName).HasMaxLength(50);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.ToTable("__files");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("date")
                    .HasColumnName("dateFrom");

                entity.Property(e => e.DateTo)
                    .HasColumnType("date")
                    .HasColumnName("dateTo");

                entity.Property(e => e.PicName).HasMaxLength(150);

                entity.Property(e => e.Url).HasMaxLength(150);
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("Gallery");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.GalleryType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gdate)
                    .HasColumnType("datetime")
                    .HasColumnName("GDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsHome).HasDefaultValueSql("((0))");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MainPictureId).HasColumnName("MainPictureID");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GalleryPicture>(entity =>
            {
                entity.HasKey(e => new { e.GalleryId, e.PictureId });

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GalleryType>(entity =>
            {
                entity.HasKey(e => e.GalleryTypeName);

                entity.ToTable("GalleryType");

                entity.Property(e => e.GalleryTypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GalleryTypeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HomeMostCommented>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.ToTable("HomeMostCommented");

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.Comments).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssueStatus).HasComment("1=Current, 2= Archive, 3=hidden");

                entity.Property(e => e.IssueTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.JournalId).HasColumnName("JournalID");
            });

            modelBuilder.Entity<Issues2>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("issues2");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Addby)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("addby");

                entity.Property(e => e.Cover)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("cover");

                entity.Property(e => e.Cover2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("cover2");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssueTitle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Issuenumber).HasColumnName("issuenumber");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.Journalname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("journalname");

                entity.Property(e => e.Orderissu).HasColumnName("orderissu");

                entity.Property(e => e.Url)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("url");
            });

            modelBuilder.Entity<IssuesNews>(entity =>
            {
                entity.HasKey(e => new { e.IssueId, e.NewsId });

                entity.HasIndex(e => new { e.NewsId, e.IssueId }, "_dta_index_IssuesNews_15_1317579732__K2_K1")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");
            });

            modelBuilder.Entity<IssuesTopNews>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.IssueId, e.TopType })
                    .HasName("PK_IssuesTopStories");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.TopType).HasComment("1: homepage, 2: weekly, 3: sections");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.ToTable("Journal");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.ComicLargeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComicSmallSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cover)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cover");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditorLargeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EditorSmallSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fbtoken)
                    .HasMaxLength(250)
                    .HasColumnName("FBToken");

                entity.Property(e => e.ImageLargeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSliderSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageSmallSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PainterLargeSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PainterSmallSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeadsReg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LeadsReg");

                entity.Property(e => e.DateReg)
                    .HasColumnType("date")
                    .HasColumnName("dateReg");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Lead).HasColumnName("lead");

                entity.Property(e => e.Mail)
                    .HasMaxLength(150)
                    .HasColumnName("mail");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.Tel)
                    .HasMaxLength(150)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<LinkedNews>(entity =>
            {
                entity.HasKey(e => new { e.NewId, e.JournalId, e.SectionId });

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");
            });

        //    modelBuilder.Entity<MainSection>()
        //.HasOne(a => a.ParentSection).WithMany(b => b.SubSections)
        //.HasForeignKey<SubSection>(e => e.SectionId);
        //    modelBuilder.Entity<MainSection>().ToTable("MainSections");
        //    modelBuilder.Entity<SubSection>().ToTable("MainSections");

            modelBuilder.Entity<MainSection>(entity =>
            {

                //entity.HasMany<MainSection>(e => e.SubSections).WithOne(e => e.ParentSection).HasForeignKey(e => e.ParentSectionId).HasPrincipalKey(e => e.SectionId);
                
                entity.HasKey(e => e.SectionId)
                    .HasName("PK_Sports");

                entity.HasOne<MainSection>(e => e.ParentSection).WithMany(e => e.SubSections).HasForeignKey(entity => entity.ParentSectionId).HasPrincipalKey(e => e.SectionId);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hide).HasDefaultValueSql("((0))");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentSectionId)
                    .HasColumnName("ParentSectionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SecTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeeklySection).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NatigaPrep2019Swe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("natiga_prep2019_swes");

                entity.Property(e => e.GlosNo).HasColumnName("glos_no");

                entity.Property(e => e.MwadRosob)
                    .HasMaxLength(255)
                    .HasColumnName("mwad_rosob");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(255)
                    .HasColumnName("school_name");

                entity.Property(e => e.StatusResult)
                    .HasMaxLength(255)
                    .HasColumnName("status_result");

                entity.Property(e => e.الحروفرقم).HasColumnName("الحروف رقم");

                entity.Property(e => e.الديانة).HasMaxLength(255);

                entity.Property(e => e.حالةنجاحتاكيد)
                    .HasMaxLength(255)
                    .HasColumnName("حالة نجاح تاكيد");

                entity.Property(e => e.رقمالمدرسة).HasColumnName("رقم المدرسة");

                entity.Property(e => e.عددموادالدورالثاني).HasColumnName("عدد مواد الدور الثاني");

                entity.Property(e => e.عدمراتالغياب).HasColumnName("عد مرات الغياب");

                entity.Property(e => e.عربيمج).HasColumnName("عربي مج");

                entity.Property(e => e.غجبر1)
                    .HasMaxLength(255)
                    .HasColumnName("غ جبر1");

                entity.Property(e => e.غجبر2)
                    .HasMaxLength(255)
                    .HasColumnName("غ جبر2");

                entity.Property(e => e.غحاسب1)
                    .HasMaxLength(255)
                    .HasColumnName("غ حاسب1");

                entity.Property(e => e.غحاسب2)
                    .HasMaxLength(255)
                    .HasColumnName("غ حاسب2");

                entity.Property(e => e.غدراسات1)
                    .HasMaxLength(255)
                    .HasColumnName("غ دراسات 1");

                entity.Property(e => e.غدراسات2)
                    .HasMaxLength(255)
                    .HasColumnName("غ دراسات2");

                entity.Property(e => e.غدين1)
                    .HasMaxLength(255)
                    .HasColumnName("غ دين1");

                entity.Property(e => e.غدين2)
                    .HasMaxLength(255)
                    .HasColumnName("غ دين2");

                entity.Property(e => e.غعربي1)
                    .HasMaxLength(255)
                    .HasColumnName("غ عربي1");

                entity.Property(e => e.غعربي2)
                    .HasMaxLength(255)
                    .HasColumnName("غ عربي2");

                entity.Property(e => e.غعلوم1)
                    .HasMaxLength(255)
                    .HasColumnName("غ علوم1");

                entity.Property(e => e.غعلوم2)
                    .HasMaxLength(255)
                    .HasColumnName("غ علوم2");

                entity.Property(e => e.غفنية1)
                    .HasMaxLength(255)
                    .HasColumnName("غ فنية1");

                entity.Property(e => e.غفنية2)
                    .HasMaxLength(255)
                    .HasColumnName("غ فنية2");

                entity.Property(e => e.غلغة1)
                    .HasMaxLength(255)
                    .HasColumnName("غ لغة 1");

                entity.Property(e => e.غلغة2)
                    .HasMaxLength(255)
                    .HasColumnName("غ لغة2");

                entity.Property(e => e.غهندسة1)
                    .HasMaxLength(255)
                    .HasColumnName("غ هندسة1");

                entity.Property(e => e.غهندسة2)
                    .HasMaxLength(255)
                    .HasColumnName("غ هندسة 2");

                entity.Property(e => e.لغة1).HasColumnName("لغة 1");

                entity.Property(e => e.مجحاسب).HasColumnName("مج حاسب");

                entity.Property(e => e.مجدراسات).HasColumnName("مج دراسات");

                entity.Property(e => e.مجدين).HasColumnName("مج دين");

                entity.Property(e => e.مجرياضيات).HasColumnName("مج رياضيات");

                entity.Property(e => e.مجعلوم).HasColumnName("مج علوم");

                entity.Property(e => e.مجفنية).HasColumnName("مج فنية");

                entity.Property(e => e.مجلغة).HasColumnName("مج لغة");

                entity.Property(e => e.مجلغةاولى)
                    .HasMaxLength(255)
                    .HasColumnName("مج لغة اولى");

                entity.Property(e => e.مجلغةثانية)
                    .HasMaxLength(255)
                    .HasColumnName("مج لغة ثانية");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK_Country");

                entity.ToTable("Nationality");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasOne(e => e.Picture1).WithMany(e => e.Picture1News).HasForeignKey(PN => PN.PictureId1);
                entity.HasOne(e => e.Picture2).WithMany(e => e.Picture2News).HasForeignKey(PN => PN.PictureId2);
                entity.HasOne(e => e.Section).WithMany(e => e.News).HasForeignKey(NS => NS.SectionId);

                entity.HasKey(e => e.NewId)
                    .HasName("PK_News2");

                entity.HasIndex(e => e.SectionId1, "News_SectionID1");

                entity.HasIndex(e => e.SectionId2, "News_SectionID2");

                entity.HasIndex(e => e.SectionId3, "News_SectionID3");

                entity.HasIndex(e => e.SectionId4, "News_SectionID4");

                entity.HasIndex(e => e.SectionId5, "News_SectionID5");

                entity.HasIndex(e => e.SectionId6, "News_SectionID6");

                entity.HasIndex(e => e.SectionId7, "News_SectionID7");

                entity.HasIndex(e => e.SectionId8, "News_SectionID8");

                entity.HasIndex(e => e.SectionId9, "News_SectionID9");

                entity.HasIndex(e => new { e.NewId, e.SectionId }, "_dta_index_News_12_940230800__K1_K2_17")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Approved, e.NewStatus, e.NewId, e.PictureId1, e.SectionId, e.PublishDate }, "_dta_index_News_12_940230800__K20_K22_K1_K13_K2_K17_3_7_10_15_18")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Approved, e.NewStatus, e.SectionId, e.NewId, e.PictureId1, e.PublishDate }, "_dta_index_News_12_940230800__K20_K22_K2_K1_K13_K17_3_7_10_15_18")
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.PublishDate, e.JournalId }, "_dta_index_News_15_940230800__K17D_K34_1_2_7_18_22_23_27_28_29_30_31_32")
                    .HasFillFactor((byte)80);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssignedTo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Brief).HasMaxLength(3000);

                entity.Property(e => e.ByLine).HasMaxLength(150);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Creator).HasDefaultValueSql("((0))");

                entity.Property(e => e.EditorId)
                    .HasColumnName("EditorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keywords).HasMaxLength(200);

                entity.Property(e => e.NewStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewsId)
                    .HasColumnName("NewsID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsSource).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewsType).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PictureCaption1).HasMaxLength(1000);

                entity.Property(e => e.PictureCaption2).HasMaxLength(1000);

                entity.Property(e => e.PictureId1)
                    .HasColumnName("PictureID1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PictureId2)
                    .HasColumnName("PictureID2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Quote)
                    .HasMaxLength(1000)
                    .HasColumnName("quote");

                entity.Property(e => e.SDepartDirectorId)
                    .HasColumnName("sDepartDirectorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SDeskId)
                    .HasColumnName("sDeskID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SEditorId)
                    .HasColumnName("sEditorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SManagerEditorId)
                    .HasColumnName("sManagerEditorID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SReviewerId)
                    .HasColumnName("sReviewerID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SUploaderId)
                    .HasColumnName("sUploaderID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SdeskDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDeskDate");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionId1).HasColumnName("SectionID1");

                entity.Property(e => e.SectionId2).HasColumnName("SectionID2");

                entity.Property(e => e.SectionId3).HasColumnName("SectionID3");

                entity.Property(e => e.SectionId4).HasColumnName("SectionID4");

                entity.Property(e => e.SectionId5).HasColumnName("SectionID5");

                entity.Property(e => e.SectionId6).HasColumnName("SectionID6");

                entity.Property(e => e.SectionId7).HasColumnName("SectionID7");

                entity.Property(e => e.SectionId8).HasColumnName("SectionID8");

                entity.Property(e => e.SectionId9).HasColumnName("SectionID9");

                entity.Property(e => e.Seotitle)
                    .HasMaxLength(50)
                    .HasColumnName("SEOTitle");

                entity.Property(e => e.SocialEditorId).HasColumnName("SocialEditorID");

                entity.Property(e => e.SocialPictureCaption).HasMaxLength(200);

                entity.Property(e => e.SocialTitle).HasMaxLength(200);

                entity.Property(e => e.Story).HasColumnType("ntext");

                entity.Property(e => e.SubTitle).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Views).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsBlock>(entity =>
            {
                entity.HasKey(e => e.BlockId);

                entity.Property(e => e.BlockId).HasColumnName("BlockID");

                entity.Property(e => e.BlockName).HasMaxLength(100);

                entity.Property(e => e.BlockText).HasColumnType("text");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<NewsByline>(entity =>
            {
                entity.HasKey(e => new { e.ByLineId, e.NewId, e.Flag })
                    .HasName("PK_News_Byline_1");

                entity.ToTable("News_Byline");

                entity.HasIndex(e => e.ByLineId, "NonClusteredIndex-20181103-184224");

                entity.HasIndex(e => e.NewId, "NonClusteredIndex-20181103-184248");
            });

            modelBuilder.Entity<NewsCategory>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.Property(e => e.CatId)
                    .ValueGeneratedNever()
                    .HasColumnName("CatID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsGallery>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.GalleryId });

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");
            });

            modelBuilder.Entity<NewsGallery1>(entity =>
            {
                entity.HasKey(e => new { e.NewId, e.GalleryId })
                    .HasName("PK_dbo.NewsGalleries");

                entity.ToTable("NewsGallery");

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");
            });

            modelBuilder.Entity<NewsPicture>(entity =>
            {
                entity.HasKey(e => e.PictureId)
                    .HasName("PK_News_Pictures_1");

                entity.HasIndex(e => e.PictureId, "_dta_index_NewsPictures_12_1381579960__K1_2")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.PictureId).HasColumnName("PictureID");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("added_date");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyWords)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PicCaption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Source).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsPicturesCat>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK_News_Pic_Categories");

                entity.Property(e => e.CatId)
                    .ValueGeneratedNever()
                    .HasColumnName("CatID");

                entity.Property(e => e.CatName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsPoll>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.PollId });

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.NewsPolls)
                    .HasForeignKey(d => d.PollId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsPolls_Polls");
            });

            modelBuilder.Entity<NewsSearch>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.ToTable("NewsSearch");

                entity.Property(e => e.NewId)
                    .ValueGeneratedNever()
                    .HasColumnName("NewID");

                entity.Property(e => e.Brief)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("brief");

                entity.Property(e => e.Brief2)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("brief2");

                entity.Property(e => e.Byline)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("byline");

                entity.Property(e => e.Byline2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("byline2");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Title2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("title2");
            });

            modelBuilder.Entity<NewsSection>(entity =>
            {
                entity.HasKey(e => new { e.NewsId, e.SectionId });

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.HasOne(d => d.Section)
                    .WithMany(p => p.NewsSections)
                    .HasForeignKey(d => d.SectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewsSections_MainSections");
            });

            modelBuilder.Entity<NewsStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("NewsStatus");

                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusDescriptions)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsTag>(entity =>
            {
                entity.HasKey(e => new { e.NewId, e.TagId });

                entity.HasIndex(e => e.TagId, "_dta_index_NewsTags_15_741577680__K2")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.TagId).HasColumnName("TagID");
            });

            modelBuilder.Entity<NewsTicker>(entity =>
            {
                entity.HasOne(e => e.Section).WithMany(N => N.NewsTickers).HasForeignKey(e => e.SectionId); //.HasPrincipalKey<News>(N => N.NewId);
                entity.HasKey(e => e.NewId);

                entity.ToTable("NewsTicker");

                entity.HasIndex(e => e.AddedDate, "NonClusteredIndex-20180215-174146")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsVersion>(entity =>
            {
                entity.HasKey(e => e.VersionId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.NewId, e.VersionId }, "_dta_index_NewsVersions_15_693577509__K2_K1_3_4_5_6_7_8_9_11_12_13_14_15_16_17_18_19_20_21_22_23_24")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => e.VersionId, "_dta_index_NewsVersions_c_15_693577509__K1D")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Brief)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ByLine)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.EditorId).HasColumnName("EditorID");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Keywords)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PictureCaption1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PictureCaption2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PictureId1).HasColumnName("PictureID1");

                entity.Property(e => e.PictureId2).HasColumnName("PictureID2");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Quote)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("quote");

                entity.Property(e => e.SdeskDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SDeskDate");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionId1).HasColumnName("SectionID1");

                entity.Property(e => e.SectionId2).HasColumnName("SectionID2");

                entity.Property(e => e.SectionId3).HasColumnName("SectionID3");

                entity.Property(e => e.SectionId4).HasColumnName("SectionID4");

                entity.Property(e => e.SectionId5).HasColumnName("SectionID5");

                entity.Property(e => e.SectionId6).HasColumnName("SectionID6");

                entity.Property(e => e.SectionId7).HasColumnName("SectionID7");

                entity.Property(e => e.SectionId8).HasColumnName("SectionID8");

                entity.Property(e => e.SectionId9).HasColumnName("SectionID9");

                entity.Property(e => e.SocialEditorId).HasColumnName("SocialEditorID");

                entity.Property(e => e.SocialPictureCaption).HasMaxLength(200);

                entity.Property(e => e.SocialTitle).HasMaxLength(200);

                entity.Property(e => e.Story)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SubTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewsVideo>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.ToTable("News_Videos");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.NewsId)
                    .HasColumnName("NewsID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VideoId)
                    .HasColumnName("VideoID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsView>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.Property(e => e.NewId)
                    .ValueGeneratedNever()
                    .HasColumnName("NewID");

                entity.Property(e => e.Views).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsViewsLog>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("NewsViewsLog");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");
            });

            modelBuilder.Entity<PictureofDay>(entity =>
            {
                entity.HasKey(e => e.PictureId);

                entity.ToTable("PictureofDay");

                entity.Property(e => e.PictureId)
                    .ValueGeneratedNever()
                    .HasColumnName("PictureID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Added")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.PictureTitle)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.Activated).HasDefaultValueSql("((0))");

                entity.Property(e => e.AddedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Added_Date");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateActivated).HasColumnType("datetime");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PollBody)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.TotalVotes).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PollsOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK_VotesOptions");

                entity.Property(e => e.OptionId).HasColumnName("OptionID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OptionBody)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.Votes).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollsOptions)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_PollsOptions_Polls");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.ToTable("Profile");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOrder).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hide).HasDefaultValueSql("((0))");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MainPictureName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<QuestionSelect>(entity =>
            {
                entity.ToTable("Question_Selects");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdQuetion).HasColumnName("id_quetion");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Result1).HasMaxLength(100);

                entity.Property(e => e.Result10).HasMaxLength(100);

                entity.Property(e => e.Result2).HasMaxLength(100);

                entity.Property(e => e.Result3).HasMaxLength(100);

                entity.Property(e => e.Result4).HasMaxLength(100);

                entity.Property(e => e.Result5).HasMaxLength(100);

                entity.Property(e => e.Result6).HasMaxLength(100);

                entity.Property(e => e.Result7).HasMaxLength(100);

                entity.Property(e => e.Result8).HasMaxLength(100);

                entity.Property(e => e.Result9).HasMaxLength(100);

                entity.Property(e => e.Tel)
                    .HasMaxLength(100)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Quetion>(entity =>
            {
                entity.ToTable("quetions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Quetion1)
                    .HasMaxLength(250)
                    .HasColumnName("quetion");

                entity.Property(e => e.Result1)
                    .HasMaxLength(250)
                    .HasColumnName("result1");

                entity.Property(e => e.Result2)
                    .HasMaxLength(250)
                    .HasColumnName("result2");

                entity.Property(e => e.Result3)
                    .HasMaxLength(250)
                    .HasColumnName("result3");

                entity.Property(e => e.Result4)
                    .HasMaxLength(250)
                    .HasColumnName("result4");

                entity.Property(e => e.Result5)
                    .HasMaxLength(250)
                    .HasColumnName("result5");

                entity.Property(e => e.ResultSuccess)
                    .HasMaxLength(250)
                    .HasColumnName("result_success");
            });

            modelBuilder.Entity<QuetionResult>(entity =>
            {
                entity.ToTable("quetion_result");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdQuetion).HasColumnName("id_quetion");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasColumnName("name");

                entity.Property(e => e.ResultEgypt).HasColumnName("Result_Egypt");

                entity.Property(e => e.ResultOther).HasColumnName("Result_Other");

                entity.Property(e => e.Success).HasMaxLength(10);

                entity.Property(e => e.Tel)
                    .HasMaxLength(50)
                    .HasColumnName("tel");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ratings");

                entity.Property(e => e.BookId).HasColumnName("book_id");

                entity.Property(e => e.Rating1).HasColumnName("rating");

                entity.Property(e => e.RatingDate)
                    .HasColumnType("date")
                    .HasColumnName("rating_date");

                entity.Property(e => e.ReviewerId).HasColumnName("reviewer_id");
            });

            modelBuilder.Entity<RelatedNews>(entity =>
            {
                entity.HasKey(e => new { e.NewId, e.RelatedId });

                entity.Property(e => e.NewId).HasColumnName("NewID");
            });

            modelBuilder.Entity<Reviewer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reviewers");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ReviewerNews>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Done).HasDefaultValueSql("((0))");

                entity.Property(e => e.GetNewDate)
                    .HasColumnType("datetime")
                    .HasColumnName("getNewDate");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<RoleService>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.ServiceId });
            });

            modelBuilder.Entity<SectionLatestNews>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.Brief)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PictureCaption1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.SecTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WeeklySection).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SesstionText>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.SesstionDate).HasColumnType("datetime");

                entity.Property(e => e.Story)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<SportMal3b>(entity =>
            {
                entity.ToTable("sport_mal3b");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mal3b)
                    .HasMaxLength(150)
                    .HasColumnName("mal3b");
            });

            modelBuilder.Entity<SportMatch>(entity =>
            {
                entity.ToTable("sport_matches");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dat)
                    .HasColumnType("datetime")
                    .HasColumnName("dat");

                entity.Property(e => e.Flag1).HasColumnName("flag1");

                entity.Property(e => e.Flag2).HasColumnName("flag2");

                entity.Property(e => e.Groups)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("groups");

                entity.Property(e => e.LinkNews)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("link_news");

                entity.Property(e => e.LiveEnd)
                    .HasMaxLength(50)
                    .HasColumnName("live_end");

                entity.Property(e => e.Mal3bId).HasColumnName("mal3b_id");

                entity.Property(e => e.ResultTeam1).HasColumnName("result_team1");

                entity.Property(e => e.ResultTeam2).HasColumnName("result_team2");

                entity.Property(e => e.StadName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("stad_name");

                entity.Property(e => e.Team1).HasColumnName("team1");

                entity.Property(e => e.Team2).HasColumnName("team2");
            });

            modelBuilder.Entity<SportTeam>(entity =>
            {
                entity.ToTable("sport_teams");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Flag)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("flag");

                entity.Property(e => e.Team)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("team");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.HasIndex(e => e.Name, "_dta_index_Tags_15_2105058535__K2")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatioDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TempDeskShift>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("TempDeskShift");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.AssignFlag).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("OrderID");

                entity.Property(e => e.WaitingFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TempDifferntBylineShape>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Ff1)
                    .HasMaxLength(100)
                    .HasColumnName("ff1");

                entity.Property(e => e.Ff11).HasColumnName("ff11");

                entity.Property(e => e.Ff12)
                    .HasMaxLength(100)
                    .HasColumnName("ff12");

                entity.Property(e => e.Ff13).HasColumnName("ff13");

                entity.Property(e => e.Ff2).HasColumnName("ff2");

                entity.Property(e => e.Ff3)
                    .HasMaxLength(100)
                    .HasColumnName("ff3");

                entity.Property(e => e.Ff4).HasColumnName("ff4");

                entity.Property(e => e.Ff5)
                    .HasMaxLength(100)
                    .HasColumnName("ff5");

                entity.Property(e => e.Ff6).HasColumnName("ff6");

                entity.Property(e => e.Ff7)
                    .HasMaxLength(100)
                    .HasColumnName("ff7");

                entity.Property(e => e.Ff8).HasColumnName("ff8");

                entity.Property(e => e.Ff9)
                    .HasMaxLength(100)
                    .HasColumnName("ff9");

                entity.Property(e => e.Field1).HasMaxLength(255);

                entity.Property(e => e.Field2).HasMaxLength(100);

                entity.Property(e => e.Field4).HasMaxLength(100);

                entity.Property(e => e.Field6).HasMaxLength(100);

                entity.Property(e => e.Field8).HasMaxLength(100);
            });

            modelBuilder.Entity<TopNews>(entity =>
            {
                entity.HasOne(e => e.News).WithOne(N => N.TopNews).HasForeignKey<TopNews>(TN => TN.NewsId); //.HasPrincipalKey<News>(N => N.NewId);
                entity.HasOne(e => e.Section).WithMany(NS => NS.TopNews).HasForeignKey(e => e.SecId);
                entity.HasOne(e => e.NewsCategory).WithMany(NC => NC.TopNews).HasForeignKey(e => e.CatId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.JournalId).HasColumnName("JournalID");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.SecId).HasColumnName("SecID");
            });

            modelBuilder.Entity<TraceTable>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__TraceTab__AAAC09D82E574458");

                entity.ToTable("TraceTable");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Trend>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Ummodule>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_Functions");

                entity.ToTable("UMModules");

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IconName).HasMaxLength(20);

                entity.Property(e => e.ModuleHide).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModuleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Umservice>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_Permissions");

                entity.ToTable("UMServices");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'Index')");

                entity.Property(e => e.ControllerName).HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IconName).HasMaxLength(20);

                entity.Property(e => e.RelatedService).HasMaxLength(50);

                entity.Property(e => e.ServiceHide).HasDefaultValueSql("((1))");

                entity.Property(e => e.ServiceName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminUserId).HasColumnName("AdminUserID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.JournalId)
                    .HasColumnName("JournalID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SectionId)
                    .HasColumnName("SectionID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<UsersOpinion>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .IsClustered(false);

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CloudIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CloudIP");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Messagebody)
                    .HasMaxLength(8000)
                    .IsUnicode(false)
                    .HasColumnName("messagebody");

                entity.Property(e => e.Messagedate)
                    .HasColumnType("datetime")
                    .HasColumnName("messagedate");

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.OperationalUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VTopNewsToday>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTopNewsToday");

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.PictureName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PublishDate)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<VersionTag>(entity =>
            {
                entity.HasKey(e => new { e.VersionId, e.TagId });

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.TagId).HasColumnName("TagID");
            });

            modelBuilder.Entity<VideoFeed>(entity =>
            {
                entity.HasKey(e => e.EntryId)
                    .IsClustered(false);

                entity.HasIndex(e => e.Date, "ClusteredIndex-20140319-152024")
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Brief).HasMaxLength(1000);

                entity.Property(e => e.BriefAr)
                    .HasMaxLength(1000)
                    .HasColumnName("BriefAR");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Link)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Thumb)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(150);

                entity.Property(e => e.TitleAr)
                    .HasMaxLength(150)
                    .HasColumnName("TitleAR");

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TypeAr)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TypeAR");
            });

            modelBuilder.Entity<VuserPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VUserPermissions");

                entity.Property(e => e.ActionName).HasMaxLength(50);

                entity.Property(e => e.AreaName).HasMaxLength(50);

                entity.Property(e => e.ControllerName).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleIcon).HasMaxLength(20);

                entity.Property(e => e.ModuleName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.ServiceIcon).HasMaxLength(20);

                entity.Property(e => e.ServiceName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wdgt>(entity =>
            {
                entity.ToTable("Wdgt");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.OrderView).HasColumnName("order_view");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasColumnName("title");

                entity.Property(e => e.ViewNews).HasColumnName("View_news");

                entity.Property(e => e.WdgetId).HasColumnName("Wdget_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
