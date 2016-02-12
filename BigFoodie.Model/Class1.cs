//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BigFoodie.Model
//{ // ************************************************************************

//    // ************************************************************************
//    // POCO Configuration

//    // adminAcc
//    public class AdminAccConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AdminAcc>
//    {
//        public AdminAccConfiguration()
//            : this("dbo")
//        {
//        }

//        public AdminAccConfiguration(string schema)
//        {
//            ToTable(schema + ".adminAcc");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Loginname).HasColumnName("loginname").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Loginpwd).HasColumnName("loginpwd").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Createtime).HasColumnName("createtime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Rightcode).HasColumnName("rightcode").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
//            Property(x => x.Lastlogindt).HasColumnName("lastlogindt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Lastloginip).HasColumnName("lastloginip").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Isvalid).HasColumnName("isvalid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isadmin).HasColumnName("isadmin").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // adv
//    public class AdvConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Adv>
//    {
//        public AdvConfiguration()
//            : this("dbo")
//        {
//        }

//        public AdvConfiguration(string schema)
//        {
//            ToTable(schema + ".adv");
//            HasKey(x => x.Advid);

//            Property(x => x.Advid).HasColumnName("advid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Pc).HasColumnName("pc").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Townname).HasColumnName("townname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Shoploginname).HasColumnName("shoploginname").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Starttime).HasColumnName("starttime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Endtime).HasColumnName("endtime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Urllink).HasColumnName("urllink").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
//            Property(x => x.AdvPic).HasColumnName("advPic").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Indexno).HasColumnName("indexno").IsOptional().HasColumnType("int");
//            Property(x => x.Clicknum).HasColumnName("clicknum").IsOptional().HasColumnType("int");
//            Property(x => x.Recdate).HasColumnName("recdate").IsOptional().HasColumnType("datetime");
//            Property(x => x.Advposition).HasColumnName("advposition").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // advsearch
//    public class AdvsearchConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Advsearch>
//    {
//        public AdvsearchConfiguration()
//            : this("dbo")
//        {
//        }

//        public AdvsearchConfiguration(string schema)
//        {
//            ToTable(schema + ".advsearch");
//            HasKey(x => x.Advid);

//            Property(x => x.Advid).HasColumnName("advid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Postcode).HasColumnName("postcode").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Indexno).HasColumnName("indexno").IsOptional().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Startdt).HasColumnName("startdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Enddt).HasColumnName("enddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createuser).HasColumnName("createuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // AppUserInfo
//    public class AppUserInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AppUserInfo>
//    {
//        public AppUserInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public AppUserInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".AppUserInfo");
//            HasKey(x => x.Appuserid);

//            Property(x => x.Appuserid).HasColumnName("appuserid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Loginname).HasColumnName("loginname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Password).HasColumnName("password").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Usertype).HasColumnName("usertype").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Username).HasColumnName("username").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Status).HasColumnName("status").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Logindt).HasColumnName("logindt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createuser).HasColumnName("createuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Loginip).HasColumnName("loginip").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Loginstatus).HasColumnName("loginstatus").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
//            Property(x => x.LoginErrCount).HasColumnName("LoginErrCount").IsOptional().HasColumnType("int");
//            Property(x => x.Apptokenstr).HasColumnName("apptokenstr").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // AppUserSetting
//    public class AppUserSettingConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AppUserSetting>
//    {
//        public AppUserSettingConfiguration()
//            : this("dbo")
//        {
//        }

//        public AppUserSettingConfiguration(string schema)
//        {
//            ToTable(schema + ".AppUserSetting");
//            HasKey(x => x.Appuserid);

//            Property(x => x.Appuserid).HasColumnName("appuserid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Operatecode).HasColumnName("operatecode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Istakeorder).HasColumnName("istakeorder").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Neworderalertfile).HasColumnName("neworderalertfile").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Infoalertfile).HasColumnName("infoalertfile").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Onduty).HasColumnName("onduty").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Offdutytodt).HasColumnName("offdutytodt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Langopt).HasColumnName("langopt").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // AppUserToDevice
//    public class AppUserToDeviceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<AppUserToDevice>
//    {
//        public AppUserToDeviceConfiguration()
//            : this("dbo")
//        {
//        }

//        public AppUserToDeviceConfiguration(string schema)
//        {
//            ToTable(schema + ".AppUserToDevice");
//            HasKey(x => x.Infoid);

//            Property(x => x.Infoid).HasColumnName("infoid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Devicetoken).HasColumnName("devicetoken").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Appuserid).HasColumnName("appuserid").IsOptional().HasColumnType("int");
//        }
//    }

//    // blocklist
//    public class BlocklistConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Blocklist>
//    {
//        public BlocklistConfiguration()
//            : this("dbo")
//        {
//        }

//        public BlocklistConfiguration(string schema)
//        {
//            ToTable(schema + ".blocklist");
//            HasKey(x => x.Blockid);

//            Property(x => x.Blockid).HasColumnName("blockid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Email).HasColumnName("email").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(100);
//            Property(x => x.Mobile).HasColumnName("mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Landline).HasColumnName("landline").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Reason).HasColumnName("reason").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Createuser).HasColumnName("createuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//        }
//    }

//    // cashreturn
//    public class CashreturnConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Cashreturn>
//    {
//        public CashreturnConfiguration()
//            : this("dbo")
//        {
//        }

//        public CashreturnConfiguration(string schema)
//        {
//            ToTable(schema + ".cashreturn");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsOptional().HasColumnType("int");
//            Property(x => x.Cashid).HasColumnName("cashid").IsOptional().HasColumnType("int");
//            Property(x => x.Amount).HasColumnName("amount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Atime).HasColumnName("atime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Cardid).HasColumnName("cardid").IsOptional().HasColumnType("int");
//            Property(x => x.Status).HasColumnName("status").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Comment).HasColumnName("comment").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//        }
//    }

//    // commission
//    public class CommissionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Commission>
//    {
//        public CommissionConfiguration()
//            : this("dbo")
//        {
//        }

//        public CommissionConfiguration(string schema)
//        {
//            ToTable(schema + ".commission");
//            HasKey(x => x.Shopid);

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Starttime).HasColumnName("starttime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Endtime).HasColumnName("endtime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Amount).HasColumnName("amount").IsRequired().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.ModifiedDt).HasColumnName("modifiedDt").IsOptional().HasColumnType("datetime");
//        }
//    }

//    // creditCard
//    public class CreditCardConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CreditCard>
//    {
//        public CreditCardConfiguration()
//            : this("dbo")
//        {
//        }

//        public CreditCardConfiguration(string schema)
//        {
//            ToTable(schema + ".creditCard");
//            HasKey(x => x.Cardid);

//            Property(x => x.Cardid).HasColumnName("cardid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Acct).HasColumnName("ACCT").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.AcctType).HasColumnName("AcctType").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Street).HasColumnName("Street").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.City).HasColumnName("city").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.State).HasColumnName("state").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Country).HasColumnName("country").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Zip).HasColumnName("zip").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.CardIssue).HasColumnName("cardIssue").IsOptional().HasColumnType("int");
//            Property(x => x.CardStart).HasColumnName("cardStart").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
//            Property(x => x.ExpDate).HasColumnName("expDate").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.FirstName).HasColumnName("firstName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.LastName).HasColumnName("lastName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Cvv2).HasColumnName("CVV2").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.CreateDt).HasColumnName("createDT").IsOptional().HasColumnType("datetime");
//        }
//    }

//    // customerReview
//    public class CustomerReviewConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CustomerReview>
//    {
//        public CustomerReviewConfiguration()
//            : this("dbo")
//        {
//        }

//        public CustomerReviewConfiguration(string schema)
//        {
//            ToTable(schema + ".customerReview");
//            HasKey(x => x.Reviewid);

