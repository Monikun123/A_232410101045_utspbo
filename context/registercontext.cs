using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_232410101045_utspbo.core;
using A_232410101045_utspbo.model;
using Npgsql;

namespace A_232410101045_utspbo.context
{
    internal class registercontext : Datawrapper
    {
        private static string table = "akun";
        public static DataTable All()
        {
            string query = @"
        SELECT 
username,psword from akun";

            DataTable dataakun = queryExecutor(query);
            return dataakun;
        }
        public static DataTable getMahasiswaById(int id)
        {
            string query = @"
        SELECT 
username,psword from akun";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataMahasiswa = queryExecutor(query, parameters);
            return dataMahasiswa;
        }


        public static void AddAkun(LoginAkun akunbaru)
        {
            string query = $"INSERT INTO {table} (username, psword) VALUES(@username, @password)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", akunbaru.Username),
                new NpgsqlParameter("@password", akunbaru.Password),
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateMahasiswa(LoginAkun akunbaru)
        {
            string query = $"UPDATE {table} SET username = @username, psword = @password WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", akunbaru.Username),
                new NpgsqlParameter("@password", akunbaru.Password),
                new NpgsqlParameter("@id", akunbaru.id)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteMahasiswa(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
