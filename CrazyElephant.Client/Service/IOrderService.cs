using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyElephant.Client.Service
{
    /// <summary>
    /// 生成菜单
    /// </summary>
    interface IOrderService
    {
        void PlaceOrder(List<string> dishes);
    }
}
