using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using CampusMart_Backend.Infra.Common;
using CampusMart_Backend.Infra.Repository;
using CampusMart_Backend.Infra.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbContext, DbContext>();

builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<ICampusConsumerRepository, CampusConsumerRepository>();
builder.Services.AddScoped<ICampusConsumerService, CampusConsumerService>();
builder.Services.AddScoped<ICampusServiceProviderRepository, CampusServiceProviderRepository>();
builder.Services.AddScoped<ICampusServiceProviderService, CampusServiceProviderService>();
builder.Services.AddScoped<ISpecialRequestRepository, SpecialRequestRepository>();
builder.Services.AddScoped<ISpecialRequestService, SpecialRequestService>();
builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
builder.Services.AddScoped<IContactUsService, ContactUsService>();
builder.Services.AddScoped<IMerchandiseRepository, MerchandiseRepository>();
builder.Services.AddScoped<IMerchandiseService, MerchandiseService>();

builder.Services.AddScoped<IOrdersRepository, OrdersRepository>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ICartRepository, CartRepository>();
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<ITestimonialPageRepository, TestimonialPageRepository>();
builder.Services.AddScoped<ITestimonialPageService, TestimonialPageService>();
builder.Services.AddScoped<IStoreReviewRepository, StoreReviewRepository>();
builder.Services.AddScoped<IStoreReviewService, StoreReviewService>();
builder.Services.AddScoped<IMerchandiseReviewRepository, MerchandiseReviewRepository>();
builder.Services.AddScoped<IMerchandiseReviewService, MerchandiseReviewService>();

builder.Services.AddScoped<IAboutUsPageRepository, AboutUsPageRepository>();
builder.Services.AddScoped<IAboutUsPageService, AboutUsPageService>();
builder.Services.AddScoped<IContactUsPageRepository, ContactUsPageRepository>();
builder.Services.AddScoped<IContactUsPageService, ContactUsPageService>();
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>();
builder.Services.AddScoped<ITestimonialService, TestimonialService>();
builder.Services.AddScoped<IStoreRepository, StoreRepository>();
builder.Services.AddScoped<IStoreService, StoreService>();
builder.Services.AddScoped<IBankRepository, BankRepository>();
builder.Services.AddScoped<IBankService, BankService>();
builder.Services.AddScoped<IHomePageRepository, HomePageRepository>();
builder.Services.AddScoped<IHomePageService, HomePageService>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();

// CORS Configuration
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.WithOrigins("http://localhost:4200")
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowOrigin"); // Enable CORS

app.UseAuthorization();

app.MapControllers();

app.Run();