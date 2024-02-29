select  DO_Piece Piece,isnull(DL_PieceBC,'') PieceBC,isnull(DL_PieceBL,'') PieceBL,isnull(DL_PieceDE,'') PieceDE,
DO_Date Date,dcl.CT_Num CodeClient ,cpt.CT_Intitule Client,isnull(DO_Ref,'') Reference,dcl.AR_Ref CodeArticle, DL_Design Designaion
,DL_Qte Quantite,DL_Remise01REM_Valeur Remise1,
DL_Remise02REM_Valeur Remise2,DL_Remise03REM_Valeur Remise3,isnull(DL_PrixUnitaire,0) PrixUnitaire,DL_Taxe1 Taxe1,
DL_Taxe2 Taxe2,DL_Taxe3 Taxe3,artGM.EG_Enumere Gamme1,isnull(artGM2.EG_Enumere,'') Gamme2,
isnull(ls.LS_NoSerie,' ')LotSerie,dcl.EU_Enumere Unite,
dpt.DE_Intitule Depot,isnull(coll.CO_Nom+' '+coll.CO_Prenom,' ') as Collaborateur,
dcl.CA_Num CodeAffaire,isnull(cptA.CA_Intitule,'') as Affaire,isnull(DL_MontantHT,0) MontantHT,isnull(DL_MontantTTC,0)MontantTTC
,dcl.AG_No1 ,dcl.AG_No2
from f_docligne dcl
left outer join F_COMPTET cpt on cpt.CT_Num = dcl.CT_Num
left outer join F_DEPOT dpt on dpt.DE_No = dcl.de_no
left outer join F_COLLABORATEUR coll on coll.CO_No = dcl.CO_No
left outer join F_COMPTEA cptA on cptA.CA_Num = dcl.CA_Num
left outer join F_ARTGAMME artGM on artGM.AG_No =dcl.AG_No1 
left outer join F_ARTGAMME artGM2 on artGM2.AG_No =dcl.AG_No2
left outer join F_LOTSERIE ls on ls.DL_NoIn = dcl.DL_No
where do_type=0 and DO_Domaine =0