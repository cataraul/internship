﻿using AutoMapper;
using Tweetbook.Contracts.V1.Requests.Queries;
using TweetBook.Domain;

namespace TweetBook.Mapping
{
    public class RequestToDomainProfile : Profile
    {
        public RequestToDomainProfile()
        {
            CreateMap<PaginationQuery, PaginationFilter>();
            CreateMap<GetAllPostsQuery, GetAllPostsFilter>();
        }
    }
}
