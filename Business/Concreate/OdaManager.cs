using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concreate.Entities;

namespace Business.Concreate
{
    public class OdaManager:IOdaService
    {
        private IOdaDal _odaDal;

        public OdaManager(IOdaDal odaDal)
        {
            _odaDal = odaDal;
        }

        public List<Oda> GetAll()
        {
            return _odaDal.GetAll();
        }

        public List<Oda> GetAllByAktif()
        {
            return _odaDal.GetAll(oda => oda.MusaitMi==true);
        }

        public Oda GetOda(int id)
        {
            return _odaDal.Get(p=>p.ID==id);
        }

        public void AddOda(Oda oda)
        {
           _odaDal.Add(oda);
        }

        public void DeleteOda(Oda oda)
        {
            _odaDal.Delete(oda);
        }

        public void UpdateOda(Oda oda)
        {
            _odaDal.Update(oda);
        }

        public void UpdateTutulanOda(Oda oda)
        {

            _odaDal.UpdateColumn(oda, new Expression<Func<Oda, object>>[] { p => p.MusaitMi });
        }
    }
}