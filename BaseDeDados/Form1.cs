using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe; //SQL COMPACT
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;    //SQLITE
using MySql.Data.MySqlClient; //MYSQL

namespace BaseDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE
            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource=" + baseDados + ";Password='12345'";

            //SqlCeEngine db = new SqlCeEngine(strConection);

            ////VERIFICA SE EXSITE ESTA BASE DE DADOS
            //if (!File.Exists(baseDados))
            //{
            //    db.CreateDatabase();
            //}

            //db.Dispose();

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            ////conexao.ConnectionString = strConection;

            //try
            //{
            //    conexao.Open();
            //    lbResultado.Text = "Conectado Sql Server CE";
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + ";Version=3";

            ////VERIFICA SE EXSITE ESTA BASE DE DADOS
            //if (!File.Exists(baseDados))
            //{
            //    SQLiteConnection.CreateFile(baseDados);
            //}

            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            ////conexao.ConnectionString = strConection;

            //try
            //{
            //    conexao.Open();
            //    lbResultado.Text = "Conectado SQLite";
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySQL
            //string strConnection = "server=127.0.0.1;User Id=root;password=";
            ////string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();
            //    lbResultado.Text = "Conectado MySQL";

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE DATABASE IF NOT EXISTS curso_db";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Base de dados criada com sucesso !";
            //    comando.Dispose();
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
            //finally
            //{

            //    conexao.Close();
            //}

            #endregion
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
            #region SQL Server CE

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource=" + baseDados + ";Password='12345'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50),email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Tabela Criada SQL Server CE !";

            //    comando.Dispose();

            //}
            //catch(Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + ";Version=3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);
            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(50),email NVARCHAR(50))";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Tabela Criada SQLite !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySql

            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);
            ////conexao.ConnectionString = strConnection;

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;
            //    comando.CommandText = "CREATE TABLE pessoas(id INT NOT NULL, nome VARCHAR(50),email VARCHAR(50), PRIMARY KEY(id))";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Tabela criada no MySql !";
            //    comando.Dispose();
            //}
            //catch (Exception erro)
            //{
            //    MessageBox.Show(erro.Message);
            //}
            //finally
            //{

            //    conexao.Close();
            //}

            #endregion
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            #region SQL Server CE

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource=" + baseDados + ";Password='12345'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0,1000);

            //    if(String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtEmail.Text))
            //    {
            //        lbResultado.Text = "Você deve preencher o campo nome e email !";
            //        return;
            //    }

            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES ("+ id + ",'" + nome + "','" + email + "')";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Inserido no SQL Server CE !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + ";Version=3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);

            //    if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtEmail.Text))
            //    {
            //        lbResultado.Text = "Você deve preencher o campo nome e email !";
            //        return;
            //    }

            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ",'" + nome + "','" + email + "')";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Inserido no SQLite !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySql

            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = new Random(DateTime.Now.Millisecond).Next(0, 1000);

            //    if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtEmail.Text))
            //    {
            //        lbResultado.Text = "Você deve preencher o campo nome e email !";
            //        return;
            //    }

            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    comando.CommandText = "INSERT INTO pessoas VALUES (" + id + ",'" + nome + "','" + email + "')";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Inserido no MySql !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion 
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE

            //lbResultado.Text = "";
            //lista.Rows.Clear();

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource=" + baseDados + ";Password='12345'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{

            //    string query = "SELECT * FROM pessoas";

            //    if (!String.IsNullOrEmpty(txtNome.Text))
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text + "%'";
            //    }

            //    if (!String.IsNullOrEmpty(txtNome.Text))
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text + "%'";
            //    }

            //    DataTable dados = new DataTable();

            //    SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow item in dados.Rows)
            //    {
            //        lista.Rows.Add(item.ItemArray);
            //    }

            //}
            //catch (Exception error)
            //{
            //    lista.Rows.Clear();
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLite

            //lbResultado.Text = "";
            //lista.Rows.Clear();

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + ";Version=3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{

            //    string query = "SELECT * FROM pessoas";

            //    if (!String.IsNullOrEmpty(txtNome.Text))
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text + "%'";
            //    }

            //    if (!String.IsNullOrEmpty(txtNome.Text))
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text + "%'";
            //    }

            //    DataTable dados = new DataTable();

            //    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, strConection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow item in dados.Rows)
            //    {
            //        lista.Rows.Add(item.ItemArray);
            //    }

            //}
            //catch (Exception error)
            //{
            //    lista.Rows.Clear();
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySql

            //lbResultado.Text = "";
            //lista.Rows.Clear();

            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{

            //    string query = "SELECT * FROM pessoas";

            //    if (!String.IsNullOrEmpty(txtNome.Text))
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text + "%'";
            //    }

            //    if (!String.IsNullOrEmpty(txtNome.Text))
            //    {
            //        query = "SELECT * FROM pessoas WHERE nome LIKE '%" + txtNome.Text + "%'";
            //    }

            //    DataTable dados = new DataTable();

            //    MySqlDataAdapter adaptador = new MySqlDataAdapter(query, strConnection);

            //    conexao.Open();

            //    adaptador.Fill(dados);

            //    foreach (DataRow item in dados.Rows)
            //    {
            //        lista.Rows.Add(item.ItemArray);
            //    }

            //}
            //catch (Exception error)
            //{
            //    lista.Rows.Clear();
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region SQL Server CE

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource=" + baseDados + ";Password='12345'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int) lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '"+id+"'";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Deletado no SQL Server CE !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + ";Version=3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = (int) lista.SelectedRows[0].Cells[0].Value;


            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '"+id+"'";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Deletado no SQLite !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion

            #region MySql

            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = (int) lista.SelectedRows[0].Cells[0].Value;

            //    comando.CommandText = "DELETE FROM pessoas WHERE id = '"+id+"'";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Deletado no MySql !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    conexao.Close();
            //}

            #endregion
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            #region SQL Server CE

            //string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            //string strConection = @"DataSource=" + baseDados + ";Password='12345'";

            //SqlCeConnection conexao = new SqlCeConnection(strConection);
            //try
            //{
            //    conexao.Open();

            //    SqlCeCommand comando = new SqlCeCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    if (String.IsNullOrEmpty(nome))
            //    {
            //        MessageBox.Show("Você deve preencher o campo Nome !");
            //        return;
            //    }

            //    if (String.IsNullOrEmpty(email))
            //    {
            //        MessageBox.Show("Você deve preencher o campo Email !");
            //        return;
            //    }

            //    comando.CommandText = "UPDATE pessoas SET nome = '"+nome+"', email = '"+email+"' WHERE id = '" + id + "'";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Editado no SQL Server CE !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{

            //    txtNome.Text = "";
            //    txtEmail.Text = "";

            //    conexao.Close();
            //}

            #endregion

            #region SQLite

            //string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            //string strConection = @"Data Source=" + baseDados + ";Version=3";

            //SQLiteConnection conexao = new SQLiteConnection(strConection);

            //try
            //{
            //    conexao.Open();

            //    SQLiteCommand comando = new SQLiteCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    if (String.IsNullOrEmpty(nome))
            //    {
            //        MessageBox.Show("Você deve preencher o campo Nome !");
            //        return;
            //    }

            //    if (String.IsNullOrEmpty(email))
            //    {
            //        MessageBox.Show("Você deve preencher o campo Email !");
            //        return;
            //    }

            //    comando.CommandText = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id = '" + id + "'";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Editado no SQLite !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{

            //    txtNome.Text  = "";
            //    txtEmail.Text = "";

            //    conexao.Close();
            //}

            #endregion

            #region MySql

            //string strConnection = "server=127.0.0.1;User Id=root;database=curso_db;password=";

            //MySqlConnection conexao = new MySqlConnection(strConnection);

            //try
            //{
            //    conexao.Open();

            //    MySqlCommand comando = new MySqlCommand();
            //    comando.Connection = conexao;

            //    int id = (int)lista.SelectedRows[0].Cells[0].Value;
            //    string nome = txtNome.Text;
            //    string email = txtEmail.Text;

            //    if (String.IsNullOrEmpty(nome))
            //    {
            //        MessageBox.Show("Você deve preencher o campo Nome !");
            //        return;
            //    }

            //    if (String.IsNullOrEmpty(email))
            //    {
            //        MessageBox.Show("Você deve preencher o campo Email !");
            //        return;
            //    }

            //    comando.CommandText = "UPDATE pessoas SET nome = '" + nome + "', email = '" + email + "' WHERE id = '" + id + "'";
            //    comando.ExecuteNonQuery();

            //    lbResultado.Text = "Registro Editado no MySql !";

            //    comando.Dispose();

            //}
            //catch (Exception error)
            //{
            //    lbResultado.Text = error.Message;
            //}
            //finally
            //{
            //    txtNome.Text  = "";
            //    txtEmail.Text = "";
            //    conexao.Close();
            //}

            #endregion
        }
    }
}
