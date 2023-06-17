using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTicket_jadi.Models
{

    internal class DetailTiketContext
    {
        public List<Detailtiket> listDetail = new List<Detailtiket>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = " Host=localhost;Port=5432;Database= Data Wisata;Username=postgres;Password=Memew001";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                string sql =
                    @"SELECT * FROM wisata WHERE id_wisata = 'A01'";
                //JOIN wisata ON transaksi.id_wisata = wisata.id_wisata
                //JOIN tiket ON trasaksi.id_tiket = tiket.id_tiket";
                conn.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader Reader = cmd.ExecuteReader();
                    listDetail.Clear();
                    while (Reader.Read())
                    {
                        Detailtiket detailTiket = new Detailtiket();

                        detailTiket.nama_wisata = (string)Reader["nama_wisata"];
                        detailTiket.harga_tiket = (string)Reader["Id_wisata"];
                        detailTiket.deskripsi = (string)Reader["deskripsi_wisata"];


                        listDetail.Add(detailTiket);
                    }
                }
            }
            return isSuccess;
        }
    }
}
