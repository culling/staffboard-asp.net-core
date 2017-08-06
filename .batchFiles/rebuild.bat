dotnet restore
echo y | dotnet ef database drop --context MvcUserContext
echo y | dotnet ef database drop --context MvcStatusContext 


 dotnet aspnet-codegenerator controller -name UsersController    -m User     -dc MvcUserContext      --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f
 dotnet aspnet-codegenerator controller -name StatusController   -m Status   -dc MvcStatusContext    --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f


REM dotnet aspnet-codegenerator controller -name StatusController   -m Status   -dc MvcStatusContext    --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -f

dotnet run