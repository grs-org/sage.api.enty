select f_artclient.AR_Ref Reference,art.AR_Design Designation, cat.CT_Intitule CategorieTarifaire,
AC_PrixVen PrixVente, AC_Remise Remise from F_ARTCLIENT
left outer join F_ARTICLE art on art.AR_Ref = f_artclient.AR_Ref
left outer join P_CATTARIF cat on cat.cbIndice = f_artclient.AC_Categorie