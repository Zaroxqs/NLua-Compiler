using NLua;
using System;

namespace NLua_Compiler
{
    internal static class Program
    {
        private static readonly Lua State = new Lua();
        private static void Read()
        {
            Console.WriteLine("Lua 5.4.4  Copyright (C) 1994-2022 Lua.org, PUC-Rio\n");
            while (true)
            {
                string Input = Console.ReadLine();

                if (Input == "Clear()") { Console.Clear(); break; }
                else { try { State.DoString(Input); } catch (Exception Excpt) { Console.WriteLine(Excpt); } }
            }
        }

        private static void Main()
        {
            State.LoadCLRPackage();
            while (true) { Read(); }
        }
    }
}
