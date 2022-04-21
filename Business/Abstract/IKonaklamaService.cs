using System;
using System.Collections.Generic;
using Entity.Concreate.Entities;

namespace Business.Abstract
{
    public interface IKonaklamaService
    {
        List<Konaklama> GetAll();
        List<Konaklama> GetKonaklamaMusteriId(int musteriId);     // Yarı ingilizce yarı türkçe oldu :) 
        List<Konaklama> GetKonaklamaByGirisTarihi(DateTime girisTarihi);
        Konaklama GetKonaklama(int id);

        void AddKonaklama(Konaklama konaklama);
        void DeleteKonaklama(Konaklama konaklama);
        void UpdateKonaklama(Konaklama konaklama);

    }
}