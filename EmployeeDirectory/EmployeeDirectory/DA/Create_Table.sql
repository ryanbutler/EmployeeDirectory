USE [Emp_Dir]
GO

/****** Object:  Table [dbo].[EmployeeDirectory]    Script Date: 3/9/2018 2:27:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[EmployeeDirectory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FName] [varchar](50) NULL,
	[LName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[GUID] [uniqueidentifier] NOT NULL,
	[JobTitle] [varchar](50) NULL,
	[OfficeLoc] [varchar](50) NULL,
 CONSTRAINT [PK_EmployeeDirectory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[EmployeeDirectory] ADD  CONSTRAINT [DF_EmployeeDirectory_GUID]  DEFAULT (newid()) FOR [GUID]
GO
