using MySql.Data.MySqlClient;
using System.Data;
using Re_World.Models;


namespace Re_World.Repositorio
{
    public class LoginRepositorio(IConfiguration configuration)
    {

        private readonly string _conexaoMySQL = configuration.GetConnectionString("conexaoMySQL");


        public Usuarios ObterUsuario(string email)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();

                MySqlCommand cmd = new("SELECT * FROM Usuario where Email = @Email", conexao);
                cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = email;


                using (MySqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    Usuarios usuario = null;

                    if (dr.Read())
                    {
                        usuario = new Usuarios
                        {
                            Id = Convert.ToInt32(dr["Id"]),

                            Nome = dr["Nome"].ToString(),

                            Email = dr["Email"].ToString(),

                            Senha = dr["Senha"].ToString()

                        };

                    }
                    return usuario;
                }


            }


        }


    }
}
