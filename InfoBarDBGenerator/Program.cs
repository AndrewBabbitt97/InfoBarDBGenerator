using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using InfoBarDBGenerator.Darkstar.Data;
using InfoBarDBGenerator.InfoBar.Data;
using InfoBarDBGenerator.InfoBar.Models;

namespace InfoBarDBGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var darkstar = new DarkstarContext();
            var infobar = new InfoBarContext();
            infobar.Database.EnsureDeleted();
            infobar.Database.EnsureCreated();

            int current = 0;
            int maximum = darkstar.MobGroups.Count();

            foreach (var group in darkstar.MobGroups)
            {
                current++;
                Console.Write("\rLoading Monsters... " + "(" + current + "/" + maximum + ")");

                var monster = new Monster();

                var pool = darkstar.MobPools.Where(p => p.Poolid == group.Poolid).FirstOrDefault();

                if (pool == null)
                    continue;

                var spawnpoint = darkstar.MobSpawnPoints.Where(m => m.Groupid == group.Groupid).FirstOrDefault();

                if (spawnpoint == null)
                    continue;

                monster.Name = spawnpoint.PolutilsName.Replace("_", " ");

                var zone = darkstar.ZoneSettings.Where(z => z.Zoneid == group.Zoneid).FirstOrDefault();

                if (zone == null)
                    continue;

                monster.Zone = FixZoneName(zone.Name);

                var family = darkstar.MobFamilySystem.Where(f => f.Familyid == pool.Familyid).FirstOrDefault();

                if (family == null)
                    continue;

                monster.Family = FixFamilyName(family.Family);

                monster.Job = ((JobTypes)pool.MJob).ToString();

                if ((JobTypes)pool.SJob != JobTypes.NON &&
                    pool.SJob != pool.MJob)
                    monster.Job += "/" + ((JobTypes)pool.SJob).ToString();

                monster.IsAggressive = pool.Aggro == 1 ? true : false;

                monster.IsLinking = pool.Links == 1 ? true : false;

                if (((MobTypes)pool.MobType).HasFlag(MobTypes.Notorious))
                    monster.IsNm = true;

                if (((MobTypes)pool.MobType).HasFlag(MobTypes.Fished))
                    monster.IsFishing = true;

                monster.LevelMin = group.MinLevel;

                monster.LevelMax = group.MaxLevel;

                if (((Detects)family.Detects).HasFlag(Detects.Sight))
                    monster.DetectsSight = true;

                if (((Detects)family.Detects).HasFlag(Detects.Hearing))
                    monster.DetectsSound = true;

                if (((Detects)family.Detects).HasFlag(Detects.Magic))
                    monster.DetectsMagic = true;

                if (((Detects)family.Detects).HasFlag(Detects.LowHp))
                    monster.DetectsLowhp = true;

                monster.DetectsHealing = pool.Aggro == 1 ? true : false;

                monster.DetectsTruesight = pool.TrueDetection == 1 ? true : false;

                monster.DetectsTruesound = pool.TrueDetection == 1 ? true : false;

                if (((Detects)family.Detects).HasFlag(Detects.Scent))
                    monster.TracksScent = true;

                List<string> weaknesses = new List<string>();

                if (family.Slash > 1)
                    weaknesses.Add("Slashing");

                if (family.Pierce > 1)
                    weaknesses.Add("Piercing");

                if (family.H2h > 1)
                    weaknesses.Add("Blunt");

                if (family.Fire > 1)
                    weaknesses.Add("Fire");

                if (family.Ice > 1)
                    weaknesses.Add("Ice");

                if (family.Wind > 1)
                    weaknesses.Add("Wind");

                if (family.Earth > 1)
                    weaknesses.Add("Earth");

                if (family.Lightning > 1)
                    weaknesses.Add("Lightning");

                if (family.Water > 1)
                    weaknesses.Add("Water");

                if (family.Light > 1)
                    weaknesses.Add("Light");

                if (family.Dark > 1)
                    weaknesses.Add("Dark");

                monster.Weaknesses = string.Join(", ", weaknesses);

                List<string> resistances = new List<string>();

                if (family.Slash < 1)
                    resistances.Add("Slashing");

                if (family.Pierce < 1)
                    resistances.Add("Piercing");

                if (family.H2h < 1)
                    resistances.Add("Blunt");

                if (family.Fire < 1)
                    resistances.Add("Fire");

                if (family.Ice < 1)
                    resistances.Add("Ice");

                if (family.Wind < 1)
                    resistances.Add("Wind");

                if (family.Earth < 1)
                    resistances.Add("Earth");

                if (family.Lightning < 1)
                    resistances.Add("Lightning");

                if (family.Water < 1)
                    resistances.Add("Water");

                if (family.Light < 1)
                    resistances.Add("Light");

                if (family.Dark < 1)
                    resistances.Add("Dark");

                monster.Resistances = string.Join(", ", resistances);

                List<string> immunities = new List<string>();

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Sleep))
                    immunities.Add("Sleep");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Gravity))
                    immunities.Add("Gravity");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Bind))
                    immunities.Add("Bind");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Stun))
                    immunities.Add("Stun");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Silcence))
                    immunities.Add("Silence");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Paralize))
                    immunities.Add("Paralize");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Blind))
                    immunities.Add("Blind");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Slow))
                    immunities.Add("Slow");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Poison))
                    immunities.Add("Poison");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Elegy))
                    immunities.Add("Elegy");

                if (((Immunity)pool.Immunity).HasFlag(Immunity.Requiem))
                    immunities.Add("Requiem");

                monster.Immunities = string.Join(", ", immunities);

                var droplist = darkstar.MobDroplist.Where(d => d.DropId == group.Dropid && (DropType)d.DropType == DropType.Normal).ToList();

                monster.Drops = string.Join(", ", darkstar.ItemBasic.Where(i => droplist.Any(s => s.ItemId == i.Itemid)).Select(i => FixItemName(i.Sortname)).ToList());

                var steallist = darkstar.MobDroplist.Where(d => d.DropId == group.Dropid && (DropType)d.DropType == DropType.Steal).ToList();

                monster.Stolen = string.Join(", ", darkstar.ItemBasic.Where(i => steallist.Any(s => s.ItemId == i.Itemid)).Select(i => FixItemName(i.Sortname)).ToList());

                monster.SpawnCount = darkstar.MobSpawnPoints.Where(m => m.Groupid == group.Groupid).Count();

                var spawntime = TimeSpan.FromSeconds(group.Respawntime);

                if (spawntime.Minutes < 60)
                {
                    monster.SpawnTime = spawntime.Minutes + " minutes";
                }
                else if (spawntime.Hours >= 1 && spawntime.Hours < 24)
                {
                    monster.SpawnTime = spawntime.Hours + " hours";
                }
                else
                {
                    monster.SpawnTime = spawntime.Days + " days";
                }

                infobar.Monsters.Add(monster);
            }

            infobar.SaveChanges();
        }

        private static string FixZoneName(string name)
        {
            var temp = name.Replace("_", " ")
                .Replace("Abyssea-", "Abyssea - ")
                .Replace("VeLugannon", "Ve'Lugannon")
                .Replace("Delkfutts", "Delkfutt's")
                .Replace("RuAvitau", "Ru'Avitau")
                .Replace("ZiTah", "Zi'Tah")
                .Replace("RuHmet", "Ru'Hmet")
                .Replace("dOria", "d'Oria")
                .Replace(" Pirates", "")
                .Replace("Sealions", "Sealion's")
                .Replace("RuAun", "Ru'Aun")
                .Replace("RoMaeve", "Ro'Maeve")
                .Replace("Riverne-Site ", "Riverne - Site #")
                .Replace("RaKaznar", "Ra'Kaznar")
                .Replace("QuBia", "Qu'Bia")
                .Replace("PsoXja", "Pso'Xja")
                .Replace("Promyvion-", "Promyvion - ")
                .Replace("Ordelles", "Ordelle's")
                .Replace("Mine Shaft ", "Mine Shaft #")
                .Replace("Dynamis-", "Dynamis - ")
                .Replace("Desuetia ", "Desuetia - ")
                .Replace("Escha ", "Escha - ")
                .Replace("RuLude", "Ru'Lude")
                .Replace("dOraguille", "d'Oraguille")
                .Replace("Ifrits", "Ifrit's")
                .Replace("FeiYin", "Fei'Yin")
                .Replace("Crawlers", "Crawlers'")
                .Replace("Ranperres", "Ranperre's")
                .Replace("LaLoff", "La'Loff")
                .Replace("Dragons", "Dragon's")
                .Replace("Balgas", "Balga's")
                .Replace("Ghoyus", "Ghoyu's")
                .Replace("Behemoths", "Behemoth's")
                .Replace("HuXzoi", "Hu'Xzoi")
                .Replace("AlTaieu", "Al'Taieu")
                .Replace("Carpenters", "Carpenters'")
                .Replace("unknown", "Unknown");

            temp = temp.EndsWith(" U") ? temp.Replace(" U", " [U]") : temp;

            return temp;
        }

        private static string FixFamilyName(string name)
        {
            var words = Regex.Matches(name, @"([A-Z][a-z-]+)")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();

            for (int i = 0; i < words.Count(); i++)
            {
                words[i] = words[i].Replace("-", " -");
            }

            return string.Join(" ", words);
        }

        private static string FixItemName(string name)
        {
            var words = name.Split("_");

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }

            return string.Join(" ", words);
        }
    }
}