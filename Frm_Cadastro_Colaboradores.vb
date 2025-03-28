Imports DP_Fácil.Tabela
Imports DP_Fácil.Md_Variaveis

Public Class Frm_Cadastro_Colaboradores

    '******************************************************************************************************************
    ' Variáveis de Manipulação

    Private ColaboradorAtual As Colaborador
    Private ModoAtual As ModoFormulario

    '******************************************************************************************************************
    ' Controles do Formulário

    Private Sub Frm_Cadastro_Colaboradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    '******************************************************************************************************************
    ' Controles dos Botões

    Private Sub Bttn_InserirEndereco_Click(sender As Object, e As EventArgs) Handles Bttn_InserirEndereco.Click

    End Sub

    Private Sub Bttn_Cancelar_Click(sender As Object, e As EventArgs) Handles Bttn_Cancelar.Click

    End Sub

    Private Sub Bttn_Excluir_Click(sender As Object, e As EventArgs) Handles Bttn_Excluir.Click

    End Sub

    Private Sub Bttn_Limpar_Click(sender As Object, e As EventArgs) Handles Bttn_Limpar.Click

    End Sub

    Private Sub Bttn_Executar_Click(sender As Object, e As EventArgs) Handles Bttn_Executar.Click

    End Sub

    '******************************************************************************************************************
    ' Funções e rotinas Auxiliares

    Public Sub DefinirModoFormulario(Modo As ModoFormulario)

        Select Case Modo

            Case ModoFormulario.Adicionar


            Case ModoFormulario.Editar


            Case ModoFormulario.Excluir


            Case ModoFormulario.Visualizar


        End Select

    End Sub

    Private Sub ConfigurarBotoes()

    End Sub

    Private Sub ConfigurarStatusCampos(Status As Boolean)

    End Sub

    Private Sub InicializarFormulario()

    End Sub

    Private Sub FinalizarFormulario()

    End Sub

    Private Function CamposPreenchidos() As Boolean

        Return True

    End Function

    Private Sub LimparCampos()

    End Sub

    Private Sub Executar()

    End Sub

    Private Sub RecuperarDados()

    End Sub

    Private Sub RegistrarDados()

    End Sub

End Class