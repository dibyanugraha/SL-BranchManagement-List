if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[xtBranch]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[xtBranch]
GO

CREATE TABLE [dbo].[xtBranch] (
	[BranchID] [char] (10)  NOT NULL ,
    [CpnyID] [char] (10)  NOT NULL ,	
	[Contact] [char] (30)  NOT NULL ,
	[Descr] [char] (30)  NOT NULL ,
	[Fax] [char] (30)  NOT NULL ,
	[GrwPct] [Int] NOT NULL ,
	[GrwVal] [Float] NOT NULL ,
	[Phone] [char] (30)  NOT NULL ,
	[TranDate] [smalldatetime] NOT NULL ,
	[tstamp] [timestamp] NOT NULL 
) ON [PRIMARY]
GO

 CREATE  UNIQUE  CLUSTERED  INDEX [xtBranch0] ON [dbo].[xtBranch]([BranchID]) ON [PRIMARY]
GO

