using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using A_232410101045_utspbo.core;
using A_232410101045_utspbo.model;
using Npgsql;

namespace A_232410101045_utspbo.context
{
    internal class Kontakconext : Datawrapper
    {
        private static string table = "Kontak";

        public static DataTable All()
        {
            string query = @"
        SELECT 
            id,
            nama,
            email,
            nohp
        FROM 
            Kontak";

            DataTable dataMahasiswa = queryExecutor(query);
            return dataMahasiswa;
        }

        public static DataTable getKontakById(int id)
        {
            string query = @"
        SELECT 
            id,
            nama,
            email,
            nohp
        FROM 
            Kontak";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataKontak = queryExecutor(query, parameters);
            return dataKontak;
        }


        public static void AddKontak(KontakModel kontakbaru)
        {
            string query = $"INSERT INTO {table} (nama, email, nohp) VALUES(@nama, @email, @nohp)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", kontakbaru.nama),
                new NpgsqlParameter("@email", kontakbaru.email),
                new NpgsqlParameter("@nohp", kontakbaru.nohp),
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateMahasiswa(KontakModel kontakbaru)
        {
            string query = $"UPDATE {table} SET nama = @nama, email = @email, nohp = @nohp WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", kontakbaru.nama),
                new NpgsqlParameter("@email", kontakbaru.email),
                new NpgsqlParameter("@nohp", kontakbaru.nohp),
                new NpgsqlParameter("@id", kontakbaru.id)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteKontak(int id)
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
