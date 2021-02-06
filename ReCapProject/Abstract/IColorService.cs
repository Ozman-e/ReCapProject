using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        void Updated(Color color);
        void Delete(Color color);

        List<Color> GetAll();

        Color GetByColorId(string id);
    }
}
