using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CompaniesDto
    {
        public int id_company { get; set; }
        public string name_company { get; set; }

        public CompaniesDto(int id_company, string name_company)
        {
            this.id_company = id_company;
            this.name_company = name_company;
        }

        public company convertTocompany()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<CompaniesDto, company>());
            var mapper = new Mapper(config);
            return mapper.Map<company>(this);
        }
        public static CompaniesDto convertTocompany_dto(company c)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<company, CompaniesDto>());
            var mapper = new Mapper(config);
            return mapper.Map<CompaniesDto>(c);
        }
    }
}
