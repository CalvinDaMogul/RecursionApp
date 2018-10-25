using System;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;

namespace RecursionApp
{
    class Program
    {
        static void Main(string[] args) {
             int[] numbers = new int[6];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16; 
            numbers[4] = 23;
            numbers[5] = 30;

            Console.WriteLine(numbers.GetValue(4));
            Console.ReadLine();

            string[] names = new string[10];

            names[0] = "Kenny";
            names[1] = "Calvin";
            names[2] = "Nicole";
            names[3] = "Lola";
            names[4] = "Trevor";
            names[5] = "Glenn";
            names[6] = "Kazadi";
            names[7] = "Tobias";
            names[8] = "Amber";
            names[9] = "CeeJay";
            names[10] = "Odie";

            Console.WriteLine(names.GetValue(4));
            Console.ReadLine();


        for(int x=1; x<=50;++x) {
        for(int row=10;row >= 5; --row) {
            for (int col=1; col <= row; col++) {
               
                Console.Write("*");
            }
                Console.WriteLine();
        
        }
                for (int row= 6; row <= 10; ++row) {
                    for (int col= 1; col <= row; ++col) {
                        
                        Console.Write("*");   
                    }
                        Console.WriteLine();
                }
        }
        
           
            
            Console.WriteLine("Hello World!");
            Program MyProg=new Program();
            double Amount = MyProg.AskforCoins();

            // Console.Write(Amount);
            MyProg.DisplayCoins(Amount);
        }

        public double AskforCoins() {
                string answer;
                double value;
                Console.WriteLine("How much do you need in coins?");
               answer= Console.ReadLine();
               value=double.Parse(answer);
                return value;
                
        }
        public void DisplayCoins(double totalAmount) {
            double RunSum=0;
            int Q=0;
            int D=0;
            int N=0;
            int P=0;

            
            for(Q=1;Q*0.25<=totalAmount;Q++) {
                RunSum=RunSum+0.25;
            }
            Q--;
             Console.WriteLine("Quarters="+Q);
            totalAmount=totalAmount-RunSum;
            RunSum=0;
            for(D=1;D*0.10<=totalAmount+0.001;D++) {
                RunSum=RunSum+0.10;

            }
            D--;
            Console.WriteLine("Dimes="+D);
            totalAmount=totalAmount-RunSum;
            RunSum=0;
            for(N=1;N*0.05<=totalAmount+0.001;N++) {
                RunSum=RunSum+0.05;
            }
            N--;
            //  Console.WriteLine(totalAmount);
            Console.WriteLine("Nickel="+N);
            totalAmount=totalAmount-RunSum;
            RunSum=0.001;
            // Console.WriteLine(totalAmount);
            for(P=1;P*0.01<=totalAmount+0.001;P++) {
                RunSum=RunSum+0.01;
            }
            P--;
             Console.WriteLine("Penny="+P);
        }        
            
        }
       
    }
