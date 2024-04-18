using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CampusMart_Backend.Core.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aboutuspage> Aboutuspages { get; set; } = null!;
        public virtual DbSet<Bank> Banks { get; set; } = null!;
        public virtual DbSet<Campusconsumer> Campusconsumers { get; set; } = null!;
        public virtual DbSet<Campusserviceprovider> Campusserviceproviders { get; set; } = null!;
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<Contactu> Contactus { get; set; } = null!;
        public virtual DbSet<Contactuspage> Contactuspages { get; set; } = null!;
        public virtual DbSet<Homepage> Homepages { get; set; } = null!;
        public virtual DbSet<Login> Logins { get; set; } = null!;
        public virtual DbSet<Merchandise> Merchandises { get; set; } = null!;
        public virtual DbSet<MerchandiseReview> MerchandiseReviews { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Specialrequest> Specialrequests { get; set; } = null!;
        public virtual DbSet<Store> Stores { get; set; } = null!;
        public virtual DbSet<StoreReview> StoreReviews { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;
        public virtual DbSet<Testimonialpage> Testimonialpages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SID=xe)));User Id=C##CampusMartDatabase;Password=CampusMartDatabase;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("C##CAMPUSMARTDATABASE")
                .UseCollation("USING_NLS_COMP");

            modelBuilder.Entity<Aboutuspage>(entity =>
            {
                entity.ToTable("ABOUTUSPAGE");

                entity.Property(e => e.AboutuspageId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ABOUTUSPAGE_ID");

                entity.Property(e => e.FooterComponent1)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT1");

                entity.Property(e => e.FooterComponent2)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT2");

                entity.Property(e => e.FooterComponent3)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT3");

                entity.Property(e => e.HeaderComponent1)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT1");

                entity.Property(e => e.HeaderComponent2)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT2");

                entity.Property(e => e.HeaderComponent3)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT3");

                entity.Property(e => e.ImagePath1)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH1");

                entity.Property(e => e.ImagePath2)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH2");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("LOGO_PATH");

                entity.Property(e => e.Paragraph1)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH1");

                entity.Property(e => e.Paragraph2)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH2");

                entity.Property(e => e.Paragraph3)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH3");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("BANK");

                entity.Property(e => e.Bankid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BANKID");

                entity.Property(e => e.Balance)
                    .HasColumnType("NUMBER")
                    .HasColumnName("BALANCE");

                entity.Property(e => e.Cardholder)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CARDHOLDER");

                entity.Property(e => e.Cardnumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CARDNUMBER");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Cvv)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CVV");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Paymentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PAYMENTID");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_BANK_CONSUMERID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Banks)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_BANK_PAYMENTID");
            });

            modelBuilder.Entity<Campusconsumer>(entity =>
            {
                entity.HasKey(e => e.Consumerid);

                entity.ToTable("CAMPUSCONSUMER");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Imagepath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEPATH");

                entity.Property(e => e.Isprovider)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ISPROVIDER")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LocationLatitude)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_LATITUDE");

                entity.Property(e => e.LocationLongitude)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_LONGITUDE");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Campusconsumers)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ROLEID");
            });

            modelBuilder.Entity<Campusserviceprovider>(entity =>
            {
                entity.HasKey(e => e.Providerid);

                entity.ToTable("CAMPUSSERVICEPROVIDER");

                entity.Property(e => e.Providerid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PROVIDERID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.LocationLatitude)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_LATITUDE");

                entity.Property(e => e.LocationLongitude)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_LONGITUDE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Campusserviceproviders)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CONSUMERID_PROVIDER");
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("CART");

                entity.Property(e => e.Cartid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CARTID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Orderid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Productid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCTID");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Storeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STOREID");

                entity.Property(e => e.Total)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTAL");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CART_CONSUMERID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CART_ORDERID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.Productid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CART_PRODUCTID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Carts)
                    .HasForeignKey(d => d.Storeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CART_STOREID");
            });

            modelBuilder.Entity<Contactu>(entity =>
            {
                entity.HasKey(e => e.ContactusId)
                    .HasName("PK_CONTACTUS_CONTACTUS_ID");

                entity.ToTable("CONTACTUS");

                entity.Property(e => e.ContactusId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACTUS_ID");

                entity.Property(e => e.Email)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fullname)
                    .IsUnicode(false)
                    .HasColumnName("FULLNAME");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.PhoneNumber)
                    .IsUnicode(false)
                    .HasColumnName("PHONE_NUMBER");

                entity.Property(e => e.Subject)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<Contactuspage>(entity =>
            {
                entity.ToTable("CONTACTUSPAGE");

                entity.Property(e => e.ContactuspageId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONTACTUSPAGE_ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.FooterComponent1)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT1");

                entity.Property(e => e.FooterComponent2)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT2");

                entity.Property(e => e.FooterComponent3)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT3");

                entity.Property(e => e.HeaderComponent1)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT1");

                entity.Property(e => e.HeaderComponent2)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT2");

                entity.Property(e => e.HeaderComponent3)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT3");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("LOGO_PATH");

                entity.Property(e => e.Message)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("MESSAGE");

                entity.Property(e => e.Paragraph1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH1");

                entity.Property(e => e.Paragraph2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH2");

                entity.Property(e => e.Paragraph3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH3");

                entity.Property(e => e.Subject)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("SUBJECT");
            });

            modelBuilder.Entity<Homepage>(entity =>
            {
                entity.ToTable("HOMEPAGE");

                entity.Property(e => e.HomepageId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HOMEPAGE_ID");

                entity.Property(e => e.FooterComponent1)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT1");

                entity.Property(e => e.FooterComponent2)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT2");

                entity.Property(e => e.FooterComponent3)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT3");

                entity.Property(e => e.HeaderComponent1)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT1");

                entity.Property(e => e.HeaderComponent2)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT2");

                entity.Property(e => e.HeaderComponent3)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT3");

                entity.Property(e => e.ImagePath1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH1");

                entity.Property(e => e.ImagePath2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH2");

                entity.Property(e => e.LogoPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("LOGO_PATH");

                entity.Property(e => e.Paragraph1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH1");

                entity.Property(e => e.Paragraph2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH2");

                entity.Property(e => e.Paragraph3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH3");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("LOGIN");

                entity.Property(e => e.Id)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Roleid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ROLEID");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_LOGIN_CONSUMERID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Logins)
                    .HasForeignKey(d => d.Roleid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_LOGIN_ROLEID");
            });

            modelBuilder.Entity<Merchandise>(entity =>
            {
                entity.HasKey(e => e.Productid);

                entity.ToTable("MERCHANDISE");

                entity.Property(e => e.Productid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PRODUCTID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CATEGORY");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRICE");

                entity.Property(e => e.Quantity)
                    .HasColumnType("NUMBER")
                    .HasColumnName("QUANTITY");

                entity.Property(e => e.Rate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("RATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Storeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STOREID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Merchandises)
                    .HasForeignKey(d => d.Storeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MERCHANDISE_STOREID");
            });

            modelBuilder.Entity<MerchandiseReview>(entity =>
            {
                entity.ToTable("MERCHANDISE_REVIEW");

                entity.Property(e => e.MerchandiseReviewId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MERCHANDISE_REVIEW_ID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Orderid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Productid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PRODUCTID");

                entity.Property(e => e.Rating)
                    .HasColumnType("FLOAT")
                    .HasColumnName("RATING");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVIEW_DATE");

                entity.Property(e => e.ReviewText)
                    .IsUnicode(false)
                    .HasColumnName("REVIEW_TEXT");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.MerchandiseReviews)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MERCHANDISE_REVIEW_CONSUMERID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.MerchandiseReviews)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MERCHANDISE_REVIEW_ORDERID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MerchandiseReviews)
                    .HasForeignKey(d => d.Productid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_MERCHANDISE_REVIEW_PRODUCTID");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("ORDERS");

                entity.Property(e => e.Orderid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Deliveryaddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERYADDRESS");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION");

                entity.Property(e => e.LocationLatitude)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_LATITUDE");

                entity.Property(e => e.LocationLongitude)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("LOCATION_LONGITUDE");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("DATE")
                    .HasColumnName("ORDERDATE");

                entity.Property(e => e.Ordernumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERNUMBER");

                entity.Property(e => e.Orderstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ORDERSTATUS");

                entity.Property(e => e.Paymentid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PAYMENTID");

                entity.Property(e => e.Providerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROVIDERID");

                entity.Property(e => e.Totalamount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("TOTALAMOUNT");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORDERS_CONSUMERID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Paymentid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ORDERS_PAYMENTID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Providerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ORDERS_PROVIDERID");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("PAYMENT");

                entity.Property(e => e.Paymentid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PAYMENTID");

                entity.Property(e => e.Amount)
                    .HasColumnType("NUMBER")
                    .HasColumnName("AMOUNT");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("DATE")
                    .HasColumnName("PAYMENT_DATE");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PAYMENT_METHOD");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("ROLES");

                entity.Property(e => e.RoleId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ROLE_ID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ROLE_NAME");
            });

            modelBuilder.Entity<Specialrequest>(entity =>
            {
                entity.HasKey(e => e.Requestid)
                    .HasName("PK_SPECIALREQUEST_REQUESTID");

                entity.ToTable("SPECIALREQUEST");

                entity.Property(e => e.Requestid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("REQUESTID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Providerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROVIDERID");

                entity.Property(e => e.Requestdetails)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTDETAILS");

                entity.Property(e => e.Requeststatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTSTATUS");

                entity.Property(e => e.Requesttitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REQUESTTITLE");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Specialrequests)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SPECIALREQUEST_CONSUMERID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Specialrequests)
                    .HasForeignKey(d => d.Providerid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_SPECIALREQUEST_PROVIDERID");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("STORE");

                entity.Property(e => e.Storeid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STOREID");

                entity.Property(e => e.Approvalstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APPROVALSTATUS");

                entity.Property(e => e.Image)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE");

                entity.Property(e => e.Isopen)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ISOPEN")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Providerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("PROVIDERID");

                entity.Property(e => e.Rate)
                    .HasColumnType("FLOAT")
                    .HasColumnName("RATE");

                entity.Property(e => e.Storename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STORENAME");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.Providerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STORE_PROVIDERID");
            });

            modelBuilder.Entity<StoreReview>(entity =>
            {
                entity.ToTable("STORE_REVIEW");

                entity.Property(e => e.StoreReviewId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("STORE_REVIEW_ID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Orderid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("ORDERID");

                entity.Property(e => e.Rating)
                    .HasColumnType("FLOAT")
                    .HasColumnName("RATING");

                entity.Property(e => e.ReviewDate)
                    .HasColumnType("DATE")
                    .HasColumnName("REVIEW_DATE");

                entity.Property(e => e.ReviewText)
                    .IsUnicode(false)
                    .HasColumnName("REVIEW_TEXT");

                entity.Property(e => e.Storeid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("STOREID");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.StoreReviews)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STORE_REVIEW_CONSUMERID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.StoreReviews)
                    .HasForeignKey(d => d.Orderid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STORE_REVIEW_ORDERID");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreReviews)
                    .HasForeignKey(d => d.Storeid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_STORE_REVIEW_STOREID");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("TESTIMONIAL");

                entity.Property(e => e.Testimonialid)
                    .HasColumnType("NUMBER")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTIMONIALID");

                entity.Property(e => e.Consumerid)
                    .HasColumnType("NUMBER")
                    .HasColumnName("CONSUMERID");

                entity.Property(e => e.Dateposted)
                    .HasColumnType("DATE")
                    .HasColumnName("DATEPOSTED")
                    .HasDefaultValueSql("SYSDATE");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");

                entity.Property(e => e.Testimonialtext)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("TESTIMONIALTEXT");

                entity.HasOne(d => d.Consumer)
                    .WithMany(p => p.Testimonials)
                    .HasForeignKey(d => d.Consumerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TESTIMONIAL_CONSUMERID");
            });

            modelBuilder.Entity<Testimonialpage>(entity =>
            {
                entity.ToTable("TESTIMONIALPAGE");

                entity.Property(e => e.TestimonialpageId)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TESTIMONIALPAGE_ID");

                entity.Property(e => e.FooterComponent1)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT1");

                entity.Property(e => e.FooterComponent2)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT2");

                entity.Property(e => e.FooterComponent3)
                    .IsUnicode(false)
                    .HasColumnName("FOOTER_COMPONENT3");

                entity.Property(e => e.HeaderComponent1)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT1");

                entity.Property(e => e.HeaderComponent2)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT2");

                entity.Property(e => e.HeaderComponent3)
                    .IsUnicode(false)
                    .HasColumnName("HEADER_COMPONENT3");

                entity.Property(e => e.ImagePath1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH1");

                entity.Property(e => e.ImagePath2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("IMAGE_PATH2");

                entity.Property(e => e.Paragraph1)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH1");

                entity.Property(e => e.Paragraph2)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH2");

                entity.Property(e => e.Paragraph3)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("PARAGRAPH3");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
