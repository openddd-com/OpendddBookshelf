# backend
1.cd aspnet-core

2.dotnet restore

3.cd src/Openddd.EntityFrameWorkcore --clean Migrations -- add entities

4.dotnet ef migrations add "initmysql"

5.dotnet ef database update

# front end

npm install typescript@'>=2.1.0 <2.4.0'

# build

cd aspnet-core/build

.\build-with-ng.ps1