1.cd aspnet-core

2.dotnet restore

3.cd src/Openddd.EntityFrameWorkcore --clean Migrations -- add entities

4.dotnet ef migrations add "initmysql"

5.dotnet ef database update
