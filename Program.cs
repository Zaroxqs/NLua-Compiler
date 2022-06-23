using NLua;
using System;

namespace NLua_Compiler
{
    internal class Program
    {
        private static readonly Lua State = new Lua();
        private static void Read()
        {
            Console.WriteLine("Lua 5.4.4  Copyright (C) 1994-2022 Lua.org, PUC-Rio\n");
            while (true)
            {
                string Input = Console.ReadLine();

                if (Input == "Exit()") { Environment.Exit(0); }
                else if (Input == "Clear()") { Console.Clear(); Read(); }
                else { try { State.DoString(Input); } catch (Exception Excpt) { Console.WriteLine(Excpt); } }
            }
        }

        private static void Main()
        {
            State.LoadCLRPackage();
            Read();
        }
    }
}
