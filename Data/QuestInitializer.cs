//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using System.Web;
//using QuestsSystem.Models;
//namespace QuestsSystem.Data
//{
//    public class QuestInitializer : DropCreateDatabaseIfModelChanges<QuestContext>
//    {
//        protected override void Seed (QuestContext context)
//        {
//            var quests = new List<Quest>
//            {
//                new Quest {Name="Wolf Destroyer", Description="Kill 10 wolves",Level=1, Rarity=Rarity.common, IsChainQuest=false},
//                new Quest {Name="Sheep Destroyer", Description="Kill 10 sheeps",Level=1, Rarity=Rarity.common, IsChainQuest=false, Location=Locations.forest},
//                new Quest {Name="Sheep Desacration", Description="Kill 666 white sheeps",Level=1, Rarity=Rarity.rare, IsChainQuest=true, Location=Locations.farm},
//                new Quest {Name="Sheep Destroyer", Description="Stop the Sheepocalypse",Level=1, Rarity=Rarity.common, IsChainQuest=false, Location=Locations.ruins}
//            };
//            quests.ForEach(q => context.Quest.Add(q));

//        }
//    }
//}
