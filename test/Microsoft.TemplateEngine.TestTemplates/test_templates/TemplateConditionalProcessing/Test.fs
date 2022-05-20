open System

#if defaultTrue
type DefaultTrueIncluded() = do printfn ""
#else
type DefaultTrueExcluded() = do printfn ""
#endif

#if defaultFalse
type DefaultFalseExcluded() = do printfn ""
#else
type DefaultFalseIncluded() = do printfn ""
#endif

//-:cnd:noEmit
#if DEBUG1
type InsideUnknownDirectiveNoEmit() = do printfn ""
#endif
//+:cnd:noEmit

//-:cnd
#if DEBUG2
type InsideUnknownDirectiveEmit() = do printfn ""
#endif
//+:cnd