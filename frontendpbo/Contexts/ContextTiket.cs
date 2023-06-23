using frontendpbo.Models;
using Npgsql;


namespace frontendpbo.Contexts
{
    internal class ContextTiket
    {
        public List<Tiket> listTiket = new List<Tiket>() { };

        public List<Tiket> GetListTiket()
        {
            return listTiket;
        }
        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT tiket.id_tiket, tiket.nama_tiket, tiket.deskripsi_tiket, tiket.harga_tiket FROM tiket Order by id_tiket ";
                             

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listTiket.Clear();
                    while (reader.Read())

                    {
                        Tiket tiket = new Tiket();
                        tiket.id_tiket = (int)reader["id_tiket"];
                        tiket.nama_tiket = (string)reader["nama_tiket"];
                        tiket.deskripsi_tiket = (string)reader["deskripsi_tiket"];
                        tiket.harga_tiket = (int)reader["harga_tiket"];
                        //tiket.wisata_id = (int)reader["id_wisata"];
                        listTiket.Add(tiket);
                    }
                }
            }
            return isSuccess;
        }
        public List<Tiket> Search(string query, string column)
        {
            List<Tiket> searchResults = new List<Tiket>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM Tiket WHERE CAST(" + column + " AS VARCHAR) ILIKE @query";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Tiket tiket = new Tiket();
                        tiket.id_tiket = (int)reader["id_tiket"];
                        tiket.nama_tiket = (string)reader["nama_tiket"];
                        tiket.deskripsi_tiket = (string)reader["deskripsi_tiket"];
                        tiket.harga_tiket = (int)reader["harga_tiket"];
//                        tiket.wisata_id = (int)reader["wisata_id"];
                        searchResults.Add(tiket);
                    }
                }
            }
            return searchResults;
        }


        public int GetHargaTiketByRoda(int jumlahRoda)
        {
            int hargaTiket = 0;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT harga_tiket FROM Tiket WHERE deskripsi_tiket LIKE @deskripsi";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@deskripsi", "Kendaraan Roda " + jumlahRoda);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        hargaTiket = (int)reader["harga_tiket"];
                    }
                }
            }

            return hargaTiket;
        }
        
        public bool Insert(Tiket tiket)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
            {
                string sql = "INSERT INTO tiket (nama_tiket, deskripsi_tiket, harga_tiket) " +
                     "VALUES (:NamaTiket, :DeskripsiTiket, :HargaTiket)";
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":NamaTiket", tiket.nama_tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":DeskripsiTiket", tiket.deskripsi_tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":HargaTiket", tiket.harga_tiket));
                    //cmd.Parameters.Add(new NpgsqlParameter(":IDWisata", tiket.wisata_id));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.listTiket.Add(tiket);
                    }
                }
                MessageBox.Show("Telah Berhasil Menambah Data");
            }
            return isSuccess;
        }
        public bool Update(Tiket tiket)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
            {
                string sql = "UPDATE public.tiket SET nama_tiket = :NamaTiket, deskripsi_tiket = :DeskripsiTiket, harga_tiket = :HargaTiket \nWHERE id_tiket = :IDTIKET;";

                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":NamaTiket", tiket.nama_tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":DeskripsiTiket", tiket.deskripsi_tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":HargaTiket", tiket.harga_tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":IDTIKET", tiket.id_tiket));
                    cmd.CommandType = System.Data.CommandType.Text;
                    int JumlahData = cmd.ExecuteNonQuery();
                    if (JumlahData > 0)
                    {
                        isSuccess = true;
                        foreach (var temp in this.listTiket)
                        {
                            var t = temp as Tiket;
                            if (t != null && t.id_tiket.Equals(tiket.nama_tiket))
                            {
                                t.nama_tiket = tiket.nama_tiket;
                                t.deskripsi_tiket = tiket.deskripsi_tiket;
                                t.harga_tiket = tiket.harga_tiket;
                                t.id_tiket = tiket.id_tiket;
                                t.wisata_id = tiket.wisata_id;
                            }
                        }
                    }
                    MessageBox.Show("Sukses Mengupdate Data");
                }
                return isSuccess;
            }
        }

        public List<Tiket> ReadtoCard()
        {
            List<Tiket> listTiket = new List<Tiket>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM tiket";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Tiket tiket = new Tiket();
                        tiket.id_tiket = (int)reader["id_tiket"];
                        tiket.nama_tiket = (string)reader["nama_tiket"];
                        tiket.deskripsi_tiket = (string)reader["deskripsi_tiket"];
                        tiket.harga_tiket = (int)reader["harga_tiket"];
  //                      tiket.wisata_id = (int)reader["id_wisata"];
                        listTiket.Add(tiket);
                    }
                }
            }
            return listTiket;
        }

        public List<Wisata> GetNamaWisataList()
        {
            List<Wisata> namaWisataList = new List<Wisata>();
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT id_wisata, nama_wisata FROM objek_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Wisata wisata = new Wisata();
                        wisata.Id_Wisata = (int)reader["id_wisata"];
                        wisata.Nama_Wisata = (string)reader["nama_wisata"];
                        namaWisataList.Add(wisata);
                    }
                }
            }
            return namaWisataList;
        }
    }
}
