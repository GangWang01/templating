Module Module1
'#If defaultTrue
    Sub DefaultTrueIncluded()
    End Sub
'#Else
    Sub DefaultTrueExcluded()
    End Sub
'#End If

'#If defaultFalse
    Sub DefaultFalseExcluded()
    End Sub
'#Else
    Sub DefaultFalseIncluded()
    End Sub
'#End If

'-:cnd:noEmit
'#If DEBUG1
    Sub InsideUnknownDirectiveNoEmit()
    End Sub
'#End If
'+:cnd:noEmit

'-:cnd
'#If DEBUG2
    Sub InsideUnknownDirectiveEmit()
    End Sub
'#End If
'+:cnd
End Module