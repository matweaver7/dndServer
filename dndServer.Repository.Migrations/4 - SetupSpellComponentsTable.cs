using System;
using FluentMigrator;

namespace dndServer.Repository.Migrations
{
    [Migration(4)]
    class SetupSpellComponentsTable : Migration
    {
        public override void Up()
        {
            Create.Table("SpellComponentsDefinitions")
                .WithColumn("Id").AsInt16().PrimaryKey().Identity()
                .WithColumn("ComponentName").AsString();
        }
        public override void Down()
        {
            Delete.Table("SpellComponentsDefinitions");
        }
    }
    class SetupSpellComponentsInstanceTable : Migration
    {
        public override void Up()
        {
            Create.Table("SpellComponents")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("SpellID").AsString().ForeignKey("Spells", "Id")
                .WithColumn("ComponentId").AsInt16().ForeignKey("SpellComponentsDefinitions", "Id");
        }
        public override void Down()
        {
            Delete.Table("SpellComponentsInstance");
        }
    }

    
    "components":"V, S, M"
}
