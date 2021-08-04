
Build with
```
dotnet build /p:EmitCompilerGeneratedFiles=true
```

Razor generated code is in obj/Debug/net6.0/generated/

The `Counter` class's `BuildRenderTree` passes a lambda to the `PageTitleAK.BuildRenderTree` method.

There is no `EnC Lambda And Closure Info` corresponding to `Counter.BuildRenderTree`.