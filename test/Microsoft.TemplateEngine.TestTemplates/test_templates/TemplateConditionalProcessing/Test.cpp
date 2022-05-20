#include "stdafx.h"
#include <string>
#include <iostream>

#if defaultTrue
class DefaultTrueIncluded { }
#else
class DefaultTrueExcluded { }
#endif

#if defaultFalse
class DefaultFalseExcluded { }
#else
class DefaultFalseIncluded { }
#endif

//-:cnd:noEmit
#if DEBUG1
class InsideUnknownDirectiveNoEmit { }
#endif
//+:cnd:noEmit

//-:cnd
#if DEBUG2
class InsideUnknownDirectiveEmit { }
#endif
//+:cnd