//            Property(x => x.Reviewid).HasColumnName("reviewid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsOptional().HasColumnType("int");
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Rate1).HasColumnName("rate1").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Rate2).HasColumnName("rate2").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Rate3).HasColumnName("rate3").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Rate4).HasColumnName("rate4").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.ReviewDate).HasColumnName("reviewDate").IsOptional().HasColumnType("datetime");
//            Property(x => x.Reviewtype).HasColumnName("reviewtype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Objid).HasColumnName("objid").IsOptional().HasColumnType("int");
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Comment).HasColumnName("comment").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.ReplyMsg).HasColumnName("replyMsg").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.ReplyDt).HasColumnName("replyDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Username).HasColumnName("username").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Townname).HasColumnName("townname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // deliveryAddr
//    public class DeliveryAddrConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DeliveryAddr>
//    {
//        public DeliveryAddrConfiguration()
//            : this("dbo")
//        {
//        }

//        public DeliveryAddrConfiguration(string schema)
//        {
//            ToTable(schema + ".deliveryAddr");
//            HasKey(x => x.Addrid);

//            Property(x => x.Addrid).HasColumnName("addrid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Username).HasColumnName("username").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Addrname).HasColumnName("addrname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr1).HasColumnName("addr1").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsRequired().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Tel).HasColumnName("tel").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
//            Property(x => x.Flag).HasColumnName("flag").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Mobile).HasColumnName("mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // deviceinfo
//    public class DeviceinfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Deviceinfo>
//    {
//        public DeviceinfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public DeviceinfoConfiguration(string schema)
//        {
//            ToTable(schema + ".deviceinfo");
//            HasKey(x => x.Deviceid);

//            Property(x => x.Deviceid).HasColumnName("deviceid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Devicetoken).HasColumnName("devicetoken").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Devicetype).HasColumnName("devicetype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Deviceversion).HasColumnName("deviceversion").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Registdt).HasColumnName("registdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Channels).HasColumnName("channels").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.LastHeartbeatAt).HasColumnName("LastHeartbeatAt").IsOptional().HasColumnType("datetime");
//        }
//    }

//    // favourites
//    public class FavouriteConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Favourite>
//    {
//        public FavouriteConfiguration()
//            : this("dbo")
//        {
//        }

//        public FavouriteConfiguration(string schema)
//        {
//            ToTable(schema + ".favourites");
//            HasKey(x => x.Fid);

//            Property(x => x.Fid).HasColumnName("fid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Ftype).HasColumnName("ftype").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Mid).HasColumnName("mid").IsOptional().HasColumnType("int");
//            Property(x => x.CreateDt).HasColumnName("createDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag).HasColumnName("flag").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // invitefriend
//    public class InvitefriendConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Invitefriend>
//    {
//        public InvitefriendConfiguration()
//            : this("dbo")
//        {
//        }

//        public InvitefriendConfiguration(string schema)
//        {
//            ToTable(schema + ".invitefriend");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Iemail).HasColumnName("iemail").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Iusername).HasColumnName("iusername").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Idatatime).HasColumnName("idatatime").IsOptional().HasColumnType("datetime");
//            Property(x => x.InviteCode).HasColumnName("inviteCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.IsReg).HasColumnName("isReg").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.IsScore).HasColumnName("isScore").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isvalid).HasColumnName("isvalid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Iorderid).HasColumnName("iorderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//        }
//    }

//    // memberCash
//    public class MemberCashConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MemberCash>
//    {
//        public MemberCashConfiguration()
//            : this("dbo")
//        {
//        }

//        public MemberCashConfiguration(string schema)
//        {
//            ToTable(schema + ".memberCash");
//            HasKey(x => x.Cashid);

//            Property(x => x.Cashid).HasColumnName("cashid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
//            Property(x => x.Amount).HasColumnName("amount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Atime).HasColumnName("atime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Action).HasColumnName("action").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Adminuid).HasColumnName("adminuid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // menu
//    public class MenuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Menu>
//    {
//        public MenuConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenuConfiguration(string schema)
//        {
//            ToTable(schema + ".menu");
//            HasKey(x => x.Mid);

//            Property(x => x.Mid).HasColumnName("mid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.MenuCat).HasColumnName("menuCat").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.MenuName).HasColumnName("menuName").IsRequired().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.MenuName2).HasColumnName("menuName2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.MenuDesc).HasColumnName("menuDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.MenuDesc2).HasColumnName("menuDesc2").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Price1).HasColumnName("price1").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Price2).HasColumnName("price2").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Star).HasColumnName("star").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Menutype).HasColumnName("menutype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Menulogo).HasColumnName("menulogo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Discountway).HasColumnName("discountway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Menucode).HasColumnName("menucode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.ServicePeriod).HasColumnName("servicePeriod").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Displayweekday).HasColumnName("displayweekday").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.HasSideOrder).HasColumnName("hasSideOrder").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.HasPl).HasColumnName("hasPL").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Standardpl).HasColumnName("standardpl").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//            Property(x => x.CreateDt).HasColumnName("CreateDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.UpdateDt).HasColumnName("UpdateDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag).HasColumnName("flag").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Indexnum).HasColumnName("indexnum").IsOptional().HasColumnType("numeric").HasPrecision(8, 1);
//            Property(x => x.Mealamt).HasColumnName("mealamt").IsOptional().HasColumnType("int");
//            Property(x => x.Menuoptioncat).HasColumnName("menuoptioncat").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//        }
//    }

//    // menubasic
//    public class MenubasicConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Menubasic>
//    {
//        public MenubasicConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenubasicConfiguration(string schema)
//        {
//            ToTable(schema + ".menubasic");
//            HasKey(x => x.Basicmenuid);

//            Property(x => x.Basicmenuid).HasColumnName("basicmenuid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Menutype1).HasColumnName("menutype1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menutype2).HasColumnName("menutype2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Mname).HasColumnName("mname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mname2).HasColumnName("mname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Price1).HasColumnName("price1").IsOptional().HasColumnType("numeric").HasPrecision(8, 2);
//            Property(x => x.Price2).HasColumnName("price2").IsOptional().HasColumnType("numeric").HasPrecision(8, 2);
//            Property(x => x.Menudesc).HasColumnName("menudesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menudesc2).HasColumnName("menudesc2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menucode).HasColumnName("menucode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Flag).HasColumnName("flag").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Menu001).HasColumnName("menu001").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Indexnum).HasColumnName("indexnum").IsOptional().HasColumnType("numeric").HasPrecision(8, 1);
//        }
//    }

//    // MenuBasicTemplate
//    public class MenuBasicTemplateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MenuBasicTemplate>
//    {
//        public MenuBasicTemplateConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenuBasicTemplateConfiguration(string schema)
//        {
//            ToTable(schema + ".MenuBasicTemplate");
//            HasKey(x => x.Basicmenuid);

//            Property(x => x.Basicmenuid).HasColumnName("basicmenuid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Menutype1).HasColumnName("menutype1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menutype2).HasColumnName("menutype2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mname).HasColumnName("mname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mname2).HasColumnName("mname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Price1).HasColumnName("price1").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Price2).HasColumnName("price2").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Menudesc2).HasColumnName("menudesc2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menudesc).HasColumnName("menudesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menucode).HasColumnName("menucode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Flag).HasColumnName("flag").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Menu001).HasColumnName("menu001").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // menuCat
//    public class MenuCatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MenuCat>
//    {
//        public MenuCatConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenuCatConfiguration(string schema)
//        {
//            ToTable(schema + ".menuCat");
//            HasKey(x => x.Catid);

//            Property(x => x.Catid).HasColumnName("catid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.CatName).HasColumnName("catName").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.CatName2).HasColumnName("catName2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Description2).HasColumnName("description2").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.ServicePeriod).HasColumnName("servicePeriod").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Displayweekday).HasColumnName("displayweekday").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Pcsetting).HasColumnName("pcsetting").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.CreateDt).HasColumnName("createDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.ModifiedDt).HasColumnName("modifiedDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Indexnum).HasColumnName("indexnum").IsOptional().HasColumnType("numeric").HasPrecision(8, 1);
//            Property(x => x.Logostr).HasColumnName("logostr").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//        }
//    }

//    // menuCatBasicMenu
//    public class MenuCatBasicMenuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MenuCatBasicMenu>
//    {
//        public MenuCatBasicMenuConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenuCatBasicMenuConfiguration(string schema)
//        {
//            ToTable(schema + ".menuCatBasicMenu");
//            HasKey(x => x.Indexid);

//            Property(x => x.Indexid).HasColumnName("indexid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Catid).HasColumnName("catid").IsRequired().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Menutype1).HasColumnName("menutype1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Menutype2).HasColumnName("menutype2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Basicmenuids).HasColumnName("basicmenuids").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//        }
//    }

//    // menucattemplate
//    public class MenucattemplateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Menucattemplate>
//    {
//        public MenucattemplateConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenucattemplateConfiguration(string schema)
//        {
//            ToTable(schema + ".menucattemplate");
//            HasKey(x => x.Catid);

//            Property(x => x.Catid).HasColumnName("catid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Indexnum).HasColumnName("indexnum").IsOptional().HasColumnType("numeric").HasPrecision(7, 1);
//            Property(x => x.Catname).HasColumnName("catname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Catname2).HasColumnName("catname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cat001).HasColumnName("cat001").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // menuoptionalcat
//    public class MenuoptionalcatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Menuoptionalcat>
//    {
//        public MenuoptionalcatConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenuoptionalcatConfiguration(string schema)
//        {
//            ToTable(schema + ".menuoptionalcat");
//            HasKey(x => new { x.Optioncatid, x.Shopid });

//            Property(x => x.Optioncatid).HasColumnName("optioncatid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Optionname).HasColumnName("optionname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Optionname2).HasColumnName("optionname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Flag).HasColumnName("flag").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Indexnum).HasColumnName("indexnum").IsOptional().HasColumnType("numeric").HasPrecision(8, 1);
//            Property(x => x.Optiondesc).HasColumnName("optiondesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
//        }
//    }

//    // menuPrice
//    public class MenuPriceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MenuPrice>
//    {
//        public MenuPriceConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenuPriceConfiguration(string schema)
//        {
//            ToTable(schema + ".menuPrice");
//            HasKey(x => x.Pid);

//            Property(x => x.Pid).HasColumnName("pid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Mid).HasColumnName("mid").IsRequired().HasColumnType("int");
//            Property(x => x.Price).HasColumnName("price").IsOptional().HasColumnType("numeric");
//            Property(x => x.Dtfrom).HasColumnName("dtfrom").IsOptional().HasColumnType("smalldatetime");
//            Property(x => x.Dtto).HasColumnName("dtto").IsOptional().HasColumnType("smalldatetime");
//            Property(x => x.Ptype).HasColumnName("ptype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // menusideorder
//    public class MenusideorderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Menusideorder>
//    {
//        public MenusideorderConfiguration()
//            : this("dbo")
//        {
//        }

//        public MenusideorderConfiguration(string schema)
//        {
//            ToTable(schema + ".menusideorder");
//            HasKey(x => x.Sideorderid);

//            Property(x => x.Sideorderid).HasColumnName("sideorderid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Mid).HasColumnName("mid").IsOptional().HasColumnType("int");
//            Property(x => x.Mname).HasColumnName("mname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mname2).HasColumnName("mname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Price1).HasColumnName("price1").IsOptional().HasColumnType("numeric").HasPrecision(8, 2);
//            Property(x => x.Price2).HasColumnName("price2").IsOptional().HasColumnType("numeric").HasPrecision(8, 2);
//            Property(x => x.DiscountPeriod).HasColumnName("discountPeriod").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // multilangMenu
//    public class MultilangMenuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MultilangMenu>
//    {
//        public MultilangMenuConfiguration()
//            : this("dbo")
//        {
//        }

//        public MultilangMenuConfiguration(string schema)
//        {
//            ToTable(schema + ".multilangMenu");
//            HasKey(x => new { x.Menuid, x.Menuname });

//            Property(x => x.Menuid).HasColumnName("menuid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Menuname).HasColumnName("menuname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Name1).HasColumnName("name1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Name2).HasColumnName("name2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Name3).HasColumnName("name3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Name4).HasColumnName("name4").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Name5).HasColumnName("name5").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Name6).HasColumnName("name6").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Name7).HasColumnName("name7").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // newshopregis
//    public class NewshopregiConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Newshopregi>
//    {
//        public NewshopregiConfiguration()
//            : this("dbo")
//        {
//        }

//        public NewshopregiConfiguration(string schema)
//        {
//            ToTable(schema + ".newshopregis");
//            HasKey(x => x.Regisid);

//            Property(x => x.Regisid).HasColumnName("regisid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopname).HasColumnName("shopname").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode).HasColumnName("postcode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Contactperson).HasColumnName("contactperson").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Tele).HasColumnName("tele").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Regisdt).HasColumnName("regisdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.SalesUserName).HasColumnName("SalesUserName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.IsJoined).HasColumnName("IsJoined").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
//            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
//        }
//    }

//    // onlineUser
//    public class OnlineUserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<OnlineUser>
//    {
//        public OnlineUserConfiguration()
//            : this("dbo")
//        {
//        }

//        public OnlineUserConfiguration(string schema)
//        {
//            ToTable(schema + ".onlineUser");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Urealname).HasColumnName("urealname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.LoginTime).HasColumnName("loginTime").IsOptional().HasColumnType("datetime");
//            Property(x => x.LastUpdateTime).HasColumnName("lastUpdateTime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Utype).HasColumnName("utype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // orders
//    public class OrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Order>
//    {
//        public OrderConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrderConfiguration(string schema)
//        {
//            ToTable(schema + ".orders");
//            HasKey(x => x.OrderId);

//            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("nvarchar").HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Useremail).HasColumnName("useremail").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Amount).HasColumnName("amount").IsOptional().HasColumnType("int");
//            Property(x => x.Unitprice).HasColumnName("unitprice").IsOptional().HasColumnType("decimal").HasPrecision(10, 4);
//            Property(x => x.Payway).HasColumnName("payway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ispaid).HasColumnName("ispaid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ticketnumber).HasColumnName("ticketnumber").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Ticketvalue).HasColumnName("ticketvalue").IsOptional().HasColumnType("int");
//            Property(x => x.Deliveryway).HasColumnName("deliveryway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Pickupdt).HasColumnName("pickupdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Orderstatus).HasColumnName("orderstatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Ordercreatedt).HasColumnName("ordercreatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.OrderUpdatedt).HasColumnName("orderUpdatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.IsCancelled).HasColumnName("isCancelled").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.OrderCancelledDt).HasColumnName("orderCancelledDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.CancelComments).HasColumnName("cancelComments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Totalamount).HasColumnName("totalamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Totalprice1).HasColumnName("totalprice1").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.DiscountRate).HasColumnName("discountRate").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Afterdiscount).HasColumnName("afterdiscount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Deliverycharge).HasColumnName("deliverycharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.ServiceCharge).HasColumnName("serviceCharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.CreditcardCharge).HasColumnName("creditcardCharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Tips).HasColumnName("tips").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Isjz).HasColumnName("isjz").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Jzdt).HasColumnName("jzdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Actualamount).HasColumnName("actualamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.UserIp).HasColumnName("userIP").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Comrate).HasColumnName("comrate").IsOptional().HasColumnType("decimal").HasPrecision(6, 2);
//            Property(x => x.Shopcardcharge).HasColumnName("shopcardcharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Paidwithcredit).HasColumnName("paidwithcredit").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Vouchercode).HasColumnName("vouchercode").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Creditback).HasColumnName("creditback").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//        }
//    }

//    // ordercomments
//    public class OrdercommentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ordercomment>
//    {
//        public OrdercommentConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrdercommentConfiguration(string schema)
//        {
//            ToTable(schema + ".ordercomments");
//            HasKey(x => x.Cid);

//            Property(x => x.Cid).HasColumnName("cid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Msgtype).HasColumnName("msgtype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Msgcont).HasColumnName("msgcont").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Msgreply).HasColumnName("msgreply").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Replydt).HasColumnName("replydt").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
//        }
//    }

//    // ordercz
//    public class OrderczConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ordercz>
//    {
//        public OrderczConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrderczConfiguration(string schema)
//        {
//            ToTable(schema + ".ordercz");
//            HasKey(x => x.Czid);

//            Property(x => x.Czid).HasColumnName("czid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Czdt).HasColumnName("czdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Orderid).HasColumnName("orderid").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Amt).HasColumnName("amt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Operateid).HasColumnName("operateid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // orderdelivery
//    public class OrderdeliveryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Orderdelivery>
//    {
//        public OrderdeliveryConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrderdeliveryConfiguration(string schema)
//        {
//            ToTable(schema + ".orderdelivery");
//            HasKey(x => x.Orderid);

//            Property(x => x.Orderid).HasColumnName("orderid").IsRequired().HasColumnType("nvarchar").HasMaxLength(30).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Townname).HasColumnName("townname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Contactname).HasColumnName("contactname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel2).HasColumnName("tel2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Deliverdt).HasColumnName("deliverdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Deliverpeople).HasColumnName("deliverpeople").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(300);
//        }
//    }

//    // orderitem
//    public class OrderitemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Orderitem>
//    {
//        public OrderitemConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrderitemConfiguration(string schema)
//        {
//            ToTable(schema + ".orderitem");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Orderid).HasColumnName("orderid").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Mid).HasColumnName("mid").IsRequired().HasColumnType("int");
//            Property(x => x.Submenuid).HasColumnName("submenuid").IsRequired().HasColumnType("int");
//            Property(x => x.Menucode).HasColumnName("menucode").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.MenuName).HasColumnName("menuName").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.MenuName2).HasColumnName("menuName2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Amount).HasColumnName("amount").IsOptional().HasColumnType("int");
//            Property(x => x.Price1).HasColumnName("price1").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Discountprice).HasColumnName("discountprice").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Totalprice).HasColumnName("totalprice").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Menulogo).HasColumnName("menulogo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Menutype).HasColumnName("menutype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.MenuNameE).HasColumnName("menuNameE").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.MenuName2E).HasColumnName("menuName2E").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//        }
//    }

//    // ordernotice
//    public class OrdernoticeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Ordernotice>
//    {
//        public OrdernoticeConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrdernoticeConfiguration(string schema)
//        {
//            ToTable(schema + ".ordernotice");
//            HasKey(x => x.Scode);

//            Property(x => x.Scode).HasColumnName("scode").IsRequired().HasColumnType("nvarchar").HasMaxLength(50).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Orderid).HasColumnName("orderid").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.ExpiredDt).HasColumnName("ExpiredDT").IsRequired().HasColumnType("datetime");
//            Property(x => x.Accessdt).HasColumnName("accessdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Accessip).HasColumnName("accessip").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Isread).HasColumnName("isread").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // orderoperation
//    public class OrderoperationConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Orderoperation>
//    {
//        public OrderoperationConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrderoperationConfiguration(string schema)
//        {
//            ToTable(schema + ".orderoperation");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Actionstr).HasColumnName("actionstr").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Actiondt).HasColumnName("actiondt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Actionuser).HasColumnName("actionuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // orderpayment
//    public class OrderpaymentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Orderpayment>
//    {
//        public OrderpaymentConfiguration()
//            : this("dbo")
//        {
//        }

//        public OrderpaymentConfiguration(string schema)
//        {
//            ToTable(schema + ".orderpayment");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Orderid).HasColumnName("orderid").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Cardnumber).HasColumnName("cardnumber").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Cardtype).HasColumnName("cardtype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Name1).HasColumnName("name1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Name2).HasColumnName("name2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Paidtime).HasColumnName("paidtime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Applytime).HasColumnName("applytime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Confirmtime).HasColumnName("confirmtime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Paidamount).HasColumnName("paidamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.ResultDesc).HasColumnName("resultDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
//            Property(x => x.Isret).HasColumnName("isret").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Securauthstr).HasColumnName("securauthstr").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//        }
//    }

//    // pushNoticeQueue
//    public class PushNoticeQueueConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PushNoticeQueue>
//    {
//        public PushNoticeQueueConfiguration()
//            : this("dbo")
//        {
//        }

//        public PushNoticeQueueConfiguration(string schema)
//        {
//            ToTable(schema + ".pushNoticeQueue");
//            HasKey(x => x.Pushid);

//            Property(x => x.Pushid).HasColumnName("pushid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Payload).HasColumnName("payload").IsOptional().HasColumnType("nvarchar").HasMaxLength(2000);
//            Property(x => x.Pushcount).HasColumnName("pushcount").IsOptional().HasColumnType("int");
//            Property(x => x.Lastpushdt).HasColumnName("lastpushdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Devicetoken).HasColumnName("devicetoken").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Channels).HasColumnName("channels").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Priority).HasColumnName("Priority").IsOptional().HasColumnType("int");
//            Property(x => x.LastError).HasColumnName("LastError").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
//            Property(x => x.Noticetype).HasColumnName("noticetype").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//        }
//    }

//    // recommend
//    public class RecommendConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Recommend>
//    {
//        public RecommendConfiguration()
//            : this("dbo")
//        {
//        }

//        public RecommendConfiguration(string schema)
//        {
//            ToTable(schema + ".recommend");
//            HasKey(x => x.RecId);

//            Property(x => x.RecId).HasColumnName("recID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.RecUid).HasColumnName("recUid").IsOptional().HasColumnType("int");
//            Property(x => x.RecName).HasColumnName("recName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Shopname).HasColumnName("shopname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Townname).HasColumnName("townname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.DeliveryArea).HasColumnName("DeliveryArea").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Addr).HasColumnName("addr").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Tel).HasColumnName("tel").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ishandled).HasColumnName("ishandled").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Status).HasColumnName("status").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.RecDate).HasColumnName("recDate").IsOptional().HasColumnType("datetime");
//        }
//    }

//    // RecPaidAmountInfo
//    public class RecPaidAmountInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<RecPaidAmountInfo>
//    {
//        public RecPaidAmountInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public RecPaidAmountInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".RecPaidAmountInfo");
//            HasKey(x => x.Infoid);

//            Property(x => x.Infoid).HasColumnName("infoid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Basicamt).HasColumnName("basicamt").IsRequired().HasColumnType("numeric").HasPrecision(8, 2);
//            Property(x => x.Fromdt).HasColumnName("fromdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Todt).HasColumnName("todt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Basicamt2).HasColumnName("basicamt2").IsOptional().HasColumnType("numeric").HasPrecision(8, 2);
//        }
//    }

//    // serviceTicket
//    public class ServiceTicketConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ServiceTicket>
//    {
//        public ServiceTicketConfiguration()
//            : this("dbo")
//        {
//        }

//        public ServiceTicketConfiguration(string schema)
//        {
//            ToTable(schema + ".serviceTicket");
//            HasKey(x => x.Ticketid);

//            Property(x => x.Ticketid).HasColumnName("ticketid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Userid).HasColumnName("userid").IsOptional().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Tele).HasColumnName("tele").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Isnormal).HasColumnName("isnormal").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ismanager).HasColumnName("ismanager").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Iscritical).HasColumnName("iscritical").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
//            Property(x => x.Status).HasColumnName("status").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Createuser).HasColumnName("createuser").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Updatedt).HasColumnName("updatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Modifyuser).HasColumnName("modifyuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // shop
//    public class ShopConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shop>
//    {
//        public ShopConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopConfiguration(string schema)
//        {
//            ToTable(schema + ".shop");
//            HasKey(x => x.Shopid);

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mealtype).HasColumnName("mealtype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ServiceType).HasColumnName("serviceType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.ServiceTypeL).HasColumnName("serviceTypeL").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel2).HasColumnName("tel2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Fax).HasColumnName("fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Gotnotice).HasColumnName("gotnotice").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Contactname).HasColumnName("contactname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ContactTel).HasColumnName("contactTel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Longitude).HasColumnName("longitude").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Latitude).HasColumnName("latitude").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Logo).HasColumnName("logo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Vat).HasColumnName("VAT").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Mapstr).HasColumnName("mapstr").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//            Property(x => x.Star1).HasColumnName("star1").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star2).HasColumnName("star2").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star3).HasColumnName("star3").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star4).HasColumnName("star4").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.UpdateTime).HasColumnName("updateTime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag1).HasColumnName("flag1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Alias).HasColumnName("alias").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Acceptpay).HasColumnName("acceptpay").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Orderlang).HasColumnName("orderlang").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Acceptorder).HasColumnName("acceptorder").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.DeliveryWay).HasColumnName("deliveryWay").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Deliverytime).HasColumnName("Deliverytime").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.DeliveryLastOt).HasColumnName("DeliveryLastOT").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.DeliveryMinOrder).HasColumnName("DeliveryMinOrder").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Bankname).HasColumnName("bankname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Bankusername).HasColumnName("bankusername").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Banksortcode).HasColumnName("banksortcode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Bankno).HasColumnName("bankno").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Webcommision).HasColumnName("webcommision").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.Expireddt).HasColumnName("expireddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Bgpicture).HasColumnName("bgpicture").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cardchargeopt).HasColumnName("cardchargeopt").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Fixchargeamt).HasColumnName("fixchargeamt").IsOptional().HasColumnType("numeric").HasPrecision(4, 2);
//            Property(x => x.Ratiochargeamt).HasColumnName("ratiochargeamt").IsOptional().HasColumnType("numeric").HasPrecision(4, 2);
//            Property(x => x.SuggestOnlineNum).HasColumnName("suggestOnlineNum").IsOptional().HasColumnType("int");
//            Property(x => x.AcceptCustomerOpt).HasColumnName("acceptCustomerOpt").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(50);
//        }
//    }

