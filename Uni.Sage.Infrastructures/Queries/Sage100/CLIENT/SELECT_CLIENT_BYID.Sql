select CT_num CodeClient, F_COMPTET.CT_Intitule Intitule,CT_Sommeil EnSommeil ,CG_NumPrinc CompteCollectif,CT_Qualite Qualite,CT_Classement Classement,
	CT_Contact Contact, CT_Adresse Adresse,CT_Telephone Telephone,CT_Complement Complement, CT_Ville Ville,CT_Pays Pays,CT_Identifiant Identifiant 
	,F_comptet.CO_No CodeCollaborateur,coll.CO_Nom Nom,coll.CO_Prenom Prenom, F_COMPTET.DE_No CodeDepot, dpt.DE_Intitule Depot,N_CatTarif CodeTarif,
	cat.CT_Intitule
	from F_COMPTET
	left outer join F_COLLABORATEUR coll on coll.CO_No = F_COMPTET.CO_No
	left outer join F_DEPOT dpt on dpt.DE_No = F_COMPTET.DE_No
	left outer join P_CATTARIF cat on cat.cbIndice = F_COMPTET.N_CatTarif
	where CT_TYPE=0 and ct_num = @CodeClient