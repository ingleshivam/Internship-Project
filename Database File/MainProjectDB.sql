USE [MainProjectDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AcceptInvestmentTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcceptInvestmentTbl](
	[AcceptIVID] [bigint] IDENTITY(1,1) NOT NULL,
	[AcceptIVDesc] [nvarchar](max) NULL,
	[IVRequestID] [bigint] NOT NULL,
	[AmountAccepted] [decimal](18, 2) NOT NULL,
	[CloseBeforeDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_AcceptInvestmentTbl] PRIMARY KEY CLUSTERED 
(
	[AcceptIVID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AdminTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminTbl](
	[AdminID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[EmailID] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_AdminTbl] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BudgetTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetTbl](
	[BudgetID] [bigint] IDENTITY(1,1) NOT NULL,
	[BudgetAmount] [decimal](18, 2) NOT NULL,
	[IdeaID] [bigint] NOT NULL,
	[MaximumInvestmentLimit] [decimal](18, 2) NOT NULL,
	[MinimumInvestmentLimit] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_BudgetTbl] PRIMARY KEY CLUSTERED 
(
	[BudgetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoryTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryTbl](
	[CategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL DEFAULT (N''),
 CONSTRAINT [PK_CategoryTbl] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CityTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CityTbl](
	[CityID] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NOT NULL DEFAULT (N''),
	[StateID] [bigint] NOT NULL,
 CONSTRAINT [PK_CityTbl] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CountryTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryTbl](
	[CountryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_CountryTbl] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocumentTypeTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentTypeTbl](
	[DocumentTypeId] [bigint] IDENTITY(1,1) NOT NULL,
	[DocumentTypeName] [nvarchar](max) NOT NULL DEFAULT (N''),
 CONSTRAINT [PK_DocumentTypeTbl] PRIMARY KEY CLUSTERED 
(
	[DocumentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IdeaDocumentsTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdeaDocumentsTbl](
	[IdeaDocumentID] [bigint] IDENTITY(1,1) NOT NULL,
	[Attachments] [nvarchar](max) NULL,
	[DocumentTypeID] [bigint] NOT NULL,
	[IdeaID] [bigint] NOT NULL,
 CONSTRAINT [PK_IdeaDocumentsTbl] PRIMARY KEY CLUSTERED 
(
	[IdeaDocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IdeaRiskTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdeaRiskTbl](
	[RiskID] [bigint] IDENTITY(1,1) NOT NULL,
	[IdeaID] [bigint] NOT NULL,
	[RiskTitle] [nvarchar](max) NOT NULL DEFAULT (N''),
	[RiskDescription] [nvarchar](1000) NOT NULL DEFAULT (N''),
	[RiskLevel] [int] NOT NULL,
 CONSTRAINT [PK_IdeaRiskTbl] PRIMARY KEY CLUSTERED 
(
	[RiskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IdeaTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IdeaTbl](
	[IdeaID] [bigint] IDENTITY(1,1) NOT NULL,
	[IdeaName] [nvarchar](max) NULL,
	[IdeaDescription] [nvarchar](max) NULL,
	[SubCategoryID] [bigint] NOT NULL,
	[UserID] [bigint] NOT NULL,
	[PhotoFilePath] [nvarchar](max) NULL,
	[IdeaStatus] [bit] NOT NULL DEFAULT (CONVERT([bit],(0))),
 CONSTRAINT [PK_IdeaTbl] PRIMARY KEY CLUSTERED 
(
	[IdeaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvestmentPaymentTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvestmentPaymentTbl](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[PaymentAmount] [decimal](18, 2) NOT NULL,
	[PaymentDate] [datetime2](7) NOT NULL,
	[PaymentMode] [int] NOT NULL,
	[AcceptIVID] [bigint] NOT NULL,
 CONSTRAINT [PK_InvestmentPaymentTbl] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvestorDocumentTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvestorDocumentTbl](
	[InvestorDocumentID] [bigint] IDENTITY(1,1) NOT NULL,
	[isOrganization] [bit] NOT NULL,
	[isNRI] [bit] NOT NULL,
	[CIN] [nvarchar](max) NOT NULL DEFAULT (N''),
	[InvestorID] [bigint] NOT NULL,
 CONSTRAINT [PK_InvestorDocumentTbl] PRIMARY KEY CLUSTERED 
(
	[InvestorDocumentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvestorTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvestorTbl](
	[InvestorID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[InvestorAddress] [nvarchar](max) NULL,
	[InvestorMobile] [nvarchar](max) NULL,
	[CityID] [bigint] NOT NULL,
	[Password] [nvarchar](max) NULL,
	[InvestorEmail] [nvarchar](max) NULL,
	[ShortProfileDesc] [nvarchar](max) NULL,
 CONSTRAINT [PK_InvestorTbl] PRIMARY KEY CLUSTERED 
(
	[InvestorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InvestorTCTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvestorTCTbl](
	[InvestorTCID] [bigint] IDENTITY(1,1) NOT NULL,
	[InvestorTCTitle] [nvarchar](max) NOT NULL DEFAULT (N''),
	[InvestorTCDesc] [nvarchar](max) NOT NULL DEFAULT (N''),
 CONSTRAINT [PK_InvestorTCTbl] PRIMARY KEY CLUSTERED 
(
	[InvestorTCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IVRequestTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IVRequestTbl](
	[IVRequestID] [bigint] IDENTITY(1,1) NOT NULL,
	[IVRequestDesc] [nvarchar](max) NOT NULL DEFAULT (N''),
	[InvestorID] [bigint] NOT NULL,
	[AmountToBeInvested] [decimal](18, 2) NOT NULL,
	[IdeaID] [bigint] NOT NULL DEFAULT (CONVERT([bigint],(0))),
 CONSTRAINT [PK_IVRequestTbl] PRIMARY KEY CLUSTERED 
(
	[IVRequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MemberTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberTbl](
	[MemberID] [bigint] IDENTITY(1,1) NOT NULL,
	[MemberName] [nvarchar](max) NULL,
	[MemberRole] [nvarchar](max) NULL,
	[ShortProfileDesc] [nvarchar](max) NULL,
	[IdeaID] [bigint] NOT NULL,
 CONSTRAINT [PK_MemberTbl] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PreviousWorkTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreviousWorkTbl](
	[PreviousWorkID] [bigint] IDENTITY(1,1) NOT NULL,
	[WorkTitle] [nvarchar](max) NULL,
	[WorkDescription] [nvarchar](max) NULL,
	[Duration] [bigint] NOT NULL,
	[TentativeBudget] [decimal](18, 2) NOT NULL,
	[UserID] [bigint] NOT NULL,
 CONSTRAINT [PK_PreviousWorkTbl] PRIMARY KEY CLUSTERED 
(
	[PreviousWorkID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QueryTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QueryTbl](
	[QueryID] [bigint] IDENTITY(1,1) NOT NULL,
	[QueryDescription] [nvarchar](max) NOT NULL DEFAULT (N''),
	[IdeaID] [bigint] NOT NULL,
	[QueryDate] [datetime2](7) NOT NULL,
	[InvestorID] [bigint] NOT NULL DEFAULT (CONVERT([bigint],(0))),
 CONSTRAINT [PK_QueryTbl] PRIMARY KEY CLUSTERED 
(
	[QueryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SolutionTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolutionTbl](
	[SolutionID] [bigint] IDENTITY(1,1) NOT NULL,
	[SolutionDesc] [nvarchar](max) NULL,
	[QueryID] [bigint] NOT NULL,
	[SolutionDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SolutionTbl] PRIMARY KEY CLUSTERED 
(
	[SolutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StagesTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StagesTbl](
	[StageID] [bigint] IDENTITY(1,1) NOT NULL,
	[StageName] [nvarchar](max) NULL,
	[StageDescription] [nvarchar](max) NULL,
	[IdeaID] [bigint] NOT NULL,
 CONSTRAINT [PK_StagesTbl] PRIMARY KEY CLUSTERED 
(
	[StageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[States]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateID] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NOT NULL DEFAULT (N''),
	[CountryID] [bigint] NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubCategoryTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubCategoryTbl](
	[SubCategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[SubCategoryName] [nvarchar](max) NOT NULL DEFAULT (N''),
	[CategoryID] [bigint] NOT NULL,
 CONSTRAINT [PK_SubCategoryTbl] PRIMARY KEY CLUSTERED 
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTbl](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[CityID] [bigint] NOT NULL,
	[EmailID] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[ShortProfileDesc] [nvarchar](max) NULL,
	[EducationDetails] [nvarchar](max) NULL,
	[Pincode] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTbl] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserTCTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTCTbl](
	[UserTCID] [bigint] IDENTITY(1,1) NOT NULL,
	[UserTCTitle] [nvarchar](max) NOT NULL DEFAULT (N''),
	[USerTCDesc] [nvarchar](max) NOT NULL DEFAULT (N''),
 CONSTRAINT [PK_UserTCTbl] PRIMARY KEY CLUSTERED 
(
	[UserTCID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkClosureTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkClosureTbl](
	[WorkClosureID] [bigint] IDENTITY(1,1) NOT NULL,
	[ClosureDate] [datetime2](7) NOT NULL,
	[ClosureStatus] [nvarchar](max) NULL,
	[IdeaID] [bigint] NOT NULL,
 CONSTRAINT [PK_WorkClosureTbl] PRIMARY KEY CLUSTERED 
(
	[WorkClosureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkProgressTbl]    Script Date: 02-06-2024 17:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkProgressTbl](
	[WorkProgressID] [bigint] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[CurrentStatus] [nvarchar](max) NULL,
	[ExpectedCompletionDate] [datetime2](7) NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[IdeaID] [bigint] NOT NULL,
 CONSTRAINT [PK_WorkProgressTbl] PRIMARY KEY CLUSTERED 
(
	[WorkProgressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240418044838_Init', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240420085331_AddedCCSTable', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240420090145_AddedCCSTableDataA', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240422130738_Validation_Of_Some_Classes_Removed', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240423123138_Added_AdminTbl', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240423123258_Added_CountryCityStatesTbl', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240423123537_Added_CountryCityStatesTblV1', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240423124457_Added_New_Classes', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240424102039_ValidationAddedOnUser', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240429135705_RiskID_Removed', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240505092512_Added_Idea_Status', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240509064818_AddDataAnnotatinoOnIVRequest', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240511143914_AddedInvestorIDinQueryTable', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240516033452_Added_IdeaID_IVRequestTbl', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240518040355_ValidationForInvestorTC', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240518041054_ValidationForInvestorTC1', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522095918_AddedValidationOnStateModel', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522101023_AddedValidationOnCityModel', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240522115643_AddedValidationOnCategory', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240524052256_InvDocumentValidation', N'7.0.18')
SET IDENTITY_INSERT [dbo].[AcceptInvestmentTbl] ON 

INSERT [dbo].[AcceptInvestmentTbl] ([AcceptIVID], [AcceptIVDesc], [IVRequestID], [AmountAccepted], [CloseBeforeDate]) VALUES (5, N'We are thrilled to accept your investment and welcome you aboard as a valued partner in our journey to revolutionize the way individuals manage their finances.

Your investment will play a crucial role in fueling our growth and expanding our capabilities to serve our users better', 14, CAST(200000.00 AS Decimal(18, 2)), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[AcceptInvestmentTbl] ([AcceptIVID], [AcceptIVDesc], [IVRequestID], [AmountAccepted], [CloseBeforeDate]) VALUES (6, N'We are delighted to accept your investment in our virtual fitness platform and welcome you aboard as a valued partner in our journey to redefine the future of fitness. Your investment represents not only financial support but also a vote of confidence in our vision to empower individuals worldwide to lead healthier, more active lives.', 15, CAST(150000.00 AS Decimal(18, 2)), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[AcceptInvestmentTbl] ([AcceptIVID], [AcceptIVDesc], [IVRequestID], [AmountAccepted], [CloseBeforeDate]) VALUES (7, N'We are thrilled to announce that we have successfully secured 80000 in funding for our online language learning platform. This investment represents a significant milestone in our journey towards revolutionizing language education and expanding our reach to empower learners worldwide.', 16, CAST(80000.00 AS Decimal(18, 2)), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[AcceptInvestmentTbl] ([AcceptIVID], [AcceptIVDesc], [IVRequestID], [AmountAccepted], [CloseBeforeDate]) VALUES (8, N'We are thrilled to accept your investment in our virtual fitness platform. Your belief in our vision and commitment to transforming the fitness industry is a testament to the potential of our platform to revolutionize the way people engage with their health', 17, CAST(180000.00 AS Decimal(18, 2)), CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[AcceptInvestmentTbl] OFF
SET IDENTITY_INSERT [dbo].[AdminTbl] ON 

INSERT [dbo].[AdminTbl] ([AdminID], [FirstName], [LastName], [EmailID], [MobileNumber], [Password]) VALUES (1, N'Shivam', N'Ingle', N'ingleshivam@gmail.com', N'9146721757', N'shivam')
SET IDENTITY_INSERT [dbo].[AdminTbl] OFF
SET IDENTITY_INSERT [dbo].[BudgetTbl] ON 

INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (2, CAST(50000.00 AS Decimal(18, 2)), 20022, CAST(500000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (4, CAST(200000.00 AS Decimal(18, 2)), 20024, CAST(500000.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (5, CAST(100000.00 AS Decimal(18, 2)), 20025, CAST(200000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (6, CAST(150000.00 AS Decimal(18, 2)), 20026, CAST(300000.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (7, CAST(50000.00 AS Decimal(18, 2)), 20027, CAST(100000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (8, CAST(200000.00 AS Decimal(18, 2)), 20028, CAST(500000.00 AS Decimal(18, 2)), CAST(50000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (9, CAST(80000.00 AS Decimal(18, 2)), 20029, CAST(150000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (10, CAST(75000.00 AS Decimal(18, 2)), 20030, CAST(200000.00 AS Decimal(18, 2)), CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (11, CAST(50000.00 AS Decimal(18, 2)), 20031, CAST(100000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (12, CAST(120000.00 AS Decimal(18, 2)), 20032, CAST(250000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)))
INSERT [dbo].[BudgetTbl] ([BudgetID], [BudgetAmount], [IdeaID], [MaximumInvestmentLimit], [MinimumInvestmentLimit]) VALUES (13, CAST(90000.00 AS Decimal(18, 2)), 20033, CAST(180000.00 AS Decimal(18, 2)), CAST(30000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[BudgetTbl] OFF
SET IDENTITY_INSERT [dbo].[CategoryTbl] ON 

INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10006, N'Sustainability')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10019, N'Retail')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10020, N'Technology')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10021, N'Finance')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10022, N'Agriculture')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10023, N'Education')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10024, N'Food & Beverage')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10025, N'Events & Entertainment')
INSERT [dbo].[CategoryTbl] ([CategoryID], [CategoryName]) VALUES (10026, N'Energy')
SET IDENTITY_INSERT [dbo].[CategoryTbl] OFF
SET IDENTITY_INSERT [dbo].[CityTbl] ON 

INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (4, N'Rajkot', 6)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10007, N'Nanded', 4)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10008, N'Parbhani', 4)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10009, N'Chtt. Sambhaji Nagar', 4)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10010, N'Vadodara', 6)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10012, N'Ayodhya', 5)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10013, N'Kanpur Central', 5)
INSERT [dbo].[CityTbl] ([CityID], [CityName], [StateID]) VALUES (10014, N'Prayagraj', 5)
SET IDENTITY_INSERT [dbo].[CityTbl] OFF
SET IDENTITY_INSERT [dbo].[CountryTbl] ON 

INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (1, N'United States')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (2, N'India')
INSERT [dbo].[CountryTbl] ([CountryID], [CountryName]) VALUES (3, N'Russia')
SET IDENTITY_INSERT [dbo].[CountryTbl] OFF
SET IDENTITY_INSERT [dbo].[DocumentTypeTbl] ON 

INSERT [dbo].[DocumentTypeTbl] ([DocumentTypeId], [DocumentTypeName]) VALUES (2, N'pdf')
INSERT [dbo].[DocumentTypeTbl] ([DocumentTypeId], [DocumentTypeName]) VALUES (3, N'docx')
SET IDENTITY_INSERT [dbo].[DocumentTypeTbl] OFF
SET IDENTITY_INSERT [dbo].[IdeaDocumentsTbl] ON 

INSERT [dbo].[IdeaDocumentsTbl] ([IdeaDocumentID], [Attachments], [DocumentTypeID], [IdeaID]) VALUES (4, N'\Documents\EFCorePraciseCode.pdf', 2, 20022)
SET IDENTITY_INSERT [dbo].[IdeaDocumentsTbl] OFF
SET IDENTITY_INSERT [dbo].[IdeaRiskTbl] ON 

INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (3, 20024, N'Fluctuating demand for eco-friendly products.', N'Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.Fluctuating demand for eco-friendly products.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (4, 20024, N'Sourcing reliable suppliers for sustainable products.', N'Sourcing reliable suppliers for sustainable products.Sourcing reliable suppliers for sustainable products.Sourcing reliable suppliers for sustainable products.Sourcing reliable suppliers for sustainable products.Sourcing reliable suppliers for sustainable products.Sourcing reliable suppliers for sustainable products.Sourcing reliable suppliers for sustainable products.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (5, 20024, N'Competition from established subscription box services.', N'Competition from established subscription box services.Competition from established subscription box services.Competition from established subscription box services.Competition from established subscription box services.Competition from established subscription box services.Competition from established subscription box services.', 3)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (6, 20024, N'Shipping costs and logistics challenges.', N'Shipping costs and logistics challenges.Shipping costs and logistics challenges.Shipping costs and logistics challenges.Shipping costs and logistics challenges.Shipping costs and logistics challenges.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (7, 20025, N'Technological glitches and platform reliability issues.', N'Technological glitches and platform reliability issues.Technological glitches and platform reliability issues.Technological glitches and platform reliability issues.Technological glitches and platform reliability issues.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (8, 20025, N'Competition from established fitness apps and platforms.', N'Competition from established fitness apps and platforms.Competition from established fitness apps and platforms.Competition from established fitness apps and platforms.Competition from established fitness apps and platforms.Competition from established fitness apps and platforms.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (9, 20025, N'Retaining qualified fitness instructors.', N'Retaining qualified fitness instructors.Retaining qualified fitness instructors.Retaining qualified fitness instructors.Retaining qualified fitness instructors.Retaining qualified fitness instructors.Retaining qualified fitness instructors.Retaining qualified fitness instructors.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (10, 20025, N'User adoption and engagement challenges.', N'User adoption and engagement challenges.User adoption and engagement challenges.User adoption and engagement challenges.User adoption and engagement challenges.User adoption and engagement challenges.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (12, 20026, N'Data privacy and security concerns.', N'Data privacy and security concerns.Data privacy and security concerns.Data privacy and security concerns.Data privacy and security concerns.Data privacy and security concerns.Data privacy and security concerns.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (13, 20026, N'Accuracy and reliability of AI algorithms.', N'Accuracy and reliability of AI algorithms.Accuracy and reliability of AI algorithms.Accuracy and reliability of AI algorithms.Accuracy and reliability of AI algorithms.Accuracy and reliability of AI algorithms.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (14, 20026, N'Integrating with existing banking systems and APIs.', N'Integrating with existing banking systems and APIs.Integrating with existing banking systems and APIs.Integrating with existing banking systems and APIs.Integrating with existing banking systems and APIs.Integrating with existing banking systems and APIs.Integrating with existing banking systems and APIs.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (15, 20026, N'Regulatory compliance and legal challenges.', N'Regulatory compliance and legal challenges.Regulatory compliance and legal challenges.Regulatory compliance and legal challenges.Regulatory compliance and legal challenges.Regulatory compliance and legal challenges.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (16, 20026, N'Convincing users to trust AI with their financial information.', N'Convincing users to trust AI with their financial information.Convincing users to trust AI with their financial information.Convincing users to trust AI with their financial information.Convincing users to trust AI with their financial information.Convincing users to trust AI with their financial information.Convincing users to trust AI with their financial information.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (17, 20027, N'Ensuring engagement and participation from remote teams.', N'Ensuring engagement and participation from remote teams.Ensuring engagement and participation from remote teams.Ensuring engagement and participation from remote teams.Ensuring engagement and participation from remote teams.Ensuring engagement and participation from remote teams.Ensuring engagement and participation from remote teams.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (18, 20027, N'Developing diverse and inclusive activities.', N'Developing diverse and inclusive activities.Developing diverse and inclusive activities.Developing diverse and inclusive activities.Developing diverse and inclusive activities.Developing diverse and inclusive activities.Developing diverse and inclusive activities.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (19, 20027, N'Competition from existing team-building services.', N'Competition from existing team-building services.Competition from existing team-building services.Competition from existing team-building services.Competition from existing team-building services.Competition from existing team-building services.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (20, 20027, N'Technological challenges for seamless online experiences.', N'Technological challenges for seamless online experiences.Technological challenges for seamless online experiences.Technological challenges for seamless online experiences.Technological challenges for seamless online experiences.Technological challenges for seamless online experiences.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (21, 20027, N'Establishing long-term client relationships for recurring revenue.', N'Establishing long-term client relationships for recurring revenue.Establishing long-term client relationships for recurring revenue.Establishing long-term client relationships for recurring revenue.Establishing long-term client relationships for recurring revenue.Establishing long-term client relationships for recurring revenue.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (22, 20028, N'High initial setup and operational costs.', N'High initial setup and operational costs.High initial setup and operational costs.High initial setup and operational costs.High initial setup and operational costs.High initial setup and operational costs.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (23, 20028, N'Access to suitable urban real estate and zoning regulations.', N'Access to suitable urban real estate and zoning regulations.Access to suitable urban real estate and zoning regulations.Access to suitable urban real estate and zoning regulations.Access to suitable urban real estate and zoning regulations.Access to suitable urban real estate and zoning regulations.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (24, 20028, N'Crop yield and quality consistency challenges.', N'Crop yield and quality consistency challenges.Crop yield and quality consistency challenges.Crop yield and quality consistency challenges.Crop yield and quality consistency challenges.Crop yield and quality consistency challenges.Crop yield and quality consistency challenges.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (25, 20028, N'Educating consumers and building market demand.', N'Educating consumers and building market demand.Educating consumers and building market demand.Educating consumers and building market demand.Educating consumers and building market demand.Educating consumers and building market demand.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (26, 20029, N'Competing with established language learning platforms.', N'Competing with established language learning platforms.Competing with established language learning platforms.Competing with established language learning platforms.Competing with established language learning platforms.Competing with established language learning platforms.Competing with established language learning platforms.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (27, 20029, N'Ensuring effectiveness of online teaching methods.', N'Ensuring effectiveness of online teaching methods.Ensuring effectiveness of online teaching methods.Ensuring effectiveness of online teaching methods.Ensuring effectiveness of online teaching methods.Ensuring effectiveness of online teaching methods.Ensuring effectiveness of online teaching methods.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (28, 20029, N'Recruiting qualified language tutors.', N'Recruiting qualified language tutors.Recruiting qualified language tutors.Recruiting qualified language tutors.Recruiting qualified language tutors.Recruiting qualified language tutors.Recruiting qualified language tutors.Recruiting qualified language tutors.Recruiting qualified language tutors.', 3)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (29, 20029, N'Localization and cultural adaptation for different markets.', N'Localization and cultural adaptation for different markets.Localization and cultural adaptation for different markets.Localization and cultural adaptation for different markets.Localization and cultural adaptation for different markets.Localization and cultural adaptation for different markets.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (30, 20029, N'Monetization challenges in a competitive market.', N'Monetization challenges in a competitive market.Monetization challenges in a competitive market.Monetization challenges in a competitive market.Monetization challenges in a competitive market.Monetization challenges in a competitive market.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (31, 20030, N'Ensuring food safety and quality during delivery.', N'Ensuring food safety and quality during delivery.Ensuring food safety and quality during delivery.Ensuring food safety and quality during delivery.Ensuring food safety and quality during delivery.Ensuring food safety and quality during delivery.Ensuring food safety and quality during delivery.', 3)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (32, 20030, N'Managing inventory and supply chain logistics.', N'Managing inventory and supply chain logistics.Managing inventory and supply chain logistics.Managing inventory and supply chain logistics.Managing inventory and supply chain logistics.Managing inventory and supply chain logistics.Managing inventory and supply chain logistics.Managing inventory and supply chain logistics.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (33, 20030, N'Competing with existing meal delivery services.', N'Competing with existing meal delivery services.Competing with existing meal delivery services.Competing with existing meal delivery services.Competing with existing meal delivery services.Competing with existing meal delivery services.Competing with existing meal delivery services.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (34, 20030, N'Addressing diverse dietary restrictions and preferences.', N'Addressing diverse dietary restrictions and preferences.Addressing diverse dietary restrictions and preferences.Addressing diverse dietary restrictions and preferences.Addressing diverse dietary restrictions and preferences.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (35, 20031, N'Technological challenges and platform compatibility issues.', N'Technological challenges and platform compatibility issues.Technological challenges and platform compatibility issues.Technological challenges and platform compatibility issues.Technological challenges and platform compatibility issues.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (36, 20031, N'Competition from traditional event planning firms.', N'Competition from traditional event planning firms.Competition from traditional event planning firms.Competition from traditional event planning firms.Competition from traditional event planning firms.Competition from traditional event planning firms.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (37, 20031, N'Ensuring attendee engagement and interaction.', N'Ensuring attendee engagement and interaction.Ensuring attendee engagement and interaction.Ensuring attendee engagement and interaction.Ensuring attendee engagement and interaction.Ensuring attendee engagement and interaction.Ensuring attendee engagement and interaction.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (38, 20032, N'Staying updated with evolving renewable energy technologies.', N'Staying updated with evolving renewable energy technologies.Staying updated with evolving renewable energy technologies.Staying updated with evolving renewable energy technologies.Staying updated with evolving renewable energy technologies.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (39, 20032, N'Convincing clients of the long-term benefits of renewable energy investments.', N'Convincing clients of the long-term benefits of renewable energy investments.Convincing clients of the long-term benefits of renewable energy investments.Convincing clients of the long-term benefits of renewable energy investments.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (40, 20032, N'Competing with established consultancy firms.', N'Competing with established consultancy firms.Competing with established consultancy firms.Competing with established consultancy firms.Competing with established consultancy firms.Competing with established consultancy firms.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (41, 20032, N'Navigating regulatory and permitting processes.', N'Navigating regulatory and permitting processes.Navigating regulatory and permitting processes.Navigating regulatory and permitting processes. Navigatin regulatory and permittin processes.Navigating regulatory and permitting processes.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (42, 20032, N'Balancing client expectations with project constraints.', N'Balancing client expectations with project constraints.Balancing client expectations with project constraints.Balancing client expectations with project constraints.Balancing client expectations with project constraints.Balancing client expectations with project constraints.Balancing client expectations with project constraints.', 3)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (44, 20033, N'Market Saturation', N'The online language learning market may already be saturated with established competitors, making it difficult to carve out a niche or attract users away from existing platforms.The online language learning market may already be saturated with established competitors, making it difficult to carve out a niche or attract users away from existing platforms.The online language learning market may already be saturated with established competitors, making it difficult to carve out a niche or attract users away from existing platforms.', 1)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (45, 20033, N'Technology Issues', N'Technical problems such as server outages, software bugs, or cybersecurity breaches could disrupt the platform''s functionality, leading to user frustration and loss of trust.Technical problems such as server outages, software bugs, or cybersecurity breaches could disrupt the platform''s functionality, leading to user frustration and loss of trust.', 2)
INSERT [dbo].[IdeaRiskTbl] ([RiskID], [IdeaID], [RiskTitle], [RiskDescription], [RiskLevel]) VALUES (46, 20033, N'Content Quality', N'If the platform''s learning materials, courses, or instructors are of low quality or not engaging, users may become dissatisfied and seek alternatives.If the platform''s learning materials, courses, or instructors are of low quality or not engaging, users may become dissatisfied and seek alternatives.', 2)
SET IDENTITY_INSERT [dbo].[IdeaRiskTbl] OFF
SET IDENTITY_INSERT [dbo].[IdeaTbl] ON 

INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20022, N'Eco Friendly Packaging', N'EcoFriendlyPackaging', 10005, 10024, N'\IdeaImages\shutterstock_2152470619.webp', 0)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20024, N'Eco-Friendly Subscription Box', N' Curate monthly subscription boxes filled with sustainable and eco-friendly products ranging from household items to personal care products.', 10030, 10024, N'\IdeaImages\Lets-Go-Eco-Spring-2021-4-scaled.jpg', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20025, N'Virtual Fitness Platform', N'Develop a virtual fitness platform offering live and on-demand workout classes led by professional instructors, catering to various fitness levels and preferences.', 10031, 10024, N'\IdeaImages\Firefly_Virtual_Fitness_Platform_95708.jpg', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20026, N'AI-Powered Personal Finance Assistant', N'Develop an AI-powered personal finance assistant that helps users track expenses, set budgets, and make informed financial decisions based on their spending habits and goals.', 10032, 10024, N'\IdeaImages\AIPowerdFinanceAssistant.jpg', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20027, N'Remote Team Building Platform', N'Create an online platform that facilitates team building activities and exercises for remote teams, helping improve communication, collaboration, and morale.', 10033, 10024, N'\IdeaImages\RemoteTeamBuildingPlatform.png', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20028, N'Urban Vertical Farming', N'Implement vertical farming systems in urban areas to grow fresh produce year-round, utilizing innovative hydroponic and aeroponic technologies.', 10034, 10024, N'\IdeaImages\UrbanVertcalFarming.webp', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20029, N'Online Language Learning Platform', N'Develop an online platform offering interactive language learning courses and resources for learners of all levels, with features such as live tutoring sessions and gamified exercises.', 10035, 10024, N'\IdeaImages\OnlineLanguageLearningPlatform.webp', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20030, N'Personalized Meal Prep Service', N'Offer personalized meal prep services that cater to individual dietary needs and preferences, delivering freshly prepared meals to customers'' doorsteps on a subscription basis.', 10036, 10024, N'\IdeaImages\PersonalizedMealPrep.png', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20031, N'Virtual Event Planning Service', N'Provide virtual event planning services for corporate meetings, conferences, and social gatherings, offering end-to-end event management solutions including virtual venue setup, technical support, and attendee engagement strategies', 10037, 10024, N'\IdeaImages\VirtualEventPlanningService.jpg', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20032, N'Renewable Energy Consultancy', N'Establish a consultancy firm specializing in renewable energy solutions for residential, commercial, and industrial clients, providing services such as energy audits, feasibility studies, and project management for solar, wind, and hydroelectric projects', 10038, 10024, N'\IdeaImages\RenewableEnergyConsultancy.jpg', 1)
INSERT [dbo].[IdeaTbl] ([IdeaID], [IdeaName], [IdeaDescription], [SubCategoryID], [UserID], [PhotoFilePath], [IdeaStatus]) VALUES (20033, N'Online Language Learning Platform', N'Online Language Learning PlatformOnline Language Learning PlatformOnline Language Learning PlatformOnline Language Learning PlatformOnline Language Learning PlatformOnline Language Learning PlatformOnline Language Learning Platform', 10035, 10025, N'\IdeaImages\OnlineLanguageLearningPlatform.webp', 1)
SET IDENTITY_INSERT [dbo].[IdeaTbl] OFF
SET IDENTITY_INSERT [dbo].[InvestmentPaymentTbl] ON 

INSERT [dbo].[InvestmentPaymentTbl] ([PaymentID], [PaymentAmount], [PaymentDate], [PaymentMode], [AcceptIVID]) VALUES (1, CAST(200000.00 AS Decimal(18, 2)), CAST(N'2024-05-16 09:21:59.4930000' AS DateTime2), 3, 5)
INSERT [dbo].[InvestmentPaymentTbl] ([PaymentID], [PaymentAmount], [PaymentDate], [PaymentMode], [AcceptIVID]) VALUES (2, CAST(150000.00 AS Decimal(18, 2)), CAST(N'2024-05-16 09:36:44.3440000' AS DateTime2), 2, 6)
INSERT [dbo].[InvestmentPaymentTbl] ([PaymentID], [PaymentAmount], [PaymentDate], [PaymentMode], [AcceptIVID]) VALUES (3, CAST(80000.00 AS Decimal(18, 2)), CAST(N'2024-05-16 10:46:45.8280000' AS DateTime2), 2, 7)
SET IDENTITY_INSERT [dbo].[InvestmentPaymentTbl] OFF
SET IDENTITY_INSERT [dbo].[InvestorDocumentTbl] ON 

INSERT [dbo].[InvestorDocumentTbl] ([InvestorDocumentID], [isOrganization], [isNRI], [CIN], [InvestorID]) VALUES (3, 1, 0, N'342sdf3434', 1)
SET IDENTITY_INSERT [dbo].[InvestorDocumentTbl] OFF
SET IDENTITY_INSERT [dbo].[InvestorTbl] ON 

INSERT [dbo].[InvestorTbl] ([InvestorID], [FirstName], [LastName], [InvestorAddress], [InvestorMobile], [CityID], [Password], [InvestorEmail], [ShortProfileDesc]) VALUES (1, N'Shreays', N'Sawant', NULL, NULL, 4, N'shreyas', N'shreyas7702@gmail.com', NULL)
INSERT [dbo].[InvestorTbl] ([InvestorID], [FirstName], [LastName], [InvestorAddress], [InvestorMobile], [CityID], [Password], [InvestorEmail], [ShortProfileDesc]) VALUES (2, N'Ritesh', N'Netake', NULL, NULL, 4, N'ritesh', N'ritesh@gmail.com', NULL)
INSERT [dbo].[InvestorTbl] ([InvestorID], [FirstName], [LastName], [InvestorAddress], [InvestorMobile], [CityID], [Password], [InvestorEmail], [ShortProfileDesc]) VALUES (4, N'Dhiraj', N'Nangare', NULL, NULL, 10014, N'dhiraj', N'dhiraj@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[InvestorTbl] OFF
SET IDENTITY_INSERT [dbo].[InvestorTCTbl] ON 

INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (4, N'Accredited Investor', N'By signing up as an investor, you represent and warrant that you are an accredited investor as defined by applicable securities laws.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (5, N'Investment Process', N'The investment process may vary depending on the type of investment opportunity. Please carefully review the investment terms and documentation provided for each opportunity before making an investment decision.
')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (6, N'Due Diligence', N'You are responsible for conducting your own due diligence on any investment opportunity presented on our platform. We do not provide investment advice or recommendations.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (7, N'Investment Limits', N'There may be minimum and maximum investment limits for certain investment opportunities. Please refer to the specific terms provided for each opportunity.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (8, N'No Guarantee', N'We do not guarantee the performance or success of any investment opportunity presented on our platform. Past performance is not indicative of future results.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (9, N'Regulatory Compliance', N'We comply with all applicable securities laws and regulations. By investing through our platform, you agree to abide by these laws and regulations.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (10, N'Investment Withdrawal', N'You acknowledge that investments made through our platform may have limited liquidity and may not be readily transferable or accessible. It may be difficult to sell or redeem your investment.
')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (11, N'Tax Implications', N'You are responsible for understanding and managing any tax implications associated with your investments. We do not provide tax advice.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (12, N'Confidentiality', N'You agree to maintain the confidentiality of any confidential information provided to you in connection with investment opportunities presented on our platform.')
INSERT [dbo].[InvestorTCTbl] ([InvestorTCID], [InvestorTCTitle], [InvestorTCDesc]) VALUES (13, N'Indemnification', N'You agree to indemnify and hold harmless our platform, its affiliates, and their respective officers, directors, employees, and agents from any claims, damages, liabilities, or expenses arising out of or related to your investment activities.')
SET IDENTITY_INSERT [dbo].[InvestorTCTbl] OFF
SET IDENTITY_INSERT [dbo].[IVRequestTbl] ON 

INSERT [dbo].[IVRequestTbl] ([IVRequestID], [IVRequestDesc], [InvestorID], [AmountToBeInvested], [IdeaID]) VALUES (14, N'Our company is seeking investment for the development and scaling of an AI-powered personal finance assistant. With the increasing complexity of financial decisions and the growing demand for personalized financial guidance, our solution aims to revolutionize how individuals manage their finances.', 1, CAST(200000.00 AS Decimal(18, 2)), 20026)
INSERT [dbo].[IVRequestTbl] ([IVRequestID], [IVRequestDesc], [InvestorID], [AmountToBeInvested], [IdeaID]) VALUES (15, N'Our company is seeking investment to further develop and scale our virtual fitness platform. In a world where health and wellness have become increasingly important, our platform aims to revolutionize the fitness industry by providing users with convenient access to high-quality workout experiences anytime, anywhere.', 2, CAST(150000.00 AS Decimal(18, 2)), 20025)
INSERT [dbo].[IVRequestTbl] ([IVRequestID], [IVRequestDesc], [InvestorID], [AmountToBeInvested], [IdeaID]) VALUES (16, N'We are excited to present an investment opportunity in our cutting-edge online language learning platform. In an increasingly globalized world, the demand for language education is skyrocketing. Our platform aims to revolutionize language learning by combining innovative technology with expert teaching methodologies to deliver a seamless and effective learning experience.', 2, CAST(80000.00 AS Decimal(18, 2)), 20033)
INSERT [dbo].[IVRequestTbl] ([IVRequestID], [IVRequestDesc], [InvestorID], [AmountToBeInvested], [IdeaID]) VALUES (17, N'We are excited to present to you our investment opportunity in the virtual fitness platform industry. As the world transitions towards a more digital-centric lifestyle, the demand for accessible and engaging fitness solutions has never been higher', 1, CAST(180000.00 AS Decimal(18, 2)), 20025)
SET IDENTITY_INSERT [dbo].[IVRequestTbl] OFF
SET IDENTITY_INSERT [dbo].[MemberTbl] ON 

INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (6, N'Akash More', N'CEO and Founder', N'CEO', 20024)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (7, N'Abhijeet Deshmukh', N'Operations Manager', N'Manager', 20024)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (8, N'Sandesh Bhale', N'Marketing Director', N'Director', 20024)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (9, N'Ajinkya More', N'Procurement Specialist', N'Specialist', 20024)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (10, N'Avneet Dixit', N'Customer Service Representative', N'Representative', 20024)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (11, N'Sanjay Garjale', N'CEO and Co-Founder', N'Co-Founder', 20025)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (12, N'Pooja Shinde', N'CTO (Chief Technology Officer)', N'CTO', 20025)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (13, N'Rushikesh Desai', N'Fitness Director', N'Director', 20025)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (14, N'Avdhoot Deshmukh', N'Marketing Manager', N'Manager', 20025)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (15, N'Narayan Arbad', N'Customer Support Specialist', N'Support Specialist', 20025)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (16, N'Akask Maid', N'CEO and Lead Developer', N'Lead Developer', 20026)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (17, N'Amol Tatode', N'CFO (Chief Financial Officer)', N'Financial Officier', 20026)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (18, N'Sanjay Kodgirkar', N'Data Scientist', N'Scientist', 20026)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (19, N'Sham Deshmukh', N'Business Development Manager', N'Manager', 20026)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (20, N'Harwardhan Meghmale', N'Legal Advisor', N'Advisor', 20026)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (21, N'Ajit Sonule', N'CEO and Co-Founder', N'Co-Founder', 20027)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (22, N'Shrikant Dhole', N'Product Manager', N'Manager', 20027)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (23, N'Shrikrishna Patil', N'Customer Success Manager', N'Success Manager', 20027)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (24, N'Dhiraj Kharche', N'Marketing Specialist', N'Specialist', 20027)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (25, N'Pramod Anandrao', N'Tech Support Engineer', N'Support Engineer', 20027)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (26, N'Sophia Chen', N' Chief Executive Officer (CEO)', N'Sophia is an experienced entrepreneur with a background in technology and education. With a passion for languages and a knack for innovation, she leads the strategic vision and direction of the platform, driving growth and expansion.', 20033)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (27, N'David Garcia ', N'Chief Technology Officer (CTO)', N'David is a seasoned technologist with expertise in software development and system architecture. He oversees the technical aspects of the platform, ensuring its reliability, scalability, and security while spearheading innovation in language learning technology.', 20033)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (28, N'Emily Johnson', N'Head of Content Development', N'Emily is a language enthusiast and educator with a flair for creating engaging and effective learning materials. With her expertise in curriculum design and instructional design, she leads the development of high-quality content that meets the diverse needs of learners.', 20033)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (29, N'Michael Nguyen', N'Chief Marketing Officer (CMO)', N'Michael is a strategic marketer with a track record of driving user acquisition and engagement. Leveraging his knowledge of digital marketing and user behavior, he develops and executes marketing campaigns to attract and retain users on the platform.', 20033)
INSERT [dbo].[MemberTbl] ([MemberID], [MemberName], [MemberRole], [ShortProfileDesc], [IdeaID]) VALUES (30, N'Linda Patel', N'Head of User Experience (UX)', N'Linda is a talented UX designer with a passion for creating intuitive and user-friendly interfaces. With a focus on user research and usability testing, she ensures that the platform delivers a seamless learning experience that keeps users motivated and engaged.', 20033)
SET IDENTITY_INSERT [dbo].[MemberTbl] OFF
SET IDENTITY_INSERT [dbo].[PreviousWorkTbl] ON 

INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10062, N'asdf', N'asdf', 321, CAST(123.00 AS Decimal(18, 2)), 10024)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10063, N'sadf', N'sadf', 123, CAST(123.00 AS Decimal(18, 2)), 10024)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10064, N'asdf', N'sadf', 12, CAST(123.00 AS Decimal(18, 2)), 10024)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10065, N'asdf', N'asdf', 32, CAST(123.00 AS Decimal(18, 2)), 10024)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10066, N'asdf', N'sdf', 32, CAST(3123.00 AS Decimal(18, 2)), 10024)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10067, N'asdf', N'sad', 123, CAST(34.00 AS Decimal(18, 2)), 10025)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10068, N'asdf', N'asdf', 123, CAST(3.00 AS Decimal(18, 2)), 10025)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10069, N'adfsadf', N'fsadf', 34, CAST(34.00 AS Decimal(18, 2)), 10025)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10070, N'sadf', N'adfasd', 23, CAST(3.00 AS Decimal(18, 2)), 10025)
INSERT [dbo].[PreviousWorkTbl] ([PreviousWorkID], [WorkTitle], [WorkDescription], [Duration], [TentativeBudget], [UserID]) VALUES (10071, N'sadf', N'asdfs', 3, CAST(3434.00 AS Decimal(18, 2)), 10025)
SET IDENTITY_INSERT [dbo].[PreviousWorkTbl] OFF
SET IDENTITY_INSERT [dbo].[QueryTbl] ON 

INSERT [dbo].[QueryTbl] ([QueryID], [QueryDescription], [IdeaID], [QueryDate], [InvestorID]) VALUES (1, N'Query Description', 20024, CAST(N'2024-05-12 08:28:47.9777379' AS DateTime2), 1)
INSERT [dbo].[QueryTbl] ([QueryID], [QueryDescription], [IdeaID], [QueryDate], [InvestorID]) VALUES (2, N'Develop an online language learning platform that facilitates comprehensive language acquisition for users of various proficiency levels.', 20033, CAST(N'2024-05-13 09:00:52.5298931' AS DateTime2), 2)
SET IDENTITY_INSERT [dbo].[QueryTbl] OFF
SET IDENTITY_INSERT [dbo].[SolutionTbl] ON 

INSERT [dbo].[SolutionTbl] ([SolutionID], [SolutionDesc], [QueryID], [SolutionDate]) VALUES (1, N'Solution Description !', 1, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[SolutionTbl] ([SolutionID], [SolutionDesc], [QueryID], [SolutionDate]) VALUES (2, N'Our online language learning platform aims to provide a dynamic and immersive experience for users seeking to enhance their proficiency in foreign languages. The platform offers a wide range of features tailored to accommodate learners at different stages of their language journey.', 2, CAST(N'2024-05-13 09:01:48.6791072' AS DateTime2))
SET IDENTITY_INSERT [dbo].[SolutionTbl] OFF
SET IDENTITY_INSERT [dbo].[StagesTbl] ON 

INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (6, N'Market research and product sourcing.', N'Market research and product sourcing.', 20024)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (7, N'Website development and branding.', N'Website development and branding.', 20024)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (8, N'Launch and initial marketing efforts.', N'Launch and initial marketing efforts.', 20024)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (9, N'Scaling up operations and expanding product range.', N'Scaling up operations and expanding product range.', 20024)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (10, N'Continuous improvement and customer retention strategies.', N'Continuous improvement and customer retention strategies.', 20024)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (11, N'Platform development and beta testing.', N'Platform development and beta testing.', 20025)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (12, N'Recruiting fitness instructors and content creation.', N'Recruiting fitness instructors and content creation.', 20025)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (13, N'Launch and initial user acquisition.', N'Launch and initial user acquisition.', 20025)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (14, N'Gathering user feedback and iterating platform features.', N'Gathering user feedback and iterating platform features.', 20025)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (15, N'Scaling up servers and expanding content library.', N'Scaling up servers and expanding content library.', 20025)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (16, N'Researching AI algorithms and financial data sources.', N'Researching AI algorithms and financial data sources.', 20026)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (17, N'Developing prototype and conducting alpha testing.', N'Developing prototype and conducting alpha testing.', 20026)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (18, N'Partnering with banks and financial institutions.', N'Partnering with banks and financial institutions.', 20026)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (19, N'Launching beta version and gathering user feedback.', N'Launching beta version and gathering user feedback.', 20026)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (20, N'Iterating based on user feedback and scaling up marketing efforts.', N'Iterating based on user feedback and scaling up marketing efforts.', 20026)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (21, N'Platform development and testing with pilot groups.', N'Platform development and testing with pilot groups.', 20027)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (22, N'Curating diverse team-building activities and resources.', N'Curating diverse team-building activities and resources.', 20027)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (23, N'Launching and marketing to remote-first companies.', N'Launching and marketing to remote-first companies.', 20027)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (24, N'Gathering feedback and refining platform features.', N'Gathering feedback and refining platform features.', 20027)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (25, N'Scaling up operations and expanding service offerings.', N'Scaling up operations and expanding service offerings.', 20027)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (26, N'Initial Setup and Onboarding', N'This stage involves creating an account, selecting the target language(s), and setting learning goals. ', 20033)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (27, N'Learning Path Customization', N'In this stage, users personalize their learning experience based on their proficiency level, interests, and preferred learning style. ', 20033)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (28, N'Engagement and Progress Tracking', N'Once users start learning, the platform helps them stay engaged and motivated by tracking their progress and providing feedback.', 20033)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (29, N'Interactive Learning Activities', N'This stage focuses on active learning through interactive activities and exercises. Users may participate in virtual language labs, role-playing scenarios, conversation practice with native speakers, or collaborative projects with other learners.', 20033)
INSERT [dbo].[StagesTbl] ([StageID], [StageName], [StageDescription], [IdeaID]) VALUES (30, N'Assessment and Certification', N'In the final stage, users undergo assessments to measure their language proficiency and receive certifications or badges upon successful completion of courses or exams. ', 20033)
SET IDENTITY_INSERT [dbo].[StagesTbl] OFF
SET IDENTITY_INSERT [dbo].[States] ON 

INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (1, N'Boston', 1)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (2, N'California', 1)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (3, N'New Jersey', 1)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (4, N'Maharashtra', 2)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (5, N'Utter Pradesh', 2)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (6, N'Gujarat', 2)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (7, N'Belgorod Oblast', 3)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (10011, N'Bryansk Oblast', 3)
INSERT [dbo].[States] ([StateID], [StateName], [CountryID]) VALUES (10012, N'Goa', 2)
SET IDENTITY_INSERT [dbo].[States] OFF
SET IDENTITY_INSERT [dbo].[SubCategoryTbl] ON 

INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10005, N'Packaging', 10006)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10030, N'Eco-Friendly Products', 10019)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10031, N'Fitness Tech', 10020)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10032, N'Personal Finance', 10021)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10033, N'Remote Work Solutions', 10020)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10034, N'Urban Farming', 10022)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10035, N'Online Learning', 10023)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10036, N'Meal Delivery', 10024)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10037, N'Virtual Events', 10025)
INSERT [dbo].[SubCategoryTbl] ([SubCategoryID], [SubCategoryName], [CategoryID]) VALUES (10038, N'Renewable Energy', 10026)
SET IDENTITY_INSERT [dbo].[SubCategoryTbl] OFF
SET IDENTITY_INSERT [dbo].[UserTbl] ON 

INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Password], [Address], [CityID], [EmailID], [MobileNumber], [ShortProfileDesc], [EducationDetails], [Pincode]) VALUES (10024, N'Shivam', N'Ingle', N'shivam', N'Ashirvad Nagar, Karegaon Road, Near Deshmukh Hotel, Durga Devi Mandir Road, Parbhani 431401', 4, N'sringlepatil@gmail.com', N'9146721757', N'Student at D.Y.Patil of Engineering and Technology, Kasaba Bawad, Kolhapur
Currently Pursuing B.Tech. in Computer Science and Engineering', N'SSC
Diploma in Computer Engineering
BTech in Computer Science and Engineering', N'431401')
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Password], [Address], [CityID], [EmailID], [MobileNumber], [ShortProfileDesc], [EducationDetails], [Pincode]) VALUES (10025, N'Rushikesh', N'Kadam', N'rushikesh', NULL, 4, N'rskadam1176@gmail.com', NULL, NULL, NULL, NULL)
INSERT [dbo].[UserTbl] ([UserID], [FirstName], [LastName], [Password], [Address], [CityID], [EmailID], [MobileNumber], [ShortProfileDesc], [EducationDetails], [Pincode]) VALUES (10028, N'Rupam', N'Jadhav', N'rupam', NULL, 10009, N'rupam@gmail.com', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[UserTbl] OFF
SET IDENTITY_INSERT [dbo].[UserTCTbl] ON 

INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (3, N'Eligibility', N'You must be at least 18 years old to use our platform. By signing up, you confirm that you meet this requirement.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (4, N'Account Information', N'You are responsible for maintaining the confidentiality of your account information and for all activities that occur under your account.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (5, N'Proper Use', N'You agree to use our platform only for lawful purposes and in a manner consistent with all applicable laws and regulations.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (6, N'Content', N'Any content you upload or share on our platform must not violate any copyrights, trademarks, or intellectual property rights of others.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (7, N'Prohibited Activities', N'You agree not to engage in any activity that may disrupt or interfere with the proper functioning of our platform or its users.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (8, N'Privacy', N'We respect your privacy and handle your personal information in accordance with our Privacy Policy. By using our platform, you consent to the collection and use of your information as described in the Privacy Policy.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (9, N'Modifications', N'We reserve the right to modify or update these terms and conditions at any time. You will be notified of any changes, and continued use of our platform constitutes acceptance of the modified terms.')
INSERT [dbo].[UserTCTbl] ([UserTCID], [UserTCTitle], [USerTCDesc]) VALUES (10, N'Termination', N'We reserve the right to terminate or suspend your account and access to our platform at any time, without prior notice, for any reason, including but not limited to violation of these terms and conditions.')
SET IDENTITY_INSERT [dbo].[UserTCTbl] OFF
SET IDENTITY_INSERT [dbo].[WorkClosureTbl] ON 

INSERT [dbo].[WorkClosureTbl] ([WorkClosureID], [ClosureDate], [ClosureStatus], [IdeaID]) VALUES (1, CAST(N'2024-06-12 00:00:00.0000000' AS DateTime2), N'The completion of the Online Language Learning Platform project marks a significant milestone in our journey towards providing accessible and effective language education to a global audience. Through meticulous planning, diligent execution, and unwavering dedication, we have successfully developed a comprehensive platform that empowers users to learn languages at their own pace, anytime and anywhere.', 20033)
INSERT [dbo].[WorkClosureTbl] ([WorkClosureID], [ClosureDate], [ClosureStatus], [IdeaID]) VALUES (2, CAST(N'2024-06-09 00:00:00.0000000' AS DateTime2), N'Work Closed ', 20025)
SET IDENTITY_INSERT [dbo].[WorkClosureTbl] OFF
SET IDENTITY_INSERT [dbo].[WorkProgressTbl] ON 

INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (1, CAST(N'2024-05-13 00:00:00.0000000' AS DateTime2), N'Research and Planning:

Conducted market research to identify existing personal finance management tools and user needs.
Defined user personas and user stories to guide development.
Outlined the key features and functionalities based on user requirements and market analysis.', CAST(N'2024-05-30 00:00:00.0000000' AS DateTime2), N'In-Progress', 20026)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (2, CAST(N'2024-05-13 00:00:00.0000000' AS DateTime2), N'Development:

Designed the architecture of the AI system, including data models, algorithms, and integration with external APIs for financial data.
Implemented natural language processing (NLP) algorithms to understand user queries and provide relevant responses.
Developed algorithms for personalized financial advice, budget optimization, and investment strategies.
Integrated machine learning models for expense categorization and anomaly detection.
Implemented a user-friendly interface for seamless interaction with the assistant via web and mobile platforms.', CAST(N'2024-05-30 00:00:00.0000000' AS DateTime2), N'In-Progress', 20026)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (3, CAST(N'2024-05-13 00:00:00.0000000' AS DateTime2), N'Testing:

Conducted extensive testing to ensure the accuracy and reliability of the AI algorithms.
Tested the assistant''s performance across different user scenarios and datasets.
Gathered feedback from beta testers to identify areas for improvement and refine the user experience.', CAST(N'2024-05-30 00:00:00.0000000' AS DateTime2), N'In-Progress', 20026)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (4, CAST(N'2024-05-13 00:00:00.0000000' AS DateTime2), N'Deployment:

Prepared the infrastructure for deployment, including cloud hosting and database setup.
Deployed the AI-powered personal finance assistant to production environments.
Monitored system performance and user feedback post-deployment for continuous optimization.', CAST(N'2024-05-31 00:00:00.0000000' AS DateTime2), N'In-Progress', 20026)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (5, CAST(N'2024-05-15 00:00:00.0000000' AS DateTime2), N'Platform Development:

Frontend Development: Completed user interface design for the web and mobile applications, ensuring a seamless and intuitive user experience.
Backend Development: Implemented core backend functionalities, including user authentication, session management, and content delivery.
Integration of VR/AR Technologies: Successfully integrated virtual reality and augmented reality technologies to create immersive fitness environments.', CAST(N'2024-06-07 00:00:00.0000000' AS DateTime2), N'In-Progress', 20025)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (6, CAST(N'2024-05-15 00:00:00.0000000' AS DateTime2), N'Content Creation:

Collaborated with certified fitness instructors to produce high-quality workout videos across various fitness disciplines, including yoga, HIIT, cardio, and strength training.
Developed interactive workout routines tailored to different fitness levels and preferences, enhancing user engagement and retention.', CAST(N'2024-06-07 00:00:00.0000000' AS DateTime2), N'In-Progress', 20025)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (7, CAST(N'2024-05-15 00:00:00.0000000' AS DateTime2), N'esting and Quality Assurance:

Conducted rigorous testing across multiple devices and platforms to ensure compatibility, performance, and security.
Identified and resolved bugs and issues promptly to maintain a stable and reliable platform.', CAST(N'2024-06-07 00:00:00.0000000' AS DateTime2), N'In-Progress', 20025)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (8, CAST(N'2024-05-15 00:00:00.0000000' AS DateTime2), N'User Acquisition and Marketing

Launched pre-registration campaigns to generate interest and gather early adopters.
Developed marketing collaterals and promotional materials to raise brand awareness and attract potential users.', CAST(N'2024-06-09 00:00:00.0000000' AS DateTime2), N'In-Progress', 20025)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (9, CAST(N'2024-05-16 00:00:00.0000000' AS DateTime2), N'Market Research:

Analyze the current online language learning market.
Identify target demographics, including age groups, regions, and language preferences.
Investigate competitors'' offerings and pricing models.
', CAST(N'2024-06-11 00:00:00.0000000' AS DateTime2), N'In-Progress', 20033)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (10, CAST(N'2024-05-16 00:00:00.0000000' AS DateTime2), N'Platform Development:

Design user interface and user experience (UI/UX) for the platform.
Develop the backend infrastructure for user registration, authentication, and payment processing.
Integrate features such as video conferencing for live classes, interactive exercises, progress tracking, and multimedia content.', CAST(N'2024-06-11 00:00:00.0000000' AS DateTime2), N'In-Progress', 20033)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (11, CAST(N'2024-05-16 00:00:00.0000000' AS DateTime2), N'Content Creation:

Collaborate with language experts to develop high-quality learning materials, including lessons, exercises, quizzes, and cultural insights.
Produce multimedia content like videos, audio recordings, and interactive games to enhance learning.', CAST(N'2024-06-11 00:00:00.0000000' AS DateTime2), N'In-Progress', 20033)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (12, CAST(N'2024-05-16 00:00:00.0000000' AS DateTime2), N'Testing and Iteration:

Conduct beta testing with a select group of users to gather feedback on usability, content effectiveness, and overall satisfaction.
Iterate based on user feedback, fixing bugs and improving features as needed.', CAST(N'2024-06-12 00:00:00.0000000' AS DateTime2), N'In-Progress', 20033)
INSERT [dbo].[WorkProgressTbl] ([WorkProgressID], [StartDate], [CurrentStatus], [ExpectedCompletionDate], [Remarks], [IdeaID]) VALUES (13, CAST(N'2024-05-16 00:00:00.0000000' AS DateTime2), N'Work Closed', CAST(N'2024-06-12 00:00:00.0000000' AS DateTime2), N'Closed', 20033)
SET IDENTITY_INSERT [dbo].[WorkProgressTbl] OFF
ALTER TABLE [dbo].[AcceptInvestmentTbl]  WITH CHECK ADD  CONSTRAINT [FK_AcceptInvestmentTbl_IVRequestTbl_IVRequestID] FOREIGN KEY([IVRequestID])
REFERENCES [dbo].[IVRequestTbl] ([IVRequestID])
GO
ALTER TABLE [dbo].[AcceptInvestmentTbl] CHECK CONSTRAINT [FK_AcceptInvestmentTbl_IVRequestTbl_IVRequestID]
GO
ALTER TABLE [dbo].[BudgetTbl]  WITH CHECK ADD  CONSTRAINT [FK_BudgetTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[BudgetTbl] CHECK CONSTRAINT [FK_BudgetTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[CityTbl]  WITH CHECK ADD  CONSTRAINT [FK_CityTbl_States_StateID] FOREIGN KEY([StateID])
REFERENCES [dbo].[States] ([StateID])
GO
ALTER TABLE [dbo].[CityTbl] CHECK CONSTRAINT [FK_CityTbl_States_StateID]
GO
ALTER TABLE [dbo].[IdeaDocumentsTbl]  WITH CHECK ADD  CONSTRAINT [FK_IdeaDocumentsTbl_DocumentTypeTbl_DocumentTypeID] FOREIGN KEY([DocumentTypeID])
REFERENCES [dbo].[DocumentTypeTbl] ([DocumentTypeId])
GO
ALTER TABLE [dbo].[IdeaDocumentsTbl] CHECK CONSTRAINT [FK_IdeaDocumentsTbl_DocumentTypeTbl_DocumentTypeID]
GO
ALTER TABLE [dbo].[IdeaDocumentsTbl]  WITH CHECK ADD  CONSTRAINT [FK_IdeaDocumentsTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[IdeaDocumentsTbl] CHECK CONSTRAINT [FK_IdeaDocumentsTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[IdeaRiskTbl]  WITH CHECK ADD  CONSTRAINT [FK_IdeaRiskTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[IdeaRiskTbl] CHECK CONSTRAINT [FK_IdeaRiskTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[IdeaTbl]  WITH CHECK ADD  CONSTRAINT [FK_IdeaTbl_SubCategoryTbl_SubCategoryID] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategoryTbl] ([SubCategoryID])
GO
ALTER TABLE [dbo].[IdeaTbl] CHECK CONSTRAINT [FK_IdeaTbl_SubCategoryTbl_SubCategoryID]
GO
ALTER TABLE [dbo].[IdeaTbl]  WITH CHECK ADD  CONSTRAINT [FK_IdeaTbl_UserTbl_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTbl] ([UserID])
GO
ALTER TABLE [dbo].[IdeaTbl] CHECK CONSTRAINT [FK_IdeaTbl_UserTbl_UserID]
GO
ALTER TABLE [dbo].[InvestmentPaymentTbl]  WITH CHECK ADD  CONSTRAINT [FK_InvestmentPaymentTbl_AcceptInvestmentTbl_AcceptIVID] FOREIGN KEY([AcceptIVID])
REFERENCES [dbo].[AcceptInvestmentTbl] ([AcceptIVID])
GO
ALTER TABLE [dbo].[InvestmentPaymentTbl] CHECK CONSTRAINT [FK_InvestmentPaymentTbl_AcceptInvestmentTbl_AcceptIVID]
GO
ALTER TABLE [dbo].[InvestorDocumentTbl]  WITH CHECK ADD  CONSTRAINT [FK_InvestorDocumentTbl_InvestorTbl_InvestorID] FOREIGN KEY([InvestorID])
REFERENCES [dbo].[InvestorTbl] ([InvestorID])
GO
ALTER TABLE [dbo].[InvestorDocumentTbl] CHECK CONSTRAINT [FK_InvestorDocumentTbl_InvestorTbl_InvestorID]
GO
ALTER TABLE [dbo].[InvestorTbl]  WITH CHECK ADD  CONSTRAINT [FK_InvestorTbl_CityTbl_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[CityTbl] ([CityID])
GO
ALTER TABLE [dbo].[InvestorTbl] CHECK CONSTRAINT [FK_InvestorTbl_CityTbl_CityID]
GO
ALTER TABLE [dbo].[IVRequestTbl]  WITH CHECK ADD  CONSTRAINT [FK_IVRequestTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[IVRequestTbl] CHECK CONSTRAINT [FK_IVRequestTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[IVRequestTbl]  WITH CHECK ADD  CONSTRAINT [FK_IVRequestTbl_InvestorTbl_InvestorID] FOREIGN KEY([InvestorID])
REFERENCES [dbo].[InvestorTbl] ([InvestorID])
GO
ALTER TABLE [dbo].[IVRequestTbl] CHECK CONSTRAINT [FK_IVRequestTbl_InvestorTbl_InvestorID]
GO
ALTER TABLE [dbo].[MemberTbl]  WITH CHECK ADD  CONSTRAINT [FK_MemberTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[MemberTbl] CHECK CONSTRAINT [FK_MemberTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[PreviousWorkTbl]  WITH CHECK ADD  CONSTRAINT [FK_PreviousWorkTbl_UserTbl_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserTbl] ([UserID])
GO
ALTER TABLE [dbo].[PreviousWorkTbl] CHECK CONSTRAINT [FK_PreviousWorkTbl_UserTbl_UserID]
GO
ALTER TABLE [dbo].[QueryTbl]  WITH CHECK ADD  CONSTRAINT [FK_QueryTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[QueryTbl] CHECK CONSTRAINT [FK_QueryTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[QueryTbl]  WITH CHECK ADD  CONSTRAINT [FK_QueryTbl_InvestorTbl_InvestorID] FOREIGN KEY([InvestorID])
REFERENCES [dbo].[InvestorTbl] ([InvestorID])
GO
ALTER TABLE [dbo].[QueryTbl] CHECK CONSTRAINT [FK_QueryTbl_InvestorTbl_InvestorID]
GO
ALTER TABLE [dbo].[SolutionTbl]  WITH CHECK ADD  CONSTRAINT [FK_SolutionTbl_QueryTbl_QueryID] FOREIGN KEY([QueryID])
REFERENCES [dbo].[QueryTbl] ([QueryID])
GO
ALTER TABLE [dbo].[SolutionTbl] CHECK CONSTRAINT [FK_SolutionTbl_QueryTbl_QueryID]
GO
ALTER TABLE [dbo].[StagesTbl]  WITH CHECK ADD  CONSTRAINT [FK_StagesTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[StagesTbl] CHECK CONSTRAINT [FK_StagesTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[States]  WITH CHECK ADD  CONSTRAINT [FK_States_CountryTbl_CountryID] FOREIGN KEY([CountryID])
REFERENCES [dbo].[CountryTbl] ([CountryID])
GO
ALTER TABLE [dbo].[States] CHECK CONSTRAINT [FK_States_CountryTbl_CountryID]
GO
ALTER TABLE [dbo].[SubCategoryTbl]  WITH CHECK ADD  CONSTRAINT [FK_SubCategoryTbl_CategoryTbl_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[CategoryTbl] ([CategoryID])
GO
ALTER TABLE [dbo].[SubCategoryTbl] CHECK CONSTRAINT [FK_SubCategoryTbl_CategoryTbl_CategoryID]
GO
ALTER TABLE [dbo].[UserTbl]  WITH CHECK ADD  CONSTRAINT [FK_UserTbl_CityTbl_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[CityTbl] ([CityID])
GO
ALTER TABLE [dbo].[UserTbl] CHECK CONSTRAINT [FK_UserTbl_CityTbl_CityID]
GO
ALTER TABLE [dbo].[WorkClosureTbl]  WITH CHECK ADD  CONSTRAINT [FK_WorkClosureTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[WorkClosureTbl] CHECK CONSTRAINT [FK_WorkClosureTbl_IdeaTbl_IdeaID]
GO
ALTER TABLE [dbo].[WorkProgressTbl]  WITH CHECK ADD  CONSTRAINT [FK_WorkProgressTbl_IdeaTbl_IdeaID] FOREIGN KEY([IdeaID])
REFERENCES [dbo].[IdeaTbl] ([IdeaID])
GO
ALTER TABLE [dbo].[WorkProgressTbl] CHECK CONSTRAINT [FK_WorkProgressTbl_IdeaTbl_IdeaID]
GO
