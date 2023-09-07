Imports System
Imports System.Windows.Forms

Namespace SchedulerSwitchLocale

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            cbLocale.SelectedIndex = cbLocale.Items.IndexOf(CultureId)
        End Sub

        Private Sub cbLocale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim selectedLocale As String = cbLocale.SelectedItem.ToString()
            ChangeCulture(selectedLocale)
        End Sub
    End Class
End Namespace
