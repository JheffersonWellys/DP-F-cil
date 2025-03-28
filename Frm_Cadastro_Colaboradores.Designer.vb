<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cadastro_Colaboradores
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Cadastro_Colaboradores))
        Me.Pnl_Botoes = New System.Windows.Forms.Panel()
        Me.Pnl_Dados = New System.Windows.Forms.Panel()
        Me.Bttn_Cancelar = New System.Windows.Forms.Button()
        Me.Bttn_Executar = New System.Windows.Forms.Button()
        Me.Bttn_Limpar = New System.Windows.Forms.Button()
        Me.Bttn_Excluir = New System.Windows.Forms.Button()
        Me.GrpBx_InformacoesPessoais = New System.Windows.Forms.GroupBox()
        Me.Lbl_NomeCompleto = New System.Windows.Forms.Label()
        Me.TxtBx_NomeCompleto = New System.Windows.Forms.TextBox()
        Me.TxtBx_EmailPessoal = New System.Windows.Forms.TextBox()
        Me.Lbl_EmailPessoal = New System.Windows.Forms.Label()
        Me.Lbl_Chapa = New System.Windows.Forms.Label()
        Me.MskdTxtBx_Chapa = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_Sexo = New System.Windows.Forms.Label()
        Me.CmbBx_Sexo = New System.Windows.Forms.ComboBox()
        Me.Lbl_RG = New System.Windows.Forms.Label()
        Me.MskdTxtBx_RG = New System.Windows.Forms.MaskedTextBox()
        Me.MskdTxtBx_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_CPF = New System.Windows.Forms.Label()
        Me.MskdTxtBx_TelefonePessoal = New System.Windows.Forms.MaskedTextBox()
        Me.Lbl_TelefonePessoal = New System.Windows.Forms.Label()
        Me.Lbl_DataNascimento = New System.Windows.Forms.Label()
        Me.DtTmPckr_DataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.Pnl_Divisor_1 = New System.Windows.Forms.Panel()
        Me.GrpBx_InformacoesCorporativas = New System.Windows.Forms.GroupBox()
        Me.DtTmPckr_DataAdmissao = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DataAdmissao = New System.Windows.Forms.Label()
        Me.Lbl_TipoContrato = New System.Windows.Forms.Label()
        Me.TxtBx_Funcao = New System.Windows.Forms.TextBox()
        Me.Lbl_Funcao = New System.Windows.Forms.Label()
        Me.TxtBx_EmailCorporativo = New System.Windows.Forms.TextBox()
        Me.Lbl_EmailCorporativo = New System.Windows.Forms.Label()
        Me.TxtBx_Setor = New System.Windows.Forms.TextBox()
        Me.Lbl_Setor = New System.Windows.Forms.Label()
        Me.CmbBx_TipoDeContrato = New System.Windows.Forms.ComboBox()
        Me.Pnl_Divisor_2 = New System.Windows.Forms.Panel()
        Me.GrpBx_InformacoesSobreEndereco = New System.Windows.Forms.GroupBox()
        Me.TxtBx_Local = New System.Windows.Forms.TextBox()
        Me.Lbl_Local = New System.Windows.Forms.Label()
        Me.Lbl_CEP = New System.Windows.Forms.Label()
        Me.MskdTxtBx_CEP = New System.Windows.Forms.MaskedTextBox()
        Me.Bttn_InserirEndereco = New System.Windows.Forms.Button()
        Me.TxtBx_IdEndereco = New System.Windows.Forms.TextBox()
        Me.TxtBx_IdColaborador = New System.Windows.Forms.TextBox()
        Me.Pnl_Botoes.SuspendLayout()
        Me.Pnl_Dados.SuspendLayout()
        Me.GrpBx_InformacoesPessoais.SuspendLayout()
        Me.GrpBx_InformacoesCorporativas.SuspendLayout()
        Me.GrpBx_InformacoesSobreEndereco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Botoes
        '
        Me.Pnl_Botoes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Pnl_Botoes.Controls.Add(Me.Bttn_Excluir)
        Me.Pnl_Botoes.Controls.Add(Me.Bttn_Limpar)
        Me.Pnl_Botoes.Controls.Add(Me.Bttn_Executar)
        Me.Pnl_Botoes.Controls.Add(Me.Bttn_Cancelar)
        Me.Pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pnl_Botoes.Location = New System.Drawing.Point(0, 438)
        Me.Pnl_Botoes.Name = "Pnl_Botoes"
        Me.Pnl_Botoes.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_Botoes.Size = New System.Drawing.Size(1009, 65)
        Me.Pnl_Botoes.TabIndex = 0
        '
        'Pnl_Dados
        '
        Me.Pnl_Dados.Controls.Add(Me.GrpBx_InformacoesSobreEndereco)
        Me.Pnl_Dados.Controls.Add(Me.Pnl_Divisor_2)
        Me.Pnl_Dados.Controls.Add(Me.GrpBx_InformacoesCorporativas)
        Me.Pnl_Dados.Controls.Add(Me.Pnl_Divisor_1)
        Me.Pnl_Dados.Controls.Add(Me.GrpBx_InformacoesPessoais)
        Me.Pnl_Dados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Dados.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Dados.Name = "Pnl_Dados"
        Me.Pnl_Dados.Padding = New System.Windows.Forms.Padding(15)
        Me.Pnl_Dados.Size = New System.Drawing.Size(1009, 438)
        Me.Pnl_Dados.TabIndex = 1
        '
        'Bttn_Cancelar
        '
        Me.Bttn_Cancelar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Bttn_Cancelar.Location = New System.Drawing.Point(15, 15)
        Me.Bttn_Cancelar.Name = "Bttn_Cancelar"
        Me.Bttn_Cancelar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Cancelar.TabIndex = 0
        Me.Bttn_Cancelar.Text = "Cancelar"
        Me.Bttn_Cancelar.UseVisualStyleBackColor = True
        '
        'Bttn_Executar
        '
        Me.Bttn_Executar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Executar.Location = New System.Drawing.Point(894, 15)
        Me.Bttn_Executar.Name = "Bttn_Executar"
        Me.Bttn_Executar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Executar.TabIndex = 1
        Me.Bttn_Executar.Text = "Salvar/Adicionar"
        Me.Bttn_Executar.UseVisualStyleBackColor = True
        '
        'Bttn_Limpar
        '
        Me.Bttn_Limpar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Limpar.Location = New System.Drawing.Point(794, 15)
        Me.Bttn_Limpar.Name = "Bttn_Limpar"
        Me.Bttn_Limpar.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Limpar.TabIndex = 2
        Me.Bttn_Limpar.Text = "Limpar"
        Me.Bttn_Limpar.UseVisualStyleBackColor = True
        '
        'Bttn_Excluir
        '
        Me.Bttn_Excluir.Dock = System.Windows.Forms.DockStyle.Right
        Me.Bttn_Excluir.Location = New System.Drawing.Point(694, 15)
        Me.Bttn_Excluir.Name = "Bttn_Excluir"
        Me.Bttn_Excluir.Size = New System.Drawing.Size(100, 35)
        Me.Bttn_Excluir.TabIndex = 3
        Me.Bttn_Excluir.Text = "Excluir"
        Me.Bttn_Excluir.UseVisualStyleBackColor = True
        '
        'GrpBx_InformacoesPessoais
        '
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.TxtBx_IdColaborador)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.DtTmPckr_DataNascimento)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_DataNascimento)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.MskdTxtBx_TelefonePessoal)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_TelefonePessoal)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.MskdTxtBx_CPF)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_CPF)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.MskdTxtBx_RG)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_RG)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.CmbBx_Sexo)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_Sexo)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.MskdTxtBx_Chapa)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_Chapa)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.TxtBx_EmailPessoal)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_EmailPessoal)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.TxtBx_NomeCompleto)
        Me.GrpBx_InformacoesPessoais.Controls.Add(Me.Lbl_NomeCompleto)
        Me.GrpBx_InformacoesPessoais.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpBx_InformacoesPessoais.Location = New System.Drawing.Point(15, 15)
        Me.GrpBx_InformacoesPessoais.Name = "GrpBx_InformacoesPessoais"
        Me.GrpBx_InformacoesPessoais.Padding = New System.Windows.Forms.Padding(10)
        Me.GrpBx_InformacoesPessoais.Size = New System.Drawing.Size(979, 130)
        Me.GrpBx_InformacoesPessoais.TabIndex = 0
        Me.GrpBx_InformacoesPessoais.TabStop = False
        Me.GrpBx_InformacoesPessoais.Text = "Informações pessoais"
        '
        'Lbl_NomeCompleto
        '
        Me.Lbl_NomeCompleto.AutoSize = True
        Me.Lbl_NomeCompleto.Location = New System.Drawing.Point(13, 25)
        Me.Lbl_NomeCompleto.Name = "Lbl_NomeCompleto"
        Me.Lbl_NomeCompleto.Size = New System.Drawing.Size(105, 16)
        Me.Lbl_NomeCompleto.TabIndex = 0
        Me.Lbl_NomeCompleto.Text = "Nome Completo"
        '
        'TxtBx_NomeCompleto
        '
        Me.TxtBx_NomeCompleto.Location = New System.Drawing.Point(13, 44)
        Me.TxtBx_NomeCompleto.Name = "TxtBx_NomeCompleto"
        Me.TxtBx_NomeCompleto.Size = New System.Drawing.Size(479, 22)
        Me.TxtBx_NomeCompleto.TabIndex = 1
        '
        'TxtBx_EmailPessoal
        '
        Me.TxtBx_EmailPessoal.Location = New System.Drawing.Point(13, 88)
        Me.TxtBx_EmailPessoal.Name = "TxtBx_EmailPessoal"
        Me.TxtBx_EmailPessoal.Size = New System.Drawing.Size(479, 22)
        Me.TxtBx_EmailPessoal.TabIndex = 3
        '
        'Lbl_EmailPessoal
        '
        Me.Lbl_EmailPessoal.AutoSize = True
        Me.Lbl_EmailPessoal.Location = New System.Drawing.Point(13, 69)
        Me.Lbl_EmailPessoal.Name = "Lbl_EmailPessoal"
        Me.Lbl_EmailPessoal.Size = New System.Drawing.Size(98, 16)
        Me.Lbl_EmailPessoal.TabIndex = 2
        Me.Lbl_EmailPessoal.Text = "E-mail Pessoal"
        '
        'Lbl_Chapa
        '
        Me.Lbl_Chapa.AutoSize = True
        Me.Lbl_Chapa.Location = New System.Drawing.Point(495, 25)
        Me.Lbl_Chapa.Name = "Lbl_Chapa"
        Me.Lbl_Chapa.Size = New System.Drawing.Size(47, 16)
        Me.Lbl_Chapa.TabIndex = 4
        Me.Lbl_Chapa.Text = "Chapa"
        '
        'MskdTxtBx_Chapa
        '
        Me.MskdTxtBx_Chapa.Location = New System.Drawing.Point(498, 44)
        Me.MskdTxtBx_Chapa.Mask = "??? ######"
        Me.MskdTxtBx_Chapa.Name = "MskdTxtBx_Chapa"
        Me.MskdTxtBx_Chapa.Size = New System.Drawing.Size(145, 22)
        Me.MskdTxtBx_Chapa.TabIndex = 5
        '
        'Lbl_Sexo
        '
        Me.Lbl_Sexo.AutoSize = True
        Me.Lbl_Sexo.Location = New System.Drawing.Point(495, 69)
        Me.Lbl_Sexo.Name = "Lbl_Sexo"
        Me.Lbl_Sexo.Size = New System.Drawing.Size(38, 16)
        Me.Lbl_Sexo.TabIndex = 6
        Me.Lbl_Sexo.Text = "Sexo"
        '
        'CmbBx_Sexo
        '
        Me.CmbBx_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBx_Sexo.FormattingEnabled = True
        Me.CmbBx_Sexo.Items.AddRange(New Object() {"Feminino", "Masculino"})
        Me.CmbBx_Sexo.Location = New System.Drawing.Point(498, 88)
        Me.CmbBx_Sexo.Name = "CmbBx_Sexo"
        Me.CmbBx_Sexo.Size = New System.Drawing.Size(145, 24)
        Me.CmbBx_Sexo.TabIndex = 7
        '
        'Lbl_RG
        '
        Me.Lbl_RG.AutoSize = True
        Me.Lbl_RG.Location = New System.Drawing.Point(647, 25)
        Me.Lbl_RG.Name = "Lbl_RG"
        Me.Lbl_RG.Size = New System.Drawing.Size(27, 16)
        Me.Lbl_RG.TabIndex = 8
        Me.Lbl_RG.Text = "RG"
        '
        'MskdTxtBx_RG
        '
        Me.MskdTxtBx_RG.Location = New System.Drawing.Point(649, 44)
        Me.MskdTxtBx_RG.Mask = "?? ##.###.###-#"
        Me.MskdTxtBx_RG.Name = "MskdTxtBx_RG"
        Me.MskdTxtBx_RG.Size = New System.Drawing.Size(148, 22)
        Me.MskdTxtBx_RG.TabIndex = 9
        '
        'MskdTxtBx_CPF
        '
        Me.MskdTxtBx_CPF.Location = New System.Drawing.Point(649, 88)
        Me.MskdTxtBx_CPF.Mask = "###.###.###-##"
        Me.MskdTxtBx_CPF.Name = "MskdTxtBx_CPF"
        Me.MskdTxtBx_CPF.Size = New System.Drawing.Size(148, 22)
        Me.MskdTxtBx_CPF.TabIndex = 11
        '
        'Lbl_CPF
        '
        Me.Lbl_CPF.AutoSize = True
        Me.Lbl_CPF.Location = New System.Drawing.Point(647, 69)
        Me.Lbl_CPF.Name = "Lbl_CPF"
        Me.Lbl_CPF.Size = New System.Drawing.Size(33, 16)
        Me.Lbl_CPF.TabIndex = 10
        Me.Lbl_CPF.Text = "CPF"
        '
        'MskdTxtBx_TelefonePessoal
        '
        Me.MskdTxtBx_TelefonePessoal.Location = New System.Drawing.Point(806, 44)
        Me.MskdTxtBx_TelefonePessoal.Mask = "(##) # ####-####"
        Me.MskdTxtBx_TelefonePessoal.Name = "MskdTxtBx_TelefonePessoal"
        Me.MskdTxtBx_TelefonePessoal.Size = New System.Drawing.Size(160, 22)
        Me.MskdTxtBx_TelefonePessoal.TabIndex = 13
        '
        'Lbl_TelefonePessoal
        '
        Me.Lbl_TelefonePessoal.AutoSize = True
        Me.Lbl_TelefonePessoal.Location = New System.Drawing.Point(804, 25)
        Me.Lbl_TelefonePessoal.Name = "Lbl_TelefonePessoal"
        Me.Lbl_TelefonePessoal.Size = New System.Drawing.Size(114, 16)
        Me.Lbl_TelefonePessoal.TabIndex = 12
        Me.Lbl_TelefonePessoal.Text = "Telefone Pessoal"
        '
        'Lbl_DataNascimento
        '
        Me.Lbl_DataNascimento.AutoSize = True
        Me.Lbl_DataNascimento.Location = New System.Drawing.Point(803, 69)
        Me.Lbl_DataNascimento.Name = "Lbl_DataNascimento"
        Me.Lbl_DataNascimento.Size = New System.Drawing.Size(130, 16)
        Me.Lbl_DataNascimento.TabIndex = 14
        Me.Lbl_DataNascimento.Text = "Data de Nascimento"
        '
        'DtTmPckr_DataNascimento
        '
        Me.DtTmPckr_DataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataNascimento.Location = New System.Drawing.Point(806, 88)
        Me.DtTmPckr_DataNascimento.Name = "DtTmPckr_DataNascimento"
        Me.DtTmPckr_DataNascimento.Size = New System.Drawing.Size(160, 22)
        Me.DtTmPckr_DataNascimento.TabIndex = 15
        '
        'Pnl_Divisor_1
        '
        Me.Pnl_Divisor_1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Divisor_1.Location = New System.Drawing.Point(15, 145)
        Me.Pnl_Divisor_1.Name = "Pnl_Divisor_1"
        Me.Pnl_Divisor_1.Size = New System.Drawing.Size(979, 10)
        Me.Pnl_Divisor_1.TabIndex = 1
        '
        'GrpBx_InformacoesCorporativas
        '
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.CmbBx_TipoDeContrato)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.TxtBx_Setor)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.Lbl_Setor)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.DtTmPckr_DataAdmissao)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.Lbl_DataAdmissao)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.Lbl_TipoContrato)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.TxtBx_Funcao)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.Lbl_Funcao)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.TxtBx_EmailCorporativo)
        Me.GrpBx_InformacoesCorporativas.Controls.Add(Me.Lbl_EmailCorporativo)
        Me.GrpBx_InformacoesCorporativas.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpBx_InformacoesCorporativas.Location = New System.Drawing.Point(15, 155)
        Me.GrpBx_InformacoesCorporativas.Name = "GrpBx_InformacoesCorporativas"
        Me.GrpBx_InformacoesCorporativas.Padding = New System.Windows.Forms.Padding(10)
        Me.GrpBx_InformacoesCorporativas.Size = New System.Drawing.Size(979, 171)
        Me.GrpBx_InformacoesCorporativas.TabIndex = 2
        Me.GrpBx_InformacoesCorporativas.TabStop = False
        Me.GrpBx_InformacoesCorporativas.Text = "Informações corporativas"
        '
        'DtTmPckr_DataAdmissao
        '
        Me.DtTmPckr_DataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTmPckr_DataAdmissao.Location = New System.Drawing.Point(498, 44)
        Me.DtTmPckr_DataAdmissao.Name = "DtTmPckr_DataAdmissao"
        Me.DtTmPckr_DataAdmissao.Size = New System.Drawing.Size(145, 22)
        Me.DtTmPckr_DataAdmissao.TabIndex = 15
        '
        'Lbl_DataAdmissao
        '
        Me.Lbl_DataAdmissao.AutoSize = True
        Me.Lbl_DataAdmissao.Location = New System.Drawing.Point(495, 23)
        Me.Lbl_DataAdmissao.Name = "Lbl_DataAdmissao"
        Me.Lbl_DataAdmissao.Size = New System.Drawing.Size(119, 16)
        Me.Lbl_DataAdmissao.TabIndex = 14
        Me.Lbl_DataAdmissao.Text = "Data de Admissão"
        '
        'Lbl_TipoContrato
        '
        Me.Lbl_TipoContrato.AutoSize = True
        Me.Lbl_TipoContrato.Location = New System.Drawing.Point(646, 23)
        Me.Lbl_TipoContrato.Name = "Lbl_TipoContrato"
        Me.Lbl_TipoContrato.Size = New System.Drawing.Size(107, 16)
        Me.Lbl_TipoContrato.TabIndex = 12
        Me.Lbl_TipoContrato.Text = "Tipo de Contrato"
        '
        'TxtBx_Funcao
        '
        Me.TxtBx_Funcao.Location = New System.Drawing.Point(13, 88)
        Me.TxtBx_Funcao.Name = "TxtBx_Funcao"
        Me.TxtBx_Funcao.Size = New System.Drawing.Size(953, 22)
        Me.TxtBx_Funcao.TabIndex = 3
        '
        'Lbl_Funcao
        '
        Me.Lbl_Funcao.AutoSize = True
        Me.Lbl_Funcao.Location = New System.Drawing.Point(13, 69)
        Me.Lbl_Funcao.Name = "Lbl_Funcao"
        Me.Lbl_Funcao.Size = New System.Drawing.Size(52, 16)
        Me.Lbl_Funcao.TabIndex = 2
        Me.Lbl_Funcao.Text = "Função"
        '
        'TxtBx_EmailCorporativo
        '
        Me.TxtBx_EmailCorporativo.Location = New System.Drawing.Point(13, 44)
        Me.TxtBx_EmailCorporativo.Name = "TxtBx_EmailCorporativo"
        Me.TxtBx_EmailCorporativo.Size = New System.Drawing.Size(479, 22)
        Me.TxtBx_EmailCorporativo.TabIndex = 1
        '
        'Lbl_EmailCorporativo
        '
        Me.Lbl_EmailCorporativo.AutoSize = True
        Me.Lbl_EmailCorporativo.Location = New System.Drawing.Point(13, 25)
        Me.Lbl_EmailCorporativo.Name = "Lbl_EmailCorporativo"
        Me.Lbl_EmailCorporativo.Size = New System.Drawing.Size(118, 16)
        Me.Lbl_EmailCorporativo.TabIndex = 0
        Me.Lbl_EmailCorporativo.Text = "E-mail Corporativo"
        '
        'TxtBx_Setor
        '
        Me.TxtBx_Setor.Location = New System.Drawing.Point(13, 132)
        Me.TxtBx_Setor.Name = "TxtBx_Setor"
        Me.TxtBx_Setor.Size = New System.Drawing.Size(953, 22)
        Me.TxtBx_Setor.TabIndex = 17
        '
        'Lbl_Setor
        '
        Me.Lbl_Setor.AutoSize = True
        Me.Lbl_Setor.Location = New System.Drawing.Point(13, 113)
        Me.Lbl_Setor.Name = "Lbl_Setor"
        Me.Lbl_Setor.Size = New System.Drawing.Size(39, 16)
        Me.Lbl_Setor.TabIndex = 16
        Me.Lbl_Setor.Text = "Setor"
        '
        'CmbBx_TipoDeContrato
        '
        Me.CmbBx_TipoDeContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBx_TipoDeContrato.FormattingEnabled = True
        Me.CmbBx_TipoDeContrato.Items.AddRange(New Object() {"Mensalista - Administrativo", "Mensalista - Instrutor de Formação Profissional", "Mensalista - Prazo Determinado", "Horista - Interminente", "Horista - Instrutor de Formação Profissional"})
        Me.CmbBx_TipoDeContrato.Location = New System.Drawing.Point(649, 42)
        Me.CmbBx_TipoDeContrato.Name = "CmbBx_TipoDeContrato"
        Me.CmbBx_TipoDeContrato.Size = New System.Drawing.Size(317, 24)
        Me.CmbBx_TipoDeContrato.TabIndex = 18
        '
        'Pnl_Divisor_2
        '
        Me.Pnl_Divisor_2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Divisor_2.Location = New System.Drawing.Point(15, 326)
        Me.Pnl_Divisor_2.Name = "Pnl_Divisor_2"
        Me.Pnl_Divisor_2.Size = New System.Drawing.Size(979, 10)
        Me.Pnl_Divisor_2.TabIndex = 3
        '
        'GrpBx_InformacoesSobreEndereco
        '
        Me.GrpBx_InformacoesSobreEndereco.Controls.Add(Me.TxtBx_IdEndereco)
        Me.GrpBx_InformacoesSobreEndereco.Controls.Add(Me.Bttn_InserirEndereco)
        Me.GrpBx_InformacoesSobreEndereco.Controls.Add(Me.MskdTxtBx_CEP)
        Me.GrpBx_InformacoesSobreEndereco.Controls.Add(Me.Lbl_CEP)
        Me.GrpBx_InformacoesSobreEndereco.Controls.Add(Me.TxtBx_Local)
        Me.GrpBx_InformacoesSobreEndereco.Controls.Add(Me.Lbl_Local)
        Me.GrpBx_InformacoesSobreEndereco.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpBx_InformacoesSobreEndereco.Location = New System.Drawing.Point(15, 336)
        Me.GrpBx_InformacoesSobreEndereco.Name = "GrpBx_InformacoesSobreEndereco"
        Me.GrpBx_InformacoesSobreEndereco.Padding = New System.Windows.Forms.Padding(10)
        Me.GrpBx_InformacoesSobreEndereco.Size = New System.Drawing.Size(979, 83)
        Me.GrpBx_InformacoesSobreEndereco.TabIndex = 4
        Me.GrpBx_InformacoesSobreEndereco.TabStop = False
        Me.GrpBx_InformacoesSobreEndereco.Text = "Informações sobre endereço"
        '
        'TxtBx_Local
        '
        Me.TxtBx_Local.Enabled = False
        Me.TxtBx_Local.Location = New System.Drawing.Point(119, 41)
        Me.TxtBx_Local.Name = "TxtBx_Local"
        Me.TxtBx_Local.ReadOnly = True
        Me.TxtBx_Local.Size = New System.Drawing.Size(741, 22)
        Me.TxtBx_Local.TabIndex = 1
        '
        'Lbl_Local
        '
        Me.Lbl_Local.AutoSize = True
        Me.Lbl_Local.Location = New System.Drawing.Point(116, 22)
        Me.Lbl_Local.Name = "Lbl_Local"
        Me.Lbl_Local.Size = New System.Drawing.Size(40, 16)
        Me.Lbl_Local.TabIndex = 0
        Me.Lbl_Local.Text = "Local"
        '
        'Lbl_CEP
        '
        Me.Lbl_CEP.AutoSize = True
        Me.Lbl_CEP.Location = New System.Drawing.Point(13, 22)
        Me.Lbl_CEP.Name = "Lbl_CEP"
        Me.Lbl_CEP.Size = New System.Drawing.Size(34, 16)
        Me.Lbl_CEP.TabIndex = 2
        Me.Lbl_CEP.Text = "CEP"
        '
        'MskdTxtBx_CEP
        '
        Me.MskdTxtBx_CEP.Enabled = False
        Me.MskdTxtBx_CEP.Location = New System.Drawing.Point(13, 41)
        Me.MskdTxtBx_CEP.Mask = "#####-###"
        Me.MskdTxtBx_CEP.Name = "MskdTxtBx_CEP"
        Me.MskdTxtBx_CEP.ReadOnly = True
        Me.MskdTxtBx_CEP.Size = New System.Drawing.Size(100, 22)
        Me.MskdTxtBx_CEP.TabIndex = 4
        '
        'Bttn_InserirEndereco
        '
        Me.Bttn_InserirEndereco.Location = New System.Drawing.Point(866, 23)
        Me.Bttn_InserirEndereco.Name = "Bttn_InserirEndereco"
        Me.Bttn_InserirEndereco.Size = New System.Drawing.Size(100, 41)
        Me.Bttn_InserirEndereco.TabIndex = 5
        Me.Bttn_InserirEndereco.Text = "Inserir"
        Me.Bttn_InserirEndereco.UseVisualStyleBackColor = True
        '
        'TxtBx_IdEndereco
        '
        Me.TxtBx_IdEndereco.Location = New System.Drawing.Point(806, 16)
        Me.TxtBx_IdEndereco.Name = "TxtBx_IdEndereco"
        Me.TxtBx_IdEndereco.Size = New System.Drawing.Size(54, 22)
        Me.TxtBx_IdEndereco.TabIndex = 6
        Me.TxtBx_IdEndereco.Visible = False
        '
        'TxtBx_IdColaborador
        '
        Me.TxtBx_IdColaborador.Location = New System.Drawing.Point(442, 19)
        Me.TxtBx_IdColaborador.Name = "TxtBx_IdColaborador"
        Me.TxtBx_IdColaborador.Size = New System.Drawing.Size(47, 22)
        Me.TxtBx_IdColaborador.TabIndex = 7
        Me.TxtBx_IdColaborador.Visible = False
        '
        'Frm_Cadastro_Colaboradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1009, 503)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pnl_Dados)
        Me.Controls.Add(Me.Pnl_Botoes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Cadastro_Colaboradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colaborador(a) | Modo"
        Me.Pnl_Botoes.ResumeLayout(False)
        Me.Pnl_Dados.ResumeLayout(False)
        Me.GrpBx_InformacoesPessoais.ResumeLayout(False)
        Me.GrpBx_InformacoesPessoais.PerformLayout()
        Me.GrpBx_InformacoesCorporativas.ResumeLayout(False)
        Me.GrpBx_InformacoesCorporativas.PerformLayout()
        Me.GrpBx_InformacoesSobreEndereco.ResumeLayout(False)
        Me.GrpBx_InformacoesSobreEndereco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Botoes As Panel
    Friend WithEvents Pnl_Dados As Panel
    Friend WithEvents Bttn_Excluir As Button
    Friend WithEvents Bttn_Limpar As Button
    Friend WithEvents Bttn_Executar As Button
    Friend WithEvents Bttn_Cancelar As Button
    Friend WithEvents GrpBx_InformacoesPessoais As GroupBox
    Friend WithEvents TxtBx_NomeCompleto As TextBox
    Friend WithEvents Lbl_NomeCompleto As Label
    Friend WithEvents TxtBx_EmailPessoal As TextBox
    Friend WithEvents Lbl_EmailPessoal As Label
    Friend WithEvents CmbBx_Sexo As ComboBox
    Friend WithEvents Lbl_Sexo As Label
    Friend WithEvents MskdTxtBx_Chapa As MaskedTextBox
    Friend WithEvents Lbl_Chapa As Label
    Friend WithEvents MskdTxtBx_RG As MaskedTextBox
    Friend WithEvents Lbl_RG As Label
    Friend WithEvents MskdTxtBx_CPF As MaskedTextBox
    Friend WithEvents Lbl_CPF As Label
    Friend WithEvents DtTmPckr_DataNascimento As DateTimePicker
    Friend WithEvents Lbl_DataNascimento As Label
    Friend WithEvents MskdTxtBx_TelefonePessoal As MaskedTextBox
    Friend WithEvents Lbl_TelefonePessoal As Label
    Friend WithEvents GrpBx_InformacoesCorporativas As GroupBox
    Friend WithEvents DtTmPckr_DataAdmissao As DateTimePicker
    Friend WithEvents Lbl_DataAdmissao As Label
    Friend WithEvents Lbl_TipoContrato As Label
    Friend WithEvents TxtBx_Funcao As TextBox
    Friend WithEvents Lbl_Funcao As Label
    Friend WithEvents TxtBx_EmailCorporativo As TextBox
    Friend WithEvents Lbl_EmailCorporativo As Label
    Friend WithEvents Pnl_Divisor_1 As Panel
    Friend WithEvents TxtBx_Setor As TextBox
    Friend WithEvents Lbl_Setor As Label
    Friend WithEvents CmbBx_TipoDeContrato As ComboBox
    Friend WithEvents GrpBx_InformacoesSobreEndereco As GroupBox
    Friend WithEvents MskdTxtBx_CEP As MaskedTextBox
    Friend WithEvents Lbl_CEP As Label
    Friend WithEvents TxtBx_Local As TextBox
    Friend WithEvents Lbl_Local As Label
    Friend WithEvents Pnl_Divisor_2 As Panel
    Friend WithEvents Bttn_InserirEndereco As Button
    Friend WithEvents TxtBx_IdEndereco As TextBox
    Friend WithEvents TxtBx_IdColaborador As TextBox
End Class