//    // shopDelieveryArea
//    public class ShopDelieveryAreaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShopDelieveryArea>
//    {
//        public ShopDelieveryAreaConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopDelieveryAreaConfiguration(string schema)
//        {
//            ToTable(schema + ".shopDelieveryArea");
//            HasKey(x => x.Did);

//            Property(x => x.Did).HasColumnName("did").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.DelieveryCost).HasColumnName("delieveryCost").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.CreateDt).HasColumnName("createDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag1).HasColumnName("flag1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Bak001).HasColumnName("bak001").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // shopdeliveryCost
//    public class ShopdeliveryCostConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShopdeliveryCost>
//    {
//        public ShopdeliveryCostConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopdeliveryCostConfiguration(string schema)
//        {
//            ToTable(schema + ".shopdeliveryCost");
//            HasKey(x => x.Costid);

//            Property(x => x.Costid).HasColumnName("costid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Costtype).HasColumnName("costtype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.BasicDistance).HasColumnName("basicDistance").IsOptional().HasColumnType("int");
//            Property(x => x.BasicPrice).HasColumnName("basicPrice").IsOptional().HasColumnType("decimal").HasPrecision(10, 2);
//            Property(x => x.UnitDistance).HasColumnName("unitDistance").IsOptional().HasColumnType("int");
//            Property(x => x.UnitRate).HasColumnName("unitRate").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.IsDiscount).HasColumnName("isDiscount").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.BasicDistance2).HasColumnName("basicDistance2").IsOptional().HasColumnType("int");
//            Property(x => x.MinOrderAmount).HasColumnName("minOrderAmount").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.FreeAmount).HasColumnName("freeAmount").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//        }
//    }

