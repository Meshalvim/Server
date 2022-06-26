using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CompanyDto
    {
        public int      id_company { get; set; }
        public string name_company { get; set; }
        public string password_company { get; set; }

        public CompanyDto(int id_company, string name_company, string password_company)
        {
            this.id_company = id_company;
            this.name_company = name_company;
            this.password_company = password_company;
        }

        public company convertTocompany()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<CompanyDto, company>());
            var mapper = new Mapper(config);
            return mapper.Map<company>(this);
        }
        public static CompanyDto convertTocompany_dto(company c)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<company, CompanyDto>());
            var mapper = new Mapper(config);
            return mapper.Map<CompanyDto>(c);
        }
    }
}
