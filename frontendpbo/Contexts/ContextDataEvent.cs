using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextDataEvent
    {
        public List<Event> listDataEvent = new List<Event>() { };
        public bool Readdata()
        {
            bool isSucces = false; //mengapa false? jika salah akan membaca file selanjutnya
            string connec = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(connec))
            {
                string sql = @"SELECT * FROM event_acara;";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listDataEvent.Clear();
                    while (reader.Read())
                    {
                        Event newDataEvent = new Event();

                        newDataEvent.Id = (int)reader["id_event"];
                        newDataEvent.Nama = (string)reader["nama_event"];
                        newDataEvent.Deskripsi = (string)reader["deskripsi_event"];
                        newDataEvent.Tanggal_Event = DateOnly.FromDateTime((DateTime)reader["tanggal_event"]);
                        newDataEvent.Wisata_ID = (int)reader["wisata_id"];

                        listDataEvent.Add(newDataEvent);


                    }


                }


            }
            return isSucces;


        }
        public List<Event> GetListDataEvent()
        {
            return listDataEvent;
        }

        public bool insert(Event dataEvent)
        {
            bool isSucces = false;
            string connec = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=peta_jember";
            using (NpgsqlConnection conn = new NpgsqlConnection(connec))
            {
                string sql = @"INSERT INTO public.event_acara(id_event, nama_event, deskripsi_event, tanggal_event, wisata_id)
	                              VALUES (:id_event,:nama_event,:deskripsi_event, :tanggal_event, :wisata_id);";
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":id_event", dataEvent.Id));
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_event", dataEvent.Nama));
                    cmd.Parameters.Add(new NpgsqlParameter(":deskripsi_event", dataEvent.Deskripsi));
                    cmd.Parameters.Add(new NpgsqlParameter(":tanggal_event", dataEvent.Tanggal_Event));
                    cmd.Parameters.Add(new NpgsqlParameter(":wisata_id", dataEvent.Wisata_ID));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmldata = cmd.ExecuteNonQuery();
                    if (jmldata > 0)
                    {
                        isSucces = true;
                        this.listDataEvent.Add(dataEvent);
                        MessageBox.Show("Success");




                    }



                }


            }
            return isSucces = Readdata();
        }
        public bool Update(Event dataEvent)
        {
            bool isSucces = false;
            string connec = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(connec))
            {

                string sql = @"UPDATE event_acara SET nama_event = :nama_event, deskripsi_event = :deskripsi_event, wisata_id = :wisata_id WHERE id_Event = :id_Event;";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue(":nama_event", dataEvent.Nama);
                    cmd.Parameters.AddWithValue(":deskripsi_event", dataEvent.Deskripsi);
                    cmd.Parameters.AddWithValue(":wisata_id", dataEvent.Wisata_ID);
                    cmd.Parameters.AddWithValue(":id_Event", dataEvent.Id);

                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listDataEvent.Clear();
                    while (reader.Read())
                    {
                        Event dataevent = new Event();
                        dataEvent.Id = (int)reader["id_event"];
                        dataEvent.Nama = (string)reader["nama_event"];
                        dataEvent.Deskripsi = (string)reader["deskripsi_event"];
                        dataEvent.Tanggal_Event = DateOnly.FromDateTime((DateTime)reader["tanggal_event"]);
                        dataEvent.Wisata_ID = (int)reader["wisata_id"];

                        int jmldata = cmd.ExecuteNonQuery();
                        listDataEvent.Add(dataEvent);
                        if (jmldata > 0)
                        {
                            isSucces = true;
                            MessageBox.Show("Success");
                            Readdata();
                        }


                    }
                }


            }
            return isSucces = Readdata();
        }
        public void setDataEvent(Event dataEvent)
        {


        }
        public bool deleted(Event dataEvent)
        {
            bool isSucces = false;
            string connec = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=peta_jember";
            using (NpgsqlConnection conn = new NpgsqlConnection(connec))
            {
                string sql = @"DELETE FROM event_acara WHERE id_event = :id_event;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue(":id_event", dataEvent.Id);
                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmldata = cmd.ExecuteNonQuery();
                    if (jmldata > 0)
                    {
                        isSucces = true;
                        var itemToRemove = listDataEvent.Single(rec => rec.Id == dataEvent.Id);
                        listDataEvent.Remove(itemToRemove);
                    }


                }
                MessageBox.Show("Success");




            }
            return isSucces = Readdata();

        }
        public List<Event> Search(string query)
        {
            List<Event> searchResults = new List<Event>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM event_acara WHERE nama_event ILIKE @query OR  deskripsi_event ILIKE @query";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Event even = new Event();
                        even.Id = (int)reader["id_event"];
                        even.Nama = (string)reader["nama_event"];
                        even.Deskripsi = (string)reader["deskripsi_event"];
                        even.Tanggal_Event = DateOnly.FromDateTime((DateTime)reader["tanggal_event"]);
                        even.Wisata_ID = (int)reader["wisata_id"];
                        searchResults.Add(even);
                    }
                }
            }
            return searchResults;
        }
    }
}
