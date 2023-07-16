C#里的namespace 会将空间里的class和其他空间以及。net的进行隔离

class是一个小程序，可以有很多的方法，每个方法里有很多的statement，statement只是一个action；

C#里创建项目的时候，会创建solution，solution是项目的容器，solution里可以有多个项目。

namespace可以跨多个文件。class也可以跨多个文件，但是需要使用partial关键字。

// sln/csproj to executable
dotnet publish -c Release -r win10-x64

dotnet publish -c Release -r osx-x64

