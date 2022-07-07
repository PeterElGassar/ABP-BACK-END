using Acme.Palmera.Books;
using AutoMapper;

namespace Acme.Palmera;

public class PalmeraApplicationAutoMapperProfile : Profile
{
    public PalmeraApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>().ReverseMap();
        CreateMap<CreateUpdateBookDto, Book>().ReverseMap();
    }
}
