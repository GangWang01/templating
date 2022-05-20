//#if defaultTrue
declare class DefaultTrueIncluded { }
//#else
declare class DefaultTrueExcluded { }
//#endif

//#if defaultFalse
declare class DefaultFalseExcluded { }
//#else
declare class DefaultFalseIncluded { }
//#endif

//-:cnd:noEmit
//#if DEBUG1
declare class InsideUnknownDirectiveNoEmit { }
//#endif
//+:cnd:noEmit

//-:cnd
//#if DEBUG2
declare class InsideUnknownDirectiveEmit { }
//#endif
//+:cnd