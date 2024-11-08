using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_232410101045_utspbo.core;
using A_232410101045_utspbo.model;
using Npgsql;

namespace A_232410101045_utspbo.context
{
    internal class LoginakunContext : Datawrapper
    {

        public LoginAkun Validate(string username, string password)
        {
            LoginAkun loginAkun = null;
            string query = "SELECT * FROM akun WHERE username = @username AND psword = @password";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@username", username),
            new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    loginAkun = new LoginAkun(username, password);
                    loginAkun.Username = (string)reader["username"];
                    loginAkun.Password = (string)reader["psword"];

                };
            return loginAkun;


        }
    }
}
