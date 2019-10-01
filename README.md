# async-action-reproduction

Steps to reproduce:
```
cd lib2
dotnet build
```

Error:
```
C.cs(10,57): error CS0012: The type 'IAsyncAction' is defined in an assembly that is not referenced. You must add a reference to assembly 'Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime'. […\lib2\lib2.csproj]
C.cs(10,57): error CS0012: The type 'IAsyncActionWithProgress<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime'. […\lib2\lib2.csproj]
C.cs(10,57): error CS0012: The type 'IAsyncOperation<>' is defined in an assembly that is not referenced. You must add a reference to assembly 'Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime'. […\lib2\lib2.csproj]
C.cs(10,57): error CS0012: The type 'IAsyncOperationWithProgress<,>' is defined in an assembly that is not referenced. You must add a reference to assembly 'Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime'. […\lib2\lib2.csproj]
```