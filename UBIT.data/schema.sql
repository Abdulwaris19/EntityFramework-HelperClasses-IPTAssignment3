USE [IPTw]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 12/22/2020 7:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointment_id] [int] IDENTITY(1,1) NOT NULL,
	[appointment_number] [int] NOT NULL,
	[appointment_doctor_id] [int] NOT NULL,
	[appointment_patient_id] [int] NOT NULL,
	[appointment_type] [nvarchar](255) NOT NULL,
	[appointment_date] [datetime] NOT NULL,
	[appointment_description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[appointment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 12/22/2020 7:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_name] [nvarchar](255) NOT NULL,
	[doctor_specialist] [nvarchar](255) NOT NULL,
	[Gender] [bit] NULL,
	[doctor_mobile] [nvarchar](255) NOT NULL,
	[doctor_email] [nvarchar](252) NOT NULL,
	[doctor_address] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicalRecord]    Script Date: 12/22/2020 7:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalRecord](
	[mrecord_id] [int] IDENTITY(1,1) NOT NULL,
	[mrecord_patient_id] [int] NOT NULL,
	[mrecord_patient_problem] [nvarchar](max) NOT NULL,
	[mrecord_dateofExamintion] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mrecord_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 12/22/2020 7:00:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patient_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_name] [nvarchar](255) NOT NULL,
	[Gender] [bit] NULL,
	[patient_mobile] [nvarchar](255) NOT NULL,
	[patient_email] [nvarchar](252) NOT NULL,
	[pateint_address] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctor] FOREIGN KEY([appointment_doctor_id])
REFERENCES [dbo].[Doctor] ([doctor_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctor]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([appointment_patient_id])
REFERENCES [dbo].[Patient] ([patient_id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[MedicalRecord]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecord_Patient] FOREIGN KEY([mrecord_patient_id])
REFERENCES [dbo].[Patient] ([patient_id])
GO
ALTER TABLE [dbo].[MedicalRecord] CHECK CONSTRAINT [FK_MedicalRecord_Patient]
GO
