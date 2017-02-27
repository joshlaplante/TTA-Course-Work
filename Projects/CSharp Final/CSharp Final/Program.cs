using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // here the database context is instantiated

            using (var db = new SmashBrosContext())
            {
                // then the method that returns the dictionary with character data is called

                var dict = CharacterAttacksData.AddCharacterAttacks();

                // this foreach loop will cycle through the dictionary, taking the Character classes from the keys and adding them to the Characters table,
                // and taking the Attacks classes from the values and adding them to the Attacks table.

                foreach(var pair in dict)
                {
                    db.Characters.Add(pair.Key);
                    db.Attacks.Add(pair.Value);
                }

                // then make sure to save these pending database changes

                db.SaveChanges();
                
                // next the user gets some info on what this app actually does

                Console.WriteLine("The following characters are playable in Super Smash Bros. for N64.");
                Console.WriteLine();

                // here is a LINQ query that will pull all the rows from the Characters table

                var ShowCharacters = from characters in db.Characters
                            orderby characters.CharacterID
                            select characters;

                // then this foreach loop will print the data in the Name column of the table to the console

                foreach(var character in ShowCharacters)
                {
                    Console.WriteLine(character.Name);
                }

                // the Loop boolean will be set to true, and used below in a while clause to keep the app running until the user wants to quit

                bool Loop = true;

                // this List contains the names of all the characters and will be used below to make sure a user enters a valid character name in the console

                List<string> NameList = new List<string> {"Luigi", "Mario", "DK", "Link", "Samus", "Captain Falcon", "Ness", "Yoshi", "Kirby", "Fox", "Pikchu", "Jigglypuff" };
                

                while (Loop == true)
                {
                    // at the start of each cycle of the loop, the user is prompted as follows

                    Console.WriteLine();
                    Console.WriteLine("To view a character's special moves, type their name and press enter.");
                    Console.WriteLine("To exit, type 'Quit' and press enter.");
                    Console.WriteLine();

                    // then the user's typed selection is grabbed and stored to a variable

                    var name = Console.ReadLine();

                    // here the NameList from above is used to check that the user typed an actual character's name

                    if (NameList.Contains(name))
                    {
                        // if the name is valid, this LINQ query will run and use the Character ID corresponding to the character name entered to pull from
                        // the Attacks table the columns that list all the character's attacks

                        var ShowMoves = from characters in db.Characters
                                        join attacks in db.Attacks on characters.CharacterID equals attacks.CharacterID
                                        where name == characters.Name
                                        select new { attacks.UpB, attacks.NeutralB, attacks.DownB };

                        Console.WriteLine();
                        Console.WriteLine("{0} has the following special moves: ", name);

                        // then this foreach loop will print the result of the LINQ query to the console

                        foreach (var move in ShowMoves)
                        {
                            Console.WriteLine(move);
                        }
                    }

                    // instead, if the user types Quit, then the Loop boolean is set to false and the program ends

                    else if (name == "Quit")
                    {
                        Loop = false;
                    }

                    // or if the name entered by the user isn't an actual character name, the user is alerted and the loop starts over

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That name doesn't correspond to a playable character, try again!");
                    }
                    
                }
                
            }


            //Wait for user to acknowledge result
            Console.WriteLine();
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
                
        }
    }

    // this class will consitute the first table within the database, and its properties will become table columns

    public class Character
    {
        // the key tag denotes that the following property will be the primary key for the table
        [Key]
        public int CharacterID { get; set; }
        public string Name { get; set; }
        
        public virtual Attacks Attacks { get; set; }

    }

    // this class will be the second table within the database, and its properties will be table columns as well

    public class Attacks
    {
        public string UpB {get; set;}
        public string NeutralB { get; set; }
        public string DownB { get; set; }
       
        // this property will be both the primary key for this table and a foreign key that links to the CharacterID column in the Characters table

        [Key, ForeignKey("Character")]
        public int CharacterID { get; set; }
        public virtual Character Character { get; set; }

    }

    // this class inherits from DbContext and creates a context for the above defined classes with the DbSet type

    public class SmashBrosContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Attacks> Attacks { get; set; }
    }

    // this class is what populates the Characters and Attacks tables with data

    public class CharacterAttacksData
    {
        // this method will return a dictionary full of characters as keys, and their attack lists as values

        public static Dictionary<Character,Attacks> AddCharacterAttacks()
        {
            // first a Character class instance is created for each character, and an Attacks class instance for their attacks list 

            Character Luigi = new Character { Name = "Luigi", CharacterID = 1 };
            Attacks LuigiAttacks = new Attacks { UpB = "Fire Uppercut", NeutralB = "Green Fireball", DownB = "Tornado Spin", CharacterID = 1 };

            Character Mario = new Character { Name = "Mario", CharacterID = 2 };
            Attacks MarioAttacks = new Attacks { UpB = "Coin Uppercut", NeutralB = "Fireball", DownB = "Tornado Spin", CharacterID = 2 };

            Character DK = new Character { Name = "DK", CharacterID = 3 };
            Attacks DKAttacks = new Attacks { UpB = "Spinning Kong", NeutralB = "Giant Punch", DownB = "Ground Slap", CharacterID = 3 };

            Character Link = new Character { Name = "Link", CharacterID = 4 };
            Attacks LinkAttacks = new Attacks { UpB = "Spinning Slash", NeutralB = "Boomerang", DownB = "Bomb", CharacterID = 4 };

            Character Samus = new Character { Name = "Samus", CharacterID = 5 };
            Attacks SamusAttacks = new Attacks { UpB = "Screw Attack", NeutralB = "Charge Shot", DownB = "Bomb Drop", CharacterID = 5 };

            Character CaptainFalcon = new Character { Name = "Captain Falcon", CharacterID = 6 };
            Attacks CaptainFalconAttacks = new Attacks { UpB = "Falcon Dive", NeutralB = "Falcon Punch", DownB = "Falcon Kick", CharacterID = 6 };

            Character Ness = new Character { Name = "Ness", CharacterID = 7 };
            Attacks NessAttacks = new Attacks { UpB = "PK Thunder", NeutralB = "PK Fire", DownB = "PSI Magnet", CharacterID = 7};

            Character Yoshi = new Character { Name = "Yoshi", CharacterID = 8 };
            Attacks YoshiAttacks = new Attacks { UpB = "Egg Throw", NeutralB = "Lay Egg", DownB = "Ground Pound", CharacterID = 8 };

            Character Kirby = new Character { Name = "Kirby", CharacterID = 9 };
            Attacks KirbyAttacks = new Attacks { UpB = "Final Cutter", NeutralB = "Inhale", DownB = "Stone", CharacterID = 9 };

            Character Fox = new Character { Name = "Fox", CharacterID = 10 };
            Attacks FoxAttacks = new Attacks { UpB = "Fire Fox", NeutralB = "Laser Beam", DownB = "Shine Shield", CharacterID = 10 };

            Character Pikachu = new Character { Name = "Pikachu", CharacterID = 11 };
            Attacks PikachuAttacks = new Attacks { UpB = "Quick Attack", NeutralB = "Thunder Jolt", DownB = "Thunder Spike", CharacterID = 11 };

            Character Jigglypuff = new Character { Name = "Jigglypuff", CharacterID = 12 };
            Attacks JigglypuffAttacks = new Attacks { UpB = "Sing", NeutralB = "Pound", DownB = "Rest", CharacterID = 12 };

            // then a dictionary is created with those Character instances and Attacks instances

            Dictionary<Character,Attacks > CharacterDict = new Dictionary<Character, Attacks>
            {
                {Luigi, LuigiAttacks },
                {Mario, MarioAttacks },
                {DK, DKAttacks },
                {Link, LinkAttacks },
                {Samus, SamusAttacks },
                {CaptainFalcon, CaptainFalconAttacks },
                {Ness, NessAttacks },
                {Yoshi, YoshiAttacks },
                {Kirby, KirbyAttacks },
                {Fox, FoxAttacks },
                {Pikachu, PikachuAttacks },
                {Jigglypuff, JigglypuffAttacks }
            };

            // and then that dictionary is returned

            return CharacterDict;
        }
        
    }
}
