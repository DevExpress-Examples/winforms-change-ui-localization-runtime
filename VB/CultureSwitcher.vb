Imports System
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms

Namespace SchedulerSwitchLocale

    Public Module CultureSwitcher

        Private _CultureId As String

        Public Property CultureId As String
            Get
                Return _CultureId
            End Get

            Private Set(ByVal value As String)
                _CultureId = value
            End Set
        End Property

        Public Sub ChangeCulture(ByVal newCultureId As String)
            If Equals(CultureId, newCultureId) Then Return
            Dim pathSettings As String = Path.Combine(Directory.GetCurrentDirectory(), "culture.ini")
            File.WriteAllText(pathSettings, newCultureId)
            Call Application.Restart()
            Environment.Exit(0)
        End Sub

        Public Sub RestoreCulture()
            Dim pathSettings As String = Path.Combine(Directory.GetCurrentDirectory(), "culture.ini")
            If File.Exists(pathSettings) Then
                CultureId = File.ReadAllText(pathSettings)
            Else
                CultureId = "en"
            End If

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(CultureId)
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(CultureId)
        End Sub
    End Module
End Namespace
