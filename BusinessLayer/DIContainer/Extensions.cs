using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules.AnnouncementValidationRules;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.DIContainer
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();

            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();

            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }

        public static void DtoValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementAddValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateValidator>();
        }
    }
}
