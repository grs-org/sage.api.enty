select F_ARTFOURNISS.ar_ref,art.AR_Design Designation,F_ARTFOURNISS.CT_Num CodeFournisseur,
cpt.CT_Intitule Fournisseur, AF_RefFourniss Reference,AF_PrixAch PrixAchat,
AF_PrixDev PrixDev,AF_Remise Remise from F_ARTFOURNISS
left outer join F_ARTICLE art on art.AR_Ref =  F_ARTFOURNISS.AR_Ref
left outer join F_COMPTET cpt on cpt.CT_Num =  F_ARTFOURNISS.CT_Num