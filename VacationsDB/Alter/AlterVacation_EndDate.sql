ALTER TABLE [dbo].[tVacations]
 ADD EndDate AS (DATEADD(day, [Duration], [StartDate]));
 GO  