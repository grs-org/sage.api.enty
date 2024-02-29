select CT_num CodeFournisseur, CT_Intitule Intitule, CG_NumPrinc CompteCollectif,CT_Qualite Qualite,CT_Classement Classement,
	CT_Contact Contact, CT_Adresse Adresse,CT_Telephone Telephone,CT_Complement Complement, CT_Ville Ville,CT_Pays Pays,CT_Identifiant Identifiant 
	,F_comptet.CO_No CodeCollaborateur,coll.CO_Nom Nom,coll.CO_Prenom Prenom, F_COMPTET.DE_No CodeDepot, dpt.DE_Intitule Depot from F_COMPTET
	left outer join F_COLLABORATEUR coll on coll.CO_No = F_COMPTET.CO_No
	left outer join F_DEPOT dpt on dpt.DE_No = F_COMPTET.DE_No
	where CT_TYPE=1