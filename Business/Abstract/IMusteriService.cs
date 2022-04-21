using System.Collections.Generic;
using Entity.Concreate.Entities;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        List<Musteri> GetAll();
        void AddMusteri(Musteri musteri);
        void DeleteMusteri(Musteri musteri);
        void UpdateMusteri(Musteri musteri);
    }
}