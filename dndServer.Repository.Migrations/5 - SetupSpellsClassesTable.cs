﻿using System;
using FluentMigrator;

namespace dndServer.Repository.Migrations
{
    [Migration(3)]
    class SetupSpellsTable : Migration
    {
        public override void Up()
        {
            Create.Table("Spells")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn
                .WithColumn("Name").AsString();

        }
        public override void Down()
        {
            Delete.Table("Spells");
        }
    }

    "name":"Abi-Dalzim's Horrid Wilting",
    "desc":"<p>You draw the moisture from every creature in a 30-foot cube centered on a point you choose within range. Each creature in that area must make a Constitution saving throw. Constructs and undead aren't affected, and plants and water elementals make this saving throw with disadvantage. A creature takes 10d8 necrotic damage on a failed save, or half as much damage on a successful one.You hurl a bubble of acid. Choose one creature within range, or choose two creatures within range that are within 5 feet of each other. A target must succeed on a Dexterity saving throw or take 1d6 acid damage.</p><p>This spells damage increases by 1d6 when you reach 5th Level (2d6), 11th level (3d6) and 17th level (4d6).</p>",
    "page":"ee pc 15",
    "range":"150 feet",
    "components":"V, S, M",
    "material":"A bit of sponge.",
    "ritual":"no",
    "duration":"Instantaneous",
    "concentration":"no",
    "casting_time":"1 action",
    "level":"8th-level",
    "school":"Necromancy",
    "class":"Sorcerer, Wizard"
}
