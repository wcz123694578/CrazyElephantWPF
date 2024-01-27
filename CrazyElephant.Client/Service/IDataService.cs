using CrazyElephant.Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyElephant.Client.Service
{
    interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}
