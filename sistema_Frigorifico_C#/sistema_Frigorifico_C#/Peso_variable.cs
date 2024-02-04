using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Frigorifico_C_
{
    public static class Peso_variable
    {
        //Variáveis globais, na qual vão ter seus valores modificados em diferentes escopos
        static double peso { get; set;}
        static double peso_Max  {get; set;}
        static double peso_Min { get; set;}
        static double peso_Velho { get; set;}
        static double peso_Novo { get; set; }
        static double peso_Total { get; set; }



        //Animal provavel

        static int id_animal { get; set; }
        static int meses_animal { get; set; }
        static int mais_velho { get; set; }
        static int mais_novo { get; set; }
        static int id_MaisPesado { get; set; }
        static int id_MaisLeve { get; set; }
        static int meses_MaisPesado { get; set; }
        static int meses_MaisLeve { get; set; }
        static int meses_Total { get; set; }
        static int contador { get; set; }
    }
}
