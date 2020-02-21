CREATE TABLE [HangFire].[Job] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [StateId]        INT            NULL,
    [StateName]      NVARCHAR (20)  NULL,
    [InvocationData] NVARCHAR (MAX) NOT NULL,
    [Arguments]      NVARCHAR (MAX) NOT NULL,
    [CreatedAt]      DATETIME       NOT NULL,
    [ExpireAt]       DATETIME       NULL,
	JobMethod   AS( CONVERT( NVARCHAR(500), SUBSTRING( InvocationData, PATINDEX('%"Method":"%',InvocationData)+10, CHARINDEX('"',InvocationData, PATINDEX('%"Method":"%',InvocationData)+10) - (PATINDEX('%"Method":"%',InvocationData)+10) ) ) ) PERSISTED,
    CONSTRAINT [PK_HangFire_Job] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

CREATE INDEX [IX_HangFire_Job_JobMethod]
  ON [HangFire].[Job] ([JobMethod])
  INCLUDE ([StateId], [StateName])
  ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_HangFire_Job_StateName]
    ON [HangFire].[Job]([StateName] ASC);
GO

CREATE NONCLUSTERED INDEX [IX_HangFire_Job_ExpireAt]
    ON [HangFire].[Job]([ExpireAt] ASC)
    INCLUDE([Id]);
GO
