# Migrations

We are using [FluentMigrator](https://fluentmigrator.github.io/) for our migrations.

To run them locally:
- only first time: dotnet tool install -g FluentMigrator.DotNet.Cli
- build this project
- run: dotnet fm migrate -p mysql -c "Server=localhost;Database=<db>;Uid=root;Pwd=<rootpw>" -a ".\bin\Debug\netcoreapp2.1\Cornerstone.Workflow.Repository.Migrations.dll"
- e.g. from root of repository 
dotnet fm migrate -p mysql -c "Server=localhost; Database=dnd; Port=3306; Uid=admin; Pwd=password;" -a ".\dndServer.Repository.Migrations\bin\Debug\netstandard2.0\dndServer.Repository.Migrations.dll"

To add read only user locally:
- run: mysql -u root -p;
- run: CREATE USER 'readonlyuser'@'%' IDENTIFIED BY 'milkyway';
- run: GRANT SELECT ON *.* TO 'readonlyuser'@'%';

# References

https://fluentmigrator.github.io/
https://github.com/fluentmigrator/fluentmigrator
https://fluentmigrator.github.io/articles/quickstart.html?tabs=runner-dotnet-fm
https://bitbucket.csod.com/projects/CSOD/repos/cornerstone-aws-rds/browse
https://wiki.cornerstoneondemand.com/display/SF/Devkit+Databases%2C+ORMs%2C+Schema+Migration+Framework#DevkitDatabases,ORMs,SchemaMigrationFramework-ManagingDatabaseSchema:FluentMigrator
https://bitbucket.csod.com/projects/CSOD/repos/devplan-blueprint-api/browse/src/DevPlanBlueprint.Repository.Migrations
