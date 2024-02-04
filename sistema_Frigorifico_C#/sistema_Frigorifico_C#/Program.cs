using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_Frigorifico_C_
{
    

    public class Program
    {
        //Variáveis globais, na qual vão ter seus valores modificados em diferentes escopos
        double peso = 0, peso_Max = 0, peso_Min = 3000000000, peso_Velho = 0, peso_Novo = 0, peso_Total = 0; 
        int id_animal = 0, meses_animal = 0, mais_velho = 0, mais_novo = 0, id_MaisPesado = 0, id_MaisLeve = 0, meses_MaisPesado = 0, meses_MaisLeve = 0, meses_Total = 0, contador = 0;

        static void Main(string[] args)
        {
            double preco_arroba = 0; 
            int escolha = 0;

            while(true)
            {
                int decisao = 0; 
                Console.WriteLine("Digite o preço da arroba do boi: ");
                try
                {
                    preco_arroba = Convert.ToDouble(Console.ReadLine());

                }
                catch(Exception e)
                {
                    Console.WriteLine("Formato incorreto no preenchimento!") ;
                    decisao = 1;
                }
                if (decisao == 0)
                    break;
                    
                //if (GetType(escolha))
            }

            Console.WriteLine("Saiu do loop!");
            //while(true)
            Console.ReadLine();
              
        }
    }
}
