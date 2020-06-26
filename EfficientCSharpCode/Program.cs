using System;

namespace EfficientCSharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "demo";
            Console.WriteLine("Hello World!");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 6; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
           
            Console.WriteLine();
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i.ToString() == "1")
            //    {
            //        text += "1 added";
            //        Console.WriteLine(text);
            //    }
            //}
            //if (text == "1")
            //{
            //    for (int i = 0; i < 20; i++)
            //    {                
            //        text += "1 added";
            //        Console.WriteLine(text);
            //    }
            //}

            //less code as well as faster
            //string appendText = (text.Equals("1")) ? "one" : "over one";
            //for (int i = 0; i < 100000; i++)
            //{
            //    text += appendText;
            //}
        }

        private void example()
        {
            string text = "demo";

            //This is not the best practice
            if (text == "")
            { }

            //This is slow as it checks for both null and empty
            if (string.IsNullOrEmpty(text))
            { }

            //Fast
            if (text == string.Empty)
            {
            }

            //Test for string equality

            //Not recommended. Not good practice
            if (text == "demo")
            { }

            //Faster
            if (text.Equals("demo"))
            {

            }

            //Fastest
            if (text.Equals("demo", StringComparison.Ordinal))
            { }

            //Using Stringbuilder is a good practice while working with string

            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                text += i.ToString();
            }

            //using string builder is a good practice and highly recommended
            for (int i = 0; i < 9; i++)
            {
                stringBuilder.Append(i);
            }

            //slow
            for (int i = 0; i < 10000; i++)
            {
                if (text == "1")
                {
                    stringBuilder.Append("one");
                }
                else
                {
                    stringBuilder.Append("Not One");
                }
            }


        }
    }
}
