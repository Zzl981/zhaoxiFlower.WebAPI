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
    public class FlowersController : ControllerBase
    {
        [HttpGet]
        public List<Flowers> GetLoveFlowers()
        {
            List<Flowers> flowers = new List<Flowers>() {
                 #region 爱情鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=200
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=1 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=201
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1 
                ,Id=2 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=202
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=3 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a4.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=203
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=4 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a5.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=204
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=5 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a6.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=205
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=6 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a7.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=206
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=7 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a8.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=207
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=1
                ,Id=8 },
	            #endregion
            };
            return flowers;
        }

        [HttpGet]
        public List<Flowers> GetBirthdayFlowers()
        {
            List<Flowers> flowers = new List<Flowers>() {
                 #region 生日鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=300
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=9 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=301
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=10 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=302
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=11 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s4.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=303
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=12 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s5.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=304
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=13 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s6.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=305
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=14 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s7.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=306
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=15 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s8.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=307
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=2
                ,Id=16 },
	            #endregion
            };
            return flowers;
        }

        [HttpGet]
        public List<Flowers> GetFriendFlowers()
        {
            List<Flowers> flowers = new List<Flowers>() {
                 #region 友情鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=100
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=17 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=101
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=18 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=102
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=19 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y4.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=103
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=20 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y5.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=104
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=21 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y6.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=105
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=22 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y7.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=106
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=23 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y8.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=107
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=3
                ,Id=24 },
	            #endregion
            };
            return flowers;
        }

        [HttpGet]
        public List<Flowers> GetWeddingFlowers()
        {
            List<Flowers> flowers = new List<Flowers>() {
                 #region 婚庆鲜花
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=500
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=25 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=501
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=26 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y1.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=502
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=27 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=503
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=28 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=504
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=29 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/y2.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=505
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=30 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/a3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=506
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=31 },
                new Flowers(){ Title ="韩式系列/公主的假日"
                ,Image="/images/content/s3.jpg"
                ,BigImage="/images/detail/202004091613483166.jpg"
                ,Description="[甜美的公主，今夜你最美]粉玫瑰11枝、白色洋桔梗5枝、大叶尤加利10枝"
                ,Price=507
                ,Language="娇羞的粉色戴安娜玫瑰与清新的白色洋桔梗，经过花艺师之手赋予了爱的意义，将这份藏于心底的爱，包裹在粉色中幸会，今晚你好吗？今夜的美妙愿你永远记住，你是我心中最甜美的公主!"
                ,Material="韩式花束系列：戴安娜粉玫瑰11枝、3头或以上白色洋桔梗5枝、大叶尤加利10枝"
                ,Packing="嫣粉/玫粉色欧雅纸6张、白色OPP雾面纸3张、樱花粉色罗纹烫金丝带2米"
                ,DeliveryRemarks="江浙沪包邮，偏远地区除外，小城市请提前一天预定"
                ,Type=4
                ,Id=32 },
	            #endregion
            };
            return flowers;
        }
    }
}
