Option Strict On

Public Class ExceptionBase
#Region "Variablen"
    ' Form initialisieren
    Private UserDetails As New UserDetails()

    ' Klassenvariablen für Fehlerdetails setzen
    Private ExceptionMessage As String = ""
    Private ExceptionInner As String = ""
    Private StackTrace As String = ""
    Private ErrorMethod As String = ""
    Private UserDescription As String = ""
    Private Version As String = ""
    Dim AppID As Integer = 0
    Dim NETFramework As String = ""
    Dim InstalledOS As String = ""

    ' Konstanten für 
    Private Const NOTAVAILABLE = "Nicht verfügbar"
    Private Const DESCSKIPPED = "Beschreibung übersprungen"
#End Region

#Region "Eigenschaften"
    Property Server As String = ""
    Property PingIP As String = ""

    ''' <summary>
    ''' Gibt den Titel des Detailfensters zurück oder ändert ihn.
    ''' </summary>
    ''' <value>Der neue Titel des Detailfensters</value>
    ''' <returns>Der Titel des Detailfensters</returns>
    ''' <remarks></remarks>
    Property DetailWinTitle As String
        Get
            Return UserDetails.winTitle
        End Get
        Set(value As String)
            UserDetails.winTitle = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Beschreibung im Detailfenster zurück oder ändert sie.
    ''' </summary>
    ''' <value>Die neue Beschreibung im Detailfenster</value>
    ''' <returns>Die Beschreibung im Detailfenster</returns>
    ''' <remarks></remarks>
    Property DetailWinDescription As String
        Get
            Return UserDetails.winDescription
        End Get
        Set(value As String)
            UserDetails.winDescription = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt den Titel des Eingabefeldes im Detailfenster zurück oder ändert ihn.
    ''' </summary>
    ''' <value>Der neue Titel des Eingabefeldes im Detailfenster</value>
    ''' <returns>Der Titel des Eingabefeldes im Detailfenster</returns>
    ''' <remarks></remarks>
    Property DetailWinInputCaption As String
        Get
            Return UserDetails.winInputCaption
        End Get
        Set(value As String)
            UserDetails.winInputCaption = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt das Programmicon im Detailfenster zurück oder ändert es.
    ''' </summary>
    ''' <value>Das neue Programmicon im Detailfenster</value>
    ''' <returns>Das Programmicon im Detailfenster</returns>
    ''' <remarks></remarks>
    Property ApplicationPicture As Drawing.Image
        Get
            Return UserDetails.pbAppImage.Image
        End Get
        Set(value As Drawing.Image)
            UserDetails.pbAppImage.Image = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Beschriftung des OK-Buttons im Detailfenster zurück oder ändert sie.
    ''' </summary>
    ''' <value>Die neue Beschriftung des OK-Buttons im Detailfenster</value>
    ''' <returns>Die Beschriftung des OK-Buttons im Detailfenster</returns>
    ''' <remarks></remarks>
    Property DetailWinSkipButton As String
        Get
            Return UserDetails.bSkip
        End Get
        Set(value As String)
            UserDetails.bSkip = value
        End Set
    End Property

    ''' <summary>
    ''' Gibt die Beschriftung des Überspringen-Buttons im Detailfenster zurück oder ändert sie.
    ''' </summary>
    ''' <value>Die neue Beschriftung des Überspringen-Buttons im Detailfenster</value>
    ''' <returns>Die Beschriftung des Überspringen-Buttons im Detailfenster</returns>
    ''' <remarks></remarks>
    Property DetailWinSendButton As String
        Get
            Return UserDetails.bSend
        End Get
        Set(value As String)
            UserDetails.bSend = value
        End Set
    End Property
#End Region

#Region "Methoden"
    ''' <summary>
    ''' Erstellt einen neuen Exception-Tracker, der Fehler an die ExceptionBase-Datenbank schicken kann.
    ''' </summary>
    ''' <param name="Server">Die URL zum hinzufügen eines Fehlers zur Datenbank. Siehe Startseite im PHP-Interface</param>
    ''' <param name="AppID">Die ID Ihrer App in der ExceptionBase.NET Datenbank</param>
    ''' <param name="Version">Die Version des Programmes</param>
    ''' <param name="AppIcon">Das Icon der App, wird im Detailfenster angezeigt</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Server As String, ByVal AppID As Integer, ByVal Version As String, ByVal AppIcon As Drawing.Image)
        Me.Version = Version
        Me.ApplicationPicture = AppIcon
    End Sub

    ''' <summary>
    ''' Sendet den gegebenen Fehler an die ExceptionBase.NET Datenbank und fragt, wenn nicht anders
    ''' angegeben, den Nutzer vorher nach Informationen zu dem Fehler.
    ''' </summary>
    ''' <param name="ex">Die Exception, die zur Datenbank gesendet werden soll.</param>
    ''' <param name="AskUser">Soll der Benutzer selbst Informationen zu dem Fehler angeben können?</param>
    ''' <remarks></remarks>
    Public Sub Track(ByVal ex As Exception, Optional ByVal AskUser As Boolean = True)
        Try
            NETFramework = System.Environment.Version.ToString()
            InstalledOS = System.Environment.OSVersion.VersionString

            If Not IsNothing(ex.Message) Then
                ExceptionMessage = ex.Message
            Else
                ExceptionMessage = NOTAVAILABLE
            End If

            If Not IsNothing(ex.InnerException) Then
                ExceptionInner = ex.InnerException.ToString
            Else
                ExceptionInner = NOTAVAILABLE
            End If

            If Not IsNothing(ex.StackTrace) Then
                StackTrace = ex.StackTrace
            Else
                StackTrace = NOTAVAILABLE
            End If

            If Not IsNothing(ex.TargetSite) Then
                ErrorMethod = ex.TargetSite.ToString()
            Else
                ErrorMethod = NOTAVAILABLE
            End If

            If AskUser Then
                If UserDetails.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    UserDescription = UserDetails.TextBox1.Text
                Else
                    UserDescription = DESCSKIPPED
                End If
            Else
                UserDescription = NOTAVAILABLE
            End If

            Dim args As String = "em=" & ExceptionMessage & _
                                 "&ei=" & ExceptionInner & _
                                 "&st=" & StackTrace & _
                                 "&eme=" & ErrorMethod & _
                                 "&udesc=" & UserDescription & _
                                 "&appid=" & AppID & _
                                 "&v=" & Version & _
                                 "&net=" & NETFramework & _
                                 "&os=" & InstalledOS

            If My.Computer.Network.Ping(_PingIP) Then
                Dim result As String = Functions.PostURL(Server, args)
                Debug.Print("[ExceptionBase Info] Sent error report to the database.")
            End If
        Catch

        End Try
    End Sub
#End Region
End Class
