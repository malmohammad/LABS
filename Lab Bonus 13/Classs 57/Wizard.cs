using System;
namespace Classs_57
{
    internal class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }
        public Wizard()
        {
            Name = "Wizard";
            Strength = 70;
            Intelligence = 99;
            MagicalEnergy = 85;
            SpellNumber = 90;
        }

        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Magical Energy: {MagicalEnergy}");
            Console.WriteLine($"Spell Number: {SpellNumber}");
        }
    }
}