//    // shopdiscount
//    public class ShopdiscountConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shopdiscount>
//    {
//        public ShopdiscountConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopdiscountConfiguration(string schema)
//        {
//            ToTable(schema + ".shopdiscount");
//            HasKey(x => x.Shopid);

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Board).HasColumnName("board").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Discountway).HasColumnName("discountway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Minorderamt).HasColumnName("minorderamt").IsOptional().HasColumnType("decimal").HasPrecision(10, 2);
//            Property(x => x.Discountrate).HasColumnName("discountrate").IsOptional().HasColumnType("int");
//        }
//    }

//    // ShopExtInfoForApp
//    public class ShopExtInfoForAppConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShopExtInfoForApp>
//    {
//        public ShopExtInfoForAppConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopExtInfoForAppConfiguration(string schema)
//        {
//            ToTable(schema + ".ShopExtInfoForApp");
//            HasKey(x => x.Shopid);

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.Createdt).HasColumnName("createdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Isaccepted).HasColumnName("isaccepted").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Acceptdt).HasColumnName("acceptdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Acceptuserid).HasColumnName("acceptuserid").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Recuserid).HasColumnName("recuserid").IsOptional().HasColumnType("int");
//            Property(x => x.Recamt).HasColumnName("recamt").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Ispaidrec).HasColumnName("ispaidrec").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Recpaiddt).HasColumnName("recpaiddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Operatename).HasColumnName("operatename").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Shopstatus).HasColumnName("shopstatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // shopJZ
//    public class ShopJzConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShopJz>
//    {
//        public ShopJzConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopJzConfiguration(string schema)
//        {
//            ToTable(schema + ".shopJZ");
//            HasKey(x => x.Jzid);

//            Property(x => x.Jzid).HasColumnName("jzid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Jzstartdt).HasColumnName("jzstartdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Jzenddt).HasColumnName("jzenddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Shopnum).HasColumnName("shopnum").IsOptional().HasColumnType("int");
//            Property(x => x.Totalamt).HasColumnName("totalamt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Orderamt).HasColumnName("orderamt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Actualamt).HasColumnName("actualamt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Ordernumber).HasColumnName("ordernumber").IsOptional().HasColumnType("int");
//            Property(x => x.Webamt).HasColumnName("webamt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Webactual).HasColumnName("webactual").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shopamt).HasColumnName("shopamt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Paytoshop).HasColumnName("paytoshop").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Str1).HasColumnName("str1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Str2).HasColumnName("str2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Bkint1).HasColumnName("bkint1").IsOptional().HasColumnType("int");
//            Property(x => x.Bknum1).HasColumnName("bknum1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Createuser).HasColumnName("createuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // shopJZDetail
//    public class ShopJzDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShopJzDetail>
//    {
//        public ShopJzDetailConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopJzDetailConfiguration(string schema)
//        {
//            ToTable(schema + ".shopJZDetail");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Jzid).HasColumnName("jzid").IsRequired().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Invoiceid).HasColumnName("invoiceid").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Frdt).HasColumnName("frdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Todt).HasColumnName("todt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Creatdt).HasColumnName("creatdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Amt1).HasColumnName("amt1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Quan1).HasColumnName("quan1").IsOptional().HasColumnType("int");
//            Property(x => x.Web1).HasColumnName("web1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shop1).HasColumnName("shop1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Amt2).HasColumnName("amt2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Quan2).HasColumnName("quan2").IsOptional().HasColumnType("int");
//            Property(x => x.Web2).HasColumnName("web2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shop2).HasColumnName("shop2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Amt3).HasColumnName("amt3").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Quan3).HasColumnName("quan3").IsOptional().HasColumnType("int");
//            Property(x => x.Web3).HasColumnName("web3").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shop3).HasColumnName("shop3").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Webactualget).HasColumnName("webactualget").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shopactualget).HasColumnName("shopactualget").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Num1).HasColumnName("num1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Num2).HasColumnName("num2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Str1).HasColumnName("str1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ishx).HasColumnName("ishx").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Amt1C).HasColumnName("amt1c").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//        }
//    }

//    // ShoppingCart
//    public class ShoppingCartConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShoppingCart>
//    {
//        public ShoppingCartConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShoppingCartConfiguration(string schema)
//        {
//            ToTable(schema + ".ShoppingCart");
//            HasKey(x => x.Cartid);

//            Property(x => x.Cartid).HasColumnName("cartid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.CustomerId).HasColumnName("customerID").IsOptional().HasColumnType("int");
//            Property(x => x.CustomerSessionId).HasColumnName("customerSessionID").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.CreatedOn).HasColumnName("CreatedOn").IsOptional().HasColumnType("datetime");
//            Property(x => x.UpdateOn).HasColumnName("UpdateOn").IsOptional().HasColumnType("datetime");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int");
//            Property(x => x.Mainfoodid).HasColumnName("mainfoodid").IsOptional().HasColumnType("int");
//            Property(x => x.SubProductId).HasColumnName("SubProductID").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
//            Property(x => x.Quantity).HasColumnName("Quantity").IsOptional().HasColumnType("int");
//            Property(x => x.MenuOptionIDs).HasColumnName("MenuOptionIDs").IsOptional().HasColumnType("nvarchar").HasMaxLength(1000);
//        }
//    }

//    // shoppingHoliday
//    public class ShoppingHolidayConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShoppingHoliday>
//    {
//        public ShoppingHolidayConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShoppingHolidayConfiguration(string schema)
//        {
//            ToTable(schema + ".shoppingHoliday");
//            HasKey(x => x.Holidayid);

//            Property(x => x.Holidayid).HasColumnName("holidayid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.FromDt).HasColumnName("fromDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.ToDt).HasColumnName("toDT").IsOptional().HasColumnType("datetime");
//        }
//    }

//    // shopTickets
//    public class ShopTicketConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ShopTicket>
//    {
//        public ShopTicketConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopTicketConfiguration(string schema)
//        {
//            ToTable(schema + ".shopTickets");
//            HasKey(x => x.Id);

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Ticketid).HasColumnName("ticketid").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Ticketname).HasColumnName("ticketname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Ticketdesc).HasColumnName("ticketdesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ticketvalue).HasColumnName("ticketvalue").IsRequired().HasColumnType("int");
//            Property(x => x.Tickettype).HasColumnName("tickettype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Starttime).HasColumnName("starttime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Endtime).HasColumnName("endtime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Isvalid).HasColumnName("isvalid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Operateid).HasColumnName("operateid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.CreateDt).HasColumnName("createDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Applyuid).HasColumnName("applyuid").IsOptional().HasColumnType("int");
//            Property(x => x.Isused).HasColumnName("isused").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Applydt).HasColumnName("applydt").IsOptional().HasColumnType("datetime");
//            Property(x => x.ApplyOrderId).HasColumnName("applyOrderID").IsOptional().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//        }
//    }

//    // shoptransactiondetail
//    public class ShoptransactiondetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shoptransactiondetail>
//    {
//        public ShoptransactiondetailConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShoptransactiondetailConfiguration(string schema)
//        {
//            ToTable(schema + ".shoptransactiondetail");
//            HasKey(x => x.Tid);

//            Property(x => x.Tid).HasColumnName("tid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Invoiceid).HasColumnName("invoiceid").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Orderdt).HasColumnName("orderdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Delieverdt).HasColumnName("delieverdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Orderamt).HasColumnName("orderamt").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Paydesc).HasColumnName("paydesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Comrate).HasColumnName("comrate").IsOptional().HasColumnType("decimal").HasPrecision(5, 2);
//            Property(x => x.Webcom).HasColumnName("webcom").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Shopyd).HasColumnName("shopyd").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Transtype).HasColumnName("transtype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Orderamtc).HasColumnName("orderamtc").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//        }
//    }

//    // shopviewtelrecord
//    public class ShopviewtelrecordConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shopviewtelrecord>
//    {
//        public ShopviewtelrecordConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopviewtelrecordConfiguration(string schema)
//        {
//            ToTable(schema + ".shopviewtelrecord");
//            HasKey(x => x.Infoid);

//            Property(x => x.Infoid).HasColumnName("infoid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Viewdt).HasColumnName("viewdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Viewcount).HasColumnName("viewcount").IsOptional().HasColumnType("int");
//        }
//    }

//    // shopworktime
//    public class ShopworktimeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Shopworktime>
//    {
//        public ShopworktimeConfiguration()
//            : this("dbo")
//        {
//        }

//        public ShopworktimeConfiguration(string schema)
//        {
//            ToTable(schema + ".shopworktime");
//            HasKey(x => x.Shopid);

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
//            Property(x => x.MonFrToA).HasColumnName("monFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.MonFrToB).HasColumnName("monFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.TuesFrToA).HasColumnName("tuesFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.TuesFrToB).HasColumnName("tuesFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.WedFrToA).HasColumnName("wedFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.WedFrToB).HasColumnName("wedFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.ThurFrToA).HasColumnName("thurFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.ThurFrToB).HasColumnName("thurFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.FriFrToA).HasColumnName("friFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.FriFrToB).HasColumnName("friFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SatFrToA).HasColumnName("satFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SatFrToB).HasColumnName("satFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SunFrToA).HasColumnName("sunFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SunFrToB).HasColumnName("sunFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.Wt001).HasColumnName("wt001").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Haslunch).HasColumnName("haslunch").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // submenu
//    public class SubmenuConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Submenu>
//    {
//        public SubmenuConfiguration()
//            : this("dbo")
//        {
//        }

//        public SubmenuConfiguration(string schema)
//        {
//            ToTable(schema + ".submenu");
//            HasKey(x => x.Smid);

//            Property(x => x.Smid).HasColumnName("smid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Mid).HasColumnName("mid").IsRequired().HasColumnType("int");
//            Property(x => x.MenuName).HasColumnName("menuName").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.MenuName2).HasColumnName("menuName2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.MenuDesc).HasColumnName("menuDesc").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.MenuDesc2).HasColumnName("menuDesc2").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Price).HasColumnName("price").IsOptional().HasColumnType("numeric").HasPrecision(8, 2);
//            Property(x => x.Submenucat).HasColumnName("submenucat").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//        }
//    }

//    // sysdiagrams
//    public class SysdiagramConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Sysdiagram>
//    {
//        public SysdiagramConfiguration()
//            : this("dbo")
//        {
//        }

//        public SysdiagramConfiguration(string schema)
//        {
//            ToTable(schema + ".sysdiagrams");
//            HasKey(x => x.DiagramId);

//            Property(x => x.Name).HasColumnName("name").IsRequired().HasColumnType("nvarchar").HasMaxLength(128);
//            Property(x => x.PrincipalId).HasColumnName("principal_id").IsRequired().HasColumnType("int");
//            Property(x => x.DiagramId).HasColumnName("diagram_id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Version).HasColumnName("version").IsOptional().HasColumnType("int");
//            Property(x => x.Definition).HasColumnName("definition").IsOptional().HasColumnType("varbinary");
//        }
//    }

//    // sysLog
//    public class SysLogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysLog>
//    {
//        public SysLogConfiguration()
//            : this("dbo")
//        {
//        }

//        public SysLogConfiguration(string schema)
//        {
//            ToTable(schema + ".sysLog");
//            HasKey(x => x.Logid);

//            Property(x => x.Logid).HasColumnName("logid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Userid).HasColumnName("userid").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Actstr).HasColumnName("actstr").IsRequired().HasColumnType("nvarchar").HasMaxLength(800);
//            Property(x => x.Actdt).HasColumnName("actdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Priority).HasColumnName("priority").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//        }
//    }

//    // sysMsg
//    public class SysMsgConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SysMsg>
//    {
//        public SysMsgConfiguration()
//            : this("dbo")
//        {
//        }

