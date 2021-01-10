# Hebut Student Management System
## 1. Test account and test data in database
Teacher login test account: 111, password: root  
Teacher test data:  

|id     |name    |major    |passwd|  
|-------|--------|---------|------|  
|222    |Evan    |computer |root  |  
|111    |Jhon    |computer |root  |  

Student test data:

|id     |name    |subject     |sex   |passwd   |classId|
|-------|--------|------------|------|---------|-------|
|111    |Evan    |Computer Seince|male|<null>  |222    |

Class test data:

|id     |name        |teacherId  |
|-------|------------|-----------|
|111    |SinoFran181 |<null>     |
|222    |SinoFran182 |<null>     |

## 2. Main code introduction
1. Data access layer
    * There are three entities: Teacher, Student and Class which are work to access database for select, delete, update and create data
    * All select, delete, update and create functions of these entities are also made into interfaces to delivery data and function to other layer clearly 
2. Business layer
    * This layer gives any functions and algorithm between data access layer and display layer
    * There are also three part of business which are student, teacher and class and it also extends the interface of data access layer
    * It also implement many interface to delivery functions to display layer
3. Display layer
    * This layer only work to display print and get user input
    * It extends interface of business layer to do some judgement and get or input data in database
    * There is only one file of program which is the entrance of this system
    * It use the data.db where is under the path /bin as the sqlite database
