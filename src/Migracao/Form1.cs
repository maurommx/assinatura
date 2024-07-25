using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Migracao
{
    public partial class btnIniciar : Form
    {
        #region variaveis
        string conexao = "Server=127.0.0.1, 2354; Initial Catalog=Poly; MultipleActiveResultSets=true; User ID=sa; Password=P@ssword00";
        #endregion
        public btnIniciar()
        {
            InitializeComponent();
            lblStatus.Text = string.Empty;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            BarGeral.Maximum = 5;
            lblStatus.Text = "Realizando conexão...";
            using (SqlConnection cnn = new SqlConnection(conexao))
            {
                await cnn.OpenAsync();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;


                string a = "";



                #region UpdateFabricasStringToInt
                lblStatus.Text = "Atualizando Colunas Fabricas.Id de String para Int...";
                cmd.CommandText = @$"
                    ALTER TABLE Produtos DROP CONSTRAINT [FK_Produtos_Fabricas1];
                    ALTER TABLE Setores DROP CONSTRAINT [FK_Setores_Fabricas];
                    ALTER TABLE Fabricas DROP CONSTRAINT [PK_Fabricas_1];
                    ALTER TABLE Fabricas ALTER COLUMN Id Int NOT NULL;
                    ALTER TABLE Fabricas ADD PRIMARY KEY(Id);
                    ALTER TABLE Produtos ALTER COLUMN Id_Fabrica Int;
                    ALTER TABLE Produtos ADD CONSTRAINT [FK_Produtos_Fabricas] FOREIGN KEY (Id_Fabrica) References Fabricas(Id);
                    ALTER TABLE Setores ALTER COLUMN Id_Fabrica Int;
                    ALTER TABLE Setores ADD CONSTRAINT [FK_Setores_Fabricas] FOREIGN KEY (Id_Fabrica) References Fabricas(Id);

                    CREATE TABLE FuncionariosFabricas (
                        Id int IDENTITY(1,1) PRIMARY KEY,
                        Id_Funcionario int not null,
                        Id_Fabrica int not null,
                        CreateAt datetime,
                        UpdateAt datetime,
                        CONSTRAINT [FK_FuncionariosFabricas_Funcionario] FOREIGN KEY (Id_Funcionario) REFERENCES Funcionarios(Id),
                        CONSTRAINT [FK_FuncionariosFabricas_Fabrica] FOREIGN KEY (Id_Fabrica) REFERENCES Fabricas(Id)
                    );

                    ALTER TABLE Usuarios ALTER COLUMN Senha varchar(50);

                    ALTER TABLE Usuarios ADD
                            Nome varchar(30),
                            Email varchar(100),
                            CreateAt datetime,
                            UpdateAt datetime
                    ;

                    ALTER TABLE Setores ADD
                            CreateAt datetime,
                            UpdateAt datetime
                    ;

                    ALTER TABLE Departamentos ADD
                            CreateAt datetime,
                            UpdateAt datetime
                    ;

                    ALTER TABLE Funcionarios ADD
                            CreateAt datetime,
                            UpdateAt datetime
                    ;

                    ALTER TABLE NF_Canceladas_Itens DROP CONSTRAINT [FK_NF_Canceladas_Itens_Produtos];
                ";
                await cmd.ExecuteNonQueryAsync();
                BarGeral.Value++;
                #endregion

                #region FuncionariosFabricasMigracao
                lblStatus.Text = "Realizando Migração para FuncionariosFabricas...";
                cmd.CommandText = @$"SELECT Id, Id_Fabrica FROM Funcionarios WHERE Id_Fabrica is not null";
                DataTable tbl = new DataTable();
                tbl.Load(await cmd.ExecuteReaderAsync());
                BarIndividual.Maximum = tbl.Rows.Count;
                foreach (DataRow row in tbl.Rows)
                {
                    var itens = row["Id_Fabrica"].ToString().Split(",");
                    cmd.CommandText = string.Empty;
                    foreach (var r in itens)
                    {
                        if (cmd.CommandText == string.Empty)
                            cmd.CommandText = string.Format("INSERT INTO FuncionariosFabricas(Id_Funcionario, Id_Fabrica, CreateAt) VALUES({0}, {1}, GetDate())", row[0], r);
                        else
                            cmd.CommandText += string.Format(",({0}, {1}, GetDate())", row[0], r);
                    }
                    await cmd.ExecuteNonQueryAsync();
                    BarIndividual.Value++;
                }
                BarIndividual.Value = 0;
                BarGeral.Value++;
                #endregion

                #region FuncionarioDropField
                lblStatus.Text = "Removendo Coluna Funcionario...";
                cmd.CommandText = @$"ALTER TABLE Funcionarios DROP Column Id_Fabrica;";
                await cmd.ExecuteNonQueryAsync();
                BarGeral.Value++;
                #endregion

                #region UsuariosAjustesEmail
                lblStatus.Text = "Realizando Ajustes para Usuários...";
                cmd.CommandText = @$"SELECT Id, Email FROM Funcionarios WHERE Id in (SELECT Id_Funcionario FROM Usuarios)";
                tbl = new DataTable();
                tbl.Load(await cmd.ExecuteReaderAsync());
                string it = string.Empty;
                foreach (DataRow row in tbl.Rows)
                {
                    it += string.Format("UPDATE Usuarios SET Email = '{0}' WHERE Id_Funcionario= {1};", row[1].ToString(), row[0].ToString());
                }
                if (it != string.Empty)
                {
                    cmd.CommandText = it;
                    await cmd.ExecuteNonQueryAsync();
                }
                BarGeral.Value++;
                #endregion

                #region UsuariosUpdatePassword
                lblStatus.Text = "Realizando Ajustes para Usuários...";
                cmd.CommandText = @$"SELECT Id, Senha FROM Usuarios";
                tbl = new DataTable();
                tbl.Load(await cmd.ExecuteReaderAsync());
                it = string.Empty;
                foreach (DataRow row in tbl.Rows)
                {
                    it += string.Format("UPDATE Usuarios SET Senha = '{0}' WHERE Id= {1};", row["Senha"].ToString().GenerateHash(), row["Id"].ToString());
                }
                if (it != string.Empty)
                {
                    cmd.CommandText = it;
                    await cmd.ExecuteNonQueryAsync();
                }
                BarGeral.Value++;
                #endregion





                await cnn.CloseAsync();
                lblStatus.Text = "Concluído!";
            }
        }
    }
}
