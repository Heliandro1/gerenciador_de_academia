using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace Academy
{
    sealed class Base
    {
        public class SQLParametros
        {
            public string Parametro { get; set; }
            public object Value { get; set; }
            public SQLParametros(string Parametro, object Value)
            {
                this.Parametro = Parametro;
                this.Value = Value;
            }
        }
        private static SqlCeConnection connect;
        public static string passwordDB = "heliandroh123";
        public static void GenerateDataBase()
        {
            if (!Directory.Exists($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database"))
                Directory.CreateDirectory($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database");

            if (!File.Exists($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database\AcademyDb.sdf"))
            {
                List<string> str = new List<string>() { $@"Data source = {AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database\AcademyDb.sdf; Password = {passwordDB}" };
                SqlCeEngine engine = new SqlCeEngine(str[0]);
                engine.CreateDatabase();
                File.Encrypt($@"{AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database\AcademyDb.sdf");
                connect = new SqlCeConnection(str[0]);
                var comando = connect.CreateCommand();
                connect.Open();
                str = null;
                str = new List<string>()
                {
                    @"CREATE TABLE [Horarios] (
                    [N_IDHORARIO] int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
                    [T_DSCHORARIO] nvarchar(15))",

                    @"CREATE TABLE [Professores] (
                    [N_IDPROFESSOR] bigint NOT NULL IDENTITY(1,1) PRIMARY KEY, 
                    [T_NOMEPROFESSOR] nvarchar(30), 
                    [T_TELEFONE] nvarchar(20))",

                    @"CREATE TABLE [Turmas] (
                    [N_IDTURMA] bigint NOT NULL IDENTITY(1,1) PRIMARY KEY, 
                    [T_SIGLA] nvarchar(30), 
                    [N_IDPROFESSOR] bigint NOT NULL, 
                    [N_IDHORARIO] int NOT NULL, 
                    [N_MAXALUNOS] int NOT NULL DEFAULT -1, 
                    [T_STATUS] nvarchar(1) DEFAULT N'A', 
                    FOREIGN KEY ([N_IDHORARIO])
                    REFERENCES [Horarios] ([N_IDHORARIO])
                    ON UPDATE NO ACTION ON DELETE SET NULL, 
                    FOREIGN KEY ([N_IDPROFESSOR])
                    REFERENCES [Professores] ([N_IDPROFESSOR])
                    ON UPDATE NO ACTION ON DELETE SET NULL
                    )",

                    @"CREATE TABLE [Users] (
                    [N_IDUSUARIO] int NOT NULL IDENTITY(1,1) PRIMARY KEY, 
                    [T_NOMEUSUARIO] nvarchar(30), 
                    [T_USERNAME] nvarchar(254), 
                    [T_SENHAUSUARIO] nvarchar(1696), 
                    [T_STATUSUSUARIO] nvarchar(1), 
                    [N_NIVELUSUARIO] int )",

                    @"CREATE TABLE [Alunos] (
	                [N_IDALUNO] bigint NOT NULL IDENTITY(1,1) PRIMARY KEY, 
	                [T_NOMEALUNO] nvarchar(30), 
	                [T_TELEFONE] nvarchar(20), 
	                [T_STATUS] nvarchar(1), 
	                [N_IDTURMA] bigint NOT NULL, 
                    [T_PHOTO] nvarchar(1000),
	                FOREIGN KEY ([N_IDTURMA])
		                REFERENCES [Turmas] ([N_IDTURMA])
		                ON UPDATE NO ACTION ON DELETE SET NULL
                    )"
                };
                foreach (var item in str)
                {
                    comando.CommandText = item;
                    comando.ExecuteNonQuery();
                }
                engine.Dispose();
                comando.Dispose();
                connect.Dispose();
            }
            return;
        }
        private static SqlCeConnection ConexaoBanco()
        {
            connect = new SqlCeConnection($@"Data source = {AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database\AcademyDb.sdf; Password={passwordDB}");
            connect.Open();
            return connect;
        }
        public static DataTable GetAllUsers()
        {
            SqlCeDataAdapter adapter = null;
            DataTable dados = new DataTable();
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM users";
                adapter = new SqlCeDataAdapter(cmd.CommandText, connection);
                adapter.Fill(dados);
                connection.Dispose();
                cmd.Dispose();
                adapter.Dispose();
                return dados;
                
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static DataTable Query(string query, List<SQLParametros> P = null)
        {
            SqlCeDataAdapter adapter = null;
            DataTable dados = new DataTable();
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = query;
                adapter = new SqlCeDataAdapter(cmd.CommandText, connection);
                if (P != null)
                {
                    foreach (var item in P)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(item.Parametro, item.Value);
                    }
                }
                adapter.Fill(dados);
                connection.Dispose();
                cmd.Dispose();
                adapter.Dispose();
                return dados;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool NewUser(User user)
        {
            if (ContainsUsername(user))
            {
                MessageBox.Show("UserName já existe");
                return false;
            }
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO Users 
                                (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) 
                                VALUES(@nome, @username, @senha, @status, @level)";
                cmd.Parameters.AddWithValue("@nome", user.Name);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@senha", user.Password);
                cmd.Parameters.AddWithValue("@status", user.Status);
                cmd.Parameters.AddWithValue("@level", user.Level);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo Usuário Inserido com sucesso!", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Dispose();
                cmd.Dispose();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private static bool ContainsUsername(User user)
        {
            SqlCeDataAdapter adapter = null;
            DataTable dados = new DataTable();
            var connection = ConexaoBanco();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM Users WHERE T_USERNAME = @username";
            adapter = new SqlCeDataAdapter(cmd.CommandText, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@username", user.UserName);
            adapter.Fill(dados);
            connection.Dispose();
            cmd.Dispose();
            adapter.Dispose();
            if (dados.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static DataTable GetAllUsersIdName()
        {
            SqlCeDataAdapter adapter = null;
            DataTable dados = new DataTable();
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as IdUser, T_NOMEUSUARIO as Nome FROM users";
                adapter = new SqlCeDataAdapter(cmd.CommandText, connection);
                adapter.Fill(dados);
                connection.Dispose();
                cmd.Dispose();
                adapter.Dispose();
                return dados;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static DataTable GetUserData(string id)
        {
            SqlCeDataAdapter adapter = null;
            DataTable dados = new DataTable();
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM users WHERE N_IDUSUARIO = @id";
                adapter = new SqlCeDataAdapter(cmd.CommandText, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                adapter.Fill(dados);
                connection.Dispose();
                cmd.Dispose();
                adapter.Dispose();
                return dados;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void UpdateUserData(User user)
        {
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"UPDATE Users SET T_NOMEUSUARIO = @nome, 
                                T_USERNAME = @username, 
                                T_SENHAUSUARIO = @password,
                                T_STATUSUSUARIO = @status, 
                                N_NIVELUSUARIO = @level WHERE N_IDUSUARIO = @id";
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@nome", user.Name);
                cmd.Parameters.AddWithValue("@id", user.IdUser);
                cmd.Parameters.AddWithValue("@level", user.Level);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@status", user.Status);
                cmd.ExecuteNonQuery();
                connection.Dispose();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void DeleteUserData(string id)
        {
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"DELETE FROM Users WHERE N_IDUSUARIO = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Dispose();
                cmd.Dispose();
                CompactDataBase();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void Crud(string query, List<SQLParametros> P = null)
        {
            try
            {
                var connection = ConexaoBanco();
                var cmd = connection.CreateCommand();
                cmd.CommandText = query;
                if (P != null)
                {
                    foreach (var item in P)
                    {
                        cmd.Parameters.AddWithValue(item.Parametro, item.Value);
                    }
                }
                cmd.ExecuteNonQuery();
                connection.Dispose();
                cmd.Dispose();
               // CompactDataBase();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void CompactDataBase()
        {
            SqlCeEngine engine = new SqlCeEngine();
            engine.LocalConnectionString = $@"Data source = {AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database\AcademyDb.sdf; Password = {passwordDB}";
            engine.Compact($@"Data source = {AppDomain.CurrentDomain.BaseDirectory.ToString()}\Database\AcademyDb.sdf; Password = {passwordDB}");
            engine.Dispose();
        }
    }

}
