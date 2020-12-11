using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
    class Program
    {
        public static double[,] SquaredArray { get; private set; }

        static void Main(string[] args)
        {
            try
            {

            //Array();
            //SquaredMatrix();

            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadLine();
        }


        public static void Array()
        {
            Console.WriteLine("..........Welcome to my program which will calculate the determinant of a 4 by 4 matrix.........\n");
            int rows;
            int cols;
           
            //Console.Write("The total number of elements for this matrix will be 16\n");
            Console.Write("Please enter the number of rows of your matrix\n");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of columns of your matrix\n");
            cols = int.Parse(Console.ReadLine());

            double[,] my4DArray = new double[rows, cols];

            /* The values inputed will be accepted in the following series of code inputs*/
            /* Where i represents rows and j represents columns*/
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Please enter the elements of the  Matrix in the order: [{0} , {1}] ", i, j);
                    my4DArray[i, j] = int.Parse(Console.ReadLine());
                }
            }


            /* The next lines of code enables the user print the inputed values of the matrix to the console*/

            Console.Write("The Matrix created is : ");
            Console.WriteLine();

            int l, k = 0;

            for (l = 0; l < my4DArray.GetLength(0); l++)
            {
                for (k = 0; k < my4DArray.GetLength(1); k++)
                {

                    Console.Write("[" + "{0}" + "] ", my4DArray[l, k]);

                }
                Console.WriteLine("\n");

            }


            double numberCount = my4DArray.Length;
            Console.WriteLine("The lenght of values inputed is : {0}", numberCount);

            /* The following code will compute the determinant of the already generated rows and columns */
            /* Using Crammer's Rule */


            double determinant = DeterminantOfMatrix_4By4(my4DArray, rows, cols);
            Console.WriteLine();
            Console.WriteLine(" The determinant of the matrix above is {0} matrix   ", determinant);
            Console.ReadLine();

        }


       public static double DeterminantOfMatrix_4By4(double[,] arr, int rows, int cols)
        {
            double Det = 0;
          

            double i = (arr[0, 0] * (arr[1, 1] * (arr[2, 2] * arr[3, 3]) - (arr[2, 3] * arr[3, 2])) - (arr[1, 2] * (arr[2, 1] * arr[3, 3]) - (arr[2, 3] * arr[3, 1])) + (arr[1, 3] * (arr[2, 1] * arr[3, 2]) - (arr[2, 2] * arr[3, 1])));
            double ii = (-arr[0, 1] * (arr[1, 0] * (arr[2, 2] * arr[3, 3]) - (arr[2, 3] * arr[3, 2])) - (arr[1, 2] * (arr[2, 0] * arr[3, 3]) - (arr[2, 3] * arr[3, 0])) + (arr[1, 3] * (arr[2, 0] * arr[3, 2]) - (arr[2, 2] * arr[3, 0])));
            double iii = (arr[0, 2] * (arr[1, 0] * (arr[2, 1] * arr[3, 3]) - (arr[2, 3] * arr[3, 1])) - (arr[1, 1] * (arr[2, 0] * arr[3, 3]) - (arr[2, 3] * arr[3, 0])) + (arr[1, 3] * (arr[2, 0] * arr[3, 1]) - (arr[2, 1] * arr[3, 0])));
            double iv =  (-arr[0, 3] * (arr[1, 0] * (arr[2, 1] * arr[3, 2]) - (arr[2, 2] * arr[3, 1])) - (arr[1, 1] * (arr[2, 0] * arr[3, 2]) - (arr[2, 2] * arr[3, 0])) + (arr[1, 2] * (arr[2, 0] * arr[3, 1]) - (arr[2, 1] * arr[3, 0])));

            Det = i + (- ii) + iii + (- iv);

            return Det;
        }

        /* Question 2*/
       public static void SquaredMatrix()
        {
            Console.WriteLine("This program will generate the squared value of two identical matrices\n");
            int rows;
            int cols;

            //Console.Write("Number of rows and columns is : 4");
            // rows = int.Parse(Console.ReadLine());
            // cols = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of rows of your matrix\n");
            rows = int.Parse(Console.ReadLine());
            Console.Write("Please enter the number of columns of your matrix\n");
            cols = int.Parse(Console.ReadLine());

            double[,] squaredArray = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine("Please enter the elements of the  Matrix in the order: [{0} , {1}] ", i, j);
                    squaredArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("The Matrix created is : ");
            Console.WriteLine();

            int l, k = 0;

            for (l = 0; l < squaredArray.GetLength(0); l++)
            {
                for (k = 0; k < squaredArray.GetLength(1); k++)
                {

                    Console.Write("[" + "{0}" + "] ", squaredArray[l, k]);
                    Console.WriteLine("\n");
                    Console.Write("[" + "{0}" + "] ", squaredArray[l, k]);
                }
                Console.WriteLine("\n");

            double Square= SquareOfMatrix_4By4(squaredArray, rows, cols);
            Console.WriteLine();
            }




        }

        public static double SquareOfMatrix_4By4(double[,] arr, int rows1, int cols1)
        {

            double asquare = 0;
            double bsquare = 0;
            double csquare = 0;
            double dsquare = 0;
            double esquare = 0;
            double fsquare = 0;
            double gsquare = 0;
            double hsquare = 0;
            double isquare = 0;
            double jsquare = 0;
            double ksquare = 0;
            double lsquare = 0;
            double msquare = 0;
            double nsquare = 0;
            double osquare = 0;
            double psquare = 0;

            arr.add(asquare);
            arr.add(bsquare) = 0;


            double a = (arr[0, 0] * arr[0, 0]) + (arr[0, 1] * arr[1, 0]) + (arr[0, 2] * arr[2, 0]) * (arr[0, 3]* arr[3, 0]);
            return asquare;//[0,0]

            double b = (arr[0, 0] * arr[0, 1]) + (arr[0, 1] * arr[1, 1]) + (arr[0, 2] * arr[2, 1] * (arr[0, 3] * arr[3, 1]));
            return bsquare;//[0,1]

            double c = (arr[0, 0] * arr[0, 2]) + (arr[0, 1] * arr[1, 2]) + (arr[0, 2] * arr[2, 2] * (arr[0, 3] * arr[3, 2]));
            return csquare;//[0,2]

            double d = (arr[0, 0] * arr[0, 3]) + (arr[0, 1] * arr[1, 3]) + (arr[0, 2] * arr[2, 3] * (arr[0, 3] * arr[3, 3]));
            return dsquare;//[0,3]

            double e = (arr[1, 0] * arr[0, 0]) + (arr[1, 1] * arr[1, 0]) + (arr[1, 2] * arr[2, 0] * (arr[1, 3] * arr[3, 0]));
            return esquare;//[1,0]

            double f = (arr[1, 0] * arr[0, 1]) + (arr[1, 1] * arr[1, 1]) + (arr[1, 2] * arr[2, 1] * (arr[1, 3] * arr[3, 1]));
            return fsquare;//[1,1]

            double g = (arr[1, 0] * arr[0, 2]) + (arr[1, 1] * arr[1, 2]) + (arr[1, 2] * arr[2, 2] * (arr[1, 3] * arr[3, 2]));
            return gsquare;//[1,2]

            double h = (arr[1, 0] * arr[0, 3]) + (arr[1, 1] * arr[1, 3]) + (arr[1, 2] * arr[2, 3] * (arr[1, 3] * arr[3, 3]));
            return hsquare;//[1,3]

            double i = (arr[2, 0] * arr[0, 0]) + (arr[2, 1] * arr[1, 0]) + (arr[2, 2] * arr[2, 0] * (arr[2, 3] * arr[3, 0]));
            return isquare;//[2,0]

            double j = (arr[2, 0] * arr[0, 1]) + (arr[2, 1] * arr[1, 1]) + (arr[2, 2] * arr[2, 1] * (arr[2, 3] * arr[3, 1]));
            return jsquare;//[2,1]

            double k = (arr[2, 0] * arr[0, 2]) + (arr[2, 1] * arr[1, 2]) + (arr[2, 2] * arr[2, 2] * (arr[2, 3] * arr[3, 2]));
            return ksquare;//[2,2]

            double l = (arr[2, 0] * arr[0, 3]) + (arr[2, 1] * arr[1, 3]) + (arr[2, 2] * arr[2, 3] * (arr[2, 3] * arr[3, 3]));
            return lsquare;//[2,3]

            double m = (arr[3, 0] * arr[0, 0]) + (arr[3, 1] * arr[1, 0]) + (arr[3, 2] * arr[2, 0] * (arr[3, 3] * arr[3, 0]));
            return msquare;//[3,0]

            double n = (arr[3, 0] * arr[0, 1]) + (arr[3, 1] * arr[1, 1]) + (arr[3, 2] * arr[2, 1] * (arr[3, 3] * arr[3, 1]));
            return nsquare;//[3,1]

            double o = (arr[3, 0] * arr[0, 2]) + (arr[3, 1] * arr[1, 2]) + (arr[3, 2] * arr[2, 2] * (arr[3, 3] * arr[3, 2]));
            return osquare;//[3,2]

            double p = (arr[3, 0] * arr[0, 3]) + (arr[3, 1] * arr[1, 3]) + (arr[3, 2] * arr[2, 3] * (arr[3, 3] * arr[3, 3]));
            return psquare;//[3,3]


           // double myArray[,] = new myArray[rows1 cols];
        }

    }
}