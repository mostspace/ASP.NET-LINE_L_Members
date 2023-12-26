using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using nxLINEadminAPI.Entity;
using nxLINEadminAPI.Models;

namespace nxLINEadminAPI.Entity
{
    public partial class nxLINEadminAPIContext : DbContext
    {
        public nxLINEadminAPIContext()
        {
        }

        public nxLINEadminAPIContext(DbContextOptions<nxLINEadminAPIContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<LineAccount> LineAccounts { get; set; }

        public virtual DbSet<Checkin> Checkins { get; set; }

        public virtual DbSet<Checkpoint> Checkpoints { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<Member> Member { get; set; } = default!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=devsv1.japaneast.cloudapp.azure.com;database=nxLINE;user=couponuser;password=M0dnwDnW");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Japanese_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                
                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(100)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserLastlogindatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("user_lastlogindatetime");

                entity.Property(e => e.UserLoginId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_loginid");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserPwd)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("user_pwd");

                entity.Property(e => e.UserLineAccountID)
                    .HasColumnName("user_lineaccount_id")
                    .HasColumnType("int");
                entity.Property(e => e.UserLineAccountRole)
                    .HasMaxLength(20)
                    .HasColumnName("user_lineaccount_role");

                entity.Property(e => e.UserCreated)
                    .HasColumnName("user_created");
                entity.Property(e => e.UserUpdated)
                    .HasColumnName("user_updated");
            });
            modelBuilder.Entity<LineAccount>(b =>
            {
                b.ToTable("lineaccount");
                b.Property<int>(e => e.LineaccountId)
                    .HasColumnType("int")
                    .HasColumnName("lineaccount_id");

                b.Property<int?>(e => e.EntryPoint)
                    .HasColumnType("int")
                    .HasColumnName("entrypoint");

                b.Property<bool?>(e => e.IsProfile)
                    .HasColumnType("bit")
                    .HasColumnName("isprofile");

                b.Property<bool?>(e => e.IsSmaregi)
                    .HasColumnName("issmaregi")
                    .HasColumnType("bit");

                b.Property<bool?>(e => e.Istalk)
                    .HasColumnName("istalk")
                    .HasColumnType("bit");

                b.Property<string>(e => e.LineChannelAccessToken)
                    .HasColumnName("line_channelaccesstoken")
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>(e => e.LineChannelId)
                    .HasColumnName("line_channelid")
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar(10)");

                b.Property<string>(e => e.LineChannelSecret)
                    .HasColumnName("line_channelsecret")
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>(e => e.LineaccountCode)
                    .HasColumnName("lineaccount_code")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<string>(e => e.LineaccountShortcode)
                    .HasColumnName("lineaccount_shortcode")
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnType("nvarchar(5)");

                b.Property<string>(e => e.LineaccountEmail)
                    .HasColumnName("lineaccount_email")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<string>(e => e.LineaccountLogoUrl)
                    .HasColumnName("lineaccount_logourl")
                    .HasMaxLength(1000)
                    .HasColumnType("nvarchar(1000)");

                b.Property<string>(e => e.LineaccountName)
                    .HasColumnName("lineaccount_name")
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<DateTime?>(e => e.LineaccountCreated)
                    .HasColumnName("lineaccount_created")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>(e => e.LineaccountDeleted)
                    .HasColumnName("lineaccount_deleted")
                    .HasColumnType("datetime2");

                b.Property<DateTime?>(e => e.LineaccountUpdated)
                    .HasColumnName("lineaccount_updated")
                    .HasColumnType("datetime2");

                b.Property<string>(e => e.MembersCardColor)
                    .HasColumnName("memberscard_color")
                    .HasMaxLength(10)
                    .HasColumnType("nvarchar(10)");

                b.Property<string>(e => e.MembersCardDesignUrl)
                    .HasColumnName("memberscard_designurl")
                    .HasMaxLength(1000)
                    .HasColumnType("nvarchar(1000)");

                b.Property<bool>(e => e.MembersCardIsUseCamera)
                    .HasColumnName("memberscard_isusecamera")
                    .HasColumnType("bit");

                b.Property<string>(e => e.MembersCardLiffId)
                    .HasColumnName("memberscard_liffid")
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<int?>(e => e.PointExpire)
                    .HasColumnName("pointexpire")
                    .HasColumnType("int");

                b.Property<string>(e => e.ProfileSetting)
                    .HasColumnName("profile_setting")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>(e => e.SmaregiContractId)
                    .HasColumnName("smaregi_contractid")
                    .HasMaxLength(20)
                    .HasColumnType("nvarchar(20)");

                b.Property<int?>(e => e.StartRank)
                    .HasColumnName("startrank")
                    .HasColumnType("int");

                b.Property<string>(e => e.TalkMessage)
                    .HasColumnName("talkmessage")
                    .HasColumnType("nvarchar(max)");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
