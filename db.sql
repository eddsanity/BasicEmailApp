/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     4/27/2019 7:23:19 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ATTACHMENT') and o.name = 'FK_ATTACHME_REFERENCE_EMAIL')
alter table ATTACHMENT
   drop constraint FK_ATTACHME_REFERENCE_EMAIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMAIL') and o.name = 'FK_EMAIL_REFERENCE_USER')
alter table EMAIL
   drop constraint FK_EMAIL_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMAIL') and o.name = 'FK_EMAIL_REF_6_USER')
alter table EMAIL
   drop constraint FK_EMAIL_REF_6_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FOLDER') and o.name = 'FK_FOLDER_REFERENCE_USER')
alter table FOLDER
   drop constraint FK_FOLDER_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FOLDEREMAIL') and o.name = 'FK_FOLDEREM_REFERENCE_EMAIL')
alter table FOLDEREMAIL
   drop constraint FK_FOLDEREM_REFERENCE_EMAIL
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('FOLDEREMAIL') and o.name = 'FK_FOLDEREM_REFERENCE_FOLDER')
alter table FOLDEREMAIL
   drop constraint FK_FOLDEREM_REFERENCE_FOLDER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MAILINGLIST') and o.name = 'FK_MAILINGL_REFERENCE_USER')
alter table MAILINGLIST
   drop constraint FK_MAILINGL_REFERENCE_USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MAILINGLISTUSERS') and o.name = 'FK_MAILINGL_INCLUDED__USER')
alter table MAILINGLISTUSERS
   drop constraint FK_MAILINGL_INCLUDED__USER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('MAILINGLISTUSERS') and o.name = 'FK_MAILINGL_REFERENCE_MAILINGL')
alter table MAILINGLISTUSERS
   drop constraint FK_MAILINGL_REFERENCE_MAILINGL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ATTACHMENT')
            and   type = 'U')
   drop table ATTACHMENT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMAIL')
            and   type = 'U')
   drop table EMAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FOLDER')
            and   type = 'U')
   drop table FOLDER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FOLDEREMAIL')
            and   type = 'U')
   drop table FOLDEREMAIL
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MAILINGLIST')
            and   type = 'U')
   drop table MAILINGLIST
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MAILINGLISTUSERS')
            and   type = 'U')
   drop table MAILINGLISTUSERS
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"USER"')
            and   type = 'U')
   drop table "USER"
go

/*==============================================================*/
/* Table: ATTACHMENT                                            */
/*==============================================================*/
create table ATTACHMENT (
   ATTACHMENTID         int    identity(1,1) not null,
   EMAILID              int                  not null,
   TYPE                 varchar(10)              null,
   URL                  varchar(200)             null,
   constraint PK_ATTACHMENT primary key (ATTACHMENTID, EMAILID)
)
go

/*==============================================================*/
/* Table: EMAIL                                                 */
/*==============================================================*/
create table EMAIL (
   EMAILID              int  identity(1,1) not null,
   SENDERID             int                    null,
   RECEIVERID           int                    null,
   SUBJECT              varchar(100)           null,
   BODY                 varchar(8000)          null,
   DATE                 datetime               null,
   ARCHIVED             bit                    null,
   constraint PK_EMAIL primary key (EMAILID)
)
go

/*==============================================================*/
/* Table: FOLDER                                                */
/*==============================================================*/
create table FOLDER (
   FOLDERID             int  identity(1,1) not null,
   USERID               int                not null,
   NAMEFOLDER           varchar(20)            null,
   constraint PK_FOLDER primary key (FOLDERID, USERID)
)
go

/*==============================================================*/
/* Table: FOLDEREMAIL                                           */
/*==============================================================*/
create table FOLDEREMAIL (
   EMAILID              int			 not null,
   FOLDERID             int          not null,
   USERID               int          not null,
   constraint PK_FOLDEREMAIL primary key (EMAILID, FOLDERID, USERID)
)
go

/*==============================================================*/
/* Table: MAILINGLIST                                           */
/*==============================================================*/
create table MAILINGLIST (
   LISTID               int  identity(1,1) not null,
   USERID               int                    null,
   NAMEMAILINGLIST      varchar(20)            null,
   constraint PK_MAILINGLIST primary key (LISTID)
)
go

/*==============================================================*/
/* Table: MAILINGLISTUSERS                                      */
/*==============================================================*/
create table MAILINGLISTUSERS (
   LISTID               int              not null,
   USERID               int              not null,
   constraint PK_MAILINGLISTUSERS primary key (LISTID, USERID)
)
go

/*==============================================================*/
/* Table: "USER"                                                */
/*==============================================================*/
create table "USER" (
   USERID               int  identity(1,1) not null,
   FIRSTNAME			varchar(26) 		   null,
   LASTNAME				varchar(26)			   null,
   USERNAME             varchar(30)            null,
   EMAIL                varchar(45)            null,
   PASSWORD             varchar(60)            null,
   constraint PK_USER primary key nonclustered (USERID)
)
go

alter table ATTACHMENT
   add constraint FK_ATTACHME_REFERENCE_EMAIL foreign key (EMAILID)
      references EMAIL (EMAILID)
         on delete cascade
go

alter table EMAIL
   add constraint FK_EMAIL_REFERENCE_USER foreign key (SENDERID)
      references "USER" (USERID)
go

alter table EMAIL
   add constraint FK_EMAIL_REF_6_USER foreign key (RECEIVERID)
      references "USER" (USERID)
go

alter table FOLDER
   add constraint FK_FOLDER_REFERENCE_USER foreign key (USERID)
      references "USER" (USERID)
go

alter table FOLDEREMAIL
   add constraint FK_FOLDEREM_REFERENCE_EMAIL foreign key (EMAILID)
      references EMAIL (EMAILID)
go

alter table FOLDEREMAIL
   add constraint FK_FOLDEREM_REFERENCE_FOLDER foreign key (FOLDERID, USERID)
      references FOLDER (FOLDERID, USERID)
go

alter table MAILINGLIST
   add constraint FK_MAILINGL_REFERENCE_USER foreign key (USERID)
      references "USER" (USERID)
go

alter table MAILINGLISTUSERS
   add constraint FK_MAILINGL_INCLUDED__USER foreign key (USERID)
      references "USER" (USERID)
go

alter table MAILINGLISTUSERS
   add constraint FK_MAILINGL_REFERENCE_MAILINGL foreign key (LISTID)
      references MAILINGLIST (LISTID)
go

