//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------
using System;

/// <summary>
/// Clase que contiene el punto de entrada al programa.
/// </summary>
namespace WordsPhrases
{
    public class Program
    {
        /// <summary>
        /// El punto de entrada al programa.
        /// </summary>
        public static void Main()
        {
            Word hello = new Word("Hello");
            Word world = new Word("World!");
            Phrase greeting = new Phrase();
            greeting.AddWord(hello);
            greeting.AddWord(world);
            Console.WriteLine(greeting.GetPhrase());
        }
    }
}
