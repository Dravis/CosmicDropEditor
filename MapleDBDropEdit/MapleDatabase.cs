using MySql.Data.MySqlClient;
using System.Data;

namespace MapleDBDropEdit
{
    internal class MapleDatabase
    {
        MySqlConnection conn;

        public MapleDatabase()
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
        }

        public void Connect(string host, string port, string database, string user, string password)
        {
            string connectionString = $"server={host};port={port};uid={user};pwd={password};database={database}";
            try
            {            
                conn.ConnectionString = connectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool IsConnected() 
        {
            return conn.State == ConnectionState.Open;
        }

        public void CountDropEntries()
        {
            string query = "SELECT count(*) as drops FROM drop_data;";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access data from the reader, e.g., reader["column_name"]
                        MessageBox.Show($"Data: {reader["drops"]}");
                    }
                }
            }
        }

        public List<MobSummaryData> GetMobsSummaryData()
        {
            List<MobSummaryData> list = new List<MobSummaryData>();
            string query = "SELECT dropperid, count(distinct itemid) as dropCount FROM drop_data where questid = 0 group by dropperid;";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access data from the reader, e.g., reader["column_name"]
                        MobSummaryData mobData = new MobSummaryData(reader["dropperid"].ToString());
                        mobData.itemCount = reader["dropCount"].ToString();
                        list.Add(mobData);
                    }
                }
            }
            return list;
        }

        public List<MobSummaryData> GetGlobalDropsSummary()
        {
            List<MobSummaryData> list = new List<MobSummaryData>();
            string query = "SELECT 'Global' as dropperid, count(itemid) as dropCount FROM drop_data_global group by dropperid;";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access data from the reader, e.g., reader["column_name"]
                        MobSummaryData mobData = new MobSummaryData(reader["dropperid"].ToString());
                        mobData.itemCount = reader["dropCount"].ToString();
                        list.Add(mobData);
                    }
                }
            }
            return list;
        }

        public List<MobDropData> GetGlobalDrops()
        {
            List<MobDropData> list = new List<MobDropData>();
            string query = "SELECT id, continent, itemid, minimum_quantity, maximum_quantity, questid, chance FROM drop_data_global;";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access data from the reader, e.g., reader["column_name"]
                        MobDropData mobdropData = new MobDropData();
                        mobdropData.ID = (long)reader["id"];
                        mobdropData.MobId = 0;
                        mobdropData.ItemId = (int)reader["itemid"];
                        mobdropData.Continent = (bool)reader["continent"];
                        mobdropData.MinimumQuantity = (int)reader["minimum_quantity"];
                        mobdropData.MaximumQuantity = (int)reader["maximum_quantity"];
                        mobdropData.QuestId = (int)reader["questid"];
                        mobdropData.Chance = (int)reader["chance"];

                        list.Add(mobdropData);
                    }
                }
            }
            return list;
        }


        internal List<MobDropData> GetMobDropData(string mobId)
        {
            List<MobDropData> list = new List<MobDropData>();
            string query = $"SELECT id, dropperid, itemid, minimum_quantity, maximum_quantity, questid, chance FROM drop_data where dropperid = \"{mobId}\";";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Access data from the reader, e.g., reader["column_name"]
                        MobDropData mobdropData = new MobDropData();
                        mobdropData.ID = (long)reader["id"];
                        mobdropData.MobId = (int)reader["dropperid"];
                        mobdropData.ItemId = (int)reader["itemid"];
                        mobdropData.MinimumQuantity = (int)reader["minimum_quantity"];
                        mobdropData.MaximumQuantity = (int)reader["maximum_quantity"];
                        mobdropData.QuestId = (int)reader["questid"];
                        mobdropData.Chance = (int)reader["chance"];

                        list.Add(mobdropData);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Creates a new drop_data record and returns the generated ID.
        /// </summary>
        public long CreateDrop(MobDropData drop)
        {
            const string query = @"
            INSERT INTO drop_data (dropperid, itemid, minimum_quantity, maximum_quantity, questid, chance)
            VALUES (@MobId, @ItemId, @MinQty, @MaxQty, @QuestId, @Chance);
            SELECT LAST_INSERT_ID();";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@MobId", drop.MobId);
            cmd.Parameters.AddWithValue("@ItemId", drop.ItemId);
            cmd.Parameters.AddWithValue("@MinQty", drop.MinimumQuantity);
            cmd.Parameters.AddWithValue("@MaxQty", drop.MaximumQuantity);
            cmd.Parameters.AddWithValue("@QuestId", drop.QuestId);
            cmd.Parameters.AddWithValue("@Chance", drop.Chance);

            var result = cmd.ExecuteScalar();
            drop.ID = Convert.ToInt64(result);
            return drop.ID;
        }

        public long CreateGlobalDrop(MobDropData drop)
        {
            const string query = @"
            INSERT INTO drop_data_global (continent, itemid, minimum_quantity, maximum_quantity, questid, chance)
            VALUES (@Continent, @ItemId, @MinQty, @MaxQty, @QuestId, @Chance);
            SELECT LAST_INSERT_ID();";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Continent", drop.Continent);
            cmd.Parameters.AddWithValue("@ItemId", drop.ItemId);
            cmd.Parameters.AddWithValue("@MinQty", drop.MinimumQuantity);
            cmd.Parameters.AddWithValue("@MaxQty", drop.MaximumQuantity);
            cmd.Parameters.AddWithValue("@QuestId", drop.QuestId);
            cmd.Parameters.AddWithValue("@Chance", drop.Chance);

            var result = cmd.ExecuteScalar();
            drop.ID = Convert.ToInt64(result);
            return drop.ID;
        }

        /// <summary>
        /// Updates an existing drop_data record.
        /// </summary>
        public bool UpdateDrop(MobDropData drop)
        {
            const string query = @"
            UPDATE drop_data
            SET dropperid = @MobId,
                itemid = @ItemId,
                minimum_quantity = @MinQty,
                maximum_quantity = @MaxQty,
                questid = @QuestId,
                chance = @Chance
            WHERE id = @Id;";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", drop.ID);
            cmd.Parameters.AddWithValue("@MobId", drop.MobId);
            cmd.Parameters.AddWithValue("@ItemId", drop.ItemId);
            cmd.Parameters.AddWithValue("@MinQty", drop.MinimumQuantity);
            cmd.Parameters.AddWithValue("@MaxQty", drop.MaximumQuantity);
            cmd.Parameters.AddWithValue("@QuestId", drop.QuestId);
            cmd.Parameters.AddWithValue("@Chance", drop.Chance);

            int affected = cmd.ExecuteNonQuery();
            return affected > 0;
        }

        public bool UpdateGlobalDrop(MobDropData drop)
        {
            const string query = @"
            UPDATE drop_data_global
            SET continent = @Continent,
                itemid = @ItemId,
                minimum_quantity = @MinQty,
                maximum_quantity = @MaxQty,
                questid = @QuestId,
                chance = @Chance
            WHERE id = @Id;";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@Id", drop.ID);
            cmd.Parameters.AddWithValue("@Continent", drop.Continent);
            cmd.Parameters.AddWithValue("@ItemId", drop.ItemId);
            cmd.Parameters.AddWithValue("@MinQty", drop.MinimumQuantity);
            cmd.Parameters.AddWithValue("@MaxQty", drop.MaximumQuantity);
            cmd.Parameters.AddWithValue("@QuestId", drop.QuestId);
            cmd.Parameters.AddWithValue("@Chance", drop.Chance);

            int affected = cmd.ExecuteNonQuery();
            return affected > 0;
        }

        /// <summary>
        /// Deletes a drop_data record by ID.
        /// </summary>
        public bool DeleteDrop(long id)
        {
            const string query = "DELETE FROM drop_data WHERE id = @Id;";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            int affected = cmd.ExecuteNonQuery();
            return affected > 0;
        }

        public bool DeleteGlobalDrop(long id)
        {
            const string query = "DELETE FROM drop_data_global WHERE id = @Id;";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);

            int affected = cmd.ExecuteNonQuery();
            return affected > 0;
        }
    }
}
