select Statut,BC NumeroBC,a.do_piece NumeroDocument from ( 
                select do_piece BC,do_piece,case when do_statut=0 then 'DElIVERED'
                when do_statut=1 then 'CONFIRMED' else 'PREPARED' end statut from f_docentete where do_type =1
                union all
                SELECT distinct DL_PieceBC BC,do_piece,
                case when DO_Type=2 THEN 'PREPARATION_LIVRAISON  ' --+ do_piece
                when DO_Type=3 then 'BON_LIVRAISON ' --+ do_piece
                when DO_Type=4 then 'RETOUR  ' --+ do_piece
                when DO_Type=5 then 'AVOIR' --+ do_piece
                when DO_Type=6 then 'FACTURE  ' --+ do_piece
                else  'FACTURE_COMPTABILISE ' --+ do_piece 
                end Statut

                 from f_docligne where do_type >1 and DO_Domaine=0 AND DL_PieceBC <> ''
                 ) a