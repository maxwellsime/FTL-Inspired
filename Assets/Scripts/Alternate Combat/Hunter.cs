using System.Collections;
using System.Collections.Generic;

public class Hunter{
    public string name;
    public int rank;
    public int age;
    public char gender;

    // All of the stats that govern gameplay. Skill, personality and status stats all have differing values.
    public Dictionary<string, int> stats = new Dictionary<string, int>(){
        // Skill stats of the character, between 0 and 10.
        { "swords", 0 },
        { "maces", 0 },
        { "daggers", 0 },
        { "whips", 0 },
        { "bows", 0 },
        { "shields", 0 },
        { "water", 0 },
        { "fire", 0 },
        { "earth", 0 },
        { "wind", 0 },
        { "white", 0 },
        { "black", 0 },
        { "endurance", 0 },
        { "intelligence", 0 },
        { "strength", 0 },
        { "awareness", 0 },
        { "charisma", 0 },
        { "memory", 0 },
        // Personality stats for the character, between -50 to 50, starts at 0.
        { "anger", 0 },
        { "extroversion", 0 },
        { "bravery", 0 },
        { "viciousness", 0 },
        // Status values, have to be managed throughout gameplay. Start at 100, reaching 0 causes them to leave the company.
        { "health", 100 },
        { "sanity", 100 },
        { "stamina", 100 },
        { "happiness", 100 },
        { "speed", 100 },
        { "load", 100 }
    };
    
    // List of quirks that directly effect gameplay
    public List<Quirk> quirks = new List<Quirk>();
    public Company company;

    // Updates an individual stat value
    public void UpdateStat(string stat, int amount){
        if (stats.ContainsKey(stat)){
            stats[stat] += amount;
        }
        CheckStatQuirk(stat);
    }

    // Gets stat information from string containing key
    public int GetStat(string stat){
        int val = 0;

        if (stats.ContainsKey(stat)){
            val = stats[stat];
            return ApplyQuirk(stat, val);
       }

        return val;
    }

    // Apply quirk effects to stat, if they exist
    public int ApplyQuirk(string stat, int val){
        foreach(Quirk q in quirks){           
            if(q.effects.ContainsKey(stat)){
                val += q.effects[stat];
            }
        }

        return val;
    }

    // Add quirk q to character quirk list
    public void AddQuirk(Quirk q){
        // Search for stat in supposed dictionary, then read value
        quirks.Add(q);
    }

    // Check recently updated skill or personality stat to see if it manifests a quirk
    public void CheckStatQuirk(string stat){
        if(stats[stat] > 40){
            // Search database for quirk information gained at this stat value
        }
        else if(stats[stat] < -40){
            // Search database for quirk information gained at this stat value
        }
    }    
}