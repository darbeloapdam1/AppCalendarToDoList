using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using AppCalendarToDoList.Model;


namespace AppCalendarToDoList.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;

        public SQLiteHelper(string path)
        {
            db = new SQLiteAsyncConnection(path);
            
        }
    }
}
