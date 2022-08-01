using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zhaoxiFlower.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "My API",
                    Version = "v1",
                    Description = "API�ĵ�����",
                    Contact = new OpenApiContact
                    {
                        Email = "5007032@qq.com",
                        Name = "������Ŀ",
                        //Url = new Uri("http://t.abc.com/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "BROOKE���֤",
                        //Url = new Uri("http://t.abc.com/")
                    }
                });
            });

            //��ȡappsettings.json������Ϣ
            var config = new ConfigurationBuilder()
                            .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json")
                            .Build();
            //��ȡ����������������
            var alloweHosts = config["AllowedHosts"];
            //���ÿ�����
            services.AddCors(options =>
            {
                options.AddPolicy("cors", builder =>
                {
                    //��������Origin����
                    builder.WithOrigins(alloweHosts)
                    .AllowAnyOrigin()
                    //�����������󷽷�Get,Post,Put,Delete
                    .AllowAnyMethod()
                    //������������ͷ appliction/json
                    .AllowAnyHeader();
                    //ָ������cookie,�����.netcore 2.1��ʱ�����ã�������3.1���ò�����
                    //.AllowCredentials();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //���ÿ���,����������λ��
            app.UseCors("cors");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //����Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = "api";// �����Ϊ�գ�����·�����Ǹ�����/index.html������Ϊ�գ���ʾֱ���ڸ��������ʣ��뻻һ��·����ֱ��д���ּ��ɣ�����ֱ��дc.RoutePrefix = "swagger"; �����·��Ϊ ������/swagger/index.html

            });

        }
    }
}
