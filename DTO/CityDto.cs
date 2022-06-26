using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CityDto
    {
        public int id_city { get; set; }
        public string name_city { get; set; }
        public CityDto()
        {

        }
        public CityDto(int id_city, string name_city)
        {
            this.id_city = id_city;
            this.name_city = name_city;
        }

        public city convertTocity()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<CityDto, city>());
            var mapper = new Mapper(config);
            return mapper.Map<city>(this);
        }
        public static CityDto convertTocity_dto(city s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<city, CityDto>());
            var mapper = new Mapper(config);
            return mapper.Map<CityDto>(s);
        }
    }
}
