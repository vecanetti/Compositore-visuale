<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ButtonTornio = New System.Windows.Forms.Button()
        Me.ButtonFresa = New System.Windows.Forms.Button()
        Me.ButtonStampante3DZ = New System.Windows.Forms.Button()
        Me.ButtonRiapriUltimoLavoro = New System.Windows.Forms.Button()
        Me.ButtonCartella = New System.Windows.Forms.Button()
        Me.TextboxCartella = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ButtonPraticaVuota = New System.Windows.Forms.Button()
        Me.ButtonPraticaGenerica = New System.Windows.Forms.Button()
        Me.ButtonImportaDaApp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonTornio
        '
        Me.ButtonTornio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonTornio.Location = New System.Drawing.Point(4, 277)
        Me.ButtonTornio.Name = "ButtonTornio"
        Me.ButtonTornio.Size = New System.Drawing.Size(328, 33)
        Me.ButtonTornio.TabIndex = 0
        Me.ButtonTornio.Text = "Tornio"
        Me.ButtonTornio.UseVisualStyleBackColor = True
        '
        'ButtonFresa
        '
        Me.ButtonFresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFresa.Location = New System.Drawing.Point(4, 316)
        Me.ButtonFresa.Name = "ButtonFresa"
        Me.ButtonFresa.Size = New System.Drawing.Size(328, 33)
        Me.ButtonFresa.TabIndex = 1
        Me.ButtonFresa.Text = "Fresa"
        Me.ButtonFresa.UseVisualStyleBackColor = True
        '
        'ButtonStampante3DZ
        '
        Me.ButtonStampante3DZ.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonStampante3DZ.Location = New System.Drawing.Point(4, 355)
        Me.ButtonStampante3DZ.Name = "ButtonStampante3DZ"
        Me.ButtonStampante3DZ.Size = New System.Drawing.Size(328, 33)
        Me.ButtonStampante3DZ.TabIndex = 2
        Me.ButtonStampante3DZ.Text = "Stampante 3D Markforged (3DZ)"
        Me.ButtonStampante3DZ.UseVisualStyleBackColor = True
        '
        'ButtonRiapriUltimoLavoro
        '
        Me.ButtonRiapriUltimoLavoro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRiapriUltimoLavoro.Location = New System.Drawing.Point(4, 42)
        Me.ButtonRiapriUltimoLavoro.Name = "ButtonRiapriUltimoLavoro"
        Me.ButtonRiapriUltimoLavoro.Size = New System.Drawing.Size(328, 33)
        Me.ButtonRiapriUltimoLavoro.TabIndex = 3
        Me.ButtonRiapriUltimoLavoro.Text = "Riapri l'ultimo lavoro salvato"
        Me.ButtonRiapriUltimoLavoro.UseVisualStyleBackColor = True
        '
        'ButtonCartella
        '
        Me.ButtonCartella.Location = New System.Drawing.Point(4, 3)
        Me.ButtonCartella.Name = "ButtonCartella"
        Me.ButtonCartella.Size = New System.Drawing.Size(58, 33)
        Me.ButtonCartella.TabIndex = 9
        Me.ButtonCartella.Text = "Cartella"
        Me.ButtonCartella.UseVisualStyleBackColor = True
        '
        'TextboxCartella
        '
        Me.TextboxCartella.Location = New System.Drawing.Point(68, 10)
        Me.TextboxCartella.Name = "TextboxCartella"
        Me.TextboxCartella.Size = New System.Drawing.Size(264, 20)
        Me.TextboxCartella.TabIndex = 8
        '
        'ButtonPraticaVuota
        '
        Me.ButtonPraticaVuota.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPraticaVuota.Location = New System.Drawing.Point(4, 81)
        Me.ButtonPraticaVuota.Name = "ButtonPraticaVuota"
        Me.ButtonPraticaVuota.Size = New System.Drawing.Size(328, 33)
        Me.ButtonPraticaVuota.TabIndex = 10
        Me.ButtonPraticaVuota.Text = "Pratica vuota"
        Me.ButtonPraticaVuota.UseVisualStyleBackColor = True
        '
        'ButtonPraticaGenerica
        '
        Me.ButtonPraticaGenerica.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonPraticaGenerica.Location = New System.Drawing.Point(4, 120)
        Me.ButtonPraticaGenerica.Name = "ButtonPraticaGenerica"
        Me.ButtonPraticaGenerica.Size = New System.Drawing.Size(328, 33)
        Me.ButtonPraticaGenerica.TabIndex = 11
        Me.ButtonPraticaGenerica.Text = "Pratica generica"
        Me.ButtonPraticaGenerica.UseVisualStyleBackColor = True
        '
        'ButtonImportaDaApp
        '
        Me.ButtonImportaDaApp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonImportaDaApp.Location = New System.Drawing.Point(4, 414)
        Me.ButtonImportaDaApp.Name = "ButtonImportaDaApp"
        Me.ButtonImportaDaApp.Size = New System.Drawing.Size(328, 33)
        Me.ButtonImportaDaApp.TabIndex = 12
        Me.ButtonImportaDaApp.Text = "Importa foto da App"
        Me.ButtonImportaDaApp.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 450)
        Me.Controls.Add(Me.ButtonImportaDaApp)
        Me.Controls.Add(Me.ButtonPraticaGenerica)
        Me.Controls.Add(Me.ButtonPraticaVuota)
        Me.Controls.Add(Me.ButtonCartella)
        Me.Controls.Add(Me.TextboxCartella)
        Me.Controls.Add(Me.ButtonRiapriUltimoLavoro)
        Me.Controls.Add(Me.ButtonStampante3DZ)
        Me.Controls.Add(Me.ButtonFresa)
        Me.Controls.Add(Me.ButtonTornio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Compositore visuale: preset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonTornio As Button
    Friend WithEvents ButtonFresa As Button
    Friend WithEvents ButtonStampante3DZ As Button
    Friend WithEvents ButtonRiapriUltimoLavoro As Button
    Friend WithEvents ButtonCartella As Button
    Friend WithEvents TextboxCartella As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ButtonPraticaVuota As Button
    Friend WithEvents ButtonPraticaGenerica As Button
    Friend WithEvents ButtonImportaDaApp As Button
End Class
