SELECT * FROM (
 SELECT [D_DebutExo01]  D_DebutEx ,[D_FinExo01]  D_FinExo,[D_Archivage01] D_Archivage 	FROM  [dbo].[P_DOSSIER] UNION
 SELECT [D_DebutExo02]  D_DebutEx ,[D_FinExo02]	 D_FinExo,[D_Archivage02] D_Archivage	FROM  [dbo].[P_DOSSIER] UNION
 SELECT [D_DebutExo03]  D_DebutEx ,[D_FinExo03]	 D_FinExo,[D_Archivage03] D_Archivage	FROM  [dbo].[P_DOSSIER] UNION
 SELECT [D_DebutExo04]  D_DebutEx ,[D_FinExo04]	 D_FinExo,[D_Archivage04] D_Archivage	FROM  [dbo].[P_DOSSIER] UNION
 SELECT [D_DebutExo05]  D_DebutEx ,[D_FinExo05]	 D_FinExo,[D_Archivage05] D_Archivage	FROM  [dbo].[P_DOSSIER]  
 ) ex WHERE @D_DATE BETWEEN	ex.D_DebutEx AND ex.D_FinExo