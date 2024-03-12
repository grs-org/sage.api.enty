select DO_Piece Piece,DO_Date Date,DO_Ref Reference,DO_Tiers CodeClient,cpt.CT_Intitule Client
,F_DOCENTETE.CO_No CodeCollaborateur,
c.CO_Nom + ' ' +c.CO_Prenom Collaborateur ,F_DOCENTETE.DE_No CodeDepot,dpt.DE_Intitule Depot
,t.CT_Intitule Tarif,
case when do_statut=0 then 'Saisi'
when do_statut=1 then 'Confirmé' else 'A facturer' end Statut,
DO_TotalHT TotalHT,DO_TotalTTC TotalTTC
 from F_DOCENTETE 
 left outer join F_COMPTET cpt on cpt.CT_Num = F_DOCENTETE.DO_Tiers
 left outer join F_COLLABORATEUR c on c.CO_No = F_DOCENTETE.CO_No
 left outer join F_DEPOT dpt on dpt.DE_No = F_DOCENTETE.DE_No
 left outer join P_CATTARIF t on t.cbIndice = F_DOCENTETE.DO_Tarif
where DO_Type = 5