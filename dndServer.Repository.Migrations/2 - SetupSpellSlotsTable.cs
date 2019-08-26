using System;
using FluentMigrator;

namespace dndServer.Repository.Migrations
{
   [Migration(2)]
   class SetupSpellSlots : Migration
    {
        public override void Up()
        {
            Create.Table("SpellSlots")
                .WithColumn("SpellInstance").AsInt64().PrimaryKey().Identity()
                .WithColumn("SpellId").AsInt64().ForeignKey("Spells", "Id")
                .WithColumn("CharacterId").AsInt64().ForeignKey("Characters", "Id")
                .WithColumn("Position").AsInt16()
                .WithColumn("HasBeenUsed").AsBoolean();
        }
        public override void Down()
        {
            Delete.Table("SpellSlots");
        }
    }
}
