using System;
using FluentMigrator;

namespace dndServer.Repository.Migrations
{
    [Migration(1)]
    public class SetupCharactersTable : Migration
    {
        public override void Up()
        {
            Create.Table("Characters")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Text").AsString();
        }
        public override void Down()
        {
            Delete.Table("Characters");
        }
    }
}