## 3. Project file tree
````
├── ClassManagementSystem.sln
├── ClassManagementSystem.sln.DotSettings.user
├── dataAccessLayer
│   ├── bin
│   │   └── Debug
│   │       └── netcoreapp3.0
│   │           ├── dataAccessLayer
│   │           ├── dataAccessLayer.deps.json
│   │           ├── dataAccessLayer.dll
│   │           ├── dataAccessLayer.pdb
│   │           ├── dataAccessLayer.runtimeconfig.dev.json
│   │           ├── dataAccessLayer.runtimeconfig.json
│   │           ├── Humanizer.dll
│   │           ├── main.db
│   │           ├── Microsoft.Data.Sqlite.dll
│   │           ├── Microsoft.DotNet.PlatformAbstractions.dll
│   │           ├── Microsoft.EntityFrameworkCore.Abstractions.dll
│   │           ├── Microsoft.EntityFrameworkCore.Design.dll
│   │           ├── Microsoft.EntityFrameworkCore.dll
│   │           ├── Microsoft.EntityFrameworkCore.Relational.dll
│   │           ├── Microsoft.EntityFrameworkCore.Sqlite.dll
│   │           ├── Microsoft.Extensions.Caching.Abstractions.dll
│   │           ├── Microsoft.Extensions.Caching.Memory.dll
│   │           ├── Microsoft.Extensions.Configuration.Abstractions.dll
│   │           ├── Microsoft.Extensions.DependencyInjection.Abstractions.dll
│   │           ├── Microsoft.Extensions.DependencyInjection.dll
│   │           ├── Microsoft.Extensions.DependencyModel.dll
│   │           ├── Microsoft.Extensions.Logging.Abstractions.dll
│   │           ├── Microsoft.Extensions.Logging.dll
│   │           ├── Microsoft.Extensions.Options.dll
│   │           ├── Microsoft.Extensions.Primitives.dll
│   │           ├── runtimes
│   │           │   ├── alpine-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-arm
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-arm64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-armel
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-mips64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-musl-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-x86
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── osx-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.dylib
│   │           │   ├── win-arm
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   ├── win-arm64
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   ├── win-x64
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   └── win-x86
│   │           │       └── native
│   │           │           └── e_sqlite3.dll
│   │           ├── SQLitePCLRaw.batteries_v2.dll
│   │           ├── SQLitePCLRaw.core.dll
│   │           ├── SQLitePCLRaw.provider.e_sqlite3.dll
│   │           ├── System.Collections.Immutable.dll
│   │           ├── System.ComponentModel.Annotations.dll
│   │           ├── systemControlLayer
│   │           ├── systemControlLayer.deps.json
│   │           ├── systemControlLayer.runtimeconfig.dev.json
│   │           ├── systemControlLayer.runtimeconfig.json
│   │           ├── System.Diagnostics.DiagnosticSource.dll
│   │           ├── System.Text.Encodings.Web.dll
│   │           └── System.Text.Json.dll
│   ├── dataAccessLayer.csproj
│   ├── entity
│   │   ├── ClassEntity.cs
│   │   ├── EntityContext.cs
│   │   ├── StudentEntity.cs
│   │   └── TeacherEntity.cs
│   ├── functionInterface
│   │   ├── ClassFunctions.cs
│   │   ├── IClassFunctions.cs
│   │   ├── IStudentFunctions.cs
│   │   ├── ITeacherFunctions.cs
│   │   ├── StudentFunctions.cs
│   │   └── TeacherFunctions.cs
│   ├── obj
│   │   ├── dataAccessLayer.csproj.nuget.dgspec.json
│   │   ├── dataAccessLayer.csproj.nuget.g.props
│   │   ├── dataAccessLayer.csproj.nuget.g.targets
│   │   ├── Debug
│   │   │   └── netcoreapp3.0
│   │   │       ├── dataAccessLayer
│   │   │       ├── dataAccessLayer.AssemblyInfo.cs
│   │   │       ├── dataAccessLayer.AssemblyInfoInputs.cache
│   │   │       ├── dataAccessLayer.assets.cache
│   │   │       ├── dataAccessLayer.csprojAssemblyReference.cache
│   │   │       ├── dataAccessLayer.csproj.CopyComplete
│   │   │       ├── dataAccessLayer.csproj.FileListAbsolute.txt
│   │   │       ├── dataAccessLayer.dll
│   │   │       ├── dataAccessLayer.pdb
│   │   │       ├── systemControlLayer
│   │   │       ├── systemControlLayer.AssemblyInfo.cs
│   │   │       ├── systemControlLayer.AssemblyInfoInputs.cache
│   │   │       ├── systemControlLayer.assets.cache
│   │   │       ├── systemControlLayer.csprojAssemblyReference.cache
│   │   │       ├── systemControlLayer.csproj.CopyComplete
│   │   │       ├── systemControlLayer.csproj.FileListAbsolute.txt
│   │   │       ├── systemControlLayer.dll
│   │   │       ├── systemControlLayer.pdb
│   │   │       ├── systemControlLyar.AssemblyInfo.cs
│   │   │       ├── systemControlLyar.AssemblyInfoInputs.cache
│   │   │       └── systemControlLyar.assets.cache
│   │   ├── project.assets.json
│   │   ├── project.nuget.cache
│   │   ├── project.packagespec.json
│   │   ├── rider.project.restore.info
│   │   ├── systemControlLayer.csproj.nuget.dgspec.json
│   │   ├── systemControlLayer.csproj.nuget.g.props
│   │   ├── systemControlLayer.csproj.nuget.g.targets
│   │   ├── systemControlLyar.csproj.nuget.dgspec.json
│   │   ├── systemControlLyar.csproj.nuget.g.props
│   │   └── systemControlLyar.csproj.nuget.g.targets
│   └── test
│       └── ControlLayerTest.cs
├── README.md
├── systemBusinessLayer
│   ├── bin
│   │   └── Debug
│   │       └── netcoreapp3.0
│   │           ├── dataAccessLayer
│   │           ├── dataAccessLayer.dll
│   │           ├── dataAccessLayer.pdb
│   │           ├── Microsoft.Data.Sqlite.dll
│   │           ├── Microsoft.DotNet.PlatformAbstractions.dll
│   │           ├── Microsoft.EntityFrameworkCore.Abstractions.dll
│   │           ├── Microsoft.EntityFrameworkCore.dll
│   │           ├── Microsoft.EntityFrameworkCore.Relational.dll
│   │           ├── Microsoft.EntityFrameworkCore.Sqlite.dll
│   │           ├── Microsoft.Extensions.Caching.Abstractions.dll
│   │           ├── Microsoft.Extensions.Caching.Memory.dll
│   │           ├── Microsoft.Extensions.Configuration.Abstractions.dll
│   │           ├── Microsoft.Extensions.DependencyInjection.Abstractions.dll
│   │           ├── Microsoft.Extensions.DependencyInjection.dll
│   │           ├── Microsoft.Extensions.DependencyModel.dll
│   │           ├── Microsoft.Extensions.Logging.Abstractions.dll
│   │           ├── Microsoft.Extensions.Logging.dll
│   │           ├── Microsoft.Extensions.Options.dll
│   │           ├── Microsoft.Extensions.Primitives.dll
│   │           ├── runtimes
│   │           │   ├── alpine-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-arm
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-arm64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-armel
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-mips64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-musl-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-x86
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── osx-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.dylib
│   │           │   ├── win-arm
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   ├── win-arm64
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   ├── win-x64
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   └── win-x86
│   │           │       └── native
│   │           │           └── e_sqlite3.dll
│   │           ├── SQLitePCLRaw.batteries_v2.dll
│   │           ├── SQLitePCLRaw.core.dll
│   │           ├── SQLitePCLRaw.provider.e_sqlite3.dll
│   │           ├── systemBusinessLayer
│   │           ├── systemBusinessLayer.deps.json
│   │           ├── systemBusinessLayer.dll
│   │           ├── systemBusinessLayer.pdb
│   │           ├── systemBusinessLayer.runtimeconfig.dev.json
│   │           ├── systemBusinessLayer.runtimeconfig.json
│   │           ├── System.Collections.Immutable.dll
│   │           ├── System.ComponentModel.Annotations.dll
│   │           ├── System.Diagnostics.DiagnosticSource.dll
│   │           ├── System.Text.Encodings.Web.dll
│   │           └── System.Text.Json.dll
│   ├── business
│   │   ├── ClassBusiness.cs
│   │   ├── StudentBusiness.cs
│   │   └── TeacherBusiness.cs
│   ├── Interface
│   │   ├── IClassBusiness.cs
│   │   ├── IStudentBusiness.cs
│   │   └── ITeacherBusiness.cs
│   ├── obj
│   │   ├── ClassManagementSystem.csproj.nuget.dgspec.json
│   │   ├── ClassManagementSystem.csproj.nuget.g.props
│   │   ├── ClassManagementSystem.csproj.nuget.g.targets
│   │   ├── Debug
│   │   │   └── netcoreapp3.0
│   │   │       ├── ClassManagementSystem.AssemblyInfo.cs
│   │   │       ├── ClassManagementSystem.AssemblyInfoInputs.cache
│   │   │       ├── ClassManagementSystem.assets.cache
│   │   │       ├── ClassManagementSystem.csprojAssemblyReference.cache
│   │   │       ├── systemBusinessLayer
│   │   │       ├── systemBusinessLayer.AssemblyInfo.cs
│   │   │       ├── systemBusinessLayer.AssemblyInfoInputs.cache
│   │   │       ├── systemBusinessLayer.assets.cache
│   │   │       ├── systemBusinessLayer.csprojAssemblyReference.cache
│   │   │       ├── systemBusinessLayer.csproj.CopyComplete
│   │   │       ├── systemBusinessLayer.csproj.FileListAbsolute.txt
│   │   │       ├── systemBusinessLayer.dll
│   │   │       └── systemBusinessLayer.pdb
│   │   ├── project.assets.json
│   │   ├── project.nuget.cache
│   │   ├── project.packagespec.json
│   │   ├── rider.project.restore.info
│   │   ├── systemBusinessLayer.csproj.nuget.dgspec.json
│   │   ├── systemBusinessLayer.csproj.nuget.g.props
│   │   └── systemBusinessLayer.csproj.nuget.g.targets
│   ├── systemBusinessLayer.csproj
│   └── test
│       └── Program.cs
├── systemDisplayLayer
│   ├── bin
│   │   └── Debug
│   │       └── netcoreapp3.0
│   │           ├── dataAccessLayer
│   │           ├── dataAccessLayer.dll
│   │           ├── dataAccessLayer.pdb
│   │           ├── data.db  // System Database
│   │           ├── Microsoft.Data.Sqlite.dll
│   │           ├── Microsoft.DotNet.PlatformAbstractions.dll
│   │           ├── Microsoft.EntityFrameworkCore.Abstractions.dll
│   │           ├── Microsoft.EntityFrameworkCore.dll
│   │           ├── Microsoft.EntityFrameworkCore.Relational.dll
│   │           ├── Microsoft.EntityFrameworkCore.Sqlite.dll
│   │           ├── Microsoft.Extensions.Caching.Abstractions.dll
│   │           ├── Microsoft.Extensions.Caching.Memory.dll
│   │           ├── Microsoft.Extensions.Configuration.Abstractions.dll
│   │           ├── Microsoft.Extensions.DependencyInjection.Abstractions.dll
│   │           ├── Microsoft.Extensions.DependencyInjection.dll
│   │           ├── Microsoft.Extensions.DependencyModel.dll
│   │           ├── Microsoft.Extensions.Logging.Abstractions.dll
│   │           ├── Microsoft.Extensions.Logging.dll
│   │           ├── Microsoft.Extensions.Options.dll
│   │           ├── Microsoft.Extensions.Primitives.dll
│   │           ├── runtimes
│   │           │   ├── alpine-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-arm
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-arm64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-armel
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-mips64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-musl-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── linux-x86
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.so
│   │           │   ├── osx-x64
│   │           │   │   └── native
│   │           │   │       └── libe_sqlite3.dylib
│   │           │   ├── win-arm
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   ├── win-arm64
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   ├── win-x64
│   │           │   │   └── native
│   │           │   │       └── e_sqlite3.dll
│   │           │   └── win-x86
│   │           │       └── native
│   │           │           └── e_sqlite3.dll
│   │           ├── SQLitePCLRaw.batteries_v2.dll
│   │           ├── SQLitePCLRaw.core.dll
│   │           ├── SQLitePCLRaw.provider.e_sqlite3.dll
│   │           ├── systemBusinessLayer
│   │           ├── systemBusinessLayer.dll
│   │           ├── systemBusinessLayer.pdb
│   │           ├── System.Collections.Immutable.dll
│   │           ├── System.ComponentModel.Annotations.dll
│   │           ├── System.Diagnostics.DiagnosticSource.dll
│   │           ├── systemDisplayLayer
│   │           ├── systemDisplayLayer.deps.json
│   │           ├── systemDisplayLayer.dll
│   │           ├── systemDisplayLayer.pdb
│   │           ├── systemDisplayLayer.runtimeconfig.dev.json
│   │           ├── systemDisplayLayer.runtimeconfig.json
│   │           ├── System.Text.Encodings.Web.dll
│   │           └── System.Text.Json.dll
│   ├── obj
│   │   ├── Debug
│   │   │   └── netcoreapp3.0
│   │   │       ├── systemDisplayLayer
│   │   │       ├── systemDisplayLayer.AssemblyInfo.cs
│   │   │       ├── systemDisplayLayer.AssemblyInfoInputs.cache
│   │   │       ├── systemDisplayLayer.assets.cache
│   │   │       ├── systemDisplayLayer.csprojAssemblyReference.cache
│   │   │       ├── systemDisplayLayer.csproj.CopyComplete
│   │   │       ├── systemDisplayLayer.csproj.FileListAbsolute.txt
│   │   │       ├── systemDisplayLayer.dll
│   │   │       └── systemDisplayLayer.pdb
│   │   ├── project.assets.json
│   │   ├── project.nuget.cache
│   │   ├── project.packagespec.json
│   │   ├── rider.project.restore.info
│   │   ├── systemDisplayLayer.csproj.nuget.dgspec.json
│   │   ├── systemDisplayLayer.csproj.nuget.g.props
│   │   └── systemDisplayLayer.csproj.nuget.g.targets
│   ├── Program.cs
│   └── systemDisplayLayer.csproj
└── tree.text
````
