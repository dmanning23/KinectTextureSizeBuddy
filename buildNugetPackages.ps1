rm *.nupkg
nuget pack .\KinectTextureSizeBuddy.nuspec -IncludeReferencedProjects -Prop Configuration=Release
cp *.nupkg C:\Projects\Nugets\