using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAionProject
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static partial class UniverseObjects
    {
        public static List<GameObject> GameObjects = new List<GameObject>()
        {
            new TravelerObject
            {
                Id = 1,
                Name = "Bag of Gold",
                SpaceTimeLocationId = 2,
                Description = "A small leather pouch filled with 9 gold coins.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 2,
                Name = "Ruby of Saron",
                SpaceTimeLocationId = 3,
                Description = "A bright red jewel, roughly the size of a robin's egg.",
                Type = TravelerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 3,
                Name = "Rotogenic Medicine",
                SpaceTimeLocationId = 1,
                Description = "A wooden box containing a small vial filled with a blue liquid.",
                PickUpMessage = "You drink the blue liquid down, feel a tingle in your chest with added health.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 7,
                Name = "Thor Medicine",
                SpaceTimeLocationId = 1,
                Description = "Found in the heart of a hammer.",
                PickUpMessage = "You drink the orange liquid down, feel the thunder of Thor within your being and adds health.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 10,
                Name = "Bzore Stone",
                SpaceTimeLocationId = 1,
                Description = "This is a black colored stone that helps with poison.",
                PickUpMessage = "You eat this stone and will be cured of any poison.",
                Type = TravelerObjectType.Medicine,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 12,
                Name = "Murphy's Poison",
                SpaceTimeLocationId = 1,
                Description = "This is a mysterious potion. Properties are unknown.",
                PickUpMessage = "This is poisonous. You lose a life.",
                Type = TravelerObjectType.Medicine,
                Value = -1,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                IsDeadly = true,
            },

            new TravelerObject
            {
                Id = 11,
                Name = "Trickster's Paradise",
                SpaceTimeLocationId = 2,
                Description = "This is a leafy plant that looks evergreen and yummy.",
                PickUpMessage = "If this is eaten you will lose a life. You were warned.",
                Type = TravelerObjectType.Medicine,
                Value = -30,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true,
                IsDeadly = true
            },

            new TravelerObject
            {
                Id = 4,
                Name = "Norlan Document ND-3075",
                SpaceTimeLocationId = 3,
                Description =
                    "Memo: Origin Errata" + "/n" +
                    "Universal Date: 378598" + "/n" +
                    "/n" +
                    "It appears a potential origin for the technology is based on Plenatia 5 in the Star Reach Galaxy.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 8,
                Name = "Aion Tracker",
                SpaceTimeLocationId = 0,
                Description =
                    "Standard issue device worn around wrist that allows for tracking and messaging.",
                Type = TravelerObjectType.Information,
                Value = 0,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new TravelerObject
            {
                Id = 9,
                Name = "RatPak 47",
                SpaceTimeLocationId = 0,
                Description =
                    "Standard issue ration package contain nutrients for 72 hours.",
                Type = TravelerObjectType.Food,
                Value = 0,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new SpaceTimeLocationObject
            {
                Id = 5,
                Name = "Boldendorian Chest",
                SpaceTimeLocationId = 2,
                Description = "A large wooden chest adorned with jewels.",
                IsDeadly = true
            },

            new SpaceTimeLocationObject
            {
                Id = 6,
                Name = "Silver Mirror",
                SpaceTimeLocationId = 2,
                Description = "A small silver mirror hanging on the wall next to a small window.",
                IsDeadly = true
            }
        };
    }
}
