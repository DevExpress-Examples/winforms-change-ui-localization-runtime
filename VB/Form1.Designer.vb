Namespace SchedulerSwitchLocale

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.cbLocale = New System.Windows.Forms.ComboBox()
            Me.label1 = New System.Windows.Forms.Label()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Anchor = CType(((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.schedulerControl1.Location = New System.Drawing.Point(16, 48)
            Me.schedulerControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(819, 580)
            Me.schedulerControl1.Start = New System.DateTime(2008, 9, 4, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' cbLocale
            ' 
            Me.cbLocale.FormattingEnabled = True
            Me.cbLocale.Items.AddRange(New Object() {"en", "fr"})
            Me.cbLocale.Location = New System.Drawing.Point(87, 14)
            Me.cbLocale.Margin = New System.Windows.Forms.Padding(4)
            Me.cbLocale.Name = "cbLocale"
            Me.cbLocale.Size = New System.Drawing.Size(129, 24)
            Me.cbLocale.TabIndex = 1
            AddHandler Me.cbLocale.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbLocale_SelectedIndexChanged)
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(16, 17)
            Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(54, 17)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Locale:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(851, 642)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.cbLocale)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private cbLocale As System.Windows.Forms.ComboBox

        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace
