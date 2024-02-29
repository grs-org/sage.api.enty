select A.*,isnull(TA_Taux,0) Taux from (select f_comptet.CT_Num Client ,
AR_Design Designation , F_ARTICLE.AR_Ref  Reference,AR_PrixVen PrixVent,
F_ARTICLE.AR_PrixTTC typePrix,F_FAMILLE.FA_Intitule Segment,
P_UNITE.U_Intitule Unité,
case when a.AR_Ref is not null then  a.acp_comptaCPT_taxe1 
else fa.FCP_ComptaCPT_Taxe1 end CodeTaxe from F_ARTICLE 
inner join P_UNITE on F_ARTICLE.AR_UniteVen = P_UNITE.cbIndice
inner join F_FAMILLE on F_ARTICLE.FA_CodeFamille = F_FAMILLE.FA_CodeFamille
left join  (select ar_ref,isnull(acp_comptaCPT_taxe1,0) taxe,acp_comptaCPT_taxe1 
from  F_ARTCOMPTA 
where ACP_Champ= @CatCompta and ACP_Type=0 )a on a.ar_ref=f_article.ar_ref
INNER join  F_FAMCOMPTA fa on fa.FA_CodeFamille=f_famille.FA_CodeFamille 
and FCP_Champ=@CatCompta and FCP_Type=0 
left outer join f_comptet on f_comptet.N_CatCompta=@CatCompta
where ar_sommeil = 0  and F_COMPTET.CT_Type = 0 
and f_comptet.CT_Num =@CodeClient
AND F_ARTICLE.AR_Ref=@CodeArticle )a 
left outer join F_TAXE on F_TAXE.TA_Code = CodeTaxe