using System;
using FluentMigrator;

namespace dndServer.Repository.Migrations
{
    [Migration(8)]
    class SetupRacesSkillsTable : Migration
    {
        public override void Up()
        {
            Create.Table("RacesStats")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("RaceID").AsInt64().ForeignKey("Races", "Id")
                .WithColumn("StrengthModifier").AsInt64()
                .WithColumn("DexterityModifier").AsInt64()
                .WithColumn("CharismanModifier").AsInt64()
                .WithColumn("IntelligenceModifier").AsInt64()
                .WithColumn("WisdomModifier").AsInt64()
                .WithColumn("ConsitutionModifier").AsInt64();
        }
        public override void Down()
        {
            Delete.Table("Races");
        }
    }
}
