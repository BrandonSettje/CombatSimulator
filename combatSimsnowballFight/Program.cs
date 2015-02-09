using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combatSimsnowballFight
{
    class Program
    {
        static Random rng = new Random(DateTime.Now.Millisecond);
        static string pName = string.Empty;
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("          Please enter your name: ");
            pName = Console.ReadLine();
            Console.Clear();

            DisplaySnowballTitle(true);
            Console.WriteLine();
            Console.WriteLine("Press a key to continue."); Console.ReadKey();
            Console.Clear();
            DisplaySnowballTitle(false);
            Console.WriteLine();
            Console.WriteLine();
            string pNameOut = (@"You pull up to your house one snowy evening. The brisk temperature creeps 
through your clothing. As the steam rolls out of your mouth, a larger 
than life kind of kid across the street, slings a fast-ball style 
snowball towards your head....");
            //Types each letter out in oldtimeytypewriterfashion
            for (int i = 0; i < pNameOut.Length; i++)
            {

                Console.Write(pNameOut[i].ToString());
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("\nPress a key to continue."); Console.ReadKey();
            Console.Clear();
            string ruleS = (@"You've hidden behind a tree in your front yard. With the recent snowfall, 
the two feet deep snow around you is more than enough to craft 
as many snowballs as you need. 
You reach into your inner pocket and find hotpads that your mate 
had left in there before you went to work in the morning. You 
feverishly start rolling snowballs and preparing your hotpacks 
when, suddenly the urge to pee rises through you. An idea pops 
into your head...");

            Console.WriteLine(ruleS);
            Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"Yellow snowballs will hit him no matter what due to splash 
damage, but will only hit him for 10-15 HP");
            Console.ResetColor();
            Console.WriteLine(@"Regular snowballs hit around 70% of the time, but hit HP 
for 20 - 35");
            Console.WriteLine(@"Hotpacks will warm you back up, healing you for 
10 - 20 HP");
            Console.ReadKey();
            Console.Clear();

            snowFightSim();
        }
        /// <summary>
        /// Title screen
        /// </summary>
        /// <param name="doSleep">activates title</param>
        private static void DisplaySnowballTitle(bool doSleep)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("           Welcome " + pName + "\n                                    to           ");
            if (doSleep) { System.Threading.Thread.Sleep(2000); }
            Console.WriteLine(@" (                                             (                            
 )\ )                      (         (   (     )\ )                )     )  
(()/(             (  (   ( )\     )  )\  )\   (()/(  (   (  (   ( /(  ( /(  
 /(_)) (      (   )\))(  )((_) ( /( ((_)((_)   /(_)) )\  )\))(  )\()) )\()) 
(_))   )\ )   )\ ((_)()\((_)_  )(_)) _   _    (_))_|((_)((_))\ ((_)\ (_))/  
/ __| _(_/(  ((_)_(()((_)| _ )((_)_ | | | |   | |_   (_) (()(_)| |(_)| |_   
\__ \| ' \))/ _ \\ V  V /| _ \/ _` || | | |   | __|  | |/ _` | | ' \ |  _|  
|___/|_||_| \___/ \_/\_/ |___/\__,_||_| |_|   |_|    |_|\__, | |_||_| \__|  
                                                        |___/               ");
            Console.ResetColor();
        }
        /// <summary>
        /// THe game of snowball fight!
        /// </summary>
        static void snowFightSim()
        {
            //declare variables for the game
            int playerHP = 100;
            int enemyHP = 200;
            // combat continues until one player is dead
            while (playerHP > 0 && enemyHP > 0)
            {
                //display round info
                Console.WriteLine(pName + " HP: " + playerHP);
                Console.WriteLine();
                Console.WriteLine("Kid HP: " + enemyHP);
                Console.WriteLine();

                //let user inpout attack
                string attackChoice = UserAttackChoice();
                //if user wants a reg snowball
                if (attackChoice == "1")
                {
                    // 70% chance to hit, 20-35 damage
                    if (rng.Next(1, 101) > 30)
                    {
                        //calculate and image of hit
                        int damage = rng.Next(20, 36);
                        Console.Clear();
                        Console.WriteLine(@"
(~)
");
                        System.Threading.Thread.Sleep(200);

                        Console.Clear();
                        Console.WriteLine(@"
       (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@" 
              (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                    (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                            (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                                    (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                                          (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                                                (~)      ( )
                                                         -|-
                                                         ] [
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"                                                        **
                                                      ***( )~oow!
                                                        *-|-
                                                         ] [
");
                        System.Threading.Thread.Sleep(1500);
                        Console.Clear();
                        Console.WriteLine("You hit the kid with a snowball for " + damage + " damage!");
                        enemyHP -= damage;
                    }
                    //if its a miss, hit the fort
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(@"
(~)
");
                        System.Threading.Thread.Sleep(200);

                        Console.Clear();
                        Console.WriteLine(@"
       (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@" 
              (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                    (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                            (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                                    (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                                          (~)
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"
                                                 (~)     (fort)
                                                        (  {}  )
");
                        System.Threading.Thread.Sleep(200);
                        Console.Clear();
                        Console.WriteLine(@"                                                    **
                                                       **(fort)
                                                       *(  {}  )
");
                        System.Threading.Thread.Sleep(1200);
                        Console.Clear();
                        Console.WriteLine("The snow ball zips past the kid and smashes against their fort.");
                    }
                }
                //if user wants to use yellow snowball
                else if (attackChoice == "2")
                {
                    int damage = rng.Next(10, 16);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine(@"
(~)
");
                    System.Threading.Thread.Sleep(200);

                    Console.Clear();
                    Console.WriteLine(@"
       (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@" 
              (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                    (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                            (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                                    (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                                          (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                                                (~)      ( )
                                                         -|-
                                                         ] [
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"                                                           **
                                                      ***( )~eeeeew!
                                                        *-|-
                                                         ] [
");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine(@"You scoop some yellow snow and throw the slush ball at the kid. 
The splash from the snowball exploding on contact has 
hit the kid for " + damage + " damage.");
                    Console.ResetColor();
                    enemyHP -= damage;
                }
                //user wants to heal
                else if (attackChoice == "3")
                {
                    int heal = rng.Next(10, 21);
                    Console.WriteLine(@"You reach into your pocket and kind a Hotpack. Activating it, 
you shove it into your glove. Your hands feel less numb, you heal for  " + heal);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"  
                       \ | /
                      -- * --
                       / | \

        /')    ./') ~        ~  ('\.    ('\
      /' /.--''./'')  ~    ~   (''\.''--.\ '\
 :--''  ;    ''./'') ~      ~  (''\.''    ;  ''--:
 :     '     ''./')  ~       ~  ('\.''     '     :
 :           ''./'    ~       ~  '\.''           :
 :--''-..--''''                     ''''--..-''--:
");
                    System.Threading.Thread.Sleep(700);
                    playerHP += heal;
                    Console.ResetColor();
                }
                Console.WriteLine("The kid is winding up!");
                Console.WriteLine();
                Console.WriteLine("Press a key to continue!"); Console.ReadKey();
                //kids' chance to hit
                if (rng.Next(1, 101) > 20)
                {
                    //if he hits with pictures
                    int damage = rng.Next(5, 16);
                    Console.Clear();
                    Console.WriteLine(@"
                                                                          (~)
");
                    System.Threading.Thread.Sleep(200);

                    Console.Clear();
                    Console.WriteLine(@"
                                                              (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@" 
                                                    (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                                        (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                               (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
                      (~)
");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                    Console.WriteLine(@"
               **
           (x x)** 
              **
");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("The kid slings a snowball into your face. You take " + damage);
                    playerHP -= damage;
                }
                else
                {
                    //if he misses
                    Console.WriteLine("The kid hit the tree in front of you!");
                    Console.WriteLine();
                }
            }


            if (playerHP > 0)
            {
                //if the player won the game
                Console.WriteLine(@"You peer around the tree, to find the kids fort and area covered in yellow. 
The kid runs away crying for his mom. You go home feeling smug that you beat
a kid at a snowball fight...");
                Console.ReadKey();
            }
            else
            {
                //if player lost game
                Console.WriteLine("The kid beat you. Even with your nasty secret weapon. Maybe you should go home and rethink your life.");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// retrieve player attack choice and checks validation
        /// </summary>
        /// <returns>the appropiate attack choice</returns>
        static string UserAttackChoice()
        {
            int UserAttkchoice = 0;
            Console.WriteLine("Choose your attack: ");
            Console.WriteLine("1. Snowball");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2. Yellow Snowball");
            Console.ResetColor();
            Console.WriteLine("3. Apply a Hotpack.");
            Console.WriteLine();
            string input;
            input = Console.ReadLine();
            int.TryParse(input, out UserAttkchoice);

            if (UserAttkchoice == 1 || UserAttkchoice == 2 || UserAttkchoice == 3)
            {
                return input;
            }
            else
            {
                Console.WriteLine("You lost your turn! Please pick a number 1 thru 3");
                return "please pick a number 1 thru 3";
            }
        }
    }
}
