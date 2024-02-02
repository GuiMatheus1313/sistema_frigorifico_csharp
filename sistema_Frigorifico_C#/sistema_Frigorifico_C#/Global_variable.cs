using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Frigorifico_C_
{
    public static class Global_variable
    {
        //Variáveis globais, na qual vão ter seus valores modificados em diferentes escopos
        static double peso { get; set; }
        static double peso_Max  {get; set;}

        static double peso_Min { get; set; },
        double peso_Velho = 0,
        static double peso_Novo = 0,
        static double peso_Total = 0,
        static double preco_arroba = 0;





        int id_animal = 0, meses_animal = 0, mais_velho = 0, mais_novo = 0, id_MaisPesado = 0, id_MaisLeve = 0, meses_MaisPesado = 0, meses_MaisLeve = 0, meses_Total = 0, contador = 0;
    }
}
