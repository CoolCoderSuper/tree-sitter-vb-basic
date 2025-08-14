Namespace Top
Namespace Nested
Public Class Hello
	Inherits Nice
	Implements Nice
End Class
End Namespace
End Namespace

Friend Class Nice
	Public Const value As String = expr
	Friend value As String, value2 As String = expr
	Function Test(first As String, Optional other As String = expr) As Integer
	End Function

	Sub Other(v As Integer)
	End Sub
End Class
