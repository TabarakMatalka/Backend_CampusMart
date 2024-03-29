using CampusMart_Backend.Core.Common;
using CampusMart_Backend.Core.Repository;
using CampusMart_Backend.Core.Service;
using CampusMart_Backend.Infra.Common;
using CampusMart_Backend.Infra.Repository;
using CampusMart_Backend.Infra.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDbContext, DbContext>();

builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IGeneralUserRepository, GeneralUserRepository>();
builder.Services.AddScoped<IGeneralUserService, GeneralUserService>();
builder.Services.AddScoped<ICampusConsumerRepository, CampusConsumerRepository>();
builder.Services.AddScoped<ICampusConsumerService, CampusConsumerService>();
builder.Services.AddScoped<ICampusServiceProviderRepository, CampusServiceProviderRepository>();
builder.Services.AddScoped<ICampusServiceProviderService, CampusServiceProviderService>();
builder.Services.AddScoped<ISpecialRequestRepository, SpecialRequestRepository>();
builder.Services.AddScoped<ISpecialRequestService, SpecialRequestService>();
builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
builder.Services.AddScoped<IContactUsService, ContactUsService>();
builder.Services.AddScoped<IMerchandiseRepository, MerchandiseRepository>();
builder.Services.AddScoped< IMerchandiseService, MerchandiseService>();

builder.Services.AddScoped<IOrderRepository, OrderRepository>();
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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
