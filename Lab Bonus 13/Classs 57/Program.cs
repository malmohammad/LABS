using System;

namespace Classs_57
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameCharacter = new GameCharacter[5];
            gameCharacter[0] = new Warrior("sword");
            gameCharacter[1] = new Warrior("ax");
            gameCharacter[2] = new Wizard();
            gameCharacter[3] = new Wizard();
            gameCharacter[4] = new Wizard();

            foreach (var character in gameCharacter)
            {
                character.Play();
                Console.WriteLine();
            }

        }
    }
}
