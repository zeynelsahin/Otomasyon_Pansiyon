using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entity.Concreate.Entities;

namespace Business.Abstract
{
    public interface IOdaService
    {
        List<Oda> GetAll();
        List<Oda> GetAllByAktif();
        Oda GetOda(int id);
        void AddOda(Oda oda);
        void DeleteOda(Oda oda);
        void UpdateOda(Oda oda);

        void UpdateTutulanOda(Oda oda);
    }
}