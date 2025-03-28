Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports DP_Fácil.Tabela

Module Md_BancoDeDados

    Private caminhoBandoDeDados As String = Application.StartupPath & "\DPFacil.db"

    ' Função para inicializar o banco de dados
    Public Sub InicializarBancoDeDados()
        CriarBancoDados()
        CriarTabelas()
        CriarTriggers()
        CriarVistas()
        CriarIndices()
    End Sub

    ' Função para obter a conexão com o banco de dados SQLite
    Private Function ObterConexaoSQLite() As SQLiteConnection
        Dim conn As New SQLiteConnection("Data Source=" & caminhoBandoDeDados & ";Version=3;")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
        End Try
        Return conn
    End Function

    ' Função para criar o banco de dados
    Private Sub CriarBancoDados()
        Try
            If Not IO.File.Exists(caminhoBandoDeDados) Then
                SQLiteConnection.CreateFile(caminhoBandoDeDados)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao criar o banco de dados: " & ex.Message)
        End Try
    End Sub

    ' Função para criar as tabelas no banco de dados
    Private Sub CriarTabelas()
        Dim query As String = "
            CREATE TABLE IF NOT EXISTS enderecos (
                id_endereco INTEGER PRIMARY KEY,
                logradouro TEXT,
                numero TEXT,
                bairro TEXT,
                cidade TEXT,
                estado TEXT,
                sigla_estado TEXT
            );

            CREATE TABLE IF NOT EXISTS clinicas (
                id_clinica INTEGER PRIMARY KEY,
                local TEXT,
                nome_clinica TEXT,
                id_endereco INTEGER,
                email TEXT,
                atendente TEXT,
                status TEXT,
                FOREIGN KEY(id_endereco) REFERENCES enderecos(id_endereco)
            );

            CREATE TABLE IF NOT EXISTS unidades_senac (
                id_unidade INTEGER PRIMARY KEY,
                local TEXT,
                nome_unidade TEXT,
                id_endereco INTEGER,
                email TEXT,
                atendente TEXT,
                status TEXT,
                FOREIGN KEY(id_endereco) REFERENCES enderecos(id_endereco)
            );

            CREATE TABLE IF NOT EXISTS agencias_caixa (
                id_agencia INTEGER PRIMARY KEY,
                local TEXT,
                nome_agencia TEXT,
                numero_agencia TEXT,
                id_endereco INTEGER,
                email TEXT,
                atendente TEXT,
                status TEXT,
                FOREIGN KEY(id_endereco) REFERENCES enderecos(id_endereco)
            );

            CREATE TABLE IF NOT EXISTS tipo_contrato (
                id_tipo_contrato INTEGER PRIMARY KEY,
                nome_tipo_contrato TEXT,
                status TEXT
            );

            CREATE TABLE IF NOT EXISTS colaboradores (
                id_colaborador INTEGER PRIMARY KEY,
                chapa TEXT,
                nome_completo TEXT,
                rg TEXT,
                cpf TEXT,
                email_pessoal TEXT,
                email_corporativo TEXT,
                id_tipo_contrato INTEGER,
                funcao TEXT,
                setor TEXT,
                data_nascimento DATE,
                sexo TEXT,
                data_admissao DATE,
                telefone_pessoal TEXT,
                id_endereco INTEGER,
                status TEXT,
                FOREIGN KEY(id_tipo_contrato) REFERENCES tipo_contrato(id_tipo_contrato),
                FOREIGN KEY(id_endereco) REFERENCES enderecos(id_endereco)
            );

            CREATE TABLE IF NOT EXISTS exames_medicos (
                id_exame INTEGER PRIMARY KEY,
                tipo_exame TEXT,
                id_colaborador INTEGER,
                data_agendamento DATE,
                horario_agendamento TEXT,
                id_clinica INTEGER,
                data_validade DATE,
                status TEXT,
                FOREIGN KEY(id_colaborador) REFERENCES colaboradores(id_colaborador),
                FOREIGN KEY(id_clinica) REFERENCES clinicas(id_clinica)
            );

            CREATE TABLE IF NOT EXISTS documentos_admissionais (
                id_documento INTEGER PRIMARY KEY,
                nome_documento TEXT,
                Mensalista_InstrutorFormacao INTEGER,
                Mensalista_Administrativo INTEGER,
                Mensalista_PrazoDeterminado INTEGER,
                TipoContrato_Horista INTEGER,
                Horista_InstrutorFormacao INTEGER,
                Horista_Intermitente INTEGER,
                status TEXT
            );
        "

        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao criar as tabelas: " & ex.Message)
        End Try
    End Sub

    ' Função para criar as triggers no banco de dados
    Private Sub CriarTriggers()
        Dim query As String = "
            CREATE TRIGGER IF NOT EXISTS log_status_change
            AFTER UPDATE ON colaboradores
            FOR EACH ROW
            WHEN NEW.status != OLD.status
            BEGIN
                INSERT INTO status_log (id_colaborador, old_status, new_status)
                VALUES (NEW.id_colaborador, OLD.status, NEW.status);
            END;

            CREATE TRIGGER IF NOT EXISTS prevent_delete_endereco
            BEFORE DELETE ON enderecos
            FOR EACH ROW
            BEGIN
                -- Verifica se o endereço está vinculado a alguma outra entidade
                -- Se o endereço estiver vinculado a alguma das entidades, aborta a operação
                SELECT
                    CASE
                        WHEN EXISTS (SELECT 1 FROM clinicas WHERE id_endereco = OLD.id_endereco) OR
                             EXISTS (SELECT 1 FROM unidades_senac WHERE id_endereco = OLD.id_endereco) OR
                             EXISTS (SELECT 1 FROM agencias_caixa WHERE id_endereco = OLD.id_endereco) OR
                             EXISTS (SELECT 1 FROM colaboradores WHERE id_endereco = OLD.id_endereco) THEN
                             RAISE(ABORT, 'Endereço vinculado a outra entidade')
                    END;
            END;
        "

        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                If conn.State <> ConnectionState.Open Then
                    conn.Open()
                End If

                ' Executa cada comando separadamente
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro ao criar as triggers: " & ex.Message)
        End Try
    End Sub

    ' Função para criar as vistas no banco de dados
    Private Sub CriarVistas()
        Dim query As String = "
            CREATE VIEW IF NOT EXISTS vw_exames_colaboradores AS
            SELECT 
                e.id_exame,
                e.tipo_exame,
                e.data_agendamento,
                e.horario_agendamento,
                e.data_validade,
                e.status AS exame_status,
                c.nome_completo AS colaborador_nome,
                c.cpf AS colaborador_cpf,
                cl.nome_clinica AS clinica_nome,
                cl.local AS clinica_local
            FROM exames_medicos e
            JOIN colaboradores c ON e.id_colaborador = c.id_colaborador
            JOIN clinicas cl ON e.id_clinica = cl.id_clinica;

            CREATE VIEW IF NOT EXISTS vw_colaboradores_enderecos AS
            SELECT 
                c.nome_completo AS colaborador_nome,
                c.email_corporativo,
                c.telefone_pessoal,
                e.logradouro,
                e.numero,
                e.bairro,
                e.cidade,
                e.estado
            FROM colaboradores c
            JOIN enderecos e ON c.id_endereco = e.id_endereco;
        "

        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao criar as vistas: " & ex.Message)
        End Try
    End Sub

    ' Função para criar os índices no banco de dados
    Private Sub CriarIndices()
        Dim query As String = "
            CREATE INDEX IF NOT EXISTS idx_endereco_clinicas ON clinicas(id_endereco);
            CREATE INDEX IF NOT EXISTS idx_endereco_unidades_senac ON unidades_senac(id_endereco);
            CREATE INDEX IF NOT EXISTS idx_endereco_agencias_caixa ON agencias_caixa(id_endereco);
            CREATE INDEX IF NOT EXISTS idx_endereco_colaboradores ON colaboradores(id_endereco);
            CREATE UNIQUE INDEX IF NOT EXISTS idx_cpf_colaboradores ON colaboradores(cpf);
            CREATE INDEX IF NOT EXISTS idx_data_agendamento_exames ON exames_medicos(data_agendamento);
        "

        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao criar os índices: " & ex.Message)
        End Try
    End Sub

    ' Funções para inserir, atualizar, excluir e consultar registros no banco de dados
    Public Function InserirRegistro(query As String, parametros As List(Of SQLiteParameter)) As Boolean
        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    If parametros IsNot Nothing Then
                        cmd.Parameters.AddRange(parametros.ToArray())
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro ao inserir registro: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function AtualizarRegistro(query As String, parametros As List(Of SQLiteParameter)) As Boolean
        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    If parametros IsNot Nothing Then
                        cmd.Parameters.AddRange(parametros.ToArray())
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro ao atualizar registro: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ExcluirRegistro(query As String, parametros As List(Of SQLiteParameter)) As Boolean
        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    If parametros IsNot Nothing Then
                        cmd.Parameters.AddRange(parametros.ToArray())
                    End If
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Erro ao excluir registro: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function ConsultarRegistros(query As String, parametros As List(Of SQLiteParameter)) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As SQLiteConnection = ObterConexaoSQLite()
                Using cmd As New SQLiteCommand(query, conn)
                    If parametros IsNot Nothing Then
                        cmd.Parameters.AddRange(parametros.ToArray())
                    End If
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Erro ao consultar registros: " & ex.Message)
            Return Nothing
        End Try
        Return dt
    End Function

End Module
