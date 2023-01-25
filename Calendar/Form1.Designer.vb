<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CALENDAR = New System.Windows.Forms.MonthCalendar()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTN_Aggiungi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_User = New System.Windows.Forms.TextBox()
        Me.BTN_Rimuovi = New System.Windows.Forms.Button()
        Me.TXT_Data = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_Calcola = New System.Windows.Forms.Button()
        Me.LIST_User = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_registri = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_persone = New System.Windows.Forms.TextBox()
        Me.BTN_DataSel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CALENDAR
        '
        Me.CALENDAR.Location = New System.Drawing.Point(18, 75)
        Me.CALENDAR.MaxSelectionCount = 1
        Me.CALENDAR.Name = "CALENDAR"
        Me.CALENDAR.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.AutoArrange = False
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(301, 13)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(306, 196)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "USER"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DATA"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'BTN_Aggiungi
        '
        Me.BTN_Aggiungi.Location = New System.Drawing.Point(18, 254)
        Me.BTN_Aggiungi.Name = "BTN_Aggiungi"
        Me.BTN_Aggiungi.Size = New System.Drawing.Size(100, 30)
        Me.BTN_Aggiungi.TabIndex = 2
        Me.BTN_Aggiungi.Text = "Aggiungi Data"
        Me.BTN_Aggiungi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(101, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "USER:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_User
        '
        Me.TXT_User.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_User.Location = New System.Drawing.Point(39, 39)
        Me.TXT_User.Name = "TXT_User"
        Me.TXT_User.Size = New System.Drawing.Size(187, 20)
        Me.TXT_User.TabIndex = 4
        '
        'BTN_Rimuovi
        '
        Me.BTN_Rimuovi.Location = New System.Drawing.Point(145, 254)
        Me.BTN_Rimuovi.Name = "BTN_Rimuovi"
        Me.BTN_Rimuovi.Size = New System.Drawing.Size(100, 30)
        Me.BTN_Rimuovi.TabIndex = 5
        Me.BTN_Rimuovi.Text = "Rimuovi Data"
        Me.BTN_Rimuovi.UseVisualStyleBackColor = True
        '
        'TXT_Data
        '
        Me.TXT_Data.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_Data.Location = New System.Drawing.Point(300, 282)
        Me.TXT_Data.Name = "TXT_Data"
        Me.TXT_Data.ReadOnly = True
        Me.TXT_Data.Size = New System.Drawing.Size(114, 20)
        Me.TXT_Data.TabIndex = 6
        Me.TXT_Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(298, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "La data migliore è:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_Calcola
        '
        Me.BTN_Calcola.Location = New System.Drawing.Point(28, 294)
        Me.BTN_Calcola.Name = "BTN_Calcola"
        Me.BTN_Calcola.Size = New System.Drawing.Size(70, 70)
        Me.BTN_Calcola.TabIndex = 8
        Me.BTN_Calcola.Text = "Trova la data migliore"
        Me.BTN_Calcola.UseVisualStyleBackColor = True
        '
        'LIST_User
        '
        Me.LIST_User.FormattingEnabled = True
        Me.LIST_User.HorizontalScrollbar = True
        Me.LIST_User.Location = New System.Drawing.Point(435, 282)
        Me.LIST_User.Name = "LIST_User"
        Me.LIST_User.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LIST_User.Size = New System.Drawing.Size(172, 82)
        Me.LIST_User.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(458, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Non saranno presenti:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(298, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Saranno presenti:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(395, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Registrate n°"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_registri
        '
        Me.TXT_registri.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_registri.Location = New System.Drawing.Point(462, 226)
        Me.TXT_registri.Name = "TXT_registri"
        Me.TXT_registri.ReadOnly = True
        Me.TXT_registri.Size = New System.Drawing.Size(21, 20)
        Me.TXT_registri.TabIndex = 13
        Me.TXT_registri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(484, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "persone"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(339, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "persone"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_persone
        '
        Me.TXT_persone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_persone.Location = New System.Drawing.Point(317, 341)
        Me.TXT_persone.Name = "TXT_persone"
        Me.TXT_persone.ReadOnly = True
        Me.TXT_persone.Size = New System.Drawing.Size(21, 20)
        Me.TXT_persone.TabIndex = 15
        Me.TXT_persone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTN_DataSel
        '
        Me.BTN_DataSel.Location = New System.Drawing.Point(156, 294)
        Me.BTN_DataSel.Name = "BTN_DataSel"
        Me.BTN_DataSel.Size = New System.Drawing.Size(70, 70)
        Me.BTN_DataSel.TabIndex = 17
        Me.BTN_DataSel.Text = "Controlla la data selezionata"
        Me.BTN_DataSel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(640, 382)
        Me.Controls.Add(Me.BTN_DataSel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_persone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_registri)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LIST_User)
        Me.Controls.Add(Me.BTN_Calcola)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_Data)
        Me.Controls.Add(Me.BTN_Rimuovi)
        Me.Controls.Add(Me.TXT_User)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_Aggiungi)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.CALENDAR)
        Me.Name = "Form1"
        Me.Text = "Pianificazione eventi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CALENDAR As MonthCalendar
    Friend WithEvents ListView1 As ListView
    Friend WithEvents BTN_Aggiungi As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_User As TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents BTN_Rimuovi As Button
    Friend WithEvents TXT_Data As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Calcola As Button
    Friend WithEvents LIST_User As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_registri As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_persone As TextBox
    Friend WithEvents BTN_DataSel As Button
End Class
