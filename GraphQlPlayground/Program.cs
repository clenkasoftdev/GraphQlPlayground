using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQlPlayground.Data;
using GraphQlPlayground.GraphQLs.Mutation;
using GraphQlPlayground.GraphQLs.Query;
using GraphQlPlayground.GraphQLs.Schema;
using GraphQlPlayground.GraphQLs.Type;
using GraphQlPlayground.Interfaces;
using GraphQlPlayground.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IMenuRepository, MenuRepository>();
builder.Services.AddTransient<MenuType>();
builder.Services.AddTransient<MenuInputType>();
builder.Services.AddTransient<MenuQuery>();
builder.Services.AddTransient<MenuMutation>();
builder.Services.AddTransient<ISchema,MenuSchema>();

builder.Services.AddGraphQL(o => o.AddAutoSchema<ISchema>().AddSystemTextJson());
builder.Services.AddDbContext<GraphQlPlaygroundDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseGraphiQl("/graphql");
app.UseGraphQL<ISchema>();

app.UseAuthorization();

app.MapControllers();

app.Run();
