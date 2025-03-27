Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Module Md_Funcoes

    ' Função para fechar o formulário
    Public Sub FecharFormulario(Frm As Form, Optional DlgRslt As DialogResult = DialogResult.Cancel)
        ' Define o resultado do diálogo e fecha o formulário
        Frm.DialogResult = DlgRslt
        Frm.Close()
    End Sub

    ' Função para mudar o nome do formulário
    Public Sub MudarNomeFormulario(Frm As Form, Texto As String)
        ' Altera o título do formulário, concatenando com o texto fornecido
        Frm.Text = $"{Frm.Text} {Texto}"
    End Sub

    ' Função para verificar se a data selecionada é hoje
    Public Function VerificarDataHoje(Dtp_EmAnalise As DateTimePicker) As Boolean
        Dim resposta As DialogResult
        ' Compara a data selecionada no DateTimePicker com a data de hoje
        If Dtp_EmAnalise.Value.Date = DateTime.Today Then
            ' Se a data for hoje, pergunta ao usuário se ele confirma
            resposta = MessageBox.Show("A data selecionada é para hoje. Você confirma?", "Confirmação de Data", MessageBoxButtons.YesNo)
        End If
        ' Se a data não for hoje, retorna False
        Return resposta = DialogResult.Yes
    End Function

    ' Função para validar o e-mail
    Public Function ValidarEmail(TxtBx_EmAnalise As TextBox) As Boolean
        ' Define a expressão regular para validação do e-mail
        Dim Pttrn As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        ' Cria a instância da expressão regular
        Dim Rgx As New Regex(Pttrn)
        ' Retorna verdadeiro se o e-mail for válido, caso contrário, retorna falso
        Return Rgx.IsMatch(TxtBx_EmAnalise.Text)
    End Function

    ' Função para verificar se o campo de texto está vazio
    Public Function CampoDeTextoVazio(txt As TextBox) As Boolean
        ' Retorna True se o campo de texto não estiver vazio
        Return Not String.IsNullOrWhiteSpace(txt.Text)
    End Function

    ' Função para verificar se o campo de máscara de texto não está completo
    Public Function CampoDeMascaraDeTextoIncompleto(mtxt As MaskedTextBox) As Boolean
        ' Retorna True se o campo com máscara de texto não estiver completo
        Return Not mtxt.MaskFull
    End Function

    ' Função para verificar se o ComboBox não tem item selecionado
    Public Function CampoDeSelecaoNaoSelecionado(cmb As ComboBox) As Boolean
        ' Retorna True se nenhum item foi selecionado no ComboBox
        Return cmb.SelectedIndex = -1
    End Function

    ' Função para abrir um arquivo PDF
    Public Sub AbrirPDF(ByVal caminhoPDF As String)
        Try
            ' Verifica se o arquivo PDF existe no caminho fornecido
            If File.Exists(caminhoPDF) Then
                ' Abre o arquivo PDF utilizando o programa padrão do sistema
                Process.Start(caminhoPDF)
            Else
                ' Exibe uma mensagem de erro caso o arquivo não seja encontrado
                MessageBox.Show("O arquivo PDF não foi encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao abrir o arquivo: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Função para criar uma pasta, se não existir
    Public Sub CriarPastaSeNaoExistir(caminho As String)
        Try
            ' Verifica se o diretório não existe e cria o diretório caso necessário
            If Not Directory.Exists(caminho) Then
                Directory.CreateDirectory(caminho)
            End If
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao criar o diretório: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Função para obter o endereço através do CEP
    Public Function ObterEnderecoPorCEP(cep As String) As JObject
        Try
            ' Define a URL da API ViaCEP para consulta do endereço com base no CEP
            Dim url As String = $"https://viacep.com.br/ws/{cep}/json/"
            ' Cria a requisição HTTP GET
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(url), HttpWebRequest)
            request.Method = "GET"
            ' Obtém a resposta da requisição
            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using reader As New StreamReader(response.GetResponseStream())
                    ' Lê a resposta JSON da API e converte em JObject
                    Dim json As String = reader.ReadToEnd()
                    Return JObject.Parse(json)
                End Using
            End Using
        Catch ex As Exception
            ' Exibe uma mensagem de erro caso ocorra uma exceção
            MessageBox.Show("Erro ao buscar o endereço: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

End Module
