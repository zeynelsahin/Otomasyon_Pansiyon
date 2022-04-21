using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concreate.Entities;

namespace Business.Concreate
{
    public class MusteriManager:IMusteriService
    {
        private IMusteriDal _musteriDal;

        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }

        public List<Musteri> GetAll()
        {
           return _musteriDal.GetAll();
        }

        public void AddMusteri(Musteri musteri)
        {
            _musteriDal.Add(musteri);
        }

        public void DeleteMusteri(Musteri musteri)
        {
            _musteriDal.Delete(musteri);
        }

        public void UpdateMusteri(Musteri musteri)
        {
            _musteriDal.Update(musteri);
        }
    }
}