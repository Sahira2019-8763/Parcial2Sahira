using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahiraReyes2doParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 0, v2 = 0, v3 = 0, v4 = 0, i = 0, num;
            double res, n1, n2, n3, n4;
            Console.WriteLine("BIENVENIDO AL SISTEMA DE VOTACION");
            Console.WriteLine("Los partidos de estas elecciones son los siguientes :");
            Console.WriteLine("Partido Moderno de los Conejos, (P.M.C.) Fundado el 1996");
            Console.WriteLine("Partido Mariposa Bella, (P.M.B.) Fundado el 1991");
            Console.WriteLine("Partido Delfines Voladores, (P.D.V.) Fundado el 1989");
            Console.WriteLine(" ");
            Console.WriteLine("Los candidatos de estas elecciones son los siguientes: ");
            Console.WriteLine("P.M.C.  Ramon Ortega.      Candidato a Presidente.");
            Console.WriteLine("P.D.V.  Luis Rodriguez.    Candidato a Presidente.");
            Console.WriteLine("P.M.B.  Luissana Ortiz.    Candidata a Presidenta.");
            Console.WriteLine("P.M.C.  Antonio Guzman.    Candidato a Presidente.");
            Console.WriteLine("                 CASILLAS DE VOTACION:                    ");
            Console.WriteLine("CASILLA 1- Ramon Ortega.     CASILLA 2- Luis Rodriguez");
            Console.WriteLine("CASILLA 3- Luissana Ortiz.   CASILLA 4- Antonio Guzman");
            for (i = 1; i <= 1000; i++)
            {
                Random al = new Random();
                num = Convert.ToInt32(al.Next(1, 5));
                Console.Write(" ");
                if (num == 1)
                {
                    v1 = v1 + 1;
                }
                else if (num == 2)
                {
                    v2 = v2 + 1;
                }
                else if (num == 3)
                {
                    v3 = v3 + 1;
                }
                else if (num == 4)
                {
                    v4 = v4 + 1;
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("GENERANDO VOTOS....  Presione ENTER para ver resultados");
            Console.Read();
            res = v1 + v2 + v3 + v4;
            n1 = (v1 / res) * 100;
            n2 = (v2 / res) * 100;
            n3 = (v3 / res) * 100;
            n4 = (v4 / res) * 100;
            Console.WriteLine("RESULTADOS:");
            if ((n1 > n2) && (n2 > n3) && (n3 > n4))
            {
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + "% de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
            }
            else if ((n2 > n1) && (n1 > n3) && (n3 > n4))
            {
                Console.WriteLine(" Luis  Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + "% de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
            }
            else if ((n3 > n1) && (n1 > n2) && (n2 > n4))
            {
                Console.WriteLine(" Luissana  Ortiz tiene " + v3 + " votos acumulados con un " + n3 + "% de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
            }
            else if ((n4 > n1) && (n1 > n3) && (n3 > n2))
            {
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + "% de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
            }
            else if ((n2 > n3) && (n3 > n1) && (n1 > n4))
            {
                Console.WriteLine(" Luis  Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + "% de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
            }
            else if ((n1 > n3) && (n3 > n2) && (n2 > n4))
            {
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + "% de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
            }
            else if ((n1 > n4) && (n4 > n3) && (n3 > n2))
            {
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + "% de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
            }
            else if ((n2 > n4) && (n4 > n3) && (n3 > n1))
            {
                Console.WriteLine(" Luis  Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + "% de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
            }
            else if ((n2 > n4) && (n4 > n1) && (n1 > n3))
            {
                Console.WriteLine(" Luis  Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + "% de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
            }
            else if ((n3 > n2) && (n2 > n1) && (n1 > n4))
            {
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + "% de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
            }
            else if ((n3 > n4) && (n4 > n2) && (n2 > n1))
            {
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + "% de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
            }
            else if ((n1 > n2) && (n2 > n4) && (n4 > n3))
            {
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + "% de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
            }
            else if ((n1 > n3) && (n3 > n4) && (n4 > n2))
            {
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + "% de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
            }
            else if ((n2 > n1) && (n1 > n4) && (n4 > n3))
            {
                Console.WriteLine(" Luis  Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + "% de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
            }
            else if ((n2 > n3) && (n3 > n4) && (n4 > n1))
            {
                Console.WriteLine(" Luis  Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + "% de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos");
                Console.WriteLine(" Ramon Ortega  tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
            }
            else if ((n1 > n4) && (n4 > n2) && (n2 > n3))
            {
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + "% de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
            }
            else if ((n3 > n4) && (n4 > n1) && (n1 > n2))
            {
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + "% de votos");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos ");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
            }
            else if ((n3 > n2) && (n2 > n4) && (n4 > n1))
            {
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + "% de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + " % de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
            }
            else if ((n4 > n1) && (n1 > n2) && (n2 > n3))
            {
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + "% de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
            }
            else if ((n4 > n2) && (n2 > n3) && (n3 > n1))
            {
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + "% de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
            }
            else if ((n4 > n2) && (n2 > n1) && (n1 > n3))
            {
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + "% de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
            }
            else if ((n4 > n3) && (n3 > n2) && (n2 > n1))
            {
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + "% de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos ");
            }
            else if ((n4 > n3) && (n3 > n1) && (n1 > n2))
            {
                Console.WriteLine(" Antonio Guzman tiene " + v4 + " votos acumulados con un " + n4 + "% de votos");
                Console.WriteLine(" Luissana Ortiz tiene " + v3 + " votos acumulados con un " + n3 + " % de votos ");
                Console.WriteLine(" Ramon Ortega tiene " + v1 + " votos acumulados con un " + n1 + " % de votos");
                Console.WriteLine(" Luis Rodriguez tiene " + v2 + " votos acumulados con un " + n2 + " % de votos ");
            }
            Console.ReadKey();
        }
    }
}
