using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace nxLINEadminAPI.Models;

public partial class NxLineContext : DbContext
{
    public NxLineContext()
    {
    }

    public NxLineContext(DbContextOptions<NxLineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Analytic> Analytics { get; set; }

    public virtual DbSet<Checkin> Checkins { get; set; }

    public virtual DbSet<Checkpoint> Checkpoints { get; set; }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<CouponHistory> CouponHistories { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Lineaccount> Lineaccounts { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Qrcode> Qrcodes { get; set; }

    public virtual DbSet<QrcodeLog> QrcodeLogs { get; set; }

    public virtual DbSet<Survey> Surveys { get; set; }

    public virtual DbSet<SurveyHistory> SurveyHistories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=devsv1.japaneast.cloudapp.azure.com;database=nxLINE;user=couponuser;password=M0dnwDnW;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Japanese_CI_AS");

        modelBuilder.Entity<Analytic>(entity =>
        {
            entity.HasKey(e => e.AnalyticsId);

            entity.ToTable("analytics");

            entity.Property(e => e.AnalyticsId)
                .ValueGeneratedNever()
                .HasColumnName("analytics_id");
            entity.Property(e => e.AnalyticsCreated).HasColumnName("analytics_created");
            entity.Property(e => e.AnalyticsMemberId).HasColumnName("analytics_memberId");
            entity.Property(e => e.AnalyticsMessage).HasColumnName("analytics_message");
            entity.Property(e => e.AnalyticsType)
                .HasMaxLength(100)
                .HasColumnName("analytics_type");
        });

        modelBuilder.Entity<Checkin>(entity =>
        {
            entity.ToTable("checkin");

            entity.Property(e => e.CheckinId).HasColumnName("checkin_id");
            entity.Property(e => e.CheckinCheckpointId).HasColumnName("checkin_checkpoint_id");
            entity.Property(e => e.CheckinCreated).HasColumnName("checkin_created");
            entity.Property(e => e.CheckinLineid)
                .HasMaxLength(100)
                .HasColumnName("checkin_lineid");
            entity.Property(e => e.CheckinUserid)
                .HasMaxLength(100)
                .HasColumnName("checkin_userid");

            entity.HasOne(d => d.CheckinCheckpoint).WithMany(p => p.Checkins)
                .HasForeignKey(d => d.CheckinCheckpointId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_checkin_checkpoint");
        });

        modelBuilder.Entity<Checkpoint>(entity =>
        {
            entity.ToTable("checkpoint");

            entity.Property(e => e.CheckpointId).HasColumnName("checkpoint_id");
            entity.Property(e => e.CheckpointCreated).HasColumnName("checkpoint_created");
            entity.Property(e => e.CheckpointDeleted).HasColumnName("checkpoint_deleted");
            entity.Property(e => e.CheckpointDescription).HasColumnName("checkpoint_description");
            entity.Property(e => e.CheckpointEventId).HasColumnName("checkpoint_event_id");
            entity.Property(e => e.CheckpointImageurl)
                .HasMaxLength(1000)
                .HasColumnName("checkpoint_imageurl");
            entity.Property(e => e.CheckpointName)
                .HasMaxLength(100)
                .HasColumnName("checkpoint_name");
            entity.Property(e => e.CheckpointUpdated).HasColumnName("checkpoint_updated");
            entity.Property(e => e.CheckpointUrl)
                .HasMaxLength(100)
                .HasColumnName("checkpoint_url");

            entity.HasOne(d => d.CheckpointEvent).WithMany(p => p.Checkpoints)
                .HasForeignKey(d => d.CheckpointEventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_checkpoint_event");
        });

        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.ToTable("coupon");

            entity.Property(e => e.CouponId).HasColumnName("coupon_id");
            entity.Property(e => e.CouponCode)
                .HasMaxLength(50)
                .HasColumnName("coupon_code");
            entity.Property(e => e.CouponGroup)
                .HasMaxLength(100)
                .HasColumnName("coupon_group");
            entity.Property(e => e.CouponImageurl)
                .HasMaxLength(200)
                .HasColumnName("coupon_imageurl");
            entity.Property(e => e.CouponLinktext)
                .HasMaxLength(100)
                .HasColumnName("coupon_linktext");
            entity.Property(e => e.CouponName)
                .HasMaxLength(50)
                .HasColumnName("coupon_name");
            entity.Property(e => e.CouponText).HasColumnName("coupon_text");
            entity.Property(e => e.CouponTitle)
                .HasMaxLength(50)
                .HasColumnName("coupon_title");
            entity.Property(e => e.CouponType)
                .HasMaxLength(50)
                .HasColumnName("coupon_type");
            entity.Property(e => e.Createdat).HasColumnName("createdat");
            entity.Property(e => e.Deletedat).HasColumnName("deletedat");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.LimitCount).HasColumnName("limit_count");
            entity.Property(e => e.LimitDays).HasColumnName("limit_days");
            entity.Property(e => e.Probability)
                .HasMaxLength(200)
                .HasColumnName("probability");
            entity.Property(e => e.Ranks)
                .HasMaxLength(50)
                .HasColumnName("ranks");
            entity.Property(e => e.Resultimageurl).HasColumnName("resultimageurl");
            entity.Property(e => e.Resultmusicurl).HasColumnName("resultmusicurl");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");
            entity.Property(e => e.Updatedat).HasColumnName("updatedat");
            entity.Property(e => e.Upperlimit)
                .HasMaxLength(200)
                .HasColumnName("upperlimit");
        });

        modelBuilder.Entity<CouponHistory>(entity =>
        {
            entity.HasKey(e => e.CouponHistoryId).HasName("PK_history_coupon");

            entity.ToTable("coupon_history");

            entity.Property(e => e.CouponHistoryId)
                .HasMaxLength(50)
                .HasColumnName("coupon_history_id");
            entity.Property(e => e.CouponGroup)
                .HasMaxLength(100)
                .HasColumnName("coupon_group");
            entity.Property(e => e.CouponId).HasColumnName("coupon_id");
            entity.Property(e => e.Createdat).HasColumnName("createdat");
            entity.Property(e => e.DeliveryDatetime)
                .HasColumnType("datetime")
                .HasColumnName("delivery_datetime");
            entity.Property(e => e.LastUseDatetime).HasColumnName("last_use_datetime");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberLineid)
                .HasMaxLength(100)
                .HasColumnName("member_lineid");
            entity.Property(e => e.Result)
                .HasMaxLength(100)
                .HasColumnName("result");
            entity.Property(e => e.Sendedat).HasColumnName("sendedat");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");
            entity.Property(e => e.TransactionHeadId)
                .HasMaxLength(100)
                .HasColumnName("transactionHeadId");
            entity.Property(e => e.UseCount).HasColumnName("use_count");
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.DivisionId).HasName("PK_divison");

            entity.ToTable("division");

            entity.Property(e => e.DivisionId).HasColumnName("division_id");
            entity.Property(e => e.DivisionBumonKind)
                .HasMaxLength(500)
                .HasColumnName("division_bumon_kind");
            entity.Property(e => e.DivisionCreatedat).HasColumnName("division_createdat");
            entity.Property(e => e.DivisionDeletedat).HasColumnName("division_deletedat");
            entity.Property(e => e.DivisionFbAccountkana)
                .HasMaxLength(30)
                .HasColumnName("division_fb_accountkana");
            entity.Property(e => e.DivisionFbAccountnum)
                .HasMaxLength(7)
                .HasColumnName("division_fb_accountnum");
            entity.Property(e => e.DivisionFbAccounttype)
                .HasMaxLength(1)
                .HasColumnName("division_fb_accounttype");
            entity.Property(e => e.DivisionFbBankcode)
                .HasMaxLength(4)
                .HasColumnName("division_fb_bankcode");
            entity.Property(e => e.DivisionFbBankkana)
                .HasMaxLength(15)
                .HasColumnName("division_fb_bankkana");
            entity.Property(e => e.DivisionFbBranchcode)
                .HasMaxLength(3)
                .HasColumnName("division_fb_branchcode");
            entity.Property(e => e.DivisionFbBranchkana)
                .HasMaxLength(15)
                .HasColumnName("division_fb_branchkana");
            entity.Property(e => e.DivisionFbCompanycode)
                .HasMaxLength(10)
                .HasColumnName("division_fb_companycode");
            entity.Property(e => e.DivisionName)
                .HasMaxLength(50)
                .HasColumnName("division_name");
            entity.Property(e => e.DivisionOrdinal).HasColumnName("division_ordinal");
            entity.Property(e => e.DivisionUpdatedat).HasColumnName("division_updatedat");
            entity.Property(e => e.DivisionVisibility).HasColumnName("division_visibility");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("event");

            entity.Property(e => e.EventId)
                .ValueGeneratedNever()
                .HasColumnName("event_id");
            entity.Property(e => e.EventCreated).HasColumnName("event_created");
            entity.Property(e => e.EventDeleted).HasColumnName("event_deleted");
            entity.Property(e => e.EventDescription).HasColumnName("event_description");
            entity.Property(e => e.EventEnddate)
                .HasColumnType("date")
                .HasColumnName("event_enddate");
            entity.Property(e => e.EventImageurl)
                .HasMaxLength(1000)
                .HasColumnName("event_imageurl");
            entity.Property(e => e.EventLiffid)
                .HasMaxLength(100)
                .HasColumnName("event_liffid");
            entity.Property(e => e.EventName)
                .HasMaxLength(100)
                .HasColumnName("event_name");
            entity.Property(e => e.EventStampurl)
                .HasMaxLength(1000)
                .HasColumnName("event_stampurl");
            entity.Property(e => e.EventStartdate)
                .HasColumnType("date")
                .HasColumnName("event_startdate");
            entity.Property(e => e.EventStatus).HasColumnName("event_status");
            entity.Property(e => e.EventUpdated).HasColumnName("event_updated");
            entity.Property(e => e.EventUrl)
                .HasMaxLength(1000)
                .HasColumnName("event_url");
        });