//        public SysMsgConfiguration(string schema)
//        {
//            ToTable(schema + ".sysMsg");
//            HasKey(x => x.Msgid);

//            Property(x => x.Msgid).HasColumnName("msgid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Msgtitle).HasColumnName("msgtitle").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Msgcontent).HasColumnName("msgcontent").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Msgdt).HasColumnName("msgdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Msgto).HasColumnName("msgto").IsRequired().HasColumnType("int");
//            Property(x => x.Isread).HasColumnName("isread").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Readdt).HasColumnName("readdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Isdelete).HasColumnName("isdelete").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//        }
//    }

//    // UserCreditInfo
//    public class UserCreditInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserCreditInfo>
//    {
//        public UserCreditInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public UserCreditInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".UserCreditInfo");
//            HasKey(x => x.Balanceid);

//            Property(x => x.Balanceid).HasColumnName("balanceid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Userid).HasColumnName("userid").IsRequired().HasColumnType("int");
//            Property(x => x.Createdt).HasColumnName("createdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Moneydirection).HasColumnName("moneydirection").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(2);
//            Property(x => x.Amt).HasColumnName("amt").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Comment).HasColumnName("comment").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Balanceamt).HasColumnName("balanceamt").IsRequired().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//        }
//    }

//    // UserReg
//    public class UserRegConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<UserReg>
//    {
//        public UserRegConfiguration()
//            : this("dbo")
//        {
//        }

//        public UserRegConfiguration(string schema)
//        {
//            ToTable(schema + ".UserReg");
//            HasKey(x => x.Uid);

//            Property(x => x.Utype).HasColumnName("utype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Gender).HasColumnName("gender").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Realname).HasColumnName("realname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Email).HasColumnName("email").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Pwd).HasColumnName("pwd").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Pwdquestion).HasColumnName("pwdquestion").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Pwdanswer).HasColumnName("pwdanswer").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Birthday).HasColumnName("birthday").IsOptional().HasColumnType("nvarchar").HasMaxLength(25);
//            Property(x => x.Lastlogindate).HasColumnName("lastlogindate").IsOptional().HasColumnType("datetime");
//            Property(x => x.LastloginIp).HasColumnName("lastloginIP").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Islocked).HasColumnName("islocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Score).HasColumnName("score").IsOptional().HasColumnType("int");
//            Property(x => x.Credits).HasColumnName("credits").IsOptional().HasColumnType("int");
//            Property(x => x.Isblocked).HasColumnName("isblocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isnoticed).HasColumnName("isnoticed").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.LoginErrTime).HasColumnName("loginErrTime").IsOptional().HasColumnType("int");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Houseno).HasColumnName("houseno").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//        }
//    }

//    // userscore
//    public class UserscoreConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Userscore>
//    {
//        public UserscoreConfiguration()
//            : this("dbo")
//        {
//        }

//        public UserscoreConfiguration(string schema)
//        {
//            ToTable(schema + ".userscore");
//            HasKey(x => x.Sid);

//            Property(x => x.Sid).HasColumnName("sid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Uid).HasColumnName("uid").IsOptional().HasColumnType("int");
//            Property(x => x.Scoretime).HasColumnName("scoretime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Operateuser).HasColumnName("operateuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Score).HasColumnName("score").IsOptional().HasColumnType("int");
//            Property(x => x.Operation).HasColumnName("operation").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Scoretype).HasColumnName("scoretype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//        }
//    }

//    // voucherinfo
//    public class VoucherinfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Voucherinfo>
//    {
//        public VoucherinfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VoucherinfoConfiguration(string schema)
//        {
//            ToTable(schema + ".voucherinfo");
//            HasKey(x => x.Voucherid);

//            Property(x => x.Voucherid).HasColumnName("voucherid").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Vouchercode).HasColumnName("vouchercode").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Fromdt).HasColumnName("fromdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Todt).HasColumnName("todt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Discountopt).HasColumnName("discountopt").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Discountamt).HasColumnName("discountamt").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.Basicamt).HasColumnName("basicamt").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.Areacode).HasColumnName("areacode").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Salesname).HasColumnName("salesname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Userid).HasColumnName("userid").IsOptional().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Vouchercount).HasColumnName("vouchercount").IsOptional().HasColumnType("int");
//            Property(x => x.Usesperuser).HasColumnName("usesperuser").IsOptional().HasColumnType("int");
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createuser).HasColumnName("createuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Comment).HasColumnName("comment").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Isdelete).HasColumnName("isdelete").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
//            Property(x => x.Isused).HasColumnName("isused").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
//            Property(x => x.Creditback).HasColumnName("creditback").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//        }
//    }

//    // vwAppUserProfile
//    public class VwAppUserProfileConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwAppUserProfile>
//    {
//        public VwAppUserProfileConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwAppUserProfileConfiguration(string schema)
//        {
//            ToTable(schema + ".vwAppUserProfile");
//            HasKey(x => new { x.Appuserid, x.Usertype });

//            Property(x => x.Operatecode).HasColumnName("operatecode").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Offdutytodt).HasColumnName("offdutytodt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Onduty).HasColumnName("onduty").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Infoalertfile).HasColumnName("infoalertfile").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Neworderalertfile).HasColumnName("neworderalertfile").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Istakeorder).HasColumnName("istakeorder").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Devicetoken).HasColumnName("devicetoken").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Appuserid).HasColumnName("appuserid").IsRequired().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Loginname).HasColumnName("loginname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Password).HasColumnName("password").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Usertype).HasColumnName("usertype").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Username).HasColumnName("username").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Status).HasColumnName("status").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Logindt).HasColumnName("logindt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createuser).HasColumnName("createuser").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Loginip).HasColumnName("loginip").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Loginstatus).HasColumnName("loginstatus").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
//            Property(x => x.LoginErrCount).HasColumnName("LoginErrCount").IsOptional().HasColumnType("int");
//            Property(x => x.Apptokenstr).HasColumnName("apptokenstr").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // vw_customerreview
//    public class VwCustomerreviewConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwCustomerreview>
//    {
//        public VwCustomerreviewConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwCustomerreviewConfiguration(string schema)
//        {
//            ToTable(schema + ".vw_customerreview");
//            HasKey(x => new { x.Sname, x.Reviewid, x.Shopid });

//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Reviewid).HasColumnName("reviewid").IsRequired().HasColumnType("int");
//            Property(x => x.Rate1).HasColumnName("rate1").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Rate2).HasColumnName("rate2").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Rate3).HasColumnName("rate3").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Townname).HasColumnName("townname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ReviewDate).HasColumnName("reviewDate").IsOptional().HasColumnType("datetime");
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Comment).HasColumnName("comment").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Username).HasColumnName("username").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Uid).HasColumnName("uid").IsOptional().HasColumnType("int");
//            Property(x => x.Rate4).HasColumnName("rate4").IsOptional().HasColumnType("decimal").HasPrecision(2, 1);
//            Property(x => x.Reviewtype).HasColumnName("reviewtype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Objid).HasColumnName("objid").IsOptional().HasColumnType("int");
//        }
//    }

//    // vwGetAppDeviceInfo
//    public class VwGetAppDeviceInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetAppDeviceInfo>
//    {
//        public VwGetAppDeviceInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetAppDeviceInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetAppDeviceInfo");
//            HasKey(x => x.Deviceid);

//            Property(x => x.Deviceid).HasColumnName("deviceid").IsRequired().HasColumnType("int");
//            Property(x => x.Devicetoken).HasColumnName("devicetoken").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Devicetype).HasColumnName("devicetype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Deviceversion).HasColumnName("deviceversion").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Registdt).HasColumnName("registdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Channels).HasColumnName("channels").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.LastHeartbeatAt).HasColumnName("LastHeartbeatAt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Loginname).HasColumnName("loginname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//        }
//    }

//    // vwGetAppRestInfo
//    public class VwGetAppRestInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetAppRestInfo>
//    {
//        public VwGetAppRestInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetAppRestInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetAppRestInfo");
//            HasKey(x => new { x.Shopid, x.Createdt, x.Sname });

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Createdt).HasColumnName("createdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Isaccepted).HasColumnName("isaccepted").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Acceptdt).HasColumnName("acceptdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Acceptuserid).HasColumnName("acceptuserid").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Recuserid).HasColumnName("recuserid").IsOptional().HasColumnType("int");
//            Property(x => x.Recamt).HasColumnName("recamt").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Ispaidrec).HasColumnName("ispaidrec").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Recpaiddt).HasColumnName("recpaiddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Operatename).HasColumnName("operatename").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Shopstatus).HasColumnName("shopstatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Contactname).HasColumnName("contactname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ContactTel).HasColumnName("contactTel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // vwGetOrderInfo
//    public class VwGetOrderInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetOrderInfo>
//    {
//        public VwGetOrderInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetOrderInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetOrderInfo");
//            HasKey(x => new { x.Shopid, x.OrderId, x.Uid });

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Useremail).HasColumnName("useremail").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ordercreatedt).HasColumnName("ordercreatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Deliveryway).HasColumnName("deliveryway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ispaid).HasColumnName("ispaid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Payway).HasColumnName("payway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Pickupdt).HasColumnName("pickupdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Orderstatustxt).HasColumnName("orderstatustxt").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Totalamount).HasColumnName("totalamount").IsOptional().HasColumnType("numeric").HasPrecision(13, 4);
//        }
//    }

//    // vwGetOrderInfoForAdmin
//    public class VwGetOrderInfoForAdminConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetOrderInfoForAdmin>
//    {
//        public VwGetOrderInfoForAdminConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetOrderInfoForAdminConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetOrderInfoForAdmin");
//            HasKey(x => new { x.Shopid, x.OrderId, x.Uid });

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Useremail).HasColumnName("useremail").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ordercreatedt).HasColumnName("ordercreatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Orderstatus).HasColumnName("orderstatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Deliveryway).HasColumnName("deliveryway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ispaid).HasColumnName("ispaid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Payway).HasColumnName("payway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Pickupdt).HasColumnName("pickupdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Orderstatustxt).HasColumnName("orderstatustxt").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Isonline).HasColumnName("isonline").IsOptional().HasColumnType("datetime");
//            Property(x => x.Acceptorder).HasColumnName("acceptorder").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Isjz).HasColumnName("isjz").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.IsCancelled).HasColumnName("isCancelled").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Comrate).HasColumnName("comrate").IsOptional().HasColumnType("decimal").HasPrecision(6, 2);
//            Property(x => x.Totalamount).HasColumnName("totalamount").IsOptional().HasColumnType("numeric").HasPrecision(13, 4);
//        }
//    }

//    // vwGetOrderListForApp
//    public class VwGetOrderListForAppConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetOrderListForApp>
//    {
//        public VwGetOrderListForAppConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetOrderListForAppConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetOrderListForApp");
//            HasKey(x => new { x.Shopid, x.OrderId });

//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Deliverdt).HasColumnName("deliverdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Payway).HasColumnName("payway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Deliveryway).HasColumnName("deliveryway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Pickupdt).HasColumnName("pickupdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Ordercreatedt).HasColumnName("ordercreatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.IsCancelled).HasColumnName("isCancelled").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ispaid).HasColumnName("ispaid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.OrderCancelledDt).HasColumnName("orderCancelledDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.Townname).HasColumnName("townname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Totalamount).HasColumnName("totalamount").IsOptional().HasColumnType("numeric").HasPrecision(13, 4);
//        }
//    }

//    // vwGetShopInfo
//    public class VwGetShopInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetShopInfo>
//    {
//        public VwGetShopInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetShopInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetShopInfo");
//            HasKey(x => new { x.Loginname, x.Uid, x.Shopstatus });

