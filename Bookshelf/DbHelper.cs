﻿using System;
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
                                byte[] filedata = (byte[])rdr.GetValue(4);

                                Books bk = new Books(id, author, title, filename, filedata);
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
                return new List<Books>();
            }
        }

        internal static void AddBooks(string author, string title, string filename, byte[] filedata)
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
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = con;
                    cmd.CommandText = @"INSERT INTO TB_BOOKS (Author, Title, FileName, FileData)
                                                    VALUES (@Author, @Title, @FileName, @FileData)";
                    cmd.Parameters.Add(new SQLiteParameter("@Author", author));
                    cmd.Parameters.Add(new SQLiteParameter("@Title", title));
                    cmd.Parameters.Add(new SQLiteParameter("@FileName", filename));
                    cmd.Parameters.Add(new SQLiteParameter("@FileData", filedata));
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
                List<Books> books = new List<Books>();
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