SELECT
AR_Ref as Reference ,
AR_Design As Designation,
FM.FA_Intitule AS Famille	,
FM.FA_CodeFamille As CodeFamille , 
AR_Sommeil as EnSommiel,
AR_PoidsBrut PoidsBrut,
AR_PoidsNet PoidsNet,
AR_SuiviStock as SuiviStock ,
unt.U_Intitule Unite
FROM F_FAMILLE  FM 
INNER JOIN	 dbo.F_ARTICLE ON F_ARTICLE.FA_CodeFamille = FM.FA_CodeFamille
INNER JOIN	 dbo.P_UNITE  unt ON unt.cbIndice = F_ARTICLE.AR_UniteVen