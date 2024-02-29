SELECT  F_ARTCOMPTA.ACP_ComptaCPT_Taxe1 CodeTaxe,tx.TA_Taux  Taux
FROM F_ARTCOMPTA 
inner join F_TAXE tx on tx.TA_Code = ACP_ComptaCPT_Taxe1
WHERE 
ACP_Champ=1 and ACP_Type = 0
and AR_Ref = @Reference
union 
SELECT  F_famCOMPTA.fCP_ComptaCPT_Taxe1 CodeTaxe,tx.TA_Taux Taux
FROM F_FAMCOMPTA 
inner join f_article on f_article.FA_CodeFamille=F_FAMCOMPTA.FA_CodeFamille
inner join F_TAXE tx on tx.TA_Code = F_famCOMPTA.fCP_ComptaCPT_Taxe1
WHERE  FCP_Champ=1 and FCP_Type = 0
and AR_Ref = @Reference