        modelBuilder.Entity<Lineaccount>(entity =>
        {
            entity.HasKey(e => e.LineaccountId).HasName("PK_lineconfig");

            entity.ToTable("lineaccount");

            entity.Property(e => e.LineaccountId).HasColumnName("lineaccount_id");
            entity.Property(e => e.Entrypoint).HasColumnName("entrypoint");
            entity.Property(e => e.Isprofile).HasColumnName("isprofile");
            entity.Property(e => e.Issmaregi).HasColumnName("issmaregi");
            entity.Property(e => e.Istalk).HasColumnName("istalk");
            entity.Property(e => e.LineChannelaccesstoken)
                .HasMaxLength(200)
                .HasColumnName("line_channelaccesstoken");
            entity.Property(e => e.LineChannelid)
                .HasMaxLength(10)
                .HasColumnName("line_channelid");
            entity.Property(e => e.LineChannelsecret)
                .HasMaxLength(50)
                .HasColumnName("line_channelsecret");
            entity.Property(e => e.LineaccountCode)
                .HasMaxLength(100)
                .HasColumnName("lineaccount_code");
            entity.Property(e => e.LineaccountCreated).HasColumnName("lineaccount_created");
            entity.Property(e => e.LineaccountDeleted).HasColumnName("lineaccount_deleted");
            entity.Property(e => e.LineaccountEmail)
                .HasMaxLength(200)
                .HasColumnName("lineaccount_email");
            entity.Property(e => e.LineaccountLogourl)
                .HasMaxLength(1000)
                .HasColumnName("lineaccount_logourl");
            entity.Property(e => e.LineaccountName)
                .HasMaxLength(50)
                .HasColumnName("lineaccount_name");
            entity.Property(e => e.LineaccountShortcode)
                .HasMaxLength(5)
                .HasColumnName("lineaccount_shortcode");
            entity.Property(e => e.LineaccountUpdated).HasColumnName("lineaccount_updated");
            entity.Property(e => e.MemberscardColor)
                .HasMaxLength(10)
                .HasColumnName("memberscard_color");
            entity.Property(e => e.MemberscardDesignurl)
                .HasMaxLength(1000)
                .HasColumnName("memberscard_designurl");
            entity.Property(e => e.MemberscardIsusecamera).HasColumnName("memberscard_isusecamera");
            entity.Property(e => e.MemberscardLiffid)
                .HasMaxLength(20)
                .HasColumnName("memberscard_liffid");
            entity.Property(e => e.Pointexpire).HasColumnName("pointexpire");
            entity.Property(e => e.ProfileSetting).HasColumnName("profile_setting");
            entity.Property(e => e.SmaregiContractid)
                .HasMaxLength(20)
                .HasColumnName("smaregi_contractid");
            entity.Property(e => e.Startrank).HasColumnName("startrank");
            entity.Property(e => e.Talkmessage).HasColumnName("talkmessage");
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.ToTable("member");

            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberAddress)
                .HasMaxLength(1000)
                .HasColumnName("member_address");
            entity.Property(e => e.MemberAllowEmail).HasColumnName("member_allow_email");
            entity.Property(e => e.MemberBirthday)
                .HasColumnType("date")
                .HasColumnName("member_birthday");
            entity.Property(e => e.MemberCity)
                .HasMaxLength(100)
                .HasColumnName("member_city");
            entity.Property(e => e.MemberCode)
                .HasMaxLength(100)
                .HasColumnName("member_code");
            entity.Property(e => e.MemberCreateat).HasColumnName("member_createat");
            entity.Property(e => e.MemberDeleteat).HasColumnName("member_deleteat");
            entity.Property(e => e.MemberDropDate)
                .HasColumnType("date")
                .HasColumnName("member_drop_date");
            entity.Property(e => e.MemberEmail)
                .HasMaxLength(50)
                .HasColumnName("member_email");
            entity.Property(e => e.MemberEmailVerifyExpiredAt).HasColumnName("member_email_verify_expired_at");
            entity.Property(e => e.MemberEmailVerifyToken).HasColumnName("member_email_verify_token");
            entity.Property(e => e.MemberFamily1Birthday)
                .HasColumnType("date")
                .HasColumnName("member_family1_birthday");
            entity.Property(e => e.MemberFamily1Gender).HasColumnName("member_family1_gender");
            entity.Property(e => e.MemberFamily1Name)
                .HasMaxLength(50)
                .HasColumnName("member_family1_name");
            entity.Property(e => e.MemberFamily1Relative)
                .HasMaxLength(5)
                .HasColumnName("member_family1_relative");
            entity.Property(e => e.MemberFamily2Birthday)
                .HasColumnType("date")
                .HasColumnName("member_family2_birthday");
            entity.Property(e => e.MemberFamily2Gender).HasColumnName("member_family2_gender");
            entity.Property(e => e.MemberFamily2Name)
                .HasMaxLength(50)
                .HasColumnName("member_family2_name");
            entity.Property(e => e.MemberFamily2Relative)
                .HasMaxLength(5)
                .HasColumnName("member_family2_relative");
            entity.Property(e => e.MemberFamily3Birthday)
                .HasColumnType("date")
                .HasColumnName("member_family3_birthday");
            entity.Property(e => e.MemberFamily3Gender).HasColumnName("member_family3_gender");
            entity.Property(e => e.MemberFamily3Name)
                .HasMaxLength(50)
                .HasColumnName("member_family3_name");
            entity.Property(e => e.MemberFamily3Relative)
                .HasMaxLength(5)
                .HasColumnName("member_family3_relative");
            entity.Property(e => e.MemberFax)
                .HasMaxLength(20)
                .HasColumnName("member_fax");
            entity.Property(e => e.MemberFirstname)
                .HasMaxLength(50)
                .HasColumnName("member_firstname");
            entity.Property(e => e.MemberFirstnameKana)
                .HasMaxLength(50)
                .HasColumnName("member_firstname_kana");
            entity.Property(e => e.MemberGender).HasColumnName("member_gender");
            entity.Property(e => e.MemberHoldPoint).HasColumnName("member_hold_point");
            entity.Property(e => e.MemberIsPasswordResetVerified).HasColumnName("member_is_password_reset_verified");
            entity.Property(e => e.MemberIsSignupVerified).HasColumnName("member_is_signup_verified");
            entity.Property(e => e.MemberJoinDate)
                .HasColumnType("date")
                .HasColumnName("member_join_date");
            entity.Property(e => e.MemberLastPointgetDate)
                .HasColumnType("date")
                .HasColumnName("member_last_pointget_date");
            entity.Property(e => e.MemberLastPointgetPoint).HasColumnName("member_last_pointget_point");
            entity.Property(e => e.MemberLastVisitDate)
                .HasColumnType("date")
                .HasColumnName("member_last_visit_date");
            entity.Property(e => e.MemberLastname)
                .HasMaxLength(50)
                .HasColumnName("member_lastname");
            entity.Property(e => e.MemberLastnameKana)
                .HasMaxLength(50)
                .HasColumnName("member_lastname_kana");
            entity.Property(e => e.MemberLineid)
                .HasMaxLength(100)
                .HasColumnName("member_lineid");
            entity.Property(e => e.MemberMobile)
                .HasMaxLength(20)
                .HasColumnName("member_mobile");
            entity.Property(e => e.MemberNonce)
                .HasMaxLength(1000)
                .HasColumnName("member_nonce");
            entity.Property(e => e.MemberNote).HasColumnName("member_note");
            entity.Property(e => e.MemberOrdinal).HasColumnName("member_ordinal");
            entity.Property(e => e.MemberPasswordHash).HasColumnName("member_password_hash");
            entity.Property(e => e.MemberPasswordResetToken).HasColumnName("member_password_reset_token");
            entity.Property(e => e.MemberPasswordResetVerifyExpiredAt).HasColumnName("member_password_reset_verify_expired_at");
            entity.Property(e => e.MemberPasswordSalt).HasColumnName("member_password_salt");
            entity.Property(e => e.MemberPendingEmail)
                .HasMaxLength(50)
                .HasColumnName("member_pending_email");
            entity.Property(e => e.MemberPendingEmailVerifyToken)
                .HasMaxLength(50)
                .HasColumnName("member_pending_email_verify_token");
            entity.Property(e => e.MemberPointLimitDate)
                .HasColumnType("date")
                .HasColumnName("member_point_limit_date");
            entity.Property(e => e.MemberPosId).HasColumnName("member_pos_id");
            entity.Property(e => e.MemberPref)
                .HasMaxLength(10)
                .HasColumnName("member_pref");
            entity.Property(e => e.MemberProfileicon)
                .HasMaxLength(1000)
                .HasColumnName("member_profileicon");
            entity.Property(e => e.MemberRank)
                .HasMaxLength(50)
                .HasColumnName("member_rank");
            entity.Property(e => e.MemberSearchtext).HasColumnName("member_searchtext");
            entity.Property(e => e.MemberShopId).HasColumnName("member_shop_id");
            entity.Property(e => e.MemberSignupVerifyToken).HasColumnName("member_signup_verify_token");
            entity.Property(e => e.MemberStatus).HasColumnName("member_status");
            entity.Property(e => e.MemberStripeId)
                .HasMaxLength(200)
                .HasColumnName("member_stripeId");
            entity.Property(e => e.MemberTag)
                .HasMaxLength(50)
                .HasColumnName("member_tag");
            entity.Property(e => e.MemberTel)
                .HasMaxLength(20)
                .HasColumnName("member_tel");
            entity.Property(e => e.MemberUpdateat).HasColumnName("member_updateat");
            entity.Property(e => e.MemberVisibility).HasColumnName("member_visibility");
            entity.Property(e => e.MemberZipcode)
                .HasMaxLength(10)
                .HasColumnName("member_zipcode");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("message");

            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.MessageCreated).HasColumnName("message_created");
            entity.Property(e => e.MessageDeleted).HasColumnName("message_deleted");
            entity.Property(e => e.MessageIspushnow).HasColumnName("message_ispushnow");
            entity.Property(e => e.MessageJson).HasColumnName("message_json");
            entity.Property(e => e.MessageLineid)
                .HasMaxLength(100)
                .HasColumnName("message_lineid");
            entity.Property(e => e.MessageMemberid).HasColumnName("message_memberid");
            entity.Property(e => e.MessagePushdatetime).HasColumnName("message_pushdatetime");
            entity.Property(e => e.MessageSendtype)
                .HasMaxLength(10)
                .HasColumnName("message_sendtype");
            entity.Property(e => e.MessageUpdated).HasColumnName("message_updated");
        });

        modelBuilder.Entity<Qrcode>(entity =>
        {
            entity.ToTable("qrcode");

            entity.Property(e => e.QrcodeId).HasColumnName("qrcode_id");
            entity.Property(e => e.QrcodeCreated).HasColumnName("qrcode_created");
            entity.Property(e => e.QrcodeDeleted).HasColumnName("qrcode_deleted");
            entity.Property(e => e.QrcodeDescription)
                .HasMaxLength(200)
                .HasColumnName("qrcode_description");
            entity.Property(e => e.QrcodeExpiry).HasColumnName("qrcode_expiry");
            entity.Property(e => e.QrcodeGuid)
                .HasMaxLength(200)
                .HasColumnName("qrcode_guid");
            entity.Property(e => e.QrcodeName)
                .HasMaxLength(50)
                .HasColumnName("qrcode_name");
            entity.Property(e => e.QrcodePoint).HasColumnName("qrcode_point");
            entity.Property(e => e.QrcodeType).HasColumnName("qrcode_type");
            entity.Property(e => e.QrcodeUpdated).HasColumnName("qrcode_updated");
        });

        modelBuilder.Entity<QrcodeLog>(entity =>
        {
            entity.ToTable("qrcode_log");

            entity.Property(e => e.QrcodeLogId).HasColumnName("qrcode_log_id");
            entity.Property(e => e.QrcodeLogCreated)
                .HasColumnType("datetime")
                .HasColumnName("qrcode_log_created");
            entity.Property(e => e.QrcodeLogMemberId).HasColumnName("qrcode_log_member_id");
            entity.Property(e => e.QrcodeLogMessage).HasColumnName("qrcode_log_message");
            entity.Property(e => e.QrcodeLogQrcodeId)
                .HasMaxLength(200)
                .HasColumnName("qrcode_log_qrcode_id");
            entity.Property(e => e.QrcodeLogResult)
                .HasMaxLength(20)
                .HasColumnName("qrcode_log_result");
            entity.Property(e => e.QrcodeLogType)
                .HasMaxLength(20)
                .HasColumnName("qrcode_log_type");
        });

        modelBuilder.Entity<Survey>(entity =>
        {
            entity.ToTable("survey");

            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.Createdat).HasColumnName("createdat");
            entity.Property(e => e.Deletedat).HasColumnName("deletedat");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.LimitCount).HasColumnName("limit_count");
            entity.Property(e => e.LimitDays).HasColumnName("limit_days");
            entity.Property(e => e.Probability)
                .HasMaxLength(200)
                .HasColumnName("probability");
            entity.Property(e => e.Ranks)
                .HasMaxLength(50)
                .HasColumnName("ranks");
            entity.Property(e => e.Resultimageurl).HasColumnName("resultimageurl");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");
            entity.Property(e => e.SurveyCode)
                .HasMaxLength(50)
                .HasColumnName("survey_code");
            entity.Property(e => e.SurveyGroup)
                .HasMaxLength(100)
                .HasColumnName("survey_group");
            entity.Property(e => e.SurveyImageurl)
                .HasMaxLength(200)
                .HasColumnName("survey_imageurl");
            entity.Property(e => e.SurveyLinktext)
                .HasMaxLength(100)
                .HasColumnName("survey_linktext");
            entity.Property(e => e.SurveyName)
                .HasMaxLength(50)
                .HasColumnName("survey_name");
            entity.Property(e => e.SurveyText).HasColumnName("survey_text");
            entity.Property(e => e.SurveyTitle)
                .HasMaxLength(50)
                .HasColumnName("survey_title");
            entity.Property(e => e.SurveyType).HasColumnName("survey_type");
            entity.Property(e => e.Updatedat).HasColumnName("updatedat");
            entity.Property(e => e.Upperlimit)
                .HasMaxLength(200)
                .HasColumnName("upperlimit");
        });

        modelBuilder.Entity<SurveyHistory>(entity =>
        {
            entity.HasKey(e => e.SurveyHistoryId).HasName("PK_history_survey");

            entity.ToTable("survey_history");

            entity.Property(e => e.SurveyHistoryId)
                .HasMaxLength(100)
                .HasColumnName("survey_history_id");
            entity.Property(e => e.Createdat).HasColumnName("createdat");
            entity.Property(e => e.DeliveryDatetime)
                .HasColumnType("datetime")
                .HasColumnName("delivery_datetime");
            entity.Property(e => e.LastUseDatetime).HasColumnName("last_use_datetime");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.MemberLineid)
                .HasMaxLength(100)
                .HasColumnName("member_lineid");
            entity.Property(e => e.Result)
                .HasMaxLength(100)
                .HasColumnName("result");
            entity.Property(e => e.Sendedat).HasColumnName("sendedat");
            entity.Property(e => e.Subtotal).HasColumnName("subtotal");
            entity.Property(e => e.SurveyGroup)
                .HasMaxLength(100)
                .HasColumnName("survey_group");
            entity.Property(e => e.SurveyId).HasColumnName("survey_id");
            entity.Property(e => e.TransactionHeadId)
                .HasMaxLength(100)
                .HasColumnName("transactionHeadId");
            entity.Property(e => e.UseCount).HasColumnName("use_count");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.ShopId).HasColumnName("shop_id");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.UpdateDatetime)
                .HasColumnType("datetime")
                .HasColumnName("update_datetime");
            entity.Property(e => e.UserCode)
                .HasMaxLength(100)
                .HasColumnName("user_code");
            entity.Property(e => e.UserCreated).HasColumnName("user_created");
            entity.Property(e => e.UserDefaultSeisanKind)
                .HasMaxLength(100)
                .HasColumnName("user_default_seisan_kind");
            entity.Property(e => e.UserDeleted).HasColumnName("user_deleted");
            entity.Property(e => e.UserDisplayName)
                .HasMaxLength(4)
                .HasColumnName("user_display_name");
            entity.Property(e => e.UserDivisionId).HasColumnName("user_division_id");
            entity.Property(e => e.UserDivisions)
                .HasMaxLength(100)
                .HasColumnName("user_divisions");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(100)
                .HasColumnName("user_email");
            entity.Property(e => e.UserLastlogindatetime)
                .HasColumnType("datetime")
                .HasColumnName("user_lastlogindatetime");
            entity.Property(e => e.UserLineaccountId).HasColumnName("user_lineaccount_id");
            entity.Property(e => e.UserLineaccountRole)
                .HasMaxLength(100)
                .HasColumnName("user_lineaccount_role");
            entity.Property(e => e.UserLoginid)
                .HasMaxLength(100)
                .HasColumnName("user_loginid");
            entity.Property(e => e.UserLv)
                .HasMaxLength(10)
                .HasColumnName("user_lv");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("user_name");
            entity.Property(e => e.UserPwd)
                .HasMaxLength(100)
                .HasColumnName("user_pwd");
            entity.Property(e => e.UserStoreId).HasColumnName("user_store_id");
            entity.Property(e => e.UserToken)
                .HasMaxLength(1000)
                .HasColumnName("user_token");
            entity.Property(e => e.UserUpdated).HasColumnName("user_updated");
            entity.Property(e => e.WorkEndDate)
                .HasColumnType("date")
                .HasColumnName("work_end_date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
