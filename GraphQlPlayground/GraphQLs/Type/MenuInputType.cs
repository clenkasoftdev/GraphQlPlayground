﻿using GraphQL.Types;

namespace GraphQlPlayground.GraphQLs.Type
{
    public class MenuInputType : InputObjectGraphType
    {
        public MenuInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<StringGraphType>("description");
            Field<FloatGraphType>("price");
            Field<IntGraphType>("categoryId");
            Field<StringGraphType>("imageUrl");
        }
    }
}
