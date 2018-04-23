Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Namespace SchedulerSwitchLocale
	Public NotInheritable Class CultureSwitcher
        Private Shared privateCultureId As String
		Public Shared Property CultureId() As String
			Get
				Return privateCultureId
			End Get
			Private Set(ByVal value As String)
				privateCultureId = value
			End Set
		End Property

		Private Sub New()
		End Sub
		Public Shared Sub ChangeCulture(ByVal newCultureId As String)
			If CultureSwitcher.CultureId = newCultureId Then
				Return
			End If

			Dim pathSettings As String = Path.Combine(Directory.GetCurrentDirectory(), "culture.ini")

			File.WriteAllText(pathSettings, newCultureId)
			Application.Restart()
			Environment.Exit(0)
		End Sub

		Public Shared Sub RestoreCulture()
			Dim pathSettings As String = Path.Combine(Directory.GetCurrentDirectory(), "culture.ini")

			If File.Exists(pathSettings) Then
				CultureId = File.ReadAllText(pathSettings)
			Else
				CultureId = "en"
			End If

			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(CultureId)
			Thread.CurrentThread.CurrentUICulture = New CultureInfo(CultureId)
		End Sub
	End Class
End Namespace
