SELECT F_ARTSTOCK.AR_Ref Reference,art.AR_Design Designation, DE_No CodeDepot,AS_MontSto Montant,AS_QteSto QuantiteReel,AS_QteRes QuantiteReserve from F_ARTSTOCK
inner join F_ARTICLE art on art.AR_Ref = F_ARTSTOCK.AR_Ref
where DE_No = @CodeDepot and F_ARTSTOCK.AR_Ref = @Reference