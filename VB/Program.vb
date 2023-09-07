Imports System
Imports System.Windows.Forms

Namespace SchedulerSwitchLocale

    Friend Module Program

        <STAThread>
        Sub Main()
            RestoreCulture()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New Form1())
        End Sub
    End Module
End Namespace
