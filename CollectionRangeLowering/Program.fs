module CollectionRangeLowering.Benchmarks

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Running

[<MemoryDiagnoser; GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory); CategoriesColumn; HideColumns("Method", "Error", "StdDev", "RatioSD")>]
type Benchmarks () =
    [<Benchmark(Baseline = true); BenchmarkCategory("Array", "1", "[|10..1|]")>]
    member _.Array_Old_10To1 () = Old.Array.``[|10..1|]`` ()

    [<Benchmark; BenchmarkCategory("Array", "1", "[|10..1|]")>]
    member _.Array_New_10To1 () = New.Array.``[|10..1|]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Array", "2", "[|1..10|]")>]
    member _.Array_Old_1To10 () = Old.Array.``[|1..10|]`` ()

    [<Benchmark; BenchmarkCategory("Array", "2", "[|1..10|]")>]
    member _.Array_New_1To10 () = New.Array.``[|1..10|]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Array", "3", "[|1..256|]")>]
    member _.Array_Old_1To256 () = Old.Array.``[|1..256|]`` ()

    [<Benchmark; BenchmarkCategory("Array", "3", "[|1..256|]")>]
    member _.Array_New_1To256 () = New.Array.``[|1..256|]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Array", "4", "[|start..finish|] (start=1,finish=65536)")>]
    member this.Array_Old_Dynamic_1To65536 () = Old.Array.``[|start..finish|]`` 1 65536

    [<Benchmark; BenchmarkCategory("Array", "4", "[|start..finish|] (start=1,finish=65536)")>]
    member this.Array_New_Dynamic_1To65536 () = New.Array.``[|start..finish|]`` 1 65536

    [<Benchmark(Baseline = true); BenchmarkCategory("Array", "5", "[|1..2..256|]")>]
    member _.Array_Old_1_2_256 () = Old.Array.``[|1..2..256|]`` ()

    [<Benchmark; BenchmarkCategory("Array", "5", "[|1..2..256|]")>]
    member _.Array_New_1_2_256 () = New.Array.``[|1..2..256|]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("Array", "6", "[|start..step..finish|] (start=1,step=2,finish=65536)")>]
    member this.Array_Old_Dynamic_1_2_65536 () = Old.Array.``[|start..step..finish|]`` 1 2 65536

    [<Benchmark; BenchmarkCategory("Array", "6", "[|start..step..finish|] (start=1,step=2,finish=65536)")>]
    member this.Array_New_Dynamic_1_2_65536 () = New.Array.``[|start..step..finish|]`` 1 2 65536

    [<Benchmark(Baseline = true); BenchmarkCategory("List", "1", "[10..1]")>]
    member _.List_Old_10To1 () = Old.List.``[10..1]`` ()

    [<Benchmark; BenchmarkCategory("List", "1", "[10..1]")>]
    member _.List_New_10To1 () = New.List.``[10..1]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("List", "2", "[1..10]")>]
    member _.List_Old_1To10 () = Old.List.``[1..10]`` ()

    [<Benchmark; BenchmarkCategory("List", "2", "[1..10]")>]
    member _.List_New_1To10 () = New.List.``[1..10]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("List", "3", "[1..256]")>]
    member _.List_Old_1To256 () = Old.List.``[1..256]`` ()

    [<Benchmark; BenchmarkCategory("List", "3", "[1..256]")>]
    member _.List_New_1To256 () = New.List.``[1..256]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("List", "4", "[start..finish] (start=1,finish=65536)")>]
    member this.List_Old_Dynamic_1To65536 () = Old.List.``[start..finish]`` 1 65536

    [<Benchmark; BenchmarkCategory("List", "4", "[start..finish] (start=1,finish=65536)")>]
    member this.List_New_Dynamic_1To65536 () = New.List.``[start..finish]`` 1 65536

    [<Benchmark(Baseline = true); BenchmarkCategory("List", "5", "[1..2..256]")>]
    member _.List_Old_1_2_256 () = Old.List.``[1..2..256]`` ()

    [<Benchmark; BenchmarkCategory("List", "5", "[1..2..256]")>]
    member _.List_New_1_2_256 () = New.List.``[1..2..256]`` ()

    [<Benchmark(Baseline = true); BenchmarkCategory("List", "6", "[start..step..finish] (start=1,step=2,finish=65536)")>]
    member this.List_Old_Dynamic_1_2_65536 () = Old.List.``[start..step..finish]`` 1 2 65536

    [<Benchmark; BenchmarkCategory("List", "6", "[start..step..finish] (start=1,step=2,finish=65536)")>]
    member this.List_New_Dynamic_1_2_65536 () = New.List.``[start..step..finish]`` 1 2 65536

ignore (BenchmarkRunner.Run<Benchmarks> ())
