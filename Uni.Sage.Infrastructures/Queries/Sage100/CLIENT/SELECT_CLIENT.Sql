select client.cbMarq Id,
       client.CT_num CodeClient,
       client.CT_Intitule Intitule,
       client.CT_Sommeil EnSommeil,
       client.CG_NumPrinc CompteCollectif,
       client.CT_Qualite Qualite,
       client.N_CatTarif CodeTarif,
       trf.CT_Intitule Tarif,
       client.CT_Classement Classement,
       client.CT_Contact Contact,
       client.CT_Telephone Telephone,
       client.CT_Pays Pays,
       client.CT_Ville Ville,
       client.CT_Adresse + ' ' + client.CT_Complement Adresse,
       client.CT_Identifiant Identifiant,
       client.CO_No CodeCollaborateur,
       coll.CO_Nom + ' ' + coll.CO_Prenom Collaborateur,
       client.DE_No CodeDepot,
       dpt.DE_Intitule Depot
from F_COMPTET client
    left outer join F_COLLABORATEUR coll
        on coll.CO_No = client.CO_No
    left outer join F_DEPOT dpt
        on dpt.DE_No = client.DE_No
    left outer join P_CATTARIF trf
        on client.N_CatTarif = trf.cbIndice
where CT_TYPE = 0