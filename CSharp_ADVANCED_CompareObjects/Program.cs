// See https://aka.ms/new-console-template for more information

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Compare natives values with operator ==
            //int number1 = 0;
            //int number2 = 0;

            //string str1 = new string("ALFREDO");
            //string str2 = new string(" Alfredo ");

            //Console.WriteLine(number1 == number2); //True
            //Console.WriteLine(str2 == str1); // False

            //str2 = str2.ToUpper().Trim();

            //Console.WriteLine(str2 == str1); // True
            #endregion


            #region Compare reference values with operator ==

            Example example = new Example();
            example.MyProperty1 = 1;
            example.MyProperty2 = 2;


            Example example1 = new Example();
            example1.MyProperty1 = 1;
            example1.MyProperty2 = 2;

            Console.WriteLine(example == example1);//False if the operator == not is override ¿¿¿¿???? Compare the refrences of object

            Console.WriteLine(
                example1.MyProperty1 == example.MyProperty1
                && example.MyProperty2 == example1.MyProperty2);// True ¿¿¿¿???? Compare the values of objects


            #endregion


            Console.ReadLine();


        }
    }

    public class Example
    {
        public int MyProperty2 { get; set; }
        public int MyProperty1 { get; set; }

        public static bool operator ==(Example c1, Example c2)
        {
            return
                c1.MyProperty1 == c2.MyProperty1
                && c1.MyProperty2 == c2.MyProperty2;
        }

        public static bool operator !=(Example c1, Example c2)
        {

            return
                !(c1.MyProperty1 == c2.MyProperty1
                && c1.MyProperty2 == c2.MyProperty2);
        }
    }

}
