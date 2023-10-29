# Zexpo

1. First Clone Application from git or clone Readme File.       
    git clone url
1. Then create solutions of dotnet project      
    dotnet new sln --name Zexpo
1. Then Create project with folder   
    dotnet new mvc -lang "C#" --name Zexpo.Web --output Zexpo.Web -f Net6.0 --no-update-check 
1. Add Project to sln   
   dotnet sln add Zexpo.Web/Zexpo.Web.csproj