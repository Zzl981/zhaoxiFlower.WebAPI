using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zhaoxiFlower.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public List<OrderModel> GetOrders()
        {
            List<OrderModel> orders = new List<OrderModel>() {
                new OrderModel { OrderDate="2022-07-30 11:12:28",OrderNumber="20220730111228200",Price=200,Title="韩式系列/公主的假日"},
                new OrderModel { OrderDate="2022-07-29 17:13:25",OrderNumber="20220729171325201",Price=201,Title="韩式系列/公主的假日"},
                new OrderModel { OrderDate="2022-07-28 04:04:38",OrderNumber="20220728040438202",Price=202,Title="韩式系列/公主的假日"},
                new OrderModel { OrderDate="2022-07-27 13:17:15",OrderNumber="20220727131715203",Price=203,Title="韩式系列/公主的假日"},
                new OrderModel { OrderDate="2022-07-26 22:05:39",OrderNumber="20220726220539204",Price=204,Title="韩式系列/公主的假日"},
                new OrderModel { OrderDate="2022-07-25 19:11:20",OrderNumber="20220725191120205",Price=205,Title="韩式系列/公主的假日"},
            };
            return orders;
        }
    }
}
