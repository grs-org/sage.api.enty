SELECT fc.N_Analytique,pa.A_Intitule,fc.CA_Num,fc.CA_Type FROM 
P_ANALYTIQUE pa INNER JOIN F_COMPTEA fc	 ON fc.N_Analytique	 = pa.cbIndice