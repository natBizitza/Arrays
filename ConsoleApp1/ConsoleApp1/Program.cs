using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
  /*          string nombre = "Natalia" ;
            char[] newArr = nombre.ToCharArray();

            Array.Reverse(newArr);
            Console.WriteLine(newArr);

           //Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. Mostrar los 10 valores en pantalla.

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // in C# we need to to a for loop to show the chars of the array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            // Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. Guardar cada uno de esos strings
            // en la posición 0 , 1 y 2. Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posicion 0.

            string a, b, c;

            // an empty array in C#... In the [] we show the number of the elemnts we are planing to have in our array.
            string[] arrOfstr = new string [3];

            Console.WriteLine("Type a string.");
            a = Console.ReadLine();
            Console.WriteLine("Type one more string.");
            b = Console.ReadLine();
            Console.WriteLine("Last one.");
            c = Console.ReadLine();

           arrOfstr[0] = a;
           arrOfstr[1] = b;
           arrOfstr[2] = c;

            Console.WriteLine(arrOfstr[1]);

            Console.WriteLine(arrOfstr[2]);

            Console.WriteLine(arrOfstr[0]);

            //Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones (en orden descendente). 
            //Usar un for para mostrar los 10 valores en pantalla.

            int[] arrayNa = new int[10];

            int value = 20;
            for(int i =0; i < arrayNa.Length; i++)
            {
                arrayNa[i] = value;
                Console.WriteLine(arrayNa[i]);
                value--;
            }

            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. 
            //Usar otro for para mostrarlos en pantalla.

            int[] array1 = new int[3];

            //int a, b, c; <-- WE DON`T NEED THIS

            //Console.WriteLine("Type a number");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Type one more.");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Last one.");
            //c = Convert.ToInt32(Console.ReadLine());

            //To assign values to the empty array. 
            //Each value is saved inside an array index. That´s why we don´t need to assign variables to numbers that a user types
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Type a number");
                array1[i] = Convert.ToInt32(Console.ReadLine());          
            }

            //to show the array
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            // Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las posiciones. 
            // Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más pequeño.

            int[] array2 = new int[3];

            //To assign values to the empty array. 
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Type a number");
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            //to show the smallest int in an array
                int min = array2.Min();
                Console.WriteLine(min);

            //Poner los nombres de los meses en un array de 12. 
            //Cuando el usuario introduce un número del 1 al 12, mostrar el nombre de ese mes en pantalla.

            string[] meses = {  "enero",
                                "febrero",
                                "marzo",
                                "abril",
                                "mayo",
                                "junio",
                                "julio",
                                "agosto",
                                "septiembre",
                                "octubre",
                                "noviembre",
                                "diciembre"
                             };
            int num;

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("Type a number");

                num = Convert.ToInt32(Console.ReadLine());
                //index of the month is introduced number -1 ...GUAY
                Console.WriteLine(meses[num - 1]);
            }

              //Another way to solve it, without a loop
            Console.WriteLine(meses[Convert.ToInt32(Console.ReadLine()) - 1]);
   
            //Hacer la media de 10 valores utilizando un array OR podemos usar int av = array3.Average();
            int[] array3 = { 1, 4, 5, 5, 7, 89, 6, 8, 4, 10 };

            float result = 0;

            //the sum of the ints in the array
            int sum = array3.Sum();

            // here we save the average
             result = sum / array3.Length;

            Console.WriteLine(result);

            //Crear un array de 11 ints. Pedir al usuario que introduzca valores entre 0 y 10. Cada vez que introduzca un dígito, 
            //añadir uno al valor en esa posición del array. Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en 
            //pantalla los valores. Si introduce un número mayor que 10, decir que ese número es incorrecto. Si introduce un número 
            //negativo, mostrar en pantalla el número de cada posición y el valor que contiene. Por ejemplo, 
            // si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:

            int[] array4 = new int[11];
       
            int num;


            do
            {
                Console.WriteLine("Type any number from 0 to 10");
                num = Convert.ToInt32(Console.ReadLine());

                //int index = Array.IndexOf(array4, num);
                if (num >=0 && num < 11)
                {
                    // add to a var everytime when user obey the conditions
                    array4[num]++;
                } else if (num > 10)
                {
                    Console.WriteLine("The number is wrong.It`s greater than 10");
                } 
                //to stop the loop when a negative number is entered and show the final table
            } while (num >= 0);

            for(int i = 0; i < array4.Length; i++)
            {
                Console.WriteLine(i + "\t " + array4[i]);
            }
*/
            //Crear un array de 10 valores. Poner el valor 1 en cada una de la posición. 
            //Pedir al usuario que introduzca un número entre 0 y 9. Cada vez que introduzca un valor entre 0 y 9, 
            //mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.

            int[] arr = new int[10];
            int num;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1;
                //Console.WriteLine(arr[i]);
            }
            

            do
            {
                Console.WriteLine("Type any number from 0 to 9");
                num = Convert.ToInt32(Console.ReadLine());

                //int index = Array.IndexOf(array4, num);
                if (num >= 0 && num < 10)
                {
                    // add to a var everytime when user obey the conditions
                   int a = arr[num]*2;
                    Console.WriteLine(arr[num] + a);
                }

               
            } while (num >=0 && num <= 9);

            Console.ReadLine();
        

        }
    }
}
