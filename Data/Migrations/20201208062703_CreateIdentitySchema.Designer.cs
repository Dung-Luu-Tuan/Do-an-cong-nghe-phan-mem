﻿// <auto-generated />
using System;
using BakeryProj.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakeryProj.Data.Migrations
{
    [DbContext(typeof(BakeryContext))]
    [Migration("20201208062703_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BakeryProj.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Permission")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BakeryProj.Models.Customer", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ID_Cs")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name_Cs")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BakeryProj.Models.Item", b =>
                {
                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ProductId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("BakeryProj.Models.Order", b =>
                {
                    b.Property<int>("ID_Od")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ID_Cs")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name_Cs")
                        .HasColumnType("TEXT");

                    b.Property<string>("Note")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total_Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Total_Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID_Od");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("BakeryProj.Models.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ID_Od")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity_Order")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id", "ID_Od");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BakeryProj.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageName")
                        .HasColumnType("TEXT")
                        .HasColumnName("ImageFileName");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "BK",
                            Description = "A scrumptious mini-carrot cake encrusted with sliced almonds",
                            ImageName = "carrot_cake.jpg",
                            Name = "Carrot Cake",
                            Price = 1500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            Category = "BN",
                            Description = "A delicious lemon tart with fresh meringue cooked to perfection",
                            ImageName = "lemon_tart.jpg",
                            Name = "Lemon Tart",
                            Price = 1500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 3,
                            Category = "BN",
                            Description = "Delectable vanilla and chocolate cupcakes",
                            ImageName = "cupcakes.jpg",
                            Name = "Cupcakes",
                            Price = 1500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 4,
                            Category = "BN",
                            Description = "Fresh baked French-style bread",
                            ImageName = "bread.jpg",
                            Name = "Bread",
                            Price = 1500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 5,
                            Category = "BN",
                            Description = "A glazed pear tart topped with sliced almonds and a dash of cinnamon",
                            ImageName = "pear_tart.jpg",
                            Name = "Pear Tart",
                            Price = 1500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 6,
                            Category = "BK",
                            Description = "Rich chocolate frosting cover this chocolate lover's dream",
                            ImageName = "chocolate_cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 2500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 7,
                            Category = "BN",
                            Description = "Rich chocolate frosting cover this chocolate lover's dream",
                            ImageName = "chocolate_cake.jpg",
                            Name = "Chocolate Cake",
                            Price = 2500m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 8,
                            Category = "BN",
                            Description = "Tiramisu được phủ lên vị phomai kem béo ngậy, thêm vào đó là lớp bột cacao chất lượng tạo nên sự mềm mịn, mát lạnh tuyệt vời cho bánh",
                            ImageName = "tiramisu.jpg",
                            Name = "Tiramisu",
                            Price = 29000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 9,
                            Category = "BN",
                            Description = "Bánh chuối được làm từ bột mỳ kết hợp cùng hương vị chuối ngọt ngào. Mỗi miếng bánh là một hương vị tuyệt vời mà bạn không thể bỏ lỡ",
                            ImageName = "banana-pie.jpg",
                            Name = "Bánh Miếng Chuối",
                            Price = 30000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 10,
                            Category = "BN",
                            Description = "Bánh chuối được làm từ bột mỳ kết hợp cùng hương vị chuối ngọt ngào. Mỗi miếng bánh là một hương vị tuyệt vời mà bạn không thể bỏ lỡ",
                            ImageName = "opera-pie.jpg",
                            Name = "Bánh Miếng Dứa",
                            Price = 30000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 11,
                            Category = "BN",
                            Description = "Bánh cà phê nhân nho đen là sản phẩm đặc trưng theo phong cách của Mexico. Vỏ bánh mềm mịn, nhân bánh hương vị cà phê và nho đen giòn, ngọt.",
                            ImageName = "coffee-cake.jpg",
                            Name = "Bánh Cà Phê Nhân Nho Đen",
                            Price = 15000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 12,
                            Category = "BN",
                            Description = "Bánh nhân tart trứng mềm thơm, ngon miệng là sản phẩm được ưa chuộng bởi mọi lứa tuổi.",
                            ImageName = "egg-tart.jpg",
                            Name = "Bánh Tart Trứng",
                            Price = 15000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 13,
                            Category = "BV",
                            Description = "Bánh mì vòng được phủ 1 lớp kem phô mai bên trên",
                            ImageName = "bagel-chesse.jpg",
                            Name = "Bánh mì vòng với kem phô mai",
                            Price = 10000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 14,
                            Category = "BV",
                            Description = "Bánh donut sẽ được những người thợ tỉ mỉ tạo hình bánh tròn nhỏ, nướng giòn, sau đó phủ thêm một lớp socola cho những ai yêu thích hương vị ngọt",
                            ImageName = "chocolate-donut.jpg",
                            Name = "Donut Socola",
                            Price = 10000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 15,
                            Category = "BV",
                            Description = "Bánh dẹt, tròn được chế biến từ nước, bột mỳ và nấm men, sau khi đã được ủ ít nhất 24 tiếng đồng hồ và nhào nặn thành loại bánh có hình dạng tròn và dẹt, và được cho vào lò nướng chín",
                            ImageName = "pizza-sea.jpg",
                            Name = "Bánh Pizza",
                            Price = 150000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 16,
                            Category = "BV",
                            Description = "Bánh bao gồm bánh mì kẹp có thịt bò xay ở giữa. Miếng thịt đã được nướng và thường được ăn với một số gia vị bên trong cùng với 2 miếng bánh mì hình tròn. Phần nhân bánh gồm thịt bò nướng, salad, cà chua, khoai tây chiên",
                            ImageName = "hamburger.jpg",
                            Name = "Hamburger bò",
                            Price = 15000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 17,
                            Category = "BV",
                            Description = "Cá hồi xông khói, nước cốt chanh, với kem phô mai cùng quế và nho khô, kèm phần khoai tây chiên",
                            ImageName = "bagel-salmon.jpg",
                            Name = "Bánh mì vòng kẹp cá hồi",
                            Price = 140000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 18,
                            Category = "BK",
                            Description = "Bánh Boston Chocolate có cốt bánh socola 3 lớp nhân kem socola, mặt bánh phủ socola, trang trí macaron và socola bi",
                            ImageName = "boston.jpg",
                            Name = "Bánh kem Boston Chocolate",
                            Price = 350000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 19,
                            Category = "BK",
                            Description = "Bánh kem Puppy với cốt bánh vanilla, với nhân mứt việt quất bánh được trang trí hình chó con ngộ nghĩnh, đáng yêu dành cho những ai có tâm hồn “bay bổng” với mẫu bánh này.",
                            ImageName = "puppy.jpg",
                            Name = "Bánh kem Puppy",
                            Price = 200000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 20,
                            Category = "BK",
                            Description = "Bánh kem Mango với cốt bánh vani 3 lớp đặc biệt bánh được phủ lên những lớp kem vani béo ngậy tạo độ cân bằng cho hương vị ngọt – béo. Sau cùng phủ lên lớp mứt xoài với hương vị chua đặc trưng và những thanh socola tạo cho khách hàng sự tận hưởng khó quên",
                            ImageName = "mango.jpg",
                            Name = "Bánh kem Mango",
                            Price = 200000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 21,
                            Category = "BK",
                            Description = "Bánh kem 3D Car với cốt bánh vanilla 4 lớp đặc biệt thêm lớp nhân kem vanilla phủ xung quanh thành hình chiếc ô tô đáng yêu cho bé tha hồ thỏa sức vui chơi. Bé sẽ tự tin khi được sở hữu chiếc bánh kem “cute” và sẽ có một buổi tiệc vui chơi thỏa thích cùng bạn bè",
                            ImageName = "3dcar.jpg",
                            Name = "Bánh kem 3D Car",
                            Price = 280000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 22,
                            Category = "BK",
                            Description = "Cốt bánh socola 4 lớp với lớp nhân mứt táo đặc biệt, lớp kem socola cùng với bàn tay khéo léo của người thợ đã tạo hình nên chiếc bánh kem hình mặt chú gấu vô cùng dễ thương và bắt mắt.",
                            ImageName = "teddy.jpg",
                            Name = "Bánh kem Teddy Bear",
                            Price = 280000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 23,
                            Category = "BM",
                            Description = "Bánh sừng bò được xếp thành ngàn lớp, cuộn lại với nhau thành hình chiếc sừng bò ngộ nghĩnh. Mặt bánh phủ lớp vừng thêm phần thu hút.",
                            ImageName = "sungbomini.jpg",
                            Name = "Bánh sừng bò mini",
                            Price = 45000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 24,
                            Category = "BM",
                            Description = "Bánh cà phê nhân đậu đỏ là sản phẩm đặc trưng theo phong cách của Mexico. Vỏ bánh mềm mịn, nhân bánh hương vịdậu đỏ và nho đen giòn, ngọt.",
                            ImageName = "banhcafe.jpg",
                            Name = "Bánh cà phê nhân đậu đỏ",
                            Price = 15000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 25,
                            Category = "BM",
                            Description = "Bánh được làm từ bột ngũ cốc, giàu chất xơ, hương vị thơm bùi. Bánh có hàm lượng chất xơ cao, phù hợp với người ăn kiêng, tiểu đường. Bánh cần được bảo quản ở nhiệt độ phòng, tránh ánh sáng trực tiếp từ mặt trời. Khi bánh chưa được sử dụng hết, Quý khách vui lòng bảo quản trong ngăn mát tủ lạnh.",
                            ImageName = "banhngucoc.jpg",
                            Name = "Bánh mì ngũ cốc",
                            Price = 39000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 26,
                            Category = "BM",
                            Description = "Bánh mỳ baguette thơm ngon chuẩn Pháp. Vỏ bánh giòn, ruột mềm, thơm ngậy vị bơ",
                            ImageName = "baguette.jpg",
                            Name = "Bánh mì Baguette",
                            Price = 15000m,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 27,
                            Category = "BM",
                            Description = "Bánh cà phê nhân nho đen là sản phẩm đặc trưng theo phong cách của Mexico. Vỏ bánh mềm mịn, nhân bánh hương vị cà phê và nho đen giòn, ngọt.",
                            ImageName = "cafenho.jpg",
                            Name = "Bánh cà phê nhân nho đen",
                            Price = 15000m,
                            Quantity = 10
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BakeryProj.Models.Item", b =>
                {
                    b.HasOne("BakeryProj.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
