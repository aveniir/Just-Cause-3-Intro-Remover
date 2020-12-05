using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Just_Cause_3_Intro_Remover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path of your Just Cause 3 installation directory. (Where the .exe is located.)");
            Console.WriteLine("e.g. E:\\Steam\\steamapps\\common\\Just Cause 3");
            Console.Write("\nPath: ");
            string gamePath = Console.ReadLine();
            string modPath = "\\dropzone\\videos";
            string gameFile = "\\JustCause3.exe";
            string videoFile = "\\corona_video.bikc";

            if (Directory.Exists(gamePath))
            {
                Console.Write("Valid Path || ");
                if (File.Exists(gamePath + gameFile))
                {
                    Console.Write(".exe found! || ");
                    Directory.CreateDirectory(gamePath + modPath);
                    if (Directory.Exists(gamePath + modPath))
                    {
                        using (FileStream fs = File.Create(gamePath + modPath + videoFile))
                            Console.Write("Created required folder and file.\n");
                        postMenu();
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong. Try starting with admin privileges.");
                        exitMenu();
                    }
                }
                else
                {
                    Console.WriteLine(".exe not found.\n");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Not a Valid Path.\n");
                Main(null);
            }
        }
        static void postMenu()
        {
            Console.Clear();
            Console.WriteLine("-Patched successfully!-\n");
            Console.WriteLine("You can now continue with step 5 in the guide.");
            Console.WriteLine("If you've lost the link: https://steamcommunity.com/sharedfiles/filedetails/?id=570542665");
            exitMenu();
        }
        static void exitMenu()
        {
            Console.WriteLine("\nPress any Key to exit.");
            Console.ReadLine();
        }
    }
}