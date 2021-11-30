using System;
using System.Linq;
namespace Traduccion_de_codigo__Clases_
{
    class ProgramaG
    {
        public static string opc;
        class Totaldecalculos{
            private string borde; private double DatPi; private double result;
        public void Bienvenida(){
            borde=string.Concat(Enumerable.Repeat("*", 50));
            DatPi=3.14;
            Console.Clear();
            System.Console.WriteLine(borde+"\n\t       PROGRAMA PARA GEOMETRIA \n"+borde);
            Console.WriteLine("¿Qué area desea Calcular? \n\n(C) Circulo. \n(R) Rectángulo. \n(T) Triángulo. \n(S) Salir.\n");
        }
        public void AC(){
            Console.Clear();
            Console.WriteLine(borde+"\n\t  Calculo del area del circulo\n"+borde);
            Console.WriteLine("\nIngrese el Radio -> ");
            double vr = Int32.Parse(Console.ReadLine());
            Double x= (Double) vr;
            result= DatPi*(x*x);
            System.Console.WriteLine("El area del circulo es: " + result);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        public void AR(){
            Console.Clear();
            Console.WriteLine(borde+"\n\t  Calculo del area del rectangulo\n"+borde);
            Console.WriteLine("\nIngrese la Base ->");
            double vb = Int32.Parse(Console.ReadLine());
            Double x= (Double) vb;
            Console.WriteLine("Ingrese la Altura ->");
            double va = Int32.Parse(Console.ReadLine());
            Double y= (Double) va;
            result=vb*va;
            System.Console.WriteLine("El area del rectangulo es: " + result);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        public void AT(){
            Console.Clear();
            Console.WriteLine(borde+"\n\t  Calculo del area del triángulo\n"+borde);
            Console.WriteLine("\nIngrese la Base ->");
            double vb = Int32.Parse(Console.ReadLine());
            Double x= (Double) vb;
            Console.WriteLine("Ingrese la Altura ->");
            double va = Int32.Parse(Console.ReadLine());
            Double y= (Double) va;
            result=(va*vb)/2;
            System.Console.WriteLine("El area del triangulo es: " + result);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();}
        public void BORD(){
            System.Console.WriteLine(borde+"\n\tError - Escoja una opción correcta\n"+borde);
            System.Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();}
        }
        static void Main(string[] args)
        {
            Totaldecalculos Llamadodeclase= new Totaldecalculos();
            Llamadodeclase.Bienvenida();
            while (opc != "S"){
            System.Console.WriteLine("Ingrese su opcion -> "); 
            opc=Console.ReadLine();
            System.Console.WriteLine();
            if (opc=="S" || opc=="s"){
                System.Console.WriteLine("\n\nGracias por usar el programa de cálculo geométrico\n\n"); 
                break;
            }
            else if (opc=="C" || opc=="c"){
                Llamadodeclase.AC();
                Llamadodeclase.Bienvenida();
            }
            else if (opc=="R" || opc=="r"){
                Llamadodeclase.AR();
                Llamadodeclase.Bienvenida();
            }
            else if (opc=="T" || opc=="t"){
                Llamadodeclase.AT();
                Llamadodeclase.Bienvenida();
            }
            else{
                Llamadodeclase.BORD();
                Llamadodeclase.Bienvenida();
            }
            }
        }
    }
}