using System;
using FluentMigrator;

namespace dndServer.Repository.Migrations
{
    [Migration(7)]
    class SetupRacesTable : Migration
    {
        public override void Up()
        {
            Create.Table("Races")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Name").AsString()
                .WithColumn("Speed").AsInt64();;
        }
        public override void Down()
        {
            Delete.Table("Races");
        }
    }
}
