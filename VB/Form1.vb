Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Globalization
Imports System.Threading

Namespace SchedulerSwitchLocale
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			cbLocale.SelectedIndex = cbLocale.Items.IndexOf(CultureSwitcher.CultureId)
		End Sub

		Private Sub cbLocale_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbLocale.SelectedIndexChanged
			Dim selectedLocale As String = cbLocale.SelectedItem.ToString()
			CultureSwitcher.ChangeCulture(selectedLocale)
		End Sub
	End Class
End Namespace