using System;

namespace RecursionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row=10; row >= 6; --row) {
                
                for (int col = 1; col <= row;++col) {
                   
                    for (int rowB=7; rowB <= 10; ++rowB) {
                        
                        for (int colB=1; colB <= rowB;++colB ) {
                           
                            Console.Write("*");
                        }
                    }
                }
        
                   Console.WriteLine(); 
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
