using System;
using System.Collections.Generic;
using dndServer.Contracts.CharacterAttributes;

namespace dndServer.Contracts
{
    public class Character
    {
        public string name { get; set; }
        public AbilityScores abilityScores { get; set; }
        public Skills skills { get; set; }
        public IList<ISpells> spells { get; set; }
        public IList<IEquipment> equipment { get; set; }
        public int level { get; set; }
        public int numberOfSpellSlots { get; set; }
        public int numberOfCantrips { get; set; }
        public int currentHitPoints { get; set; }
        public int maxHitPoints { get; set; }
        public int armourClass { get; set; }
        public int initiative { get; set; }
        public int speed { get; set; }
    }
}
