using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bookshelf
{
    internal class DbHelper
    {
        //internal static string pathDB = Path.Combine(Application.StartupPath, "dbase.db");
        internal static string pathDB = "dbase.db";

        internal static void CreateDB()
        {
            SQLiteConnection.CreateFile(pathDB);

            using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))

            {
                using (SQLiteCommand cmd = new SQLiteCommand(@"CREATE TABLE TB_BOOKS (  Id	INTEGER NOT NULL UNIQUE,
	                                                                                    Author	TEXT,
	                                                                                    Title	TEXT,
	                                                                                    FileName	TEXT,
	                                                                                    FileData	BLOB,
	                                                                                    PRIMARY KEY(Id AUTOINCREMENT));", con))
                {
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show($"Создан файл бд в {pathDB}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }

                }
            }
        }

        internal static List<Books> GetBooks()
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
            try
            {
                List<Books> books = new List<Books>();
                using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT Id, Author, Title, FileName FROM TB_BOOKS;", con))
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            
                            while (rdr.Read())
                            {
                                var id = rdr.GetInt32(0);
                                var author = rdr.GetString(1);
                                var title = rdr.GetString(2);
                                var filename = rdr.GetString(3);

                                Books bk = new Books(id, author, title, filename);
                                books.Add(bk);

                            }
                            return books;
                        }
                    }

                }


            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
}
