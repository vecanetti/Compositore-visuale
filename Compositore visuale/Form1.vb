Public Class Form1
    'Costanti
    Const DocRtfInizio As String = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\fnil\fcharset0 Arial;}}\viewkind4\uc1 \pard\sa200\sl276\slmult1\f0\fs22\lang16 "
    Const DocRtfFine As String = "\par}"
    Dim GruppoEPunto(3, 12) As String
    Dim ImmaginePlaceholder As Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Ingranaggi.jpg")
    Dim FileModelloBaseRTF1 As String = My.Application.Info.DirectoryPath & "\Modello relazione tecnica.rtf"
    Dim FileModelloBaseRTF23 As String = My.Application.Info.DirectoryPath & "\Modello relazione tecnica23.rtf"
    Dim FileModelloBasePeriziaRTF As String = My.Application.Info.DirectoryPath & "\Modello perizia asseverata.rtf"
    Dim AllegatoSelezionato As Integer = -1

    'Guide
    Const GuidaRO1a As String = "Controllo per mezzo di CNC (Computer Numerical Control) e/o PLC (Programmable Logic Controller)" & vbCrLf & "Descrivere come si realizza il controllo, le verifiche fatte a supporto, il materiale conseguente che si allega (immagini videate, ecc.) o a cui si rinvia (doc tecnica del fornitore, fascicolo tecnico di costruzione, ecc.). Esempio: identificazione del sistema di controllo (sigla del costruttore utilizzato nell’ordine di acquisto), per controllori la denominazione dell’unità di controllo; caratteristiche funzionali del PLC o del CNC o di ALTRO; (eventuali) elementi di controllo del PLC o del CNC o di altro." & vbCrLf & "Inserire poi eventualmente: serial Number del sistema, configurazione(CPU, memoria, I / O, porte di comunicazione, ecc.), configurazione dei sistemi DCS, linguaggio di programmazione." & vbCrLf & "Per controllori: denominazione dell'unità di controllo, consorzi che partecipano alla diffusione"
    Const GuidaRO1b As String = "Scambio di informazioni con sistemi interni (es.: sistema gestionale, sistemi di pianificazione, sistemi di progettazione e sviluppo del prodotto, monitoraggio, anche in remoto, e controllo, altre macchine dello stabilimento, ecc.) e/o esterni (es.: clienti, fornitori, partner nella progettazione e sviluppo collaborativo, altri siti di produzione, supply chain, ecc.) per mezzo di un collegamento basato su specifiche documentate, disponibili pubblicamente e internazionalmente riconosciute (esempi: TCP/IP, HTTP, MQTT, ecc.)"
    Const GuidaRO2a As String = "Interconnessione ai sistemi informatici di fabbrica con caricamento da remoto di istruzioni e/o part program" & vbCrLf & "Descrivere come si realizza l’interconnessione, le verifiche fatte a supporto, il materiale conseguente che si allega (immagini videate, ecc.) o a cui si rinvia (doc tecnica del fornitore, fascicolo tecnico di costruzione, ecc.). Questo vale sia:" & vbCrLf & "a) IN INGRESSO, invio da remoto di informazioni al PLC sulla ricettazione ancorché sulla programmazione, ecc.;" & vbCrLf & "b) IN USCITA, invio in remoto informazioni sul funzionamento del macchinario o sistema (numero pezzi prodotti, difettosità, ecc.)." & vbCrLf & "Esempio: descrizione dell’interconnessione (con ERP, MES, SCADA, PC di ufficio, ecc.); descrizione del protocollo di comunicazione (TCP/IP, http, FTP, ecc.), specifiche della fornitura rilasciate dal produttore; indirizzi IP dei dispositivi; descrizione delle informazioni scambiate e, possibilmente, screenshot/fotografia delle videate/monitor; (se disponibili) Schemi elettrici dell’interconnessione."
    Const GuidaRO2b As String = "Il bene è identificato univocamente, al fine di riconoscere l’origine delle informazioni, mediante l’utilizzo di standard di indirizzamento internazionalmente riconosciuti (es.: indirizzo IP)."

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'inizializzazione e caricamento delle tipologie di lavori
        ComboBoxDimensioneIcone.SelectedIndex = 1 'per default dimensione media
        'descrizioni della Circolare 4
        GruppoEPunto(0, 0) = "1. \b macchine utensili per asportazione\b0. In tale contesto si fa riferimento a tutte le macchine atte alla trasformazione di pezzi, indipendentemente dal materiale lavorato(metallo, compositi, marmo, polimeri, legno, ceramica, ecc.). Ne sono un esempio torni a CN, centri di lavoro, centri di rettifica, ecc."
        GruppoEPunto(0, 1) = "2. \b macchine utensili operanti con laser e altri processi a flusso di energia (ad esempio plasma, waterjet, fascio di elettroni), elettroerosione, processi elettrochimici\b0. Sono comprese, per esempio, macchine per la lavorazione a ultrasuono (USM), a getto abrasivo (AJM), waterjet (WJM), chimiche (CHM), elettrochimiche (ECM), elettroerosione (EDM), taglio laser (LBM), con fascio di elettroni o di ioni (EBM), plasma (PAM), ecc."
        GruppoEPunto(0, 2) = "3. \b macchine e impianti per la realizzazione di prodotti mediante la trasformazione dei materiali e delle materie prime\b0. In questo caso, si intendono macchine e impianti impiegati nell'industria manifatturiera discreta, nell'industria di processo e in quella di trasformazione che devono essere dotati di proprietà di riconfigurabilità o flessibilità (sia per quanto riguarda le tipologie di operazioni che possono essere eseguite, sia per quanto riguarda la gestione dei flussi all'interno dell’impianto). Nel rispetto delle condizioni sopra esposte, la voce nell'elenco è applicabile indipendentemente dal prodotto(o semilavorato) realizzato o trasformato o trattato e dal relativo ciclo tecnologico e indipendentemente dal tipo di realizzazione o trasformazione o trattamento (meccanico, chimico, fisico, ecc.) indotto sul prodotto o semilavorato. Per impianto o porzione di impianto si intende un insieme di macchine connesse fisicamente tra di loro anche se ogni macchina o attrezzatura funziona In maniera indipendente. L'impianto gode del beneficio fiscale anche nel caso In cui i singoli componenti provengano da fornitori diversi"
        GruppoEPunto(0, 3) = "4. \b macchine utensili per la deformazione plastica dei metalli e altri materiali\b0. Si intendono tutte quelle macchine che eseguono la deformazione plastica operanti sia a freddo che a caldo. Ne sono un esempio presse, punzonatrici a CN, laminatoi, pannellatrici, trafilatrici, ecc."
        GruppoEPunto(0, 4) = "5. \b macchine utensili per l'assemblaggio, la giunzione e la saldatura\b0. In questo caso possono essere compresi anche linee, celle e sistemi di assemblaggio"
        GruppoEPunto(0, 5) = "6. \b macchine per il confezionamento e l'imballaggio\b0. Queste possono includere per esempio macchine adibite al packaging e all'imbottigliamento"
        GruppoEPunto(0, 6) = "7. \b macchine utensili di de-produzione e riconfezionamento per recuperare materiali e funzioni da scarti industriali e prodotti di ritorno a fine vita (ad esempio macchine per il disassemblaggio, la separazione, la frantumazione, il recupero chimico)\b0. Sono inclusi i dispositivi che, In un'ottica di economia circolare, sono finalizzati al riutilizzo diretto, alla riparazione, al remanufacturing e al riciclo/riutilizzo delle materie prime. Sono da ritenersi escluse le macchine finalizzate allo smaltimento In discarica e quelle finalizzate al recupero energetico"
        GruppoEPunto(0, 7) = "8. \b robot, robot collaborativi e sistemi multi-robot\b0 "
        GruppoEPunto(0, 8) = "9. \b macchine utensili e sistemi per il conferimento o la modifica delle caratteristiche superficiali dei prodotti o la funzionalizzazione delle superfici\b0. Ne sono un esempio: lappatrici, rettificatrici, macchine per trattamenti superficiali, termici e/o chimici, macchine per il coating, macchine per granigliatura, sabbiatura, pallinatura, vibrofinitura, verniciatura, funzionalizzazione mediante plasma, stampa su carta e tessuti, funzionalizzazione con plasma, smaltatura, decorazione della ceramica, ecc."
        GruppoEPunto(0, 9) = "10. \b macchine per la manifattura additiva utilizzate in ambito industriale\b0. Ne sono un esempio le macchine per laser melting/sintering di polveri metalliche o polimeri, ecc."
        GruppoEPunto(0, 10) = "11. \b macchine, anche motrici e operatrici \b0(sono comprese, per esempio, macchine per l'agricoltura 4.0, quali tutte le trattrici e le macchine agricole - portate, trainate e semoventi - che consentono la lavorazione di precisione in campo grazie all'utilizzo di elettronica, sensori e gestione computerizzata delle logiche di controllo; sono, inoltre, inclusi dispositivi e macchine di supporto quali, ad esempio, sistemi di sensori In campo, stazioni meteo e droni)\b, strumenti e dispositivi per il carico e lo scarico, la movimentazione, la pesatura e la cernita automatica dei pezzi \b0(es. carrelli elevatori, sollevatori, carriponte, gru mobili, gru a portale)\b, dispositivi di sollevamento e manipolazione automatizzati \b0(es. manipolatori industriali, sistemi di pallettizzazione e dispositivi pick And place)\b, AGV e sistemi di convogliamento e movimentazione flessibili, e/o dotati di riconoscimento dei pezzi (ad esempio \b0 sistemi attivi come \b RFID, \b0 sistemi passivi come ad esempio QR code, \b visori e sistemi di visione e meccatronici)\b0. Si precisa che l'espressione ""macchine motrici"" non include i veicoli ai sensi della definizione di cui all'art. 1 della Direttiva 70/156/CEE"
        GruppoEPunto(0, 11) = "12. \b magazzini automatizzati interconnessi ai sistemi gestionali di fabbrica\b0. Si intendono, per esempio, magazzini automatici asserviti da traslo-elevatori o mini-loaders e software WMS per la gestione delle missioni in/out; i sistemi di selezionamento, prelievo e deposito automatico controllati da software di gestione e/o il controllo delle scorte e dei punti di riordino"
        GruppoEPunto(1, 0) = "1. \b sistemi di misura a coordinate e no (a contatto, non a contatto, sistemi ibridi, multi - sensore o basati su tomografia computerizzata tridimensionale) e relativa strumentazione per la verifica dei requisiti micro e macro geometrici di prodotto per qualunque livello di scala dimensionale(dalla larga scala alla scala micro-metrica o nano-metrica) al fine di assicurare e tracciare la qualità del prodotto e che consentono di qualificare i processi di produzione In maniera documentabile e connessa al sistema informativo di fabbrica\b0. In questa voce sono comprese per esempio le Coordinate Measuring Machine (CMM) utilizzate per l 'ispezione geometrica, dimensionale e per l’identificazione di geometrie incognite"
        GruppoEPunto(1, 1) = "2. \b altri sistemi di monitoraggio in process per assicurare e tracciare la qualità del prodotto o del processo produttivo e che consentono di qualificare i processi di produzione In maniera documentabile e connessa al sistema informativo di fabbrica\b0, diretta o indiretta. Sono compresi ad esempio i sistemi per il controllo di processo, il monitoraggio delle emissioni, delle vibrazioni, della temperatura e i sistemi per il controllo della forza e della potenza, i test di prodotto durante la fase di giunzione e assemblaggio industriale, le bilance di controllo peso, telecamere di controllo riempimento, stazioni di testing, validazione, collaudo e calibratura, ecc."
        GruppoEPunto(1, 2) = "3. \b sistemi per l'ispezione e la caratterizzazione dei materiali (ad esempio macchine di prova materiali, macchine per il collaudo dei prodotti realizzati, sistemi per prove o collaudi non distruttivi, tomografia) in grado di verificare le caratteristiche dei materiali in ingresso o in uscita al processo e che vanno a costituire il prodotto risultante a livello macro (ad esempio caratteristiche meccaniche) o micro (ad esempio porosità, inclusioni) e di generare opportuni report di collaudo da inserire nel sistema informativo aziendale\b0 "
        GruppoEPunto(1, 3) = "4. \b dispositivi intelligenti per il test delle polveri metalliche e sistemi di monitoraggio in continuo che consentono di qualificare i processi di produzione mediante tecnologie additive\b0. Ne sono un esempio sistemi utilizzati per il supporto tecnico, l'analisi e l’ispezione in termini di composizione, granulometria, flussometria, conservazione, e l'omogeneità delle polveri"
        GruppoEPunto(1, 4) = "5. \b sistemi intelligenti e connessi di marcatura e tracciabilità dei lotti produttivi e / o dei singoli prodotti (ad esempio RFID – Radio Frequency Identification)\b0. In questo senso possono rientrare anche altre tecnologie quali Bar Code Reader, Pistole, Sistemi di riconoscimento etichette su trans-pallet, dispositivi IoT, sistemi di geolocalizzazione inbound/outbound"
        GruppoEPunto(1, 5) = "6. \b sistemi di monitoraggio e controllo delle condizioni di lavoro delle macchine(ad esempio forze, coppia e potenza di lavorazione; usura tridimensionale degli utensili a bordo macchina; stato di componenti o sotto-insiemi delle macchine) e dei sistemi di produzione interfacciati con i sistemi informativi di fabbrica e/o con soluzioni cloud\b0. Si intendono per esempio, i sistemi dedicati alla misura dell'utensile durante la truciolatura in termini di potenza, vibrazioni e sforzo e/o quelli dedicati al controllo geometrico dell'utensile post truciolatura"
        GruppoEPunto(1, 6) = "7. \b strumenti e dispositivi per l'etichettatura, l’identificazione o la marcatura automatica dei prodotti, con collegamento con il codice e la matricola del prodotto stesso In modo da consentire ai manutentori di monitorare la costanza delle prestazioni dei prodotti nel tempo e di agire sul processo di progettazione dei futuri prodotti In maniera sinergica, consentendo il richiamo di prodotti difettosi o dannosi\b0. Ne sono un esempio sistemi capaci di stampare e applicare l'etichetta sui prodotti in automatico e quindi senza l'intervento dell’operatore"
        GruppoEPunto(1, 7) = "8. \b componenti, sistemi e soluzioni intelligenti per la gestione, l'utilizzo efficiente e il monitoraggio dei consumi energetici e idrici e per la riduzione delle emissioni\b0. Questa voce si riferisce a quelle soluzioni che interagiscono a livello di macchine e componenti del sistema produttivo e basate sulla combinazione di sensori, sistemi di controllo e di elaborazione/ simulazione connessi e In grado di gestire il consumo della risorsa energetica, idrica e per la riduzione delle emissioni In maniera intelligente recuperando o rilasciando energia In base allo stato del processo e delle macchine, ottimizzando la distribuzione di energia elettrica e minimizzando eventuali sovraccarichi (smart grid). Sono invece escluse soluzioni finalizzate alla produzione di energia (ad es. sistemi cogenerativi, sistemi di generazione di energia da qualunque fonte rinnovabile e non); si ricorda peraltro che queste ultime possono beneficiare di misure di agevolazione all'efficienza energetica già in vigore (come i ""certificati bianchi"")"
        GruppoEPunto(1, 8) = "9. \b filtri e sistemi \b0(si intendono anche impianti) \b di trattamento e recupero di acqua, aria, olio, sostanze chimiche, polveri con sistemi di segnalazione dell'efficienza filtrante e della presenza di anomalie o sostanze aliene al processo o pericolose, integrate con il sistema di fabbrica e in grado di avvisare gli operatori e/o di fermare le attività di macchine e impianti\b0 "
        GruppoEPunto(2, 0) = "1. \b banchi e postazioni di lavoro dotati di soluzioni ergonomiche In grado di adattarli in maniera automatizzata alle caratteristiche fisiche degli operatori (ad esempio caratteristiche biometriche, età, presenza di disabilità)\b0. Ne sono un esempio postazioni di lavoro ergonomiche integrate in cui l'operatore ha a disposizione moduli di trasporto intelligenti (per l'approvvigionamento delle merci), terminali touch screen (con guida intuitiva delle attività per l'utente), illuminazione antiabbagliante e personalizzabile della postazione (per un'illuminazione ottimale della postazione di lavoro), elementi con braccio a snodo (per l'ottimizzazione ergonomica dello spazio di prelievo), tavolo di lavoro regolabile elettricamente In altezza (per un rapido adattamento a diverse condizioni fisiche e lavorative dell'operatore)"
        GruppoEPunto(2, 1) = "2. \b sistemi per il sollevamento/traslazione di parti pesanti o oggetti esposti ad alte temperature In grado di agevolare In maniera intelligente/robotizzata/interattiva il compito dell'operatore\b0 "
        GruppoEPunto(2, 2) = "3. \b dispositivi wearable, apparecchiature di comunicazione tra operatore/operatori e sistema produttivo, dispositivi di realtà aumentata e virtual reality\b0. Un esempio è costituito da dispositivi intelligenti In grado di fornire istruzioni sul lavoro e di visualizzare In real time i dati sul funzionamento delle macchine e sulle attività che gli operatori dovranno svolgere"
        GruppoEPunto(2, 3) = "4. \b interfacce uomo-macchina (HMI) intelligenti che supportano l'operatore in termini di sicurezza ed efficienza delle operazioni di lavorazione, manutenzione, logistica\b0 "

        'GUIDE
        TextBoxGuidaDettaglio.Text = "Informazioni generali sulla macchina/impianto:" & vbCrLf & "1) Foto geneale dell'impianto" & vbCrLf & "2) Targhetta CE" & vbCrLf & "3) Descrizione generale del funzionamento"
        TextBoxGuidaRO1.Text = GuidaRO1a 'questa guida è variabile, è diversa nel caso dei beni del gruppo 2 e 3
        TextBoxGuidaRO2.Text = GuidaRO2a 'questa guida è variabile, è diversa nel caso dei beni del gruppo 2 e 3
        TextBoxGuidaRO3.Text = "Integrazione automatizzata con il sistema logistico della fabbrica o con la rete di fornitura e/o con altre macchine del ciclo produttivo" & vbCrLf & "Descrivere come si realizza l’integrazione, le verifiche fatte a supporto, il materiale conseguente che si allega (immagini videate, ecc.) o a cui si rinvia (doc tecnica del fornitore, fascicolo tecnico di costruzione, ecc.). Descrivere come si realizza l’integrazione e inserire schermate di esempio. Esempio:" & vbCrLf & "• Descrizione e/o videate del sistema di scambio dati con il sistema logistico di fabbrica: ordini automatici, movimenti di magazzino. Se disponibile, tracciamento del lotto con report da gestionale;" & vbCrLf & "• Descrizione o videate del sistema di integrazione con la rete di fornitura: ordini automatici, date di consegna, aggiornamento dei programmi di produzione, ecc.;" & vbCrLf & "• Descrizione dell’integrazione M2M a monte e/o a valle con altre macchine;" & vbCrLf & "• (Se disponibili) Schemi elettrici e informativi per integrazione con macchine a monte e/o a valle."
        TextBoxGuidaRO4.Text = "Interfaccia tra uomo e macchina semplici e intuitive" & vbCrLf & "Descrivere l’interfaccia uomo-macchina riportando le descrizioni opportune che evidenzino il rispetto delle seguenti condizioni. Esempio: La macchina è fornita di pannello di comando touch screen marca XXXXX e modello XXXXX , su cui sono riportati comandi e icone semplici e intuitive, utili alla programmazione e alla gestione dei parametri macchina, nonché al controllo della funzionalità della stessa. Il bene strumentale possiede un monitor di controllo con interfaccia HMI che permette all’utente operazioni semplici e intuitive che consentono una lettura facilitata delle informazioni nelle seguenti condizioni:" & vbCrLf & "• Con indosso i dispositivi di protezione individuale di cui deve essere dotato l’operatore;" & vbCrLf & "• Consentire la lettura senza errori nelle condizioni di situazione ambientale del reparto produttivo (illuminazione, posizionamento delle interfacce sulle macchine, presenza di agenti che possono sporcare o guastare i sistemi idi interazione, ecc.)." & vbCrLf & "Il pannello di controllo consente, in sintesi, di gestire, tra le varie possibili, le seguenti funzionalità: memorizzazione di dati; funzioni di ricerca dati; presentazione dei dati in schermate successive strutturate per tipo di attività; funzionalità di ""help""; presenza di icone rappresentative dello stato della macchina; presenza di icone rappresentative della schermata; evidenza degli allarmi emergenti e funzioni di diagnostica." & vbCrLf & "Le immagini seguenti rappresentano alcune schermate dell’interfaccia operatore (inserire immagini schermate principali)."
        TextBoxGuidaRO5.Text = "Rispondenza ai più recenti parametri di sicurezza, salute e igiene del lavoro" & vbCrLf & "Inserire descrizione ""minimale"". Esempio:" & vbCrLf & "La macchina è marcata CE ai sensi delle direttive di prodotto applicabili ed è accompagnata da:" & vbCrLf & "• Dichiarazione CE di conformità;" & vbCrLf & "• Manuale di istruzioni." & vbCrLf & "Allegare foto targa CE apposta sulla macchina."
        TextBoxGuidaRU1.Text = "Sistemi di telemanutenzione e/o telediagnosi e/o controllo in remoto" & vbCrLf & "Descrivere come si realizza (solo 1, 2 o tutti e 3 tra Sistemi di telemanutenzione, Sistemi di telediagnosi e Controllo in remoto), le verifiche fatte a supporto, il materiale conseguente che si allega (immagini videate, ecc.) o a cui si rinvia (doc tecnica del fornitore, fascicolo tecnico di costruzione, ecc.). Esempio:" & vbCrLf & "• Descrizione del sistema di telediagnosi/telemanutenzione/telecontrollo adottato;" & vbCrLf & "• (Se disponibile) descrizione del processo interno all’azienda che consente ai fornitori un ingresso controllato ai beni di fabbrica;" & vbCrLf & "• (Ove disponibile) Report di telediagnosi/telemanutenzione/telecontrollo in alternativa foto delle videate del collegamento con fornitore o in remoto;" & vbCrLf & "• (Eventuale) copia del contratto di manutenzione o di acquisto della macchina, se prevede tale servizio."
        TextBoxGuidaRU2.Text = "Monitoraggio continuo delle condizioni di lavoro e dei parametri di processo mediante opportuni set di sensori e adattività alle derive di processo" & vbCrLf & "Descrivere i principali parametri critici di processo, come si realizza il monitoraggio, le conseguenze operative (arresto macchina, adattività, ecc.) verifiche fatte a supporto, il materiale conseguente che si allega (immagini videate, ecc.) o a cui si rinvia (doc tecnica del fornitore, fascicolo tecnico di costruzione, ecc.). Esempio:" & vbCrLf & "• Descrizione dei parametri di processo che vengono monitorati;" & vbCrLf & "• Descrizione dei principali sensori (indicare almeno costruttore, marca e modello), così come indicato dal fornitore;" & vbCrLf & "• Report di produzione ed eventuale grafico che identificano le tipologie di arresti macchina, a dimostrazione della adattività."
        TextBoxGuidaRU3.Text = "Caratteristiche di integrazione tra macchina fisica e/o impianto con la modellizzazione e/o la simulazione del proprio comportamento nello svolgimento del processo (sistema cyberfisico)" & vbCrLf & "Descrivere modalità di soddisfacimento requisito. Esempio:" & vbCrLf & "• Descrizione del modello, identificazione della licenza (se acquistato), livello di revisione;" & vbCrLf & "• Grafici/videate di funzionamento del modello."

        'TESTI PRECARICATI
        RichTextBoxValoreCespite.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1040{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}}\viewkind4\uc1\trowd\trgaph108\trleft5\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl108\trpaddr108\trpaddfl3\trpaddfr3 \clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx1785\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx3740\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6010\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8280\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx9967 \pard\intbl\widctlpar\qc\b\f0\fs22 Bene\cell Importo\cell Numero\line Fattura/Leasing\cell Data\line Fattura/Leasing\cell Fornitore\cell\row\trowd\trgaph108\trleft5\trbrdrl\brdrs\brdrw10 \trbrdrt\brdrs\brdrw10 \trbrdrr\brdrs\brdrw10 \trbrdrb\brdrs\brdrw10 \trpaddl108\trpaddr108\trpaddfl3\trpaddfr3 \clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx1785\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx3740\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6010\clvertalc\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8280\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx9967 \pard\intbl\widctlpar\qc\b0\cell\cell\cell\cell\cell\row \pard\sa200\sl276\slmult1\lang16\par}"

        'CARICO IL FORM2 PER RICHIEDERE DI IMPOSTARE LA PRATICA
        Dim FormPreset As Form2 = New Form2
        FormPreset.Show(Me)
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            Dim Res As MsgBoxResult = MsgBox("Salvare il lavoro corrente prima di chiudere il programma?", MsgBoxStyle.YesNoCancel)
            If Res = MsgBoxResult.Yes Then
                Try
                    SalvaLavoro()
                Catch ex As Exception
                    MsgBox("Impossibile salvare il lavoro del compositore visuale")
                End Try
            ElseIf Res = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ButtonCartella_Click(sender As Object, e As EventArgs) Handles ButtonCartella.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextboxCartella.Text = FolderBrowserDialog1.SelectedPath()
        End If
    End Sub

    Private Sub CaricaImmaginiEAllegati()
        'cancello quello che c'è dentro, se c'è qualcosa
        ListViewFoto.Items.Clear()
        ImageList256.Images.Clear()
        ImageList128.Images.Clear()
        ImageList64.Images.Clear()
        DataGridViewAllegati.Rows.Clear()
        AllegatoSelezionato = -1
        PictureBoxFotoSelezionata.Image = Nothing
        WebBrowserAllegati.Navigate(New Uri("about:blank"))
        Dim i As Integer = 0
        For Each File As String In My.Computer.FileSystem.GetFiles(TextboxCartella.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            Dim Ext As String = File.Substring(File.LastIndexOf(".") + 1).ToLower
            If Ext = "jpg" Or Ext = "png" Or Ext = "bmp" Or Ext = "gif" Or Ext = "jpeg" Or Ext = "jpe" Or Ext = "jfif" Or Ext = "tif" Or Ext = "tiff" Or Ext = "ico" Then
                If Not File.Contains("\Compositore visuale\") Then
                    Dim Immagine As Image
                    Immagine = Image.FromFile(File)
                    Try
                        Dim ProprietaOrientamento = Immagine.GetPropertyItem(&H112).Value(0) 'il codice  esadecimale indica "PropertyTagOrientation"
                        Dim RotateFlip = 1 'che dovrebbe corrispondere a RotateFlipType.RotateNoneFlipNone
                        If ProprietaOrientamento <> 1 Then
                            Select Case ProprietaOrientamento
                                Case 2 : RotateFlip = RotateFlipType.RotateNoneFlipX
                                Case 3 : RotateFlip = RotateFlipType.Rotate180FlipNone
                                Case 4 : RotateFlip = RotateFlipType.Rotate180FlipX
                                Case 5 : RotateFlip = RotateFlipType.Rotate90FlipX
                                Case 6 : RotateFlip = RotateFlipType.Rotate90FlipNone
                                Case 7 : RotateFlip = RotateFlipType.Rotate270FlipX
                                Case 8 : RotateFlip = RotateFlipType.Rotate270FlipNone
                            End Select
                            Immagine.RotateFlip(RotateFlip)
                            Immagine.RemovePropertyItem(&H112)
                        End If
                    Catch
                        'non fa niente perché se non c'è la proprietà non c'è neppure un problema
                    End Try
                    ImageList256.Images.Add(Immagine)
                    ImageList128.Images.Add(Immagine)
                    ImageList64.Images.Add(Immagine)
                    ListViewFoto.Items.Add(File.Substring(TextboxCartella.Text.Length + 1), i)
                    i = i + 1
                End If
            End If
        Next

        GC.Collect() 'aggiunto per cercare di risoplvere i problemi di memoria di Marco

        If ComboBoxDimensioneIcone.SelectedIndex = 0 Then
            ListViewFoto.LargeImageList = ImageList256
        Else
            If ComboBoxDimensioneIcone.SelectedIndex = 1 Then
                ListViewFoto.LargeImageList = ImageList128
            Else
                ListViewFoto.LargeImageList = ImageList64
            End If
        End If
        'penso che il prossimo IF non serva a nulla, del tutto inutile perché "ListViewFoto.SelectedIndices" dovrebbe essere sempre vuoto
        If ListViewFoto.SelectedIndices.Count > 0 Then
            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & "\" & ListViewFoto.Items(ListViewFoto.SelectedIndices.Item(0)).Text) Then
                PictureBoxFotoSelezionata.Image = Image.FromFile(TextboxCartella.Text & "\" & ListViewFoto.Items(ListViewFoto.SelectedIndices.Item(0)).Text)
                Zoomer(0)
            End If
        End If
        'caricamento allegati
        For Each File As String In My.Computer.FileSystem.GetFiles(TextboxCartella.Text, FileIO.SearchOption.SearchAllSubDirectories, "*.pdf")
            Dim Informazioni As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(File)
            Dim Riga(2) As String
            Riga(0) = File.Substring(TextboxCartella.Text.Length + 1)
            Riga(1) = Int(Informazioni.Length / 1000) & " KB"
            DataGridViewAllegati.Rows.Add(Riga)
        Next
    End Sub


    Private Sub TextBoxCartella_TextChanged(sender As Object, e As EventArgs) Handles TextboxCartella.TextChanged

        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            CaricaImmaginiEAllegati()
            'crea la cartella di salvataggio se non c'è, altrimenti carica il lavoro
            TextboxCartella.Enabled = False
            If Not My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text & "\Compositore visuale") Then
                My.Computer.FileSystem.CreateDirectory(TextboxCartella.Text & "\Compositore visuale")
            Else
                CaricaLavoro()
            End If
            'salvo la cartella di lavoro per poter riprendere velocemente il lavoro alla riapertura del programma, ma solo se non ho fatto "Riapri l'ultimo lavoro salvato"
            Try
                'va in conflitto perché vorrei scrivere appena letto... devo evitare leggendo ancora o spostando in Form2
                Dim DirectoryUtentePC As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                Dim NomeUtentePC As String = DirectoryUtentePC.Substring(DirectoryUtentePC.LastIndexOf("\") + 1)
                Dim FileSalvataggioImpostazioni As String = My.Application.Info.DirectoryPath & "\Impostazioni-" & NomeUtentePC & ".txt"
                Dim FlussoImpostazioni As New IO.StreamWriter(FileSalvataggioImpostazioni)
                FlussoImpostazioni.WriteLine(TextboxCartella.Text)
                FlussoImpostazioni.Close()
            Catch ex As Exception
                MsgBox("Impossibile salvare il file di impostazioni, errore:" & vbCrLf & ex.Message)
            End Try
        End If
        GC.Collect() 'aggiunto per cercare di risoplvere i problemi di memoria di Marco
    End Sub

    Private Sub ButtonAggiorna_Click(sender As Object, e As EventArgs) Handles ButtonAggiorna.Click
        CaricaImmaginiEAllegati()
        GC.Collect() 'aggiunto per cercare di risoplvere i problemi di memoria di Marco
    End Sub

    Private Sub ComboBoxDimensioneIcone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDimensioneIcone.SelectedIndexChanged
        If ComboBoxDimensioneIcone.SelectedIndex = 0 Then
            ListViewFoto.LargeImageList = ImageList256
        Else
            If ComboBoxDimensioneIcone.SelectedIndex = 1 Then
                ListViewFoto.LargeImageList = ImageList128
            Else
                ListViewFoto.LargeImageList = ImageList64
            End If
        End If
    End Sub


    Dim PreviousZoom As Single = 0

    Private Sub Zoomer(Zoom As Single)
        If TextboxCartella.Text <> "" Then
            'gestisco il caso dello zoom per adattare, convenzionalmente: Zoom = 0
            NumericUpDown1.Enabled = False
            If Zoom = 0 Then
                Dim maxFitZoomWidth As Single = Panel1.Width / PictureBoxFotoSelezionata.Image.Width
                Dim maxFitZoomHeight As Single = Panel1.Height / PictureBoxFotoSelezionata.Image.Height
                If maxFitZoomWidth < maxFitZoomHeight Then
                    Zoom = maxFitZoomWidth
                Else
                    Zoom = maxFitZoomHeight
                End If
            End If
            If PreviousZoom <> Zoom Then
                PreviousZoom = Zoom
                'imposto il valore nella TextBox2
                If Zoom > NumericUpDown1.Maximum Then NumericUpDown1.Maximum = Zoom
                If Zoom < NumericUpDown1.Minimum Then NumericUpDown1.Minimum = Zoom
                NumericUpDown1.Value = Zoom
                'azzero lo scroll per evitare guai
                Panel1.VerticalScroll.Value = 0
                Panel1.HorizontalScroll.Value = 0
            End If
            'imposto lo zoom
            If Zoom = 1 Then
                PictureBoxFotoSelezionata.SizeMode = PictureBoxSizeMode.AutoSize
            Else
                PictureBoxFotoSelezionata.SizeMode = PictureBoxSizeMode.StretchImage
                PictureBoxFotoSelezionata.Width = CInt(PictureBoxFotoSelezionata.Image.Width * Zoom)
                PictureBoxFotoSelezionata.Height = CInt(PictureBoxFotoSelezionata.Image.Height * Zoom)
            End If
            'imposto il centraggio
            If Panel1.Width > PictureBoxFotoSelezionata.Width Then
                PictureBoxFotoSelezionata.Left = (Panel1.Width - PictureBoxFotoSelezionata.Width) / 2
            Else
                PictureBoxFotoSelezionata.Left = 0
            End If
            If Panel1.Height > PictureBoxFotoSelezionata.Height Then
                PictureBoxFotoSelezionata.Top = (Panel1.Height - PictureBoxFotoSelezionata.Height) / 2
            Else
                PictureBoxFotoSelezionata.Top = 0
            End If
            NumericUpDown1.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Enabled Then Zoomer(CSng(NumericUpDown1.Value))
    End Sub

    Private Function ResizeImage(ByVal InputImage As Image) As Image
        Dim MaxDim As Integer
        If InputImage.Size.Width > InputImage.Size.Height Then MaxDim = InputImage.Size.Width Else MaxDim = InputImage.Size.Height
        Dim Scala As Integer = Math.Floor(MaxDim / 1000)
        If Scala > 1 Then
            Return New Bitmap(InputImage, New Size(InputImage.Size.Width / Scala, InputImage.Size.Height / Scala))
        Else
            Return InputImage
        End If
    End Function

    Dim FileImmagineSelezionata = ""
    Private Sub ListViewFoto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewFoto.SelectedIndexChanged
        If ListViewFoto.SelectedIndices.Count > 0 Then
            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & "\" & ListViewFoto.Items(ListViewFoto.SelectedIndices.Item(0)).Text) Then
                PictureBoxFotoSelezionata.Image = Image.FromFile(TextboxCartella.Text & "\" & ListViewFoto.Items(ListViewFoto.SelectedIndices.Item(0)).Text)
                Try
                    Dim ProprietaOrientamento = PictureBoxFotoSelezionata.Image.GetPropertyItem(&H112).Value(0) 'il codice  esadecimale indica "PropertyTagOrientation"
                    Dim RotateFlip = 1 'che dovrebbe corrispondere a RotateFlipType.RotateNoneFlipNone
                    If ProprietaOrientamento <> 1 Then
                        Select Case ProprietaOrientamento
                            Case 2 : RotateFlip = RotateFlipType.RotateNoneFlipX
                            Case 3 : RotateFlip = RotateFlipType.Rotate180FlipNone
                            Case 4 : RotateFlip = RotateFlipType.Rotate180FlipX
                            Case 5 : RotateFlip = RotateFlipType.Rotate90FlipX
                            Case 6 : RotateFlip = RotateFlipType.Rotate90FlipNone
                            Case 7 : RotateFlip = RotateFlipType.Rotate270FlipX
                            Case 8 : RotateFlip = RotateFlipType.Rotate270FlipNone
                        End Select
                        PictureBoxFotoSelezionata.Image.RotateFlip(RotateFlip)
                        PictureBoxFotoSelezionata.Image.RemovePropertyItem(&H112)
                    End If
                Catch
                    'non fa niente perché se non c'è la proprietà non c'è neppure un problema
                End Try
                'Vecchia versione
                'Clipboard.SetText(ListViewFoto.Items(ListViewFoto.SelectedIndices.Item(0)).Text)
                Clipboard.SetImage(PictureBoxFotoSelezionata.Image)
                'Nuova versione
                FileImmagineSelezionata = "\" & ListViewFoto.Items(ListViewFoto.SelectedIndices.Item(0)).Text
                'Clipboard.Clear() 'non serve a niente, ma può essere utile averlo per non fare confusione
                Zoomer(0)
            End If
        End If
    End Sub

    Private Sub DataGridViewAllegati_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAllegati.CellClick
        If e.RowIndex > -1 Then
            AllegatoSelezionato = e.RowIndex
            TextBoxRinominaAllegati.Text = DataGridViewAllegati.Rows(e.RowIndex).Cells(0).Value.substring(DataGridViewAllegati.Rows(e.RowIndex).Cells(0).Value.lastindexof("\") + 1)
            WebBrowserAllegati.Navigate(TextboxCartella.Text & "\" & DataGridViewAllegati.Rows(e.RowIndex).Cells(0).Value)
        End If
    End Sub

    Private Sub ButtonRinominaAllegati_Click(sender As Object, e As EventArgs) Handles ButtonRinominaAllegati.Click
        If AllegatoSelezionato > -1 Then
            WebBrowserAllegati.Navigate(New Uri("about:blank")) 'chiudo il file aperto nel browser per potergli cambiare il nome
            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & "\" & DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value) Then
                If TextBoxRinominaAllegati.Text <> "" Then
                    TextBoxRinominaAllegati.Text = TextBoxRinominaAllegati.Text.Trim()
                    If TextBoxRinominaAllegati.Text.Substring(TextBoxRinominaAllegati.Text.Length() - 4).ToLower <> ".pdf" Then
                        TextBoxRinominaAllegati.Text = TextBoxRinominaAllegati.Text & ".pdf"
                    End If
                    'la riga seguente serve per dare un po' di tempo e impedire che il file sia ancora aperto nel WebBrowser. Altrimenti darebbe sempre errore di file in uso (si può automatizzare con un retry)
                    If MsgBox("Rinominare " & DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value.substring(DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value.lastindexof("\") + 1) & " in " & TextBoxRinominaAllegati.Text & "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Try
                            My.Computer.FileSystem.RenameFile(TextboxCartella.Text & "\" & DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value, TextBoxRinominaAllegati.Text)
                            DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value = DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value.substring(0, DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value.lastindexof("\") + 1) & TextBoxRinominaAllegati.Text
                        Catch ex As Exception
                            MsgBox("Impossibile rinominare, errore: " & vbCrLf & ex.Message)
                        End Try
                    End If
                End If
            End If
            WebBrowserAllegati.Navigate(TextboxCartella.Text & "\" & DataGridViewAllegati.Rows(AllegatoSelezionato).Cells(0).Value)
        End If
    End Sub

    Dim FileLogoAzienda As String = ""
    Dim FileFotoCopertina As String = ""

    Private Sub ButtonPasteLogoAzienda_Click(sender As Object, e As EventArgs) Handles ButtonPasteLogoAzienda.Click
        If Clipboard.ContainsImage Then
            PictureBoxLogoAzienda.Image = ResizeImage(Clipboard.GetImage)
            FileLogoAzienda = "\Compositore visuale\LogoAzienda-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxLogoAzienda.Image.Save(TextboxCartella.Text & FileLogoAzienda, Imaging.ImageFormat.Jpeg)
            PictureBoxLogoAzienda.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub ButtonPasteFotoCopertina_Click(sender As Object, e As EventArgs) Handles ButtonPasteFotoCopertina.Click
        If Clipboard.ContainsImage Then
            PictureBoxFotoCopertina.Image = ResizeImage(Clipboard.GetImage)
            FileFotoCopertina = "\Compositore visuale\FotoCopertina-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxFotoCopertina.Image.Save(TextboxCartella.Text & FileFotoCopertina, Imaging.ImageFormat.Jpeg)
            PictureBoxFotoCopertina.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    Private Sub ButtonGeneraleInserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonGeneraleInserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataGenerale > -1 Then
            PictureBoxGenerale.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\Generale" & RigaSelezionataGenerale & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxGenerale.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxGenerale.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value = FilePathAndName
            'If TextBoxGeneraleDidascalia.Text = "" And Clipboard.ContainsText Then TextBoxGeneraleDidascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRO1InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRO1InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRO1 > -1 Then
            PictureBoxRO1.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RO1" & RigaSelezionataRO1 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRO1.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRO1.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value = FilePathAndName
            'If TextBoxRO1Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRO1Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRO2InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRO2InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRO2 > -1 Then
            PictureBoxRO2.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RO2" & RigaSelezionataRO2 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRO2.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRO2.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value = FilePathAndName
            'If TextBoxRO2Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRO2Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRO3InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRO3InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRO3 > -1 Then
            PictureBoxRO3.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RO3" & RigaSelezionataRO3 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRO3.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRO3.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value = FilePathAndName
            'If TextBoxRO3Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRO3Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRO4InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRO4InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRO4 > -1 Then
            PictureBoxRO4.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RO4" & RigaSelezionataRO4 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRO4.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRO4.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value = FilePathAndName
            'If TextBoxRO4Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRO4Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRO5InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRO5InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRO5 > -1 Then
            PictureBoxRO5.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RO5" & RigaSelezionataRO5 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRO5.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRO5.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value = FilePathAndName
            'If TextBoxRO5Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRO5Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRU1InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRU1InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRU1 > -1 Then
            PictureBoxRU1.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RU1" & RigaSelezionataRU1 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRU1.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRU1.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value = FilePathAndName
            'If TextBoxRU1Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRU1Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRU2InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRU2InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRU2 > -1 Then
            PictureBoxRU2.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RU2" & RigaSelezionataRU2 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRU2.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRU2.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value = FilePathAndName
            'If TextBoxRU2Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRU2Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ButtonRU3InserisciImmagine_Click(sender As Object, e As EventArgs) Handles ButtonRU3InserisciImmagine.Click
        If Clipboard.ContainsImage And RigaSelezionataRU3 > -1 Then
            PictureBoxRU3.Image = ResizeImage(Clipboard.GetImage)
            Dim FilePathAndName As String = "\Compositore visuale\RU3" & RigaSelezionataRU3 & "-" & Format(Now(), "yyMMdd-HHmmss") & ".jpg"
            PictureBoxRU3.Image.Save(TextboxCartella.Text & FilePathAndName, Imaging.ImageFormat.Jpeg)
            PictureBoxRU3.SizeMode = PictureBoxSizeMode.Zoom
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value = ResizeImage(Clipboard.GetImage)
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value = FilePathAndName
            'If TextBoxRU3Didascalia.Text = "" And Clipboard.ContainsText Then TextBoxRU3Didascalia.Text = Clipboard.GetText
        End If
    End Sub

    Private Sub ComboBoxGruppo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxGruppo.SelectedIndexChanged
        ComboBoxCategoria.Items.Clear()
        Select Case ComboBoxGruppo.SelectedIndex
            Case 0
                ComboBoxCategoria.Items.Add("1. macchine utensili per asportazione")
                ComboBoxCategoria.Items.Add("2. macchine utensili operanti con laser e altri processi a flusso di energia (ad esempio plasma, waterjet, fascio di elettroni), elettroerosione, processi elettrochimici")
                ComboBoxCategoria.Items.Add("3. macchine e impianti per la realizzazione di prodotti mediante la trasformazione dei materiali e delle materie prime")
                ComboBoxCategoria.Items.Add("4. macchine utensili per la deformazione plastica dei metalli e altri materiali")
                ComboBoxCategoria.Items.Add("5. macchine utensili per l'assemblaggio, la giunzione e la saldatura")
                ComboBoxCategoria.Items.Add("6. macchine per il confezionamento e l'imballaggio")
                ComboBoxCategoria.Items.Add("7. macchine utensili di de-produzione e riconfezionamento per recuperare materiali e funzioni da scarti industriali e prodotti di ritorno a fine vita (ad esempio macchine per il disassemblaggio, la separazione, la frantumazione, il recupero chimico)")
                ComboBoxCategoria.Items.Add("8. robot, robot collaborativi e sistemi multi-robot")
                ComboBoxCategoria.Items.Add("9. macchine utensili e sistemi per il conferimento o la modifica delle caratteristiche superficiali dei prodotti o la funzionalizzazione delle superfici")
                ComboBoxCategoria.Items.Add("10. macchine per la manifattura additiva utilizzate in ambito industriale")
                ComboBoxCategoria.Items.Add("11. macchine, anche motrici e operatrici, strumenti e dispositivi per il carico e lo scarico, la movimentazione, la pesatura e la cernita automatica dei pezzi, dispositivi di sollevamento e manipolazione automatizzati, AGV e sistemi di convogliamento e movimentazione flessibili, e / o dotati di riconoscimento dei pezzi (ad esempio RFID, visori e sistemi di visione e meccatronici)")
                ComboBoxCategoria.Items.Add("12. magazzini automatizzati interconnessi ai sistemi gestionali di fabbrica")
            Case 1
                ComboBoxCategoria.Items.Add("1. sistemi di misura a coordinate e no (a contatto, non a contatto, multi - sensore o basati su tomografia computerizzata tridimensionale) e relativa strumentazione per la verifica dei requisiti micro e macro geometrici di prodotto per qualunque livello di scala dimensionale (dalla larga scala alla scala micro - metrica o nano-metrica) al fine di assicurare e tracciare la qualità del prodotto e che consentono di qualificare i processi di produzione in maniera documentabile e connessa al sistema informativo di fabbrica")
                ComboBoxCategoria.Items.Add("2. altri sistemi di monitoraggio in process per assicurare e tracciare la qualità del prodotto o del processo produttivo e che consentono di qualificare i processi di produzione in maniera documentabile e connessa al sistema informativo di fabbrica")
                ComboBoxCategoria.Items.Add("3. sistemi per l'ispezione e la caratterizzazione dei materiali (ad esempio macchine di prova materiali, macchine per il collaudo dei prodotti realizzati, sistemi per prove o collaudi non distruttivi, tomografia) in grado di verificare le caratteristiche dei materiali in ingresso o in uscita al processo e che vanno a costituire il prodotto risultante a livello macro (ad esempio caratteristiche meccaniche) o micro (ad esempio porosità, inclusioni) e di generare opportuni report di collaudo da inserire nel sistema informativo aziendale")
                ComboBoxCategoria.Items.Add("4. dispositivi intelligenti per il test delle polveri metalliche e sistemi di monitoraggio in continuo che consentono di qualificare i processi di produzione mediante tecnologie additive")
                ComboBoxCategoria.Items.Add("5. sistemi intelligenti e connessi di marcatura e tracciabilità dei lotti produttivi e/ o dei singoli prodotti (ad esempio RFID – Radio Frequency Identification)")
                ComboBoxCategoria.Items.Add("6. sistemi di monitoraggio e controllo delle condizioni di lavoro delle macchine (ad esempio forze, coppia e potenza di lavorazione; usura tridimensionale degli utensili a bordo macchina; stato di componenti o sotto-insiemi delle macchine) e dei sistemi di produzione interfacciati con i sistemi informativi di fabbrica e/o con soluzioni cloud")
                ComboBoxCategoria.Items.Add("7. strumenti e dispositivi per l'etichettatura, l’identificazione o la marcatura automatica dei prodotti, con collegamento con il codice e la matricola del prodotto stesso in modo da consentire ai manutentori di monitorare la costanza delle prestazioni dei prodotti nel tempo e di agire sul processo di progettazione dei futuri prodotti In maniera sinergica, consentendo il richiamo di prodotti difettosi o dannosi")
                ComboBoxCategoria.Items.Add("8. componenti, sistemi e soluzioni intelligenti per la gestione, l'utilizzo efficiente e il monitoraggio dei consumi energetici e idrici e per la riduzione delle emissioni")
                ComboBoxCategoria.Items.Add("9. filtri e sistemi di trattamento e recupero di acqua, aria, olio, sostanze chimiche, polveri con sistemi di segnalazione dell'efficienza filtrante e della presenza di anomalie o sostanze aliene al processo o pericolose, integrate con il sistema di fabbrica e in grado di avvisare gli operatori e/o di fermare le attività di macchine e impianti")
            Case 2
                ComboBoxCategoria.Items.Add("1. banchi e postazioni di lavoro dotati di soluzioni ergonomiche in grado di adattarli in maniera automatizzata alle caratteristiche fisiche degli operatori (ad esempio caratteristiche biometriche, età, presenza di disabilità)")
                ComboBoxCategoria.Items.Add("2. sistemi per il sollevamento/traslazione di parti pesanti o oggetti esposti ad alte temperature in grado di agevolare in maniera intelligente/ robotizzata / interattiva il compito dell'operatore")
                ComboBoxCategoria.Items.Add("3. dispositivi wearable, apparecchiature di comunicazione tra operatore/ operatori e sistema produttivo, dispositivi di realtà aumentata e virtual reality")
                ComboBoxCategoria.Items.Add("4. interfacce uomo-macchina (HMI) intelligenti che coadiuvano l'operatore a fini di sicurezza ed efficienza delle operazioni di lavorazione, manutenzione, logistica")
        End Select
        If ComboBoxGruppo.SelectedIndex = 0 Then
            For i = 4 To 9
                TabControl2.TabPages.Item(i).Enabled = True 'riabilito le tab da 4 a 9 (da RO3 a RU3)
            Next
            LabelRO1.Text = "RO1. Controllo per mezzo di CNC e/o PLC"
            LabelRO2.Text = "RO2. Interconnessione con caricamento da remoto di istruzioni e/o part program"
            TextBoxGuidaRO1.Text = GuidaRO1a
            TextBoxGuidaRO2.Text = GuidaRO2a
        Else
            For i = 4 To 9
                TabControl2.TabPages.Item(i).Enabled = False 'disabilito le tab da 4 a 9 (da RO3 a RU3)
            Next
            LabelRO1.Text = "RO1. Scambio informazioni con sistemi interni e/o esterni"
            LabelRO2.Text = "RO2. Identificazione univoca (indirizzo IP)"
            TextBoxGuidaRO1.Text = GuidaRO1b
            TextBoxGuidaRO2.Text = GuidaRO2b
        End If
        ComboBoxCategoria.SelectedIndex = 0
    End Sub

    'sezioni replicate su tutte le schermate
    Sub CaricaDatiGenerale()
        PictureBoxGenerale.Image = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value
        PictureBoxGenerale.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxGeneraleDidascalia.Text = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value 'Didascalia
        TextBoxGeneraleTitolo.Text = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value 'Titolo
        RichTextBoxGeneraleDescrizione.Rtf = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataGenerale = 0 Then
            DataGridViewGenerale.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewGenerale.FirstDisplayedScrollingRowIndex() <> RigaSelezionataGenerale - 1 Then
            DataGridViewGenerale.FirstDisplayedScrollingRowIndex() = RigaSelezionataGenerale - 1
        End If
        DataGridViewGenerale.Rows(RigaSelezionataGenerale).Selected = True
    End Sub

    Sub CaricaDatiRO1()
        PictureBoxRO1.Image = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value
        PictureBoxRO1.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRO1Didascalia.Text = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value 'Didascalia
        TextBoxRO1Titolo.Text = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value 'Titolo
        RichTextBoxRO1Descrizione.Rtf = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRO1 = 0 Then
            DataGridViewRO1.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRO1.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRO1 - 1 Then
            DataGridViewRO1.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO1 - 1
        End If
        DataGridViewRO1.Rows(RigaSelezionataRO1).Selected = True
    End Sub

    Sub CaricaDatiRO2()
        PictureBoxRO2.Image = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value
        PictureBoxRO2.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRO2Didascalia.Text = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value 'Didascalia
        TextBoxRO2Titolo.Text = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value 'Titolo
        RichTextBoxRO2Descrizione.Rtf = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRO2 = 0 Then
            DataGridViewRO2.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRO2.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRO2 - 1 Then
            DataGridViewRO2.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO2 - 1
        End If
        DataGridViewRO2.Rows(RigaSelezionataRO2).Selected = True
    End Sub

    Sub CaricaDatiRO3()
        PictureBoxRO3.Image = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value
        PictureBoxRO3.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRO3Didascalia.Text = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value 'Didascalia
        TextBoxRO3Titolo.Text = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value 'Titolo
        RichTextBoxRO3Descrizione.Rtf = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRO3 = 0 Then
            DataGridViewRO3.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRO3.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRO3 - 1 Then
            DataGridViewRO3.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO3 - 1
        End If
        DataGridViewRO3.Rows(RigaSelezionataRO3).Selected = True
    End Sub

    Sub CaricaDatiRO4()
        PictureBoxRO4.Image = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value
        PictureBoxRO4.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRO4Didascalia.Text = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value 'Didascalia
        TextBoxRO4Titolo.Text = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value 'Titolo
        RichTextBoxRO4Descrizione.Rtf = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRO4 = 0 Then
            DataGridViewRO4.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRO4.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRO4 - 1 Then
            DataGridViewRO4.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO4 - 1
        End If
        DataGridViewRO4.Rows(RigaSelezionataRO4).Selected = True
    End Sub

    Sub CaricaDatiRO5()
        PictureBoxRO5.Image = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value
        PictureBoxRO5.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRO5Didascalia.Text = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value 'Didascalia
        TextBoxRO5Titolo.Text = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value 'Titolo
        RichTextBoxRO5Descrizione.Rtf = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRO5 = 0 Then
            DataGridViewRO5.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRO5.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRO5 - 1 Then
            DataGridViewRO5.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO5 - 1
        End If
        DataGridViewRO5.Rows(RigaSelezionataRO5).Selected = True
    End Sub

    Sub CaricaDatiRU1()
        PictureBoxRU1.Image = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value
        PictureBoxRU1.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRU1Didascalia.Text = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value 'Didascalia
        TextBoxRU1Titolo.Text = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value 'Titolo
        RichTextBoxRU1Descrizione.Rtf = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRU1 = 0 Then
            DataGridViewRU1.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRU1.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRU1 - 1 Then
            DataGridViewRU1.FirstDisplayedScrollingRowIndex() = RigaSelezionataRU1 - 1
        End If
        DataGridViewRU1.Rows(RigaSelezionataRU1).Selected = True
    End Sub

    Sub CaricaDatiRU2()
        PictureBoxRU2.Image = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value
        PictureBoxRU2.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRU2Didascalia.Text = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value 'Didascalia
        TextBoxRU2Titolo.Text = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value 'Titolo
        RichTextBoxRU2Descrizione.Rtf = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRU2 = 0 Then
            DataGridViewRU2.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRU2.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRU2 - 1 Then
            DataGridViewRU2.FirstDisplayedScrollingRowIndex() = RigaSelezionataRU2 - 1
        End If
        DataGridViewRU2.Rows(RigaSelezionataRU2).Selected = True
    End Sub

    Sub CaricaDatiRU3()
        PictureBoxRU3.Image = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value
        PictureBoxRU3.SizeMode = PictureBoxSizeMode.Zoom
        TextBoxRU3Didascalia.Text = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value 'Didascalia
        TextBoxRU3Titolo.Text = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value 'Titolo
        RichTextBoxRU3Descrizione.Rtf = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value 'DescrizioneRTF
        If RigaSelezionataRU3 = 0 Then
            DataGridViewRU3.FirstDisplayedScrollingRowIndex() = 0
        ElseIf DataGridViewRU3.FirstDisplayedScrollingRowIndex() <> RigaSelezionataRU3 - 1 Then
            DataGridViewRU3.FirstDisplayedScrollingRowIndex() = RigaSelezionataRU3 - 1
        End If
        DataGridViewRU3.Rows(RigaSelezionataRU3).Selected = True
    End Sub

    Private Sub DataGridViewGenerale_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewGenerale.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataGenerale = e.RowIndex
            CaricaDatiGenerale()
        End If
    End Sub

    Private Sub DataGridViewRO1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRO1.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRO1 = e.RowIndex
            CaricaDatiRO1()
        End If
    End Sub

    Private Sub DataGridViewRO2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRO2.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRO2 = e.RowIndex
            CaricaDatiRO2()
        End If
    End Sub

    Private Sub DataGridViewRO3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRO3.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRO3 = e.RowIndex
            CaricaDatiRO3()
        End If
    End Sub

    Private Sub DataGridViewRO4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRO4.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRO4 = e.RowIndex
            CaricaDatiRO4()
        End If
    End Sub

    Private Sub DataGridViewRO5_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRO5.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRO5 = e.RowIndex
            CaricaDatiRO5()
        End If
    End Sub

    Private Sub DataGridViewRU1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRU1.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRU1 = e.RowIndex
            CaricaDatiRU1()
        End If
    End Sub

    Private Sub DataGridViewRU2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRU2.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRU2 = e.RowIndex
            CaricaDatiRU2()
        End If
    End Sub

    Private Sub DataGridViewRU3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRU3.CellClick
        If e.RowIndex > -1 Then
            RigaSelezionataRU3 = e.RowIndex
            CaricaDatiRU3()
        End If
    End Sub

    Dim RigaSelezionataGenerale As Integer = -1
    Dim RigaSelezionataRO1 As Integer = -1
    Dim RigaSelezionataRO2 As Integer = -1
    Dim RigaSelezionataRO3 As Integer = -1
    Dim RigaSelezionataRO4 As Integer = -1
    Dim RigaSelezionataRO5 As Integer = -1
    Dim RigaSelezionataRU1 As Integer = -1
    Dim RigaSelezionataRU2 As Integer = -1
    Dim RigaSelezionataRU3 As Integer = -1
    Private Sub ButtonGeneraleAggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonGeneraleAggiungiSezione.Click
        DataGridViewGenerale.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataGenerale = DataGridViewGenerale.Rows.Count - 1
        PictureBoxGenerale.Image = ImmaginePlaceholder
        PictureBoxGenerale.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxGeneraleDidascalia.Text = ""
        TextBoxGeneraleTitolo.Text = ""
        RichTextBoxGeneraleDescrizione.Text = ""
        DataGridViewGenerale.FirstDisplayedScrollingRowIndex() = RigaSelezionataGenerale
        DataGridViewGenerale.Rows(RigaSelezionataGenerale).Selected = True
    End Sub

    Private Sub ButtonRO1AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO1AggiungiSezione.Click
        DataGridViewRO1.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRO1 = DataGridViewRO1.Rows.Count - 1
        PictureBoxRO1.Image = ImmaginePlaceholder
        PictureBoxRO1.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRO1Didascalia.Text = ""
        TextBoxRO1Titolo.Text = ""
        RichTextBoxRO1Descrizione.Text = ""
        DataGridViewRO1.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO1
        DataGridViewRO1.Rows(RigaSelezionataRO1).Selected = True
    End Sub

    Private Sub ButtonRO2AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO2AggiungiSezione.Click
        DataGridViewRO2.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRO2 = DataGridViewRO2.Rows.Count - 1
        PictureBoxRO2.Image = ImmaginePlaceholder
        PictureBoxRO2.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRO2Didascalia.Text = ""
        TextBoxRO2Titolo.Text = ""
        RichTextBoxRO2Descrizione.Text = ""
        DataGridViewRO2.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO2
        DataGridViewRO2.Rows(RigaSelezionataRO2).Selected = True
    End Sub

    Private Sub ButtonRO3AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO3AggiungiSezione.Click
        DataGridViewRO3.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRO3 = DataGridViewRO3.Rows.Count - 1
        PictureBoxRO3.Image = ImmaginePlaceholder
        PictureBoxRO3.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRO3Didascalia.Text = ""
        TextBoxRO3Titolo.Text = ""
        RichTextBoxRO3Descrizione.Text = ""
        DataGridViewRO3.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO3
        DataGridViewRO3.Rows(RigaSelezionataRO3).Selected = True
    End Sub

    Private Sub ButtonRO4AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO4AggiungiSezione.Click
        DataGridViewRO4.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRO4 = DataGridViewRO4.Rows.Count - 1
        PictureBoxRO4.Image = ImmaginePlaceholder
        PictureBoxRO4.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRO4Didascalia.Text = ""
        TextBoxRO4Titolo.Text = ""
        RichTextBoxRO4Descrizione.Text = ""
        DataGridViewRO4.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO4
        DataGridViewRO4.Rows(RigaSelezionataRO4).Selected = True
    End Sub

    Private Sub ButtonRO5AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO5AggiungiSezione.Click
        DataGridViewRO5.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRO5 = DataGridViewRO5.Rows.Count - 1
        PictureBoxRO5.Image = ImmaginePlaceholder
        PictureBoxRO5.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRO5Didascalia.Text = ""
        TextBoxRO5Titolo.Text = ""
        RichTextBoxRO5Descrizione.Text = ""
        DataGridViewRO5.FirstDisplayedScrollingRowIndex() = RigaSelezionataRO5
        DataGridViewRO5.Rows(RigaSelezionataRO5).Selected = True
    End Sub

    Private Sub ButtonRU1AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRU1AggiungiSezione.Click
        DataGridViewRU1.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRU1 = DataGridViewRU1.Rows.Count - 1
        PictureBoxRU1.Image = ImmaginePlaceholder
        PictureBoxRU1.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRU1Didascalia.Text = ""
        TextBoxRU1Titolo.Text = ""
        RichTextBoxRU1Descrizione.Text = ""
        DataGridViewRU1.FirstDisplayedScrollingRowIndex() = RigaSelezionataRU1
        DataGridViewRU1.Rows(RigaSelezionataRU1).Selected = True
    End Sub

    Private Sub ButtonRU2AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRU2AggiungiSezione.Click
        DataGridViewRU2.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRU2 = DataGridViewRU2.Rows.Count - 1
        PictureBoxRU2.Image = ImmaginePlaceholder
        PictureBoxRU2.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRU2Didascalia.Text = ""
        TextBoxRU2Titolo.Text = ""
        RichTextBoxRU2Descrizione.Text = ""
        DataGridViewRU2.FirstDisplayedScrollingRowIndex() = RigaSelezionataRU2
        DataGridViewRU2.Rows(RigaSelezionataRU2).Selected = True
    End Sub

    Private Sub ButtonRU3AggiungiSezione_Click(sender As Object, e As EventArgs) Handles ButtonRU3AggiungiSezione.Click
        DataGridViewRU3.Rows.Add(ImmaginePlaceholder, "", "", "", "", "")
        RigaSelezionataRU3 = DataGridViewRU3.Rows.Count - 1
        PictureBoxRU3.Image = ImmaginePlaceholder
        PictureBoxRU3.SizeMode = PictureBoxSizeMode.CenterImage
        TextBoxRU3Didascalia.Text = ""
        TextBoxRU3Titolo.Text = ""
        RichTextBoxRU3Descrizione.Text = ""
        DataGridViewRU3.FirstDisplayedScrollingRowIndex() = RigaSelezionataRU3
        DataGridViewRU3.Rows(RigaSelezionataRU3).Selected = True
        CheckBoxRU3.Checked = True
    End Sub

    Private Sub TextBoxGeneraleDidascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGeneraleDidascalia.TextChanged
        If RigaSelezionataGenerale > -1 Then
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value = TextBoxGeneraleDidascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRO1Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO1Didascalia.TextChanged
        If RigaSelezionataRO1 > -1 Then
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value = TextBoxRO1Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRO2Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO2Didascalia.TextChanged
        If RigaSelezionataRO2 > -1 Then
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value = TextBoxRO2Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRO3Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO3Didascalia.TextChanged
        If RigaSelezionataRO3 > -1 Then
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value = TextBoxRO3Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRO4Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO4Didascalia.TextChanged
        If RigaSelezionataRO4 > -1 Then
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value = TextBoxRO4Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRO5Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO5Didascalia.TextChanged
        If RigaSelezionataRO5 > -1 Then
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value = TextBoxRO5Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRU1Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRU1Didascalia.TextChanged
        If RigaSelezionataRU1 > -1 Then
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value = TextBoxRU1Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRU2Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRU2Didascalia.TextChanged
        If RigaSelezionataRU2 > -1 Then
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value = TextBoxRU2Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxRU3Didascalia_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRU3Didascalia.TextChanged
        If RigaSelezionataRU3 > -1 Then
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value = TextBoxRU3Didascalia.Text 'Didascalia
        End If
    End Sub

    Private Sub TextBoxGeneraleTitolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGeneraleTitolo.TextChanged
        If RigaSelezionataGenerale > -1 Then
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value = TextBoxGeneraleTitolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRO1Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO1Titolo.TextChanged
        If RigaSelezionataRO1 > -1 Then
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value = TextBoxRO1Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRO2Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO2Titolo.TextChanged
        If RigaSelezionataRO2 > -1 Then
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value = TextBoxRO2Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRO3Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO3Titolo.TextChanged
        If RigaSelezionataRO3 > -1 Then
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value = TextBoxRO3Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRO4Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO4Titolo.TextChanged
        If RigaSelezionataRO4 > -1 Then
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value = TextBoxRO4Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRO5Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRO5Titolo.TextChanged
        If RigaSelezionataRO5 > -1 Then
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value = TextBoxRO5Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRU1Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRU1Titolo.TextChanged
        If RigaSelezionataRU1 > -1 Then
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value = TextBoxRU1Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRU2Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRU2Titolo.TextChanged
        If RigaSelezionataRU2 > -1 Then
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value = TextBoxRU2Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub TextBoxRU3Titolo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRU3Titolo.TextChanged
        If RigaSelezionataRU3 > -1 Then
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value = TextBoxRU3Titolo.Text 'Titolo
        End If
    End Sub

    Private Sub RichTextBoxGeneraleDescrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxGeneraleDescrizione.TextChanged
        If RigaSelezionataGenerale > -1 Then
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value = RichTextBoxGeneraleDescrizione.Text 'Descrizione
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value = RichTextBoxGeneraleDescrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRO1Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRO1Descrizione.TextChanged
        If RigaSelezionataRO1 > -1 Then
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value = RichTextBoxRO1Descrizione.Text 'Descrizione
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value = RichTextBoxRO1Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRO2Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRO2Descrizione.TextChanged
        If RigaSelezionataRO2 > -1 Then
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value = RichTextBoxRO2Descrizione.Text 'Descrizione
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value = RichTextBoxRO2Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRO3Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRO3Descrizione.TextChanged
        If RigaSelezionataRO3 > -1 Then
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value = RichTextBoxRO3Descrizione.Text 'Descrizione
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value = RichTextBoxRO3Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRO4Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRO4Descrizione.TextChanged
        If RigaSelezionataRO4 > -1 Then
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value = RichTextBoxRO4Descrizione.Text 'Descrizione
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value = RichTextBoxRO4Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRO5Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRO5Descrizione.TextChanged
        If RigaSelezionataRO5 > -1 Then
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value = RichTextBoxRO5Descrizione.Text 'Descrizione
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value = RichTextBoxRO5Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRU1Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRU1Descrizione.TextChanged
        If RigaSelezionataRU1 > -1 Then
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value = RichTextBoxRU1Descrizione.Text 'Descrizione
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value = RichTextBoxRU1Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRU2Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRU2Descrizione.TextChanged
        If RigaSelezionataRU2 > -1 Then
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value = RichTextBoxRU2Descrizione.Text 'Descrizione
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value = RichTextBoxRU2Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub RichTextBoxRU3Descrizione_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxRU3Descrizione.TextChanged
        If RigaSelezionataRU3 > -1 Then
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value = RichTextBoxRU3Descrizione.Text 'Descrizione
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value = RichTextBoxRU3Descrizione.Rtf 'DescrizioneRTF
        End If
    End Sub

    Private Sub ButtonGeneraleRimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonGeneraleRimuoviSezione.Click
        If RigaSelezionataGenerale > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewGenerale.Rows.Remove(DataGridViewGenerale.Rows(RigaSelezionataGenerale))
                If DataGridViewGenerale.Rows.Count = 0 Then
                    RigaSelezionataGenerale = -1
                    PictureBoxGenerale.Image = Nothing
                    TextBoxGeneraleDidascalia.Text = ""
                    TextBoxGeneraleTitolo.Text = ""
                    RichTextBoxGeneraleDescrizione.Text = ""
                Else
                    If RigaSelezionataGenerale > DataGridViewGenerale.Rows.Count - 1 Then RigaSelezionataGenerale = DataGridViewGenerale.Rows.Count - 1
                    CaricaDatiGenerale()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRO1RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO1RimuoviSezione.Click
        If RigaSelezionataRO1 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRO1.Rows.Remove(DataGridViewRO1.Rows(RigaSelezionataRO1))
                If DataGridViewRO1.Rows.Count = 0 Then
                    RigaSelezionataRO1 = -1
                    PictureBoxRO1.Image = Nothing
                    TextBoxRO1Didascalia.Text = ""
                    TextBoxRO1Titolo.Text = ""
                    RichTextBoxRO1Descrizione.Text = ""
                Else
                    If RigaSelezionataRO1 > DataGridViewRO1.Rows.Count - 1 Then RigaSelezionataRO1 = DataGridViewRO1.Rows.Count - 1
                    CaricaDatiRO1()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRO2RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO2RimuoviSezione.Click
        If RigaSelezionataRO2 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRO2.Rows.Remove(DataGridViewRO2.Rows(RigaSelezionataRO2))
                If DataGridViewRO2.Rows.Count = 0 Then
                    RigaSelezionataRO2 = -1
                    PictureBoxRO2.Image = Nothing
                    TextBoxRO2Didascalia.Text = ""
                    TextBoxRO2Titolo.Text = ""
                    RichTextBoxRO2Descrizione.Text = ""
                Else
                    If RigaSelezionataRO2 > DataGridViewRO2.Rows.Count - 1 Then RigaSelezionataRO2 = DataGridViewRO2.Rows.Count - 1
                    CaricaDatiRO2()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRO3RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO3RimuoviSezione.Click
        If RigaSelezionataRO3 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRO3.Rows.Remove(DataGridViewRO3.Rows(RigaSelezionataRO3))
                If DataGridViewRO3.Rows.Count = 0 Then
                    RigaSelezionataRO3 = -1
                    PictureBoxRO3.Image = Nothing
                    TextBoxRO3Didascalia.Text = ""
                    TextBoxRO3Titolo.Text = ""
                    RichTextBoxRO3Descrizione.Text = ""
                Else
                    If RigaSelezionataRO3 > DataGridViewRO3.Rows.Count - 1 Then RigaSelezionataRO3 = DataGridViewRO3.Rows.Count - 1
                    CaricaDatiRO3()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRO4RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO4RimuoviSezione.Click
        If RigaSelezionataRO4 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRO4.Rows.Remove(DataGridViewRO4.Rows(RigaSelezionataRO4))
                If DataGridViewRO4.Rows.Count = 0 Then
                    RigaSelezionataRO4 = -1
                    PictureBoxRO4.Image = Nothing
                    TextBoxRO4Didascalia.Text = ""
                    TextBoxRO4Titolo.Text = ""
                    RichTextBoxRO4Descrizione.Text = ""
                Else
                    If RigaSelezionataRO4 > DataGridViewRO4.Rows.Count - 1 Then RigaSelezionataRO4 = DataGridViewRO4.Rows.Count - 1
                    CaricaDatiRO4()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRO5RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRO5RimuoviSezione.Click
        If RigaSelezionataRO5 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRO5.Rows.Remove(DataGridViewRO5.Rows(RigaSelezionataRO5))
                If DataGridViewRO5.Rows.Count = 0 Then
                    RigaSelezionataRO5 = -1
                    PictureBoxRO5.Image = Nothing
                    TextBoxRO5Didascalia.Text = ""
                    TextBoxRO5Titolo.Text = ""
                    RichTextBoxRO5Descrizione.Text = ""
                Else
                    If RigaSelezionataRO5 > DataGridViewRO5.Rows.Count - 1 Then RigaSelezionataRO5 = DataGridViewRO5.Rows.Count - 1
                    CaricaDatiRO5()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRU1RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRU1RimuoviSezione.Click
        If RigaSelezionataRU1 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRU1.Rows.Remove(DataGridViewRU1.Rows(RigaSelezionataRU1))
                If DataGridViewRU1.Rows.Count = 0 Then
                    RigaSelezionataRU1 = -1
                    PictureBoxRU1.Image = Nothing
                    TextBoxRU1Didascalia.Text = ""
                    TextBoxRU1Titolo.Text = ""
                    RichTextBoxRU1Descrizione.Text = ""
                Else
                    If RigaSelezionataRU1 > DataGridViewRU1.Rows.Count - 1 Then RigaSelezionataRU1 = DataGridViewRU1.Rows.Count - 1
                    CaricaDatiRU1()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRU2RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRU2RimuoviSezione.Click
        If RigaSelezionataRU2 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRU2.Rows.Remove(DataGridViewRU2.Rows(RigaSelezionataRU2))
                If DataGridViewRU2.Rows.Count = 0 Then
                    RigaSelezionataRU2 = -1
                    PictureBoxRU2.Image = Nothing
                    TextBoxRU2Didascalia.Text = ""
                    TextBoxRU2Titolo.Text = ""
                    RichTextBoxRU2Descrizione.Text = ""
                Else
                    If RigaSelezionataRU2 > DataGridViewRU2.Rows.Count - 1 Then RigaSelezionataRU2 = DataGridViewRU2.Rows.Count - 1
                    CaricaDatiRU2()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonRU3RimuoviSezione_Click(sender As Object, e As EventArgs) Handles ButtonRU3RimuoviSezione.Click
        If RigaSelezionataRU3 > -1 Then
            If MsgBox("Vuoi veramente rimuovere la sezione attiva?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                DataGridViewRU3.Rows.Remove(DataGridViewRU3.Rows(RigaSelezionataRU3))
                If DataGridViewRU3.Rows.Count = 0 Then
                    RigaSelezionataRU3 = -1
                    PictureBoxRU3.Image = Nothing
                    TextBoxRU3Didascalia.Text = ""
                    TextBoxRU3Titolo.Text = ""
                    RichTextBoxRU3Descrizione.Text = ""
                Else
                    If RigaSelezionataRU3 > DataGridViewRU3.Rows.Count - 1 Then RigaSelezionataRU3 = DataGridViewRU3.Rows.Count - 1
                    CaricaDatiRU3()
                End If
            End If
        End If
    End Sub

    Private Sub ButtonGeneraleSpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonGeneraleSpostaSu.Click
        If RigaSelezionataGenerale > 0 Then
            Dim tempImage As Image = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value
            Dim tempTitolo As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value
            Dim tempFileImage As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value
            RigaSelezionataGenerale = RigaSelezionataGenerale - 1
            DataGridViewGenerale.Rows(RigaSelezionataGenerale + 1).Cells(0).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale + 1).Cells(1).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale + 1).Cells(2).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale + 1).Cells(3).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale + 1).Cells(4).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale + 1).Cells(5).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value = tempImage
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value = tempDidascalia
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value = tempTitolo
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value = tempDescrisione
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value = tempDescrizioneRTF
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value = tempFileImage
            CaricaDatiGenerale()
        End If
    End Sub

    Private Sub ButtonRO1SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRO1SpostaSu.Click
        If RigaSelezionataRO1 > 0 Then
            Dim tempImage As Image = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value
            RigaSelezionataRO1 = RigaSelezionataRO1 - 1
            DataGridViewRO1.Rows(RigaSelezionataRO1 + 1).Cells(0).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 + 1).Cells(1).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 + 1).Cells(2).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 + 1).Cells(3).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 + 1).Cells(4).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 + 1).Cells(5).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value = tempImage
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value = tempDidascalia
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value = tempTitolo
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value = tempDescrisione
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value = tempFileImage
            CaricaDatiRO1()
        End If
    End Sub

    Private Sub ButtonRO2SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRO2SpostaSu.Click
        If RigaSelezionataRO2 > 0 Then
            Dim tempImage As Image = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value
            RigaSelezionataRO2 = RigaSelezionataRO2 - 1
            DataGridViewRO2.Rows(RigaSelezionataRO2 + 1).Cells(0).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 + 1).Cells(1).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 + 1).Cells(2).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 + 1).Cells(3).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 + 1).Cells(4).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 + 1).Cells(5).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value = tempImage
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value = tempDidascalia
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value = tempTitolo
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value = tempDescrisione
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value = tempFileImage
            CaricaDatiRO2()
        End If
    End Sub

    Private Sub ButtonRO3SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRO3SpostaSu.Click
        If RigaSelezionataRO3 > 0 Then
            Dim tempImage As Image = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value
            RigaSelezionataRO3 = RigaSelezionataRO3 - 1
            DataGridViewRO3.Rows(RigaSelezionataRO3 + 1).Cells(0).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 + 1).Cells(1).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 + 1).Cells(2).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 + 1).Cells(3).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 + 1).Cells(4).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 + 1).Cells(5).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value = tempImage
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value = tempDidascalia
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value = tempTitolo
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value = tempDescrisione
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value = tempFileImage
            CaricaDatiRO3()
        End If
    End Sub

    Private Sub ButtonRO4SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRO4SpostaSu.Click
        If RigaSelezionataRO4 > 0 Then
            Dim tempImage As Image = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value
            RigaSelezionataRO4 = RigaSelezionataRO4 - 1
            DataGridViewRO4.Rows(RigaSelezionataRO4 + 1).Cells(0).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 + 1).Cells(1).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 + 1).Cells(2).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 + 1).Cells(3).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 + 1).Cells(4).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 + 1).Cells(5).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value = tempImage
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value = tempDidascalia
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value = tempTitolo
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value = tempDescrisione
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value = tempFileImage
            CaricaDatiRO4()
        End If
    End Sub

    Private Sub ButtonRO5SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRO5SpostaSu.Click
        If RigaSelezionataRO5 > 0 Then
            Dim tempImage As Image = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value
            RigaSelezionataRO5 = RigaSelezionataRO5 - 1
            DataGridViewRO5.Rows(RigaSelezionataRO5 + 1).Cells(0).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 + 1).Cells(1).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 + 1).Cells(2).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 + 1).Cells(3).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 + 1).Cells(4).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 + 1).Cells(5).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value = tempImage
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value = tempDidascalia
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value = tempTitolo
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value = tempDescrisione
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value = tempFileImage
            CaricaDatiRO5()
        End If
    End Sub

    Private Sub ButtonRU1SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRU1SpostaSu.Click
        If RigaSelezionataRU1 > 0 Then
            Dim tempImage As Image = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value
            RigaSelezionataRU1 = RigaSelezionataRU1 - 1
            DataGridViewRU1.Rows(RigaSelezionataRU1 + 1).Cells(0).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 + 1).Cells(1).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 + 1).Cells(2).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 + 1).Cells(3).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 + 1).Cells(4).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 + 1).Cells(5).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value = tempImage
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value = tempDidascalia
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value = tempTitolo
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value = tempDescrisione
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value = tempFileImage
            CaricaDatiRU1()
        End If
    End Sub

    Private Sub ButtonRU2SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRU2SpostaSu.Click
        If RigaSelezionataRU2 > 0 Then
            Dim tempImage As Image = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value
            RigaSelezionataRU2 = RigaSelezionataRU2 - 1
            DataGridViewRU2.Rows(RigaSelezionataRU2 + 1).Cells(0).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 + 1).Cells(1).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 + 1).Cells(2).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 + 1).Cells(3).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 + 1).Cells(4).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 + 1).Cells(5).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value = tempImage
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value = tempDidascalia
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value = tempTitolo
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value = tempDescrisione
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value = tempFileImage
            CaricaDatiRU2()
        End If
    End Sub

    Private Sub ButtonRU3SpostaSu_Click(sender As Object, e As EventArgs) Handles ButtonRU3SpostaSu.Click
        If RigaSelezionataRU3 > 0 Then
            Dim tempImage As Image = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value
            RigaSelezionataRU3 = RigaSelezionataRU3 - 1
            DataGridViewRU3.Rows(RigaSelezionataRU3 + 1).Cells(0).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 + 1).Cells(1).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 + 1).Cells(2).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 + 1).Cells(3).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 + 1).Cells(4).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 + 1).Cells(5).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value = tempImage
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value = tempDidascalia
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value = tempTitolo
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value = tempDescrisione
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value = tempFileImage
            CaricaDatiRU3()
        End If
    End Sub

    Private Sub ButtonGeneraleSpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonGeneraleSpostaGiu.Click
        If RigaSelezionataGenerale < DataGridViewGenerale.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value
            Dim tempTitolo As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value
            Dim tempFileImage As String = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value
            RigaSelezionataGenerale = RigaSelezionataGenerale + 1
            DataGridViewGenerale.Rows(RigaSelezionataGenerale - 1).Cells(0).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale - 1).Cells(1).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale - 1).Cells(2).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale - 1).Cells(3).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale - 1).Cells(4).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale - 1).Cells(5).Value = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value = tempImage
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(1).Value = tempDidascalia
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(2).Value = tempTitolo
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(3).Value = tempDescrisione
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(4).Value = tempDescrizioneRTF
            DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(5).Value = tempFileImage
            CaricaDatiGenerale()
        End If
    End Sub

    Private Sub ButtonRO1SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRO1SpostaGiu.Click
        If RigaSelezionataRO1 < DataGridViewRO1.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value
            RigaSelezionataRO1 = RigaSelezionataRO1 + 1
            DataGridViewRO1.Rows(RigaSelezionataRO1 - 1).Cells(0).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 - 1).Cells(1).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 - 1).Cells(2).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 - 1).Cells(3).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 - 1).Cells(4).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1 - 1).Cells(5).Value = DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(0).Value = tempImage
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(1).Value = tempDidascalia
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(2).Value = tempTitolo
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(3).Value = tempDescrisione
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO1.Rows(RigaSelezionataRO1).Cells(5).Value = tempFileImage
            CaricaDatiRO1()
        End If
    End Sub

    Private Sub ButtonRO2SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRO2SpostaGiu.Click
        If RigaSelezionataRO2 < DataGridViewRO2.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value
            RigaSelezionataRO2 = RigaSelezionataRO2 + 1
            DataGridViewRO2.Rows(RigaSelezionataRO2 - 1).Cells(0).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 - 1).Cells(1).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 - 1).Cells(2).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 - 1).Cells(3).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 - 1).Cells(4).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2 - 1).Cells(5).Value = DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(0).Value = tempImage
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(1).Value = tempDidascalia
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(2).Value = tempTitolo
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(3).Value = tempDescrisione
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO2.Rows(RigaSelezionataRO2).Cells(5).Value = tempFileImage
            CaricaDatiRO2()
        End If
    End Sub

    Private Sub ButtonRO3SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRO3SpostaGiu.Click
        If RigaSelezionataRO3 < DataGridViewRO3.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value
            RigaSelezionataRO3 = RigaSelezionataRO3 + 1
            DataGridViewRO3.Rows(RigaSelezionataRO3 - 1).Cells(0).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 - 1).Cells(1).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 - 1).Cells(2).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 - 1).Cells(3).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 - 1).Cells(4).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3 - 1).Cells(5).Value = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value = tempImage
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(1).Value = tempDidascalia
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(2).Value = tempTitolo
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(3).Value = tempDescrisione
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(5).Value = tempFileImage
            CaricaDatiRO3()
        End If
    End Sub

    Private Sub ButtonRO4SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRO4SpostaGiu.Click
        If RigaSelezionataRO4 < DataGridViewRO4.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value
            RigaSelezionataRO4 = RigaSelezionataRO4 + 1
            DataGridViewRO4.Rows(RigaSelezionataRO4 - 1).Cells(0).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 - 1).Cells(1).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 - 1).Cells(2).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 - 1).Cells(3).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 - 1).Cells(4).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4 - 1).Cells(5).Value = DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(0).Value = tempImage
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(1).Value = tempDidascalia
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(2).Value = tempTitolo
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(3).Value = tempDescrisione
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO4.Rows(RigaSelezionataRO4).Cells(5).Value = tempFileImage
            CaricaDatiRO4()
        End If
    End Sub

    Private Sub ButtonRO5SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRO5SpostaGiu.Click
        If RigaSelezionataRO5 < DataGridViewRO5.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value
            RigaSelezionataRO5 = RigaSelezionataRO5 + 1
            DataGridViewRO5.Rows(RigaSelezionataRO5 - 1).Cells(0).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 - 1).Cells(1).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 - 1).Cells(2).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 - 1).Cells(3).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 - 1).Cells(4).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5 - 1).Cells(5).Value = DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(0).Value = tempImage
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(1).Value = tempDidascalia
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(2).Value = tempTitolo
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(3).Value = tempDescrisione
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRO5.Rows(RigaSelezionataRO5).Cells(5).Value = tempFileImage
            CaricaDatiRO5()
        End If
    End Sub

    Private Sub ButtonRU1SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRU1SpostaGiu.Click
        If RigaSelezionataRU1 < DataGridViewRU1.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value
            RigaSelezionataRU1 = RigaSelezionataRU1 + 1
            DataGridViewRU1.Rows(RigaSelezionataRU1 - 1).Cells(0).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 - 1).Cells(1).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 - 1).Cells(2).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 - 1).Cells(3).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 - 1).Cells(4).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1 - 1).Cells(5).Value = DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(0).Value = tempImage
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(1).Value = tempDidascalia
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(2).Value = tempTitolo
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(3).Value = tempDescrisione
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRU1.Rows(RigaSelezionataRU1).Cells(5).Value = tempFileImage
            CaricaDatiRU1()
        End If
    End Sub

    Private Sub ButtonRU2SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRU2SpostaGiu.Click
        If RigaSelezionataRU2 < DataGridViewRU2.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value
            RigaSelezionataRU2 = RigaSelezionataRU2 + 1
            DataGridViewRU2.Rows(RigaSelezionataRU2 - 1).Cells(0).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 - 1).Cells(1).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 - 1).Cells(2).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 - 1).Cells(3).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 - 1).Cells(4).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2 - 1).Cells(5).Value = DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(0).Value = tempImage
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(1).Value = tempDidascalia
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(2).Value = tempTitolo
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(3).Value = tempDescrisione
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRU2.Rows(RigaSelezionataRU2).Cells(5).Value = tempFileImage
            CaricaDatiRU2()
        End If
    End Sub

    Private Sub ButtonRU3SpostaGiu_Click(sender As Object, e As EventArgs) Handles ButtonRU3SpostaGiu.Click
        If RigaSelezionataRU3 < DataGridViewRU3.Rows.Count - 1 Then
            Dim tempImage As Image = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value
            Dim tempDidascalia As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value
            Dim tempTitolo As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value
            Dim tempDescrisione As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value
            Dim tempDescrizioneRTF As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value
            Dim tempFileImage As String = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value
            RigaSelezionataRU3 = RigaSelezionataRU3 + 1
            DataGridViewRU3.Rows(RigaSelezionataRU3 - 1).Cells(0).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 - 1).Cells(1).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 - 1).Cells(2).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 - 1).Cells(3).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 - 1).Cells(4).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3 - 1).Cells(5).Value = DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(0).Value = tempImage
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(1).Value = tempDidascalia
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(2).Value = tempTitolo
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(3).Value = tempDescrisione
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(4).Value = tempDescrizioneRTF
            DataGridViewRU3.Rows(RigaSelezionataRU3).Cells(5).Value = tempFileImage
            CaricaDatiRU3()
        End If
    End Sub

    'fine delle sezioni replicate

    Private Sub ButtonGeneraPerizia_Click(sender As Object, e As EventArgs) Handles ButtonGeneraPerizia.Click
        If My.Computer.FileSystem.FileExists(FileModelloBasePeriziaRTF) Then
            RichTextBoxPerizia.LoadFile(FileModelloBasePeriziaRTF, RichTextBoxStreamType.RichText)
            Try
                If ComboBoxPerito.SelectedIndex = 1 Then
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHPERITO>", ComboBoxPerito.Items(ComboBoxPerito.SelectedIndex).ToString & ", con studio in Abano Terme (PD), viale Giuseppe Mazzini, n. 41/A, iscritto in data 25/05/2005 all’ordine degli ingegneri, con numero 5508 nell’albo della provincia di Padova")
                Else
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHPERITO>", ComboBoxPerito.Items(ComboBoxPerito.SelectedIndex).ToString & ", con studio in Vicenza (VI), via Arzignano 63, iscritto in data 28 giugno 2018 all’ordine degli ingegneri, con numero 3761 nell’albo della provincia di Vicenza")
                End If
                If TextBoxDataPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHDATA>", TextBoxDataPerizia.Text)
                If TextBoxNomeAzienda.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHNOMEAZIENDA>", TextBoxNomeAzienda.Text)
                If TextBoxIndirizzoAzienda.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHINDIRIZZOSEDE>", TextBoxIndirizzoAzienda.Text)
                If TextBoxCF_PIVA.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHCFPIVA>", TextBoxCF_PIVA.Text)
                If ComboBoxTipoRelazione.SelectedIndex = 2 Then
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHTIPOPERIZIA1>", "GIURATA")
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHTIPOPERIZIA2>", "giurata")
                Else
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHTIPOPERIZIA1>", "ASSEVERATA")
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHTIPOPERIZIA2>", "asseverata")
                End If
                If TextBoxTipoInvestimento.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHTIPOLOGIA>", TextBoxTipoInvestimento.Text)
                If TextBoxProduttore.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHPRODUTTORE>", TextBoxProduttore.Text)
                If TextBoxModello.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHMODELLO>", TextBoxModello.Text)
                If TextBoxMatricola.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHMATRICOLA>", TextBoxMatricola.Text)
                If TextBoxDotazioni.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHDOTAZIONI>", TextBoxDotazioni.Text)
                If TextBoxCostoTotale.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHCOSTO>", TextBoxCostoTotale.Text)
                If TextBoxFornitore.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHFORNITORE>", TextBoxFornitore.Text)
                If CheckBoxLeasing.Checked Then
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHLEASING>", " ed è stato finanziato mediante leasing")
                Else
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHLEASING>", "")
                End If
                RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHGRUPPO>", ComboBoxGruppo.Items(ComboBoxGruppo.SelectedIndex).ToString)
                RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHCATEGORIA>", GruppoEPunto(ComboBoxGruppo.SelectedIndex, ComboBoxCategoria.SelectedIndex))
                Dim CorpoPerizia As String = ""
                If ComboBoxGruppo.SelectedIndex = 0 Then
                    CorpoPerizia = "Come previsto dall\rquote allegato A annesso alla Legge 11 dicembre 2016, n. 232 e secondo le interpretazioni fornite con la circolare 4/E e le FAQ sopra citate, il bene materiale strumentale oggetto dell\rquote investimento presenta tutte le seguenti caratteristiche obbligatorie:\par\pard{\pntext\f0 1.\tab}{\*\pn\pnlvlbody\pnf0\pnindent0\pnstart1\pndec{\pntxta.}}\nowidctlpar\fi-390\li390\sl555\slmult0\qj controllo per mezzo di CNC (Computer Numerical Control) e/o PLC (Programmable Logic Controller)<PLHRO1DETTAGLIOPERIZIA>;\par{\pntext\f0 2.\tab}interconnessione ai sistemi informatici di fabbrica con caricamento da remoto di istruzioni e/o part program<PLHRO2DETTAGLIOPERIZIA>;\par{\pntext\f0 3.\tab}integrazione automatizzata con il sistema logistico della fabbrica o con la rete di fornitura e/o con altre macchine del ciclo produttivo<PLHRO3DETTAGLIOPERIZIA>;\par{\pntext\f0 4.\tab}interfaccia tra uomo e macchina semplici e intuitive<PLHRO4DETTAGLIOPERIZIA>;\par{\pntext\f0 5.\tab}rispondenza ai pi\'f9 recenti parametri di sicurezza, salute e igiene del lavoro<PLHRO5DETTAGLIOPERIZIA>.\par\pard\nowidctlpar\sl555\slmult0\qj Presenta inoltre le seguenti caratteristiche facoltative per renderle assimilabili o integrabili a sistemi cyberfisici:\par\pard{\*\pn\pnlvlblt\pnf2\pnindent0{\pntxtb\'B7}}\nowidctlpar\fi-360\li360\sl555\slmult0\qj"
                    If CheckBoxRU1.Checked Then CorpoPerizia = CorpoPerizia & "{\pntext\f2\'B7\tab}sistemi di telemanutenzione e/o telediagnosi e/o controllo in remoto<PLHRU1DETTAGLIOPERIZIA>;\par"
                    If CheckBoxRU2.Checked Then CorpoPerizia = CorpoPerizia & "{\pntext\f2\'B7\tab}monitoraggio continuo delle condizioni di lavoro e dei parametri di processo mediante opportuni set di sensori e adattivit\'e0 alle derive di processo<PLHRU2DETTAGLIOPERIZIA>;\par"
                    If CheckBoxRU3.Checked Then CorpoPerizia = CorpoPerizia & "{\pntext\f2\'B7\tab}caratteristiche di integrazione tra macchina fisica e/o impianto con la modellizzazione e/o la simulazione del proprio comportamento nello svolgimento del processo (sistema cyberfisico)<PLHRU3DETTAGLIOPERIZIA>.\par"
                    CorpoPerizia = CorpoPerizia & "\pard\par"
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHCORPOPERIZIA>", CorpoPerizia)
                    If TextBoxRO1DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO1DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO1DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO1DETTAGLIOPERIZIA>", "")
                    If TextBoxRO2DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO2DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO2DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO2DETTAGLIOPERIZIA>", "")
                    If TextBoxRO3DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO3DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO3DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO3DETTAGLIOPERIZIA>", "")
                    If TextBoxRO4DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO4DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO4DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO4DETTAGLIOPERIZIA>", "")
                    If TextBoxRO5DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO5DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO5DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO5DETTAGLIOPERIZIA>", "")
                    If TextBoxRU1DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRU1DETTAGLIOPERIZIA>", " \endash  " & TextBoxRU1DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRU1DETTAGLIOPERIZIA>", "")
                    If TextBoxRU2DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRU2DETTAGLIOPERIZIA>", " \endash  " & TextBoxRU2DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRU2DETTAGLIOPERIZIA>", "")
                    If TextBoxRU3DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRU3DETTAGLIOPERIZIA>", " \endash  " & TextBoxRU3DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRU3DETTAGLIOPERIZIA>", "")
                Else
                    CorpoPerizia = "Come previsto dall\rquote allegato A annesso alla Legge 11 dicembre 2016, n. 232 e secondo le interpretazioni fornite con la circolare 4/E e le FAQ sopra citate, il bene materiale strumentale oggetto dell\rquote investimento \'e8 interconnesso in quanto:\par\pard{\pntext\f0 1.\tab}{\*\pn\pnlvlbody\pnf0\pnindent0\pnstart1\pndec{\pntxta.}}\nowidctlpar\fi-390\li390\sl555\slmult0\qj scambia informazioni con sistemi interni (es.: sistema gestionale, sistemi di pianificazione, sistemi di progettazione e sviluppo del prodotto, monitoraggio, anche in remoto, e controllo, altre macchine dello stabilimento, ecc.) e/o esterni (es.: clienti, fornitori, partner nella progettazione e sviluppo collaborativo, altri siti di produzione, supply chain, ecc.) per mezzo di un collegamento basato su specifiche documentate, disponibili pubblicamente e internazionalmente riconosciute (esempi: TCP/IP, HTTP, MQTT, ecc.)<PLHRO1DETTAGLIOPERIZIA>;\par{\pntext\f0 2.\tab}\'e8 identificato univocamente, al fine di riconoscere l\rquote origine delle informazioni, mediante l\rquote utilizzo di standard di indirizzamento internazionalmente riconosciuti (es.: indirizzo IP)<PLHRO2DETTAGLIOPERIZIA>.\par"
                    RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHCORPOPERIZIA>", CorpoPerizia)
                    If TextBoxRO1DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO1DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO1DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO1DETTAGLIOPERIZIA>", "")
                    If TextBoxRO2DettaglioPerizia.Text.Trim <> "" Then RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO2DETTAGLIOPERIZIA>", " \endash  " & TextBoxRO2DettaglioPerizia.Text) Else RichTextBoxPerizia.Rtf = RichTextBoxPerizia.Rtf.Replace("<PLHRO2DETTAGLIOPERIZIA>", "")
                End If
            Catch
                MsgBox("Errore nella creazione della relazione," & vbCrLf & "controllare che siano presenti gli elementi base per poterla creare")
            End Try
        End If
    End Sub

    Private Sub ButtonGeneraRelazioneVecchio_Click(sender As Object, e As EventArgs) 'Handles ButtonGeneraRelazione.Click
        Dim FileModelloBaseRTF As String
        If ComboBoxGruppo.SelectedIndex = 0 Then
            FileModelloBaseRTF = FileModelloBaseRTF1
        Else
            FileModelloBaseRTF = FileModelloBaseRTF23
        End If
        If My.Computer.FileSystem.FileExists(FileModelloBaseRTF) Then
            RichTextBoxRelazione.LoadFile(FileModelloBaseRTF, RichTextBoxStreamType.RichText)
            MsgBox("La creazione della relazione può richiedere alcuni minuti, attendere il messaggio di completamento")
            Try
                'Per includere il link a un'immagine usare:
                '{\field{\*\fldinst{INCLUDEPICTURE "c:\\\\filename.bmp" MERGEFORMAT \\d \\w3000 \\h4500 \\pm1 \\px0 \\py0 \\pw0}}}
                'le barre vanno ripetute 4 volte nel nome file

                'inserisco gli elementi semplici
                If Not (PictureBoxLogoAzienda.Image Is Nothing) Then
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHLOGOAZIENDA>"), 16) : Clipboard.SetImage(PictureBoxLogoAzienda.Image) : RichTextBoxRelazione.Paste()
                End If
                If TextBoxNomeAzienda.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHNOMEAZIENDA>", TextBoxNomeAzienda.Text)
                If TextBoxIndirizzoAzienda.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHINDIRIZZOSEDE>", TextBoxIndirizzoAzienda.Text)
                If TextBoxCF_PIVA.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCFPIVA>", TextBoxCF_PIVA.Text)
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHTIPORELAZIONE>", ComboBoxTipoRelazione.Items(ComboBoxTipoRelazione.SelectedIndex).ToString)
                If Not (PictureBoxFotoCopertina.Image Is Nothing) Then
                    'prima volta per la prima pagina
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHFOTOCOPERTINA>"), 18) : Clipboard.SetImage(PictureBoxFotoCopertina.Image) : RichTextBoxRelazione.Paste()
                    'seconda volta per la pagina di dettaglio
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHFOTOCOPERTINA>"), 18) : Clipboard.SetImage(PictureBoxFotoCopertina.Image) : RichTextBoxRelazione.Paste()
                End If
                If TextBoxTipoInvestimento.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHTIPOLOGIA>", TextBoxTipoInvestimento.Text)
                If TextBoxProduttore.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHPRODUTTORE>", TextBoxProduttore.Text)
                If TextBoxModello.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHMODELLO>", TextBoxModello.Text)
                If TextBoxMatricola.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHMATRICOLA>", TextBoxMatricola.Text)
                If TextBoxAnno.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHANNOPRODUZIONE>", TextBoxAnno.Text)
                If TextBoxDotazioni.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHDOTAZIONI>", TextBoxDotazioni.Text)
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHPERITO>", ComboBoxPerito.Items(ComboBoxPerito.SelectedIndex).ToString)
                If TextBoxDataPerizia.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHDATA>", TextBoxDataPerizia.Text)
                If TextBoxProtocolloPerizia.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHPROTOCOLLO>", TextBoxProtocolloPerizia.Text)
                If ComboBoxTipoRelazione.SelectedIndex = 2 Then
                    If TextBoxNotaio.Text.Trim <> "" Then
                        RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHENTEASSEVERAZIONE>", "Ente asseveratore:\tab " & TextBoxNotaio.Text)
                    Else
                        RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHENTEASSEVERAZIONE>", "Ente asseveratore:\tab <PLHENTEASSEVERAZIONE>")
                    End If
                Else
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHENTEASSEVERAZIONE>", "")
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHGRUPPO>", ComboBoxGruppo.Items(ComboBoxGruppo.SelectedIndex).ToString)
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCATEGORIA>", GruppoEPunto(ComboBoxGruppo.SelectedIndex, ComboBoxCategoria.SelectedIndex))
                If TextBoxAltreInfoCategoria.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHALTREINFO>", TextBoxAltreInfoCategoria.Text)
                If TextBoxCostoTotale.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCOSTO>", TextBoxCostoTotale.Text)
                If TextBoxFornitore.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHFORNITORE>", "\par Il bene è stato fornito da " & TextBoxFornitore.Text & ".")
                If CheckBoxLeasing.Checked Then
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHLEASING>", "\par L'investimento è stato finanziato mediante leasing.")
                Else
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHLEASING>", "")
                End If
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHDETTAGLIOCOSTO>"), 19) : Clipboard.SetText(RichTextBoxValoreCespite.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                Dim PlaceHolderImmagine As String
                Dim PlaceHolderTesto As String
                'Dettaglio
                Dim Composizione As String = ""
                Dim NumeroFigura As Integer = 2
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHDETTAGLIOTESTOINIZIALE>"), 27) : Clipboard.SetText(RichTextBoxGeneraleTestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewGenerale.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewGenerale.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewGenerale.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewGenerale.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewGenerale.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHDETTAGLIOCORPO>", Composizione)
                For i = 0 To DataGridViewGenerale.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewGenerale.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewGenerale.Rows(i).Cells(3).Value & "").Trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewGenerale.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHDETTAGLIOTESTOFINALE>"), 25) : Clipboard.SetText(RichTextBoxGeneraleTestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                'RO1
                Dim offset As Integer = 8 'bilancia l'errore di conteggio
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO1TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRO1TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRO1.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO1.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO1.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO1.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO1.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRO1CORPO>", Composizione)
                For i = 0 To DataGridViewRO1.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRO1.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRO1.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRO1.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO1TESTOFINALE>") + 8, 19) : Clipboard.SetText(RichTextBoxRO1TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                'RO2
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO2TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRO2TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRO2.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO2.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO2.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO2.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO2.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRO2CORPO>", Composizione)
                offset = offset + 4 'bilancia l'errore di conteggio
                For i = 0 To DataGridViewRO2.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRO2.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRO2.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRO2.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO2TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRO2TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                'RO3
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO3TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRO3TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRO3.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO3.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO3.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO3.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO3.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRO3CORPO>", Composizione)
                For i = 0 To DataGridViewRO3.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRO3.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRO3.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRO3.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO3TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRO3TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                'RO4
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO4TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRO4TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRO4.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO4.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO4.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO4.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO4.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRO4CORPO>", Composizione)
                For i = 0 To DataGridViewRO4.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRO4.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRO4.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRO4.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO4TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRO4TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                'RO5
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO5TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRO5TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRO5.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO5.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO5.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO5.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO5.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRO5CORPO>", Composizione)
                For i = 0 To DataGridViewRO5.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRO5.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRO5.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRO5.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO5TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRO5TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                GC.Collect()

                'RU1
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU1TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRU1TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRU1.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRU1.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRU1.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRU1.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRU1.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU1CORPO>", Composizione)
                For i = 0 To DataGridViewRU1.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRU1.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRU1.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRU1.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU1TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRU1TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                If CheckBoxRU1.Checked Then
                    Composizione = "\f3\u9746?\f0  Il bene soddisfa il requisito ulteriore RU1\line\f3\u9744?\f0  Il bene NON soddisfa il requisito ulteriore RU1"
                Else
                    Composizione = "\f3\u9744?\f0  Il bene soddisfa il requisito ulteriore RU1\line\f3\u9746?\f0  Il bene NON soddisfa il requisito ulteriore RU1"
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU1VERIFICAREQUISITO>", Composizione)
                GC.Collect()

                'RU2
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU2TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRU2TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRU2.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRU2.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRU2.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRU2.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRU2.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU2CORPO>", Composizione)
                For i = 0 To DataGridViewRU2.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRU2.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRU2.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRU2.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU2TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRU2TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                If CheckBoxRU2.Checked Then
                    Composizione = "\f3\u9746?\f0  Il bene soddisfa il requisito ulteriore RU2\line\f3\u9744?\f0  Il bene NON soddisfa il requisito ulteriore RU2"
                Else
                    Composizione = "\f3\u9744?\f0  Il bene soddisfa il requisito ulteriore RU2\line\f3\u9746?\f0  Il bene NON soddisfa il requisito ulteriore RU2"
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU2VERIFICAREQUISITO>", Composizione)
                GC.Collect()

                'RU3
                Composizione = ""
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU3TESTOINIZIALE>") + offset, 21) : Clipboard.SetText(RichTextBoxRU3TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                For i = 0 To DataGridViewRU3.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRU3.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRU3.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRU3.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRU3.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU3CORPO>", Composizione)
                For i = 0 To DataGridViewRU3.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderImmagine) + offset, PlaceHolderImmagine.Length()) : Clipboard.SetImage(DataGridViewRU3.Rows(i).Cells(0).Value) : RichTextBoxRelazione.Paste()
                    If (DataGridViewRU3.Rows(i).Cells(3).Value & "").trim <> "" Then
                        RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf(PlaceHolderTesto) + offset, PlaceHolderTesto.Length()) : Clipboard.SetText(DataGridViewRU3.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                    End If
                Next
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU3TESTOFINALE>") + offset, 19) : Clipboard.SetText(RichTextBoxRU3TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                If CheckBoxRU3.Checked Then
                    Composizione = "\f3\u9746?\f0  Il bene soddisfa il requisito ulteriore RU3\line\f3\u9744?\f0  Il bene NON soddisfa il requisito ulteriore RU3"
                Else
                    Composizione = "\f3\u9744?\f0  Il bene soddisfa il requisito ulteriore RU3\line\f3\u9746?\f0  Il bene NON soddisfa il requisito ulteriore RU3"
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU3VERIFICAREQUISITO>", Composizione)
                GC.Collect()

                'Checklist 1
                Composizione = ""
                For i = 0 To ComboBoxCategoria.Items.Count - 1
                    If i = ComboBoxCategoria.SelectedIndex Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ComboBoxCategoria.Items(i).replace(". ", ".\tab ") & "\par"
                Next

                If ComboBoxGruppo.SelectedIndex = 0 Then
                    'Checklist 2 (statica)
                    Composizione = Composizione & "\par\pard\keep\keepn\widctlpar\s3\fi-709\li709\sb400\sa400\tx709\cf4\fs22 2.6.2.\tab Check List 2 \endash  Beni allegato A \endash  Requisiti obbligatori (par. 11.1 Circ. AE 4/E)\par\pard\widctlpar\fi-992\li992\sa40\cf0\fs18"
                    Composizione = Composizione & "\u9746? .\tab controllo per mezzo di CNC (Computer Numerical Control) e/o PLC (Programmable Logic Controller);\par"
                    Composizione = Composizione & "\u9746? .\tab interconnessione ai sistemi informatici di fabbrica con caricamento da remoto di istruzioni e/o part program;\par"
                    Composizione = Composizione & "\u9746? .\tab integrazione automatizzata con il sistema logistico della fabbrica o con la rete di fornitura e/o con altre macchine del ciclo produttivo;\par"
                    Composizione = Composizione & "\u9746? .\tab interfaccia tra uomo e macchina semplici e intuitive;\par"
                    Composizione = Composizione & "\u9746? .\tab rispondenza ai più recenti parametri di sicurezza, salute e igiene del lavoro.\par"

                    'Checklist 3 
                    Composizione = Composizione & "\par\pard\keep\keepn\widctlpar\s3\fi-709\li709\sb400\sa400\tx709\cf4\fs22 2.6.3.\tab Check List 3 \endash  Beni allegato A \endash  Requisiti Ulteriori (par. 11.2 Circ. AE 4/E)\par\pard\widctlpar\fi-992\li992\sa40\cf0\fs18"
                    If CheckBoxRU1.Checked Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ".\tab sistemi di telemanutenzione e/o telediagnosi e/o controllo in remoto;\par"
                    If CheckBoxRU2.Checked Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ".\tab monitoraggio continuo delle condizioni di lavoro e dei parametri di processo mediante opportuni set di sensori e adattività alle derive di processo;\par"
                    If CheckBoxRU3.Checked Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ".\tab caratteristiche di integrazione tra macchina fisica e/o impianto con la modellizzazione e/o la simulazione del proprio comportamento nello svolgimento del processo (sistema cyberfisico).\par"
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCHECKLIST>", Composizione)

                Composizione = ""
                For Each File As String In My.Computer.FileSystem.GetFiles(TextboxCartella.Text, FileIO.SearchOption.SearchAllSubDirectories, "Allegat*.pdf")
                    Dim Informazioni As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(File)
                    Composizione = Composizione & Informazioni.Name() & "\par "
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHALLEGATI>", Composizione)
                MsgBox("Relazione pronta")
            Catch
                MsgBox("Errore nella creazione della relazione," & vbCrLf & "controllare che siano presenti gli elementi base per poterla creare")
            End Try
        Else
            MsgBox("File modello non trovato")
        End If
    End Sub
    Private Sub ButtonGeneraRelazione_Click(sender As Object, e As EventArgs) Handles ButtonGeneraRelazione.Click
        Dim FileModelloBaseRTF As String
        If ComboBoxGruppo.SelectedIndex = 0 Then
            FileModelloBaseRTF = FileModelloBaseRTF1
        Else
            FileModelloBaseRTF = FileModelloBaseRTF23
        End If
        If My.Computer.FileSystem.FileExists(FileModelloBaseRTF) Then
            RichTextBoxRelazione.LoadFile(FileModelloBaseRTF, RichTextBoxStreamType.RichText)
            MsgBox("La creazione della relazione può richiedere alcuni minuti, attendere il messaggio di completamento")
            'Funzioni che evitano errodi dati dalla fretta di compilare
            If TextBoxTipoInvestimento.Text = "Es. Centro di lavoro / Tornio / Impianto di lavaggio" Or TextBoxTipoInvestimento.Text.Trim() = "" Then TextBoxDotazioni.Text = "" : MsgBox("Attenzione, mancano informazioni importanti come il tipo do investimento (Es. Centro di lavoro / Tornio / Impianto di lavaggio), si raccomanda di compilarle a mano!")
            If TextBoxDotazioni.Text = "Es. Il tornio è dotato di un caricatore di barre di marca Meta con matricola XXX" Then TextBoxDotazioni.Text = ""
            If TextBoxAltreInfoCategoria.Text = "Es. se settore agricolo citare la Norma UNI-PdR 91-2020, se macchina semplice senza part program citare la Circolare MiSE n . 295485 del 01 agosto 2018" Then TextBoxAltreInfoCategoria.Text = ""

            Try
                'Per includere il link a un'immagine usare:
                '{\field{\*\fldinst{INCLUDEPICTURE "c:\\\\filename.bmp" MERGEFORMAT \\d \\w3000 \\h4500 \\pm1 \\px0 \\py0 \\pw0}}}
                'le barre vanno ripetute 4 volte nel nome file

                'inserisco gli elementi semplici
                If Not (PictureBoxLogoAzienda.Image Is Nothing) Then
                    Clipboard.SetImage(PictureBoxLogoAzienda.Image) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHLOGOAZIENDA>"), 16) : RichTextBoxRelazione.Paste()
                End If
                If TextBoxNomeAzienda.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHNOMEAZIENDA>", TextBoxNomeAzienda.Text)
                If TextBoxIndirizzoAzienda.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHINDIRIZZOSEDE>", TextBoxIndirizzoAzienda.Text)
                If TextBoxCF_PIVA.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCFPIVA>", TextBoxCF_PIVA.Text)
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHTIPORELAZIONE>", ComboBoxTipoRelazione.Items(ComboBoxTipoRelazione.SelectedIndex).ToString)
                If Not (PictureBoxFotoCopertina.Image Is Nothing) Then
                    'prima volta per la prima pagina
                    Clipboard.SetImage(PictureBoxFotoCopertina.Image) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHFOTOCOPERTINA>"), 18) : RichTextBoxRelazione.Paste()
                    'seconda volta per la pagina di dettaglio
                    Clipboard.SetImage(PictureBoxFotoCopertina.Image) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHFOTOCOPERTINA>"), 18) : RichTextBoxRelazione.Paste()
                End If
                If TextBoxTipoInvestimento.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHTIPOLOGIA>", TextBoxTipoInvestimento.Text)
                If TextBoxProduttore.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHPRODUTTORE>", TextBoxProduttore.Text)
                If TextBoxModello.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHMODELLO>", TextBoxModello.Text)
                If TextBoxMatricola.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHMATRICOLA>", TextBoxMatricola.Text)
                If TextBoxAnno.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHANNOPRODUZIONE>", TextBoxAnno.Text)
                If TextBoxDotazioni.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHDOTAZIONI>", TextBoxDotazioni.Text)
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHPERITO>", ComboBoxPerito.Items(ComboBoxPerito.SelectedIndex).ToString)
                If TextBoxDataPerizia.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHDATA>", TextBoxDataPerizia.Text)
                If TextBoxProtocolloPerizia.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHPROTOCOLLO>", TextBoxProtocolloPerizia.Text)
                If ComboBoxTipoRelazione.SelectedIndex = 2 Then
                    If TextBoxNotaio.Text.Trim <> "" Then
                        RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHENTEASSEVERAZIONE>", "Ente asseveratore:\tab " & TextBoxNotaio.Text)
                    Else
                        RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHENTEASSEVERAZIONE>", "Ente asseveratore:\tab <PLHENTEASSEVERAZIONE>")
                    End If
                Else
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHENTEASSEVERAZIONE>", "")
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHGRUPPO>", ComboBoxGruppo.Items(ComboBoxGruppo.SelectedIndex).ToString)
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCATEGORIA>", GruppoEPunto(ComboBoxGruppo.SelectedIndex, ComboBoxCategoria.SelectedIndex))
                If TextBoxAltreInfoCategoria.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHALTREINFO>", TextBoxAltreInfoCategoria.Text)
                If TextBoxCostoTotale.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCOSTO>", TextBoxCostoTotale.Text)
                If TextBoxFornitore.Text.Trim <> "" Then RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHFORNITORE>", "\par Il bene è stato fornito da " & TextBoxFornitore.Text & ".")
                If CheckBoxLeasing.Checked Then
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHLEASING>", "\par L'investimento è stato finanziato mediante leasing.")
                Else
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHLEASING>", "")
                End If
                RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHDETTAGLIOCOSTO>"), 19) : Clipboard.SetText(RichTextBoxValoreCespite.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Paste()
                'GC.Collect()

                Dim PlaceHolderImmagine As String
                Dim PlaceHolderTesto As String
                Dim NumeroFigura As Integer = 2
                'Dettaglio
                Dim Composizione As String = ""
                RichTextBoxDettaglio.Text = "<PLHDETTAGLIOTESTOINIZIALE>" & vbCrLf & "<PLHDETTAGLIOCORPO>" & vbCrLf & "<PLHDETTAGLIOTESTOFINALE>"
                For i = 0 To DataGridViewGenerale.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewGenerale.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewGenerale.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewGenerale.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewGenerale.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxDettaglio.Rtf = RichTextBoxDettaglio.Rtf.Replace("<PLHDETTAGLIOCORPO>", Composizione)
                For i = 0 To DataGridViewGenerale.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    Clipboard.SetImage(DataGridViewGenerale.Rows(i).Cells(0).Value) : RichTextBoxDettaglio.Select(RichTextBoxDettaglio.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxDettaglio.Paste()
                    If (DataGridViewGenerale.Rows(i).Cells(3).Value & "").Trim <> "" Then
                        Clipboard.SetText(DataGridViewGenerale.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxDettaglio.Select(RichTextBoxDettaglio.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxDettaglio.Paste()
                    End If
                Next
                'System.Threading.Thread.Sleep(2000)
                Application.DoEvents()
                If RichTextBoxGeneraleTestoIniziale.Text.Trim() <> "" Then
                    Clipboard.SetText(RichTextBoxGeneraleTestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxDettaglio.Select(RichTextBoxDettaglio.Text.IndexOf("<PLHDETTAGLIOTESTOINIZIALE>"), 27) : RichTextBoxDettaglio.Paste()
                Else
                    RichTextBoxDettaglio.Rtf = RichTextBoxDettaglio.Rtf.Replace("<PLHDETTAGLIOTESTOINIZIALE>", "")
                End If
                If RichTextBoxGeneraleTestoFinale.Text.Trim() <> "" Then
                    Clipboard.SetText(RichTextBoxRO1TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxDettaglio.Select(RichTextBoxDettaglio.Text.IndexOf("<PLHDETTAGLIOTESTOFINALE>"), 25) : RichTextBoxDettaglio.Paste()
                Else
                    RichTextBoxDettaglio.Rtf = RichTextBoxDettaglio.Rtf.Replace("<PLHDETTAGLIOTESTOFINALE>", "")
                End If
                'System.Threading.Thread.Sleep(2000)
                Application.DoEvents()
                Clipboard.SetText(RichTextBoxDettaglio.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHDETTAGLIOCORPO>"), 19) : RichTextBoxRelazione.Paste()
                'GC.Collect()

                'RO1
                Composizione = ""
                RichTextBoxRO1.Text = "<PLHRO1TESTOINIZIALE>" & vbCrLf & "<PLHRO1CORPO>" & vbCrLf & "<PLHRO1TESTOFINALE>"
                For i = 0 To DataGridViewRO1.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO1.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO1.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO1.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO1.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRO1.Rtf = RichTextBoxRO1.Rtf.Replace("<PLHRO1CORPO>", Composizione)
                For i = 0 To DataGridViewRO1.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    Clipboard.SetImage(DataGridViewRO1.Rows(i).Cells(0).Value) : RichTextBoxRO1.Select(RichTextBoxRO1.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRO1.Paste()
                    If (DataGridViewRO1.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Clipboard.SetText(DataGridViewRO1.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRO1.Select(RichTextBoxRO1.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRO1.Paste()
                    Else
                        RichTextBoxRO1.Rtf = RichTextBoxRO1.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                    End If
                Next
                'System.Threading.Thread.Sleep(2000)
                Application.DoEvents()
                If RichTextBoxRO1TestoIniziale.Text.Trim() <> "" Then
                    Clipboard.SetText(RichTextBoxRO1TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO1.Select(RichTextBoxRO1.Text.IndexOf("<PLHRO1TESTOINIZIALE>"), 21) : RichTextBoxRO1.Paste()
                Else
                    RichTextBoxRO1.Rtf = RichTextBoxRO1.Rtf.Replace("<PLHRO1TESTOINIZIALE>", "")
                End If
                If RichTextBoxRO1TestoFinale.Text.Trim() <> "" Then
                    Clipboard.SetText(RichTextBoxRO1TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO1.Select(RichTextBoxRO1.Text.IndexOf("<PLHRO1TESTOFINALE>"), 19) : RichTextBoxRO1.Paste()
                Else
                    RichTextBoxRO1.Rtf = RichTextBoxRO1.Rtf.Replace("<PLHRO1TESTOFINALE>", "")
                End If
                'System.Threading.Thread.Sleep(2000)
                Application.DoEvents()
                Clipboard.SetText(RichTextBoxRO1.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO1CORPO>"), 13) : RichTextBoxRelazione.Paste()
                'GC.Collect()

                'RO2
                Composizione = ""
                RichTextBoxRO2.Text = "<PLHRO2TESTOINIZIALE>" & vbCrLf & "<PLHRO2CORPO>" & vbCrLf & "<PLHRO2TESTOFINALE>"
                For i = 0 To DataGridViewRO2.Rows.Count - 1
                    Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO2.Rows(i).Cells(1).Value & "\i0\par\pard"
                    NumeroFigura = NumeroFigura + 1
                    If DataGridViewRO2.Rows(i).Cells(2).Value.trim <> "" Then
                        Composizione = Composizione & "\pard\qj\b " & DataGridViewRO2.Rows(i).Cells(2).Value & "\b0\par"
                    End If
                    If (DataGridViewRO2.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                    End If
                Next
                RichTextBoxRO2.Rtf = RichTextBoxRO2.Rtf.Replace("<PLHRO2CORPO>", Composizione)
                For i = 0 To DataGridViewRO2.Rows.Count - 1
                    PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                    PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                    Clipboard.SetImage(DataGridViewRO2.Rows(i).Cells(0).Value) : RichTextBoxRO2.Select(RichTextBoxRO2.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRO2.Paste()
                    If (DataGridViewRO2.Rows(i).Cells(3).Value & "").trim <> "" Then
                        Clipboard.SetText(DataGridViewRO2.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRO2.Select(RichTextBoxRO2.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRO2.Paste()
                    Else
                        RichTextBoxRO2.Rtf = RichTextBoxRO2.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                    End If
                Next
                'System.Threading.Thread.Sleep(2000)
                Application.DoEvents()
                If RichTextBoxRO2TestoIniziale.Text.Trim() <> "" Then
                    Clipboard.SetText(RichTextBoxRO2TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO2.Select(RichTextBoxRO2.Text.IndexOf("<PLHRO2TESTOINIZIALE>"), 21) : RichTextBoxRO2.Paste()
                Else
                    RichTextBoxRO2.Rtf = RichTextBoxRO2.Rtf.Replace("<PLHRO2TESTOINIZIALE>", "")
                End If
                If RichTextBoxRO2TestoFinale.Text.Trim() <> "" Then
                    Clipboard.SetText(RichTextBoxRO2TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO2.Select(RichTextBoxRO2.Text.IndexOf("<PLHRO2TESTOFINALE>"), 19) : RichTextBoxRO2.Paste()
                Else
                    RichTextBoxRO2.Rtf = RichTextBoxRO2.Rtf.Replace("<PLHRO2TESTOFINALE>", "")
                End If
                'System.Threading.Thread.Sleep(2000)
                Application.DoEvents()
                Clipboard.SetText(RichTextBoxRO2.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO2CORPO>"), 13) : RichTextBoxRelazione.Paste()
                'GC.Collect()

                If ComboBoxGruppo.SelectedIndex = 0 Then 'se il bene è del gruppo 2 o 3 posso saltare la sezione seguente (che darebbe errore!)
                    'RO3
                    RichTextBoxRO3.Text = "<PLHRO3TESTOINIZIALE>" & vbCrLf & "<PLHRO3CORPO>" & vbCrLf & "<PLHRO3TESTOFINALE>"
                    Composizione = ""
                    For i = 0 To DataGridViewRO3.Rows.Count - 1
                        Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO3.Rows(i).Cells(1).Value & "\i0\par\pard"
                        NumeroFigura = NumeroFigura + 1
                        If DataGridViewRO3.Rows(i).Cells(2).Value.trim <> "" Then
                            Composizione = Composizione & "\pard\qj\b " & DataGridViewRO3.Rows(i).Cells(2).Value & "\b0\par"
                        End If
                        If (DataGridViewRO3.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                        End If
                    Next
                    RichTextBoxRO3.Rtf = RichTextBoxRO3.Rtf.Replace("<PLHRO3CORPO>", Composizione)
                    For i = 0 To DataGridViewRO3.Rows.Count - 1
                        PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                        PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                        Clipboard.SetImage(DataGridViewRO3.Rows(i).Cells(0).Value) : RichTextBoxRO3.Select(RichTextBoxRO3.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRO3.Paste()
                        If (DataGridViewRO3.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Clipboard.SetText(DataGridViewRO3.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRO3.Select(RichTextBoxRO3.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRO3.Paste()
                        Else
                            RichTextBoxRO3.Rtf = RichTextBoxRO3.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                        End If
                    Next
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    If RichTextBoxRO3TestoIniziale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRO3TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO3.Select(RichTextBoxRO3.Text.IndexOf("<PLHRO3TESTOINIZIALE>"), 21) : RichTextBoxRO3.Paste()
                    Else
                        RichTextBoxRO3.Rtf = RichTextBoxRO3.Rtf.Replace("<PLHRO3TESTOINIZIALE>", "")
                    End If
                    If RichTextBoxRO3TestoFinale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRO3TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO3.Select(RichTextBoxRO3.Text.IndexOf("<PLHRO3TESTOFINALE>"), 19) : RichTextBoxRO3.Paste()
                    Else
                        RichTextBoxRO3.Rtf = RichTextBoxRO3.Rtf.Replace("<PLHRO3TESTOFINALE>", "")
                    End If
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    Clipboard.SetText(RichTextBoxRO3.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO3CORPO>"), 13) : RichTextBoxRelazione.Paste()
                    'GC.Collect()

                    'RO4
                    Composizione = ""
                    RichTextBoxRO4.Text = "<PLHRO4TESTOINIZIALE>" & vbCrLf & "<PLHRO4CORPO>" & vbCrLf & "<PLHRO4TESTOFINALE>"
                    For i = 0 To DataGridViewRO4.Rows.Count - 1
                        Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO4.Rows(i).Cells(1).Value & "\i0\par\pard"
                        NumeroFigura = NumeroFigura + 1
                        If DataGridViewRO4.Rows(i).Cells(2).Value.trim <> "" Then
                            Composizione = Composizione & "\pard\qj\b " & DataGridViewRO4.Rows(i).Cells(2).Value & "\b0\par"
                        End If
                        If (DataGridViewRO4.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                        End If
                    Next
                    RichTextBoxRO4.Rtf = RichTextBoxRO4.Rtf.Replace("<PLHRO4CORPO>", Composizione)
                    For i = 0 To DataGridViewRO4.Rows.Count - 1
                        PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                        PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                        Clipboard.SetImage(DataGridViewRO4.Rows(i).Cells(0).Value) : RichTextBoxRO4.Select(RichTextBoxRO4.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRO4.Paste()
                        If (DataGridViewRO4.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Clipboard.SetText(DataGridViewRO4.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRO4.Select(RichTextBoxRO4.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRO4.Paste()
                        Else
                            RichTextBoxRO4.Rtf = RichTextBoxRO4.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                        End If
                    Next
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    If RichTextBoxRO4TestoIniziale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRO4TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO4.Select(RichTextBoxRO4.Text.IndexOf("<PLHRO4TESTOINIZIALE>"), 21) : RichTextBoxRO4.Paste()
                    Else
                        RichTextBoxRO4.Rtf = RichTextBoxRO4.Rtf.Replace("<PLHRO4TESTOINIZIALE>", "")
                    End If
                    If RichTextBoxRO4TestoFinale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRO4TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO4.Select(RichTextBoxRO4.Text.IndexOf("<PLHRO4TESTOFINALE>"), 19) : RichTextBoxRO4.Paste()
                    Else
                        RichTextBoxRO4.Rtf = RichTextBoxRO4.Rtf.Replace("<PLHRO4TESTOFINALE>", "")
                    End If
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    Clipboard.SetText(RichTextBoxRO4.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO4CORPO>"), 13) : RichTextBoxRelazione.Paste()
                    'GC.Collect()

                    'RO5
                    Composizione = ""
                    RichTextBoxRO5.Text = "<PLHRO5TESTOINIZIALE>" & vbCrLf & "<PLHRO5CORPO>" & vbCrLf & "<PLHRO5TESTOFINALE>"
                    For i = 0 To DataGridViewRO5.Rows.Count - 1
                        Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRO5.Rows(i).Cells(1).Value & "\i0\par\pard"
                        NumeroFigura = NumeroFigura + 1
                        If DataGridViewRO5.Rows(i).Cells(2).Value.trim <> "" Then
                            Composizione = Composizione & "\pard\qj\b " & DataGridViewRO5.Rows(i).Cells(2).Value & "\b0\par"
                        End If
                        If (DataGridViewRO5.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                        End If
                    Next
                    RichTextBoxRO5.Rtf = RichTextBoxRO5.Rtf.Replace("<PLHRO5CORPO>", Composizione)
                    For i = 0 To DataGridViewRO5.Rows.Count - 1
                        PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                        PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                        Clipboard.SetImage(DataGridViewRO5.Rows(i).Cells(0).Value) : RichTextBoxRO5.Select(RichTextBoxRO5.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRO5.Paste()
                        If (DataGridViewRO5.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Clipboard.SetText(DataGridViewRO5.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRO5.Select(RichTextBoxRO5.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRO5.Paste()
                        Else
                            RichTextBoxRO5.Rtf = RichTextBoxRO5.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                        End If
                    Next
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    If RichTextBoxRO5TestoIniziale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRO5TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO5.Select(RichTextBoxRO5.Text.IndexOf("<PLHRO5TESTOINIZIALE>"), 21) : RichTextBoxRO5.Paste()
                    Else
                        RichTextBoxRO5.Rtf = RichTextBoxRO5.Rtf.Replace("<PLHRO5TESTOINIZIALE>", "")
                    End If
                    If RichTextBoxRO5TestoFinale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRO5TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRO5.Select(RichTextBoxRO5.Text.IndexOf("<PLHRO5TESTOFINALE>"), 19) : RichTextBoxRO5.Paste()
                    Else
                        RichTextBoxRO5.Rtf = RichTextBoxRO5.Rtf.Replace("<PLHRO5TESTOFINALE>", "")
                    End If
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    Clipboard.SetText(RichTextBoxRO5.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRO5CORPO>"), 13) : RichTextBoxRelazione.Paste()
                    'GC.Collect()

                    'RU1
                    Composizione = ""
                    RichTextBoxRU1.Text = "<PLHRU1TESTOINIZIALE>" & vbCrLf & "<PLHRU1CORPO>" & vbCrLf & "<PLHRU1TESTOFINALE>"
                    For i = 0 To DataGridViewRU1.Rows.Count - 1
                        Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRU1.Rows(i).Cells(1).Value & "\i0\par\pard"
                        NumeroFigura = NumeroFigura + 1
                        If DataGridViewRU1.Rows(i).Cells(2).Value.trim <> "" Then
                            Composizione = Composizione & "\pard\qj\b " & DataGridViewRU1.Rows(i).Cells(2).Value & "\b0\par"
                        End If
                        If (DataGridViewRU1.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                        End If
                    Next
                    RichTextBoxRU1.Rtf = RichTextBoxRU1.Rtf.Replace("<PLHRU1CORPO>", Composizione)
                    For i = 0 To DataGridViewRU1.Rows.Count - 1
                        PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                        PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                        Clipboard.SetImage(DataGridViewRU1.Rows(i).Cells(0).Value) : RichTextBoxRU1.Select(RichTextBoxRU1.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRU1.Paste()
                        If (DataGridViewRU1.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Clipboard.SetText(DataGridViewRU1.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRU1.Select(RichTextBoxRU1.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRU1.Paste()
                        Else
                            RichTextBoxRU1.Rtf = RichTextBoxRU1.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                        End If
                    Next
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    If RichTextBoxRU1TestoIniziale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRU1TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRU1.Select(RichTextBoxRU1.Text.IndexOf("<PLHRU1TESTOINIZIALE>"), 21) : RichTextBoxRU1.Paste()
                    Else
                        RichTextBoxRU1.Rtf = RichTextBoxRU1.Rtf.Replace("<PLHRU1TESTOINIZIALE>", "")
                    End If
                    If RichTextBoxRU1TestoFinale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRU1TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRU1.Select(RichTextBoxRU1.Text.IndexOf("<PLHRU1TESTOFINALE>"), 19) : RichTextBoxRU1.Paste()
                    Else
                        RichTextBoxRU1.Rtf = RichTextBoxRU1.Rtf.Replace("<PLHRU1TESTOFINALE>", "")
                    End If
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    Clipboard.SetText(RichTextBoxRU1.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU1CORPO>"), 13) : RichTextBoxRelazione.Paste()
                    If CheckBoxRU1.Checked Then
                        Composizione = "\f3\u9746?\f0  Il bene soddisfa il requisito ulteriore RU1\line\f3\u9744?\f0  Il bene NON soddisfa il requisito ulteriore RU1"
                    Else
                        Composizione = "\f3\u9744?\f0  Il bene soddisfa il requisito ulteriore RU1\line\f3\u9746?\f0  Il bene NON soddisfa il requisito ulteriore RU1"
                    End If
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU1VERIFICAREQUISITO>", Composizione)
                    'GC.Collect()

                    'RU2
                    Composizione = ""
                    RichTextBoxRU2.Text = "<PLHRU2TESTOINIZIALE>" & vbCrLf & "<PLHRU2CORPO>" & vbCrLf & "<PLHRU2TESTOFINALE>"
                    For i = 0 To DataGridViewRU2.Rows.Count - 1
                        Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRU2.Rows(i).Cells(1).Value & "\i0\par\pard"
                        NumeroFigura = NumeroFigura + 1
                        If DataGridViewRU2.Rows(i).Cells(2).Value.trim <> "" Then
                            Composizione = Composizione & "\pard\qj\b " & DataGridViewRU2.Rows(i).Cells(2).Value & "\b0\par"
                        End If
                        If (DataGridViewRU2.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                        End If
                    Next
                    RichTextBoxRU2.Rtf = RichTextBoxRU2.Rtf.Replace("<PLHRU2CORPO>", Composizione)
                    For i = 0 To DataGridViewRU2.Rows.Count - 1
                        PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                        PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                        Clipboard.SetImage(DataGridViewRU2.Rows(i).Cells(0).Value) : RichTextBoxRU2.Select(RichTextBoxRU2.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRU2.Paste()
                        If (DataGridViewRU2.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Clipboard.SetText(DataGridViewRU2.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRU2.Select(RichTextBoxRU2.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRU2.Paste()
                        Else
                            RichTextBoxRU2.Rtf = RichTextBoxRU2.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                        End If
                    Next
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    If RichTextBoxRU2TestoIniziale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRU2TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRU2.Select(RichTextBoxRU2.Text.IndexOf("<PLHRU2TESTOINIZIALE>"), 21) : RichTextBoxRU2.Paste()
                    Else
                        RichTextBoxRU2.Rtf = RichTextBoxRU2.Rtf.Replace("<PLHRU2TESTOINIZIALE>", "")
                    End If
                    If RichTextBoxRU2TestoFinale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRU2TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRU2.Select(RichTextBoxRU2.Text.IndexOf("<PLHRU2TESTOFINALE>"), 19) : RichTextBoxRU2.Paste()
                    Else
                        RichTextBoxRU2.Rtf = RichTextBoxRU2.Rtf.Replace("<PLHRU2TESTOFINALE>", "")
                    End If
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    Clipboard.SetText(RichTextBoxRU2.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU2CORPO>"), 13) : RichTextBoxRelazione.Paste()
                    If CheckBoxRU2.Checked Then
                        Composizione = "\f3\u9746?\f0  Il bene soddisfa il requisito ulteriore RU2\line\f3\u9744?\f0  Il bene NON soddisfa il requisito ulteriore RU2"
                    Else
                        Composizione = "\f3\u9744?\f0  Il bene soddisfa il requisito ulteriore RU2\line\f3\u9746?\f0  Il bene NON soddisfa il requisito ulteriore RU2"
                    End If
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU2VERIFICAREQUISITO>", Composizione)
                    'GC.Collect()

                    'RU3
                    Composizione = ""
                    RichTextBoxRU3.Text = "<PLHRU3TESTOINIZIALE>" & vbCrLf & "<PLHRU3CORPO>" & vbCrLf & "<PLHRU3TESTOFINALE>"
                    For i = 0 To DataGridViewRU3.Rows.Count - 1
                        Composizione = Composizione & "\pard\qc<PLHITEMIMMAGINE" & i & ">\par\pard\qc\i Figura " & NumeroFigura & ": " & DataGridViewRU3.Rows(i).Cells(1).Value & "\i0\par\pard"
                        NumeroFigura = NumeroFigura + 1
                        If DataGridViewRU3.Rows(i).Cells(2).Value.trim <> "" Then
                            Composizione = Composizione & "\pard\qj\b " & DataGridViewRU3.Rows(i).Cells(2).Value & "\b0\par"
                        End If
                        If (DataGridViewRU3.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Composizione = Composizione & "\pard <PLHITEMTESTO" & i & ">\par"
                        End If
                    Next
                    RichTextBoxRU3.Rtf = RichTextBoxRU3.Rtf.Replace("<PLHRU3CORPO>", Composizione)
                    For i = 0 To DataGridViewRU3.Rows.Count - 1
                        PlaceHolderImmagine = "<PLHITEMIMMAGINE" & i & ">"
                        PlaceHolderTesto = "<PLHITEMTESTO" & i & ">"
                        Clipboard.SetImage(DataGridViewRU3.Rows(i).Cells(0).Value) : RichTextBoxRU3.Select(RichTextBoxRU3.Text.IndexOf(PlaceHolderImmagine), PlaceHolderImmagine.Length()) : RichTextBoxRU3.Paste()
                        If (DataGridViewRU3.Rows(i).Cells(3).Value & "").trim <> "" Then
                            Clipboard.SetText(DataGridViewRU3.Rows(i).Cells(4).Value, TextDataFormat.Rtf) : RichTextBoxRU3.Select(RichTextBoxRU3.Text.IndexOf(PlaceHolderTesto), PlaceHolderTesto.Length()) : RichTextBoxRU3.Paste()
                        Else
                            RichTextBoxRU3.Rtf = RichTextBoxRU3.Rtf.Replace(PlaceHolderTesto, "\pard\qj\b *** \b0\par")
                        End If
                    Next
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    If RichTextBoxRU3TestoIniziale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRU3TestoIniziale.Rtf, TextDataFormat.Rtf) : RichTextBoxRU3.Select(RichTextBoxRU3.Text.IndexOf("<PLHRU3TESTOINIZIALE>"), 21) : RichTextBoxRU3.Paste()
                    Else
                        RichTextBoxRU3.Rtf = RichTextBoxRU3.Rtf.Replace("<PLHRU3TESTOINIZIALE>", "")
                    End If
                    If RichTextBoxRU3TestoFinale.Text.Trim() <> "" Then
                        Clipboard.SetText(RichTextBoxRU3TestoFinale.Rtf, TextDataFormat.Rtf) : RichTextBoxRU3.Select(RichTextBoxRU3.Text.IndexOf("<PLHRU3TESTOFINALE>"), 19) : RichTextBoxRU3.Paste()
                    Else
                        RichTextBoxRU3.Rtf = RichTextBoxRU3.Rtf.Replace("<PLHRU3TESTOFINALE>", "")
                    End If
                    'System.Threading.Thread.Sleep(2000)
                    Application.DoEvents()
                    Clipboard.SetText(RichTextBoxRU3.Rtf, TextDataFormat.Rtf) : RichTextBoxRelazione.Select(RichTextBoxRelazione.Text.IndexOf("<PLHRU3CORPO>"), 13) : RichTextBoxRelazione.Paste()
                    If CheckBoxRU3.Checked Then
                        Composizione = "\f3\u9746?\f0  Il bene soddisfa il requisito ulteriore RU3\line\f3\u9744?\f0  Il bene NON soddisfa il requisito ulteriore RU3"
                    Else
                        Composizione = "\f3\u9744?\f0  Il bene soddisfa il requisito ulteriore RU3\line\f3\u9746?\f0  Il bene NON soddisfa il requisito ulteriore RU3"
                    End If
                    RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHRU3VERIFICAREQUISITO>", Composizione)
                    Application.DoEvents()
                    'GC.Collect()
                End If 'fine della sezione saltata per i gruppi 2 e 3

                'Checklist 1
                Composizione = ""
                For i = 0 To ComboBoxCategoria.Items.Count - 1
                    If i = ComboBoxCategoria.SelectedIndex Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ComboBoxCategoria.Items(i).replace(". ", ".\tab ") & "\par"
                Next

                If ComboBoxGruppo.SelectedIndex = 0 Then
                    'Checklist 2 (statica)
                    Composizione = Composizione & "\par\pard\keep\keepn\widctlpar\s3\fi-709\li709\sb400\sa400\tx709\cf4\fs22 2.6.2.\tab Check List 2 \endash  Beni allegato A \endash  Requisiti obbligatori (par. 11.1 Circ. AE 4/E)\par\pard\widctlpar\fi-992\li992\sa40\cf0\fs18"
                    Composizione = Composizione & "\u9746? .\tab controllo per mezzo di CNC (Computer Numerical Control) e/o PLC (Programmable Logic Controller);\par"
                    Composizione = Composizione & "\u9746? .\tab interconnessione ai sistemi informatici di fabbrica con caricamento da remoto di istruzioni e/o part program;\par"
                    Composizione = Composizione & "\u9746? .\tab integrazione automatizzata con il sistema logistico della fabbrica o con la rete di fornitura e/o con altre macchine del ciclo produttivo;\par"
                    Composizione = Composizione & "\u9746? .\tab interfaccia tra uomo e macchina semplici e intuitive;\par"
                    Composizione = Composizione & "\u9746? .\tab rispondenza ai più recenti parametri di sicurezza, salute e igiene del lavoro.\par"

                    'Checklist 3 
                    Composizione = Composizione & "\par\pard\keep\keepn\widctlpar\s3\fi-709\li709\sb400\sa400\tx709\cf4\fs22 2.6.3.\tab Check List 3 \endash  Beni allegato A \endash  Requisiti Ulteriori (par. 11.2 Circ. AE 4/E)\par\pard\widctlpar\fi-992\li992\sa40\cf0\fs18"
                    If CheckBoxRU1.Checked Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ".\tab sistemi di telemanutenzione e/o telediagnosi e/o controllo in remoto;\par"
                    If CheckBoxRU2.Checked Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ".\tab monitoraggio continuo delle condizioni di lavoro e dei parametri di processo mediante opportuni set di sensori e adattività alle derive di processo;\par"
                    If CheckBoxRU3.Checked Then
                        Composizione = Composizione & "\u9746? "
                    Else
                        Composizione = Composizione & "\u9744? "
                    End If
                    Composizione = Composizione & ".\tab caratteristiche di integrazione tra macchina fisica e/o impianto con la modellizzazione e/o la simulazione del proprio comportamento nello svolgimento del processo (sistema cyberfisico).\par"
                End If
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHCHECKLIST>", Composizione)

                Composizione = ""
                For Each File As String In My.Computer.FileSystem.GetFiles(TextboxCartella.Text, FileIO.SearchOption.SearchAllSubDirectories, "Allegat*.pdf")
                    Dim Informazioni As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(File)
                    Composizione = Composizione & Informazioni.Name() & "\par "
                Next
                RichTextBoxRelazione.Rtf = RichTextBoxRelazione.Rtf.Replace("<PLHALLEGATI>", Composizione)
                Application.DoEvents()
                MsgBox("Relazione pronta")
            Catch
                MsgBox("Errore nella creazione della relazione," & vbCrLf & "controllare che siano presenti gli elementi base per poterla creare")
            End Try
        Else
            MsgBox("File modello non trovato")
        End If
    End Sub


    Private Sub ButtonSalvaPerizia_Click(sender As Object, e As EventArgs) Handles ButtonSalvaPerizia.Click
        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            Dim DirTemp As String = System.IO.Path.GetTempPath()
            If My.Computer.FileSystem.FileExists(DirTemp & "\PeriziaCompositoreVisuale.rtf") Then
                If MsgBox("Sovrascrivere il file ""PeriziaCompositoreVisuale.rtf"" esistente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Try
                RichTextBoxPerizia.SaveFile(DirTemp & "\PeriziaCompositoreVisuale.rtf", RichTextBoxStreamType.RichText)
                'MsgBox("File salvato: PeriziaCompositoreVisuale.rtf")
            Catch ex As Exception
                MsgBox("Impossibile salvare ""PeriziaCompositoreVisuale.rtf"" verificare che il file non sia aperto da un'altra applicazione")
            End Try

            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & "\Perizia.docx") Then
                If MsgBox("Sovrascrivere il file ""Perizia.docx"" esistente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Try
                Dim _App As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
                Dim _Doc As Microsoft.Office.Interop.Word.Document = _App.Documents.Open(DirTemp & "\PeriziaCompositoreVisuale.rtf")

                Dim _DocxFileName As Object = TextboxCartella.Text & "\Perizia.docx"
                Dim FileFormat As Object = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLDocument

                _Doc.SaveAs2(_DocxFileName, FileFormat)
                _Doc.Close()
                My.Computer.FileSystem.DeleteFile(DirTemp & "\PeriziaCompositoreVisuale.rtf")
            Catch ex As Exception
                MsgBox("Errore nella conversione di ""PeriziaCompositoreVisuale.rtf"" in ""Perizia.docx""")
            End Try
            MsgBox("File ""Perizia.docx"" salvato")
        Else
            MsgBox("File non salvato perché la cartella di destinazione è inesistente")
        End If
    End Sub


    Private Sub ButtonSalvaRelazione_Click(sender As Object, e As EventArgs) Handles ButtonSalvaRelazione.Click
        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            Dim DirTemp As String = System.IO.Path.GetTempPath()
            If My.Computer.FileSystem.FileExists(DirTemp & "\RelazioneCompositoreVisuale.rtf") Then
                If MsgBox("Sovrascrivere il file ""RelazioneCompositoreVisuale.rtf"" esistente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Try
                RichTextBoxRelazione.SaveFile(DirTemp & "\RelazioneCompositoreVisuale.rtf", RichTextBoxStreamType.RichText)
                'MsgBox("File salvato: RelazioneCompositoreVisuale.rtf")
            Catch ex As Exception
                MsgBox("Impossibile salvare ""RelazioneCompositoreVisuale.rtf"" verificare che il file non sia aperto da un'altra applicazione")
            End Try

            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & "\Relazione.docx") Then
                If MsgBox("Sovrascrivere il file ""Relazione.docx"" esistente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Try
                Dim _App As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
                Dim _Doc As Microsoft.Office.Interop.Word.Document = _App.Documents.Open(DirTemp & "\RelazioneCompositoreVisuale.rtf")

                Dim _DocxFileName As Object = TextboxCartella.Text & "\Relazione.docx"
                Dim FileFormat As Object = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatXMLDocument

                _Doc.SaveAs2(_DocxFileName, FileFormat)
                _Doc.Close()
                My.Computer.FileSystem.DeleteFile(DirTemp & "\RelazioneCompositoreVisuale.rtf")
            Catch ex As Exception
                MsgBox("Errore nella conversione di ""RelazioneCompositoreVisuale.rtf"" in ""Relazione.docx""")
            End Try
            MsgBox("File ""Relazione.docx"" salvato")
        Else
            MsgBox("File non salvato perché la cartella di destinazione è inesistente")
        End If
    End Sub


    'TRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASHTRASH
    Private Sub RendiTestoBold()
        If RichTextBoxScreenshot.SelectionFont.Bold Then
            RichTextBoxScreenshot.SelectionFont = New Font(RichTextBoxScreenshot.SelectionFont.FontFamily, RichTextBoxScreenshot.SelectionFont.Size)
        Else
            RichTextBoxScreenshot.SelectionFont = New Font(RichTextBoxScreenshot.SelectionFont.FontFamily, RichTextBoxScreenshot.SelectionFont.Size, FontStyle.Bold)
        End If
    End Sub

    Private Function CaricaImmagine(fileImmagine As String) As Image
        Dim myStream As IO.FileStream
        Dim ImmagineTemporanea As Image
        Try
            myStream = IO.File.Open(fileImmagine, IO.FileMode.Open, IO.FileAccess.Read)
            ImmagineTemporanea = Image.FromStream(myStream)
            myStream.Close()
            myStream.Dispose()
        Catch
            MsgBox("Errore Stream lettura immagine")
            ImmagineTemporanea = Nothing
        End Try
        Return ImmagineTemporanea
    End Function

    Private Sub CaricaLavoro()
        Dim CartellaSalvataggioDati As String = TextboxCartella.Text & "\Compositore visuale"
        Dim DataOraUltimoSalvataggio As String 'in realtà è un'informazione inutile
        Dim FileSalvataggioDati As String = TextboxCartella.Text & "\Compositore visuale\Compositore visuale.txt"
        If My.Computer.FileSystem.FileExists(FileSalvataggioDati) Then
            Dim FlussoLavoro As New IO.StreamReader(FileSalvataggioDati)
            Dim Riga As String
            Dim RigaContenuto As String = "" : Dim Contenuto As String = "" ' variabili usate dai controlli multiline e RTF
            Dim IndiceItem As Integer = 0
            Riga = FlussoLavoro.ReadLine
            If Riga <> "Compositore visuale" Then
                MsgBox("Il lavoro salvato non è conforme allo standard, lettura interrotta")
            Else
                DataOraUltimoSalvataggio = FlussoLavoro.ReadLine 'in realtà non usata
                DataGridViewGenerale.Rows.Clear() 'svuoto le tabelle perché altrimenti perdo il controllo

                While Not FlussoLavoro.EndOfStream
                    Riga = FlussoLavoro.ReadLine
                    Select Case Riga
                        Case "<PLHNOMEAZIENDA>" : TextBoxNomeAzienda.Text = FlussoLavoro.ReadLine
                        Case "<PLHINDIRIZZOSEDE>" : TextBoxIndirizzoAzienda.Text = FlussoLavoro.ReadLine
                        Case "<PLHCFPIVA>" : TextBoxCF_PIVA.Text = FlussoLavoro.ReadLine
                        Case "<PLHTIPORELAZIONEINDEX>" : ComboBoxTipoRelazione.SelectedIndex = Val(FlussoLavoro.ReadLine)
                        Case "<PLHTIPOLOGIA>" : TextBoxTipoInvestimento.Text = FlussoLavoro.ReadLine
                        Case "<PLHPRODUTTORE>" : TextBoxProduttore.Text = FlussoLavoro.ReadLine
                        Case "<PLHMODELLO>" : TextBoxModello.Text = FlussoLavoro.ReadLine
                        Case "<PLHMATRICOLA>" : TextBoxMatricola.Text = FlussoLavoro.ReadLine
                        Case "<PLHANNOPRODUZIONE>" : TextBoxAnno.Text = FlussoLavoro.ReadLine
                        Case "<PLHDOTAZIONI>" : TextBoxDotazioni.Text = FlussoLavoro.ReadLine
                        Case "<PLHPERITO>" : ComboBoxPerito.SelectedIndex = Val(FlussoLavoro.ReadLine)
                        Case "<PLHDATA>" : TextBoxDataPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHPROTOCOLLO>" : TextBoxProtocolloPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHENTEASSEVERAZIONE>" : TextBoxNotaio.Text = FlussoLavoro.ReadLine
                        Case "<PLHGRUPPOINDEX>" : ComboBoxGruppo.SelectedIndex = Val(FlussoLavoro.ReadLine)
                        Case "<PLHCATEGORIAINDEX>" : ComboBoxCategoria.SelectedIndex = Val(FlussoLavoro.ReadLine)
                        Case "<PLHALTREINFO>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHALTREINFO>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            TextBoxAltreInfoCategoria.Text = Contenuto
                        Case "<PLHCOSTO>" : TextBoxCostoTotale.Text = FlussoLavoro.ReadLine
                        Case "<PLHFORNITORE>" : TextBoxFornitore.Text = FlussoLavoro.ReadLine
                        Case "<PLHLEASING>"
                            RigaContenuto = FlussoLavoro.ReadLine
                            If RigaContenuto = "True" Then
                                CheckBoxLeasing.Checked = True
                            Else
                                CheckBoxLeasing.Checked = False
                            End If

                        Case "<PLHDETTAGLIOCOSTO>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHDETTAGLIOCOSTO>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxValoreCespite.Rtf = Contenuto
                        'carico le immagini se presenti
                        Case "<PLHFILELOGOAZIENDA>" : FileLogoAzienda = FlussoLavoro.ReadLine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & FileLogoAzienda) Then
                                PictureBoxLogoAzienda.Image = Image.FromFile(TextboxCartella.Text & FileLogoAzienda) 'carico l'immagine
                                PictureBoxLogoAzienda.SizeMode = PictureBoxSizeMode.Zoom
                            End If
                        Case "<PLHFILEFOTOCOPERTINA>" : FileFotoCopertina = FlussoLavoro.ReadLine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & FileFotoCopertina) Then
                                PictureBoxFotoCopertina.Image = Image.FromFile(TextboxCartella.Text & FileFotoCopertina) 'carico l'immagine
                                PictureBoxFotoCopertina.SizeMode = PictureBoxSizeMode.Zoom
                            End If
                        'case della schermata Dettaglio
                        Case "<PLHDETTAGLIOTESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHDETTAGLIOTESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxGeneraleTestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMDETTAGLIO>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewGenerale.Rows.Count()
                            DataGridViewGenerale.Rows.Add()
                            DataGridViewGenerale.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewGenerale.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewGenerale.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewGenerale.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewGenerale.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewGenerale.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewGenerale.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMDETTAGLIO>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxGeneraleDescrizione.Rtf = Contenuto
                                DataGridViewGenerale.Rows(IndiceItem).Cells(3).Value = RichTextBoxGeneraleDescrizione.Text 'mi procuro il testo semplice
                                DataGridViewGenerale.Rows(IndiceItem).Cells(4).Value = RichTextBoxGeneraleDescrizione.Rtf 'ho letto il testo RTF
                            End If
                            'qui devo leggere l'immagine se esiste
                            'If My.Computer.FileSystem.FileExists(CartellaSalvataggioImmagini & "\FotoDettaglio" & IndiceItem & ".jpg") Then
                            ''DataGridViewGenerale.Rows(IndiceItem).Cells(0).Value = CaricaImmagine(CartellaSalvataggioDati & "\FotoDettaglio" & IndiceItem & ".jpg")
                            'DataGridViewGenerale.Rows(IndiceItem).Cells(0).Value = Image.FromFile(CartellaSalvataggioImmagini & "\FotoDettaglio" & IndiceItem & ".jpg")
                            'End If
                        Case "<PLHDETTAGLIOTESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHDETTAGLIOTESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxGeneraleTestoFinale.Rtf = Contenuto
                        'case della schermata RO1
                        Case "<PLHRO1DETTAGLIOPERIZIA>" : TextBoxRO1DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRO1TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO1TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO1TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRO1>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRO1.Rows.Count()
                            DataGridViewRO1.Rows.Add()
                            DataGridViewRO1.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRO1.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRO1.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRO1.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRO1.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRO1.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRO1.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRO1>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRO1Descrizione.Rtf = Contenuto
                                DataGridViewRO1.Rows(IndiceItem).Cells(3).Value = RichTextBoxRO1Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRO1.Rows(IndiceItem).Cells(4).Value = RichTextBoxRO1Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRO1TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO1TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO1TestoFinale.Rtf = Contenuto
                        'case della schermata RO2
                        Case "<PLHRO2DETTAGLIOPERIZIA>" : TextBoxRO2DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRO2TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO2TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO2TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRO2>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRO2.Rows.Count()
                            DataGridViewRO2.Rows.Add()
                            DataGridViewRO2.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRO2.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRO2.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRO2.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRO2.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRO2.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRO2.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRO2>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRO2Descrizione.Rtf = Contenuto
                                DataGridViewRO2.Rows(IndiceItem).Cells(3).Value = RichTextBoxRO2Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRO2.Rows(IndiceItem).Cells(4).Value = RichTextBoxRO2Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRO2TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO2TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO2TestoFinale.Rtf = Contenuto
                        'case della schermata RO3
                        Case "<PLHRO3DETTAGLIOPERIZIA>" : TextBoxRO3DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRO3TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO3TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO3TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRO3>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRO3.Rows.Count()
                            DataGridViewRO3.Rows.Add()
                            DataGridViewRO3.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRO3.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRO3.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRO3.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRO3.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRO3.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRO3.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRO3>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRO3Descrizione.Rtf = Contenuto
                                DataGridViewRO3.Rows(IndiceItem).Cells(3).Value = RichTextBoxRO3Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRO3.Rows(IndiceItem).Cells(4).Value = RichTextBoxRO3Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRO3TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO3TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO3TestoFinale.Rtf = Contenuto
                        'case della schermata RO4
                        Case "<PLHRO4DETTAGLIOPERIZIA>" : TextBoxRO4DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRO4TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO4TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO4TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRO4>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRO4.Rows.Count()
                            DataGridViewRO4.Rows.Add()
                            DataGridViewRO4.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRO4.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRO4.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRO4.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRO4.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRO4.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRO4.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRO4>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRO4Descrizione.Rtf = Contenuto
                                DataGridViewRO4.Rows(IndiceItem).Cells(3).Value = RichTextBoxRO4Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRO4.Rows(IndiceItem).Cells(4).Value = RichTextBoxRO4Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRO4TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO4TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO4TestoFinale.Rtf = Contenuto
                        'case della schermata RO5
                        Case "<PLHRO5DETTAGLIOPERIZIA>" : TextBoxRO5DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRO5TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO5TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO5TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRO5>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRO5.Rows.Count()
                            DataGridViewRO5.Rows.Add()
                            DataGridViewRO5.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRO5.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRO5.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRO5.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRO5.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRO5.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRO5.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRO5>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRO5Descrizione.Rtf = Contenuto
                                DataGridViewRO5.Rows(IndiceItem).Cells(3).Value = RichTextBoxRO5Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRO5.Rows(IndiceItem).Cells(4).Value = RichTextBoxRO5Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRO5TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRO5TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRO5TestoFinale.Rtf = Contenuto
                        'case della schermata RU1
                        Case "<PLHRU1DETTAGLIOPERIZIA>" : TextBoxRU1DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRU1VERIFICAREQUISITO>"
                            RigaContenuto = FlussoLavoro.ReadLine
                            If RigaContenuto = "True" Then
                                CheckBoxRU1.Checked = True
                            Else
                                CheckBoxRU1.Checked = False
                            End If
                        Case "<PLHRU1TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRU1TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRU1TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRU1>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRU1.Rows.Count()
                            DataGridViewRU1.Rows.Add()
                            DataGridViewRU1.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRU1.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRU1.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRU1.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRU1.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRU1.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRU1.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRU1>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRU1Descrizione.Rtf = Contenuto
                                DataGridViewRU1.Rows(IndiceItem).Cells(3).Value = RichTextBoxRU1Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRU1.Rows(IndiceItem).Cells(4).Value = RichTextBoxRU1Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRU1TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRU1TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRU1TestoFinale.Rtf = Contenuto
                        'case della schermata RU2
                        Case "<PLHRU2DETTAGLIOPERIZIA>" : TextBoxRU2DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRU2VERIFICAREQUISITO>"
                            RigaContenuto = FlussoLavoro.ReadLine
                            If RigaContenuto = "True" Then
                                CheckBoxRU2.Checked = True
                            Else
                                CheckBoxRU2.Checked = False
                            End If
                        Case "<PLHRU2TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRU2TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRU2TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRU2>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRU2.Rows.Count()
                            DataGridViewRU2.Rows.Add()
                            DataGridViewRU2.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRU2.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRU2.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRU2.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRU2.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRU2.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRU2.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRU2>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRU2Descrizione.Rtf = Contenuto
                                DataGridViewRU2.Rows(IndiceItem).Cells(3).Value = RichTextBoxRU2Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRU2.Rows(IndiceItem).Cells(4).Value = RichTextBoxRU2Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRU2TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRU2TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRU2TestoFinale.Rtf = Contenuto
                        'case della schermata RU3
                        Case "<PLHRU3DETTAGLIOPERIZIA>" : TextBoxRU3DettaglioPerizia.Text = FlussoLavoro.ReadLine
                        Case "<PLHRU3VERIFICAREQUISITO>"
                            RigaContenuto = FlussoLavoro.ReadLine
                            If RigaContenuto = "True" Then
                                CheckBoxRU3.Checked = True
                            Else
                                CheckBoxRU3.Checked = False
                            End If
                        Case "<PLHRU3TESTOINIZIALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRU3TESTOINIZIALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRU3TestoIniziale.Rtf = Contenuto
                        Case "<PLHITEMRU3>" : RigaContenuto = "" : Contenuto = "" : IndiceItem = DataGridViewRU3.Rows.Count()
                            DataGridViewRU3.Rows.Add()
                            DataGridViewRU3.Rows(IndiceItem).Cells(1).Value = FlussoLavoro.ReadLine 'leggo la didascalia
                            DataGridViewRU3.Rows(IndiceItem).Cells(2).Value = FlussoLavoro.ReadLine 'leggo il titolo
                            DataGridViewRU3.Rows(IndiceItem).Cells(5).Value = FlussoLavoro.ReadLine 'leggo il nome del file immagine
                            If My.Computer.FileSystem.FileExists(TextboxCartella.Text & DataGridViewRU3.Rows(IndiceItem).Cells(5).Value) Then
                                DataGridViewRU3.Rows(IndiceItem).Cells(0).Value = Image.FromFile(TextboxCartella.Text & DataGridViewRU3.Rows(IndiceItem).Cells(5).Value) 'carico l'immagine
                            Else
                                DataGridViewRU3.Rows(IndiceItem).Cells(0).Value = ImmaginePlaceholder 'carico gli ingranaggi
                            End If
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHITEMRU3>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            If Contenuto <> vbCrLf Then
                                RichTextBoxRU3Descrizione.Rtf = Contenuto
                                DataGridViewRU3.Rows(IndiceItem).Cells(3).Value = RichTextBoxRU3Descrizione.Text 'mi procuro il testo semplice
                                DataGridViewRU3.Rows(IndiceItem).Cells(4).Value = RichTextBoxRU3Descrizione.Rtf 'ho letto il testo RTF
                            End If
                        Case "<PLHRU3TESTOFINALE>" : RigaContenuto = "" : Contenuto = ""
                            RigaContenuto = FlussoLavoro.ReadLine
                            While RigaContenuto <> "</PLHRU3TESTOFINALE>"
                                Contenuto = Contenuto & RigaContenuto & vbCrLf
                                RigaContenuto = FlussoLavoro.ReadLine
                            End While
                            RichTextBoxRU3TestoFinale.Rtf = Contenuto
                    End Select

                End While
                'carico i dati nei form delle pagine seguenti
                If DataGridViewGenerale.Rows.Count > 0 Then RigaSelezionataGenerale = 0 : CaricaDatiGenerale()
                'If DataGridViewGenerale.Rows.Count > -1 Then RigaSelezionataGenerale = DataGridViewGenerale.Rows.Count - 1 : CaricaDatiGenerale() 'se invece voglio che punti all'ultimo
                If DataGridViewRO1.Rows.Count > 0 Then RigaSelezionataRO1 = 0 : CaricaDatiRO1()
                If DataGridViewRO2.Rows.Count > 0 Then RigaSelezionataRO2 = 0 : CaricaDatiRO2()
                If DataGridViewRO3.Rows.Count > 0 Then RigaSelezionataRO3 = 0 : CaricaDatiRO3()
                If DataGridViewRO4.Rows.Count > 0 Then RigaSelezionataRO4 = 0 : CaricaDatiRO4()
                If DataGridViewRO5.Rows.Count > 0 Then RigaSelezionataRO5 = 0 : CaricaDatiRO5()
                If DataGridViewRU1.Rows.Count > 0 Then RigaSelezionataRU1 = 0 : CaricaDatiRU1()
                If DataGridViewRU2.Rows.Count > 0 Then RigaSelezionataRU2 = 0 : CaricaDatiRU2()
                If DataGridViewRU3.Rows.Count > 0 Then RigaSelezionataRU3 = 0 : CaricaDatiRU3()
            End If
            FlussoLavoro.Close()
        End If
    End Sub

    Private Function SalvaImmagine(Img As Image, FilePathAndName As String) As Image
        Img.Save(FilePathAndName, Imaging.ImageFormat.Jpeg)
        'Img.Dispose()
        Img = Image.FromFile(FilePathAndName)
        Return Img
    End Function

    Private Sub SalvaLavoro()
        'Dim DataOra As Date = Now()
        Dim CartellaSalvataggio As String = TextboxCartella.Text & "\Compositore visuale"
        'Dim CartellaImmagini As String = CartellaSalvataggio & "\" & Format(DataOra, "HHmmss")
        If Not My.Computer.FileSystem.DirectoryExists(CartellaSalvataggio) Then
            'My.Computer.FileSystem.CreateDirectory(CartellaSalvataggio)
            'End If
            'If Not My.Computer.FileSystem.DirectoryExists(CartellaImmagini) Then
            'My.Computer.FileSystem.CreateDirectory(CartellaImmagini)
            'Else
            'MsgBox("Salvataggio interrotto perché già effettuato, eventualmente riprovare tra qualche secondo")
            MsgBox("Selezionare una cartella di lavoro per poter effettuare il salvataggio")
            Exit Sub
        End If
        Dim FileSalvataggioDati As String = CartellaSalvataggio & "\Compositore visuale.txt"
        Dim FlussoLavoro As New IO.StreamWriter(FileSalvataggioDati)
        FlussoLavoro.WriteLine("Compositore visuale")
        FlussoLavoro.WriteLine(Format(Now(), "yyyy-MM-dd-HHmmss")) 'indico l'ora del salvataggio, in passato serviva per trovare la cartella immagini, ora non serve a nulla
        'Schermata Generale
        If TextBoxNomeAzienda.Text <> "" Then FlussoLavoro.WriteLine("<PLHNOMEAZIENDA>") : FlussoLavoro.WriteLine(TextBoxNomeAzienda.Text)
        If TextBoxIndirizzoAzienda.Text <> "" Then FlussoLavoro.WriteLine("<PLHINDIRIZZOSEDE>") : FlussoLavoro.WriteLine(TextBoxIndirizzoAzienda.Text)
        If TextBoxCF_PIVA.Text <> "" Then FlussoLavoro.WriteLine("<PLHCFPIVA>") : FlussoLavoro.WriteLine(TextBoxCF_PIVA.Text)
        FlussoLavoro.WriteLine("<PLHTIPORELAZIONEINDEX>") : FlussoLavoro.WriteLine(ComboBoxTipoRelazione.SelectedIndex)
        If TextBoxTipoInvestimento.Text <> "" Then FlussoLavoro.WriteLine("<PLHTIPOLOGIA>") : FlussoLavoro.WriteLine(TextBoxTipoInvestimento.Text)
        If TextBoxProduttore.Text <> "" Then FlussoLavoro.WriteLine("<PLHPRODUTTORE>") : FlussoLavoro.WriteLine(TextBoxProduttore.Text)
        If TextBoxModello.Text <> "" Then FlussoLavoro.WriteLine("<PLHMODELLO>") : FlussoLavoro.WriteLine(TextBoxModello.Text)
        If TextBoxMatricola.Text <> "" Then FlussoLavoro.WriteLine("<PLHMATRICOLA>") : FlussoLavoro.WriteLine(TextBoxMatricola.Text)
        If TextBoxAnno.Text <> "" Then FlussoLavoro.WriteLine("<PLHANNOPRODUZIONE>") : FlussoLavoro.WriteLine(TextBoxAnno.Text)
        If TextBoxDotazioni.Text <> "" Then FlussoLavoro.WriteLine("<PLHDOTAZIONI>") : FlussoLavoro.WriteLine(TextBoxDotazioni.Text)
        FlussoLavoro.WriteLine("<PLHPERITO>") : FlussoLavoro.WriteLine(ComboBoxPerito.SelectedIndex)
        If TextBoxDataPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHDATA>") : FlussoLavoro.WriteLine(TextBoxDataPerizia.Text)
        If TextBoxProtocolloPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHPROTOCOLLO>") : FlussoLavoro.WriteLine(TextBoxProtocolloPerizia.Text)
        If TextBoxNotaio.Text <> "" Then FlussoLavoro.WriteLine("<PLHENTEASSEVERAZIONE>") : FlussoLavoro.WriteLine(TextBoxNotaio.Text)
        FlussoLavoro.WriteLine("<PLHGRUPPOINDEX>") : FlussoLavoro.WriteLine(ComboBoxGruppo.SelectedIndex)
        FlussoLavoro.WriteLine("<PLHCATEGORIAINDEX>") : FlussoLavoro.WriteLine(ComboBoxCategoria.SelectedIndex)
        If TextBoxAltreInfoCategoria.Text <> "" Then FlussoLavoro.WriteLine("<PLHALTREINFO>") : FlussoLavoro.WriteLine(TextBoxAltreInfoCategoria.Text) : FlussoLavoro.WriteLine("</PLHALTREINFO>") 'è l'unico textbox multiline, quindi lo gestisco come un RTF
        If TextBoxCostoTotale.Text <> "" Then FlussoLavoro.WriteLine("<PLHCOSTO>") : FlussoLavoro.WriteLine(TextBoxCostoTotale.Text)
        If TextBoxFornitore.Text <> "" Then FlussoLavoro.WriteLine("<PLHFORNITORE>") : FlussoLavoro.WriteLine(TextBoxFornitore.Text)
        FlussoLavoro.WriteLine("<PLHLEASING>") : If CheckBoxLeasing.Checked Then FlussoLavoro.WriteLine("True") Else FlussoLavoro.WriteLine("False")
        If RichTextBoxValoreCespite.Text <> "" Then FlussoLavoro.WriteLine("<PLHDETTAGLIOCOSTO>") : FlussoLavoro.WriteLine(RichTextBoxValoreCespite.Rtf) : FlussoLavoro.WriteLine("</PLHDETTAGLIOCOSTO>")
        'Immagini di Generale
        If Not (PictureBoxLogoAzienda.Image Is Nothing) Then FlussoLavoro.WriteLine("<PLHFILELOGOAZIENDA>") : FlussoLavoro.WriteLine(FileLogoAzienda)
        'PictureBoxLogoAzienda.Image = SalvaImmagine(PictureBoxLogoAzienda.Image, CartellaImmagini & "\LogoAzienda.jpg")
        'End If
        If Not (PictureBoxFotoCopertina.Image Is Nothing) Then FlussoLavoro.WriteLine("<PLHFILEFOTOCOPERTINA>") : FlussoLavoro.WriteLine(FileFotoCopertina)
        'PictureBoxFotoCopertina.Image = SalvaImmagine(PictureBoxFotoCopertina.Image, CartellaImmagini & "\FotoCopertina.jpg")
        'End If

        'Schermata Dettaglio
        If RichTextBoxGeneraleTestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHDETTAGLIOTESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxGeneraleTestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHDETTAGLIOTESTOINIZIALE>")
        For i = 0 To DataGridViewGenerale.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMDETTAGLIO>")
            FlussoLavoro.WriteLine(DataGridViewGenerale.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewGenerale.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewGenerale.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewGenerale.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMDETTAGLIO>")
            'PictureBoxGenerale.Image = DataGridViewGenerale.Rows(i).Cells(0).Value
            'If Not (PictureBoxGenerale.Image Is Nothing) Then
            'Try
            'PictureBoxGenerale.Image = SalvaImmagine(PictureBoxGenerale.Image, CartellaImmagini & "/FotoDettaglio" & i & ".jpg")
            'Catch e As Exception
            'MsgBox(e.Message)
            'End Try
            'End If
        Next
        'If DataGridViewGenerale.Rows.Count > 0 Then PictureBoxGenerale.Image = DataGridViewGenerale.Rows(RigaSelezionataGenerale).Cells(0).Value
        If RichTextBoxGeneraleTestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHDETTAGLIOTESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxGeneraleTestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHDETTAGLIOTESTOFINALE>")

        'Schermata RO1
        If TextBoxRO1DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO1DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRO1DettaglioPerizia.Text)
        If RichTextBoxRO1TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO1TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRO1TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRO1TESTOINIZIALE>")
        For i = 0 To DataGridViewRO1.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRO1>")
            FlussoLavoro.WriteLine(DataGridViewRO1.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRO1.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRO1.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRO1.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRO1>")
        Next
        If RichTextBoxRO1TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO1TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRO1TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRO1TESTOFINALE>")

        'Schermata RO2
        If TextBoxRO2DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO2DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRO2DettaglioPerizia.Text)
        If RichTextBoxRO2TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO2TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRO2TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRO2TESTOINIZIALE>")
        For i = 0 To DataGridViewRO2.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRO2>")
            FlussoLavoro.WriteLine(DataGridViewRO2.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRO2.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRO2.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRO2.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRO2>")
        Next
        If RichTextBoxRO2TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO2TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRO2TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRO2TESTOFINALE>")

        'Schermata RO3
        If TextBoxRO3DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO3DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRO3DettaglioPerizia.Text)
        If RichTextBoxRO3TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO3TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRO3TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRO3TESTOINIZIALE>")
        For i = 0 To DataGridViewRO3.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRO3>")
            FlussoLavoro.WriteLine(DataGridViewRO3.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRO3.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRO3.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRO3.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRO3>")
        Next
        'If DataGridViewRO3.Rows.Count > 0 Then PictureBoxRO3.Image = DataGridViewRO3.Rows(RigaSelezionataRO3).Cells(0).Value
        If RichTextBoxRO3TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO3TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRO3TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRO3TESTOFINALE>")

        'Schermata RO4
        If TextBoxRO4DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO4DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRO4DettaglioPerizia.Text)
        If RichTextBoxRO4TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO4TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRO4TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRO4TESTOINIZIALE>")
        For i = 0 To DataGridViewRO4.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRO4>")
            FlussoLavoro.WriteLine(DataGridViewRO4.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRO4.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRO4.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRO4.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRO4>")
        Next
        If RichTextBoxRO4TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO4TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRO4TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRO4TESTOFINALE>")

        'Schermata RO5
        If TextBoxRO5DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO5DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRO5DettaglioPerizia.Text)
        If RichTextBoxRO5TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO5TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRO5TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRO5TESTOINIZIALE>")
        For i = 0 To DataGridViewRO5.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRO5>")
            FlussoLavoro.WriteLine(DataGridViewRO5.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRO5.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRO5.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRO5.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRO5>")
        Next
        If RichTextBoxRO5TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRO5TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRO5TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRO5TESTOFINALE>")

        'Schermata RU1
        If TextBoxRU1DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU1DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRU1DettaglioPerizia.Text)
        FlussoLavoro.WriteLine("<PLHRU1VERIFICAREQUISITO>") : If CheckBoxRU1.Checked Then FlussoLavoro.WriteLine("True") Else FlussoLavoro.WriteLine("False")
        If RichTextBoxRU1TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU1TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRU1TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRU1TESTOINIZIALE>")
        For i = 0 To DataGridViewRU1.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRU1>")
            FlussoLavoro.WriteLine(DataGridViewRU1.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRU1.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRU1.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRU1.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRU1>")
        Next
        If RichTextBoxRU1TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU1TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRU1TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRU1TESTOFINALE>")

        'Schermata RU2
        If TextBoxRU2DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU2DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRU2DettaglioPerizia.Text)
        FlussoLavoro.WriteLine("<PLHRU2VERIFICAREQUISITO>") : If CheckBoxRU2.Checked Then FlussoLavoro.WriteLine("True") Else FlussoLavoro.WriteLine("False")
        If RichTextBoxRU2TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU2TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRU2TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRU2TESTOINIZIALE>")
        For i = 0 To DataGridViewRU2.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRU2>")
            FlussoLavoro.WriteLine(DataGridViewRU2.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRU2.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRU2.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRU2.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRU2>")
        Next
        If RichTextBoxRU2TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU2TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRU2TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRU2TESTOFINALE>")

        'Schermata RU3
        If TextBoxRU3DettaglioPerizia.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU3DETTAGLIOPERIZIA>") : FlussoLavoro.WriteLine(TextBoxRU3DettaglioPerizia.Text)
        FlussoLavoro.WriteLine("<PLHRU3VERIFICAREQUISITO>") : If CheckBoxRU3.Checked Then FlussoLavoro.WriteLine("True") Else FlussoLavoro.WriteLine("False")
        If RichTextBoxRU3TestoIniziale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU3TESTOINIZIALE>") : FlussoLavoro.WriteLine(RichTextBoxRU3TestoIniziale.Rtf) : FlussoLavoro.WriteLine("</PLHRU3TESTOINIZIALE>")
        For i = 0 To DataGridViewRU3.Rows.Count - 1
            FlussoLavoro.WriteLine("<PLHITEMRU3>")
            FlussoLavoro.WriteLine(DataGridViewRU3.Rows(i).Cells(1).Value) 'scrivo la didascalia
            FlussoLavoro.WriteLine(DataGridViewRU3.Rows(i).Cells(2).Value) 'scrivo il titolo
            FlussoLavoro.WriteLine(DataGridViewRU3.Rows(i).Cells(5).Value) 'scrivo il nome del file immagine
            FlussoLavoro.WriteLine(DataGridViewRU3.Rows(i).Cells(4).Value) 'scrivo testo (RTF)
            FlussoLavoro.WriteLine("</PLHITEMRU3>")
        Next
        If RichTextBoxRU3TestoFinale.Text <> "" Then FlussoLavoro.WriteLine("<PLHRU3TESTOFINALE>") : FlussoLavoro.WriteLine(RichTextBoxRU3TestoFinale.Rtf) : FlussoLavoro.WriteLine("</PLHRU3TESTOFINALE>")

        FlussoLavoro.Close()
        FlussoLavoro.Dispose()
    End Sub

    Private Sub ButtonSalva_Click(sender As Object, e As EventArgs) Handles ButtonSalva.Click
        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text & "\Compositore visuale") Then
                If MsgBox("Sovrascrivere il file lavoro salvato?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Try
                SalvaLavoro()
            Catch ex As Exception
                MsgBox("Impossibile salvare il lavoro del compositore visuale, verificare che alcuni file non siano aperti da altre applicazioni")
            End Try
        Else
            MsgBox("File non salvato perché la cartella di lavoro è inesistente")
        End If
    End Sub

    'Funzioni di attivazione e scomparsa guide interattive per tutte le sezioni
    Private Sub LabelDettaglio_MouseEnter(sender As Object, e As EventArgs) Handles LabelDettaglio.MouseEnter
        TextBoxGuidaDettaglio.Visible = True
    End Sub
    Private Sub LabelRO1_MouseEnter(sender As Object, e As EventArgs) Handles LabelRO1.MouseEnter
        TextBoxGuidaRO1.Visible = True
    End Sub
    Private Sub LabelRO2_MouseEnter(sender As Object, e As EventArgs) Handles LabelRO2.MouseEnter
        TextBoxGuidaRO2.Visible = True
    End Sub
    Private Sub LabelRO3_MouseEnter(sender As Object, e As EventArgs) Handles LabelRO3.MouseEnter
        TextBoxGuidaRO3.Visible = True
    End Sub
    Private Sub LabelRO4_MouseEnter(sender As Object, e As EventArgs) Handles LabelRO4.MouseEnter
        TextBoxGuidaRO4.Visible = True
    End Sub
    Private Sub LabelRO5_MouseEnter(sender As Object, e As EventArgs) Handles LabelRO5.MouseEnter
        TextBoxGuidaRO5.Visible = True
    End Sub
    Private Sub LabelRU1_MouseEnter(sender As Object, e As EventArgs) Handles LabelRU1.MouseEnter
        TextBoxGuidaRU1.Visible = True
    End Sub
    Private Sub LabelRU2_MouseEnter(sender As Object, e As EventArgs) Handles LabelRU2.MouseEnter
        TextBoxGuidaRU2.Visible = True
    End Sub
    Private Sub LabelRU3_MouseEnter(sender As Object, e As EventArgs) Handles LabelRU3.MouseEnter
        TextBoxGuidaRU3.Visible = True
    End Sub
    Private Sub LabelDettaglio_MouseLeave(sender As Object, e As EventArgs) Handles LabelDettaglio.MouseLeave
        TextBoxGuidaDettaglio.Visible = False
    End Sub
    Private Sub LabelRO1_MouseLeave(sender As Object, e As EventArgs) Handles LabelRO1.MouseLeave
        TextBoxGuidaRO1.Visible = False
    End Sub
    Private Sub LabelRO2_MouseLeave(sender As Object, e As EventArgs) Handles LabelRO2.MouseLeave
        TextBoxGuidaRO2.Visible = False
    End Sub
    Private Sub LabelRO3_MouseLeave(sender As Object, e As EventArgs) Handles LabelRO3.MouseLeave
        TextBoxGuidaRO3.Visible = False
    End Sub
    Private Sub LabelRO4_MouseLeave(sender As Object, e As EventArgs) Handles LabelRO4.MouseLeave
        TextBoxGuidaRO4.Visible = False
    End Sub
    Private Sub LabelRO5_MouseLeave(sender As Object, e As EventArgs) Handles LabelRO5.MouseLeave
        TextBoxGuidaRO5.Visible = False
    End Sub
    Private Sub LabelRU1_MouseLeave(sender As Object, e As EventArgs) Handles LabelRU1.MouseLeave
        TextBoxGuidaRU1.Visible = False
    End Sub
    Private Sub LabelRU2_MouseLeave(sender As Object, e As EventArgs) Handles LabelRU2.MouseLeave
        TextBoxGuidaRU2.Visible = False
    End Sub
    Private Sub LabelRU3_MouseLeave(sender As Object, e As EventArgs) Handles LabelRU3.MouseLeave
        TextBoxGuidaRU3.Visible = False
    End Sub

    Private Sub TimerSalvataggioAutomatico_Tick(sender As Object, e As EventArgs) Handles TimerSalvataggioAutomatico.Tick
        If My.Computer.FileSystem.DirectoryExists(TextboxCartella.Text) Then
            Try
                SalvaLavoro()
            Catch ex As Exception
                MsgBox("Impossibile salvare il lavoro del compositore visuale, verificare che alcuni file non siano aperti da altre applicazioni")
            End Try
        End If
    End Sub

    Private Sub CheckBoxSalvataggioAutomatico_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSalvataggioAutomatico.CheckedChanged
        If CheckBoxSalvataggioAutomatico.Checked = True Then
            TimerSalvataggioAutomatico.Enabled = True
        Else
            TimerSalvataggioAutomatico.Enabled = False
        End If
    End Sub

    Private Sub ButtonApriPreset_Click(sender As Object, e As EventArgs) Handles ButtonApriPreset.Click
        Dim FormPreset As Form2 = New Form2
        FormPreset.Show(Me)
    End Sub

    Private Sub ComboBoxTipoRelazione_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTipoRelazione.SelectedIndexChanged
        If ComboBoxTipoRelazione.SelectedIndex = 2 Then
            TextBoxNotaio.Enabled = True
        Else
            TextBoxNotaio.Enabled = False
        End If
    End Sub


End Class
