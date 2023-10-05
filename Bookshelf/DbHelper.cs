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

        internal static List<Book> GetBooks()
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
            try
            {
                List<Book> books = new List<Book>();
                using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
                {
                    con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT Id, Author, Title, FileName, FileData FROM TB_BOOKS;", con))
                    {
                        using (var rdr = cmd.ExecuteReader())
                        {
                            
                            while (rdr.Read())
                            {
                                var id = rdr.GetInt32(0);
                                var author = rdr.GetString(1);
                                var title = rdr.GetString(2);
                                var filename = rdr.GetString(3);
                                //byte[] filedata = (byte[])rdr.GetValue(4);

                                Book bk = new Book { Id=id, Author=author, Title = title, FileName = filename };
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
                return new List<Book>();
            }
        }

        //internal static void AddBooks(string author, string title, string filename, byte[] filedata)
            internal static void AddBooks(Book book)
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
            try
            {
                List<Book> books = new List<Book>();
                using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"INSERT INTO TB_BOOKS (Author, Title, FileName)
                                                    VALUES (@Author, @Title, @FileName)";
                    cmd.Parameters.Add(new SQLiteParameter("@Author", book.Author));
                    cmd.Parameters.Add(new SQLiteParameter("@Title", book.Title));
                    cmd.Parameters.Add(new SQLiteParameter("@FileName", book.FileName));
                    //cmd.Parameters.Add(new SQLiteParameter("@FileData", book.FileData));
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Добавлено записей: " + number.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        internal static void DelBooks(int id)
        {
            //if (!File.Exists(pathDB)) 
            //{
            //CreateDB();
            //}
            try
            {
                List<Book> books = new List<Book>();
                using (SQLiteConnection con = new SQLiteConnection(string.Format($"Data source={pathDB};")))
                {
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"DELETE FROM TB_BOOKS WHERE ID=@Id";
                    cmd.Parameters.Add(new SQLiteParameter("@Id", id));
                    int number = cmd.ExecuteNonQuery();
                    MessageBox.Show("Удалено записей: " + number.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

    }
}
