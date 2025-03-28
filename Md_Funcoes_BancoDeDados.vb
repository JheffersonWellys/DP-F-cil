Imports System.Data.SQLite
Imports DP_Fácil.Tabela

Module Md_Funcoes_BancoDeDados

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar endereços

    Public Function AdicionarEndereco(endereco As Endereco) As Boolean
        Try
            Dim query As String = "INSERT INTO Enderecos (Logradouro, Numero, Bairro, Cidade, Estado, SiglaEstado) 
                           VALUES (@Logradouro, @Numero, @Bairro, @Cidade, @Estado, @SiglaEstado)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Logradouro", endereco.Logradouro),
            New SQLiteParameter("@Numero", endereco.Numero),
            New SQLiteParameter("@Bairro", endereco.Bairro),
            New SQLiteParameter("@Cidade", endereco.Cidade),
            New SQLiteParameter("@Estado", endereco.Estado),
            New SQLiteParameter("@SiglaEstado", endereco.SiglaEstado)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar registro de endereço: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AtualizarEndereco(endereco As Endereco) As Boolean
        Try
            Dim query As String = "UPDATE Enderecos 
                           SET Logradouro = @Logradouro, Numero = @Numero, Bairro = @Bairro, 
                               Cidade = @Cidade, Estado = @Estado, SiglaEstado = @SiglaEstado
                           WHERE IdEndereco = @IdEndereco"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Logradouro", endereco.Logradouro),
            New SQLiteParameter("@Numero", endereco.Numero),
            New SQLiteParameter("@Bairro", endereco.Bairro),
            New SQLiteParameter("@Cidade", endereco.Cidade),
            New SQLiteParameter("@Estado", endereco.Estado),
            New SQLiteParameter("@SiglaEstado", endereco.SiglaEstado),
            New SQLiteParameter("@IdEndereco", endereco.IdEndereco)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar registro de endereço: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirEndereco(idEndereco As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Enderecos WHERE IdEndereco = @IdEndereco"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdEndereco", idEndereco)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir registro de endereço: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarEnderecosAtivos() As DataTable
        Try
            Dim query As String = "SELECT * FROM Enderecos WHERE Status = 'Ativo'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar registros de endereços: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar clincias

    Public Function AdicionarClinica(clinica As Clinica) As Boolean
        Try
            Dim query As String = "INSERT INTO Clinicas (Local, NomeClinica, IdEndereco, Email, Atendente, Status) 
                           VALUES (@Local, @NomeClinica, @IdEndereco, @Email, @Atendente, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Local", clinica.Local),
            New SQLiteParameter("@NomeClinica", clinica.NomeClinica),
            New SQLiteParameter("@IdEndereco", clinica.IdEndereco),
            New SQLiteParameter("@Email", clinica.Email),
            New SQLiteParameter("@Atendente", clinica.Atendente),
            New SQLiteParameter("@Status", clinica.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar registro de clínica: " & ex.Message)
            Return False
        End Try
    End Function


    Public Function AtualizarClinica(clinica As Clinica) As Boolean
        Try
            Dim query As String = "UPDATE Clinicas 
                           SET Local = @Local, NomeClinica = @NomeClinica, IdEndereco = @IdEndereco, 
                               Email = @Email, Atendente = @Atendente, Status = @Status
                           WHERE IdClinica = @IdClinica"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Local", clinica.Local),
            New SQLiteParameter("@NomeClinica", clinica.NomeClinica),
            New SQLiteParameter("@IdEndereco", clinica.IdEndereco),
            New SQLiteParameter("@Email", clinica.Email),
            New SQLiteParameter("@Atendente", clinica.Atendente),
            New SQLiteParameter("@Status", clinica.Status),
            New SQLiteParameter("@IdClinica", clinica.IdClinica)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar registro de clínica: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirClinica(idClinica As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Clinicas WHERE IdClinica = @IdClinica"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdClinica", idClinica)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir registro de clínica: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarClinicasAtivas() As DataTable
        Try
            Dim query As String = "SELECT * FROM Clinicas WHERE Status = 'Ativo'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar registros de clínicas: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar unidades

    Public Function AdicionarUnidadeSenac(unidade As UnidadeSenac) As Boolean
        Try
            Dim query As String = "INSERT INTO UnidadesSenac (Local, NomeUnidade, IdEndereco, Email, Atendente, Status) 
                           VALUES (@Local, @NomeUnidade, @IdEndereco, @Email, @Atendente, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Local", unidade.Local),
            New SQLiteParameter("@NomeUnidade", unidade.NomeUnidade),
            New SQLiteParameter("@IdEndereco", unidade.IdEndereco),
            New SQLiteParameter("@Email", unidade.Email),
            New SQLiteParameter("@Atendente", unidade.Atendente),
            New SQLiteParameter("@Status", unidade.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar registro de unidade Senac: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AtualizarUnidadeSenac(unidade As UnidadeSenac) As Boolean
        Try
            Dim query As String = "UPDATE UnidadesSenac 
                           SET Local = @Local, NomeUnidade = @NomeUnidade, IdEndereco = @IdEndereco, 
                               Email = @Email, Atendente = @Atendente, Status = @Status
                           WHERE IdUnidade = @IdUnidade"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Local", unidade.Local),
            New SQLiteParameter("@NomeUnidade", unidade.NomeUnidade),
            New SQLiteParameter("@IdEndereco", unidade.IdEndereco),
            New SQLiteParameter("@Email", unidade.Email),
            New SQLiteParameter("@Atendente", unidade.Atendente),
            New SQLiteParameter("@Status", unidade.Status),
            New SQLiteParameter("@IdUnidade", unidade.IdUnidade)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar registro de unidade Senac: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirUnidadeSenac(idUnidade As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM UnidadesSenac WHERE IdUnidade = @IdUnidade"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdUnidade", idUnidade)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir registro de unidade Senac: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarUnidadesSenacAtivas() As DataTable
        Try
            Dim query As String = "SELECT * FROM UnidadesSenac WHERE Status = 'Ativo'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar registros de unidades: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar agências

    Public Function AdicionarAgenciaCaixa(agencia As AgenciaCaixa) As Boolean
        Try
            Dim query As String = "INSERT INTO AgenciaCaixa (Local, NomeAgencia, NumeroAgencia, IdEndereco, Email, Atendente, Status) 
                           VALUES (@Local, @NomeAgencia, @NumeroAgencia, @IdEndereco, @Email, @Atendente, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Local", agencia.Local),
            New SQLiteParameter("@NomeAgencia", agencia.NomeAgencia),
            New SQLiteParameter("@NumeroAgencia", agencia.NumeroAgencia),
            New SQLiteParameter("@IdEndereco", agencia.IdEndereco),
            New SQLiteParameter("@Email", agencia.Email),
            New SQLiteParameter("@Atendente", agencia.Atendente),
            New SQLiteParameter("@Status", agencia.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar registro de agência caixa: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AtualizarAgenciaCaixa(agencia As AgenciaCaixa) As Boolean
        Try
            Dim query As String = "UPDATE AgenciaCaixa 
                           SET Local = @Local, NomeAgencia = @NomeAgencia, NumeroAgencia = @NumeroAgencia, 
                               IdEndereco = @IdEndereco, Email = @Email, Atendente = @Atendente, Status = @Status
                           WHERE IdAgencia = @IdAgencia"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Local", agencia.Local),
            New SQLiteParameter("@NomeAgencia", agencia.NomeAgencia),
            New SQLiteParameter("@NumeroAgencia", agencia.NumeroAgencia),
            New SQLiteParameter("@IdEndereco", agencia.IdEndereco),
            New SQLiteParameter("@Email", agencia.Email),
            New SQLiteParameter("@Atendente", agencia.Atendente),
            New SQLiteParameter("@Status", agencia.Status),
            New SQLiteParameter("@IdAgencia", agencia.IdAgencia)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar registro de agência caixa: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirAgenciaCaixa(idAgencia As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM AgenciaCaixa WHERE IdAgencia = @IdAgencia"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdAgencia", idAgencia)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir registro de agência caixa: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarAgenciasAtivas() As DataTable
        Try
            Dim query As String = "SELECT * FROM AgenciasCaixa WHERE Status = 'Ativo'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar registros de agências: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar tipos de contratos
    Public Function AdicionarTipoContrato(tipo As TipoContrato) As Boolean
        Try
            Dim query As String = "INSERT INTO TipoContrato (NomeTipoContrato, Status) 
                           VALUES (@NomeTipoContrato, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@NomeTipoContrato", tipo.NomeTipoContrato),
            New SQLiteParameter("@Status", tipo.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar tipo de contrato: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AtualizarTipoContrato(tipo As TipoContrato) As Boolean
        Try
            Dim query As String = "UPDATE TipoContrato 
                           SET NomeTipoContrato = @NomeTipoContrato, Status = @Status
                           WHERE IdTipoContrato = @IdTipoContrato"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@NomeTipoContrato", tipo.NomeTipoContrato),
            New SQLiteParameter("@Status", tipo.Status),
            New SQLiteParameter("@IdTipoContrato", tipo.IdTipoContrato)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar tipo de contrato: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirTipoContrato(idTipoContrato As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM TipoContrato WHERE IdTipoContrato = @IdTipoContrato"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdTipoContrato", idTipoContrato)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir tipo de contrato: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarTiposContratosAtivos() As DataTable
        Try
            Dim query As String = "SELECT * FROM TiposContrato WHERE Status = 'Ativo'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar registros de tipos de contrato: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar colaborador

    Public Function AdicionarColaborador(colaborador As Colaborador) As Boolean
        Try
            Dim query As String = "INSERT INTO Colaboradores (Chapa, NomeCompleto, Rg, Cpf, EmailPessoal, EmailCorporativo, IdTipoContrato, Funcao, Setor, DataNascimento, Sexo, DataAdmissao, TelefonePessoal, IdEndereco, Status) 
                           VALUES (@Chapa, @NomeCompleto, @Rg, @Cpf, @EmailPessoal, @EmailCorporativo, @IdTipoContrato, @Funcao, @Setor, @DataNascimento, @Sexo, @DataAdmissao, @TelefonePessoal, @IdEndereco, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Chapa", colaborador.Chapa),
            New SQLiteParameter("@NomeCompleto", colaborador.NomeCompleto),
            New SQLiteParameter("@Rg", colaborador.Rg),
            New SQLiteParameter("@Cpf", colaborador.Cpf),
            New SQLiteParameter("@EmailPessoal", colaborador.EmailPessoal),
            New SQLiteParameter("@EmailCorporativo", colaborador.EmailCorporativo),
            New SQLiteParameter("@IdTipoContrato", colaborador.IdTipoContrato),
            New SQLiteParameter("@Funcao", colaborador.Funcao),
            New SQLiteParameter("@Setor", colaborador.Setor),
            New SQLiteParameter("@DataNascimento", colaborador.DataNascimento),
            New SQLiteParameter("@Sexo", colaborador.Sexo),
            New SQLiteParameter("@DataAdmissao", colaborador.DataAdmissao),
            New SQLiteParameter("@TelefonePessoal", colaborador.TelefonePessoal),
            New SQLiteParameter("@IdEndereco", colaborador.IdEndereco),
            New SQLiteParameter("@Status", colaborador.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar registro de colaborador: " & ex.Message)
            Return False
        End Try
    End Function

    ' Atualizar Colaborador
    Public Function AtualizarColaborador(colaborador As Colaborador) As Boolean
        Try
            Dim query As String = "UPDATE Colaboradores 
                           SET Chapa = @Chapa, NomeCompleto = @NomeCompleto, Rg = @Rg, Cpf = @Cpf, EmailPessoal = @EmailPessoal, 
                               EmailCorporativo = @EmailCorporativo, IdTipoContrato = @IdTipoContrato, Funcao = @Funcao, Setor = @Setor, 
                               DataNascimento = @DataNascimento, Sexo = @Sexo, DataAdmissao = @DataAdmissao, TelefonePessoal = @TelefonePessoal, 
                               IdEndereco = @IdEndereco, Status = @Status
                           WHERE IdColaborador = @IdColaborador"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@Chapa", colaborador.Chapa),
            New SQLiteParameter("@NomeCompleto", colaborador.NomeCompleto),
            New SQLiteParameter("@Rg", colaborador.Rg),
            New SQLiteParameter("@Cpf", colaborador.Cpf),
            New SQLiteParameter("@EmailPessoal", colaborador.EmailPessoal),
            New SQLiteParameter("@EmailCorporativo", colaborador.EmailCorporativo),
            New SQLiteParameter("@IdTipoContrato", colaborador.IdTipoContrato),
            New SQLiteParameter("@Funcao", colaborador.Funcao),
            New SQLiteParameter("@Setor", colaborador.Setor),
            New SQLiteParameter("@DataNascimento", colaborador.DataNascimento),
            New SQLiteParameter("@Sexo", colaborador.Sexo),
            New SQLiteParameter("@DataAdmissao", colaborador.DataAdmissao),
            New SQLiteParameter("@TelefonePessoal", colaborador.TelefonePessoal),
            New SQLiteParameter("@IdEndereco", colaborador.IdEndereco),
            New SQLiteParameter("@Status", colaborador.Status),
            New SQLiteParameter("@IdColaborador", colaborador.IdColaborador)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar registro de colaborador: " & ex.Message)
            Return False
        End Try
    End Function

    ' Excluir Colaborador
    Public Function ExcluirColaborador(idColaborador As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM Colaboradores WHERE IdColaborador = @IdColaborador"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdColaborador", idColaborador)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir registro de colaborador: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarColaboradoresAtivos() As DataTable
        Try
            Dim query As String = "SELECT * FROM Colaboradores WHERE Status = 'Ativo'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar registros de colaboradores: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar exame médico

    Public Function AdicionarExameMedico(exame As ExameMedico) As Boolean
        Try
            Dim query As String = "INSERT INTO ExamesMedicos (TipoExame, IdColaborador, DataAgendamento, HorarioAgendamento, IdClinica, DataValidade, Status) 
                           VALUES (@TipoExame, @IdColaborador, @DataAgendamento, @HorarioAgendamento, @IdClinica, @DataValidade, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@TipoExame", exame.TipoExame),
            New SQLiteParameter("@IdColaborador", exame.IdColaborador),
            New SQLiteParameter("@DataAgendamento", exame.DataAgendamento),
            New SQLiteParameter("@HorarioAgendamento", exame.HorarioAgendamento),
            New SQLiteParameter("@IdClinica", exame.IdClinica),
            New SQLiteParameter("@DataValidade", exame.DataValidade),
            New SQLiteParameter("@Status", exame.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar exame médico: " & ex.Message)
            Return False
        End Try
    End Function

    ' Atualizar Exame Médico
    Public Function AtualizarExameMedico(exame As ExameMedico) As Boolean
        Try
            Dim query As String = "UPDATE ExamesMedicos 
                           SET TipoExame = @TipoExame, IdColaborador = @IdColaborador, DataAgendamento = @DataAgendamento, 
                               HorarioAgendamento = @HorarioAgendamento, IdClinica = @IdClinica, DataValidade = @DataValidade, 
                               Status = @Status
                           WHERE IdExame = @IdExame"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@TipoExame", exame.TipoExame),
            New SQLiteParameter("@IdColaborador", exame.IdColaborador),
            New SQLiteParameter("@DataAgendamento", exame.DataAgendamento),
            New SQLiteParameter("@HorarioAgendamento", exame.HorarioAgendamento),
            New SQLiteParameter("@IdClinica", exame.IdClinica),
            New SQLiteParameter("@DataValidade", exame.DataValidade),
            New SQLiteParameter("@Status", exame.Status),
            New SQLiteParameter("@IdExame", exame.IdExame)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar exame médico: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirExameMedico(idExame As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM ExamesMedicos WHERE IdExame = @IdExame"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdExame", idExame)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir exame médico: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function BuscarExamesAgendados() As DataTable
        Try
            Dim query As String = "SELECT * FROM ExamesMedicos WHERE Status = 'Agendado'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar exames agendados: " & ex.Message)
            Return Nothing
        End Try
    End Function

    '******************************************************************************************************************
    ' Funções para adicionar, editar, excluir ou listar documentos admissionais

    Public Function AdicionarDocumentoAdmissional(documento As DocumentoAdmissional) As Boolean
        Try
            Dim query As String = "INSERT INTO DocumentosAdmissionais (NomeDocumento, MensalistaInstrutorFormacao, MensalistaAdministrativo, MensalistaPrazoDeterminado, TipoContratoHorista, 
                           HoristaInstrutorFormacao, HoristaIntermitente, Status) 
                           VALUES (@NomeDocumento, @MensalistaInstrutorFormacao, @MensalistaAdministrativo, @MensalistaPrazoDeterminado, @TipoContratoHorista, 
                           @HoristaInstrutorFormacao, @HoristaIntermitente, @Status)"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@NomeDocumento", documento.NomeDocumento),
            New SQLiteParameter("@MensalistaInstrutorFormacao", documento.MensalistaInstrutorFormacao),
            New SQLiteParameter("@MensalistaAdministrativo", documento.MensalistaAdministrativo),
            New SQLiteParameter("@MensalistaPrazoDeterminado", documento.MensalistaPrazoDeterminado),
            New SQLiteParameter("@TipoContratoHorista", documento.TipoContratoHorista),
            New SQLiteParameter("@HoristaInstrutorFormacao", documento.HoristaInstrutorFormacao),
            New SQLiteParameter("@HoristaIntermitente", documento.HoristaIntermitente),
            New SQLiteParameter("@Status", documento.Status)
        }

            Return InserirRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao adicionar documento admissional: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AtualizarDocumentoAdmissional(documento As DocumentoAdmissional) As Boolean
        Try
            Dim query As String = "UPDATE DocumentosAdmissionais 
                           SET NomeDocumento = @NomeDocumento, MensalistaInstrutorFormacao = @MensalistaInstrutorFormacao, 
                               MensalistaAdministrativo = @MensalistaAdministrativo, MensalistaPrazoDeterminado = @MensalistaPrazoDeterminado, 
                               TipoContratoHorista = @TipoContratoHorista, HoristaInstrutorFormacao = @HoristaInstrutorFormacao, 
                               HoristaIntermitente = @HoristaIntermitente, Status = @Status
                           WHERE IdDocumento = @IdDocumento"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@NomeDocumento", documento.NomeDocumento),
            New SQLiteParameter("@MensalistaInstrutorFormacao", documento.MensalistaInstrutorFormacao),
            New SQLiteParameter("@MensalistaAdministrativo", documento.MensalistaAdministrativo),
            New SQLiteParameter("@MensalistaPrazoDeterminado", documento.MensalistaPrazoDeterminado),
            New SQLiteParameter("@TipoContratoHorista", documento.TipoContratoHorista),
            New SQLiteParameter("@HoristaInstrutorFormacao", documento.HoristaInstrutorFormacao),
            New SQLiteParameter("@HoristaIntermitente", documento.HoristaIntermitente),
            New SQLiteParameter("@Status", documento.Status),
            New SQLiteParameter("@IdDocumento", documento.IdDocumento)
        }

            Return AtualizarRegistro(query, parametros)

        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar documento admissional: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirDocumentoAdmissional(idDocumento As Integer) As Boolean
        Try
            Dim query As String = "DELETE FROM DocumentosAdmissionais WHERE IdDocumento = @IdDocumento"
            Dim parametros As New List(Of SQLiteParameter) From {
            New SQLiteParameter("@IdDocumento", idDocumento)
        }

            Return ExcluirRegistro(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir documento admissional: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function BuscarDocumentosAdmissionais() As DataTable
        Try
            Dim query As String = "SELECT * FROM DocumentosAdmissionais WHERE Status = 'Pendente'"
            Dim parametros As New List(Of SQLiteParameter)()

            Return ConsultarRegistros(query, parametros)
        Catch ex As Exception
            MessageBox.Show("Erro ao pesquisar documentos admissionais: " & ex.Message)
            Return Nothing
        End Try
    End Function

End Module
