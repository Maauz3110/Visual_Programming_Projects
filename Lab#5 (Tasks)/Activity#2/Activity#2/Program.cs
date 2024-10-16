using System;
using System.IO;

namespace program
{
    public class Class1
    {
        static void Main(string[] args)
        {
            TestCatch2();
        }

        static void TestCatch2()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Online Computer\OneDrive\Desktop\233599,VP,LAB#5\Activity#2\test.txt")) 
                {
                    sw.WriteLine("hello");
                    Console.WriteLine("Wrote to file: C:\\Users\\Online Computer\\OneDrive\\Desktop\\233599,VP,LAB#5\\Activity#2\\test.txt");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
