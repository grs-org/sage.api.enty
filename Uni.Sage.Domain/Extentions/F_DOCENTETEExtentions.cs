using Uni.Sage.Domain.Entities;

namespace Uni.Sage.Domain.Extentions
{
    public static class F_DOCENTETEExtentions
    {
        public static void Calculate(this F_DOCENTETE obj)
        {
            foreach (var f_DOCLIGNE in obj.F_DOCLIGNEs)
            {
                if (f_DOCLIGNE.DL_TTC == 1)
                {
                    f_DOCLIGNE.DL_PrixUnitaire = f_DOCLIGNE.DL_PUTTC / (1 + (f_DOCLIGNE.DL_Taxe1 / 100));
                }
                else
                {
                    f_DOCLIGNE.DL_PUTTC = f_DOCLIGNE.DL_PrixUnitaire * (1 + (f_DOCLIGNE.DL_Taxe1 / 100)); ;
                }
                 

                //f_DOCLIGNE.DL_MontantHT = (((f_DOCLIGNE.DL_PrixUnitaire * (1 - (f_DOCLIGNE.DL_Remise01REM_Valeur / 100))) * (1 - (f_DOCLIGNE.DL_Remise02REM_Valeur / 100))) * (1 - (f_DOCLIGNE.DL_Remise03REM_Valeur / 100))) * f_DOCLIGNE.DL_Qte;
                //f_DOCLIGNE.DL_MontantTTC = (f_DOCLIGNE.DL_MontantHT * (1 + (f_DOCLIGNE.DL_Taxe1 / 100)));
                f_DOCLIGNE.DL_MontantHT = f_DOCLIGNE.DL_MontantTTC / (1 + (f_DOCLIGNE.DL_Taxe1 / 100));
                f_DOCLIGNE.DL_MontantTTC = f_DOCLIGNE.DL_MontantTTC;


                obj.DO_TotalTTC += f_DOCLIGNE.DL_MontantTTC;
                obj.DO_TotalHTNet += f_DOCLIGNE.DL_MontantHT;

                obj.DO_NetAPayer =  obj.DO_TotalTTC;
                obj.DO_TotalHT =obj.DO_TotalHTNet;
            }

        }
    }
}