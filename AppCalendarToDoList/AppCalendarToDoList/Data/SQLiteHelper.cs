using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using AppCalendarToDoList.Model;
using System.Threading.Tasks;

namespace AppCalendarToDoList.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;

        public SQLiteHelper(string path)
        {
            db = new SQLiteAsyncConnection(path);            
            db.CreateTableAsync<Evento>().Wait();
            db.CreateTableAsync<Tarea>().Wait();
        }

        public Task<int> saveEventoAsync(Evento evento)
        {
            return db.InsertAsync(evento);
        }
        public Task<int> saveTareaAsync(Tarea tarea)
        {
            return db.InsertAsync(tarea);
        }

        public Task<List<Evento>> getEventosAsync(DateTime dia)
        {
            return db.QueryAsync<Evento>("SELECT * FROM EVENTO WHERE DAY(diaHoraInicio) == " + dia.Day + " AND MONTH(diaHoraInicio) == " + dia.Month);
        }

        public Task<List<Evento>> getEventosAsync()
        {
            return db.QueryAsync<Evento>("SELECT * FROM EVENTO");
        }

        public Task<List<Tarea>> getTareasAsync()
        {
            return db.QueryAsync<Tarea>("SELECT * FROM TAREA WHERE COMPLETADO == 0");
        }

        public Task<int> deleteEventoAsync(Evento evento)
        {
            return db.DeleteAsync(evento);
        }
        public Task<int> deleteTareaAsync(Tarea tarea)
        {
            return db.DeleteAsync(tarea);
        }



    }
}
