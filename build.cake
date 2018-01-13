
Task("Run").Does(() => {
  StartProcess("dotnet", new ProcessSettings {
      Arguments = "run --project src/DotNetSpan/DotNetSpan.csproj --configuration Release"
  });  
});

var target = Argument("target", "default");
RunTarget(target);