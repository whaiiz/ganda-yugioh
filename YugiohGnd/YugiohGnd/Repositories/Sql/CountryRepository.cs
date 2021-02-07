using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using YugiohGnd.Models;
using YugiohGnd.Models.Dtos;

namespace YugiohGnd.Repositories.Sql
{
    public class CountryRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IMapper _mapper;

        public CountryRepository(AppDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<CountryDto> Get()
        {
            var countries = _dbContext.Countries.ToList();
            return _mapper.Map<List<Country>, List<CountryDto>>(countries);
        }
    }
}
