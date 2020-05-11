using System;

namespace Classs_57
{
    internal class Warrior : GameCharacter
    {
        public string WeaponType{get; set;}
        public Warrior(string weaponType)
        {
            Name = "Warrior";
            Strength = 100;
            Intelligence = 45;
            WeaponType= weaponType;
        }
        public override void Play()
        {
            Console.WriteLine($"Character: {Name}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"WeaponType:{WeaponType}");
        }
    }
}