Public Class Frm_Intro

    ' Timer para controlar o tempo de exibição do FormIntro
    Private WithEvents Tmr_Intro As New Timer()

    ' Quando o formulário for carregado, inicializa o timer
    Private Sub FormIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Inicializar banco de dados
        Call InicializarBancoDeDados()

        ' Configura o intervalo do timer (5 segundos = 5000 milissegundos)
        Tmr_Intro.Interval = 3000 ' 5 segundos
        Tmr_Intro.Start() ' Inicia o timer

    End Sub

    ' Evento do timer que ocorre a cada intervalo
    Private Sub Tmr_Intro_Tick(sender As Object, e As EventArgs) Handles Tmr_Intro.Tick

        ' Para o timer para evitar múltiplos ticks
        Tmr_Intro.Stop()

        ' Abre o FormPrincipal e fecha o FormIntro
        Dim frm_Principal As New Frm_Principal()
        frm_Principal.Show()

        Me.Close()

    End Sub

End Class
