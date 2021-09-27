using System;
using System.Collections.Generic;
using cadastroSeries.Interfaces;

namespace cadastroSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Delete(int id)
        {
            listaSerie[id].SetExcluido();
        }

        public Serie GetById(int id)
        {
            if (id > listaSerie.Count) 
            {
                return null;
            }

            return listaSerie[id];
        }

        public void Insert(Serie entidade)
        {
            listaSerie.Add(entidade);
        }

        public int NextId()
        {
            return listaSerie.Count;
        }

        public List<Serie> Show()
        {
            return listaSerie;
        }

        public void Update(int id, Serie entidade)
        {
            listaSerie[id] = entidade;
        }
    }
}