//            Property(x => x.Loginname).HasColumnName("loginname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mealtype).HasColumnName("mealtype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ServiceType).HasColumnName("serviceType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel2).HasColumnName("tel2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Fax).HasColumnName("fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Gotnotice).HasColumnName("gotnotice").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Contactname).HasColumnName("contactname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ContactTel).HasColumnName("contactTel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Logo).HasColumnName("logo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Vat).HasColumnName("VAT").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//            Property(x => x.Star1).HasColumnName("star1").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star2).HasColumnName("star2").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star3).HasColumnName("star3").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star4).HasColumnName("star4").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.UpdateTime).HasColumnName("updateTime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag1).HasColumnName("flag1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Alias).HasColumnName("alias").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.MonFrToA).HasColumnName("monFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.MonFrToB).HasColumnName("monFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.TuesFrToB).HasColumnName("tuesFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.TuesFrToA).HasColumnName("tuesFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.WedFrToA).HasColumnName("wedFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.WedFrToB).HasColumnName("wedFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.ThurFrToA).HasColumnName("thurFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.ThurFrToB).HasColumnName("thurFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.FriFrToA).HasColumnName("friFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.FriFrToB).HasColumnName("friFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SatFrToA).HasColumnName("satFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SatFrToB).HasColumnName("satFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SunFrToA).HasColumnName("sunFrToA").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.SunFrToB).HasColumnName("sunFrToB").IsOptional().HasColumnType("nvarchar").HasMaxLength(80);
//            Property(x => x.Utype).HasColumnName("utype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Islocked).HasColumnName("islocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.DeliveryMinOrder).HasColumnName("DeliveryMinOrder").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.DeliveryLastOt).HasColumnName("DeliveryLastOT").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Deliverytime).HasColumnName("Deliverytime").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.DeliveryWay).HasColumnName("deliveryWay").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Acceptorder).HasColumnName("acceptorder").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Acceptpay).HasColumnName("acceptpay").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Haslunch).HasColumnName("haslunch").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.ServiceTypeL).HasColumnName("serviceTypeL").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.SuggestOnlineNum).HasColumnName("suggestOnlineNum").IsOptional().HasColumnType("int");
//            Property(x => x.AcceptCustomerOpt).HasColumnName("acceptCustomerOpt").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(50);
//            Property(x => x.Webcommision).HasColumnName("webcommision").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.Shopstatus).HasColumnName("shopstatus").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
//        }
//    }

//    // vwGetShopInfo2
//    public class VwGetShopInfo2Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetShopInfo2>
//    {
//        public VwGetShopInfo2Configuration()
//            : this("dbo")
//        {
//        }

//        public VwGetShopInfo2Configuration(string schema)
//        {
//            ToTable(schema + ".vwGetShopInfo2");
//            HasKey(x => new { x.Loginname, x.Uid });

//            Property(x => x.Loginname).HasColumnName("loginname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Islocked).HasColumnName("islocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.LastloginIp).HasColumnName("lastloginIP").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Lastlogindate).HasColumnName("lastlogindate").IsOptional().HasColumnType("datetime");
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Sname).HasColumnName("sname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mealtype).HasColumnName("mealtype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ServiceType).HasColumnName("serviceType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel2).HasColumnName("tel2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Fax).HasColumnName("fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Gotnotice).HasColumnName("gotnotice").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Contactname).HasColumnName("contactname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ContactTel).HasColumnName("contactTel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Logo).HasColumnName("logo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Vat).HasColumnName("VAT").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//            Property(x => x.Star1).HasColumnName("star1").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star2).HasColumnName("star2").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star3).HasColumnName("star3").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star4).HasColumnName("star4").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.UpdateTime).HasColumnName("updateTime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag1).HasColumnName("flag1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Alias).HasColumnName("alias").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Acceptorder).HasColumnName("acceptorder").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Utype).HasColumnName("utype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isonline).HasColumnName("isonline").IsOptional().HasColumnType("datetime");
//            Property(x => x.SuggestOnlineNum).HasColumnName("suggestOnlineNum").IsOptional().HasColumnType("int");
//            Property(x => x.AcceptCustomerOpt).HasColumnName("acceptCustomerOpt").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(50);
//        }
//    }

//    // vwGetShopJZDetail
//    public class VwGetShopJzDetailConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetShopJzDetail>
//    {
//        public VwGetShopJzDetailConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetShopJzDetailConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetShopJZDetail");
//            HasKey(x => new { x.Id, x.Jzid, x.Shopid, x.Ishx });

//            Property(x => x.Id).HasColumnName("id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Jzid).HasColumnName("jzid").IsRequired().HasColumnType("int");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Invoiceid).HasColumnName("invoiceid").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Frdt).HasColumnName("frdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Todt).HasColumnName("todt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Creatdt).HasColumnName("creatdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Amt1).HasColumnName("amt1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Web1).HasColumnName("web1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shop1).HasColumnName("shop1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Amt2).HasColumnName("amt2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Web2).HasColumnName("web2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shop2).HasColumnName("shop2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Amt3).HasColumnName("amt3").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Quan3).HasColumnName("quan3").IsOptional().HasColumnType("int");
//            Property(x => x.Web3).HasColumnName("web3").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shop3).HasColumnName("shop3").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Webactualget).HasColumnName("webactualget").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Shopactualget).HasColumnName("shopactualget").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Num1).HasColumnName("num1").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Num2).HasColumnName("num2").IsOptional().HasColumnType("decimal").HasPrecision(18, 2);
//            Property(x => x.Str1).HasColumnName("str1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ishx).HasColumnName("ishx").IsRequired().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Shoploginname).HasColumnName("shoploginname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Ordernum).HasColumnName("ordernum").IsOptional().HasColumnType("int");
//        }
//    }

//    // vwGetUserBalanceSummary
//    public class VwGetUserBalanceSummaryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetUserBalanceSummary>
//    {
//        public VwGetUserBalanceSummaryConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetUserBalanceSummaryConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetUserBalanceSummary");
//            HasKey(x => new { x.Userid, x.Balanceamt, x.Email });

//            Property(x => x.Utype).HasColumnName("utype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Userid).HasColumnName("userid").IsRequired().HasColumnType("int");
//            Property(x => x.Balanceamt).HasColumnName("balanceamt").IsRequired().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Email).HasColumnName("email").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // vwGetUserFavShopInfo
//    public class VwGetUserFavShopInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetUserFavShopInfo>
//    {
//        public VwGetUserFavShopInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetUserFavShopInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetUserFavShopInfo");
//            HasKey(x => new { x.Fid, x.Uid, x.Sname });

//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Fid).HasColumnName("fid").IsRequired().HasColumnType("int");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Ftype).HasColumnName("ftype").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(10);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Logo).HasColumnName("logo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Alias).HasColumnName("alias").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // vwGetUserInfo
//    public class VwGetUserInfoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwGetUserInfo>
//    {
//        public VwGetUserInfoConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwGetUserInfoConfiguration(string schema)
//        {
//            ToTable(schema + ".vwGetUserInfo");
//            HasKey(x => new { x.Uid, x.Email });

//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Utype).HasColumnName("utype").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Gender).HasColumnName("gender").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Realname).HasColumnName("realname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Email).HasColumnName("email").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Pwd).HasColumnName("pwd").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Pwdquestion).HasColumnName("pwdquestion").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Pwdanswer).HasColumnName("pwdanswer").IsOptional().HasColumnType("nvarchar").HasMaxLength(200);
//            Property(x => x.Birthday).HasColumnName("birthday").IsOptional().HasColumnType("nvarchar").HasMaxLength(25);
//            Property(x => x.Lastlogindate).HasColumnName("lastlogindate").IsOptional().HasColumnType("datetime");
//            Property(x => x.LastloginIp).HasColumnName("lastloginIP").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Islocked).HasColumnName("islocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Score).HasColumnName("score").IsOptional().HasColumnType("int");
//            Property(x => x.Isblocked).HasColumnName("isblocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isnoticed).HasColumnName("isnoticed").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Createdt).HasColumnName("createdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.LoginErrTime).HasColumnName("loginErrTime").IsOptional().HasColumnType("int");
//            Property(x => x.Mobile).HasColumnName("mobile").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Credits).HasColumnName("credits").IsOptional().HasColumnType("int");
//        }
//    }

//    // vwOrdersValid
//    public class VwOrdersValidConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwOrdersValid>
//    {
//        public VwOrdersValidConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwOrdersValidConfiguration(string schema)
//        {
//            ToTable(schema + ".vwOrdersValid");
//            HasKey(x => new { x.OrderId, x.Shopid, x.Uid });

//            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Useremail).HasColumnName("useremail").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Amount).HasColumnName("amount").IsOptional().HasColumnType("int");
//            Property(x => x.Unitprice).HasColumnName("unitprice").IsOptional().HasColumnType("decimal").HasPrecision(10, 4);
//            Property(x => x.Payway).HasColumnName("payway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ispaid).HasColumnName("ispaid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Ticketnumber).HasColumnName("ticketnumber").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Ticketvalue).HasColumnName("ticketvalue").IsOptional().HasColumnType("int");
//            Property(x => x.Deliveryway).HasColumnName("deliveryway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Pickupdt).HasColumnName("pickupdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Comments).HasColumnName("comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Orderstatus).HasColumnName("orderstatus").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Ordercreatedt).HasColumnName("ordercreatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.OrderUpdatedt).HasColumnName("orderUpdatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.IsCancelled).HasColumnName("isCancelled").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.OrderCancelledDt).HasColumnName("orderCancelledDT").IsOptional().HasColumnType("datetime");
//            Property(x => x.CancelComments).HasColumnName("cancelComments").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Totalamount).HasColumnName("totalamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Totalprice1).HasColumnName("totalprice1").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.DiscountRate).HasColumnName("discountRate").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Afterdiscount).HasColumnName("afterdiscount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Deliverycharge).HasColumnName("deliverycharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.ServiceCharge).HasColumnName("serviceCharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.CreditcardCharge).HasColumnName("creditcardCharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Tips).HasColumnName("tips").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Isjz).HasColumnName("isjz").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Jzdt).HasColumnName("jzdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Actualamount).HasColumnName("actualamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.UserIp).HasColumnName("userIP").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Isnew).HasColumnName("isnew").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Comrate).HasColumnName("comrate").IsOptional().HasColumnType("decimal").HasPrecision(6, 2);
//        }
//    }

