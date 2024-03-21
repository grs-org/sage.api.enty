select DO_piece Piece,DO_Date Date ,AR_Ref CodeArticle,DL_Design Designation,DL_Qte Quantite
,DL_Remise01REM_Valeur Remise
,DL_PrixUnitaire Prix,DL_Taxe1 Taxe,DL_MontantHT MontantHT,DL_MontantTTC MontantTTC
from F_DOCLIGNE
where  DO_Type = @Type