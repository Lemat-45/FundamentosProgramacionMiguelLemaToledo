using System;

namespace _2.ConstantesDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constantes
            const string iva = "19%";
            string nombre = "Perry";
            nombre = "agente P";
            //iva = "20%"; a una constante no le puedo vambiar el valor
            //tipos de datos
            byte dato1 = 255;
            int dato2 = -12365; //datos de numeros enteros, incluyendo negativo
            //byte se refiere a datos entre 0 y 255
            long dato3 = 12345678910;//datos largos
            float dato4 = 5.3f; //decimales, más cortos
            double dato5 = 12.36d; //decimales más largos
            decimal dato6 = 1.241521536465125m; //valores decimales precisos de hasta 29 caracteres 
            char dato7 = 'Ø'; //un caractér de unicode
            string dato8 = "dato88Ø bienvenido agente P"; //cualquier tipo de texto
            bool dato9 = true; //true or false
            object dato10 = new object();

            //operadores
            //Operadores numéricos
            //cambio de signo
            int datoll = 5;
            int dato12 = -datoll;
            Console.WriteLine("datoll: {0}: dato12: {1}", datoll, dato12);
            int dato13 = 3 + 5;
            Console.WriteLine("el valor de la suma es:{0}",dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("el valor de la resta es {0}",dato14); //chequeo para confirmar la correcta ejecución del dato 14
            int dato15 = dato13 * dato1;
            Console.WriteLine("el valor de la multiplicación es:{0}", dato15);
            float dato16 =(float) 5 / 3;//el (float) es para que EL RESULTADO salga decimal y la variable también ha de ser declarada como decimal también se podría hacer como
            //=5f/3f;
            Console.WriteLine("el valor de la división es es:{0}",dato16);
        }
    }
}