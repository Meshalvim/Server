using AutoMapper;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CandidaleDto
    {
        public int id_candidate { get; set; }
        public string Id_number { get; set; }
        public string name_ { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int id_city { get; set; }
        public int id_gender { get; set; }
        public int age { get; set; }
        public double seniority { get; set; }
        public int price { get; set; }
        public string password_ { get; set; }

        public CandidaleDto(int id_candidate, string Id_number, string name_, string phone, string email, int id_city, int id_gender, int age, double seniority, int price, string password_)
        {
            this.id_candidate = id_candidate;
            this.Id_number = Id_number;
            this.name_ = name_;
            this.phone = phone;
            this.email = email;
            this.id_city = id_city;
            this.id_gender = id_gender;
            this.age = age;
            this.seniority = seniority;
            this.price = price;
            this.password_ = password_;
        }

        public candidate convertTocandidates()
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<CandidaleDto, candidate>());
            var mapper = new Mapper(config);
            return mapper.Map<candidate>(this);
        }
        public static CandidaleDto convertTocandidate_dto(candidate s)
        {
            var config = new MapperConfiguration(cfg =>
              cfg.CreateMap<candidate, CandidaleDto>());
            var mapper = new Mapper(config);
            return mapper.Map<CandidaleDto>(s);
        }
    }
}
