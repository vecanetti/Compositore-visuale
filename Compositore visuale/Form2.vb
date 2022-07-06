Public Class Form2
    Dim ImmaginePlaceholder As Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Ingranaggi.jpg")
    Const RTFinizio As String = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\fnil\fcharset0 Arial;}}\viewkind4\uc1\pard\fs23 "
    Const RTFfine As String = "\par}"
    Dim PresetCaricato As Boolean = False

    Private Sub ButtonCartella_Click(sender As Object, e As EventArgs) Handles ButtonCartella.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextboxCartella.Text = FolderBrowserDialog1.SelectedPath()
        End If
    End Sub

    Private Sub TextboxCartella_TextChanged(sender As Object, e As EventArgs) Handles TextboxCartella.TextChanged
        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            Form1.TextboxCartella.Text = TextboxCartella.Text
            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & "\Compositore visuale\Compositore visuale.txt") Then
                Me.Close()
            Else
                If PresetCaricato Then
                    Me.Close()
                Else
                    MsgBox("Non è presente un lavoro salvato nel percorso selezionato, selezionare un preset o ""Pratica vuota""")
                End If
            End If
        Else
            TextboxCartella.Text = ""
        End If
    End Sub

    Private Sub ButtonRiapriUltimoLavoro_Click(sender As Object, e As EventArgs) Handles ButtonRiapriUltimoLavoro.Click
        'lettura del file Impostazioni-utente.txt
        Try
            Dim DirectoryUtentePC As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            Dim NomeUtentePC As String = DirectoryUtentePC.Substring(DirectoryUtentePC.LastIndexOf("\") + 1)
            Dim FileSalvataggioImpostazioni As String = My.Application.Info.DirectoryPath & "\Impostazioni-" & NomeUtentePC & ".txt"
            If My.Computer.FileSystem.FileExists(FileSalvataggioImpostazioni) Then
                Dim FlussoImpostazioni As New IO.StreamReader(FileSalvataggioImpostazioni)
                Dim NomeDirectory = FlussoImpostazioni.ReadLine 'Uso questa cartella temporanea perché devo modificare TextboxCartella.Text solo quando il file è chiuso
                FlussoImpostazioni.Close()
                TextboxCartella.Text = NomeDirectory
            End If
        Catch ex As Exception
            MsgBox("Impossibile leggere il file di impostazioni, errore:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub TerminaPreset()
        If TextboxCartella.Text <> "" Then
            Me.Close()
        Else
            MsgBox("Selezionare una directory per il salvataggio del lavoro")
            PresetCaricato = True
        End If
    End Sub

    Private Sub ButtonPraticaVuota_Click(sender As Object, e As EventArgs) Handles ButtonPraticaVuota.Click
        Form1.TextBoxTipoInvestimento.Text = ""
        Form1.TextBoxDotazioni.Text = ""
        Form1.TextBoxAltreInfoCategoria.Text = ""
        TerminaPreset()
    End Sub

    Private Sub ButtonPraticaGenerica_Click(sender As Object, e As EventArgs) Handles ButtonPraticaGenerica.Click
        Form1.DataGridViewGenerale.Rows.Add(ImmaginePlaceholder, "Targhetta CE", "", "", "", "")
        Form1.TextBoxRO1DettaglioPerizia.Text = "in particolare la macchina impiega un controller __________"
        Form1.RichTextBoxRO1TestoIniziale.Rtf = RTFinizio & "La macchina è dotata di un controllore __________." & RTFfine
        Form1.DataGridViewRO1.Rows.Add(ImmaginePlaceholder, "Controllore", "", "La macchina è controllata da un microcontrollore __________.", RTFinizio & "La macchina è controllata da un microcontrollore __________" & RTFfine, "")
        'RO2
        Form1.TextBoxRO2DettaglioPerizia.Text = "in particolare il bene riceve dalla rete __________, la macchina ha indirizzo IP __________"
        Form1.RichTextBoxRO2TestoIniziale.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\froman\fprq2\fcharset0 Times New Roman;}{\f1\fswiss\fprq2\fcharset0 Arial;}{\f2\fswiss\fprq2\fcharset1 Segoe UI Symbol;}{\f3\fnil\fcharset0 Arial;}}{\colortbl ;\red255\green255\blue255;\red0\green255\blue255;\red68\green114\blue196;}\viewkind4\uc1\trowd\trgaph70\trleft-70\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl70\trpaddr70\trpaddfl3\trpaddfr3\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx1375\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx2820\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4264\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx5708\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx7152\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8596\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx10042\pard\intbl\widctlpar\sb60\sa60\sl360\slmult1\qc\cf1\b\f1\fs22 PREMESSA\line Interconnessione della macchina con TCP-IP\cell\cf0\f2\u10132?\cf1\f1\cell FASE 1\line Creazione disegno/ programma\cell\cf0\f2\u10132?\cf1\f1\cell FASE 2\line Caricamento del file in macchina\cell\cf0\f2\u10132?\cf1\f1\cell FASE 3\line Selezione programma e avvio lavoro\cell\row\pard\widctlpar\sb60\sa60\sl360\slmult1\cf0\b0 La macchina \'e8 \b interconnessa\b0  alla \b rete aziendale\b0  tramite protocollo TCP-IP con il \b sistema informatico di fabbrica \b0 __________.\f3\fs23\par}"
        Form1.DataGridViewRO2.Rows.Add(ImmaginePlaceholder, "Dettaglio indirizzo IP", "PREMESSA", "INTERCONNESSIONE FISICA: Connessione con la rete aziendale tramite ethernet con il protocollo TCP/IP", RTFinizio & "INTERCONNESSIONE FISICA:\par Connessione con la rete aziendale tramite ethernet con il protocollo TCP/IP" & RTFfine, "")
        'RO3
        Form1.TextBoxRO3DettaglioPerizia.Text = "il bene scambia automaticamente informazioni con il sistema logistico __________"
        Form1.RichTextBoxRO3TestoIniziale.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\froman\fprq2\fcharset0 Times New Roman;}{\f1\fswiss\fprq2\fcharset0 Arial;}{\f2\fswiss\fprq2\fcharset1 Segoe UI Symbol;}{\f3\fnil\fcharset0 Arial;}}{\colortbl ;\red255\green255\blue255;\red0\green255\blue255;\red68\green114\blue196;}\viewkind4\uc1\trowd\trgaph70\trleft-70\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl70\trpaddr70\trpaddfl3\trpaddfr3\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx1375\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx2820\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4264\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx5708\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx7152\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8596\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx10042\pard\intbl\widctlpar\sb60\sa60\sl360\slmult1\qc\cf1\b\f1\fs22 PREMESSA\line Si genera l\rquote ODL con il gestionale\cell\cf0\f2\u10132?\cf1\f1\cell FASE 1\line Esecuzione del lavoro\cell\cf0\f2\u10132?\cf1\f1\cell FASE 2\line Ricezione dati sulla produzione\cell\cf0\f2\u10132?\cf1\f1\cell FASE 3\line Storico e statistiche produzione\cell\row\pard\widctlpar\sb60\sa60\sl360\slmult1\cf0\b0 La macchina \'e8 \b integrata\b0  con il \b sistema logistico\b0  __________.\f3\fs23\par}"
        'RO4
        Form1.TextBoxRO4DettaglioPerizia.Text = "il bene è dotato di un'interfaccia con schermo touch __________"
        Form1.RichTextBoxRO4TestoIniziale.Rtf = RTFinizio & "La macchina è dotata di una interfaccia che rispetta il requisito ed è facilmente comprensibile per un operatore esperto del settore." & RTFfine
        Form1.DataGridViewRO4.Rows.Add(ImmaginePlaceholder, "HMI Touchscreen", "", "L’interfaccia di controllo della macchina è costituita da uno schermo touch screen ___________.", RTFinizio & "L’interfaccia di controllo della macchina è costituita da uno schermo touch screen." & RTFfine, "")
        Form1.TextBoxRO5DettaglioPerizia.Text = "la macchina è dotata della documentazione che dimostra il rispetto del requisito"
        Form1.RichTextBoxRO5TestoIniziale.Rtf = RTFinizio & "La macchina è dotata della documentazione che dimostra il rispetto del requisito." & RTFfine
        Form1.DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "Certificato di conformità", "", "", "", "")
        Form1.DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "Targhetta CE", "", "", "", "")
        Form1.DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "Manuale in formato cartaceo", "", "", "", "")
        Form1.TextBoxRU1DettaglioPerizia.Text = "la telediagnosi è eseguita mediante accesso remoto __________"
        Form1.RichTextBoxRU1TestoIniziale.Text = "La macchina, tramite il portale di controllo e gestione, permette di ottenere informazioni utili alla telediagnosi e al telecontrollo."
        Form1.DataGridViewRU1.Rows.Add(ImmaginePlaceholder, "Accesso remoto tramite software ________", "", "", "", "")
        Form1.CheckBoxRU1.Checked = True
        Form1.TextBoxRU2DettaglioPerizia.Text = "la macchina controlla in modo attivo, tra gli altri, __________ temperature e avanzamento"
        Form1.RichTextBoxRU2TestoIniziale.Text = "Il sistema di controllo monitora costantemente numerosi parametri, tra cui __________. Vi è un monitoraggio degli errori con registrazione dello storico."
        Form1.DataGridViewRU2.Rows.Add(ImmaginePlaceholder, "Dettaglio lavorazione con monitoraggio in tempo reale", "", "", "", "")
        Form1.CheckBoxRU2.Checked = True
        Form1.TextBoxRU3DettaglioPerizia.Text = "la macchina è dotata di un software __________ che permette la simulazione della lavorazione"
        Form1.RichTextBoxRU3TestoIniziale.Text = "Il software di controllo e gestione dispone della funzionalità di simulazione."
        Form1.DataGridViewRU3.Rows.Add(ImmaginePlaceholder, "Esecuzione della simulazione", "", "", "", "")
        Form1.CheckBoxRU3.Checked = False
        TerminaPreset()
    End Sub

    Private Sub ButtonTornio_Click(sender As Object, e As EventArgs) Handles ButtonTornio.Click
        Form1.ComboBoxGruppo.SelectedIndex = 0
        Form1.ComboBoxCategoria.SelectedIndex = 0
        Form1.TextBoxTipoInvestimento.Text = "Tornio"

        TerminaPreset()
    End Sub

    Private Sub ButtonFresa_Click(sender As Object, e As EventArgs) Handles ButtonFresa.Click
        Form1.ComboBoxGruppo.SelectedIndex = 0
        Form1.ComboBoxCategoria.SelectedIndex = 0
        Form1.TextBoxTipoInvestimento.Text = "Centro di lavoro"


        TerminaPreset()
    End Sub

    Private Sub ButtonStampante3DZ_Click(sender As Object, e As EventArgs) Handles ButtonStampante3DZ.Click
        Form1.ComboBoxTipoRelazione.SelectedIndex = 1 'Perizia asseverata
        Form1.ComboBoxPerito.SelectedIndex = 0 'Perito = Marco
        Form1.TextBoxDataPerizia.Text = Now().ToLongDateString
        Form1.ComboBoxGruppo.SelectedIndex = 0 'Gruppo 1
        Form1.ComboBoxCategoria.SelectedIndex = 9 'Tipo 10 = manifattura additiva
        Form1.TextBoxTipoInvestimento.Text = "Stampante 3D"
        Form1.TextBoxProduttore.Text = "Markforged"
        Form1.TextBoxDotazioni.Text = "La stampante è fornita con le credenziali per l'accesso al portale web di controllo e con un set di dotazioni iniziali"
        Form1.TextBoxAltreInfoCategoria.Text = ""
        Form1.TextBoxFornitore.Text = "3DZ S.p.A. (C.F. e P.IVA 05142580264)"
        Form1.RichTextBoxGeneraleTestoIniziale.Text = "Si tratta di una stampante 3D che realizza oggetti tridimensionali mediante produzione additiva, partendo da un modello CAD 3D digitale."
        Form1.DataGridViewGenerale.Rows.Add(ImmaginePlaceholder, "Targhetta CE della stampante", "", "", "", "")
        Form1.TextBoxRO1DettaglioPerizia.Text = "la macchina impiega un controller proprietario"
        Form1.DataGridViewRO1.Rows.Add(ImmaginePlaceholder, "Controllore Markforged", "", "La macchina è controllata da un microcontrollore proprietario Markforged.", RTFinizio & "La macchina è controllata da un microcontrollore proprietario Markforged." & RTFfine, "")
        'RO2
        Form1.TextBoxRO2DettaglioPerizia.Text = "il bene è interfacciato con un portale di controllo che consente di caricare file tridimensionali dai sistemi informatici dell’azienda inviandoli alla macchina, la macchina ha un indirizzo IP sulla LAN dell’azienda"
        Form1.RichTextBoxRO2TestoIniziale.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\froman\fprq2\fcharset0 Times New Roman;}{\f1\fswiss\fprq2\fcharset0 Arial;}{\f2\fswiss\fprq2\fcharset1 Segoe UI Symbol;}{\f3\fnil\fcharset0 Arial;}}{\colortbl ;\red255\green255\blue255;\red0\green255\blue255;\red68\green114\blue196;}\viewkind4\uc1\trowd\trgaph70\trleft-108\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl70\trpaddr70\trpaddfl3\trpaddfr3\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx2013\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4134\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6255\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8376\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx10498\pard\intbl\widctlpar\sb60\sa60\sl360\slmult1\qc\cf1\b\f1\fs22 PREMESSA\line Interconnessione della macchina con TCP-IP\cell\cf0\f2\u10132?\cf1\f1\cell FASE 1\line Creazione disegno e file di stampa\cell\cf0\f2\u10132?\cf1\f1\cell FASE 2\line Caricamento del file 3D in macchina\cell\row\pard\widctlpar\sb60\sa60\sl360\slmult1\cf0\b0 La macchina \'e8 \b interconnessa\b0  alla \b rete aziendale\b0  tramite protocollo TCP-IP con il \b sistema informatico di fabbrica \b0 in cloud accessibile da qualsiasi browser e posizione.\par\pard\f3\fs23\par}"
        Form1.DataGridViewRO2.Rows.Add(ImmaginePlaceholder, "Sinottico macchina con dettaglio IP", "PREMESSA", "INTERCONNESSIONE FISICA: Connessione con la rete aziendale tramite ethernet con il protocollo TCP/IP", RTFinizio & "INTERCONNESSIONE FISICA:\par Connessione con la rete aziendale tramite ethernet con il protocollo TCP/IP" & RTFfine, "")
        Form1.DataGridViewRO2.Rows.Add(ImmaginePlaceholder, "Accesso a sistema informatico per invio programmi/file alla macchina", "FASE 1", "Creazione del disegno del prodotto", RTFinizio & "Creazione del disegno del prodotto" & RTFfine, "")
        Form1.DataGridViewRO2.Rows.Add(ImmaginePlaceholder, "Accesso a sistema informatico per invio programmi/file alla macchina", "FASE 2", "Sistema informatico: eger.io Produttore Markforged Caricamento file di produzione 3D sul sistema informatico in cloud che poi lo invia alla macchina.", RTFinizio & "Sistema informatico: \b eger.io\par\b0 Produttore\b Markforged\b0\par\pard Caricamento file di produzione 3D sul sistema informatico in cloud che poi lo invia alla macchina." & RTFfine, "")
        'RO3
        Form1.TextBoxRO3DettaglioPerizia.Text = "la macchina, attraverso il software remoto di controllo, invia i log di funzionamento e produzione ad un sistema logistico in cloud, che storicizza ed elabora i dati"
        Form1.RichTextBoxRO3TestoIniziale.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}{\f1\froman\fprq2\fcharset0 Times New Roman;}{\f2\fswiss\fprq2\fcharset1 Segoe UI Symbol;}{\f3\fnil\fcharset0 Arial;}}{\colortbl ;\red255\green255\blue255;\red0\green255\blue255;\red68\green114\blue196;}\viewkind4\uc1 \pard\widctlpar\tx5123\f0\fs22 Di seguito i punti di dettaglio per l\rquote integrazione.\par\trowd\trgaph70\trleft-108\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl70\trpaddr70\trpaddfl3\trpaddfr3\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx3452\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx7012\clvertalc\clcbpat3\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx10574\pard\intbl\widctlpar\sb60\sa60\sl360\slmult1\qc\cf1\b FASE 1\line Esecuzione del lavoro\cell\cf0\f2\u10132?\cf1\f0\cell FASE 2\line Fine lavorazione e rilevamento dati macchina\cell\row\pard\cf0\b0\f3\fs23\par}"
        Form1.DataGridViewRO3.Rows.Add(ImmaginePlaceholder, "Avanzamento del lavoro da portale in cloud", "FASE 1", "", "", "")
        Form1.DataGridViewRO3.Rows.Add(ImmaginePlaceholder, "eQuadrant rileva lo storico dei dati logistici in particolare la quantità di materiale e il tempo di produzione", "FASE 2", "Sistema Logistico: eQuadrant Produttore: Besquare Srl", RTFinizio & "Sistema Logistico: eQuadrant\par Produttore: Besquare Srl" & RTFfine, "")
        'RO4
        Form1.TextBoxRO4DettaglioPerizia.Text = "la macchina è dotata di uno schermo touch che permette il controllo e mostra lo stato"
        Form1.DataGridViewRO4.Rows.Add(ImmaginePlaceholder, "HMI Touch", "", "L’interfaccia di controllo della macchina è costituita da uno schermo touch screen.", RTFinizio & "L’interfaccia di controllo della macchina è costituita da uno schermo touch screen." & RTFfine, "")
        Form1.TextBoxRO5DettaglioPerizia.Text = ""
        Form1.DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "Certificato di conformità", "", "", "", "")
        Form1.DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "Targhetta CE", "", "", "", "")
        Form1.DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "Manuale in formato cartaceo", "", "", "", "")
        Form1.TextBoxRU1DettaglioPerizia.Text = "la telediagnosi è eseguita mediante il portale per il controllo remoto"
        Form1.RichTextBoxRU1TestoIniziale.Text = "La macchina, tramite il portale di controllo e gestione, permette di ottenere informazioni utili alla telediagnosi e al telecontrollo."
        Form1.DataGridViewRU1.Rows.Add(ImmaginePlaceholder, "Il portale per la telediagnosi", "", "", "", "")
        Form1.CheckBoxRU1.Checked = True
        Form1.TextBoxRU2DettaglioPerizia.Text = "la macchina controlla in modo attivo, tra gli altri, movimento assi, temperature e avanzamento"
        Form1.RichTextBoxRU2TestoIniziale.Text = "Il sistema di controllo monitora costantemente numerosi parametri, tra cui le temperature. Vi è un monitoraggio degli errori con registrazione dello storico."
        Form1.DataGridViewRU2.Rows.Add(ImmaginePlaceholder, "Dettaglio lavorazione con monitoraggio in tempo reale", "", "", "", "")
        Form1.CheckBoxRU2.Checked = True
        Form1.TextBoxRU3DettaglioPerizia.Text = "il software permette la simulazione della lavorazione"
        Form1.RichTextBoxRU3TestoIniziale.Text = "Il software di controllo e gestione dispone della funzionalità di simulazione."
        Form1.DataGridViewRU3.Rows.Add(ImmaginePlaceholder, "Esecuzione della simulazione", "", "", "", "")
        Form1.CheckBoxRU3.Checked = True
        TerminaPreset()
    End Sub


    Private Function ResizeImage(ByVal InputImageFile As String) As Image
        Dim MaxDim As Integer
        Dim InputImage As Image = Image.FromFile(InputImageFile)
        Form1.PictureBoxFotoSelezionata.Load(InputImageFile)
        If InputImage.Size.Width > InputImage.Size.Height Then MaxDim = InputImage.Size.Width Else MaxDim = InputImage.Size.Height
        Dim Scala As Integer = Math.Floor(MaxDim / 1000)
        If Scala > 1 Then
            Return New Bitmap(InputImage, New Size(InputImage.Size.Width / Scala, InputImage.Size.Height / Scala))
        Else
            Return InputImage
        End If
    End Function

    Private Sub ButtonImportaDaApp_Click(sender As Object, e As EventArgs) Handles ButtonImportaDaApp.Click
        If Form1.TextboxCartella.Text <> "" Then
            For Each File As String In My.Computer.FileSystem.GetFiles(Form1.TextboxCartella.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.jpg")
                If File.IndexOf("\Compositore visuale\") < 0 Then
                    Dim Parti As String() = Split(File, "-")
                    If Parti.Length > 3 Then
                        Dim Sezione As String = Parti(Parti.Length - 3)
                        Dim Descrizione As String = ""
                        If My.Computer.FileSystem.FileExists(File.Substring(0, File.Length() - 3) & "txt") Then
                            Dim FlussoDescrizione As New IO.StreamReader(File.Substring(0, File.Length() - 3) & "txt")
                            Descrizione = FlussoDescrizione.ReadLine
                            While Not FlussoDescrizione.EndOfStream
                                Descrizione = Descrizione & vbCrLf & FlussoDescrizione.ReadLine
                            End While
                        End If
                        Select Case Sezione
                            Case "Generale"
                                Form1.DataGridViewGenerale.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewGenerale.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\Generale" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewGenerale.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewGenerale.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RO1"
                                Form1.DataGridViewRO1.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRO1.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RO1" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRO1.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRO1.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RO2"
                                Form1.DataGridViewRO2.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRO2.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RO2" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRO2.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRO2.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RO3"
                                Form1.DataGridViewRO3.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRO3.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RO3" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRO3.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRO3.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RO4"
                                Form1.DataGridViewRO4.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRO4.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RO4" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRO4.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRO4.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RO5"
                                Form1.DataGridViewRO5.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRO5.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RO5" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRO5.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRO5.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RU1"
                                Form1.DataGridViewRU1.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRU1.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RU1" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRU1.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRU1.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RU2"
                                Form1.DataGridViewRU2.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRU2.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RU2" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRU2.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRU2.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                            Case "RU3"
                                Form1.DataGridViewRU3.Rows.Add(ResizeImage(File), "", "", Descrizione, RTFinizio & Descrizione & RTFfine, "")
                                Dim RigaSelezionata = Form1.DataGridViewRU3.Rows.Count() - 1
                                Dim FilePathAndName As String = "\Compositore visuale\RU3" & RigaSelezionata & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
                                Form1.DataGridViewRU3.Rows(RigaSelezionata).Cells(0).Value.Save(Form1.TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
                                Form1.DataGridViewRU3.Rows(RigaSelezionata).Cells(5).Value = FilePathAndName
                        End Select 'case
                    End If
                End If
            Next
        Else
            MsgBox("Selezionare prima una cartella contenente file")
        End If
        Me.Close()
    End Sub
End Class