Namespace Tabela

    Public Class Endereco
        Public Property IdEndereco As Integer
        Public Property Logradouro As String
        Public Property Numero As String
        Public Property Bairro As String
        Public Property Cidade As String
        Public Property Estado As String
        Public Property SiglaEstado As String
    End Class

    Public Class Clinica
        Public Property IdClinica As Integer
        Public Property Local As String
        Public Property NomeClinica As String
        Public Property IdEndereco As Integer
        Public Property Email As String
        Public Property Atendente As String
        Public Property Status As String
    End Class

    Public Class UnidadeSenac
        Public Property IdUnidade As Integer
        Public Property Local As String
        Public Property NomeUnidade As String
        Public Property IdEndereco As Integer
        Public Property Email As String
        Public Property Atendente As String
        Public Property Status As String
    End Class

    Public Class AgenciaCaixa
        Public Property IdAgencia As Integer
        Public Property Local As String
        Public Property NomeAgencia As String
        Public Property NumeroAgencia As String
        Public Property IdEndereco As Integer
        Public Property Email As String
        Public Property Atendente As String
        Public Property Status As String
    End Class

    Public Class TipoContrato
        Public Property IdTipoContrato As Integer
        Public Property NomeTipoContrato As String
        Public Property Status As String
    End Class

    Public Class Colaborador
        Public Property IdColaborador As Integer
        Public Property Chapa As String
        Public Property NomeCompleto As String
        Public Property Rg As String
        Public Property Cpf As String
        Public Property EmailPessoal As String
        Public Property EmailCorporativo As String
        Public Property IdTipoContrato As Integer
        Public Property Funcao As String
        Public Property Setor As String
        Public Property DataNascimento As Date
        Public Property Sexo As String
        Public Property DataAdmissao As Date
        Public Property TelefonePessoal As String
        Public Property IdEndereco As Integer
        Public Property Status As String
    End Class

    Public Class ExameMedico
        Public Property IdExame As Integer
        Public Property TipoExame As String
        Public Property IdColaborador As Integer
        Public Property DataAgendamento As Date
        Public Property HorarioAgendamento As String
        Public Property IdClinica As Integer
        Public Property DataValidade As Date
        Public Property Status As String
    End Class

    Public Class DocumentoAdmissional
        Public Property IdDocumento As Integer
        Public Property NomeDocumento As String
        Public Property MensalistaInstrutorFormacao As Integer
        Public Property MensalistaAdministrativo As Integer
        Public Property MensalistaPrazoDeterminado As Integer
        Public Property TipoContratoHorista As Integer
        Public Property HoristaInstrutorFormacao As Integer
        Public Property HoristaIntermitente As Integer
        Public Property Status As String
    End Class


End Namespace
