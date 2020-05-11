using System;
namespace Classs_57
{
    internal class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }
        public MagicUsingCharacter()
        {
            Name = "MagicUsingCharacter";
            Strength = 40;
            Intelligence = 25;
            MagicalEnergy = 75;
        }

        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
        }
    }
}