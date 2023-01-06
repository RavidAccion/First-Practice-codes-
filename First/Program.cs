using First;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

    /*class Program
    {
        static void Main()
        {*/
        ///sum 

        /*int[] arr = new int[] { 1, 2, 3 };
        int sum = arr.Sum(); ;

        Console.WriteLine(sum);*/


        ///if else
        /*Console.WriteLine("Enter An Number");
        int RollNumber = int.Parse(Console.ReadLine());
        if (RollNumber == 25)
        {
            Console.WriteLine("Ravids Roll Number Is 25");
        }

        else  
        {
            Console.WriteLine("Its not his Roll Number");
        }*/


        ///Switch
        /*Console.WriteLine("Enter An Number");
        int RollNumber = int.Parse(Console.ReadLine());
        switch (RollNumber)
        {
            case 25:
                Console.WriteLine("its correct Number");
                break;
            case 15:
                Console.WriteLine("its Not a correct Number");
                break;
            default:
                Console.WriteLine("its Not a correct Number");
                break;
        }*/




        ///tried string and array


        /*string name = "RAVID";
        var replacement = name.Replace("RAVID", "RIO");
        Console.WriteLine($"The source string is {name}");
        Console.WriteLine($"The updated string is {replacement}");

        Console.WriteLine(name);
        

        int[] myNum = { 10, 20, 30, 40 };
        myNum[2] = 55;
        for (int i = 0; i < myNum.Length; i++)
        {
            Console.WriteLine(myNum[i]);
        }*/


        ///using StringBuilder

        /*StringBuilder sb = new StringBuilder("Hello ");

        sb.Append("World!!");
        sb.Append("Hello C#!");
        sb.Append("This is new line.");

        Console.WriteLine(sb);
        string s = "Hello All";
        string sa=s.Substring(0, 2);
        Console.WriteLine(sa);*/



        ///Try Catch
        /* try
         {
             Console.WriteLine("Enter An Number");
             int Firstnum = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Another Number To Divide");
             int Secondnum = int.Parse(Console.ReadLine());
             int Result = Firstnum / Secondnum;
             Console.WriteLine(Result);
         }
 catch(Exception ex)
         {
             Console.WriteLine(ex.Message);
         }
         finally {
             Console.WriteLine("This Is The Result");
             Console.ReadLine(); }*/



        ///Assign

       /* int[] arr = { 10, 11, 12 };

        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {

           
            for (int j = i; j < arr.Length; j += 2)
            {
                
                for (int k = i; k <= j; k++)
                {
                    *//*Console.WriteLine(k);*//*

                    sum += arr[k];
                }
            }
        }
        Console.WriteLine(sum);*/


        /*int[,] accounts = new[,] { { 1, 2, 3 }, { 3, 2, 1 } };
        int n = accounts.GetLength(1);
        int wealth = 0;
        int m = accounts.GetLength(0);
        int MaxWealth = 0;
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < m; j++)
            {

                wealth += accounts[i][j];
            }
            MaxWealth = Math.Max(MaxWealth, wealth);
        }

        Console.WriteLine(MaxWealth);*/
 /*   }
 

}*/

///OOPS
 class program
{
    string Company = "Skoda";
    string Name = "Kushaq";
    string color = "White";
    string Model = "2022";
    string Condition = "Good";

    static void Main(string[] args)
    {
        firstclass items = new firstclass();

        items.One();
        items.Two(3, 27);
            }

}

