using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CO2_CORE_DLL.IO;

namespace MType
{
     class Program
     {
          public static void Main(string[] args)
          {
               Console.Title = "magictype.dat dumper/creator";
               Console.WriteLine("Credits go to:\nCptSky for the .dll\nme (Kiyono) for doing this for those that were too lazy to do it.");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("\nThis is for the old magictype that is incompatible with high6's DatCryptor!");
               Console.ResetColor();
               Console.WriteLine("\nChoose one of the following options.");
               Console.WriteLine("Type Dump and press enter to dump the magictype into a text file.\nType Create and press enter to create a magictype.dat from a text file.\nNote: case sensitive.");
               failsafe:
               switch (Console.ReadLine())
               {
                    case "Dump":
                         {
                              MagicType MT = new MagicType();
                              MT.LoadFromDat("magictype.dat");
                              MT.SaveToTxt("magictype.txt");
                              break;
                         }
                    case "Create":
                         {
                              MagicType MT = new MagicType();
                              MT.LoadFromTxt("magictype.txt");
                              MT.SaveToDat("[NEW]_magictype.dat");
                              break;
                         }
                    default:
                         {
                              Console.WriteLine("Not a valid option.");
                              goto failsafe;
                         }
               }
               Console.WriteLine("It is finished.");
               Console.ReadLine();
          }
     }
}