//    // vwShopOrders
//    public class VwShopOrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwShopOrder>
//    {
//        public VwShopOrderConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwShopOrderConfiguration(string schema)
//        {
//            ToTable(schema + ".vwShopOrders");
//            HasKey(x => new { x.Shopid, x.Sname });

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Expr1).HasColumnName("Expr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(101);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Count).HasColumnName("count").IsOptional().HasColumnType("int");
//            Property(x => x.Sum).HasColumnName("sum").IsOptional().HasColumnType("numeric").HasPrecision(38, 4);
//        }
//    }

//    // vwShopsValid
//    public class VwShopsValidConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwShopsValid>
//    {
//        public VwShopsValidConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwShopsValidConfiguration(string schema)
//        {
//            ToTable(schema + ".vwShopsValid");
//            HasKey(x => new { x.Shopid, x.Sname, x.Uid });

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Mealtype).HasColumnName("mealtype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ServiceType).HasColumnName("serviceType").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.ServiceTypeL).HasColumnName("serviceTypeL").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel2).HasColumnName("tel2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Fax).HasColumnName("fax").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Email).HasColumnName("email").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Gotnotice).HasColumnName("gotnotice").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Contactname).HasColumnName("contactname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ContactTel).HasColumnName("contactTel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr3).HasColumnName("addr3").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Longitude).HasColumnName("longitude").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Latitude).HasColumnName("latitude").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.Logo).HasColumnName("logo").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Vat).HasColumnName("VAT").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Mapstr).HasColumnName("mapstr").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Description).HasColumnName("description").IsOptional().HasColumnType("nvarchar").HasMaxLength(3000);
//            Property(x => x.Star1).HasColumnName("star1").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star2).HasColumnName("star2").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star3).HasColumnName("star3").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.Star4).HasColumnName("star4").IsOptional().HasColumnType("numeric").HasPrecision(5, 1);
//            Property(x => x.UpdateTime).HasColumnName("updateTime").IsOptional().HasColumnType("datetime");
//            Property(x => x.Flag1).HasColumnName("flag1").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Alias).HasColumnName("alias").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Acceptpay).HasColumnName("acceptpay").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Orderlang).HasColumnName("orderlang").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//            Property(x => x.Acceptorder).HasColumnName("acceptorder").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
//            Property(x => x.DeliveryWay).HasColumnName("deliveryWay").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Deliverytime).HasColumnName("Deliverytime").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.DeliveryLastOt).HasColumnName("DeliveryLastOT").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.DeliveryMinOrder).HasColumnName("DeliveryMinOrder").IsOptional().HasColumnType("decimal").HasPrecision(8, 2);
//            Property(x => x.Bankname).HasColumnName("bankname").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Bankusername).HasColumnName("bankusername").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Banksortcode).HasColumnName("banksortcode").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Bankno).HasColumnName("bankno").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Webcommision).HasColumnName("webcommision").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.Expireddt).HasColumnName("expireddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Isblocked).HasColumnName("isblocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//        }
//    }

//    // vwSysMsg
//    public class VwSysMsgConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwSysMsg>
//    {
//        public VwSysMsgConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwSysMsgConfiguration(string schema)
//        {
//            ToTable(schema + ".vwSysMsg");
//            HasKey(x => new { x.Msgto, x.Msgid, x.Msgtitle, x.Msgdt, x.Msgcontent, x.Email });

//            Property(x => x.Msgto).HasColumnName("msgto").IsRequired().HasColumnType("int");
//            Property(x => x.Msgid).HasColumnName("msgid").IsRequired().HasColumnType("int");
//            Property(x => x.Msgtitle).HasColumnName("msgtitle").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Msgdt).HasColumnName("msgdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Msgcontent).HasColumnName("msgcontent").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Isread).HasColumnName("isread").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Isdelete).HasColumnName("isdelete").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Readdt).HasColumnName("readdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Email).HasColumnName("email").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }

//    // vwUser2Device
//    public class VwUser2DeviceConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwUser2Device>
//    {
//        public VwUser2DeviceConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwUser2DeviceConfiguration(string schema)
//        {
//            ToTable(schema + ".vwUser2Device");
//            HasKey(x => x.Deviceid);

//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Appuserid).HasColumnName("appuserid").IsOptional().HasColumnType("int");
//            Property(x => x.Devicetoken).HasColumnName("devicetoken").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Devicetype).HasColumnName("devicetype").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Deviceversion).HasColumnName("deviceversion").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Registdt).HasColumnName("registdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Channels).HasColumnName("channels").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.LastHeartbeatAt).HasColumnName("LastHeartbeatAt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Deviceid).HasColumnName("deviceid").IsRequired().HasColumnType("int");
//        }
//    }

//    // vwUserBalanceSummary
//    public class VwUserBalanceSummaryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwUserBalanceSummary>
//    {
//        public VwUserBalanceSummaryConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwUserBalanceSummaryConfiguration(string schema)
//        {
//            ToTable(schema + ".vwUserBalanceSummary");
//            HasKey(x => new { x.Balanceid, x.Userid, x.Createdt, x.Moneydirection, x.Balanceamt });

//            Property(x => x.Balanceid).HasColumnName("balanceid").IsRequired().HasColumnType("numeric").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
//            Property(x => x.Userid).HasColumnName("userid").IsRequired().HasColumnType("int");
//            Property(x => x.Createdt).HasColumnName("createdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Moneydirection).HasColumnName("moneydirection").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(2);
//            Property(x => x.Amt).HasColumnName("amt").IsOptional().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Comment).HasColumnName("comment").IsOptional().HasColumnType("nvarchar").HasMaxLength(500);
//            Property(x => x.Balanceamt).HasColumnName("balanceamt").IsRequired().HasColumnType("numeric").HasPrecision(10, 2);
//            Property(x => x.Shopid).HasColumnName("shopid").IsOptional().HasColumnType("int");
//            Property(x => x.Orderid).HasColumnName("orderid").IsOptional().HasColumnType("nvarchar").HasMaxLength(30);
//        }
//    }

//    // vwValidOrders
//    public class VwValidOrderConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwValidOrder>
//    {
//        public VwValidOrderConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwValidOrderConfiguration(string schema)
//        {
//            ToTable(schema + ".vwValidOrders");
//            HasKey(x => new { x.OrderId, x.Shopid, x.Uid });

//            Property(x => x.OrderId).HasColumnName("OrderID").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
//            Property(x => x.Payway).HasColumnName("payway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Uid).HasColumnName("uid").IsRequired().HasColumnType("int");
//            Property(x => x.Ispaid).HasColumnName("ispaid").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Deliveryway).HasColumnName("deliveryway").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Pickupdt).HasColumnName("pickupdt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Ordercreatedt).HasColumnName("ordercreatedt").IsOptional().HasColumnType("datetime");
//            Property(x => x.IsCancelled).HasColumnName("isCancelled").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Totalamount).HasColumnName("totalamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Totalprice1).HasColumnName("totalprice1").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Afterdiscount).HasColumnName("afterdiscount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Deliverycharge).HasColumnName("deliverycharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.CreditcardCharge).HasColumnName("creditcardCharge").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Tips).HasColumnName("tips").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Actualamount).HasColumnName("actualamount").IsOptional().HasColumnType("numeric").HasPrecision(10, 4);
//            Property(x => x.Isjz).HasColumnName("isjz").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Comrate).HasColumnName("comrate").IsOptional().HasColumnType("decimal").HasPrecision(6, 2);
//        }
//    }

//    // vwValidShops
//    public class VwValidShopConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwValidShop>
//    {
//        public VwValidShopConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwValidShopConfiguration(string schema)
//        {
//            ToTable(schema + ".vwValidShops");
//            HasKey(x => new { x.Shopid, x.Sname });

//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Tel1).HasColumnName("tel1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Tel2).HasColumnName("tel2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.ContactTel).HasColumnName("contactTel").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Addr1).HasColumnName("addr1").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Addr2).HasColumnName("addr2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Cityname).HasColumnName("cityname").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Postcode1).HasColumnName("postcode1").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Postcode2).HasColumnName("postcode2").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
//            Property(x => x.Webcommision).HasColumnName("webcommision").IsOptional().HasColumnType("numeric").HasPrecision(5, 2);
//            Property(x => x.Expireddt).HasColumnName("expireddt").IsOptional().HasColumnType("datetime");
//            Property(x => x.Islocked).HasColumnName("islocked").IsOptional().IsFixedLength().IsUnicode(false).HasColumnType("char").HasMaxLength(1);
//            Property(x => x.Acceptpay).HasColumnName("acceptpay").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
//        }
//    }

//    // vwviewtel
//    public class VwviewtelConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Vwviewtel>
//    {
//        public VwviewtelConfiguration()
//            : this("dbo")
//        {
//        }

//        public VwviewtelConfiguration(string schema)
//        {
//            ToTable(schema + ".vwviewtel");
//            HasKey(x => new { x.Infoid, x.Shopid, x.Viewdt, x.Sname });

//            Property(x => x.Infoid).HasColumnName("infoid").IsRequired().HasColumnType("numeric");
//            Property(x => x.Shopid).HasColumnName("shopid").IsRequired().HasColumnType("int");
//            Property(x => x.Viewdt).HasColumnName("viewdt").IsRequired().HasColumnType("datetime");
//            Property(x => x.Viewcount).HasColumnName("viewcount").IsOptional().HasColumnType("int");
//            Property(x => x.Sname).HasColumnName("sname").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
//            Property(x => x.Sname2).HasColumnName("sname2").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
//        }
//    }


//    // ************************************************************************
//    // Stored procedure return models

//    public class GetShopByPostCodeReturnModel
//    {
//        public System.String loginname { get; set; }
//        public System.Int32 uid { get; set; }
//        public System.String sname { get; set; }
//        public System.Int32? shopid { get; set; }
//        public System.String sname2 { get; set; }
//        public System.String mealtype { get; set; }
//        public System.String serviceType { get; set; }
//        public System.String tel1 { get; set; }
//        public System.String tel2 { get; set; }
//        public System.String fax { get; set; }
//        public System.String email { get; set; }
//        public System.String gotnotice { get; set; }
//        public System.String contactname { get; set; }
//        public System.String contactTel { get; set; }
//        public System.String addr1 { get; set; }
//        public System.String addr2 { get; set; }
//        public System.String addr3 { get; set; }
//        public System.String cityname { get; set; }
//        public System.String postcode1 { get; set; }
//        public System.String postcode2 { get; set; }
//        public System.String logo { get; set; }
//        public System.String VAT { get; set; }
//        public System.String description { get; set; }
//        public System.Decimal? star1 { get; set; }
//        public System.Decimal? star2 { get; set; }
//        public System.Decimal? star3 { get; set; }
//        public System.Decimal? star4 { get; set; }
//        public System.DateTime? updateTime { get; set; }
//        public System.String flag1 { get; set; }
//        public System.String alias { get; set; }
//        public System.String monFrToA { get; set; }
//        public System.String monFrToB { get; set; }
//        public System.String tuesFrToB { get; set; }
//        public System.String tuesFrToA { get; set; }
//        public System.String wedFrToA { get; set; }
//        public System.String wedFrToB { get; set; }
//        public System.String thurFrToA { get; set; }
//        public System.String thurFrToB { get; set; }
//        public System.String friFrToA { get; set; }
//        public System.String friFrToB { get; set; }
//        public System.String satFrToA { get; set; }
//        public System.String satFrToB { get; set; }
//        public System.String sunFrToA { get; set; }
//        public System.String sunFrToB { get; set; }
//        public System.String utype { get; set; }
//        public System.String islocked { get; set; }
//        public System.Decimal? DeliveryMinOrder { get; set; }
//        public System.String DeliveryLastOT { get; set; }
//        public System.String Deliverytime { get; set; }
//        public System.String deliveryWay { get; set; }
//        public System.String acceptorder { get; set; }
//        public System.String acceptpay { get; set; }
//        public System.String haslunch { get; set; }
//        public System.String serviceTypeL { get; set; }
//        public System.Int32? suggestOnlineNum { get; set; }
//        public System.String acceptCustomerOpt { get; set; }
//        public System.Decimal? webcommision { get; set; }
//        public System.String shopstatus { get; set; }
//        public System.Int32? indexno { get; set; }
//        public System.String minCost { get; set; }
//    }

//    public class SpGetMenuInfosReturnModel
//    {
//        public class ResultSetModel1
//        {
//            public System.Int32 mid { get; set; }
//            public System.Int32 shopid { get; set; }
//            public System.String menuCat { get; set; }
//            public System.String menuName { get; set; }
//            public System.String menuName2 { get; set; }
//            public System.String menuDesc { get; set; }
//            public System.String menuDesc2 { get; set; }
//            public System.Decimal? price1 { get; set; }
//            public System.Decimal? price2 { get; set; }
//            public System.Decimal? star { get; set; }
//            public System.String menutype { get; set; }
//            public System.String menulogo { get; set; }
//            public System.String discountway { get; set; }
//            public System.String menucode { get; set; }
//            public System.String servicePeriod { get; set; }
//            public System.String displayweekday { get; set; }
//            public System.String hasSideOrder { get; set; }
//            public System.String hasPL { get; set; }
//            public System.String standardpl { get; set; }
//            public System.DateTime? CreateDT { get; set; }
//            public System.DateTime? UpdateDT { get; set; }
//            public System.String flag { get; set; }
//            public System.Decimal? indexnum { get; set; }
//            public System.Int32? mealamt { get; set; }
//            public System.String menuoptioncat { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

