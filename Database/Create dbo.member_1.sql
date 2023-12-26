USE [master]
GO

/****** Object: Table [dbo].[member] Script Date: 10/8/2023 10:31:19 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[member] (
    [member_id]                               INT             IDENTITY (1, 1) NOT NULL,
    [member_pos_id]                           INT             NULL,
    [member_code]                             NVARCHAR (100)  NOT NULL,
    [member_shop_id]                          INT             NOT NULL,
    [member_lastname]                         NVARCHAR (50)   NOT NULL,
    [member_firstname]                        NVARCHAR (50)   NOT NULL,
    [member_lastname_kana]                    NVARCHAR (50)   NOT NULL,
    [member_firstname_kana]                   NVARCHAR (50)   NOT NULL,
    [member_zipcode]                          NVARCHAR (10)   NULL,
    [member_pref]                             NVARCHAR (10)   NULL,
    [member_address]                          NVARCHAR (1000) NULL,
    [member_tel]                              NVARCHAR (20)   NULL,
    [member_fax]                              NVARCHAR (20)   NULL,
    [member_mobile]                           NVARCHAR (20)   NULL,
    [member_email]                            NVARCHAR (50)   NULL,
    [member_gender]                           TINYINT         NULL,
    [member_birthday]                         DATETIME2 (7)   NULL,
    [member_hold_point]                       INT             NULL,
    [member_point_limit_date]                 DATETIME2 (7)   NULL,
    [member_last_pointget_date]               DATETIME2 (7)   NULL,
    [member_last_pointget_point]              SMALLINT        NULL,
    [member_last_visit_date]                  DATETIME2 (7)   NULL,
    [member_join_date]                        DATETIME2 (7)   NULL,
    [member_drop_date]                        DATETIME2 (7)   NULL,
    [member_allow_email]                      TINYINT         NULL,
    [member_rank]                             NVARCHAR (50)   NULL,
    [member_note]                             NVARCHAR (MAX)  NULL,
    [member_status]                           TINYINT         NOT NULL,
    [member_ordinal]                          INT             NOT NULL,
    [member_visibility]                       BIT             NOT NULL,
    [member_tag]                              NVARCHAR (50)   NULL,
    [member_nonce]                            NVARCHAR (1000) NULL,
    [member_lineid]                           NVARCHAR (100)  NULL,
    [member_stripeId]                         NVARCHAR (200)  NULL,
    [member_password_hash]                    NVARCHAR (MAX)  NULL,
    [member_password_salt]                    NVARCHAR (MAX)  NULL,
    [member_email_verify_token]               NVARCHAR (MAX)  NULL,
    [member_email_verify_expired_at]          DATETIME2 (7)   NULL,
    [member_password_reset_token]             NVARCHAR (MAX)  NULL,
    [member_password_reset_verify_expired_at] DATETIME2 (7)   NULL,
    [member_is_password_reset_verified]       BIT             NOT NULL,
    [member_pending_email]                    NVARCHAR (50)   NULL,
    [member_pending_email_verify_token]       NVARCHAR (50)   NULL,
    [member_is_signup_verified]               BIT             NOT NULL,
    [member_signup_verify_token]              NVARCHAR (MAX)  NULL,
    [member_searchtext]                       NVARCHAR (MAX)  NULL,
    [member_createat]                         DATETIME2 (7)   NOT NULL,
    [member_updateat]                         DATETIME2 (7)   NULL,
    [member_deleteat]                         DATETIME2 (7)   NULL
);


