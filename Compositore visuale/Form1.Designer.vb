<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBoxScreenshot = New System.Windows.Forms.RichTextBox()
        Me.ListViewFoto = New System.Windows.Forms.ListView()
        Me.PictureBoxFotoSelezionata = New System.Windows.Forms.PictureBox()
        Me.TextboxCartella = New System.Windows.Forms.TextBox()
        Me.ImageList256 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonAggiorna = New System.Windows.Forms.Button()
        Me.ButtonApriPreset = New System.Windows.Forms.Button()
        Me.CheckBoxSalvataggioAutomatico = New System.Windows.Forms.CheckBox()
        Me.ButtonSalva = New System.Windows.Forms.Button()
        Me.ButtonCartella = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Documento = New System.Windows.Forms.TabPage()
        Me.Immagini = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBoxDimensioneIcone = New System.Windows.Forms.ComboBox()
        Me.Allegati = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.ButtonRinominaAllegati = New System.Windows.Forms.Button()
        Me.TextBoxRinominaAllegati = New System.Windows.Forms.TextBox()
        Me.DataGridViewAllegati = New System.Windows.Forms.DataGridView()
        Me.ColumnAllegato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDimensione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WebBrowserAllegati = New System.Windows.Forms.WebBrowser()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.Generale = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxLeasing = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBoxFornitore = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBoxCostoTotale = New System.Windows.Forms.TextBox()
        Me.ButtonPasteFotoCopertina = New System.Windows.Forms.Button()
        Me.TextBoxAltreInfoCategoria = New System.Windows.Forms.TextBox()
        Me.RichTextBoxValoreCespite = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.ComboBoxGruppo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxAnno = New System.Windows.Forms.TextBox()
        Me.PictureBoxFotoCopertina = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBoxDotazioni = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxMatricola = New System.Windows.Forms.TextBox()
        Me.TextBoxProduttore = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTipoInvestimento = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxModello = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBoxNotaio = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxPerito = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTipoRelazione = New System.Windows.Forms.ComboBox()
        Me.TextBoxDataPerizia = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxProtocolloPerizia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonPasteLogoAzienda = New System.Windows.Forms.Button()
        Me.TextBoxIndirizzoAzienda = New System.Windows.Forms.TextBox()
        Me.PictureBoxLogoAzienda = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxNomeAzienda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCF_PIVA = New System.Windows.Forms.TextBox()
        Me.Dettaglio = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ButtonGeneraleInserisciImmagine = New System.Windows.Forms.Button()
        Me.TextBoxGuidaDettaglio = New System.Windows.Forms.TextBox()
        Me.DataGridViewGenerale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonGeneraleRimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonGeneraleSpostaSu = New System.Windows.Forms.Button()
        Me.ButtonGeneraleSpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonGeneraleAggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxGeneraleDescrizione = New System.Windows.Forms.RichTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBoxGeneraleTitolo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBoxGenerale = New System.Windows.Forms.PictureBox()
        Me.TextBoxGeneraleDidascalia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxGeneraleTestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxGeneraleTestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.LabelDettaglio = New System.Windows.Forms.Label()
        Me.RO1 = New System.Windows.Forms.TabPage()
        Me.TextBoxRO1DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LabelRO1 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRO1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRO1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRO1RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRO1SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRO1SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRO1AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRO1Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBoxRO1Titolo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PictureBoxRO1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRO1Didascalia = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ButtonRO1InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO1TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO1TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RO2 = New System.Windows.Forms.TabPage()
        Me.TextBoxRO2DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LabelRO2 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRO2 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRO2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRO2RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRO2SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRO2SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRO2AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRO2Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBoxRO2Titolo = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.PictureBoxRO2 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRO2Didascalia = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ButtonRO2InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO2TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO2TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RO3 = New System.Windows.Forms.TabPage()
        Me.TextBoxRO3DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LabelRO3 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRO3 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRO3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRO3RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRO3SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRO3SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRO3AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRO3Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBoxRO3Titolo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureBoxRO3 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRO3Didascalia = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ButtonRO3InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO3TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO3TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RO4 = New System.Windows.Forms.TabPage()
        Me.TextBoxRO4DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.LabelRO4 = New System.Windows.Forms.Label()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRO4 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRO4 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRO4RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRO4SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRO4SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRO4AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRO4Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBoxRO4Titolo = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PictureBoxRO4 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRO4Didascalia = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.ButtonRO4InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO4TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO4TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RO5 = New System.Windows.Forms.TabPage()
        Me.TextBoxRO5DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LabelRO5 = New System.Windows.Forms.Label()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRO5 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRO5 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRO5RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRO5SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRO5SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRO5AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRO5Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TextBoxRO5Titolo = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.PictureBoxRO5 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRO5Didascalia = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.ButtonRO5InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO5TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRO5TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RU1 = New System.Windows.Forms.TabPage()
        Me.TextBoxRU1DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.CheckBoxRU1 = New System.Windows.Forms.CheckBox()
        Me.LabelRU1 = New System.Windows.Forms.Label()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRU1 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRU1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRU1RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRU1SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRU1SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRU1AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRU1Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.TextBoxRU1Titolo = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.PictureBoxRU1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRU1Didascalia = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ButtonRU1InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRU1TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRU1TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RU2 = New System.Windows.Forms.TabPage()
        Me.TextBoxRU2DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.CheckBoxRU2 = New System.Windows.Forms.CheckBox()
        Me.LabelRU2 = New System.Windows.Forms.Label()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRU2 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRU2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRU2RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRU2SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRU2SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRU2AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRU2Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.TextBoxRU2Titolo = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.PictureBoxRU2 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRU2Didascalia = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ButtonRU2InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRU2TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRU2TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.RU3 = New System.Windows.Forms.TabPage()
        Me.TextBoxRU3DettaglioPerizia = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.CheckBoxRU3 = New System.Windows.Forms.CheckBox()
        Me.LabelRU3 = New System.Windows.Forms.Label()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.TextBoxGuidaRU3 = New System.Windows.Forms.TextBox()
        Me.DataGridViewRU3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonRU3RimuoviSezione = New System.Windows.Forms.Button()
        Me.ButtonRU3SpostaSu = New System.Windows.Forms.Button()
        Me.ButtonRU3SpostaGiu = New System.Windows.Forms.Button()
        Me.ButtonRU3AggiungiSezione = New System.Windows.Forms.Button()
        Me.RichTextBoxRU3Descrizione = New System.Windows.Forms.RichTextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.TextBoxRU3Titolo = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.PictureBoxRU3 = New System.Windows.Forms.PictureBox()
        Me.TextBoxRU3Didascalia = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ButtonRU3InserisciImmagine = New System.Windows.Forms.Button()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRU3TestoFinale = New System.Windows.Forms.RichTextBox()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxRU3TestoIniziale = New System.Windows.Forms.RichTextBox()
        Me.Perizia = New System.Windows.Forms.TabPage()
        Me.ButtonSalvaPerizia = New System.Windows.Forms.Button()
        Me.ButtonGeneraPerizia = New System.Windows.Forms.Button()
        Me.RichTextBoxPerizia = New System.Windows.Forms.RichTextBox()
        Me.Relazione = New System.Windows.Forms.TabPage()
        Me.RichTextBoxRU3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRU2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRU1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRO5 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRO4 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRO3 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRO2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxRO1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBoxDettaglio = New System.Windows.Forms.RichTextBox()
        Me.ButtonSalvaRelazione = New System.Windows.Forms.Button()
        Me.ButtonGeneraRelazione = New System.Windows.Forms.Button()
        Me.RichTextBoxRelazione = New System.Windows.Forms.RichTextBox()
        Me.ImageList64 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList128 = New System.Windows.Forms.ImageList(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerSalvataggioAutomatico = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxFotoSelezionata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Documento.SuspendLayout()
        Me.Immagini.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Allegati.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.DataGridViewAllegati, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.Generale.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxFotoCopertina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxLogoAzienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Dettaglio.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridViewGenerale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxGenerale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.RO1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridViewRO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.RO2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridViewRO2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRO2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.RO3.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.DataGridViewRO3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRO3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.RO4.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.DataGridViewRO4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRO4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.RO5.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        CType(Me.DataGridViewRO5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRO5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.RU1.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        CType(Me.DataGridViewRU1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRU1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.RU2.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        CType(Me.DataGridViewRU2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRU2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.RU3.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        CType(Me.DataGridViewRU3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxRU3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.Perizia.SuspendLayout()
        Me.Relazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBoxScreenshot
        '
        Me.RichTextBoxScreenshot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxScreenshot.AutoWordSelection = True
        Me.RichTextBoxScreenshot.EnableAutoDragDrop = True
        Me.RichTextBoxScreenshot.Location = New System.Drawing.Point(4, 6)
        Me.RichTextBoxScreenshot.Name = "RichTextBoxScreenshot"
        Me.RichTextBoxScreenshot.ShowSelectionMargin = True
        Me.RichTextBoxScreenshot.Size = New System.Drawing.Size(569, 881)
        Me.RichTextBoxScreenshot.TabIndex = 0
        Me.RichTextBoxScreenshot.Text = ""
        '
        'ListViewFoto
        '
        Me.ListViewFoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewFoto.HideSelection = False
        Me.ListViewFoto.Location = New System.Drawing.Point(3, 3)
        Me.ListViewFoto.MultiSelect = False
        Me.ListViewFoto.Name = "ListViewFoto"
        Me.ListViewFoto.Size = New System.Drawing.Size(561, 448)
        Me.ListViewFoto.TabIndex = 0
        Me.ListViewFoto.Tag = ""
        Me.ListViewFoto.UseCompatibleStateImageBehavior = False
        '
        'PictureBoxFotoSelezionata
        '
        Me.PictureBoxFotoSelezionata.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxFotoSelezionata.Name = "PictureBoxFotoSelezionata"
        Me.PictureBoxFotoSelezionata.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxFotoSelezionata.TabIndex = 2
        Me.PictureBoxFotoSelezionata.TabStop = False
        '
        'TextboxCartella
        '
        Me.TextboxCartella.Location = New System.Drawing.Point(73, 12)
        Me.TextboxCartella.Name = "TextboxCartella"
        Me.TextboxCartella.Size = New System.Drawing.Size(268, 20)
        Me.TextboxCartella.TabIndex = 3
        '
        'ImageList256
        '
        Me.ImageList256.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList256.ImageSize = New System.Drawing.Size(256, 256)
        Me.ImageList256.TransparentColor = System.Drawing.Color.Transparent
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonAggiorna)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonApriPreset)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckBoxSalvataggioAutomatico)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSalva)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCartella)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextboxCartella)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1266, 961)
        Me.SplitContainer1.SplitterDistance = 593
        Me.SplitContainer1.TabIndex = 6
        '
        'ButtonAggiorna
        '
        Me.ButtonAggiorna.Location = New System.Drawing.Point(347, 10)
        Me.ButtonAggiorna.Name = "ButtonAggiorna"
        Me.ButtonAggiorna.Size = New System.Drawing.Size(58, 23)
        Me.ButtonAggiorna.TabIndex = 11
        Me.ButtonAggiorna.Text = "Aggiorna"
        Me.ButtonAggiorna.UseVisualStyleBackColor = True
        '
        'ButtonApriPreset
        '
        Me.ButtonApriPreset.Location = New System.Drawing.Point(411, 10)
        Me.ButtonApriPreset.Name = "ButtonApriPreset"
        Me.ButtonApriPreset.Size = New System.Drawing.Size(47, 23)
        Me.ButtonApriPreset.TabIndex = 10
        Me.ButtonApriPreset.Text = "Preset"
        Me.ButtonApriPreset.UseVisualStyleBackColor = True
        '
        'CheckBoxSalvataggioAutomatico
        '
        Me.CheckBoxSalvataggioAutomatico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxSalvataggioAutomatico.AutoSize = True
        Me.CheckBoxSalvataggioAutomatico.Checked = True
        Me.CheckBoxSalvataggioAutomatico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSalvataggioAutomatico.Location = New System.Drawing.Point(464, 14)
        Me.CheckBoxSalvataggioAutomatico.Name = "CheckBoxSalvataggioAutomatico"
        Me.CheckBoxSalvataggioAutomatico.Size = New System.Drawing.Size(73, 17)
        Me.CheckBoxSalvataggioAutomatico.TabIndex = 9
        Me.CheckBoxSalvataggioAutomatico.Text = "AutoSave"
        Me.CheckBoxSalvataggioAutomatico.UseVisualStyleBackColor = True
        '
        'ButtonSalva
        '
        Me.ButtonSalva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSalva.Location = New System.Drawing.Point(543, 10)
        Me.ButtonSalva.Name = "ButtonSalva"
        Me.ButtonSalva.Size = New System.Drawing.Size(43, 23)
        Me.ButtonSalva.TabIndex = 8
        Me.ButtonSalva.Text = "Salva"
        Me.ButtonSalva.UseVisualStyleBackColor = True
        '
        'ButtonCartella
        '
        Me.ButtonCartella.Location = New System.Drawing.Point(9, 10)
        Me.ButtonCartella.Name = "ButtonCartella"
        Me.ButtonCartella.Size = New System.Drawing.Size(58, 23)
        Me.ButtonCartella.TabIndex = 7
        Me.ButtonCartella.Text = "Cartella"
        Me.ButtonCartella.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Documento)
        Me.TabControl1.Controls.Add(Me.Immagini)
        Me.TabControl1.Controls.Add(Me.Allegati)
        Me.TabControl1.Location = New System.Drawing.Point(3, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(3, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(587, 909)
        Me.TabControl1.TabIndex = 0
        '
        'Documento
        '
        Me.Documento.Controls.Add(Me.RichTextBoxScreenshot)
        Me.Documento.Location = New System.Drawing.Point(4, 22)
        Me.Documento.Name = "Documento"
        Me.Documento.Padding = New System.Windows.Forms.Padding(3)
        Me.Documento.Size = New System.Drawing.Size(579, 883)
        Me.Documento.TabIndex = 0
        Me.Documento.Text = "Documento"
        Me.Documento.UseVisualStyleBackColor = True
        '
        'Immagini
        '
        Me.Immagini.Controls.Add(Me.SplitContainer2)
        Me.Immagini.Location = New System.Drawing.Point(4, 22)
        Me.Immagini.Name = "Immagini"
        Me.Immagini.Padding = New System.Windows.Forms.Padding(3)
        Me.Immagini.Size = New System.Drawing.Size(579, 883)
        Me.Immagini.TabIndex = 1
        Me.Immagini.Text = "Immagini"
        Me.Immagini.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(6, 6)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ListViewFoto)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.NumericUpDown1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ComboBoxDimensioneIcone)
        Me.SplitContainer2.Size = New System.Drawing.Size(567, 872)
        Me.SplitContainer2.SplitterDistance = 454
        Me.SplitContainer2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Dimensione icone"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(436, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Zoom immagine"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown1.DecimalPlaces = 2
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Location = New System.Drawing.Point(520, 4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(44, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.PictureBoxFotoSelezionata)
        Me.Panel1.Location = New System.Drawing.Point(3, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(561, 381)
        Me.Panel1.TabIndex = 0
        '
        'ComboBoxDimensioneIcone
        '
        Me.ComboBoxDimensioneIcone.FormattingEnabled = True
        Me.ComboBoxDimensioneIcone.Items.AddRange(New Object() {"Grande", "Media", "Piccola"})
        Me.ComboBoxDimensioneIcone.Location = New System.Drawing.Point(100, 3)
        Me.ComboBoxDimensioneIcone.Name = "ComboBoxDimensioneIcone"
        Me.ComboBoxDimensioneIcone.Size = New System.Drawing.Size(60, 21)
        Me.ComboBoxDimensioneIcone.TabIndex = 1
        '
        'Allegati
        '
        Me.Allegati.Controls.Add(Me.SplitContainer3)
        Me.Allegati.Location = New System.Drawing.Point(4, 22)
        Me.Allegati.Name = "Allegati"
        Me.Allegati.Size = New System.Drawing.Size(579, 883)
        Me.Allegati.TabIndex = 2
        Me.Allegati.Text = "Allegati"
        Me.Allegati.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.ButtonRinominaAllegati)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TextBoxRinominaAllegati)
        Me.SplitContainer3.Panel1.Controls.Add(Me.DataGridViewAllegati)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.WebBrowserAllegati)
        Me.SplitContainer3.Size = New System.Drawing.Size(579, 883)
        Me.SplitContainer3.SplitterDistance = 341
        Me.SplitContainer3.TabIndex = 0
        '
        'ButtonRinominaAllegati
        '
        Me.ButtonRinominaAllegati.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRinominaAllegati.Location = New System.Drawing.Point(4, 304)
        Me.ButtonRinominaAllegati.Name = "ButtonRinominaAllegati"
        Me.ButtonRinominaAllegati.Size = New System.Drawing.Size(133, 23)
        Me.ButtonRinominaAllegati.TabIndex = 2
        Me.ButtonRinominaAllegati.Text = "Rinomina selezionato"
        Me.ButtonRinominaAllegati.UseVisualStyleBackColor = True
        '
        'TextBoxRinominaAllegati
        '
        Me.TextBoxRinominaAllegati.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRinominaAllegati.Location = New System.Drawing.Point(143, 307)
        Me.TextBoxRinominaAllegati.Name = "TextBoxRinominaAllegati"
        Me.TextBoxRinominaAllegati.Size = New System.Drawing.Size(433, 20)
        Me.TextBoxRinominaAllegati.TabIndex = 1
        '
        'DataGridViewAllegati
        '
        Me.DataGridViewAllegati.AllowUserToAddRows = False
        Me.DataGridViewAllegati.AllowUserToDeleteRows = False
        Me.DataGridViewAllegati.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewAllegati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAllegati.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnAllegato, Me.ColumnDimensione})
        Me.DataGridViewAllegati.Location = New System.Drawing.Point(4, 3)
        Me.DataGridViewAllegati.Name = "DataGridViewAllegati"
        Me.DataGridViewAllegati.ReadOnly = True
        Me.DataGridViewAllegati.Size = New System.Drawing.Size(572, 298)
        Me.DataGridViewAllegati.TabIndex = 0
        '
        'ColumnAllegato
        '
        Me.ColumnAllegato.HeaderText = "Allegato"
        Me.ColumnAllegato.Name = "ColumnAllegato"
        Me.ColumnAllegato.ReadOnly = True
        Me.ColumnAllegato.Width = 300
        '
        'ColumnDimensione
        '
        Me.ColumnDimensione.HeaderText = "Dimensione"
        Me.ColumnDimensione.Name = "ColumnDimensione"
        Me.ColumnDimensione.ReadOnly = True
        Me.ColumnDimensione.Width = 80
        '
        'WebBrowserAllegati
        '
        Me.WebBrowserAllegati.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowserAllegati.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserAllegati.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserAllegati.Name = "WebBrowserAllegati"
        Me.WebBrowserAllegati.Size = New System.Drawing.Size(579, 538)
        Me.WebBrowserAllegati.TabIndex = 0
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.Generale)
        Me.TabControl2.Controls.Add(Me.Dettaglio)
        Me.TabControl2.Controls.Add(Me.RO1)
        Me.TabControl2.Controls.Add(Me.RO2)
        Me.TabControl2.Controls.Add(Me.RO3)
        Me.TabControl2.Controls.Add(Me.RO4)
        Me.TabControl2.Controls.Add(Me.RO5)
        Me.TabControl2.Controls.Add(Me.RU1)
        Me.TabControl2.Controls.Add(Me.RU2)
        Me.TabControl2.Controls.Add(Me.RU3)
        Me.TabControl2.Controls.Add(Me.Perizia)
        Me.TabControl2.Controls.Add(Me.Relazione)
        Me.TabControl2.Location = New System.Drawing.Point(3, 3)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Padding = New System.Drawing.Point(3, 3)
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(663, 945)
        Me.TabControl2.TabIndex = 0
        '
        'Generale
        '
        Me.Generale.AutoScroll = True
        Me.Generale.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.Generale.Controls.Add(Me.GroupBox3)
        Me.Generale.Controls.Add(Me.GroupBox2)
        Me.Generale.Controls.Add(Me.GroupBox1)
        Me.Generale.Location = New System.Drawing.Point(4, 22)
        Me.Generale.Name = "Generale"
        Me.Generale.Size = New System.Drawing.Size(655, 919)
        Me.Generale.TabIndex = 0
        Me.Generale.Text = "Generale"
        Me.Generale.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.CheckBoxLeasing)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.TextBoxFornitore)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.TextBoxCostoTotale)
        Me.GroupBox3.Controls.Add(Me.ButtonPasteFotoCopertina)
        Me.GroupBox3.Controls.Add(Me.TextBoxAltreInfoCategoria)
        Me.GroupBox3.Controls.Add(Me.RichTextBoxValoreCespite)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.ComboBoxCategoria)
        Me.GroupBox3.Controls.Add(Me.ComboBoxGruppo)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBoxAnno)
        Me.GroupBox3.Controls.Add(Me.PictureBoxFotoCopertina)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TextBoxDotazioni)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.TextBoxMatricola)
        Me.GroupBox3.Controls.Add(Me.TextBoxProduttore)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TextBoxTipoInvestimento)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TextBoxModello)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 355)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(651, 561)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Investimento"
        '
        'CheckBoxLeasing
        '
        Me.CheckBoxLeasing.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBoxLeasing.AutoSize = True
        Me.CheckBoxLeasing.Location = New System.Drawing.Point(582, 389)
        Me.CheckBoxLeasing.Name = "CheckBoxLeasing"
        Me.CheckBoxLeasing.Size = New System.Drawing.Size(63, 17)
        Me.CheckBoxLeasing.TabIndex = 35
        Me.CheckBoxLeasing.Text = "Leasing"
        Me.CheckBoxLeasing.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(313, 390)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Fornitore"
        '
        'TextBoxFornitore
        '
        Me.TextBoxFornitore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFornitore.Location = New System.Drawing.Point(367, 386)
        Me.TextBoxFornitore.Name = "TextBoxFornitore"
        Me.TextBoxFornitore.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxFornitore.TabIndex = 34
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 389)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(88, 13)
        Me.Label25.TabIndex = 31
        Me.Label25.Text = "Costo totale Euro"
        '
        'TextBoxCostoTotale
        '
        Me.TextBoxCostoTotale.Location = New System.Drawing.Point(98, 386)
        Me.TextBoxCostoTotale.Name = "TextBoxCostoTotale"
        Me.TextBoxCostoTotale.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxCostoTotale.TabIndex = 32
        '
        'ButtonPasteFotoCopertina
        '
        Me.ButtonPasteFotoCopertina.Location = New System.Drawing.Point(6, 207)
        Me.ButtonPasteFotoCopertina.Name = "ButtonPasteFotoCopertina"
        Me.ButtonPasteFotoCopertina.Size = New System.Drawing.Size(86, 23)
        Me.ButtonPasteFotoCopertina.TabIndex = 30
        Me.ButtonPasteFotoCopertina.Text = "Foto copertina"
        Me.ButtonPasteFotoCopertina.UseVisualStyleBackColor = True
        '
        'TextBoxAltreInfoCategoria
        '
        Me.TextBoxAltreInfoCategoria.AcceptsReturn = True
        Me.TextBoxAltreInfoCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAltreInfoCategoria.Location = New System.Drawing.Point(98, 320)
        Me.TextBoxAltreInfoCategoria.Multiline = True
        Me.TextBoxAltreInfoCategoria.Name = "TextBoxAltreInfoCategoria"
        Me.TextBoxAltreInfoCategoria.Size = New System.Drawing.Size(547, 60)
        Me.TextBoxAltreInfoCategoria.TabIndex = 29
        Me.TextBoxAltreInfoCategoria.Text = "Es. se settore agricolo citare la Norma UNI-PdR 91-2020, se macchina semplice sen" &
    "za part program citare la Circolare MiSE n . 295485 del 01 agosto 2018"
        '
        'RichTextBoxValoreCespite
        '
        Me.RichTextBoxValoreCespite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxValoreCespite.Location = New System.Drawing.Point(98, 412)
        Me.RichTextBoxValoreCespite.Name = "RichTextBoxValoreCespite"
        Me.RichTextBoxValoreCespite.Size = New System.Drawing.Size(547, 143)
        Me.RichTextBoxValoreCespite.TabIndex = 28
        Me.RichTextBoxValoreCespite.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 460)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(78, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Dettaglio costo"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 341)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Altre info"
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(98, 293)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(547, 21)
        Me.ComboBoxCategoria.TabIndex = 23
        '
        'ComboBoxGruppo
        '
        Me.ComboBoxGruppo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxGruppo.FormattingEnabled = True
        Me.ComboBoxGruppo.Items.AddRange(New Object() {"1. Beni strumentali il cui funzionamento è controllato da sistemi computerizzati " &
                "o gestito tramite opportuni sensori e azionamenti", "2. Sistemi per l’assicurazione della qualità e della sostenibilità", "3. Dispositivi per l’interazione uomo macchina e per il miglioramento dell’ergono" &
                "mia e della sicurezza del posto di lavoro in logica «4.0»"})
        Me.ComboBoxGruppo.Location = New System.Drawing.Point(98, 265)
        Me.ComboBoxGruppo.Name = "ComboBoxGruppo"
        Me.ComboBoxGruppo.Size = New System.Drawing.Size(547, 21)
        Me.ComboBoxGruppo.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 296)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Categoria"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 268)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Gruppo"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Anno"
        '
        'TextBoxAnno
        '
        Me.TextBoxAnno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxAnno.Location = New System.Drawing.Point(98, 123)
        Me.TextBoxAnno.Name = "TextBoxAnno"
        Me.TextBoxAnno.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxAnno.TabIndex = 19
        '
        'PictureBoxFotoCopertina
        '
        Me.PictureBoxFotoCopertina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxFotoCopertina.Location = New System.Drawing.Point(98, 176)
        Me.PictureBoxFotoCopertina.Name = "PictureBoxFotoCopertina"
        Me.PictureBoxFotoCopertina.Size = New System.Drawing.Size(547, 83)
        Me.PictureBoxFotoCopertina.TabIndex = 17
        Me.PictureBoxFotoCopertina.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 153)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Dotazioni"
        '
        'TextBoxDotazioni
        '
        Me.TextBoxDotazioni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDotazioni.Location = New System.Drawing.Point(98, 150)
        Me.TextBoxDotazioni.Name = "TextBoxDotazioni"
        Me.TextBoxDotazioni.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxDotazioni.TabIndex = 15
        Me.TextBoxDotazioni.Text = "Es. Il tornio è dotato di un caricatore di barre di marca Meta con matricola XXX"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Matricola"
        '
        'TextBoxMatricola
        '
        Me.TextBoxMatricola.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMatricola.Location = New System.Drawing.Point(98, 97)
        Me.TextBoxMatricola.Name = "TextBoxMatricola"
        Me.TextBoxMatricola.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxMatricola.TabIndex = 13
        '
        'TextBoxProduttore
        '
        Me.TextBoxProduttore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProduttore.Location = New System.Drawing.Point(98, 45)
        Me.TextBoxProduttore.Name = "TextBoxProduttore"
        Me.TextBoxProduttore.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxProduttore.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tipologia"
        '
        'TextBoxTipoInvestimento
        '
        Me.TextBoxTipoInvestimento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTipoInvestimento.Location = New System.Drawing.Point(98, 19)
        Me.TextBoxTipoInvestimento.Name = "TextBoxTipoInvestimento"
        Me.TextBoxTipoInvestimento.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxTipoInvestimento.TabIndex = 7
        Me.TextBoxTipoInvestimento.Text = "Es. Centro di lavoro / Tornio / Impianto di lavaggio"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Produttore"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Modello"
        '
        'TextBoxModello
        '
        Me.TextBoxModello.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxModello.Location = New System.Drawing.Point(98, 71)
        Me.TextBoxModello.Name = "TextBoxModello"
        Me.TextBoxModello.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxModello.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TextBoxNotaio)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPerito)
        Me.GroupBox2.Controls.Add(Me.ComboBoxTipoRelazione)
        Me.GroupBox2.Controls.Add(Me.TextBoxDataPerizia)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBoxProtocolloPerizia)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 195)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 154)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo pratica"
        '
        'TextBoxNotaio
        '
        Me.TextBoxNotaio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNotaio.Location = New System.Drawing.Point(98, 123)
        Me.TextBoxNotaio.Name = "TextBoxNotaio"
        Me.TextBoxNotaio.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxNotaio.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 126)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Trib./Notaio"
        '
        'ComboBoxPerito
        '
        Me.ComboBoxPerito.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxPerito.FormattingEnabled = True
        Me.ComboBoxPerito.Items.AddRange(New Object() {"Ing. Marco Ciscato", "Ing. Volfango Emanuele Canetti"})
        Me.ComboBoxPerito.Location = New System.Drawing.Point(98, 45)
        Me.ComboBoxPerito.Name = "ComboBoxPerito"
        Me.ComboBoxPerito.Size = New System.Drawing.Size(547, 21)
        Me.ComboBoxPerito.TabIndex = 19
        '
        'ComboBoxTipoRelazione
        '
        Me.ComboBoxTipoRelazione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTipoRelazione.FormattingEnabled = True
        Me.ComboBoxTipoRelazione.Items.AddRange(New Object() {"Analisi tecnica a corredo dell'autocertificazione", "Analisi tecnica a corredo della perizia asseverata", "Analisi tecnica a corredo della perizia giurata"})
        Me.ComboBoxTipoRelazione.Location = New System.Drawing.Point(98, 17)
        Me.ComboBoxTipoRelazione.Name = "ComboBoxTipoRelazione"
        Me.ComboBoxTipoRelazione.Size = New System.Drawing.Size(547, 21)
        Me.ComboBoxTipoRelazione.TabIndex = 18
        '
        'TextBoxDataPerizia
        '
        Me.TextBoxDataPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDataPerizia.Location = New System.Drawing.Point(98, 97)
        Me.TextBoxDataPerizia.Name = "TextBoxDataPerizia"
        Me.TextBoxDataPerizia.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxDataPerizia.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Data (Aggiorn)"
        '
        'TextBoxProtocolloPerizia
        '
        Me.TextBoxProtocolloPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxProtocolloPerizia.Location = New System.Drawing.Point(98, 71)
        Me.TextBoxProtocolloPerizia.Name = "TextBoxProtocolloPerizia"
        Me.TextBoxProtocolloPerizia.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxProtocolloPerizia.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Protocollo/Id"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Perito"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Tipo relazione"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonPasteLogoAzienda)
        Me.GroupBox1.Controls.Add(Me.TextBoxIndirizzoAzienda)
        Me.GroupBox1.Controls.Add(Me.PictureBoxLogoAzienda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomeAzienda)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxCF_PIVA)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 186)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dati Azienda"
        '
        'ButtonPasteLogoAzienda
        '
        Me.ButtonPasteLogoAzienda.Location = New System.Drawing.Point(6, 126)
        Me.ButtonPasteLogoAzienda.Name = "ButtonPasteLogoAzienda"
        Me.ButtonPasteLogoAzienda.Size = New System.Drawing.Size(86, 23)
        Me.ButtonPasteLogoAzienda.TabIndex = 11
        Me.ButtonPasteLogoAzienda.Text = "Logo azienda"
        Me.ButtonPasteLogoAzienda.UseVisualStyleBackColor = True
        '
        'TextBoxIndirizzoAzienda
        '
        Me.TextBoxIndirizzoAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIndirizzoAzienda.Location = New System.Drawing.Point(98, 41)
        Me.TextBoxIndirizzoAzienda.Name = "TextBoxIndirizzoAzienda"
        Me.TextBoxIndirizzoAzienda.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxIndirizzoAzienda.TabIndex = 3
        '
        'PictureBoxLogoAzienda
        '
        Me.PictureBoxLogoAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxLogoAzienda.Location = New System.Drawing.Point(98, 96)
        Me.PictureBoxLogoAzienda.Name = "PictureBoxLogoAzienda"
        Me.PictureBoxLogoAzienda.Size = New System.Drawing.Size(547, 83)
        Me.PictureBoxLogoAzienda.TabIndex = 10
        Me.PictureBoxLogoAzienda.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nome azienda"
        '
        'TextBoxNomeAzienda
        '
        Me.TextBoxNomeAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNomeAzienda.Location = New System.Drawing.Point(98, 15)
        Me.TextBoxNomeAzienda.Name = "TextBoxNomeAzienda"
        Me.TextBoxNomeAzienda.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxNomeAzienda.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Indirizzo sede"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "C.F./P.IVA"
        '
        'TextBoxCF_PIVA
        '
        Me.TextBoxCF_PIVA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCF_PIVA.Location = New System.Drawing.Point(98, 67)
        Me.TextBoxCF_PIVA.Name = "TextBoxCF_PIVA"
        Me.TextBoxCF_PIVA.Size = New System.Drawing.Size(547, 20)
        Me.TextBoxCF_PIVA.TabIndex = 5
        '
        'Dettaglio
        '
        Me.Dettaglio.AutoScroll = True
        Me.Dettaglio.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.Dettaglio.Controls.Add(Me.GroupBox6)
        Me.Dettaglio.Controls.Add(Me.GroupBox5)
        Me.Dettaglio.Controls.Add(Me.GroupBox4)
        Me.Dettaglio.Controls.Add(Me.LabelDettaglio)
        Me.Dettaglio.Location = New System.Drawing.Point(4, 22)
        Me.Dettaglio.Name = "Dettaglio"
        Me.Dettaglio.Size = New System.Drawing.Size(655, 919)
        Me.Dettaglio.TabIndex = 10
        Me.Dettaglio.Text = "Dettaglio"
        Me.Dettaglio.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.ButtonGeneraleInserisciImmagine)
        Me.GroupBox6.Controls.Add(Me.TextBoxGuidaDettaglio)
        Me.GroupBox6.Controls.Add(Me.DataGridViewGenerale)
        Me.GroupBox6.Controls.Add(Me.ButtonGeneraleRimuoviSezione)
        Me.GroupBox6.Controls.Add(Me.ButtonGeneraleSpostaSu)
        Me.GroupBox6.Controls.Add(Me.ButtonGeneraleSpostaGiu)
        Me.GroupBox6.Controls.Add(Me.ButtonGeneraleAggiungiSezione)
        Me.GroupBox6.Controls.Add(Me.RichTextBoxGeneraleDescrizione)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.TextBoxGeneraleTitolo)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.PictureBoxGenerale)
        Me.GroupBox6.Controls.Add(Me.TextBoxGeneraleDidascalia)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Corpo centrale"
        '
        'ButtonGeneraleInserisciImmagine
        '
        Me.ButtonGeneraleInserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonGeneraleInserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonGeneraleInserisciImmagine.Name = "ButtonGeneraleInserisciImmagine"
        Me.ButtonGeneraleInserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonGeneraleInserisciImmagine.TabIndex = 16
        Me.ButtonGeneraleInserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonGeneraleInserisciImmagine.UseVisualStyleBackColor = True
        '
        'TextBoxGuidaDettaglio
        '
        Me.TextBoxGuidaDettaglio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaDettaglio.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaDettaglio.Location = New System.Drawing.Point(298, 57)
        Me.TextBoxGuidaDettaglio.Multiline = True
        Me.TextBoxGuidaDettaglio.Name = "TextBoxGuidaDettaglio"
        Me.TextBoxGuidaDettaglio.ReadOnly = True
        Me.TextBoxGuidaDettaglio.Size = New System.Drawing.Size(215, 123)
        Me.TextBoxGuidaDettaglio.TabIndex = 5
        Me.TextBoxGuidaDettaglio.Visible = False
        '
        'DataGridViewGenerale
        '
        Me.DataGridViewGenerale.AllowUserToAddRows = False
        Me.DataGridViewGenerale.AllowUserToDeleteRows = False
        Me.DataGridViewGenerale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewGenerale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewGenerale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridViewGenerale.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewGenerale.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewGenerale.MultiSelect = False
        Me.DataGridViewGenerale.Name = "DataGridViewGenerale"
        Me.DataGridViewGenerale.RowHeadersVisible = False
        Me.DataGridViewGenerale.RowTemplate.Height = 128
        Me.DataGridViewGenerale.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewGenerale.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Immagine"
        Me.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 128
        '
        'Column2
        '
        Me.Column2.HeaderText = "Didascalia"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "Titolo"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descrizione"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "DescrizioneRTF"
        Me.Column5.Name = "Column5"
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "PercorsoImmagine"
        Me.Column6.Name = "Column6"
        Me.Column6.Visible = False
        '
        'ButtonGeneraleRimuoviSezione
        '
        Me.ButtonGeneraleRimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonGeneraleRimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonGeneraleRimuoviSezione.Name = "ButtonGeneraleRimuoviSezione"
        Me.ButtonGeneraleRimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonGeneraleRimuoviSezione.TabIndex = 14
        Me.ButtonGeneraleRimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonGeneraleRimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonGeneraleSpostaSu
        '
        Me.ButtonGeneraleSpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGeneraleSpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonGeneraleSpostaSu.Name = "ButtonGeneraleSpostaSu"
        Me.ButtonGeneraleSpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGeneraleSpostaSu.TabIndex = 13
        Me.ButtonGeneraleSpostaSu.Text = "Sposta sù"
        Me.ButtonGeneraleSpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonGeneraleSpostaGiu
        '
        Me.ButtonGeneraleSpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGeneraleSpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonGeneraleSpostaGiu.Name = "ButtonGeneraleSpostaGiu"
        Me.ButtonGeneraleSpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGeneraleSpostaGiu.TabIndex = 12
        Me.ButtonGeneraleSpostaGiu.Text = "Sposta giù"
        Me.ButtonGeneraleSpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonGeneraleAggiungiSezione
        '
        Me.ButtonGeneraleAggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonGeneraleAggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonGeneraleAggiungiSezione.Name = "ButtonGeneraleAggiungiSezione"
        Me.ButtonGeneraleAggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonGeneraleAggiungiSezione.TabIndex = 11
        Me.ButtonGeneraleAggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonGeneraleAggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxGeneraleDescrizione
        '
        Me.RichTextBoxGeneraleDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxGeneraleDescrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxGeneraleDescrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxGeneraleDescrizione.Name = "RichTextBoxGeneraleDescrizione"
        Me.RichTextBoxGeneraleDescrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxGeneraleDescrizione.TabIndex = 10
        Me.RichTextBoxGeneraleDescrizione.Text = ""
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(256, 406)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 13)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Descrizione"
        '
        'TextBoxGeneraleTitolo
        '
        Me.TextBoxGeneraleTitolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGeneraleTitolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxGeneraleTitolo.Name = "TextBoxGeneraleTitolo"
        Me.TextBoxGeneraleTitolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxGeneraleTitolo.TabIndex = 8
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(260, 367)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Titolo"
        '
        'PictureBoxGenerale
        '
        Me.PictureBoxGenerale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxGenerale.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxGenerale.Name = "PictureBoxGenerale"
        Me.PictureBoxGenerale.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxGenerale.TabIndex = 6
        Me.PictureBoxGenerale.TabStop = False
        '
        'TextBoxGeneraleDidascalia
        '
        Me.TextBoxGeneraleDidascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGeneraleDidascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxGeneraleDidascalia.Name = "TextBoxGeneraleDidascalia"
        Me.TextBoxGeneraleDidascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxGeneraleDidascalia.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 619)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Didascalia"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.RichTextBoxGeneraleTestoFinale)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 821)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Testo finale"
        '
        'RichTextBoxGeneraleTestoFinale
        '
        Me.RichTextBoxGeneraleTestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxGeneraleTestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxGeneraleTestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxGeneraleTestoFinale.Name = "RichTextBoxGeneraleTestoFinale"
        Me.RichTextBoxGeneraleTestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxGeneraleTestoFinale.TabIndex = 0
        Me.RichTextBoxGeneraleTestoFinale.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.RichTextBoxGeneraleTestoIniziale)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(642, 133)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Testo iniziale"
        '
        'RichTextBoxGeneraleTestoIniziale
        '
        Me.RichTextBoxGeneraleTestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxGeneraleTestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxGeneraleTestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxGeneraleTestoIniziale.Name = "RichTextBoxGeneraleTestoIniziale"
        Me.RichTextBoxGeneraleTestoIniziale.Size = New System.Drawing.Size(630, 108)
        Me.RichTextBoxGeneraleTestoIniziale.TabIndex = 0
        Me.RichTextBoxGeneraleTestoIniziale.Text = ""
        '
        'LabelDettaglio
        '
        Me.LabelDettaglio.AutoSize = True
        Me.LabelDettaglio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDettaglio.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelDettaglio.Location = New System.Drawing.Point(3, 5)
        Me.LabelDettaglio.Name = "LabelDettaglio"
        Me.LabelDettaglio.Size = New System.Drawing.Size(615, 18)
        Me.LabelDettaglio.TabIndex = 1
        Me.LabelDettaglio.Text = "Breve descrizione delle macchine inserite nel ciclo produttivo e foto identificat" &
    "ive"
        Me.LabelDettaglio.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RO1
        '
        Me.RO1.AutoScroll = True
        Me.RO1.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RO1.Controls.Add(Me.TextBoxRO1DettaglioPerizia)
        Me.RO1.Controls.Add(Me.Label26)
        Me.RO1.Controls.Add(Me.LabelRO1)
        Me.RO1.Controls.Add(Me.GroupBox7)
        Me.RO1.Controls.Add(Me.GroupBox8)
        Me.RO1.Controls.Add(Me.GroupBox9)
        Me.RO1.Location = New System.Drawing.Point(4, 22)
        Me.RO1.Name = "RO1"
        Me.RO1.Size = New System.Drawing.Size(655, 919)
        Me.RO1.TabIndex = 1
        Me.RO1.Text = "RO1"
        Me.RO1.UseVisualStyleBackColor = True
        '
        'TextBoxRO1DettaglioPerizia
        '
        Me.TextBoxRO1DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO1DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRO1DettaglioPerizia.Name = "TextBoxRO1DettaglioPerizia"
        Me.TextBoxRO1DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRO1DettaglioPerizia.TabIndex = 10
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(14, 29)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 13)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Dettaglio per perizia"
        '
        'LabelRO1
        '
        Me.LabelRO1.AutoSize = True
        Me.LabelRO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRO1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRO1.Location = New System.Drawing.Point(5, 5)
        Me.LabelRO1.Name = "LabelRO1"
        Me.LabelRO1.Size = New System.Drawing.Size(332, 18)
        Me.LabelRO1.TabIndex = 5
        Me.LabelRO1.Text = "RO1. Controllo per mezzo di CNC e/o PLC"
        Me.LabelRO1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.TextBoxGuidaRO1)
        Me.GroupBox7.Controls.Add(Me.DataGridViewRO1)
        Me.GroupBox7.Controls.Add(Me.ButtonRO1RimuoviSezione)
        Me.GroupBox7.Controls.Add(Me.ButtonRO1SpostaSu)
        Me.GroupBox7.Controls.Add(Me.ButtonRO1SpostaGiu)
        Me.GroupBox7.Controls.Add(Me.ButtonRO1AggiungiSezione)
        Me.GroupBox7.Controls.Add(Me.RichTextBoxRO1Descrizione)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.TextBoxRO1Titolo)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.PictureBoxRO1)
        Me.GroupBox7.Controls.Add(Me.TextBoxRO1Didascalia)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.ButtonRO1InserisciImmagine)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Corpo centrale"
        '
        'TextBoxGuidaRO1
        '
        Me.TextBoxGuidaRO1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRO1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRO1.Location = New System.Drawing.Point(9, 43)
        Me.TextBoxGuidaRO1.Multiline = True
        Me.TextBoxGuidaRO1.Name = "TextBoxGuidaRO1"
        Me.TextBoxGuidaRO1.ReadOnly = True
        Me.TextBoxGuidaRO1.Size = New System.Drawing.Size(616, 247)
        Me.TextBoxGuidaRO1.TabIndex = 5
        Me.TextBoxGuidaRO1.Visible = False
        '
        'DataGridViewRO1
        '
        Me.DataGridViewRO1.AllowUserToAddRows = False
        Me.DataGridViewRO1.AllowUserToDeleteRows = False
        Me.DataGridViewRO1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRO1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRO1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column7})
        Me.DataGridViewRO1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRO1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRO1.MultiSelect = False
        Me.DataGridViewRO1.Name = "DataGridViewRO1"
        Me.DataGridViewRO1.RowHeadersVisible = False
        Me.DataGridViewRO1.RowTemplate.Height = 128
        Me.DataGridViewRO1.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRO1.TabIndex = 15
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Immagine"
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 128
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "PercorsoImmagine"
        Me.Column7.Name = "Column7"
        Me.Column7.Visible = False
        '
        'ButtonRO1RimuoviSezione
        '
        Me.ButtonRO1RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO1RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRO1RimuoviSezione.Name = "ButtonRO1RimuoviSezione"
        Me.ButtonRO1RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO1RimuoviSezione.TabIndex = 14
        Me.ButtonRO1RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRO1RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRO1SpostaSu
        '
        Me.ButtonRO1SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO1SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRO1SpostaSu.Name = "ButtonRO1SpostaSu"
        Me.ButtonRO1SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO1SpostaSu.TabIndex = 13
        Me.ButtonRO1SpostaSu.Text = "Sposta sù"
        Me.ButtonRO1SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRO1SpostaGiu
        '
        Me.ButtonRO1SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO1SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRO1SpostaGiu.Name = "ButtonRO1SpostaGiu"
        Me.ButtonRO1SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO1SpostaGiu.TabIndex = 12
        Me.ButtonRO1SpostaGiu.Text = "Sposta giù"
        Me.ButtonRO1SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRO1AggiungiSezione
        '
        Me.ButtonRO1AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO1AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRO1AggiungiSezione.Name = "ButtonRO1AggiungiSezione"
        Me.ButtonRO1AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO1AggiungiSezione.TabIndex = 11
        Me.ButtonRO1AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRO1AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRO1Descrizione
        '
        Me.RichTextBoxRO1Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO1Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO1Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRO1Descrizione.Name = "RichTextBoxRO1Descrizione"
        Me.RichTextBoxRO1Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRO1Descrizione.TabIndex = 10
        Me.RichTextBoxRO1Descrizione.Text = ""
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(256, 406)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 13)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Descrizione"
        '
        'TextBoxRO1Titolo
        '
        Me.TextBoxRO1Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO1Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRO1Titolo.Name = "TextBoxRO1Titolo"
        Me.TextBoxRO1Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRO1Titolo.TabIndex = 8
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(260, 367)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Titolo"
        '
        'PictureBoxRO1
        '
        Me.PictureBoxRO1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRO1.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRO1.Name = "PictureBoxRO1"
        Me.PictureBoxRO1.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRO1.TabIndex = 6
        Me.PictureBoxRO1.TabStop = False
        '
        'TextBoxRO1Didascalia
        '
        Me.TextBoxRO1Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO1Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRO1Didascalia.Name = "TextBoxRO1Didascalia"
        Me.TextBoxRO1Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRO1Didascalia.TabIndex = 5
        '
        'Label29
        '
        Me.Label29.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 619)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Didascalia"
        '
        'ButtonRO1InserisciImmagine
        '
        Me.ButtonRO1InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO1InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRO1InserisciImmagine.Name = "ButtonRO1InserisciImmagine"
        Me.ButtonRO1InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO1InserisciImmagine.TabIndex = 0
        Me.ButtonRO1InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRO1InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.RichTextBoxRO1TestoFinale)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox8.TabIndex = 7
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Testo finale"
        '
        'RichTextBoxRO1TestoFinale
        '
        Me.RichTextBoxRO1TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO1TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO1TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO1TestoFinale.Name = "RichTextBoxRO1TestoFinale"
        Me.RichTextBoxRO1TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRO1TestoFinale.TabIndex = 0
        Me.RichTextBoxRO1TestoFinale.Text = ""
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.RichTextBoxRO1TestoIniziale)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Testo iniziale"
        '
        'RichTextBoxRO1TestoIniziale
        '
        Me.RichTextBoxRO1TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO1TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO1TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO1TestoIniziale.Name = "RichTextBoxRO1TestoIniziale"
        Me.RichTextBoxRO1TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRO1TestoIniziale.TabIndex = 0
        Me.RichTextBoxRO1TestoIniziale.Text = ""
        '
        'RO2
        '
        Me.RO2.AutoScroll = True
        Me.RO2.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RO2.Controls.Add(Me.TextBoxRO2DettaglioPerizia)
        Me.RO2.Controls.Add(Me.Label30)
        Me.RO2.Controls.Add(Me.LabelRO2)
        Me.RO2.Controls.Add(Me.GroupBox10)
        Me.RO2.Controls.Add(Me.GroupBox11)
        Me.RO2.Controls.Add(Me.GroupBox12)
        Me.RO2.Location = New System.Drawing.Point(4, 22)
        Me.RO2.Name = "RO2"
        Me.RO2.Size = New System.Drawing.Size(655, 919)
        Me.RO2.TabIndex = 2
        Me.RO2.Text = "RO2"
        Me.RO2.UseVisualStyleBackColor = True
        '
        'TextBoxRO2DettaglioPerizia
        '
        Me.TextBoxRO2DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO2DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRO2DettaglioPerizia.Name = "TextBoxRO2DettaglioPerizia"
        Me.TextBoxRO2DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRO2DettaglioPerizia.TabIndex = 12
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(14, 29)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 13)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Dettaglio per perizia"
        '
        'LabelRO2
        '
        Me.LabelRO2.AutoSize = True
        Me.LabelRO2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRO2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRO2.Location = New System.Drawing.Point(5, 5)
        Me.LabelRO2.Name = "LabelRO2"
        Me.LabelRO2.Size = New System.Drawing.Size(617, 18)
        Me.LabelRO2.TabIndex = 5
        Me.LabelRO2.Text = "RO2. Interconnessione con caricamento da remoto di istruzioni e/o part program"
        Me.LabelRO2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.TextBoxGuidaRO2)
        Me.GroupBox10.Controls.Add(Me.DataGridViewRO2)
        Me.GroupBox10.Controls.Add(Me.ButtonRO2RimuoviSezione)
        Me.GroupBox10.Controls.Add(Me.ButtonRO2SpostaSu)
        Me.GroupBox10.Controls.Add(Me.ButtonRO2SpostaGiu)
        Me.GroupBox10.Controls.Add(Me.ButtonRO2AggiungiSezione)
        Me.GroupBox10.Controls.Add(Me.RichTextBoxRO2Descrizione)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.TextBoxRO2Titolo)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.PictureBoxRO2)
        Me.GroupBox10.Controls.Add(Me.TextBoxRO2Didascalia)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.ButtonRO2InserisciImmagine)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox10.TabIndex = 8
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Corpo centrale"
        '
        'TextBoxGuidaRO2
        '
        Me.TextBoxGuidaRO2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRO2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRO2.Location = New System.Drawing.Point(18, 47)
        Me.TextBoxGuidaRO2.Multiline = True
        Me.TextBoxGuidaRO2.Name = "TextBoxGuidaRO2"
        Me.TextBoxGuidaRO2.ReadOnly = True
        Me.TextBoxGuidaRO2.Size = New System.Drawing.Size(606, 246)
        Me.TextBoxGuidaRO2.TabIndex = 5
        Me.TextBoxGuidaRO2.Visible = False
        '
        'DataGridViewRO2
        '
        Me.DataGridViewRO2.AllowUserToAddRows = False
        Me.DataGridViewRO2.AllowUserToDeleteRows = False
        Me.DataGridViewRO2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRO2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRO2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn2, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn33})
        Me.DataGridViewRO2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRO2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRO2.MultiSelect = False
        Me.DataGridViewRO2.Name = "DataGridViewRO2"
        Me.DataGridViewRO2.RowHeadersVisible = False
        Me.DataGridViewRO2.RowTemplate.Height = 128
        Me.DataGridViewRO2.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRO2.TabIndex = 15
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.HeaderText = "Immagine"
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Width = 128
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 300
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'ButtonRO2RimuoviSezione
        '
        Me.ButtonRO2RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO2RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRO2RimuoviSezione.Name = "ButtonRO2RimuoviSezione"
        Me.ButtonRO2RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO2RimuoviSezione.TabIndex = 14
        Me.ButtonRO2RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRO2RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRO2SpostaSu
        '
        Me.ButtonRO2SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO2SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRO2SpostaSu.Name = "ButtonRO2SpostaSu"
        Me.ButtonRO2SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO2SpostaSu.TabIndex = 13
        Me.ButtonRO2SpostaSu.Text = "Sposta sù"
        Me.ButtonRO2SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRO2SpostaGiu
        '
        Me.ButtonRO2SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO2SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRO2SpostaGiu.Name = "ButtonRO2SpostaGiu"
        Me.ButtonRO2SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO2SpostaGiu.TabIndex = 12
        Me.ButtonRO2SpostaGiu.Text = "Sposta giù"
        Me.ButtonRO2SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRO2AggiungiSezione
        '
        Me.ButtonRO2AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO2AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRO2AggiungiSezione.Name = "ButtonRO2AggiungiSezione"
        Me.ButtonRO2AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO2AggiungiSezione.TabIndex = 11
        Me.ButtonRO2AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRO2AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRO2Descrizione
        '
        Me.RichTextBoxRO2Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO2Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO2Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRO2Descrizione.Name = "RichTextBoxRO2Descrizione"
        Me.RichTextBoxRO2Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRO2Descrizione.TabIndex = 10
        Me.RichTextBoxRO2Descrizione.Text = ""
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(256, 406)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 13)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Descrizione"
        '
        'TextBoxRO2Titolo
        '
        Me.TextBoxRO2Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO2Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRO2Titolo.Name = "TextBoxRO2Titolo"
        Me.TextBoxRO2Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRO2Titolo.TabIndex = 8
        '
        'Label32
        '
        Me.Label32.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(260, 367)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(33, 13)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Titolo"
        '
        'PictureBoxRO2
        '
        Me.PictureBoxRO2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRO2.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRO2.Name = "PictureBoxRO2"
        Me.PictureBoxRO2.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRO2.TabIndex = 6
        Me.PictureBoxRO2.TabStop = False
        '
        'TextBoxRO2Didascalia
        '
        Me.TextBoxRO2Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO2Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRO2Didascalia.Name = "TextBoxRO2Didascalia"
        Me.TextBoxRO2Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRO2Didascalia.TabIndex = 5
        '
        'Label33
        '
        Me.Label33.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(6, 619)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 13)
        Me.Label33.TabIndex = 4
        Me.Label33.Text = "Didascalia"
        '
        'ButtonRO2InserisciImmagine
        '
        Me.ButtonRO2InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO2InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRO2InserisciImmagine.Name = "ButtonRO2InserisciImmagine"
        Me.ButtonRO2InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO2InserisciImmagine.TabIndex = 0
        Me.ButtonRO2InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRO2InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox11.Controls.Add(Me.RichTextBoxRO2TestoFinale)
        Me.GroupBox11.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox11.TabIndex = 7
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Testo finale"
        '
        'RichTextBoxRO2TestoFinale
        '
        Me.RichTextBoxRO2TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO2TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO2TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO2TestoFinale.Name = "RichTextBoxRO2TestoFinale"
        Me.RichTextBoxRO2TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRO2TestoFinale.TabIndex = 0
        Me.RichTextBoxRO2TestoFinale.Text = ""
        '
        'GroupBox12
        '
        Me.GroupBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox12.Controls.Add(Me.RichTextBoxRO2TestoIniziale)
        Me.GroupBox12.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox12.TabIndex = 6
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Testo iniziale"
        '
        'RichTextBoxRO2TestoIniziale
        '
        Me.RichTextBoxRO2TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO2TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO2TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO2TestoIniziale.Name = "RichTextBoxRO2TestoIniziale"
        Me.RichTextBoxRO2TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRO2TestoIniziale.TabIndex = 0
        Me.RichTextBoxRO2TestoIniziale.Text = ""
        '
        'RO3
        '
        Me.RO3.AutoScroll = True
        Me.RO3.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RO3.Controls.Add(Me.TextBoxRO3DettaglioPerizia)
        Me.RO3.Controls.Add(Me.Label34)
        Me.RO3.Controls.Add(Me.LabelRO3)
        Me.RO3.Controls.Add(Me.GroupBox13)
        Me.RO3.Controls.Add(Me.GroupBox14)
        Me.RO3.Controls.Add(Me.GroupBox15)
        Me.RO3.Location = New System.Drawing.Point(4, 22)
        Me.RO3.Name = "RO3"
        Me.RO3.Size = New System.Drawing.Size(655, 919)
        Me.RO3.TabIndex = 3
        Me.RO3.Text = "RO3"
        Me.RO3.UseVisualStyleBackColor = True
        '
        'TextBoxRO3DettaglioPerizia
        '
        Me.TextBoxRO3DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO3DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRO3DettaglioPerizia.Name = "TextBoxRO3DettaglioPerizia"
        Me.TextBoxRO3DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRO3DettaglioPerizia.TabIndex = 12
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(14, 29)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 13)
        Me.Label34.TabIndex = 11
        Me.Label34.Text = "Dettaglio per perizia"
        '
        'LabelRO3
        '
        Me.LabelRO3.AutoSize = True
        Me.LabelRO3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRO3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRO3.Location = New System.Drawing.Point(5, 5)
        Me.LabelRO3.Name = "LabelRO3"
        Me.LabelRO3.Size = New System.Drawing.Size(596, 18)
        Me.LabelRO3.TabIndex = 5
        Me.LabelRO3.Text = "RO3. Integrazione con il sistema logistico, la rete di fornitura o altre macchine" &
    ""
        Me.LabelRO3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox13
        '
        Me.GroupBox13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox13.Controls.Add(Me.TextBoxGuidaRO3)
        Me.GroupBox13.Controls.Add(Me.DataGridViewRO3)
        Me.GroupBox13.Controls.Add(Me.ButtonRO3RimuoviSezione)
        Me.GroupBox13.Controls.Add(Me.ButtonRO3SpostaSu)
        Me.GroupBox13.Controls.Add(Me.ButtonRO3SpostaGiu)
        Me.GroupBox13.Controls.Add(Me.ButtonRO3AggiungiSezione)
        Me.GroupBox13.Controls.Add(Me.RichTextBoxRO3Descrizione)
        Me.GroupBox13.Controls.Add(Me.Label35)
        Me.GroupBox13.Controls.Add(Me.TextBoxRO3Titolo)
        Me.GroupBox13.Controls.Add(Me.Label36)
        Me.GroupBox13.Controls.Add(Me.PictureBoxRO3)
        Me.GroupBox13.Controls.Add(Me.TextBoxRO3Didascalia)
        Me.GroupBox13.Controls.Add(Me.Label37)
        Me.GroupBox13.Controls.Add(Me.ButtonRO3InserisciImmagine)
        Me.GroupBox13.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox13.TabIndex = 8
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Corpo centrale"
        '
        'TextBoxGuidaRO3
        '
        Me.TextBoxGuidaRO3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRO3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRO3.Location = New System.Drawing.Point(27, 45)
        Me.TextBoxGuidaRO3.Multiline = True
        Me.TextBoxGuidaRO3.Name = "TextBoxGuidaRO3"
        Me.TextBoxGuidaRO3.ReadOnly = True
        Me.TextBoxGuidaRO3.Size = New System.Drawing.Size(598, 259)
        Me.TextBoxGuidaRO3.TabIndex = 5
        Me.TextBoxGuidaRO3.Visible = False
        '
        'DataGridViewRO3
        '
        Me.DataGridViewRO3.AllowUserToAddRows = False
        Me.DataGridViewRO3.AllowUserToDeleteRows = False
        Me.DataGridViewRO3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRO3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRO3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn3, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn34})
        Me.DataGridViewRO3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRO3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRO3.MultiSelect = False
        Me.DataGridViewRO3.Name = "DataGridViewRO3"
        Me.DataGridViewRO3.RowHeadersVisible = False
        Me.DataGridViewRO3.RowTemplate.Height = 128
        Me.DataGridViewRO3.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRO3.TabIndex = 15
        '
        'DataGridViewImageColumn3
        '
        Me.DataGridViewImageColumn3.HeaderText = "Immagine"
        Me.DataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Width = 128
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 300
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Visible = False
        '
        'ButtonRO3RimuoviSezione
        '
        Me.ButtonRO3RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO3RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRO3RimuoviSezione.Name = "ButtonRO3RimuoviSezione"
        Me.ButtonRO3RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO3RimuoviSezione.TabIndex = 14
        Me.ButtonRO3RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRO3RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRO3SpostaSu
        '
        Me.ButtonRO3SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO3SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRO3SpostaSu.Name = "ButtonRO3SpostaSu"
        Me.ButtonRO3SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO3SpostaSu.TabIndex = 13
        Me.ButtonRO3SpostaSu.Text = "Sposta sù"
        Me.ButtonRO3SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRO3SpostaGiu
        '
        Me.ButtonRO3SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO3SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRO3SpostaGiu.Name = "ButtonRO3SpostaGiu"
        Me.ButtonRO3SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO3SpostaGiu.TabIndex = 12
        Me.ButtonRO3SpostaGiu.Text = "Sposta giù"
        Me.ButtonRO3SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRO3AggiungiSezione
        '
        Me.ButtonRO3AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO3AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRO3AggiungiSezione.Name = "ButtonRO3AggiungiSezione"
        Me.ButtonRO3AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO3AggiungiSezione.TabIndex = 11
        Me.ButtonRO3AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRO3AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRO3Descrizione
        '
        Me.RichTextBoxRO3Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO3Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO3Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRO3Descrizione.Name = "RichTextBoxRO3Descrizione"
        Me.RichTextBoxRO3Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRO3Descrizione.TabIndex = 10
        Me.RichTextBoxRO3Descrizione.Text = ""
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(256, 406)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(62, 13)
        Me.Label35.TabIndex = 9
        Me.Label35.Text = "Descrizione"
        '
        'TextBoxRO3Titolo
        '
        Me.TextBoxRO3Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO3Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRO3Titolo.Name = "TextBoxRO3Titolo"
        Me.TextBoxRO3Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRO3Titolo.TabIndex = 8
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(260, 367)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(33, 13)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "Titolo"
        '
        'PictureBoxRO3
        '
        Me.PictureBoxRO3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRO3.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRO3.Name = "PictureBoxRO3"
        Me.PictureBoxRO3.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRO3.TabIndex = 6
        Me.PictureBoxRO3.TabStop = False
        '
        'TextBoxRO3Didascalia
        '
        Me.TextBoxRO3Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO3Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRO3Didascalia.Name = "TextBoxRO3Didascalia"
        Me.TextBoxRO3Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRO3Didascalia.TabIndex = 5
        '
        'Label37
        '
        Me.Label37.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 619)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 13)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "Didascalia"
        '
        'ButtonRO3InserisciImmagine
        '
        Me.ButtonRO3InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO3InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRO3InserisciImmagine.Name = "ButtonRO3InserisciImmagine"
        Me.ButtonRO3InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO3InserisciImmagine.TabIndex = 0
        Me.ButtonRO3InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRO3InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.Controls.Add(Me.RichTextBoxRO3TestoFinale)
        Me.GroupBox14.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox14.TabIndex = 7
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Testo finale"
        '
        'RichTextBoxRO3TestoFinale
        '
        Me.RichTextBoxRO3TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO3TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO3TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO3TestoFinale.Name = "RichTextBoxRO3TestoFinale"
        Me.RichTextBoxRO3TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRO3TestoFinale.TabIndex = 0
        Me.RichTextBoxRO3TestoFinale.Text = ""
        '
        'GroupBox15
        '
        Me.GroupBox15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox15.Controls.Add(Me.RichTextBoxRO3TestoIniziale)
        Me.GroupBox15.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox15.TabIndex = 6
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Testo iniziale"
        '
        'RichTextBoxRO3TestoIniziale
        '
        Me.RichTextBoxRO3TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO3TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO3TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO3TestoIniziale.Name = "RichTextBoxRO3TestoIniziale"
        Me.RichTextBoxRO3TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRO3TestoIniziale.TabIndex = 0
        Me.RichTextBoxRO3TestoIniziale.Text = ""
        '
        'RO4
        '
        Me.RO4.AutoScroll = True
        Me.RO4.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RO4.Controls.Add(Me.TextBoxRO4DettaglioPerizia)
        Me.RO4.Controls.Add(Me.Label38)
        Me.RO4.Controls.Add(Me.LabelRO4)
        Me.RO4.Controls.Add(Me.GroupBox16)
        Me.RO4.Controls.Add(Me.GroupBox17)
        Me.RO4.Controls.Add(Me.GroupBox18)
        Me.RO4.Location = New System.Drawing.Point(4, 22)
        Me.RO4.Name = "RO4"
        Me.RO4.Size = New System.Drawing.Size(655, 919)
        Me.RO4.TabIndex = 4
        Me.RO4.Text = "RO4"
        Me.RO4.UseVisualStyleBackColor = True
        '
        'TextBoxRO4DettaglioPerizia
        '
        Me.TextBoxRO4DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO4DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRO4DettaglioPerizia.Name = "TextBoxRO4DettaglioPerizia"
        Me.TextBoxRO4DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRO4DettaglioPerizia.TabIndex = 12
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(14, 29)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(100, 13)
        Me.Label38.TabIndex = 11
        Me.Label38.Text = "Dettaglio per perizia"
        '
        'LabelRO4
        '
        Me.LabelRO4.AutoSize = True
        Me.LabelRO4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRO4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRO4.Location = New System.Drawing.Point(5, 5)
        Me.LabelRO4.Name = "LabelRO4"
        Me.LabelRO4.Size = New System.Drawing.Size(437, 18)
        Me.LabelRO4.TabIndex = 5
        Me.LabelRO4.Text = "RO4. Interfaccia tra uomo e macchina semplici e intuitive"
        Me.LabelRO4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox16
        '
        Me.GroupBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox16.Controls.Add(Me.TextBoxGuidaRO4)
        Me.GroupBox16.Controls.Add(Me.DataGridViewRO4)
        Me.GroupBox16.Controls.Add(Me.ButtonRO4RimuoviSezione)
        Me.GroupBox16.Controls.Add(Me.ButtonRO4SpostaSu)
        Me.GroupBox16.Controls.Add(Me.ButtonRO4SpostaGiu)
        Me.GroupBox16.Controls.Add(Me.ButtonRO4AggiungiSezione)
        Me.GroupBox16.Controls.Add(Me.RichTextBoxRO4Descrizione)
        Me.GroupBox16.Controls.Add(Me.Label39)
        Me.GroupBox16.Controls.Add(Me.TextBoxRO4Titolo)
        Me.GroupBox16.Controls.Add(Me.Label40)
        Me.GroupBox16.Controls.Add(Me.PictureBoxRO4)
        Me.GroupBox16.Controls.Add(Me.TextBoxRO4Didascalia)
        Me.GroupBox16.Controls.Add(Me.Label41)
        Me.GroupBox16.Controls.Add(Me.ButtonRO4InserisciImmagine)
        Me.GroupBox16.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox16.TabIndex = 8
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Corpo centrale"
        '
        'TextBoxGuidaRO4
        '
        Me.TextBoxGuidaRO4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRO4.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRO4.Location = New System.Drawing.Point(22, 46)
        Me.TextBoxGuidaRO4.Multiline = True
        Me.TextBoxGuidaRO4.Name = "TextBoxGuidaRO4"
        Me.TextBoxGuidaRO4.ReadOnly = True
        Me.TextBoxGuidaRO4.Size = New System.Drawing.Size(602, 247)
        Me.TextBoxGuidaRO4.TabIndex = 5
        Me.TextBoxGuidaRO4.Visible = False
        '
        'DataGridViewRO4
        '
        Me.DataGridViewRO4.AllowUserToAddRows = False
        Me.DataGridViewRO4.AllowUserToDeleteRows = False
        Me.DataGridViewRO4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRO4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRO4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn4, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn35})
        Me.DataGridViewRO4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRO4.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRO4.MultiSelect = False
        Me.DataGridViewRO4.Name = "DataGridViewRO4"
        Me.DataGridViewRO4.RowHeadersVisible = False
        Me.DataGridViewRO4.RowTemplate.Height = 128
        Me.DataGridViewRO4.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRO4.TabIndex = 15
        '
        'DataGridViewImageColumn4
        '
        Me.DataGridViewImageColumn4.HeaderText = "Immagine"
        Me.DataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        Me.DataGridViewImageColumn4.Width = 128
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 300
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'ButtonRO4RimuoviSezione
        '
        Me.ButtonRO4RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO4RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRO4RimuoviSezione.Name = "ButtonRO4RimuoviSezione"
        Me.ButtonRO4RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO4RimuoviSezione.TabIndex = 14
        Me.ButtonRO4RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRO4RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRO4SpostaSu
        '
        Me.ButtonRO4SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO4SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRO4SpostaSu.Name = "ButtonRO4SpostaSu"
        Me.ButtonRO4SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO4SpostaSu.TabIndex = 13
        Me.ButtonRO4SpostaSu.Text = "Sposta sù"
        Me.ButtonRO4SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRO4SpostaGiu
        '
        Me.ButtonRO4SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO4SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRO4SpostaGiu.Name = "ButtonRO4SpostaGiu"
        Me.ButtonRO4SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO4SpostaGiu.TabIndex = 12
        Me.ButtonRO4SpostaGiu.Text = "Sposta giù"
        Me.ButtonRO4SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRO4AggiungiSezione
        '
        Me.ButtonRO4AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO4AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRO4AggiungiSezione.Name = "ButtonRO4AggiungiSezione"
        Me.ButtonRO4AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO4AggiungiSezione.TabIndex = 11
        Me.ButtonRO4AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRO4AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRO4Descrizione
        '
        Me.RichTextBoxRO4Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO4Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO4Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRO4Descrizione.Name = "RichTextBoxRO4Descrizione"
        Me.RichTextBoxRO4Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRO4Descrizione.TabIndex = 10
        Me.RichTextBoxRO4Descrizione.Text = ""
        '
        'Label39
        '
        Me.Label39.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(256, 406)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(62, 13)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "Descrizione"
        '
        'TextBoxRO4Titolo
        '
        Me.TextBoxRO4Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO4Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRO4Titolo.Name = "TextBoxRO4Titolo"
        Me.TextBoxRO4Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRO4Titolo.TabIndex = 8
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(260, 367)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 13)
        Me.Label40.TabIndex = 7
        Me.Label40.Text = "Titolo"
        '
        'PictureBoxRO4
        '
        Me.PictureBoxRO4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRO4.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRO4.Name = "PictureBoxRO4"
        Me.PictureBoxRO4.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRO4.TabIndex = 6
        Me.PictureBoxRO4.TabStop = False
        '
        'TextBoxRO4Didascalia
        '
        Me.TextBoxRO4Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO4Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRO4Didascalia.Name = "TextBoxRO4Didascalia"
        Me.TextBoxRO4Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRO4Didascalia.TabIndex = 5
        '
        'Label41
        '
        Me.Label41.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(6, 619)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(56, 13)
        Me.Label41.TabIndex = 4
        Me.Label41.Text = "Didascalia"
        '
        'ButtonRO4InserisciImmagine
        '
        Me.ButtonRO4InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO4InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRO4InserisciImmagine.Name = "ButtonRO4InserisciImmagine"
        Me.ButtonRO4InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO4InserisciImmagine.TabIndex = 0
        Me.ButtonRO4InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRO4InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox17
        '
        Me.GroupBox17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox17.Controls.Add(Me.RichTextBoxRO4TestoFinale)
        Me.GroupBox17.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox17.TabIndex = 7
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Testo finale"
        '
        'RichTextBoxRO4TestoFinale
        '
        Me.RichTextBoxRO4TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO4TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO4TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO4TestoFinale.Name = "RichTextBoxRO4TestoFinale"
        Me.RichTextBoxRO4TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRO4TestoFinale.TabIndex = 0
        Me.RichTextBoxRO4TestoFinale.Text = ""
        '
        'GroupBox18
        '
        Me.GroupBox18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox18.Controls.Add(Me.RichTextBoxRO4TestoIniziale)
        Me.GroupBox18.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox18.TabIndex = 6
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Testo iniziale"
        '
        'RichTextBoxRO4TestoIniziale
        '
        Me.RichTextBoxRO4TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO4TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO4TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO4TestoIniziale.Name = "RichTextBoxRO4TestoIniziale"
        Me.RichTextBoxRO4TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRO4TestoIniziale.TabIndex = 0
        Me.RichTextBoxRO4TestoIniziale.Text = ""
        '
        'RO5
        '
        Me.RO5.AutoScroll = True
        Me.RO5.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RO5.Controls.Add(Me.TextBoxRO5DettaglioPerizia)
        Me.RO5.Controls.Add(Me.Label42)
        Me.RO5.Controls.Add(Me.LabelRO5)
        Me.RO5.Controls.Add(Me.GroupBox19)
        Me.RO5.Controls.Add(Me.GroupBox20)
        Me.RO5.Controls.Add(Me.GroupBox21)
        Me.RO5.Location = New System.Drawing.Point(4, 22)
        Me.RO5.Name = "RO5"
        Me.RO5.Size = New System.Drawing.Size(655, 919)
        Me.RO5.TabIndex = 5
        Me.RO5.Text = "RO5"
        Me.RO5.UseVisualStyleBackColor = True
        '
        'TextBoxRO5DettaglioPerizia
        '
        Me.TextBoxRO5DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO5DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRO5DettaglioPerizia.Name = "TextBoxRO5DettaglioPerizia"
        Me.TextBoxRO5DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRO5DettaglioPerizia.TabIndex = 12
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(14, 29)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(100, 13)
        Me.Label42.TabIndex = 11
        Me.Label42.Text = "Dettaglio per perizia"
        '
        'LabelRO5
        '
        Me.LabelRO5.AutoSize = True
        Me.LabelRO5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRO5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRO5.Location = New System.Drawing.Point(5, 5)
        Me.LabelRO5.Name = "LabelRO5"
        Me.LabelRO5.Size = New System.Drawing.Size(620, 18)
        Me.LabelRO5.TabIndex = 5
        Me.LabelRO5.Text = "RO5. Rispondenza ai più recenti parametri di sicurezza, salute e igiene del lavor" &
    "o"
        Me.LabelRO5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox19
        '
        Me.GroupBox19.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox19.Controls.Add(Me.TextBoxGuidaRO5)
        Me.GroupBox19.Controls.Add(Me.DataGridViewRO5)
        Me.GroupBox19.Controls.Add(Me.ButtonRO5RimuoviSezione)
        Me.GroupBox19.Controls.Add(Me.ButtonRO5SpostaSu)
        Me.GroupBox19.Controls.Add(Me.ButtonRO5SpostaGiu)
        Me.GroupBox19.Controls.Add(Me.ButtonRO5AggiungiSezione)
        Me.GroupBox19.Controls.Add(Me.RichTextBoxRO5Descrizione)
        Me.GroupBox19.Controls.Add(Me.Label43)
        Me.GroupBox19.Controls.Add(Me.TextBoxRO5Titolo)
        Me.GroupBox19.Controls.Add(Me.Label44)
        Me.GroupBox19.Controls.Add(Me.PictureBoxRO5)
        Me.GroupBox19.Controls.Add(Me.TextBoxRO5Didascalia)
        Me.GroupBox19.Controls.Add(Me.Label45)
        Me.GroupBox19.Controls.Add(Me.ButtonRO5InserisciImmagine)
        Me.GroupBox19.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox19.TabIndex = 8
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "Corpo centrale"
        '
        'TextBoxGuidaRO5
        '
        Me.TextBoxGuidaRO5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRO5.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRO5.Location = New System.Drawing.Point(29, 45)
        Me.TextBoxGuidaRO5.Multiline = True
        Me.TextBoxGuidaRO5.Name = "TextBoxGuidaRO5"
        Me.TextBoxGuidaRO5.ReadOnly = True
        Me.TextBoxGuidaRO5.Size = New System.Drawing.Size(562, 230)
        Me.TextBoxGuidaRO5.TabIndex = 5
        Me.TextBoxGuidaRO5.Visible = False
        '
        'DataGridViewRO5
        '
        Me.DataGridViewRO5.AllowUserToAddRows = False
        Me.DataGridViewRO5.AllowUserToDeleteRows = False
        Me.DataGridViewRO5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRO5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRO5.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn5, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn36})
        Me.DataGridViewRO5.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRO5.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRO5.MultiSelect = False
        Me.DataGridViewRO5.Name = "DataGridViewRO5"
        Me.DataGridViewRO5.RowHeadersVisible = False
        Me.DataGridViewRO5.RowTemplate.Height = 128
        Me.DataGridViewRO5.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRO5.TabIndex = 15
        '
        'DataGridViewImageColumn5
        '
        Me.DataGridViewImageColumn5.HeaderText = "Immagine"
        Me.DataGridViewImageColumn5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Width = 128
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 300
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'ButtonRO5RimuoviSezione
        '
        Me.ButtonRO5RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO5RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRO5RimuoviSezione.Name = "ButtonRO5RimuoviSezione"
        Me.ButtonRO5RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO5RimuoviSezione.TabIndex = 14
        Me.ButtonRO5RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRO5RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRO5SpostaSu
        '
        Me.ButtonRO5SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO5SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRO5SpostaSu.Name = "ButtonRO5SpostaSu"
        Me.ButtonRO5SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO5SpostaSu.TabIndex = 13
        Me.ButtonRO5SpostaSu.Text = "Sposta sù"
        Me.ButtonRO5SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRO5SpostaGiu
        '
        Me.ButtonRO5SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO5SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRO5SpostaGiu.Name = "ButtonRO5SpostaGiu"
        Me.ButtonRO5SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRO5SpostaGiu.TabIndex = 12
        Me.ButtonRO5SpostaGiu.Text = "Sposta giù"
        Me.ButtonRO5SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRO5AggiungiSezione
        '
        Me.ButtonRO5AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO5AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRO5AggiungiSezione.Name = "ButtonRO5AggiungiSezione"
        Me.ButtonRO5AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO5AggiungiSezione.TabIndex = 11
        Me.ButtonRO5AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRO5AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRO5Descrizione
        '
        Me.RichTextBoxRO5Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO5Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO5Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRO5Descrizione.Name = "RichTextBoxRO5Descrizione"
        Me.RichTextBoxRO5Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRO5Descrizione.TabIndex = 10
        Me.RichTextBoxRO5Descrizione.Text = ""
        '
        'Label43
        '
        Me.Label43.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(256, 406)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(62, 13)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "Descrizione"
        '
        'TextBoxRO5Titolo
        '
        Me.TextBoxRO5Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO5Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRO5Titolo.Name = "TextBoxRO5Titolo"
        Me.TextBoxRO5Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRO5Titolo.TabIndex = 8
        '
        'Label44
        '
        Me.Label44.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(260, 367)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(33, 13)
        Me.Label44.TabIndex = 7
        Me.Label44.Text = "Titolo"
        '
        'PictureBoxRO5
        '
        Me.PictureBoxRO5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRO5.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRO5.Name = "PictureBoxRO5"
        Me.PictureBoxRO5.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRO5.TabIndex = 6
        Me.PictureBoxRO5.TabStop = False
        '
        'TextBoxRO5Didascalia
        '
        Me.TextBoxRO5Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRO5Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRO5Didascalia.Name = "TextBoxRO5Didascalia"
        Me.TextBoxRO5Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRO5Didascalia.TabIndex = 5
        '
        'Label45
        '
        Me.Label45.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(6, 619)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(56, 13)
        Me.Label45.TabIndex = 4
        Me.Label45.Text = "Didascalia"
        '
        'ButtonRO5InserisciImmagine
        '
        Me.ButtonRO5InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRO5InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRO5InserisciImmagine.Name = "ButtonRO5InserisciImmagine"
        Me.ButtonRO5InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRO5InserisciImmagine.TabIndex = 0
        Me.ButtonRO5InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRO5InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox20
        '
        Me.GroupBox20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox20.Controls.Add(Me.RichTextBoxRO5TestoFinale)
        Me.GroupBox20.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox20.TabIndex = 7
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Testo finale"
        '
        'RichTextBoxRO5TestoFinale
        '
        Me.RichTextBoxRO5TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO5TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO5TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO5TestoFinale.Name = "RichTextBoxRO5TestoFinale"
        Me.RichTextBoxRO5TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRO5TestoFinale.TabIndex = 0
        Me.RichTextBoxRO5TestoFinale.Text = ""
        '
        'GroupBox21
        '
        Me.GroupBox21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox21.Controls.Add(Me.RichTextBoxRO5TestoIniziale)
        Me.GroupBox21.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox21.TabIndex = 6
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Testo iniziale"
        '
        'RichTextBoxRO5TestoIniziale
        '
        Me.RichTextBoxRO5TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO5TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRO5TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRO5TestoIniziale.Name = "RichTextBoxRO5TestoIniziale"
        Me.RichTextBoxRO5TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRO5TestoIniziale.TabIndex = 0
        Me.RichTextBoxRO5TestoIniziale.Text = ""
        '
        'RU1
        '
        Me.RU1.AutoScroll = True
        Me.RU1.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RU1.Controls.Add(Me.TextBoxRU1DettaglioPerizia)
        Me.RU1.Controls.Add(Me.Label46)
        Me.RU1.Controls.Add(Me.CheckBoxRU1)
        Me.RU1.Controls.Add(Me.LabelRU1)
        Me.RU1.Controls.Add(Me.GroupBox22)
        Me.RU1.Controls.Add(Me.GroupBox23)
        Me.RU1.Controls.Add(Me.GroupBox24)
        Me.RU1.Location = New System.Drawing.Point(4, 22)
        Me.RU1.Name = "RU1"
        Me.RU1.Size = New System.Drawing.Size(655, 919)
        Me.RU1.TabIndex = 6
        Me.RU1.Text = "RU1"
        Me.RU1.UseVisualStyleBackColor = True
        '
        'TextBoxRU1DettaglioPerizia
        '
        Me.TextBoxRU1DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU1DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRU1DettaglioPerizia.Name = "TextBoxRU1DettaglioPerizia"
        Me.TextBoxRU1DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRU1DettaglioPerizia.TabIndex = 12
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(14, 29)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(100, 13)
        Me.Label46.TabIndex = 11
        Me.Label46.Text = "Dettaglio per perizia"
        '
        'CheckBoxRU1
        '
        Me.CheckBoxRU1.AutoSize = True
        Me.CheckBoxRU1.Checked = True
        Me.CheckBoxRU1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRU1.Location = New System.Drawing.Point(575, 9)
        Me.CheckBoxRU1.Name = "CheckBoxRU1"
        Me.CheckBoxRU1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxRU1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxRU1.TabIndex = 9
        Me.CheckBoxRU1.UseVisualStyleBackColor = True
        '
        'LabelRU1
        '
        Me.LabelRU1.AutoSize = True
        Me.LabelRU1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRU1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRU1.Location = New System.Drawing.Point(5, 5)
        Me.LabelRU1.Name = "LabelRU1"
        Me.LabelRU1.Size = New System.Drawing.Size(564, 18)
        Me.LabelRU1.TabIndex = 5
        Me.LabelRU1.Text = "RU1. Sistemi di telemanutenzione e/o telediagnosi e/o controllo in remoto"
        Me.LabelRU1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox22
        '
        Me.GroupBox22.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox22.Controls.Add(Me.TextBoxGuidaRU1)
        Me.GroupBox22.Controls.Add(Me.DataGridViewRU1)
        Me.GroupBox22.Controls.Add(Me.ButtonRU1RimuoviSezione)
        Me.GroupBox22.Controls.Add(Me.ButtonRU1SpostaSu)
        Me.GroupBox22.Controls.Add(Me.ButtonRU1SpostaGiu)
        Me.GroupBox22.Controls.Add(Me.ButtonRU1AggiungiSezione)
        Me.GroupBox22.Controls.Add(Me.RichTextBoxRU1Descrizione)
        Me.GroupBox22.Controls.Add(Me.Label47)
        Me.GroupBox22.Controls.Add(Me.TextBoxRU1Titolo)
        Me.GroupBox22.Controls.Add(Me.Label48)
        Me.GroupBox22.Controls.Add(Me.PictureBoxRU1)
        Me.GroupBox22.Controls.Add(Me.TextBoxRU1Didascalia)
        Me.GroupBox22.Controls.Add(Me.Label49)
        Me.GroupBox22.Controls.Add(Me.ButtonRU1InserisciImmagine)
        Me.GroupBox22.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox22.TabIndex = 8
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Corpo centrale"
        '
        'TextBoxGuidaRU1
        '
        Me.TextBoxGuidaRU1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRU1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRU1.Location = New System.Drawing.Point(9, 45)
        Me.TextBoxGuidaRU1.Multiline = True
        Me.TextBoxGuidaRU1.Name = "TextBoxGuidaRU1"
        Me.TextBoxGuidaRU1.ReadOnly = True
        Me.TextBoxGuidaRU1.Size = New System.Drawing.Size(616, 240)
        Me.TextBoxGuidaRU1.TabIndex = 5
        Me.TextBoxGuidaRU1.Visible = False
        '
        'DataGridViewRU1
        '
        Me.DataGridViewRU1.AllowUserToAddRows = False
        Me.DataGridViewRU1.AllowUserToDeleteRows = False
        Me.DataGridViewRU1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRU1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRU1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn6, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn37})
        Me.DataGridViewRU1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRU1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRU1.MultiSelect = False
        Me.DataGridViewRU1.Name = "DataGridViewRU1"
        Me.DataGridViewRU1.RowHeadersVisible = False
        Me.DataGridViewRU1.RowTemplate.Height = 128
        Me.DataGridViewRU1.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRU1.TabIndex = 15
        '
        'DataGridViewImageColumn6
        '
        Me.DataGridViewImageColumn6.HeaderText = "Immagine"
        Me.DataGridViewImageColumn6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        Me.DataGridViewImageColumn6.Width = 128
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn21.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 300
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Visible = False
        '
        'ButtonRU1RimuoviSezione
        '
        Me.ButtonRU1RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU1RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRU1RimuoviSezione.Name = "ButtonRU1RimuoviSezione"
        Me.ButtonRU1RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU1RimuoviSezione.TabIndex = 14
        Me.ButtonRU1RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRU1RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRU1SpostaSu
        '
        Me.ButtonRU1SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU1SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRU1SpostaSu.Name = "ButtonRU1SpostaSu"
        Me.ButtonRU1SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRU1SpostaSu.TabIndex = 13
        Me.ButtonRU1SpostaSu.Text = "Sposta sù"
        Me.ButtonRU1SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRU1SpostaGiu
        '
        Me.ButtonRU1SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU1SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRU1SpostaGiu.Name = "ButtonRU1SpostaGiu"
        Me.ButtonRU1SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRU1SpostaGiu.TabIndex = 12
        Me.ButtonRU1SpostaGiu.Text = "Sposta giù"
        Me.ButtonRU1SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRU1AggiungiSezione
        '
        Me.ButtonRU1AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU1AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRU1AggiungiSezione.Name = "ButtonRU1AggiungiSezione"
        Me.ButtonRU1AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU1AggiungiSezione.TabIndex = 11
        Me.ButtonRU1AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRU1AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRU1Descrizione
        '
        Me.RichTextBoxRU1Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU1Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU1Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRU1Descrizione.Name = "RichTextBoxRU1Descrizione"
        Me.RichTextBoxRU1Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRU1Descrizione.TabIndex = 10
        Me.RichTextBoxRU1Descrizione.Text = ""
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(256, 406)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(62, 13)
        Me.Label47.TabIndex = 9
        Me.Label47.Text = "Descrizione"
        '
        'TextBoxRU1Titolo
        '
        Me.TextBoxRU1Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU1Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRU1Titolo.Name = "TextBoxRU1Titolo"
        Me.TextBoxRU1Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRU1Titolo.TabIndex = 8
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(260, 367)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(33, 13)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "Titolo"
        '
        'PictureBoxRU1
        '
        Me.PictureBoxRU1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRU1.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRU1.Name = "PictureBoxRU1"
        Me.PictureBoxRU1.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRU1.TabIndex = 6
        Me.PictureBoxRU1.TabStop = False
        '
        'TextBoxRU1Didascalia
        '
        Me.TextBoxRU1Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU1Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRU1Didascalia.Name = "TextBoxRU1Didascalia"
        Me.TextBoxRU1Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRU1Didascalia.TabIndex = 5
        '
        'Label49
        '
        Me.Label49.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(6, 619)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(56, 13)
        Me.Label49.TabIndex = 4
        Me.Label49.Text = "Didascalia"
        '
        'ButtonRU1InserisciImmagine
        '
        Me.ButtonRU1InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU1InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRU1InserisciImmagine.Name = "ButtonRU1InserisciImmagine"
        Me.ButtonRU1InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU1InserisciImmagine.TabIndex = 0
        Me.ButtonRU1InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRU1InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox23
        '
        Me.GroupBox23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox23.Controls.Add(Me.RichTextBoxRU1TestoFinale)
        Me.GroupBox23.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox23.TabIndex = 7
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Testo finale"
        '
        'RichTextBoxRU1TestoFinale
        '
        Me.RichTextBoxRU1TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU1TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU1TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRU1TestoFinale.Name = "RichTextBoxRU1TestoFinale"
        Me.RichTextBoxRU1TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRU1TestoFinale.TabIndex = 0
        Me.RichTextBoxRU1TestoFinale.Text = ""
        '
        'GroupBox24
        '
        Me.GroupBox24.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox24.Controls.Add(Me.RichTextBoxRU1TestoIniziale)
        Me.GroupBox24.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox24.TabIndex = 6
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Testo iniziale"
        '
        'RichTextBoxRU1TestoIniziale
        '
        Me.RichTextBoxRU1TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU1TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU1TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRU1TestoIniziale.Name = "RichTextBoxRU1TestoIniziale"
        Me.RichTextBoxRU1TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRU1TestoIniziale.TabIndex = 0
        Me.RichTextBoxRU1TestoIniziale.Text = ""
        '
        'RU2
        '
        Me.RU2.AutoScroll = True
        Me.RU2.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RU2.Controls.Add(Me.TextBoxRU2DettaglioPerizia)
        Me.RU2.Controls.Add(Me.Label50)
        Me.RU2.Controls.Add(Me.CheckBoxRU2)
        Me.RU2.Controls.Add(Me.LabelRU2)
        Me.RU2.Controls.Add(Me.GroupBox25)
        Me.RU2.Controls.Add(Me.GroupBox26)
        Me.RU2.Controls.Add(Me.GroupBox27)
        Me.RU2.Location = New System.Drawing.Point(4, 22)
        Me.RU2.Name = "RU2"
        Me.RU2.Size = New System.Drawing.Size(655, 919)
        Me.RU2.TabIndex = 7
        Me.RU2.Text = "RU2"
        Me.RU2.UseVisualStyleBackColor = True
        '
        'TextBoxRU2DettaglioPerizia
        '
        Me.TextBoxRU2DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU2DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRU2DettaglioPerizia.Name = "TextBoxRU2DettaglioPerizia"
        Me.TextBoxRU2DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRU2DettaglioPerizia.TabIndex = 12
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(14, 29)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(100, 13)
        Me.Label50.TabIndex = 11
        Me.Label50.Text = "Dettaglio per perizia"
        '
        'CheckBoxRU2
        '
        Me.CheckBoxRU2.AutoSize = True
        Me.CheckBoxRU2.Checked = True
        Me.CheckBoxRU2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxRU2.Location = New System.Drawing.Point(581, 9)
        Me.CheckBoxRU2.Name = "CheckBoxRU2"
        Me.CheckBoxRU2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxRU2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxRU2.TabIndex = 10
        Me.CheckBoxRU2.UseVisualStyleBackColor = True
        '
        'LabelRU2
        '
        Me.LabelRU2.AutoSize = True
        Me.LabelRU2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRU2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRU2.Location = New System.Drawing.Point(5, 5)
        Me.LabelRU2.Name = "LabelRU2"
        Me.LabelRU2.Size = New System.Drawing.Size(570, 18)
        Me.LabelRU2.TabIndex = 5
        Me.LabelRU2.Text = "RU2. Monitoraggio continuo dei parametri adattività alle derive di processo"
        Me.LabelRU2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox25
        '
        Me.GroupBox25.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox25.Controls.Add(Me.TextBoxGuidaRU2)
        Me.GroupBox25.Controls.Add(Me.DataGridViewRU2)
        Me.GroupBox25.Controls.Add(Me.ButtonRU2RimuoviSezione)
        Me.GroupBox25.Controls.Add(Me.ButtonRU2SpostaSu)
        Me.GroupBox25.Controls.Add(Me.ButtonRU2SpostaGiu)
        Me.GroupBox25.Controls.Add(Me.ButtonRU2AggiungiSezione)
        Me.GroupBox25.Controls.Add(Me.RichTextBoxRU2Descrizione)
        Me.GroupBox25.Controls.Add(Me.Label51)
        Me.GroupBox25.Controls.Add(Me.TextBoxRU2Titolo)
        Me.GroupBox25.Controls.Add(Me.Label52)
        Me.GroupBox25.Controls.Add(Me.PictureBoxRU2)
        Me.GroupBox25.Controls.Add(Me.TextBoxRU2Didascalia)
        Me.GroupBox25.Controls.Add(Me.Label53)
        Me.GroupBox25.Controls.Add(Me.ButtonRU2InserisciImmagine)
        Me.GroupBox25.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox25.TabIndex = 8
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Corpo centrale"
        '
        'TextBoxGuidaRU2
        '
        Me.TextBoxGuidaRU2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRU2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRU2.Location = New System.Drawing.Point(9, 44)
        Me.TextBoxGuidaRU2.Multiline = True
        Me.TextBoxGuidaRU2.Name = "TextBoxGuidaRU2"
        Me.TextBoxGuidaRU2.ReadOnly = True
        Me.TextBoxGuidaRU2.Size = New System.Drawing.Size(609, 248)
        Me.TextBoxGuidaRU2.TabIndex = 5
        Me.TextBoxGuidaRU2.Visible = False
        '
        'DataGridViewRU2
        '
        Me.DataGridViewRU2.AllowUserToAddRows = False
        Me.DataGridViewRU2.AllowUserToDeleteRows = False
        Me.DataGridViewRU2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRU2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRU2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn7, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn38})
        Me.DataGridViewRU2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRU2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRU2.MultiSelect = False
        Me.DataGridViewRU2.Name = "DataGridViewRU2"
        Me.DataGridViewRU2.RowHeadersVisible = False
        Me.DataGridViewRU2.RowTemplate.Height = 128
        Me.DataGridViewRU2.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRU2.TabIndex = 15
        '
        'DataGridViewImageColumn7
        '
        Me.DataGridViewImageColumn7.HeaderText = "Immagine"
        Me.DataGridViewImageColumn7.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn7.Name = "DataGridViewImageColumn7"
        Me.DataGridViewImageColumn7.Width = 128
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn25.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 300
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.Visible = False
        '
        'ButtonRU2RimuoviSezione
        '
        Me.ButtonRU2RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU2RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRU2RimuoviSezione.Name = "ButtonRU2RimuoviSezione"
        Me.ButtonRU2RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU2RimuoviSezione.TabIndex = 14
        Me.ButtonRU2RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRU2RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRU2SpostaSu
        '
        Me.ButtonRU2SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU2SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRU2SpostaSu.Name = "ButtonRU2SpostaSu"
        Me.ButtonRU2SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRU2SpostaSu.TabIndex = 13
        Me.ButtonRU2SpostaSu.Text = "Sposta sù"
        Me.ButtonRU2SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRU2SpostaGiu
        '
        Me.ButtonRU2SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU2SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRU2SpostaGiu.Name = "ButtonRU2SpostaGiu"
        Me.ButtonRU2SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRU2SpostaGiu.TabIndex = 12
        Me.ButtonRU2SpostaGiu.Text = "Sposta giù"
        Me.ButtonRU2SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRU2AggiungiSezione
        '
        Me.ButtonRU2AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU2AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRU2AggiungiSezione.Name = "ButtonRU2AggiungiSezione"
        Me.ButtonRU2AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU2AggiungiSezione.TabIndex = 11
        Me.ButtonRU2AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRU2AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRU2Descrizione
        '
        Me.RichTextBoxRU2Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU2Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU2Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRU2Descrizione.Name = "RichTextBoxRU2Descrizione"
        Me.RichTextBoxRU2Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRU2Descrizione.TabIndex = 10
        Me.RichTextBoxRU2Descrizione.Text = ""
        '
        'Label51
        '
        Me.Label51.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(256, 406)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(62, 13)
        Me.Label51.TabIndex = 9
        Me.Label51.Text = "Descrizione"
        '
        'TextBoxRU2Titolo
        '
        Me.TextBoxRU2Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU2Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRU2Titolo.Name = "TextBoxRU2Titolo"
        Me.TextBoxRU2Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRU2Titolo.TabIndex = 8
        '
        'Label52
        '
        Me.Label52.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(260, 367)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(33, 13)
        Me.Label52.TabIndex = 7
        Me.Label52.Text = "Titolo"
        '
        'PictureBoxRU2
        '
        Me.PictureBoxRU2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRU2.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRU2.Name = "PictureBoxRU2"
        Me.PictureBoxRU2.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRU2.TabIndex = 6
        Me.PictureBoxRU2.TabStop = False
        '
        'TextBoxRU2Didascalia
        '
        Me.TextBoxRU2Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU2Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRU2Didascalia.Name = "TextBoxRU2Didascalia"
        Me.TextBoxRU2Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRU2Didascalia.TabIndex = 5
        '
        'Label53
        '
        Me.Label53.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(6, 619)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(56, 13)
        Me.Label53.TabIndex = 4
        Me.Label53.Text = "Didascalia"
        '
        'ButtonRU2InserisciImmagine
        '
        Me.ButtonRU2InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU2InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRU2InserisciImmagine.Name = "ButtonRU2InserisciImmagine"
        Me.ButtonRU2InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU2InserisciImmagine.TabIndex = 0
        Me.ButtonRU2InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRU2InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox26
        '
        Me.GroupBox26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox26.Controls.Add(Me.RichTextBoxRU2TestoFinale)
        Me.GroupBox26.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox26.TabIndex = 7
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Testo finale"
        '
        'RichTextBoxRU2TestoFinale
        '
        Me.RichTextBoxRU2TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU2TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU2TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRU2TestoFinale.Name = "RichTextBoxRU2TestoFinale"
        Me.RichTextBoxRU2TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRU2TestoFinale.TabIndex = 0
        Me.RichTextBoxRU2TestoFinale.Text = ""
        '
        'GroupBox27
        '
        Me.GroupBox27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox27.Controls.Add(Me.RichTextBoxRU2TestoIniziale)
        Me.GroupBox27.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox27.TabIndex = 6
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Testo iniziale"
        '
        'RichTextBoxRU2TestoIniziale
        '
        Me.RichTextBoxRU2TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU2TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU2TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRU2TestoIniziale.Name = "RichTextBoxRU2TestoIniziale"
        Me.RichTextBoxRU2TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRU2TestoIniziale.TabIndex = 0
        Me.RichTextBoxRU2TestoIniziale.Text = ""
        '
        'RU3
        '
        Me.RU3.AutoScroll = True
        Me.RU3.AutoScrollMinSize = New System.Drawing.Size(300, 919)
        Me.RU3.Controls.Add(Me.TextBoxRU3DettaglioPerizia)
        Me.RU3.Controls.Add(Me.Label54)
        Me.RU3.Controls.Add(Me.CheckBoxRU3)
        Me.RU3.Controls.Add(Me.LabelRU3)
        Me.RU3.Controls.Add(Me.GroupBox28)
        Me.RU3.Controls.Add(Me.GroupBox29)
        Me.RU3.Controls.Add(Me.GroupBox30)
        Me.RU3.Location = New System.Drawing.Point(4, 22)
        Me.RU3.Name = "RU3"
        Me.RU3.Size = New System.Drawing.Size(655, 919)
        Me.RU3.TabIndex = 8
        Me.RU3.Text = "RU3"
        Me.RU3.UseVisualStyleBackColor = True
        '
        'TextBoxRU3DettaglioPerizia
        '
        Me.TextBoxRU3DettaglioPerizia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU3DettaglioPerizia.Location = New System.Drawing.Point(120, 26)
        Me.TextBoxRU3DettaglioPerizia.Name = "TextBoxRU3DettaglioPerizia"
        Me.TextBoxRU3DettaglioPerizia.Size = New System.Drawing.Size(524, 20)
        Me.TextBoxRU3DettaglioPerizia.TabIndex = 12
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(14, 29)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(100, 13)
        Me.Label54.TabIndex = 11
        Me.Label54.Text = "Dettaglio per perizia"
        '
        'CheckBoxRU3
        '
        Me.CheckBoxRU3.AutoSize = True
        Me.CheckBoxRU3.Location = New System.Drawing.Point(619, 9)
        Me.CheckBoxRU3.Name = "CheckBoxRU3"
        Me.CheckBoxRU3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxRU3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxRU3.TabIndex = 10
        Me.CheckBoxRU3.UseVisualStyleBackColor = True
        '
        'LabelRU3
        '
        Me.LabelRU3.AutoSize = True
        Me.LabelRU3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRU3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LabelRU3.Location = New System.Drawing.Point(5, 5)
        Me.LabelRU3.Name = "LabelRU3"
        Me.LabelRU3.Size = New System.Drawing.Size(608, 18)
        Me.LabelRU3.TabIndex = 5
        Me.LabelRU3.Text = "RU3. Integrazione tra macchina o impianto con simulazione del comportamento"
        Me.LabelRU3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox28
        '
        Me.GroupBox28.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox28.Controls.Add(Me.TextBoxGuidaRU3)
        Me.GroupBox28.Controls.Add(Me.DataGridViewRU3)
        Me.GroupBox28.Controls.Add(Me.ButtonRU3RimuoviSezione)
        Me.GroupBox28.Controls.Add(Me.ButtonRU3SpostaSu)
        Me.GroupBox28.Controls.Add(Me.ButtonRU3SpostaGiu)
        Me.GroupBox28.Controls.Add(Me.ButtonRU3AggiungiSezione)
        Me.GroupBox28.Controls.Add(Me.RichTextBoxRU3Descrizione)
        Me.GroupBox28.Controls.Add(Me.Label55)
        Me.GroupBox28.Controls.Add(Me.TextBoxRU3Titolo)
        Me.GroupBox28.Controls.Add(Me.Label56)
        Me.GroupBox28.Controls.Add(Me.PictureBoxRU3)
        Me.GroupBox28.Controls.Add(Me.TextBoxRU3Didascalia)
        Me.GroupBox28.Controls.Add(Me.Label57)
        Me.GroupBox28.Controls.Add(Me.ButtonRU3InserisciImmagine)
        Me.GroupBox28.Location = New System.Drawing.Point(8, 165)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(642, 650)
        Me.GroupBox28.TabIndex = 8
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "Corpo centrale"
        '
        'TextBoxGuidaRU3
        '
        Me.TextBoxGuidaRU3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxGuidaRU3.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxGuidaRU3.Location = New System.Drawing.Point(18, 45)
        Me.TextBoxGuidaRU3.Multiline = True
        Me.TextBoxGuidaRU3.Name = "TextBoxGuidaRU3"
        Me.TextBoxGuidaRU3.ReadOnly = True
        Me.TextBoxGuidaRU3.Size = New System.Drawing.Size(597, 256)
        Me.TextBoxGuidaRU3.TabIndex = 5
        Me.TextBoxGuidaRU3.Visible = False
        '
        'DataGridViewRU3
        '
        Me.DataGridViewRU3.AllowUserToAddRows = False
        Me.DataGridViewRU3.AllowUserToDeleteRows = False
        Me.DataGridViewRU3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewRU3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRU3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn8, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn39})
        Me.DataGridViewRU3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridViewRU3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewRU3.MultiSelect = False
        Me.DataGridViewRU3.Name = "DataGridViewRU3"
        Me.DataGridViewRU3.RowHeadersVisible = False
        Me.DataGridViewRU3.RowTemplate.Height = 128
        Me.DataGridViewRU3.Size = New System.Drawing.Size(630, 313)
        Me.DataGridViewRU3.TabIndex = 15
        '
        'DataGridViewImageColumn8
        '
        Me.DataGridViewImageColumn8.HeaderText = "Immagine"
        Me.DataGridViewImageColumn8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn8.Name = "DataGridViewImageColumn8"
        Me.DataGridViewImageColumn8.Width = 128
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.HeaderText = "Didascalia"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn29.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "Titolo"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 300
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.HeaderText = "DescrizioneRTF"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.HeaderText = "PercorsoImmagine"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        Me.DataGridViewTextBoxColumn39.Visible = False
        '
        'ButtonRU3RimuoviSezione
        '
        Me.ButtonRU3RimuoviSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU3RimuoviSezione.Location = New System.Drawing.Point(226, 338)
        Me.ButtonRU3RimuoviSezione.Name = "ButtonRU3RimuoviSezione"
        Me.ButtonRU3RimuoviSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU3RimuoviSezione.TabIndex = 14
        Me.ButtonRU3RimuoviSezione.Text = "Rimuovi sezione"
        Me.ButtonRU3RimuoviSezione.UseVisualStyleBackColor = True
        '
        'ButtonRU3SpostaSu
        '
        Me.ButtonRU3SpostaSu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU3SpostaSu.Location = New System.Drawing.Point(480, 338)
        Me.ButtonRU3SpostaSu.Name = "ButtonRU3SpostaSu"
        Me.ButtonRU3SpostaSu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRU3SpostaSu.TabIndex = 13
        Me.ButtonRU3SpostaSu.Text = "Sposta sù"
        Me.ButtonRU3SpostaSu.UseVisualStyleBackColor = True
        '
        'ButtonRU3SpostaGiu
        '
        Me.ButtonRU3SpostaGiu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU3SpostaGiu.Location = New System.Drawing.Point(561, 338)
        Me.ButtonRU3SpostaGiu.Name = "ButtonRU3SpostaGiu"
        Me.ButtonRU3SpostaGiu.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRU3SpostaGiu.TabIndex = 12
        Me.ButtonRU3SpostaGiu.Text = "Sposta giù"
        Me.ButtonRU3SpostaGiu.UseVisualStyleBackColor = True
        '
        'ButtonRU3AggiungiSezione
        '
        Me.ButtonRU3AggiungiSezione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU3AggiungiSezione.Location = New System.Drawing.Point(4, 338)
        Me.ButtonRU3AggiungiSezione.Name = "ButtonRU3AggiungiSezione"
        Me.ButtonRU3AggiungiSezione.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU3AggiungiSezione.TabIndex = 11
        Me.ButtonRU3AggiungiSezione.Text = "Aggiungi sezione"
        Me.ButtonRU3AggiungiSezione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRU3Descrizione
        '
        Me.RichTextBoxRU3Descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU3Descrizione.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU3Descrizione.Location = New System.Drawing.Point(260, 422)
        Me.RichTextBoxRU3Descrizione.Name = "RichTextBoxRU3Descrizione"
        Me.RichTextBoxRU3Descrizione.Size = New System.Drawing.Size(376, 214)
        Me.RichTextBoxRU3Descrizione.TabIndex = 10
        Me.RichTextBoxRU3Descrizione.Text = ""
        '
        'Label55
        '
        Me.Label55.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(256, 406)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(62, 13)
        Me.Label55.TabIndex = 9
        Me.Label55.Text = "Descrizione"
        '
        'TextBoxRU3Titolo
        '
        Me.TextBoxRU3Titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU3Titolo.Location = New System.Drawing.Point(260, 383)
        Me.TextBoxRU3Titolo.Name = "TextBoxRU3Titolo"
        Me.TextBoxRU3Titolo.Size = New System.Drawing.Size(376, 20)
        Me.TextBoxRU3Titolo.TabIndex = 8
        '
        'Label56
        '
        Me.Label56.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(260, 367)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(33, 13)
        Me.Label56.TabIndex = 7
        Me.Label56.Text = "Titolo"
        '
        'PictureBoxRU3
        '
        Me.PictureBoxRU3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxRU3.Location = New System.Drawing.Point(4, 367)
        Me.PictureBoxRU3.Name = "PictureBoxRU3"
        Me.PictureBoxRU3.Size = New System.Drawing.Size(250, 243)
        Me.PictureBoxRU3.TabIndex = 6
        Me.PictureBoxRU3.TabStop = False
        '
        'TextBoxRU3Didascalia
        '
        Me.TextBoxRU3Didascalia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRU3Didascalia.Location = New System.Drawing.Point(68, 616)
        Me.TextBoxRU3Didascalia.Name = "TextBoxRU3Didascalia"
        Me.TextBoxRU3Didascalia.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxRU3Didascalia.TabIndex = 5
        '
        'Label57
        '
        Me.Label57.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(6, 619)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(56, 13)
        Me.Label57.TabIndex = 4
        Me.Label57.Text = "Didascalia"
        '
        'ButtonRU3InserisciImmagine
        '
        Me.ButtonRU3InserisciImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonRU3InserisciImmagine.Location = New System.Drawing.Point(115, 338)
        Me.ButtonRU3InserisciImmagine.Name = "ButtonRU3InserisciImmagine"
        Me.ButtonRU3InserisciImmagine.Size = New System.Drawing.Size(105, 23)
        Me.ButtonRU3InserisciImmagine.TabIndex = 0
        Me.ButtonRU3InserisciImmagine.Text = "Inserisci immagine"
        Me.ButtonRU3InserisciImmagine.UseVisualStyleBackColor = True
        '
        'GroupBox29
        '
        Me.GroupBox29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox29.Controls.Add(Me.RichTextBoxRU3TestoFinale)
        Me.GroupBox29.Location = New System.Drawing.Point(8, 821)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(642, 92)
        Me.GroupBox29.TabIndex = 7
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Testo finale"
        '
        'RichTextBoxRU3TestoFinale
        '
        Me.RichTextBoxRU3TestoFinale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU3TestoFinale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU3TestoFinale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRU3TestoFinale.Name = "RichTextBoxRU3TestoFinale"
        Me.RichTextBoxRU3TestoFinale.Size = New System.Drawing.Size(630, 67)
        Me.RichTextBoxRU3TestoFinale.TabIndex = 0
        Me.RichTextBoxRU3TestoFinale.Text = ""
        '
        'GroupBox30
        '
        Me.GroupBox30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox30.Controls.Add(Me.RichTextBoxRU3TestoIniziale)
        Me.GroupBox30.Location = New System.Drawing.Point(8, 52)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(642, 107)
        Me.GroupBox30.TabIndex = 6
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Testo iniziale"
        '
        'RichTextBoxRU3TestoIniziale
        '
        Me.RichTextBoxRU3TestoIniziale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU3TestoIniziale.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxRU3TestoIniziale.Location = New System.Drawing.Point(6, 19)
        Me.RichTextBoxRU3TestoIniziale.Name = "RichTextBoxRU3TestoIniziale"
        Me.RichTextBoxRU3TestoIniziale.Size = New System.Drawing.Size(630, 82)
        Me.RichTextBoxRU3TestoIniziale.TabIndex = 0
        Me.RichTextBoxRU3TestoIniziale.Text = ""
        '
        'Perizia
        '
        Me.Perizia.Controls.Add(Me.ButtonSalvaPerizia)
        Me.Perizia.Controls.Add(Me.ButtonGeneraPerizia)
        Me.Perizia.Controls.Add(Me.RichTextBoxPerizia)
        Me.Perizia.Location = New System.Drawing.Point(4, 22)
        Me.Perizia.Name = "Perizia"
        Me.Perizia.Size = New System.Drawing.Size(655, 919)
        Me.Perizia.TabIndex = 11
        Me.Perizia.Text = "Perizia"
        Me.Perizia.UseVisualStyleBackColor = True
        '
        'ButtonSalvaPerizia
        '
        Me.ButtonSalvaPerizia.Location = New System.Drawing.Point(117, 3)
        Me.ButtonSalvaPerizia.Name = "ButtonSalvaPerizia"
        Me.ButtonSalvaPerizia.Size = New System.Drawing.Size(108, 23)
        Me.ButtonSalvaPerizia.TabIndex = 8
        Me.ButtonSalvaPerizia.Text = "Salva perizia"
        Me.ButtonSalvaPerizia.UseVisualStyleBackColor = True
        '
        'ButtonGeneraPerizia
        '
        Me.ButtonGeneraPerizia.Location = New System.Drawing.Point(3, 3)
        Me.ButtonGeneraPerizia.Name = "ButtonGeneraPerizia"
        Me.ButtonGeneraPerizia.Size = New System.Drawing.Size(108, 23)
        Me.ButtonGeneraPerizia.TabIndex = 7
        Me.ButtonGeneraPerizia.Text = "Genera perizia"
        Me.ButtonGeneraPerizia.UseVisualStyleBackColor = True
        '
        'RichTextBoxPerizia
        '
        Me.RichTextBoxPerizia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxPerizia.Location = New System.Drawing.Point(3, 32)
        Me.RichTextBoxPerizia.Name = "RichTextBoxPerizia"
        Me.RichTextBoxPerizia.Size = New System.Drawing.Size(649, 884)
        Me.RichTextBoxPerizia.TabIndex = 6
        Me.RichTextBoxPerizia.Text = ""
        '
        'Relazione
        '
        Me.Relazione.Controls.Add(Me.RichTextBoxRU3)
        Me.Relazione.Controls.Add(Me.RichTextBoxRU2)
        Me.Relazione.Controls.Add(Me.RichTextBoxRU1)
        Me.Relazione.Controls.Add(Me.RichTextBoxRO5)
        Me.Relazione.Controls.Add(Me.RichTextBoxRO4)
        Me.Relazione.Controls.Add(Me.RichTextBoxRO3)
        Me.Relazione.Controls.Add(Me.RichTextBoxRO2)
        Me.Relazione.Controls.Add(Me.RichTextBoxRO1)
        Me.Relazione.Controls.Add(Me.RichTextBoxDettaglio)
        Me.Relazione.Controls.Add(Me.ButtonSalvaRelazione)
        Me.Relazione.Controls.Add(Me.ButtonGeneraRelazione)
        Me.Relazione.Controls.Add(Me.RichTextBoxRelazione)
        Me.Relazione.Location = New System.Drawing.Point(4, 22)
        Me.Relazione.Name = "Relazione"
        Me.Relazione.Size = New System.Drawing.Size(655, 919)
        Me.Relazione.TabIndex = 9
        Me.Relazione.Text = "Relazione"
        Me.Relazione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRU3
        '
        Me.RichTextBoxRU3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU3.Location = New System.Drawing.Point(548, 327)
        Me.RichTextBoxRU3.Name = "RichTextBoxRU3"
        Me.RichTextBoxRU3.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRU3.TabIndex = 28
        Me.RichTextBoxRU3.Text = ""
        '
        'RichTextBoxRU2
        '
        Me.RichTextBoxRU2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU2.Location = New System.Drawing.Point(548, 291)
        Me.RichTextBoxRU2.Name = "RichTextBoxRU2"
        Me.RichTextBoxRU2.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRU2.TabIndex = 27
        Me.RichTextBoxRU2.Text = ""
        '
        'RichTextBoxRU1
        '
        Me.RichTextBoxRU1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRU1.Location = New System.Drawing.Point(548, 255)
        Me.RichTextBoxRU1.Name = "RichTextBoxRU1"
        Me.RichTextBoxRU1.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRU1.TabIndex = 26
        Me.RichTextBoxRU1.Text = ""
        '
        'RichTextBoxRO5
        '
        Me.RichTextBoxRO5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO5.Location = New System.Drawing.Point(548, 219)
        Me.RichTextBoxRO5.Name = "RichTextBoxRO5"
        Me.RichTextBoxRO5.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRO5.TabIndex = 25
        Me.RichTextBoxRO5.Text = ""
        '
        'RichTextBoxRO4
        '
        Me.RichTextBoxRO4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO4.Location = New System.Drawing.Point(548, 183)
        Me.RichTextBoxRO4.Name = "RichTextBoxRO4"
        Me.RichTextBoxRO4.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRO4.TabIndex = 24
        Me.RichTextBoxRO4.Text = ""
        '
        'RichTextBoxRO3
        '
        Me.RichTextBoxRO3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO3.Location = New System.Drawing.Point(548, 147)
        Me.RichTextBoxRO3.Name = "RichTextBoxRO3"
        Me.RichTextBoxRO3.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRO3.TabIndex = 23
        Me.RichTextBoxRO3.Text = ""
        '
        'RichTextBoxRO2
        '
        Me.RichTextBoxRO2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO2.Location = New System.Drawing.Point(548, 111)
        Me.RichTextBoxRO2.Name = "RichTextBoxRO2"
        Me.RichTextBoxRO2.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRO2.TabIndex = 22
        Me.RichTextBoxRO2.Text = ""
        '
        'RichTextBoxRO1
        '
        Me.RichTextBoxRO1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRO1.Location = New System.Drawing.Point(548, 75)
        Me.RichTextBoxRO1.Name = "RichTextBoxRO1"
        Me.RichTextBoxRO1.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxRO1.TabIndex = 21
        Me.RichTextBoxRO1.Text = ""
        '
        'RichTextBoxDettaglio
        '
        Me.RichTextBoxDettaglio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxDettaglio.Location = New System.Drawing.Point(548, 39)
        Me.RichTextBoxDettaglio.Name = "RichTextBoxDettaglio"
        Me.RichTextBoxDettaglio.Size = New System.Drawing.Size(100, 30)
        Me.RichTextBoxDettaglio.TabIndex = 20
        Me.RichTextBoxDettaglio.Text = ""
        '
        'ButtonSalvaRelazione
        '
        Me.ButtonSalvaRelazione.Location = New System.Drawing.Point(117, 3)
        Me.ButtonSalvaRelazione.Name = "ButtonSalvaRelazione"
        Me.ButtonSalvaRelazione.Size = New System.Drawing.Size(108, 23)
        Me.ButtonSalvaRelazione.TabIndex = 5
        Me.ButtonSalvaRelazione.Text = "Salva relazione"
        Me.ButtonSalvaRelazione.UseVisualStyleBackColor = True
        '
        'ButtonGeneraRelazione
        '
        Me.ButtonGeneraRelazione.Location = New System.Drawing.Point(3, 3)
        Me.ButtonGeneraRelazione.Name = "ButtonGeneraRelazione"
        Me.ButtonGeneraRelazione.Size = New System.Drawing.Size(108, 23)
        Me.ButtonGeneraRelazione.TabIndex = 4
        Me.ButtonGeneraRelazione.Text = "Genera relazione"
        Me.ButtonGeneraRelazione.UseVisualStyleBackColor = True
        '
        'RichTextBoxRelazione
        '
        Me.RichTextBoxRelazione.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxRelazione.Location = New System.Drawing.Point(3, 32)
        Me.RichTextBoxRelazione.Name = "RichTextBoxRelazione"
        Me.RichTextBoxRelazione.Size = New System.Drawing.Size(539, 884)
        Me.RichTextBoxRelazione.TabIndex = 0
        Me.RichTextBoxRelazione.Text = ""
        '
        'ImageList64
        '
        Me.ImageList64.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList64.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageList64.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageList128
        '
        Me.ImageList128.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList128.ImageSize = New System.Drawing.Size(128, 128)
        Me.ImageList128.TransparentColor = System.Drawing.Color.Transparent
        '
        'TimerSalvataggioAutomatico
        '
        Me.TimerSalvataggioAutomatico.Enabled = True
        Me.TimerSalvataggioAutomatico.Interval = 300000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 961)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Compositore visuale"
        CType(Me.PictureBoxFotoSelezionata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Documento.ResumeLayout(False)
        Me.Immagini.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Allegati.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.DataGridViewAllegati, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.Generale.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxFotoCopertina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxLogoAzienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Dettaglio.ResumeLayout(False)
        Me.Dettaglio.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridViewGenerale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxGenerale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.RO1.ResumeLayout(False)
        Me.RO1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataGridViewRO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.RO2.ResumeLayout(False)
        Me.RO2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.DataGridViewRO2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRO2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.RO3.ResumeLayout(False)
        Me.RO3.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        CType(Me.DataGridViewRO3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRO3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.RO4.ResumeLayout(False)
        Me.RO4.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.DataGridViewRO4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRO4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.RO5.ResumeLayout(False)
        Me.RO5.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        CType(Me.DataGridViewRO5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRO5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.RU1.ResumeLayout(False)
        Me.RU1.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        CType(Me.DataGridViewRU1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRU1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.RU2.ResumeLayout(False)
        Me.RU2.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        CType(Me.DataGridViewRU2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRU2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox27.ResumeLayout(False)
        Me.RU3.ResumeLayout(False)
        Me.RU3.PerformLayout()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        CType(Me.DataGridViewRU3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxRU3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.Perizia.ResumeLayout(False)
        Me.Relazione.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxScreenshot As RichTextBox
    Friend WithEvents ListViewFoto As ListView
    Friend WithEvents PictureBoxFotoSelezionata As PictureBox
    Friend WithEvents TextboxCartella As TextBox
    Friend WithEvents ImageList256 As ImageList
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Documento As TabPage
    Friend WithEvents Immagini As TabPage
    Friend WithEvents Allegati As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents WebBrowserAllegati As WebBrowser
    Friend WithEvents ButtonCartella As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents Generale As TabPage
    Friend WithEvents RO1 As TabPage
    Friend WithEvents RO2 As TabPage
    Friend WithEvents RO3 As TabPage
    Friend WithEvents RO4 As TabPage
    Friend WithEvents RO5 As TabPage
    Friend WithEvents RU1 As TabPage
    Friend WithEvents RU2 As TabPage
    Friend WithEvents RU3 As TabPage
    Friend WithEvents ComboBoxDimensioneIcone As ComboBox
    Friend WithEvents ImageList128 As ImageList
    Friend WithEvents ImageList64 As ImageList
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewAllegati As DataGridView
    Friend WithEvents ColumnAllegato As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDimensione As DataGridViewTextBoxColumn
    Friend WithEvents Relazione As TabPage
    Friend WithEvents RichTextBoxRelazione As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxIndirizzoAzienda As TextBox
    Friend WithEvents PictureBoxLogoAzienda As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNomeAzienda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxCF_PIVA As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBoxTipoRelazione As ComboBox
    Friend WithEvents TextBoxDataPerizia As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxProtocolloPerizia As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxPerito As ComboBox
    Friend WithEvents TextBoxNotaio As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBoxDotazioni As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxMatricola As TextBox
    Friend WithEvents TextBoxProduttore As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxTipoInvestimento As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxModello As TextBox
    Friend WithEvents PictureBoxFotoCopertina As PictureBox
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents ComboBoxGruppo As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxAnno As TextBox
    Friend WithEvents RichTextBoxValoreCespite As RichTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBoxAltreInfoCategoria As TextBox
    Friend WithEvents Dettaglio As TabPage
    Friend WithEvents LabelDettaglio As Label
    Friend WithEvents ButtonRinominaAllegati As Button
    Friend WithEvents TextBoxRinominaAllegati As TextBox
    Friend WithEvents ButtonPasteFotoCopertina As Button
    Friend WithEvents ButtonPasteLogoAzienda As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RichTextBoxGeneraleTestoIniziale As RichTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RichTextBoxGeneraleTestoFinale As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents RichTextBoxGeneraleDescrizione As RichTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBoxGeneraleTitolo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents PictureBoxGenerale As PictureBox
    Friend WithEvents TextBoxGeneraleDidascalia As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonGeneraleSpostaSu As Button
    Friend WithEvents ButtonGeneraleSpostaGiu As Button
    Friend WithEvents ButtonGeneraleAggiungiSezione As Button
    Friend WithEvents ButtonGeneraleRimuoviSezione As Button
    Friend WithEvents DataGridViewGenerale As DataGridView
    Friend WithEvents ButtonGeneraRelazione As Button
    Friend WithEvents ButtonSalvaRelazione As Button
    Friend WithEvents ButtonSalva As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBoxCostoTotale As TextBox
    Friend WithEvents TextBoxGuidaDettaglio As TextBox
    Friend WithEvents TimerSalvataggioAutomatico As Timer
    Friend WithEvents CheckBoxSalvataggioAutomatico As CheckBox
    Friend WithEvents LabelRO1 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DataGridViewRO1 As DataGridView
    Friend WithEvents ButtonRO1RimuoviSezione As Button
    Friend WithEvents ButtonRO1SpostaSu As Button
    Friend WithEvents ButtonRO1SpostaGiu As Button
    Friend WithEvents ButtonRO1AggiungiSezione As Button
    Friend WithEvents RichTextBoxRO1Descrizione As RichTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBoxRO1Titolo As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents PictureBoxRO1 As PictureBox
    Friend WithEvents TextBoxRO1Didascalia As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents ButtonRO1InserisciImmagine As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents RichTextBoxRO1TestoFinale As RichTextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TextBoxGuidaRO1 As TextBox
    Friend WithEvents RichTextBoxRO1TestoIniziale As RichTextBox
    Friend WithEvents LabelRO2 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents DataGridViewRO2 As DataGridView
    Friend WithEvents ButtonRO2RimuoviSezione As Button
    Friend WithEvents ButtonRO2SpostaSu As Button
    Friend WithEvents ButtonRO2SpostaGiu As Button
    Friend WithEvents ButtonRO2AggiungiSezione As Button
    Friend WithEvents RichTextBoxRO2Descrizione As RichTextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBoxRO2Titolo As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents PictureBoxRO2 As PictureBox
    Friend WithEvents TextBoxRO2Didascalia As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents ButtonRO2InserisciImmagine As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents RichTextBoxRO2TestoFinale As RichTextBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents TextBoxGuidaRO2 As TextBox
    Friend WithEvents RichTextBoxRO2TestoIniziale As RichTextBox
    Friend WithEvents LabelRO3 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents DataGridViewRO3 As DataGridView
    Friend WithEvents ButtonRO3RimuoviSezione As Button
    Friend WithEvents ButtonRO3SpostaSu As Button
    Friend WithEvents ButtonRO3SpostaGiu As Button
    Friend WithEvents ButtonRO3AggiungiSezione As Button
    Friend WithEvents RichTextBoxRO3Descrizione As RichTextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents TextBoxRO3Titolo As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents PictureBoxRO3 As PictureBox
    Friend WithEvents TextBoxRO3Didascalia As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents ButtonRO3InserisciImmagine As Button
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents RichTextBoxRO3TestoFinale As RichTextBox
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents TextBoxGuidaRO3 As TextBox
    Friend WithEvents RichTextBoxRO3TestoIniziale As RichTextBox
    Friend WithEvents LabelRO4 As Label
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents DataGridViewRO4 As DataGridView
    Friend WithEvents ButtonRO4RimuoviSezione As Button
    Friend WithEvents ButtonRO4SpostaSu As Button
    Friend WithEvents ButtonRO4SpostaGiu As Button
    Friend WithEvents ButtonRO4AggiungiSezione As Button
    Friend WithEvents RichTextBoxRO4Descrizione As RichTextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBoxRO4Titolo As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents PictureBoxRO4 As PictureBox
    Friend WithEvents TextBoxRO4Didascalia As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents ButtonRO4InserisciImmagine As Button
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents RichTextBoxRO4TestoFinale As RichTextBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents TextBoxGuidaRO4 As TextBox
    Friend WithEvents RichTextBoxRO4TestoIniziale As RichTextBox
    Friend WithEvents LabelRO5 As Label
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents DataGridViewRO5 As DataGridView
    Friend WithEvents ButtonRO5RimuoviSezione As Button
    Friend WithEvents ButtonRO5SpostaSu As Button
    Friend WithEvents ButtonRO5SpostaGiu As Button
    Friend WithEvents ButtonRO5AggiungiSezione As Button
    Friend WithEvents RichTextBoxRO5Descrizione As RichTextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents TextBoxRO5Titolo As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents PictureBoxRO5 As PictureBox
    Friend WithEvents TextBoxRO5Didascalia As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents ButtonRO5InserisciImmagine As Button
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents RichTextBoxRO5TestoFinale As RichTextBox
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents TextBoxGuidaRO5 As TextBox
    Friend WithEvents RichTextBoxRO5TestoIniziale As RichTextBox
    Friend WithEvents LabelRU1 As Label
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents DataGridViewRU1 As DataGridView
    Friend WithEvents ButtonRU1RimuoviSezione As Button
    Friend WithEvents ButtonRU1SpostaSu As Button
    Friend WithEvents ButtonRU1SpostaGiu As Button
    Friend WithEvents ButtonRU1AggiungiSezione As Button
    Friend WithEvents RichTextBoxRU1Descrizione As RichTextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents TextBoxRU1Titolo As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents PictureBoxRU1 As PictureBox
    Friend WithEvents TextBoxRU1Didascalia As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents ButtonRU1InserisciImmagine As Button
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents RichTextBoxRU1TestoFinale As RichTextBox
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents TextBoxGuidaRU1 As TextBox
    Friend WithEvents RichTextBoxRU1TestoIniziale As RichTextBox
    Friend WithEvents LabelRU2 As Label
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents DataGridViewRU2 As DataGridView
    Friend WithEvents ButtonRU2RimuoviSezione As Button
    Friend WithEvents ButtonRU2SpostaSu As Button
    Friend WithEvents ButtonRU2SpostaGiu As Button
    Friend WithEvents ButtonRU2AggiungiSezione As Button
    Friend WithEvents RichTextBoxRU2Descrizione As RichTextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents TextBoxRU2Titolo As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents PictureBoxRU2 As PictureBox
    Friend WithEvents TextBoxRU2Didascalia As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents ButtonRU2InserisciImmagine As Button
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents RichTextBoxRU2TestoFinale As RichTextBox
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents TextBoxGuidaRU2 As TextBox
    Friend WithEvents RichTextBoxRU2TestoIniziale As RichTextBox
    Friend WithEvents LabelRU3 As Label
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents DataGridViewRU3 As DataGridView
    Friend WithEvents ButtonRU3RimuoviSezione As Button
    Friend WithEvents ButtonRU3SpostaSu As Button
    Friend WithEvents ButtonRU3SpostaGiu As Button
    Friend WithEvents ButtonRU3AggiungiSezione As Button
    Friend WithEvents RichTextBoxRU3Descrizione As RichTextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents TextBoxRU3Titolo As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents PictureBoxRU3 As PictureBox
    Friend WithEvents TextBoxRU3Didascalia As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents ButtonRU3InserisciImmagine As Button
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents RichTextBoxRU3TestoFinale As RichTextBox
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents TextBoxGuidaRU3 As TextBox
    Friend WithEvents RichTextBoxRU3TestoIniziale As RichTextBox
    Friend WithEvents ButtonGeneraleInserisciImmagine As Button
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn7 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn8 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents CheckBoxRU1 As CheckBox
    Friend WithEvents CheckBoxRU2 As CheckBox
    Friend WithEvents CheckBoxRU3 As CheckBox
    Friend WithEvents ButtonApriPreset As Button
    Friend WithEvents Perizia As TabPage
    Friend WithEvents ButtonSalvaPerizia As Button
    Friend WithEvents ButtonGeneraPerizia As Button
    Friend WithEvents RichTextBoxPerizia As RichTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBoxFornitore As TextBox
    Friend WithEvents CheckBoxLeasing As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBoxRO1DettaglioPerizia As TextBox
    Friend WithEvents TextBoxRO2DettaglioPerizia As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBoxRO3DettaglioPerizia As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TextBoxRO4DettaglioPerizia As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBoxRO5DettaglioPerizia As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBoxRU1DettaglioPerizia As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents TextBoxRU2DettaglioPerizia As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TextBoxRU3DettaglioPerizia As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents RichTextBoxRU3 As RichTextBox
    Friend WithEvents RichTextBoxRU2 As RichTextBox
    Friend WithEvents RichTextBoxRU1 As RichTextBox
    Friend WithEvents RichTextBoxRO5 As RichTextBox
    Friend WithEvents RichTextBoxRO4 As RichTextBox
    Friend WithEvents RichTextBoxRO3 As RichTextBox
    Friend WithEvents RichTextBoxRO2 As RichTextBox
    Friend WithEvents RichTextBoxRO1 As RichTextBox
    Friend WithEvents RichTextBoxDettaglio As RichTextBox
    Friend WithEvents ButtonAggiorna As Button
End Class