//        public class ResultSetModel2
//        {
//            public System.Int32 mid { get; set; }
//            public System.Int32 shopid { get; set; }
//            public System.String menuCat { get; set; }
//            public System.String menuName { get; set; }
//            public System.String menuName2 { get; set; }
//            public System.String menuDesc { get; set; }
//            public System.String menuDesc2 { get; set; }
//            public System.Decimal? price1 { get; set; }
//            public System.Decimal? price2 { get; set; }
//            public System.Decimal? star { get; set; }
//            public System.String menutype { get; set; }
//            public System.String menulogo { get; set; }
//            public System.String discountway { get; set; }
//            public System.String menucode { get; set; }
//            public System.String servicePeriod { get; set; }
//            public System.String displayweekday { get; set; }
//            public System.String hasSideOrder { get; set; }
//            public System.String hasPL { get; set; }
//            public System.String standardpl { get; set; }
//            public System.DateTime? CreateDT { get; set; }
//            public System.DateTime? UpdateDT { get; set; }
//            public System.String flag { get; set; }
//            public System.Decimal? indexnum { get; set; }
//            public System.Int32? mealamt { get; set; }
//            public System.String menuoptioncat { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

//    }

//    public class SpGetPlInfoReturnModel
//    {
//        public class ResultSetModel1
//        {
//            public System.Int32 basicmenuid { get; set; }
//            public System.Int32 shopid { get; set; }
//            public System.String menutype1 { get; set; }
//            public System.String menutype2 { get; set; }
//            public System.String mname { get; set; }
//            public System.String mname2 { get; set; }
//            public System.Decimal? price1 { get; set; }
//            public System.Decimal? price2 { get; set; }
//            public System.String menudesc { get; set; }
//            public System.String menudesc2 { get; set; }
//            public System.String menucode { get; set; }
//            public System.String flag { get; set; }
//            public System.String menu001 { get; set; }
//            public System.Decimal? indexnum { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

//        public class ResultSetModel2
//        {
//            public System.Int32 basicmenuid { get; set; }
//            public System.Int32 shopid { get; set; }
//            public System.String menutype1 { get; set; }
//            public System.String menutype2 { get; set; }
//            public System.String mname { get; set; }
//            public System.String mname2 { get; set; }
//            public System.Decimal? price1 { get; set; }
//            public System.Decimal? price2 { get; set; }
//            public System.String menudesc { get; set; }
//            public System.String menudesc2 { get; set; }
//            public System.String menucode { get; set; }
//            public System.String flag { get; set; }
//            public System.String menu001 { get; set; }
//            public System.Decimal? indexnum { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

//    }

//    public class SpUserRegExistReturnModel
//    {
//        public System.Int32 uid { get; set; }
//    }

//    public class UpCreditCardGetListReturnModel
//    {
//        public System.Int32 cardid { get; set; }
//        public System.Int32 uid { get; set; }
//        public System.String ACCT { get; set; }
//        public System.String AcctType { get; set; }
//        public System.String Street { get; set; }
//        public System.String city { get; set; }
//        public System.String state { get; set; }
//        public System.String country { get; set; }
//        public System.String zip { get; set; }
//        public System.Int32? cardIssue { get; set; }
//        public System.String cardStart { get; set; }
//        public System.String expDate { get; set; }
//        public System.String firstName { get; set; }
//        public System.String lastName { get; set; }
//        public System.String CVV2 { get; set; }
//        public System.DateTime? createDT { get; set; }
//    }

//    public class UpDeliveryAddrGetListReturnModel
//    {
//        public System.Int32 addrid { get; set; }
//        public System.String username { get; set; }
//        public System.Int32 uid { get; set; }
//        public System.String addrname { get; set; }
//        public System.String addr1 { get; set; }
//        public System.String addr2 { get; set; }
//        public System.String addr3 { get; set; }
//        public System.String cityname { get; set; }
//        public System.String postcode1 { get; set; }
//        public System.String postcode2 { get; set; }
//        public System.String tel { get; set; }
//        public System.String comments { get; set; }
//        public System.String flag { get; set; }
//        public System.String mobile { get; set; }
//    }

//    public class UpDeliveryAddrGetModelByIdReturnModel
//    {
//        public System.Int32 addrid { get; set; }
//        public System.String username { get; set; }
//        public System.Int32 uid { get; set; }
//        public System.String addrname { get; set; }
//        public System.String addr1 { get; set; }
//        public System.String addr2 { get; set; }
//        public System.String addr3 { get; set; }
//        public System.String cityname { get; set; }
//        public System.String postcode1 { get; set; }
//        public System.String postcode2 { get; set; }
//        public System.String tel { get; set; }
//        public System.String comments { get; set; }
//        public System.String flag { get; set; }
//        public System.String mobile { get; set; }
//    }

//    public class UpFavouritesGetModelReturnModel
//    {
//        public System.Int32 fid { get; set; }
//        public System.Int32 uid { get; set; }
//        public System.String ftype { get; set; }
//        public System.Int32? shopid { get; set; }
//        public System.Int32? mid { get; set; }
//        public System.DateTime? createDT { get; set; }
//        public System.String flag { get; set; }
//    }

//    public class UpGetUserEmailReturnModel
//    {
//        public class ResultSetModel1
//        {
//            public System.String uname { get; set; }
//            public System.String email { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

//        public class ResultSetModel2
//        {
//            public System.String uname { get; set; }
//            public System.String email { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

//    }

//    public class UpRecommendGetModelReturnModel
//    {
//        public System.Int32 recID { get; set; }
//        public System.Int32? recUid { get; set; }
//        public System.String recName { get; set; }
//        public System.String shopname { get; set; }
//        public System.String townname { get; set; }
//        public System.String addr { get; set; }
//        public System.String tel { get; set; }
//        public System.String ishandled { get; set; }
//        public System.String status { get; set; }
//        public System.DateTime? recDate { get; set; }
//    }

//    public class UpShopGetModelReturnModel
//    {
//        public System.Int32 shopid { get; set; }
//        public System.String sname { get; set; }
//        public System.String sname2 { get; set; }
//        public System.String mealtype { get; set; }
//        public System.String serviceType { get; set; }
//        public System.String serviceTypeL { get; set; }
//        public System.String tel1 { get; set; }
//        public System.String tel2 { get; set; }
//        public System.String fax { get; set; }
//        public System.String email { get; set; }
//        public System.String gotnotice { get; set; }
//        public System.String contactname { get; set; }
//        public System.String contactTel { get; set; }
//        public System.String addr1 { get; set; }
//        public System.String addr2 { get; set; }
//        public System.String addr3 { get; set; }
//        public System.String cityname { get; set; }
//        public System.String postcode1 { get; set; }
//        public System.String postcode2 { get; set; }
//        public System.String longitude { get; set; }
//        public System.String latitude { get; set; }
//        public System.String logo { get; set; }
//        public System.String VAT { get; set; }
//        public System.String mapstr { get; set; }
//        public System.String description { get; set; }
//        public System.Decimal? star1 { get; set; }
//        public System.Decimal? star2 { get; set; }
//        public System.Decimal? star3 { get; set; }
//        public System.Decimal? star4 { get; set; }
//        public System.DateTime? updateTime { get; set; }
//        public System.String flag1 { get; set; }
//        public System.String alias { get; set; }
//        public System.String acceptpay { get; set; }
//        public System.String orderlang { get; set; }
//        public System.String acceptorder { get; set; }
//        public System.String deliveryWay { get; set; }
//        public System.String Deliverytime { get; set; }
//        public System.String DeliveryLastOT { get; set; }
//        public System.Decimal? DeliveryMinOrder { get; set; }
//        public System.String bankname { get; set; }
//        public System.String bankusername { get; set; }
//        public System.String banksortcode { get; set; }
//        public System.String bankno { get; set; }
//        public System.Decimal? webcommision { get; set; }
//        public System.DateTime? expireddt { get; set; }
//        public System.String bgpicture { get; set; }
//        public System.String cardchargeopt { get; set; }
//        public System.Decimal? fixchargeamt { get; set; }
//        public System.Decimal? ratiochargeamt { get; set; }
//        public System.Int32? suggestOnlineNum { get; set; }
//        public System.String acceptCustomerOpt { get; set; }
//    }

//    public class UpShoppingHolidayGetListReturnModel
//    {
//        public System.Int32 holidayid { get; set; }
//        public System.Int32? shopid { get; set; }
//        public System.DateTime? fromDT { get; set; }
//        public System.DateTime? toDT { get; set; }
//    }

//    public class UpSysMsgGetModelReturnModel
//    {
//        public System.Int32 msgid { get; set; }
//        public System.String msgtitle { get; set; }
//        public System.String msgcontent { get; set; }
//        public System.DateTime msgdt { get; set; }
//        public System.Int32 msgto { get; set; }
//        public System.String isread { get; set; }
//        public System.DateTime? readdt { get; set; }
//    }

//    public class UpUserregGetInfoByUidReturnModel
//    {
//        public System.String utype { get; set; }
//        public System.String gender { get; set; }
//        public System.String realname { get; set; }
//        public System.String email { get; set; }
//        public System.String pwd { get; set; }
//        public System.String pwdquestion { get; set; }
//        public System.String pwdanswer { get; set; }
//        public System.String birthday { get; set; }
//        public System.DateTime? lastlogindate { get; set; }
//        public System.String lastloginIP { get; set; }
//        public System.String islocked { get; set; }
//        public System.Int32? score { get; set; }
//        public System.Int32? credits { get; set; }
//        public System.String isblocked { get; set; }
//        public System.String isnoticed { get; set; }
//        public System.DateTime? createdt { get; set; }
//        public System.Int32? loginErrTime { get; set; }
//        public System.Int32 uid { get; set; }
//        public System.String houseno { get; set; }
//        public System.String addr1 { get; set; }
//        public System.String postcode1 { get; set; }
//        public System.String postcode2 { get; set; }
//    }

//    public class UpUserregGetpwdByMailReturnModel
//    {
//        public System.String pwd { get; set; }
//    }

//    public class UpUserregGetPwdQuestionReturnModel
//    {
//        public class ResultSetModel1
//        {
//            public System.String pwdquestion { get; set; }
//            public System.String pwdanswer { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel1> ResultSet1;

//        public class ResultSetModel2
//        {
//            public System.String pwdquestion { get; set; }
//            public System.String pwdanswer { get; set; }
//        }
//        public System.Collections.Generic.List<ResultSetModel2> ResultSet2;

//    }

//    public class UpUserscoreGetListReturnModel
//    {
//        public System.Int32 sid { get; set; }
//        public System.Int32? uid { get; set; }
//        public System.DateTime? scoretime { get; set; }
//        public System.String operateuser { get; set; }
//        public System.Int32? score { get; set; }
//        public System.String operation { get; set; }
//        public System.String scoretype { get; set; }
//        public System.String description { get; set; }
//    }

//    public class UpUserscoreGetModelReturnModel
//    {
//        public System.Int32 sid { get; set; }
//        public System.Int32? uid { get; set; }
//        public System.DateTime? scoretime { get; set; }
//        public System.String operateuser { get; set; }
//        public System.Int32? score { get; set; }
//        public System.String operation { get; set; }
//        public System.String scoretype { get; set; }
//        public System.String description { get; set; }
//    }
//}
