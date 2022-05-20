//#if defaultTrue
function DefaultTrueIncluded() { }
//#else
function DefaultTrueExcluded() { }
//#endif

//#if defaultFalse
function DefaultFalseExcluded() { }
//#else
function DefaultFalseIncluded() { }
//#endif

//-:cnd:noEmit
//#if DEBUG1
function InsideUnknownDirectiveNoEmit() { }
//#endif
//+:cnd:noEmit

//-:cnd
//#if DEBUG2
function InsideUnknownDirectiveEmit() { }
//#endif
//+:cnd