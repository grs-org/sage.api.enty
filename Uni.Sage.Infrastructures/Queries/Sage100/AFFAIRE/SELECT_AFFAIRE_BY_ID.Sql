select Code,Intitule,PlanAnalytique,Domaine  from 
( select 
 F_COMPTEA.CA_NUM as Code , P_ANALYTIQUE.A_INTITULE PlanAnalytique,  
 F_COMPTEA.CA_INTITULE as    Intitule
 ,P_ANALYTIQUE.A_INTITULE as CA_PLAN_ANALYTIQUE , 
 Case P_ANALYTIQUE.cbIndice
 when P_PARAMETRECIAL.P_CHPANALDOC then 'Oui' Else 'Non' end As CA_CODE_AFFAIRE ,
 F_COMPTEA.CA_DOMAINE as Domaine From 
 F_COMPTEA inner join P_ANALYTIQUE 
 on F_COMPTEA.N_Analytique = P_ANALYTIQUE.CbIndice 
 left join P_PARAMETRECIAL on   P_ANALYTIQUE.CBINDICE =P_PARAMETRECIAL.P_CHPANALDOC ) VwAffaire 
 where VwAffaire.Domaine = 0 and VwAffaire.CA_CODE_AFFAIRE = 'OUI' and VwAffaire.Code=@Affaire