select DE_Intitule Depot,DP_NO CodeEmplacement,DP_Code Code,DP_Intitule Intitule from F_DEPOTEMPL
inner join F_DEPOT dpt on dpt.DE_No = F_DEPOTEMPL.DE_No