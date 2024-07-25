using AutoMapper;
//using Domain.Interfaces.QueryOptions;
//using Domain.Interfaces.QueryOptions;

using Microsoft.Data.SqlClient;

namespace Api.CrossCutting.Mappings
{
    public class QueryOptionsProfile : Profile
    {
        public QueryOptionsProfile()
        {
            CreateMap<QueryOptions, QueryOptionsInput>()
            //.ForMember(d => d.Paging.Page, f => f.MapFrom(src => src.Paging.Page))
            //.ForMember(d => d.Paging.PageSize, f => f.MapFrom(src => src.Paging.PageSize))
            //.ForMember(d => d.Paging,
            //opt => opt.MapFrom((src, dest) => dest.Paging = (IPagingInput)src.Paging));
            //opt => opt.MapFrom<PagingInput, Paging>(src => (Paging)src.Paging));
            //    .ForMember(dest => dest.Total,
            //opt => opt.MapFrom<CustomResolver, decimal>(src => src.SubTotal));
            //.ConstructUsing(ct => Map<)
            .ReverseMap();


            //CreateMap<IPaging, IPagingInput>().ReverseMap();

            CreateMap<QueryOptions, QueryOptionsOutput>()
                //.ForMember(d => d.Paging.Page, f => f.MapFrom(src => src.Paging.Page))
                //.ForMember(d => d.Paging.PageSize, f => f.MapFrom(src => src.Paging.PageSize))
                .ReverseMap();

            CreateMap<IQueryOptions, IQueryOptionsOutput>().ReverseMap();

            CreateMap<PagingInput, Paging>().ReverseMap();
        }

    }
}
