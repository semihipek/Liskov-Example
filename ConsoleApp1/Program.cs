
using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Player newPlayer1 = new Player
            {
                name = "Ümit",
                position = "Striker",


            };
            BasketballPlayer newPlayer = new BasketballPlayer
            {
            name = "Michael Jordan",
            position = "Shooting Guard",
            team = "Chicago Bulls"
        };

            

            Console.WriteLine($"\nPlayer Name :{newPlayer1.name}\nPosition:{newPlayer1.position}\n");

            Console.WriteLine($"Basketball Player Name   :{newPlayer.name}\nPosition:{newPlayer.position}\nTeam:{newPlayer.team} ");
        } 
    }
}