using NLua;
using System;

namespace NLua_Compiler
{
    internal class Program
    {
        private static readonly Lua State = new Lua();
        private static int Line;
        private static void Read()
        {
            Line = 1;
            Console.WriteLine("Lua 5.4.4  Copyright (C) 1994-2022 Lua.org, PUC-Rio");
            while (true)
            {
                Console.WriteLine("> ");
                Console.SetCursorPosition(2, Line);
                Line++;
                string Input = Console.ReadLine();

                if (Input == "Exit()") { Environment.Exit(0); }
                else if (Input == "Clear()") { Console.Clear(); Read(); }
                else { try { State.DoString(Input); Line++; } catch (Exception Excpt) { Console.WriteLine(Excpt); Line++; } }
            }
        }

        private static void Main()
        {
            State.LoadCLRPackage();
            Read();
        }
    }
}
