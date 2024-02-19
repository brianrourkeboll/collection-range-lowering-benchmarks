module CollectionRangeLowering.Old

open System.Runtime.CompilerServices

module Array =
    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[|10..1|]`` () = [|10..1|]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[|1..10|]`` () = [|1..10|]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[|1..256|]`` () = [|1..256|]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[|start..finish|]`` start finish = [|start..finish|]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[|1..2..256|]`` () = [|1..2..256|]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[|start..step..finish|]`` start step finish = [|start..step..finish|]

module List =
    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[10..1]`` () = [10..1]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[1..10]`` () = [1..10]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[1..256]`` () = [1..256]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[start..finish]`` start finish = [start..finish]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[1..2..256]`` () = [1..2..256]

    [<MethodImpl(MethodImplOptions.NoInlining)>]
    let ``[start..step..finish]`` start step finish = [start..step..finish]
