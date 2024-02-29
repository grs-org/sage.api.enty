select DO_Piece Piece,DO_Date Date,DO_Ref Reference,DO_Tiers CodeClient,
ent.CO_No CodeCollaborateur,coll.CO_Nom+' '+coll.CO_Prenom as Collaborateur,ent.DE_No CodeDepot,dpt.DE_Intitule Depot,
ent.CA_Num CodeAffaire,aff.CA_Intitule Affaire,DO_Souche CodeSouche,sch.S_Intitule Souche,
ent.CG_Num CodeCompteCollectif,cpt.CG_Intitule CompteCollectif,DO_TotalHT TotalHT,DO_TotalTTC TotalTTC 
from F_DOCENTETE ent
inner join F_DEPOT dpt on dpt.DE_No = ent.DE_No
left outer join F_COLLABORATEUR coll on coll.CO_No = ent.CO_no
left outer join F_COMPTEA aff on aff.CA_Num = ent.CA_Num
left outer join P_SOUCHEVENTE sch on sch.cbIndice = DO_Souche +1
left outer join F_COMPTEG cpt on cpt.CG_Num = ent.CG_Num
where DO_Domaine = 0 and DO_Type = 0