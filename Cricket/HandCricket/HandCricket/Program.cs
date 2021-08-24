using System;
using System.Text;
namespace HandCricket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int over = 2;
            int total_score = 0, wicket = 0, noball = 0, four_count = 0, six_count = 0, wicket_count = 0, user_batting;

            while (true)
            {
                Console.Write("Odd or Even: ");
                input = Console.ReadLine();

                if(input == "o" || input == "e")
                {
                    System.Random r = new System.Random();
                    int rand = r.Next(0, 5);
                    Console.WriteLine(rand);

                    if(rand % 2 == 0)
                    {
                        Console.WriteLine("You won");
                        Console.Write("Bat or bowl:");
                        string wish = Console.ReadLine();

                        if(wish == "bat")
                        {
                            Console.WriteLine("You choose to bat");
                            Console.WriteLine("Total Over: " + over);
                            Console.WriteLine("First ball: ");

                            
                            for(int i = 0; i <= 1; i++)
                            {
                                for(int j = 0; j <= 5; j++)
                                {
                                    user_batting = int.Parse(Console.ReadLine());
                                    System.Random rnd = new System.Random();
                                    int system_bowl = rnd.Next(0, 7);

                                    if(system_bowl >=6)
                                    {
                                        Console.WriteLine("No Ball..!"); 
                                        total_score = total_score + 1; 
                                        total_score = total_score + user_batting;
                                        if (user_batting == 4)
                                        {                                            
                                            four_count = four_count + 1;
                                        }
                                        else
                                        {
                                            four_count = 0;
                                        }
                                        if (four_count >= 3)
                                        {
                                            Console.WriteLine("Hatrick four..!");
                                        }
                                        if (user_batting == 6)
                                        {
                                            six_count = six_count + 1;
                                        }
                                        else
                                        {
                                            six_count = 0;
                                        }
                                        if (six_count >= 3)
                                        {
                                            Console.WriteLine("Hatrick six..!");
                                        }
                                        j--;
                                    }
                                    

                                    if(user_batting == system_bowl)
                                    {
                                        if(j == 0)
                                        {
                                            Console.WriteLine("Duck Out..!");
                                        }
                                        
                                       
                                        if (user_batting == system_bowl)
                                        {
                                            if(system_bowl <= 6)
                                            {
                                                Console.WriteLine("Wicket..!");
                                                wicket = wicket + 1;
                                                wicket_count = wicket_count + 1;
                                            }
                                        }
                                        
                                        if (wicket_count >= 3)
                                        {
                                            Console.WriteLine("Hatrick Wicket..!");
                                        }
                                       
                                    }
                                    else
                                    {
                                        wicket_count = 0;
                                        total_score = total_score + user_batting;
                                        if (user_batting == 4)
                                        {
                                            Console.WriteLine("Four..!");
                                            four_count = four_count + 1;
                                        }
                                        else
                                        {
                                            four_count = 0;
                                        }
                                        if(four_count >= 3)
                                        {
                                            Console.WriteLine("Hatrick four..!");
                                        }
                                        if (user_batting == 6)
                                        {
                                            Console.WriteLine("Six..!");
                                            six_count = six_count + 1;
                                        }
                                        else
                                        {
                                            six_count = 0;
                                        }
                                        if (six_count >= 3)
                                        {
                                            Console.WriteLine("Hatrick six..!");
                                        }
                                    }

                                    
                                
                                }
                                int o = i + 1;
                                Console.WriteLine("Over: " + o + " - Total Score: " + total_score + " - Wicket: " + wicket);
                                
                            }
                            Console.WriteLine("1st Innings over..!");
                        }
                        else
                        {
                            Console.WriteLine("You choose to bowl");
                        }
                    }
                    else
                    {
                        Console.WriteLine("System won");
                    }
                }
                break;
                
                
            }    
        }
    }
}
