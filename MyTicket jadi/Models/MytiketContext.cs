using MyTicket_jadi.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTicket_jadi.Models
{
    internal class MytiketContext
    {
        public List<MyTiket> TiketList = new List<MyTiket>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = " Host=localhost;Port=5432;Database= Data Wisata;Username=postgres;Password=Memew001";

            using(NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                string sql =
                    @"SELECT * FROM wisata";
                      //JOIN wisata ON transaksi.id_wisata = wisata.id_wisata
                      //JOIN tiket ON trasaksi.id_tiket = tiket.id_tiket";

                conn.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand(sql,conn);
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader Reader = cmd.ExecuteReader();
                    TiketList.Clear();
                    while (Reader.Read())
                    {
                        MyTiket newTiket = new MyTiket();

                        newTiket.nama_wisata = (string)Reader["nama_wisata"];
                        newTiket.alamat_wisata = (string)Reader["alamat_wisata"];
                        newTiket.harga_tiket = (string)Reader["deskripsi_wisata"];
                        newTiket.kuatitas = (string)Reader["id_wisata"];

                        TiketList.Add(newTiket);
                    }
                }
            }
            return isSuccess;
        }
    }
}
