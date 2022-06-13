using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandocomDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data =  new DateTime(2001, 5, 8);
            //para exibir a data com a hora
            Debug.WriteLine(data);
            //para exibir a data sem a hora
            Debug.WriteLine(data.ToString("d"));
            //para exibir a data sem a hora, mas na cultura brasileira
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            //para exibir o dia e o mês
            Debug.WriteLine(data.ToString("dd/MM")); // atenção o MM do mês deve ser em maisculo, pois a propriedade é sensitive e pode identificar como minutos caso estja como minusculo
            //para exibir o dia e o mês e o ano somente com os dois digitos
            Debug.WriteLine(data.ToString("dd/MM/yy"));

            //exibir a data com o horario
            data = new DateTime(2001, 5, 8, 13, 40, 55, 987);
            Debug.WriteLine(data); 
            //mostrar hora e minutos no formatado brasileiro
            Debug.WriteLine(data.ToString("HH:mm"));
            //mostrar hora, minutos, segundos e milisegundos formatado brasileiro
            Debug.WriteLine(data.ToString("HH:mm:ss.fff"));


            //mostrar data por extenso
            Debug.WriteLine(data.ToString("D"));
            //mostrar data por extenso sem o ano
            Debug.WriteLine(data.ToString("m"));
            //mostrar data por extenso mês e ano
            Debug.WriteLine(data.ToString("Y"));


            //mostrar data geral
            Debug.WriteLine(data.ToString("G"));
            //mostrar data geral sem os segundos
            Debug.WriteLine(data.ToString("g"));


            //formato DateTime
            Debug.WriteLine(data.ToString("O"));
            // o Parse faz a conversão de string para DataTime          -- formatando a saida
            Debug.WriteLine(DateTime.Parse(data.ToString("O")).ToString("dd/MM/yyyy HH:mm:s.fff"));

            //mostrar somente hora e minuto
            Debug.WriteLine(data.ToString("t"));
            //mostrar hora e minuto e segundo
            Debug.WriteLine(data.ToString("T"));



        }
    }
}
