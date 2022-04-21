using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concreate.Entities;

namespace Business.Concreate
{
    public class KonaklamaManager:IKonaklamaService
    {
        private IKonaklamaDal _konaklamaDal;

        public KonaklamaManager(IKonaklamaDal konaklamaDal)
        {
            _konaklamaDal = konaklamaDal;
        }

        public List<Konaklama> GetAll()
        {
            return _konaklamaDal.GetAll();
        }

        public List<Konaklama> GetKonaklamaMusteriId(int musteriId)
        {
            return _konaklamaDal.GetAll(konaklama => konaklama.MusteriID==musteriId);
        }

    
        public List<Konaklama> GetKonaklamaByGirisTarihi(DateTime girisTarihi)
        {
            return _konaklamaDal.GetAll(konaklama => konaklama.GirisTarihi == girisTarihi);
        }

        public Konaklama GetKonaklama(int id)
        {
            return _konaklamaDal.Get(p=> p.ID==id);
        }

        public void AddKonaklama(Konaklama konaklama)
        {
           _konaklamaDal.Add(konaklama);
        }

        public void DeleteKonaklama(Konaklama konaklama)
        {
            _konaklamaDal.Delete(konaklama);
        }

        public void UpdateKonaklama(Konaklama konaklama)
        {
            _konaklamaDal.Update(konaklama);
        }

      
    }
}