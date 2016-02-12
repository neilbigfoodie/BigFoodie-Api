
using System.Data.Entity;
using System.Linq;
using BigFoodie.DataAccess.EntityFramework;
using BigFoodie.DataAccess.EntityFramework.Mapping;
using BigFoodie.Model;
using BigFoodie.Model.StoredProceedureReturnClasses;
using Order = BigFoodie.Model.Order;

namespace Bitflux.Master.Dal.EntityFramework
{
    public class BFDbContext : DbContext, IBFDbContext
    {
        public DbSet<AdminAcc> AdminAccs { get; set; } // adminAcc
        public DbSet<Adv> Advs { get; set; } // adv
        public DbSet<Advsearch> Advsearches { get; set; } // advsearch
        public DbSet<AppUserInfo> AppUserInfoes { get; set; } // AppUserInfo
        public DbSet<AppUserSetting> AppUserSettings { get; set; } // AppUserSetting
        public DbSet<AppUserToDevice> AppUserToDevices { get; set; } // AppUserToDevice
        public DbSet<Blocklist> Blocklists { get; set; } // blocklist
        public DbSet<Cashreturn> Cashreturns { get; set; } // cashreturn
        public DbSet<Commission> Commissions { get; set; } // commission
        public DbSet<CreditCard> CreditCards { get; set; } // creditCard
        public DbSet<CustomerReview> CustomerReviews { get; set; } // customerReview
        public DbSet<DeliveryAddr> DeliveryAddrs { get; set; } // deliveryAddr
        public DbSet<Deviceinfo> Deviceinfoes { get; set; } // deviceinfo
        public DbSet<Favourite> Favourites { get; set; } // favourites
        public DbSet<Invitefriend> Invitefriends { get; set; } // invitefriend
        public DbSet<MemberCash> MemberCashes { get; set; } // memberCash
        public DbSet<Menu> Menus { get; set; } // menu
        public DbSet<Menubasic> Menubasics { get; set; } // menubasic
        public DbSet<MenuBasicTemplate> MenuBasicTemplates { get; set; } // MenuBasicTemplate
        public DbSet<MenuCat> MenuCats { get; set; } // menuCat
        public DbSet<MenuCatBasicMenu> MenuCatBasicMenus { get; set; } // menuCatBasicMenu
        public DbSet<Menucattemplate> Menucattemplates { get; set; } // menucattemplate
        public DbSet<Menuoptionalcat> Menuoptionalcats { get; set; } // menuoptionalcat
        public DbSet<MenuPrice> MenuPrices { get; set; } // menuPrice
        public DbSet<Menusideorder> Menusideorders { get; set; } // menusideorder
        public DbSet<MultilangMenu> MultilangMenus { get; set; } // multilangMenu
        public DbSet<Newshopregi> Newshopregis { get; set; } // newshopregis
        public DbSet<OnlineUser> OnlineUsers { get; set; } // onlineUser
        public DbSet<Order> Orders { get; set; } // orders
        public DbSet<Ordercomment> Ordercomments { get; set; } // ordercomments
        public DbSet<Ordercz> Orderczs { get; set; } // ordercz
        public DbSet<Orderdelivery> Orderdeliveries { get; set; } // orderdelivery
        public DbSet<Orderitem> Orderitems { get; set; } // orderitem
        public DbSet<Ordernotice> Ordernotices { get; set; } // ordernotice
        public DbSet<Orderoperation> Orderoperations { get; set; } // orderoperation
        public DbSet<Orderpayment> Orderpayments { get; set; } // orderpayment
        public DbSet<PushNoticeQueue> PushNoticeQueues { get; set; } // pushNoticeQueue
        public DbSet<Recommend> Recommends { get; set; } // recommend
        public DbSet<RecPaidAmountInfo> RecPaidAmountInfoes { get; set; } // RecPaidAmountInfo
        public DbSet<ServiceTicket> ServiceTickets { get; set; } // serviceTicket
        public DbSet<Shop> Shops { get; set; } // shop
        public DbSet<ShopDelieveryArea> ShopDelieveryAreas { get; set; } // shopDelieveryArea
        public DbSet<ShopdeliveryCost> ShopdeliveryCosts { get; set; } // shopdeliveryCost
        public DbSet<Shopdiscount> Shopdiscounts { get; set; } // shopdiscount
        public DbSet<ShopExtInfoForApp> ShopExtInfoForApps { get; set; } // ShopExtInfoForApp
        public DbSet<ShopJz> ShopJzs { get; set; } // shopJZ
        public DbSet<ShopJzDetail> ShopJzDetails { get; set; } // shopJZDetail
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } // ShoppingCart
        public DbSet<ShoppingHoliday> ShoppingHolidays { get; set; } // shoppingHoliday
        public DbSet<ShopTicket> ShopTickets { get; set; } // shopTickets
        public DbSet<Shoptransactiondetail> Shoptransactiondetails { get; set; } // shoptransactiondetail
        public DbSet<Shopviewtelrecord> Shopviewtelrecords { get; set; } // shopviewtelrecord
        public DbSet<Shopworktime> Shopworktimes { get; set; } // shopworktime
        public DbSet<Submenu> Submenus { get; set; } // submenu
        public DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public DbSet<SysLog> SysLogs { get; set; } // sysLog
        public DbSet<SysMsg> SysMsgs { get; set; } // sysMsg
        public DbSet<UserCreditInfo> UserCreditInfoes { get; set; } // UserCreditInfo
        public DbSet<UserReg> UserRegs { get; set; } // UserReg
        public DbSet<Userscore> Userscores { get; set; } // userscore
        public DbSet<Voucherinfo> Voucherinfoes { get; set; } // voucherinfo
        public DbSet<VwAppUserProfile> VwAppUserProfiles { get; set; } // vwAppUserProfile
        public DbSet<VwCustomerreview> VwCustomerreviews { get; set; } // vw_customerreview
        public DbSet<VwGetAppDeviceInfo> VwGetAppDeviceInfoes { get; set; } // vwGetAppDeviceInfo
        public DbSet<VwGetAppRestInfo> VwGetAppRestInfoes { get; set; } // vwGetAppRestInfo
        public DbSet<VwGetOrderInfo> VwGetOrderInfoes { get; set; } // vwGetOrderInfo
        public DbSet<VwGetOrderInfoForAdmin> VwGetOrderInfoForAdmins { get; set; } // vwGetOrderInfoForAdmin
        public DbSet<VwGetOrderListForApp> VwGetOrderListForApps { get; set; } // vwGetOrderListForApp
        public DbSet<VwGetShopInfo> VwGetShopInfoes { get; set; } // vwGetShopInfo
        public DbSet<VwGetShopInfo2> VwGetShopInfo2 { get; set; } // vwGetShopInfo2
        public DbSet<VwGetShopJzDetail> VwGetShopJzDetails { get; set; } // vwGetShopJZDetail
        public DbSet<VwGetUserBalanceSummary> VwGetUserBalanceSummaries { get; set; } // vwGetUserBalanceSummary
        public DbSet<VwGetUserFavShopInfo> VwGetUserFavShopInfoes { get; set; } // vwGetUserFavShopInfo
        public DbSet<VwGetUserInfo> VwGetUserInfoes { get; set; } // vwGetUserInfo
        public DbSet<VwOrdersValid> VwOrdersValids { get; set; } // vwOrdersValid
        public DbSet<VwShopOrder> VwShopOrders { get; set; } // vwShopOrders
        public DbSet<VwShopsValid> VwShopsValids { get; set; } // vwShopsValid
        public DbSet<VwSysMsg> VwSysMsgs { get; set; } // vwSysMsg
        public DbSet<VwUser2Device> VwUser2Device { get; set; } // vwUser2Device
        public DbSet<VwUserBalanceSummary> VwUserBalanceSummaries { get; set; } // vwUserBalanceSummary
        public DbSet<VwValidOrder> VwValidOrders { get; set; } // vwValidOrders
        public DbSet<VwValidShop> VwValidShops { get; set; } // vwValidShops
        public DbSet<Vwviewtel> Vwviewtels { get; set; } // vwviewtel

        public BFDbContext() : base("name=BFDbContext")
        {
            var connectionString = base.Database.Connection.ConnectionString;
           // Database.SetInitializer(new MigrateDatabaseToLatestVersion<Dal.BFContext, DbConfiguration());
        }

        public BFDbContext(string ConnectionString) : base(ConnectionString)
        {
            var cnn = base.Database.Connection.ConnectionString;
        }

        public BFDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AdminAccConfiguration());
            modelBuilder.Configurations.Add(new AdvConfiguration());
            modelBuilder.Configurations.Add(new AdvsearchConfiguration());
            modelBuilder.Configurations.Add(new AppUserInfoConfiguration());
            modelBuilder.Configurations.Add(new AppUserSettingConfiguration());
            modelBuilder.Configurations.Add(new AppUserToDeviceConfiguration());
            modelBuilder.Configurations.Add(new BlocklistConfiguration());
            modelBuilder.Configurations.Add(new CashreturnConfiguration());
            modelBuilder.Configurations.Add(new CommissionConfiguration());
            modelBuilder.Configurations.Add(new CreditCardConfiguration());
            modelBuilder.Configurations.Add(new CustomerReviewConfiguration());
            modelBuilder.Configurations.Add(new DeliveryAddrConfiguration());
            modelBuilder.Configurations.Add(new DeviceinfoConfiguration());
            modelBuilder.Configurations.Add(new FavouriteConfiguration());
            modelBuilder.Configurations.Add(new InvitefriendConfiguration());
            modelBuilder.Configurations.Add(new MemberCashConfiguration());
            modelBuilder.Configurations.Add(new MenuConfiguration());
            modelBuilder.Configurations.Add(new MenubasicConfiguration());
            modelBuilder.Configurations.Add(new MenuBasicTemplateConfiguration());
            modelBuilder.Configurations.Add(new MenuCatConfiguration());
            modelBuilder.Configurations.Add(new MenuCatBasicMenuConfiguration());
            modelBuilder.Configurations.Add(new MenucattemplateConfiguration());
            modelBuilder.Configurations.Add(new MenuoptionalcatConfiguration());
            modelBuilder.Configurations.Add(new MenuPriceConfiguration());
            modelBuilder.Configurations.Add(new MenusideorderConfiguration());
            modelBuilder.Configurations.Add(new MultilangMenuConfiguration());
            modelBuilder.Configurations.Add(new NewshopregiConfiguration());
            modelBuilder.Configurations.Add(new OnlineUserConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new OrdercommentConfiguration());
            modelBuilder.Configurations.Add(new OrderczConfiguration());
            modelBuilder.Configurations.Add(new OrderdeliveryConfiguration());
            modelBuilder.Configurations.Add(new OrderitemConfiguration());
            modelBuilder.Configurations.Add(new OrdernoticeConfiguration());
            modelBuilder.Configurations.Add(new OrderoperationConfiguration());
            modelBuilder.Configurations.Add(new OrderpaymentConfiguration());
            modelBuilder.Configurations.Add(new PushNoticeQueueConfiguration());
            modelBuilder.Configurations.Add(new RecommendConfiguration());
            modelBuilder.Configurations.Add(new RecPaidAmountInfoConfiguration());
            modelBuilder.Configurations.Add(new ServiceTicketConfiguration());
            modelBuilder.Configurations.Add(new ShopConfiguration());
            modelBuilder.Configurations.Add(new ShopDelieveryAreaConfiguration());
            modelBuilder.Configurations.Add(new ShopdeliveryCostConfiguration());
            modelBuilder.Configurations.Add(new ShopdiscountConfiguration());
            modelBuilder.Configurations.Add(new ShopExtInfoForAppConfiguration());
            modelBuilder.Configurations.Add(new ShopJzConfiguration());
            modelBuilder.Configurations.Add(new ShopJzDetailConfiguration());
            modelBuilder.Configurations.Add(new ShoppingCartConfiguration());
            modelBuilder.Configurations.Add(new ShoppingHolidayConfiguration());
            modelBuilder.Configurations.Add(new ShopTicketConfiguration());
            modelBuilder.Configurations.Add(new ShoptransactiondetailConfiguration());
            modelBuilder.Configurations.Add(new ShopviewtelrecordConfiguration());
            modelBuilder.Configurations.Add(new ShopworktimeConfiguration());
            modelBuilder.Configurations.Add(new SubmenuConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
            modelBuilder.Configurations.Add(new SysLogConfiguration());
            modelBuilder.Configurations.Add(new SysMsgConfiguration());
            modelBuilder.Configurations.Add(new UserCreditInfoConfiguration());
            modelBuilder.Configurations.Add(new UserRegConfiguration());
            modelBuilder.Configurations.Add(new UserscoreConfiguration());
            modelBuilder.Configurations.Add(new VoucherinfoConfiguration());
            modelBuilder.Configurations.Add(new VwAppUserProfileConfiguration());
            modelBuilder.Configurations.Add(new VwCustomerreviewConfiguration());
            modelBuilder.Configurations.Add(new VwGetAppDeviceInfoConfiguration());
            modelBuilder.Configurations.Add(new VwGetAppRestInfoConfiguration());
            modelBuilder.Configurations.Add(new VwGetOrderInfoConfiguration());
            modelBuilder.Configurations.Add(new VwGetOrderInfoForAdminConfiguration());
            modelBuilder.Configurations.Add(new VwGetOrderListForAppConfiguration());
            modelBuilder.Configurations.Add(new VwGetShopInfoConfiguration());
            modelBuilder.Configurations.Add(new VwGetShopInfo2Configuration());
            modelBuilder.Configurations.Add(new VwGetShopJzDetailConfiguration());
            modelBuilder.Configurations.Add(new VwGetUserBalanceSummaryConfiguration());
            modelBuilder.Configurations.Add(new VwGetUserFavShopInfoConfiguration());
            modelBuilder.Configurations.Add(new VwGetUserInfoConfiguration());
            modelBuilder.Configurations.Add(new VwOrdersValidConfiguration());
            modelBuilder.Configurations.Add(new VwShopOrderConfiguration());
            modelBuilder.Configurations.Add(new VwShopsValidConfiguration());
            modelBuilder.Configurations.Add(new VwSysMsgConfiguration());
            modelBuilder.Configurations.Add(new VwUser2DeviceConfiguration());
            modelBuilder.Configurations.Add(new VwUserBalanceSummaryConfiguration());
            modelBuilder.Configurations.Add(new VwValidOrderConfiguration());
            modelBuilder.Configurations.Add(new VwValidShopConfiguration());
            modelBuilder.Configurations.Add(new VwviewtelConfiguration());
            
            
            //modelBuilder.Conventions.Add(new Order_Mapping());
            //modelBuilder.Conventions.Add(new Item_Mapping());

            //many to many 
            //modelBuilder.Entity<Order>()
            //    .HasMany(e => e.Items)
            //    .WithMany(e => e.Orders)
            //    .Map(m => m.ToTable("tbl_order_item", "master").MapLeftKey("order_id").MapRightKey("item_id"));

            //one to many


            //many to one or zero. 
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AdminAccConfiguration(schema));
            modelBuilder.Configurations.Add(new AdvConfiguration(schema));
            modelBuilder.Configurations.Add(new AdvsearchConfiguration(schema));
            modelBuilder.Configurations.Add(new AppUserInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new AppUserSettingConfiguration(schema));
            modelBuilder.Configurations.Add(new AppUserToDeviceConfiguration(schema));
            modelBuilder.Configurations.Add(new BlocklistConfiguration(schema));
            modelBuilder.Configurations.Add(new CashreturnConfiguration(schema));
            modelBuilder.Configurations.Add(new CommissionConfiguration(schema));
            modelBuilder.Configurations.Add(new CreditCardConfiguration(schema));
            modelBuilder.Configurations.Add(new CustomerReviewConfiguration(schema));
            modelBuilder.Configurations.Add(new DeliveryAddrConfiguration(schema));
            modelBuilder.Configurations.Add(new DeviceinfoConfiguration(schema));
            modelBuilder.Configurations.Add(new FavouriteConfiguration(schema));
            modelBuilder.Configurations.Add(new InvitefriendConfiguration(schema));
            modelBuilder.Configurations.Add(new MemberCashConfiguration(schema));
            modelBuilder.Configurations.Add(new MenuConfiguration(schema));
            modelBuilder.Configurations.Add(new MenubasicConfiguration(schema));
            modelBuilder.Configurations.Add(new MenuBasicTemplateConfiguration(schema));
            modelBuilder.Configurations.Add(new MenuCatConfiguration(schema));
            modelBuilder.Configurations.Add(new MenuCatBasicMenuConfiguration(schema));
            modelBuilder.Configurations.Add(new MenucattemplateConfiguration(schema));
            modelBuilder.Configurations.Add(new MenuoptionalcatConfiguration(schema));
            modelBuilder.Configurations.Add(new MenuPriceConfiguration(schema));
            modelBuilder.Configurations.Add(new MenusideorderConfiguration(schema));
            modelBuilder.Configurations.Add(new MultilangMenuConfiguration(schema));
            modelBuilder.Configurations.Add(new NewshopregiConfiguration(schema));
            modelBuilder.Configurations.Add(new OnlineUserConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderConfiguration(schema));
            modelBuilder.Configurations.Add(new OrdercommentConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderczConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderdeliveryConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderitemConfiguration(schema));
            modelBuilder.Configurations.Add(new OrdernoticeConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderoperationConfiguration(schema));
            modelBuilder.Configurations.Add(new OrderpaymentConfiguration(schema));
            modelBuilder.Configurations.Add(new PushNoticeQueueConfiguration(schema));
            modelBuilder.Configurations.Add(new RecommendConfiguration(schema));
            modelBuilder.Configurations.Add(new RecPaidAmountInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new ServiceTicketConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopDelieveryAreaConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopdeliveryCostConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopdiscountConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopExtInfoForAppConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopJzConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopJzDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ShoppingCartConfiguration(schema));
            modelBuilder.Configurations.Add(new ShoppingHolidayConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopTicketConfiguration(schema));
            modelBuilder.Configurations.Add(new ShoptransactiondetailConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopviewtelrecordConfiguration(schema));
            modelBuilder.Configurations.Add(new ShopworktimeConfiguration(schema));
            modelBuilder.Configurations.Add(new SubmenuConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            modelBuilder.Configurations.Add(new SysLogConfiguration(schema));
            modelBuilder.Configurations.Add(new SysMsgConfiguration(schema));
            modelBuilder.Configurations.Add(new UserCreditInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new UserRegConfiguration(schema));
            modelBuilder.Configurations.Add(new UserscoreConfiguration(schema));
            modelBuilder.Configurations.Add(new VoucherinfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwAppUserProfileConfiguration(schema));
            modelBuilder.Configurations.Add(new VwCustomerreviewConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetAppDeviceInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetAppRestInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetOrderInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetOrderInfoForAdminConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetOrderListForAppConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetShopInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetShopInfo2Configuration(schema));
            modelBuilder.Configurations.Add(new VwGetShopJzDetailConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetUserBalanceSummaryConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetUserFavShopInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwGetUserInfoConfiguration(schema));
            modelBuilder.Configurations.Add(new VwOrdersValidConfiguration(schema));
            modelBuilder.Configurations.Add(new VwShopOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new VwShopsValidConfiguration(schema));
            modelBuilder.Configurations.Add(new VwSysMsgConfiguration(schema));
            modelBuilder.Configurations.Add(new VwUser2DeviceConfiguration(schema));
            modelBuilder.Configurations.Add(new VwUserBalanceSummaryConfiguration(schema));
            modelBuilder.Configurations.Add(new VwValidOrderConfiguration(schema));
            modelBuilder.Configurations.Add(new VwValidShopConfiguration(schema));
            modelBuilder.Configurations.Add(new VwviewtelConfiguration(schema));
            return modelBuilder;
        }


        #region stored procedures
        // Stored Procedures
        public int AddToBlockList(string orderid, string reason, string operateid)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var reasonParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@reason", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = reason, Size = 500 };
            if (reasonParam.Value == null)
                reasonParam.Value = System.DBNull.Value;

            var operateidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operateid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = operateid, Size = 50 };
            if (operateidParam.Value == null)
                operateidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[ADDToBlockList] @orderid, @reason, @operateid", orderidParam, reasonParam, operateidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int CancelOrders(string orderid, string isCancelled, System.DateTime? orderCancelledDt, string cancelComments)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var isCancelledParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isCancelled", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isCancelled, Size = 1 };
            if (isCancelledParam.Value == null)
                isCancelledParam.Value = System.DBNull.Value;

            var orderCancelledDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderCancelledDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = orderCancelledDt.GetValueOrDefault() };
            if (!orderCancelledDt.HasValue)
                orderCancelledDtParam.Value = System.DBNull.Value;

            var cancelCommentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cancelComments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cancelComments, Size = 300 };
            if (cancelCommentsParam.Value == null)
                cancelCommentsParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[CancelOrders] @orderid, @isCancelled, @orderCancelledDT, @cancelComments", orderidParam, isCancelledParam, orderCancelledDtParam, cancelCommentsParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int DeleAppDevice(int? deviceid)
        {
            var deviceidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@deviceid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = deviceid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!deviceid.HasValue)
                deviceidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[deleAppDevice] @deviceid", deviceidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int Deleapprestanduser(int? shopid)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[deleapprestanduser] @shopid", shopidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int Deletejz(int? jzid)
        {
            var jzidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@jzid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = jzid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!jzid.HasValue)
                jzidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[deletejz] @jzid", jzidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int GetAdvByCondition(string pc, string tn)
        {
            var pcParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pc, Size = 10 };
            if (pcParam.Value == null)
                pcParam.Value = System.DBNull.Value;

            var tnParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tn", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tn, Size = 100 };
            if (tnParam.Value == null)
                tnParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[GetAdvByCondition] @pc, @tn", pcParam, tnParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int GetOrdersByCondition(string sqlwhere)
        {
            var sqlwhereParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sqlwhere", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sqlwhere, Size = 2000 };
            if (sqlwhereParam.Value == null)
                sqlwhereParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[GetOrdersByCondition] @sqlwhere", sqlwhereParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int GetOrdersByUid(int? uid, int? shopid, string dtsql)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var dtsqlParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@dtsql", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = dtsql, Size = 500 };
            if (dtsqlParam.Value == null)
                dtsqlParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[GetOrdersByUID] @uid, @shopid, @dtsql", uidParam, shopidParam, dtsqlParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int GetOrdersByUser(string email, int? shopid, string dtsql)
        {
            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var dtsqlParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@dtsql", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = dtsql, Size = 500 };
            if (dtsqlParam.Value == null)
                dtsqlParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[GetOrdersByUser] @email, @shopid, @dtsql", emailParam, shopidParam, dtsqlParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<GetShopByPostCodeReturnModel> GetShopByPostCode(string postcode)
        {
            int procResult;
            return GetShopByPostCode(postcode, out procResult);
        }

        public System.Collections.Generic.List<GetShopByPostCodeReturnModel> GetShopByPostCode(string postcode, out int procResult)
        {
            var postcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode, Size = 15 };
            if (postcodeParam.Value == null)
                postcodeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<GetShopByPostCodeReturnModel>("EXEC @procResult = [dbo].[GetShopByPostCode] @postcode", postcodeParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int GetShopByTownName(string sn, string tn)
        {
            var snParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sn", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sn, Size = 100 };
            if (snParam.Value == null)
                snParam.Value = System.DBNull.Value;

            var tnParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tn", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tn, Size = 100 };
            if (tnParam.Value == null)
                tnParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[GetShopByTownName] @sn, @tn", snParam, tnParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int ImportCatFromTempl(int? shopid, string cats)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var catsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cats", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cats, Size = 1000 };
            if (catsParam.Value == null)
                catsParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[ImportCatFromTempl] @shopid, @cats", shopidParam, catsParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int ImportPlFromTempl(int? shopid, string pls, string plcat)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var plsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pls", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pls, Size = 1000 };
            if (plsParam.Value == null)
                plsParam.Value = System.DBNull.Value;

            var plcatParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@plcat", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = plcat, Size = 1 };
            if (plcatParam.Value == null)
                plcatParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[ImportPLFromTempl] @shopid, @pls, @plcat", shopidParam, plsParam, plcatParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int IsInBlockList(string orderid, out string ret)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var retParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ret", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Output, Size = 1 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[IsInBlockList] @orderid, @ret OUTPUT", orderidParam, retParam, procResultParam);
            if (IsSqlParameterNull(retParam))
                ret = default(string);
            else
                ret = (string)retParam.Value;

            return (int)procResultParam.Value;
        }

        public int JzDetail(System.DateTime? frdt, System.DateTime? todt, int? shopid, decimal? stdcommrate, int? jzid, out string ret)
        {
            var frdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@frdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = frdt.GetValueOrDefault() };
            if (!frdt.HasValue)
                frdtParam.Value = System.DBNull.Value;

            var todtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@todt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = todt.GetValueOrDefault() };
            if (!todt.HasValue)
                todtParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var stdcommrateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@stdcommrate", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = stdcommrate.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!stdcommrate.HasValue)
                stdcommrateParam.Value = System.DBNull.Value;

            var jzidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@jzid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = jzid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!jzid.HasValue)
                jzidParam.Value = System.DBNull.Value;

            var retParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ret", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 50 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[JZDetail] @frdt, @todt, @shopid, @stdcommrate, @jzid, @ret OUTPUT", frdtParam, todtParam, shopidParam, stdcommrateParam, jzidParam, retParam, procResultParam);
            if (IsSqlParameterNull(retParam))
                ret = default(string);
            else
                ret = (string)retParam.Value;

            return (int)procResultParam.Value;
        }

        public int JzDetailtmp(System.DateTime? frdt, System.DateTime? todt, int? shopid, int? jzid, out string ret)
        {
            var frdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@frdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = frdt.GetValueOrDefault() };
            if (!frdt.HasValue)
                frdtParam.Value = System.DBNull.Value;

            var todtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@todt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = todt.GetValueOrDefault() };
            if (!todt.HasValue)
                todtParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var jzidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@jzid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = jzid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!jzid.HasValue)
                jzidParam.Value = System.DBNull.Value;

            var retParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ret", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 50 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[JZDetailtmp] @frdt, @todt, @shopid, @jzid, @ret OUTPUT", frdtParam, todtParam, shopidParam, jzidParam, retParam, procResultParam);
            if (IsSqlParameterNull(retParam))
                ret = default(string);
            else
                ret = (string)retParam.Value;

            return (int)procResultParam.Value;
        }

        public int PfSysPageControl(string tableName, string tableFields, string sqlWhere, string orderFields, int? pageSize, int? pageIndex, out int? totalPage)
        {
            var tableNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tableName", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = tableName, Size = 500 };
            if (tableNameParam.Value == null)
                tableNameParam.Value = System.DBNull.Value;

            var tableFieldsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tableFields", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = tableFields, Size = 5000 };
            if (tableFieldsParam.Value == null)
                tableFieldsParam.Value = System.DBNull.Value;

            var sqlWhereParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sqlWhere", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = sqlWhere, Size = 5000 };
            if (sqlWhereParam.Value == null)
                sqlWhereParam.Value = System.DBNull.Value;

            var orderFieldsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderFields", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = orderFields, Size = 5000 };
            if (orderFieldsParam.Value == null)
                orderFieldsParam.Value = System.DBNull.Value;

            var pageSizeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pageSize", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = pageSize.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!pageSize.HasValue)
                pageSizeParam.Value = System.DBNull.Value;

            var pageIndexParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pageIndex", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = pageIndex.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!pageIndex.HasValue)
                pageIndexParam.Value = System.DBNull.Value;

            var totalPageParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@totalPage", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[PF_Sys_PageControl] @tableName, @tableFields, @sqlWhere, @orderFields, @pageSize, @pageIndex, @totalPage OUTPUT", tableNameParam, tableFieldsParam, sqlWhereParam, orderFieldsParam, pageSizeParam, pageIndexParam, totalPageParam, procResultParam);
            if (IsSqlParameterNull(totalPageParam))
                totalPage = null;
            else
                totalPage = (int)totalPageParam.Value;

            return (int)procResultParam.Value;
        }

        public int PfSysPageControl2000(string tablename, string tableFields, int? pageIndex, int? pageSize, string sqlWhere, string orderFields, bool? intOrder, out int? totalPage)
        {
            var tablenameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tablename", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = tablename, Size = 200 };
            if (tablenameParam.Value == null)
                tablenameParam.Value = System.DBNull.Value;

            var tableFieldsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tableFields", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = tableFields, Size = 200 };
            if (tableFieldsParam.Value == null)
                tableFieldsParam.Value = System.DBNull.Value;

            var pageIndexParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@PageIndex", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = pageIndex.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!pageIndex.HasValue)
                pageIndexParam.Value = System.DBNull.Value;

            var pageSizeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pageSize", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = pageSize.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!pageSize.HasValue)
                pageSizeParam.Value = System.DBNull.Value;

            var sqlWhereParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sqlWhere", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = sqlWhere, Size = 100 };
            if (sqlWhereParam.Value == null)
                sqlWhereParam.Value = System.DBNull.Value;

            var orderFieldsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderFields", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = orderFields, Size = 100 };
            if (orderFieldsParam.Value == null)
                orderFieldsParam.Value = System.DBNull.Value;

            var intOrderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@intOrder", SqlDbType = System.Data.SqlDbType.Bit, Direction = System.Data.ParameterDirection.Input, Value = intOrder.GetValueOrDefault() };
            if (!intOrder.HasValue)
                intOrderParam.Value = System.DBNull.Value;

            var totalPageParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@totalPage", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[PF_Sys_PageControl2000] @tablename, @tableFields, @PageIndex, @pageSize, @sqlWhere, @orderFields, @intOrder, @totalPage OUTPUT", tablenameParam, tableFieldsParam, pageIndexParam, pageSizeParam, sqlWhereParam, orderFieldsParam, intOrderParam, totalPageParam, procResultParam);
            if (IsSqlParameterNull(totalPageParam))
                totalPage = null;
            else
                totalPage = (int)totalPageParam.Value;

            return (int)procResultParam.Value;
        }

        public int SpAdminAccAdd(string loginname, string loginpwd, System.DateTime? createtime, string rightcode, string isvalid, string isadmin)
        {
            var loginnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = loginname, Size = 50 };
            if (loginnameParam.Value == null)
                loginnameParam.Value = System.DBNull.Value;

            var loginpwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginpwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = loginpwd, Size = 100 };
            if (loginpwdParam.Value == null)
                loginpwdParam.Value = System.DBNull.Value;

            var createtimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createtime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createtime.GetValueOrDefault() };
            if (!createtime.HasValue)
                createtimeParam.Value = System.DBNull.Value;

            var rightcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@rightcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = rightcode, Size = 1000 };
            if (rightcodeParam.Value == null)
                rightcodeParam.Value = System.DBNull.Value;

            var isvalidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isvalid", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isvalid, Size = 1 };
            if (isvalidParam.Value == null)
                isvalidParam.Value = System.DBNull.Value;

            var isadminParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isadmin", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isadmin, Size = 1 };
            if (isadminParam.Value == null)
                isadminParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_adminAcc_ADD] @loginname, @loginpwd, @createtime, @rightcode, @isvalid, @isadmin", loginnameParam, loginpwdParam, createtimeParam, rightcodeParam, isvalidParam, isadminParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpAdminAccUpdate(string loginname, string loginpwd, string rightcode, string isvalid, string isadmin)
        {
            var loginnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = loginname, Size = 50 };
            if (loginnameParam.Value == null)
                loginnameParam.Value = System.DBNull.Value;

            var loginpwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginpwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = loginpwd, Size = 100 };
            if (loginpwdParam.Value == null)
                loginpwdParam.Value = System.DBNull.Value;

            var rightcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@rightcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = rightcode, Size = 1000 };
            if (rightcodeParam.Value == null)
                rightcodeParam.Value = System.DBNull.Value;

            var isvalidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isvalid", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isvalid, Size = 1 };
            if (isvalidParam.Value == null)
                isvalidParam.Value = System.DBNull.Value;

            var isadminParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isadmin", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isadmin, Size = 1 };
            if (isadminParam.Value == null)
                isadminParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_adminAcc_Update] @loginname, @loginpwd, @rightcode, @isvalid, @isadmin", loginnameParam, loginpwdParam, rightcodeParam, isvalidParam, isadminParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpAdvpicAdd(int? advid, string pc, string townname, int? shopid, string shoploginname, System.DateTime? starttime, System.DateTime? endtime, string urllink, string advPic, int? indexno, int? clicknum)
        {
            var advidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@advid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = advid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!advid.HasValue)
                advidParam.Value = System.DBNull.Value;

            var pcParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pc, Size = 10 };
            if (pcParam.Value == null)
                pcParam.Value = System.DBNull.Value;

            var townnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@townname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = townname, Size = 50 };
            if (townnameParam.Value == null)
                townnameParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var shoploginnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shoploginname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = shoploginname, Size = 20 };
            if (shoploginnameParam.Value == null)
                shoploginnameParam.Value = System.DBNull.Value;

            var starttimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@starttime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = starttime.GetValueOrDefault() };
            if (!starttime.HasValue)
                starttimeParam.Value = System.DBNull.Value;

            var endtimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@endtime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = endtime.GetValueOrDefault() };
            if (!endtime.HasValue)
                endtimeParam.Value = System.DBNull.Value;

            var urllinkParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@urllink", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = urllink, Size = 300 };
            if (urllinkParam.Value == null)
                urllinkParam.Value = System.DBNull.Value;

            var advPicParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@advPic", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = advPic, Size = 100 };
            if (advPicParam.Value == null)
                advPicParam.Value = System.DBNull.Value;

            var indexnoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexno", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = indexno.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!indexno.HasValue)
                indexnoParam.Value = System.DBNull.Value;

            var clicknumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@clicknum", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = clicknum.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!clicknum.HasValue)
                clicknumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_advpic_ADD] @advid, @pc, @townname, @shopid, @shoploginname, @starttime, @endtime, @urllink, @advPic, @indexno, @clicknum", advidParam, pcParam, townnameParam, shopidParam, shoploginnameParam, starttimeParam, endtimeParam, urllinkParam, advPicParam, indexnoParam, clicknumParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpAdvsearchAdd(string postcode, int? indexno, string shopid, System.DateTime? startdt, System.DateTime? enddt, System.DateTime? createdt, string createuser)
        {
            var postcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode, Size = 10 };
            if (postcodeParam.Value == null)
                postcodeParam.Value = System.DBNull.Value;

            var indexnoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexno", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = indexno.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!indexno.HasValue)
                indexnoParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = shopid, Size = 50 };
            if (shopidParam.Value == null)
                shopidParam.Value = System.DBNull.Value;

            var startdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@startdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = startdt.GetValueOrDefault() };
            if (!startdt.HasValue)
                startdtParam.Value = System.DBNull.Value;

            var enddtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@enddt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = enddt.GetValueOrDefault() };
            if (!enddt.HasValue)
                enddtParam.Value = System.DBNull.Value;

            var createdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createdt.GetValueOrDefault() };
            if (!createdt.HasValue)
                createdtParam.Value = System.DBNull.Value;

            var createuserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createuser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = createuser, Size = 50 };
            if (createuserParam.Value == null)
                createuserParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_advsearch_ADD] @postcode, @indexno, @shopid, @startdt, @enddt, @createdt, @createuser", postcodeParam, indexnoParam, shopidParam, startdtParam, enddtParam, createdtParam, createuserParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpAppUserAdd(int? shopid, string password, string usertype, string username, string status, System.DateTime? createdt, string createuser, string loginstatus, out int? appuserid)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var passwordParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@password", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = password, Size = 100 };
            if (passwordParam.Value == null)
                passwordParam.Value = System.DBNull.Value;

            var usertypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@usertype", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = usertype, Size = 1 };
            if (usertypeParam.Value == null)
                usertypeParam.Value = System.DBNull.Value;

            var usernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@username", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = username, Size = 100 };
            if (usernameParam.Value == null)
                usernameParam.Value = System.DBNull.Value;

            var statusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@status", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = status, Size = 1 };
            if (statusParam.Value == null)
                statusParam.Value = System.DBNull.Value;

            var createdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createdt.GetValueOrDefault() };
            if (!createdt.HasValue)
                createdtParam.Value = System.DBNull.Value;

            var createuserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createuser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = createuser, Size = 100 };
            if (createuserParam.Value == null)
                createuserParam.Value = System.DBNull.Value;

            var loginstatusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginstatus", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = loginstatus, Size = 1 };
            if (loginstatusParam.Value == null)
                loginstatusParam.Value = System.DBNull.Value;

            var appuseridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@appuserid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[SP_AppUser_ADD] @shopid, @password, @usertype, @username, @status, @createdt, @createuser, @loginstatus, @appuserid OUTPUT", shopidParam, passwordParam, usertypeParam, usernameParam, statusParam, createdtParam, createuserParam, loginstatusParam, appuseridParam, procResultParam);
            if (IsSqlParameterNull(appuseridParam))
                appuserid = null;
            else
                appuserid = (int)appuseridParam.Value;

            return (int)procResultParam.Value;
        }

        public int SpAppuserExit(string apptokenstr)
        {
            var apptokenstrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@apptokenstr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = apptokenstr, Size = 100 };
            if (apptokenstrParam.Value == null)
                apptokenstrParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[SP_Appuser_Exit] @apptokenstr", apptokenstrParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpAppUserLogin(string loginname, string loginip, string apptokenstr, string devicetoken)
        {
            var loginnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = loginname, Size = 100 };
            if (loginnameParam.Value == null)
                loginnameParam.Value = System.DBNull.Value;

            var loginipParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginip", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = loginip, Size = 50 };
            if (loginipParam.Value == null)
                loginipParam.Value = System.DBNull.Value;

            var apptokenstrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@apptokenstr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = apptokenstr, Size = 100 };
            if (apptokenstrParam.Value == null)
                apptokenstrParam.Value = System.DBNull.Value;

            var devicetokenParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@devicetoken", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = devicetoken, Size = 100 };
            if (devicetokenParam.Value == null)
                devicetokenParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[SP_AppUser_Login] @loginname, @loginip, @apptokenstr, @devicetoken", loginnameParam, loginipParam, apptokenstrParam, devicetokenParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpAppUserSettingAdd(string operatecode, int? appuserid)
        {
            var operatecodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operatecode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = operatecode, Size = 100 };
            if (operatecodeParam.Value == null)
                operatecodeParam.Value = System.DBNull.Value;

            var appuseridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@appuserid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = appuserid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!appuserid.HasValue)
                appuseridParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[SP_AppUserSetting_ADD] @operatecode, @appuserid", operatecodeParam, appuseridParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpDeleteOrder(string orderid)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_deleteOrder] @orderid", orderidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpGetMenuInfoOfSets(int? shopid, int? mid, int? catid)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var midParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mid.HasValue)
                midParam.Value = System.DBNull.Value;

            var catidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = catid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!catid.HasValue)
                catidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_GetMenuInfoOfSets] @shopid, @mid, @catid", shopidParam, midParam, catidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public SpGetMenuInfosReturnModel SpGetMenuInfos(int? shopid, int? catid)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var catidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = catid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!catid.HasValue)
                catidParam.Value = System.DBNull.Value;


            var procResultData = new SpGetMenuInfosReturnModel();
            var cmd = Database.Connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[sp_GetMenuInfos]";
            cmd.Parameters.Add(shopidParam);
            cmd.Parameters.Add(catidParam);

            try
            {
                Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;

                procResultData.ResultSet1 = objectContext.Translate<SpGetMenuInfosReturnModel.ResultSetModel1>(reader).ToList();
                reader.NextResult();

                procResultData.ResultSet2 = objectContext.Translate<SpGetMenuInfosReturnModel.ResultSetModel2>(reader).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
            return procResultData;
        }

        public SpGetPlInfoReturnModel SpGetPlInfo(string menutype1, string menutype2, int? shopid)
        {
            var menutype1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype1, Size = 50 };
            if (menutype1Param.Value == null)
                menutype1Param.Value = System.DBNull.Value;

            var menutype2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype2, Size = 50 };
            if (menutype2Param.Value == null)
                menutype2Param.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;


            var procResultData = new SpGetPlInfoReturnModel();
            var cmd = Database.Connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[sp_GetPLInfo]";
            cmd.Parameters.Add(menutype1Param);
            cmd.Parameters.Add(menutype2Param);
            cmd.Parameters.Add(shopidParam);

            try
            {
                Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;

                procResultData.ResultSet1 = objectContext.Translate<SpGetPlInfoReturnModel.ResultSetModel1>(reader).ToList();
                reader.NextResult();

                procResultData.ResultSet2 = objectContext.Translate<SpGetPlInfoReturnModel.ResultSetModel2>(reader).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
            return procResultData;
        }

        public int SpMenuAdd(int? shopid, string menuCat, string menuName, string menuName2, string menuDesc, string menuDesc2, decimal? price1, decimal? price2, string menutype, string menulogo, string discountway, string menucode, string servicePeriod, string displayweekday, string hasSideOrder, string hasPl, System.DateTime? createDt, string flag, decimal? indexnum, int? mealamt)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var menuCatParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuCat", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuCat, Size = 30 };
            if (menuCatParam.Value == null)
                menuCatParam.Value = System.DBNull.Value;

            var menuNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName, Size = 200 };
            if (menuNameParam.Value == null)
                menuNameParam.Value = System.DBNull.Value;

            var menuName2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName2, Size = 200 };
            if (menuName2Param.Value == null)
                menuName2Param.Value = System.DBNull.Value;

            var menuDescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuDesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuDesc, Size = 500 };
            if (menuDescParam.Value == null)
                menuDescParam.Value = System.DBNull.Value;

            var menuDesc2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuDesc2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuDesc2, Size = 500 };
            if (menuDesc2Param.Value == null)
                menuDesc2Param.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var price2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price2", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = price2.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!price2.HasValue)
                price2Param.Value = System.DBNull.Value;

            var menutypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = menutype, Size = 1 };
            if (menutypeParam.Value == null)
                menutypeParam.Value = System.DBNull.Value;

            var menulogoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menulogo", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menulogo, Size = 100 };
            if (menulogoParam.Value == null)
                menulogoParam.Value = System.DBNull.Value;

            var discountwayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@discountway", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = discountway, Size = 1 };
            if (discountwayParam.Value == null)
                discountwayParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 20 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var servicePeriodParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@servicePeriod", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = servicePeriod, Size = 1 };
            if (servicePeriodParam.Value == null)
                servicePeriodParam.Value = System.DBNull.Value;

            var displayweekdayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@displayweekday", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = displayweekday, Size = 50 };
            if (displayweekdayParam.Value == null)
                displayweekdayParam.Value = System.DBNull.Value;

            var hasSideOrderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@hasSideOrder", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = hasSideOrder, Size = 1 };
            if (hasSideOrderParam.Value == null)
                hasSideOrderParam.Value = System.DBNull.Value;

            var hasPlParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@hasPL", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = hasPl, Size = 1 };
            if (hasPlParam.Value == null)
                hasPlParam.Value = System.DBNull.Value;

            var createDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CreateDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createDt.GetValueOrDefault() };
            if (!createDt.HasValue)
                createDtParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 50 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var mealamtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mealamt", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mealamt.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mealamt.HasValue)
                mealamtParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_menu_ADD] @shopid, @menuCat, @menuName, @menuName2, @menuDesc, @menuDesc2, @price1, @price2, @menutype, @menulogo, @discountway, @menucode, @servicePeriod, @displayweekday, @hasSideOrder, @hasPL, @CreateDT, @flag, @indexnum, @mealamt", shopidParam, menuCatParam, menuNameParam, menuName2Param, menuDescParam, menuDesc2Param, price1Param, price2Param, menutypeParam, menulogoParam, discountwayParam, menucodeParam, servicePeriodParam, displayweekdayParam, hasSideOrderParam, hasPlParam, createDtParam, flagParam, indexnumParam, mealamtParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuUpdate(int? mid, int? shopid, string menuCat, string menuName, string menuName2, string menuDesc, string menuDesc2, decimal? price1, decimal? price2, string menutype, string menulogo, string menucode, string servicePeriod, string displayweekday, string hasSideOrder, string hasPl, System.DateTime? updateDt, string flag, decimal? indexnum, int? mealamt)
        {
            var midParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mid.HasValue)
                midParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var menuCatParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuCat", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuCat, Size = 30 };
            if (menuCatParam.Value == null)
                menuCatParam.Value = System.DBNull.Value;

            var menuNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName, Size = 200 };
            if (menuNameParam.Value == null)
                menuNameParam.Value = System.DBNull.Value;

            var menuName2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName2, Size = 200 };
            if (menuName2Param.Value == null)
                menuName2Param.Value = System.DBNull.Value;

            var menuDescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuDesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuDesc, Size = 500 };
            if (menuDescParam.Value == null)
                menuDescParam.Value = System.DBNull.Value;

            var menuDesc2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuDesc2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuDesc2, Size = 500 };
            if (menuDesc2Param.Value == null)
                menuDesc2Param.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var price2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price2", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = price2.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!price2.HasValue)
                price2Param.Value = System.DBNull.Value;

            var menutypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = menutype, Size = 1 };
            if (menutypeParam.Value == null)
                menutypeParam.Value = System.DBNull.Value;

            var menulogoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menulogo", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menulogo, Size = 100 };
            if (menulogoParam.Value == null)
                menulogoParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 20 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var servicePeriodParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@servicePeriod", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = servicePeriod, Size = 1 };
            if (servicePeriodParam.Value == null)
                servicePeriodParam.Value = System.DBNull.Value;

            var displayweekdayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@displayweekday", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = displayweekday, Size = 50 };
            if (displayweekdayParam.Value == null)
                displayweekdayParam.Value = System.DBNull.Value;

            var hasSideOrderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@hasSideOrder", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = hasSideOrder, Size = 1 };
            if (hasSideOrderParam.Value == null)
                hasSideOrderParam.Value = System.DBNull.Value;

            var hasPlParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@hasPL", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = hasPl, Size = 1 };
            if (hasPlParam.Value == null)
                hasPlParam.Value = System.DBNull.Value;

            var updateDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UpdateDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = updateDt.GetValueOrDefault() };
            if (!updateDt.HasValue)
                updateDtParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 50 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var mealamtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mealamt", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mealamt.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mealamt.HasValue)
                mealamtParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_menu_Update] @mid, @shopid, @menuCat, @menuName, @menuName2, @menuDesc, @menuDesc2, @price1, @price2, @menutype, @menulogo, @menucode, @servicePeriod, @displayweekday, @hasSideOrder, @hasPL, @UpdateDT, @flag, @indexnum, @mealamt", midParam, shopidParam, menuCatParam, menuNameParam, menuName2Param, menuDescParam, menuDesc2Param, price1Param, price2Param, menutypeParam, menulogoParam, menucodeParam, servicePeriodParam, displayweekdayParam, hasSideOrderParam, hasPlParam, updateDtParam, flagParam, indexnumParam, mealamtParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuBasicAdd(int? shopid, string menutype1, string menutype2, string mname, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001, decimal? indexnum)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var menutype1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype1, Size = 50 };
            if (menutype1Param.Value == null)
                menutype1Param.Value = System.DBNull.Value;

            var menutype2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype2, Size = 100 };
            if (menutype2Param.Value == null)
                menutype2Param.Value = System.DBNull.Value;

            var mnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname, Size = 100 };
            if (mnameParam.Value == null)
                mnameParam.Value = System.DBNull.Value;

            var mname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname2, Size = 100 };
            if (mname2Param.Value == null)
                mname2Param.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var price2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price2", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price2.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price2.HasValue)
                price2Param.Value = System.DBNull.Value;

            var menudesc2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc2, Size = 50 };
            if (menudesc2Param.Value == null)
                menudesc2Param.Value = System.DBNull.Value;

            var menudescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc, Size = 50 };
            if (menudescParam.Value == null)
                menudescParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 50 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var menu001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menu001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menu001, Size = 50 };
            if (menu001Param.Value == null)
                menu001Param.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuBasic_ADD] @shopid, @menutype1, @menutype2, @mname, @mname2, @price1, @price2, @menudesc2, @menudesc, @menucode, @flag, @menu001, @indexnum", shopidParam, menutype1Param, menutype2Param, mnameParam, mname2Param, price1Param, price2Param, menudesc2Param, menudescParam, menucodeParam, flagParam, menu001Param, indexnumParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuBasicDelete(int? basicmenuid, int? shopid)
        {
            var basicmenuidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicmenuid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = basicmenuid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!basicmenuid.HasValue)
                basicmenuidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuBasic_Delete] @basicmenuid, @shopid", basicmenuidParam, shopidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuBasicUpdate(int? basicmenuid, int? shopid, string mname, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001, decimal? indexnum)
        {
            var basicmenuidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicmenuid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = basicmenuid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!basicmenuid.HasValue)
                basicmenuidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var mnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname, Size = 100 };
            if (mnameParam.Value == null)
                mnameParam.Value = System.DBNull.Value;

            var mname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname2, Size = 100 };
            if (mname2Param.Value == null)
                mname2Param.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var price2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price2", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price2.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price2.HasValue)
                price2Param.Value = System.DBNull.Value;

            var menudesc2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc2, Size = 50 };
            if (menudesc2Param.Value == null)
                menudesc2Param.Value = System.DBNull.Value;

            var menudescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc, Size = 50 };
            if (menudescParam.Value == null)
                menudescParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 50 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var menu001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menu001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menu001, Size = 50 };
            if (menu001Param.Value == null)
                menu001Param.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuBasic_Update] @basicmenuid, @shopid, @mname, @mname2, @price1, @price2, @menudesc2, @menudesc, @menucode, @flag, @menu001, @indexnum", basicmenuidParam, shopidParam, mnameParam, mname2Param, price1Param, price2Param, menudesc2Param, menudescParam, menucodeParam, flagParam, menu001Param, indexnumParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuBasicTemplateAdd(string menutype1, string menutype2, string mname, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001)
        {
            var menutype1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype1, Size = 50 };
            if (menutype1Param.Value == null)
                menutype1Param.Value = System.DBNull.Value;

            var menutype2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype2, Size = 100 };
            if (menutype2Param.Value == null)
                menutype2Param.Value = System.DBNull.Value;

            var mnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname, Size = 100 };
            if (mnameParam.Value == null)
                mnameParam.Value = System.DBNull.Value;

            var mname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname2, Size = 100 };
            if (mname2Param.Value == null)
                mname2Param.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var price2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price2", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price2.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price2.HasValue)
                price2Param.Value = System.DBNull.Value;

            var menudesc2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc2, Size = 50 };
            if (menudesc2Param.Value == null)
                menudesc2Param.Value = System.DBNull.Value;

            var menudescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc, Size = 50 };
            if (menudescParam.Value == null)
                menudescParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 50 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var menu001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menu001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menu001, Size = 50 };
            if (menu001Param.Value == null)
                menu001Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuBasicTemplate_ADD] @menutype1, @menutype2, @mname, @mname2, @price1, @price2, @menudesc2, @menudesc, @menucode, @flag, @menu001", menutype1Param, menutype2Param, mnameParam, mname2Param, price1Param, price2Param, menudesc2Param, menudescParam, menucodeParam, flagParam, menu001Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuBasicTemplateUpdate(int? basicmenuid, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001)
        {
            var basicmenuidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicmenuid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = basicmenuid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!basicmenuid.HasValue)
                basicmenuidParam.Value = System.DBNull.Value;

            var mname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@mname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mname2, Size = 100 };
            if (mname2Param.Value == null)
                mname2Param.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var price2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price2", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = price2.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!price2.HasValue)
                price2Param.Value = System.DBNull.Value;

            var menudesc2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc2, Size = 50 };
            if (menudesc2Param.Value == null)
                menudesc2Param.Value = System.DBNull.Value;

            var menudescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menudesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menudesc, Size = 50 };
            if (menudescParam.Value == null)
                menudescParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 50 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var menu001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menu001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menu001, Size = 50 };
            if (menu001Param.Value == null)
                menu001Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuBasicTemplate_Update] @basicmenuid, @mname2, @price1, @price2, @menudesc2, @menudesc, @menucode, @flag, @menu001", basicmenuidParam, mname2Param, price1Param, price2Param, menudesc2Param, menudescParam, menucodeParam, flagParam, menu001Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuCatBasicMenuUpdate(int? catid, int? shopid, string menutype1, string menutype2, string basicmenuids)
        {
            var catidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = catid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!catid.HasValue)
                catidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var menutype1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype1, Size = 50 };
            if (menutype1Param.Value == null)
                menutype1Param.Value = System.DBNull.Value;

            var menutype2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menutype2, Size = 50 };
            if (menutype2Param.Value == null)
                menutype2Param.Value = System.DBNull.Value;

            var basicmenuidsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicmenuids", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = basicmenuids, Size = 3000 };
            if (basicmenuidsParam.Value == null)
                basicmenuidsParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_menuCatBasicMenu_Update] @catid, @shopid, @menutype1, @menutype2, @basicmenuids", catidParam, shopidParam, menutype1Param, menutype2Param, basicmenuidsParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenucattemplateAdd(decimal? indexnum, string catname, string catname2, string cat001)
        {
            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 7, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var catnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catname, Size = 100 };
            if (catnameParam.Value == null)
                catnameParam.Value = System.DBNull.Value;

            var catname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@catname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catname2, Size = 100 };
            if (catname2Param.Value == null)
                catname2Param.Value = System.DBNull.Value;

            var cat001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@cat001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cat001, Size = 50 };
            if (cat001Param.Value == null)
                cat001Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_menucattemplate_ADD] @indexnum, @catname, @catname2, @cat001", indexnumParam, catnameParam, catname2Param, cat001Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenucattemplateUpdate(int? catid, decimal? indexnum, string catname, string catname2, string cat001)
        {
            var catidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = catid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!catid.HasValue)
                catidParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 7, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var catnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catname, Size = 100 };
            if (catnameParam.Value == null)
                catnameParam.Value = System.DBNull.Value;

            var catname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@catname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catname2, Size = 100 };
            if (catname2Param.Value == null)
                catname2Param.Value = System.DBNull.Value;

            var cat001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@cat001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cat001, Size = 50 };
            if (cat001Param.Value == null)
                cat001Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_menucattemplate_Update] @catid, @indexnum, @catname, @catname2, @cat001", catidParam, indexnumParam, catnameParam, catname2Param, cat001Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuOptionCatAdd(int? shopid, string optionname, string optionname2, string flag, decimal? indexnum, string optiondesc)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var optionnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@optionname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = optionname, Size = 100 };
            if (optionnameParam.Value == null)
                optionnameParam.Value = System.DBNull.Value;

            var optionname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@optionname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = optionname2, Size = 100 };
            if (optionname2Param.Value == null)
                optionname2Param.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var optiondescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@optiondesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = optiondesc, Size = 300 };
            if (optiondescParam.Value == null)
                optiondescParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuOptionCat_ADD] @shopid, @optionname, @optionname2, @flag, @indexnum, @optiondesc", shopidParam, optionnameParam, optionname2Param, flagParam, indexnumParam, optiondescParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuOptionCatDelete(int? optioncatid, int? shopid)
        {
            var optioncatidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@optioncatid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = optioncatid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!optioncatid.HasValue)
                optioncatidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuOptionCat_Delete] @optioncatid, @shopid", optioncatidParam, shopidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMenuOptionCatUpdate(decimal? optioncatid, int? shopid, string optionname, string optionname2, string flag, decimal? indexnum, string optiondesc)
        {
            var optioncatidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@optioncatid", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = optioncatid.GetValueOrDefault(), Precision = 18, Scale = 1 };
            if (!optioncatid.HasValue)
                optioncatidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var optionnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@optionname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = optionname, Size = 100 };
            if (optionnameParam.Value == null)
                optionnameParam.Value = System.DBNull.Value;

            var optionname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@optionname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = optionname2, Size = 100 };
            if (optionname2Param.Value == null)
                optionname2Param.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var optiondescParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@optiondesc", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = optiondesc, Size = 300 };
            if (optiondescParam.Value == null)
                optiondescParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_MenuOptionCat_Update] @optioncatid, @shopid, @optionname, @optionname2, @flag, @indexnum, @optiondesc", optioncatidParam, shopidParam, optionnameParam, optionname2Param, flagParam, indexnumParam, optiondescParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpMultilangmenuAdd(string menuname, string name1, string name2, string name3, string name4, string name5, string name6, string name7)
        {
            var menunameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuname, Size = 100 };
            if (menunameParam.Value == null)
                menunameParam.Value = System.DBNull.Value;

            var name1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name1, Size = 100 };
            if (name1Param.Value == null)
                name1Param.Value = System.DBNull.Value;

            var name2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name2, Size = 100 };
            if (name2Param.Value == null)
                name2Param.Value = System.DBNull.Value;

            var name3Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name3", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name3, Size = 100 };
            if (name3Param.Value == null)
                name3Param.Value = System.DBNull.Value;

            var name4Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name4", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name4, Size = 100 };
            if (name4Param.Value == null)
                name4Param.Value = System.DBNull.Value;

            var name5Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name5", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name5, Size = 100 };
            if (name5Param.Value == null)
                name5Param.Value = System.DBNull.Value;

            var name6Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name6", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name6, Size = 100 };
            if (name6Param.Value == null)
                name6Param.Value = System.DBNull.Value;

            var name7Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name7", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name7, Size = 100 };
            if (name7Param.Value == null)
                name7Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_multilangmenu_ADD] @menuname, @name1, @name2, @name3, @name4, @name5, @name6, @name7", menunameParam, name1Param, name2Param, name3Param, name4Param, name5Param, name6Param, name7Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpOrderdeliveryAdd(string orderid, string addr1, string addr2, string addr3, string townname, string postcode1, string postcode2, string contactname, string tel1, string tel2, System.DateTime? deliverdt, string deliverpeople, string comments)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var addr2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr2, Size = 100 };
            if (addr2Param.Value == null)
                addr2Param.Value = System.DBNull.Value;

            var addr3Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr3", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr3, Size = 100 };
            if (addr3Param.Value == null)
                addr3Param.Value = System.DBNull.Value;

            var townnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@townname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = townname, Size = 100 };
            if (townnameParam.Value == null)
                townnameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 10 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 10 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var contactnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactname, Size = 50 };
            if (contactnameParam.Value == null)
                contactnameParam.Value = System.DBNull.Value;

            var tel1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel1, Size = 50 };
            if (tel1Param.Value == null)
                tel1Param.Value = System.DBNull.Value;

            var tel2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel2, Size = 50 };
            if (tel2Param.Value == null)
                tel2Param.Value = System.DBNull.Value;

            var deliverdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@deliverdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = deliverdt.GetValueOrDefault() };
            if (!deliverdt.HasValue)
                deliverdtParam.Value = System.DBNull.Value;

            var deliverpeopleParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@deliverpeople", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = deliverpeople, Size = 50 };
            if (deliverpeopleParam.Value == null)
                deliverpeopleParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 300 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_orderdelivery_ADD] @orderid, @addr1, @addr2, @addr3, @townname, @postcode1, @postcode2, @contactname, @tel1, @tel2, @deliverdt, @deliverpeople, @comments", orderidParam, addr1Param, addr2Param, addr3Param, townnameParam, postcode1Param, postcode2Param, contactnameParam, tel1Param, tel2Param, deliverdtParam, deliverpeopleParam, commentsParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpOrderitemAdd(string orderid, int? mid, int? submenuid, string menucode, string menuName, string menuNameE, string menuName2, string menuName2E, int? amount, decimal? price1, decimal? discountprice, decimal? totalprice, string menulogo, string menutype)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var midParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mid.HasValue)
                midParam.Value = System.DBNull.Value;

            var submenuidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@submenuid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = submenuid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!submenuid.HasValue)
                submenuidParam.Value = System.DBNull.Value;

            var menucodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menucode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menucode, Size = 20 };
            if (menucodeParam.Value == null)
                menucodeParam.Value = System.DBNull.Value;

            var menuNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName, Size = 200 };
            if (menuNameParam.Value == null)
                menuNameParam.Value = System.DBNull.Value;

            var menuNameEParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuNameE", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuNameE, Size = 500 };
            if (menuNameEParam.Value == null)
                menuNameEParam.Value = System.DBNull.Value;

            var menuName2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName2, Size = 200 };
            if (menuName2Param.Value == null)
                menuName2Param.Value = System.DBNull.Value;

            var menuName2EParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menuName2E", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuName2E, Size = 500 };
            if (menuName2EParam.Value == null)
                menuName2EParam.Value = System.DBNull.Value;

            var amountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@amount", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = amount.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!amount.HasValue)
                amountParam.Value = System.DBNull.Value;

            var price1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@price1", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = price1.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!price1.HasValue)
                price1Param.Value = System.DBNull.Value;

            var discountpriceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@discountprice", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = discountprice.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!discountprice.HasValue)
                discountpriceParam.Value = System.DBNull.Value;

            var totalpriceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@totalprice", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = totalprice.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!totalprice.HasValue)
                totalpriceParam.Value = System.DBNull.Value;

            var menulogoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menulogo", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menulogo, Size = 100 };
            if (menulogoParam.Value == null)
                menulogoParam.Value = System.DBNull.Value;

            var menutypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@menutype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = menutype, Size = 1 };
            if (menutypeParam.Value == null)
                menutypeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_orderitem_ADD] @orderid, @mid, @submenuid, @menucode, @menuName, @menuNameE, @menuName2, @menuName2E, @amount, @price1, @discountprice, @totalprice, @menulogo, @menutype", orderidParam, midParam, submenuidParam, menucodeParam, menuNameParam, menuNameEParam, menuName2Param, menuName2EParam, amountParam, price1Param, discountpriceParam, totalpriceParam, menulogoParam, menutypeParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpOrderpaymentAdd(string orderid, string cardnumber, string cardtype, string name1, string name2, System.DateTime? paidtime, System.DateTime? applytime, decimal? paidamount, string isret)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var cardnumberParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardnumber", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cardnumber, Size = 50 };
            if (cardnumberParam.Value == null)
                cardnumberParam.Value = System.DBNull.Value;

            var cardtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardtype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = cardtype, Size = 1 };
            if (cardtypeParam.Value == null)
                cardtypeParam.Value = System.DBNull.Value;

            var name1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name1, Size = 50 };
            if (name1Param.Value == null)
                name1Param.Value = System.DBNull.Value;

            var name2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@name2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = name2, Size = 50 };
            if (name2Param.Value == null)
                name2Param.Value = System.DBNull.Value;

            var paidtimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@paidtime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = paidtime.GetValueOrDefault() };
            if (!paidtime.HasValue)
                paidtimeParam.Value = System.DBNull.Value;

            var applytimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@applytime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = applytime.GetValueOrDefault() };
            if (!applytime.HasValue)
                applytimeParam.Value = System.DBNull.Value;

            var paidamountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@paidamount", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = paidamount.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!paidamount.HasValue)
                paidamountParam.Value = System.DBNull.Value;

            var isretParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isret", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isret, Size = 1 };
            if (isretParam.Value == null)
                isretParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_orderpayment_ADD] @orderid, @cardnumber, @cardtype, @name1, @name2, @paidtime, @applytime, @paidamount, @isret", orderidParam, cardnumberParam, cardtypeParam, name1Param, name2Param, paidtimeParam, applytimeParam, paidamountParam, isretParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpOrdersAdd(out string orderId, int? shopid, int? uid, string useremail, string payway, string ispaid, string ticketnumber, int? ticketvalue, string deliveryway, string comments, string orderstatus, System.DateTime? ordercreatedt, string isCancelled, decimal? totalprice1, decimal? discountRate, decimal? afterdiscount, decimal? deliverycharge, decimal? serviceCharge, decimal? creditcardCharge, decimal? tips, string isjz, decimal? totalamount, string userIp, System.DateTime? pickupdt, decimal? commrate, string isnew, decimal? shopcardcharge, decimal? paidwithcredit, string vouchercode)
        {
            var orderIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@OrderID", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 30 };
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var useremailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@useremail", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = useremail, Size = 100 };
            if (useremailParam.Value == null)
                useremailParam.Value = System.DBNull.Value;

            var paywayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@payway", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = payway, Size = 1 };
            if (paywayParam.Value == null)
                paywayParam.Value = System.DBNull.Value;

            var ispaidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ispaid", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = ispaid, Size = 1 };
            if (ispaidParam.Value == null)
                ispaidParam.Value = System.DBNull.Value;

            var ticketnumberParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ticketnumber", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ticketnumber, Size = 50 };
            if (ticketnumberParam.Value == null)
                ticketnumberParam.Value = System.DBNull.Value;

            var ticketvalueParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ticketvalue", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ticketvalue.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ticketvalue.HasValue)
                ticketvalueParam.Value = System.DBNull.Value;

            var deliverywayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@deliveryway", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = deliveryway, Size = 1 };
            if (deliverywayParam.Value == null)
                deliverywayParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 500 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var orderstatusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderstatus", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderstatus, Size = 50 };
            if (orderstatusParam.Value == null)
                orderstatusParam.Value = System.DBNull.Value;

            var ordercreatedtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ordercreatedt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = ordercreatedt.GetValueOrDefault() };
            if (!ordercreatedt.HasValue)
                ordercreatedtParam.Value = System.DBNull.Value;

            var isCancelledParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isCancelled", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isCancelled, Size = 1 };
            if (isCancelledParam.Value == null)
                isCancelledParam.Value = System.DBNull.Value;

            var totalprice1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@totalprice1", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = totalprice1.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!totalprice1.HasValue)
                totalprice1Param.Value = System.DBNull.Value;

            var discountRateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@discountRate", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = discountRate.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!discountRate.HasValue)
                discountRateParam.Value = System.DBNull.Value;

            var afterdiscountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@afterdiscount", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = afterdiscount.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!afterdiscount.HasValue)
                afterdiscountParam.Value = System.DBNull.Value;

            var deliverychargeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@deliverycharge", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = deliverycharge.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!deliverycharge.HasValue)
                deliverychargeParam.Value = System.DBNull.Value;

            var serviceChargeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@serviceCharge", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = serviceCharge.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!serviceCharge.HasValue)
                serviceChargeParam.Value = System.DBNull.Value;

            var creditcardChargeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@creditcardCharge", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = creditcardCharge.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!creditcardCharge.HasValue)
                creditcardChargeParam.Value = System.DBNull.Value;

            var tipsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tips", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = tips.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!tips.HasValue)
                tipsParam.Value = System.DBNull.Value;

            var isjzParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isjz", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isjz, Size = 1 };
            if (isjzParam.Value == null)
                isjzParam.Value = System.DBNull.Value;

            var totalamountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@totalamount", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = totalamount.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!totalamount.HasValue)
                totalamountParam.Value = System.DBNull.Value;

            var userIpParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@userIP", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = userIp, Size = 100 };
            if (userIpParam.Value == null)
                userIpParam.Value = System.DBNull.Value;

            var pickupdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pickupdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = pickupdt.GetValueOrDefault() };
            if (!pickupdt.HasValue)
                pickupdtParam.Value = System.DBNull.Value;

            var commrateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@commrate", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = commrate.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!commrate.HasValue)
                commrateParam.Value = System.DBNull.Value;

            var isnewParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isnew", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isnew, Size = 1 };
            if (isnewParam.Value == null)
                isnewParam.Value = System.DBNull.Value;

            var shopcardchargeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopcardcharge", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = shopcardcharge.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!shopcardcharge.HasValue)
                shopcardchargeParam.Value = System.DBNull.Value;

            var paidwithcreditParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@paidwithcredit", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = paidwithcredit.GetValueOrDefault(), Precision = 10, Scale = 4 };
            if (!paidwithcredit.HasValue)
                paidwithcreditParam.Value = System.DBNull.Value;

            var vouchercodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@vouchercode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = vouchercode, Size = 30 };
            if (vouchercodeParam.Value == null)
                vouchercodeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_orders_ADD] @OrderID OUTPUT, @shopid, @uid, @useremail, @payway, @ispaid, @ticketnumber, @ticketvalue, @deliveryway, @comments, @orderstatus, @ordercreatedt, @isCancelled, @totalprice1, @discountRate, @afterdiscount, @deliverycharge, @serviceCharge, @creditcardCharge, @tips, @isjz, @totalamount, @userIP, @pickupdt, @commrate, @isnew, @shopcardcharge, @paidwithcredit, @vouchercode", orderIdParam, shopidParam, uidParam, useremailParam, paywayParam, ispaidParam, ticketnumberParam, ticketvalueParam, deliverywayParam, commentsParam, orderstatusParam, ordercreatedtParam, isCancelledParam, totalprice1Param, discountRateParam, afterdiscountParam, deliverychargeParam, serviceChargeParam, creditcardChargeParam, tipsParam, isjzParam, totalamountParam, userIpParam, pickupdtParam, commrateParam, isnewParam, shopcardchargeParam, paidwithcreditParam, vouchercodeParam, procResultParam);
            if (IsSqlParameterNull(orderIdParam))
                orderId = default(string);
            else
                orderId = (string)orderIdParam.Value;

            return (int)procResultParam.Value;
        }

        public int SpRefreshByDeviceTokenId(string devicetoken)
        {
            var devicetokenParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@devicetoken", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = devicetoken, Size = 100 };
            if (devicetokenParam.Value == null)
                devicetokenParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[SP_RefreshByDeviceTokenId] @devicetoken", devicetokenParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpRefreshDeviceDt(string apptokenstr)
        {
            var apptokenstrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@apptokenstr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = apptokenstr, Size = 100 };
            if (apptokenstrParam.Value == null)
                apptokenstrParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[SP_RefreshDeviceDT] @apptokenstr", apptokenstrParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopAdd(int? shopid, string sname, string sname2, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string cityname, string postcode1, string postcode2, string description, string acceptpay, string acceptorder, string bankname, string bankusername, string banksortcode, string bankno, decimal? webcommision, System.DateTime? expireddt)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var snameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname, Size = 100 };
            if (snameParam.Value == null)
                snameParam.Value = System.DBNull.Value;

            var sname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname2, Size = 100 };
            if (sname2Param.Value == null)
                sname2Param.Value = System.DBNull.Value;

            var tel1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel1, Size = 50 };
            if (tel1Param.Value == null)
                tel1Param.Value = System.DBNull.Value;

            var tel2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel2, Size = 50 };
            if (tel2Param.Value == null)
                tel2Param.Value = System.DBNull.Value;

            var faxParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fax", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = fax, Size = 50 };
            if (faxParam.Value == null)
                faxParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var contactnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactname, Size = 50 };
            if (contactnameParam.Value == null)
                contactnameParam.Value = System.DBNull.Value;

            var contactTelParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactTel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactTel, Size = 50 };
            if (contactTelParam.Value == null)
                contactTelParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var citynameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cityname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cityname, Size = 100 };
            if (citynameParam.Value == null)
                citynameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 50 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 50 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 3000 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var acceptpayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptpay", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptpay, Size = 10 };
            if (acceptpayParam.Value == null)
                acceptpayParam.Value = System.DBNull.Value;

            var acceptorderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptorder", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptorder, Size = 20 };
            if (acceptorderParam.Value == null)
                acceptorderParam.Value = System.DBNull.Value;

            var banknameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankname, Size = 50 };
            if (banknameParam.Value == null)
                banknameParam.Value = System.DBNull.Value;

            var bankusernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankusername", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankusername, Size = 50 };
            if (bankusernameParam.Value == null)
                bankusernameParam.Value = System.DBNull.Value;

            var banksortcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@banksortcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = banksortcode, Size = 50 };
            if (banksortcodeParam.Value == null)
                banksortcodeParam.Value = System.DBNull.Value;

            var banknoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankno", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankno, Size = 50 };
            if (banknoParam.Value == null)
                banknoParam.Value = System.DBNull.Value;

            var webcommisionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@webcommision", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = webcommision.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!webcommision.HasValue)
                webcommisionParam.Value = System.DBNull.Value;

            var expireddtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@expireddt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = expireddt.GetValueOrDefault() };
            if (!expireddt.HasValue)
                expireddtParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shop_ADD] @shopid, @sname, @sname2, @tel1, @tel2, @fax, @email, @contactname, @contactTel, @addr1, @cityname, @postcode1, @postcode2, @description, @acceptpay, @acceptorder, @bankname, @bankusername, @banksortcode, @bankno, @webcommision, @expireddt", shopidParam, snameParam, sname2Param, tel1Param, tel2Param, faxParam, emailParam, contactnameParam, contactTelParam, addr1Param, citynameParam, postcode1Param, postcode2Param, descriptionParam, acceptpayParam, acceptorderParam, banknameParam, bankusernameParam, banksortcodeParam, banknoParam, webcommisionParam, expireddtParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopAddDeliveryInfo(int? shopid, string serviceType, string serviceTypeL, string deliveryWay, string deliverytime, string deliveryLastOt, decimal? deliveryMinOrder)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var serviceTypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@serviceType", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = serviceType, Size = 1 };
            if (serviceTypeParam.Value == null)
                serviceTypeParam.Value = System.DBNull.Value;

            var serviceTypeLParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@serviceTypeL", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = serviceTypeL, Size = 1 };
            if (serviceTypeLParam.Value == null)
                serviceTypeLParam.Value = System.DBNull.Value;

            var deliveryWayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@deliveryWay", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = deliveryWay, Size = 1 };
            if (deliveryWayParam.Value == null)
                deliveryWayParam.Value = System.DBNull.Value;

            var deliverytimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Deliverytime", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = deliverytime, Size = 50 };
            if (deliverytimeParam.Value == null)
                deliverytimeParam.Value = System.DBNull.Value;

            var deliveryLastOtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DeliveryLastOT", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = deliveryLastOt, Size = 50 };
            if (deliveryLastOtParam.Value == null)
                deliveryLastOtParam.Value = System.DBNull.Value;

            var deliveryMinOrderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DeliveryMinOrder", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = deliveryMinOrder.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!deliveryMinOrder.HasValue)
                deliveryMinOrderParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shop_ADDDeliveryInfo] @shopid, @serviceType, @serviceTypeL, @deliveryWay, @Deliverytime, @DeliveryLastOT, @DeliveryMinOrder", shopidParam, serviceTypeParam, serviceTypeLParam, deliveryWayParam, deliverytimeParam, deliveryLastOtParam, deliveryMinOrderParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopChangeboard(string board, int? shopid)
        {
            var boardParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@board", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = board, Size = 500 };
            if (boardParam.Value == null)
                boardParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shop_changeboard] @board, @shopid", boardParam, shopidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopUpdate(int? shopid, string sname, string sname2, string mealtype, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string addr2, string cityname, string postcode1, string postcode2, string logo, string description, System.DateTime? updateTime, string alias, string acceptpay, string orderlang, string acceptorder, string bankname, string bankusername, string banksortcode, string bankno, decimal? webcommision, System.DateTime? expireddt, string acceptCustomerOpt)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var snameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname, Size = 100 };
            if (snameParam.Value == null)
                snameParam.Value = System.DBNull.Value;

            var sname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname2, Size = 100 };
            if (sname2Param.Value == null)
                sname2Param.Value = System.DBNull.Value;

            var mealtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mealtype", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mealtype, Size = 50 };
            if (mealtypeParam.Value == null)
                mealtypeParam.Value = System.DBNull.Value;

            var tel1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel1, Size = 50 };
            if (tel1Param.Value == null)
                tel1Param.Value = System.DBNull.Value;

            var tel2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel2, Size = 50 };
            if (tel2Param.Value == null)
                tel2Param.Value = System.DBNull.Value;

            var faxParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fax", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = fax, Size = 50 };
            if (faxParam.Value == null)
                faxParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var contactnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactname, Size = 50 };
            if (contactnameParam.Value == null)
                contactnameParam.Value = System.DBNull.Value;

            var contactTelParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactTel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactTel, Size = 50 };
            if (contactTelParam.Value == null)
                contactTelParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var addr2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr2, Size = 100 };
            if (addr2Param.Value == null)
                addr2Param.Value = System.DBNull.Value;

            var citynameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cityname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cityname, Size = 100 };
            if (citynameParam.Value == null)
                citynameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 50 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 50 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var logoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@logo", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = logo, Size = 100 };
            if (logoParam.Value == null)
                logoParam.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 3000 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var updateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@updateTime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = updateTime.GetValueOrDefault() };
            if (!updateTime.HasValue)
                updateTimeParam.Value = System.DBNull.Value;

            var aliasParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@alias", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = alias, Size = 100 };
            if (aliasParam.Value == null)
                aliasParam.Value = System.DBNull.Value;

            var acceptpayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptpay", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptpay, Size = 10 };
            if (acceptpayParam.Value == null)
                acceptpayParam.Value = System.DBNull.Value;

            var orderlangParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderlang", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderlang, Size = 10 };
            if (orderlangParam.Value == null)
                orderlangParam.Value = System.DBNull.Value;

            var acceptorderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptorder", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptorder, Size = 20 };
            if (acceptorderParam.Value == null)
                acceptorderParam.Value = System.DBNull.Value;

            var banknameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankname, Size = 50 };
            if (banknameParam.Value == null)
                banknameParam.Value = System.DBNull.Value;

            var bankusernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankusername", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankusername, Size = 50 };
            if (bankusernameParam.Value == null)
                bankusernameParam.Value = System.DBNull.Value;

            var banksortcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@banksortcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = banksortcode, Size = 50 };
            if (banksortcodeParam.Value == null)
                banksortcodeParam.Value = System.DBNull.Value;

            var banknoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankno", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankno, Size = 50 };
            if (banknoParam.Value == null)
                banknoParam.Value = System.DBNull.Value;

            var webcommisionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@webcommision", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = webcommision.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!webcommision.HasValue)
                webcommisionParam.Value = System.DBNull.Value;

            var expireddtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@expireddt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = expireddt.GetValueOrDefault() };
            if (!expireddt.HasValue)
                expireddtParam.Value = System.DBNull.Value;

            var acceptCustomerOptParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptCustomerOpt", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptCustomerOpt, Size = 50 };
            if (acceptCustomerOptParam.Value == null)
                acceptCustomerOptParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shop_Update] @shopid, @sname, @sname2, @mealtype, @tel1, @tel2, @fax, @email, @contactname, @contactTel, @addr1, @addr2, @cityname, @postcode1, @postcode2, @logo, @description, @updateTime, @alias, @acceptpay, @orderlang, @acceptorder, @bankname, @bankusername, @banksortcode, @bankno, @webcommision, @expireddt, @acceptCustomerOpt", shopidParam, snameParam, sname2Param, mealtypeParam, tel1Param, tel2Param, faxParam, emailParam, contactnameParam, contactTelParam, addr1Param, addr2Param, citynameParam, postcode1Param, postcode2Param, logoParam, descriptionParam, updateTimeParam, aliasParam, acceptpayParam, orderlangParam, acceptorderParam, banknameParam, bankusernameParam, banksortcodeParam, banknoParam, webcommisionParam, expireddtParam, acceptCustomerOptParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopUpdate2(int? shopid, string sname, string sname2, string mealtype, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string addr2, string cityname, string postcode1, string postcode2, string description, System.DateTime? updateTime, string alias, string acceptpay, string orderlang, string acceptorder)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var snameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname, Size = 100 };
            if (snameParam.Value == null)
                snameParam.Value = System.DBNull.Value;

            var sname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname2, Size = 100 };
            if (sname2Param.Value == null)
                sname2Param.Value = System.DBNull.Value;

            var mealtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mealtype", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mealtype, Size = 50 };
            if (mealtypeParam.Value == null)
                mealtypeParam.Value = System.DBNull.Value;

            var tel1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel1, Size = 50 };
            if (tel1Param.Value == null)
                tel1Param.Value = System.DBNull.Value;

            var tel2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel2, Size = 50 };
            if (tel2Param.Value == null)
                tel2Param.Value = System.DBNull.Value;

            var faxParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fax", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = fax, Size = 50 };
            if (faxParam.Value == null)
                faxParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var contactnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactname, Size = 50 };
            if (contactnameParam.Value == null)
                contactnameParam.Value = System.DBNull.Value;

            var contactTelParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactTel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactTel, Size = 50 };
            if (contactTelParam.Value == null)
                contactTelParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var addr2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr2, Size = 100 };
            if (addr2Param.Value == null)
                addr2Param.Value = System.DBNull.Value;

            var citynameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cityname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cityname, Size = 100 };
            if (citynameParam.Value == null)
                citynameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 50 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 50 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 3000 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var updateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@updateTime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = updateTime.GetValueOrDefault() };
            if (!updateTime.HasValue)
                updateTimeParam.Value = System.DBNull.Value;

            var aliasParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@alias", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = alias, Size = 100 };
            if (aliasParam.Value == null)
                aliasParam.Value = System.DBNull.Value;

            var acceptpayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptpay", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptpay, Size = 10 };
            if (acceptpayParam.Value == null)
                acceptpayParam.Value = System.DBNull.Value;

            var orderlangParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderlang", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderlang, Size = 10 };
            if (orderlangParam.Value == null)
                orderlangParam.Value = System.DBNull.Value;

            var acceptorderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptorder", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptorder, Size = 20 };
            if (acceptorderParam.Value == null)
                acceptorderParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shop_Update2] @shopid, @sname, @sname2, @mealtype, @tel1, @tel2, @fax, @email, @contactname, @contactTel, @addr1, @addr2, @cityname, @postcode1, @postcode2, @description, @updateTime, @alias, @acceptpay, @orderlang, @acceptorder", shopidParam, snameParam, sname2Param, mealtypeParam, tel1Param, tel2Param, faxParam, emailParam, contactnameParam, contactTelParam, addr1Param, addr2Param, citynameParam, postcode1Param, postcode2Param, descriptionParam, updateTimeParam, aliasParam, acceptpayParam, orderlangParam, acceptorderParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopUpdate3(int? shopid, string description, System.DateTime? updateTime, string alias, string orderlang)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 3000 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var updateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@updateTime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = updateTime.GetValueOrDefault() };
            if (!updateTime.HasValue)
                updateTimeParam.Value = System.DBNull.Value;

            var aliasParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@alias", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = alias, Size = 100 };
            if (aliasParam.Value == null)
                aliasParam.Value = System.DBNull.Value;

            var orderlangParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderlang", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderlang, Size = 10 };
            if (orderlangParam.Value == null)
                orderlangParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shop_Update3] @shopid, @description, @updateTime, @alias, @orderlang", shopidParam, descriptionParam, updateTimeParam, aliasParam, orderlangParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopDelieveryAreaAdd(int? shopid, string postcode1, decimal? delieveryCost, string comments, System.DateTime? createDt, string flag1, string bak001)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 10 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var delieveryCostParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@delieveryCost", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = delieveryCost.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!delieveryCost.HasValue)
                delieveryCostParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 200 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var createDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createDt.GetValueOrDefault() };
            if (!createDt.HasValue)
                createDtParam.Value = System.DBNull.Value;

            var flag1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag1", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag1, Size = 1 };
            if (flag1Param.Value == null)
                flag1Param.Value = System.DBNull.Value;

            var bak001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@bak001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bak001, Size = 50 };
            if (bak001Param.Value == null)
                bak001Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shopDelieveryArea_ADD] @shopid, @postcode1, @delieveryCost, @comments, @createDT, @flag1, @bak001", shopidParam, postcode1Param, delieveryCostParam, commentsParam, createDtParam, flag1Param, bak001Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopDelieveryAreaUpdate(int? did, int? shopid, decimal? delieveryCost, string comments, string flag1, string bak001)
        {
            var didParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@did", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = did.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!did.HasValue)
                didParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var delieveryCostParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@delieveryCost", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = delieveryCost.GetValueOrDefault(), Precision = 8, Scale = 2 };
            if (!delieveryCost.HasValue)
                delieveryCostParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 200 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var flag1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag1", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag1, Size = 1 };
            if (flag1Param.Value == null)
                flag1Param.Value = System.DBNull.Value;

            var bak001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@bak001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bak001, Size = 50 };
            if (bak001Param.Value == null)
                bak001Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shopDelieveryArea_Update] @did, @shopid, @delieveryCost, @comments, @flag1, @bak001", didParam, shopidParam, delieveryCostParam, commentsParam, flag1Param, bak001Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopdiscountUpdate(int? shopid, string board, string discountway, decimal? minorderamt, int? discountrate)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var boardParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@board", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = board, Size = 500 };
            if (boardParam.Value == null)
                boardParam.Value = System.DBNull.Value;

            var discountwayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@discountway", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = discountway, Size = 1 };
            if (discountwayParam.Value == null)
                discountwayParam.Value = System.DBNull.Value;

            var minorderamtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@minorderamt", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = minorderamt.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!minorderamt.HasValue)
                minorderamtParam.Value = System.DBNull.Value;

            var discountrateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@discountrate", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = discountrate.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!discountrate.HasValue)
                discountrateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shopdiscount_Update] @shopid, @board, @discountway, @minorderamt, @discountrate", shopidParam, boardParam, discountwayParam, minorderamtParam, discountrateParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopJz(System.DateTime? frdt, System.DateTime? todt, decimal? stdcommrate, string shoploginname, string createUser, out string ret)
        {
            var frdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@frdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = frdt.GetValueOrDefault() };
            if (!frdt.HasValue)
                frdtParam.Value = System.DBNull.Value;

            var todtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@todt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = todt.GetValueOrDefault() };
            if (!todt.HasValue)
                todtParam.Value = System.DBNull.Value;

            var stdcommrateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@stdcommrate", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = stdcommrate.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!stdcommrate.HasValue)
                stdcommrateParam.Value = System.DBNull.Value;

            var shoploginnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shoploginname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = shoploginname, Size = 50 };
            if (shoploginnameParam.Value == null)
                shoploginnameParam.Value = System.DBNull.Value;

            var createUserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createUser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = createUser, Size = 30 };
            if (createUserParam.Value == null)
                createUserParam.Value = System.DBNull.Value;

            var retParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ret", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 50 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_ShopJZ] @frdt, @todt, @stdcommrate, @shoploginname, @createUser, @ret OUTPUT", frdtParam, todtParam, stdcommrateParam, shoploginnameParam, createUserParam, retParam, procResultParam);
            if (IsSqlParameterNull(retParam))
                ret = default(string);
            else
                ret = (string)retParam.Value;

            return (int)procResultParam.Value;
        }

        public int SpShoppingCartAdd(int? customerId, string customerSessionId, System.DateTime? createdOn, System.DateTime? updateOn, int? shopid, int? productId, int? mainfoodid, string menuOptionIDs, string subProductId, int? quantity)
        {
            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@customerID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = customerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!customerId.HasValue)
                customerIdParam.Value = System.DBNull.Value;

            var customerSessionIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@customerSessionID", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = customerSessionId, Size = 50 };
            if (customerSessionIdParam.Value == null)
                customerSessionIdParam.Value = System.DBNull.Value;

            var createdOnParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@CreatedOn", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createdOn.GetValueOrDefault() };
            if (!createdOn.HasValue)
                createdOnParam.Value = System.DBNull.Value;

            var updateOnParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UpdateOn", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = updateOn.GetValueOrDefault() };
            if (!updateOn.HasValue)
                updateOnParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var productIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ProductID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = productId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!productId.HasValue)
                productIdParam.Value = System.DBNull.Value;

            var mainfoodidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mainfoodid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mainfoodid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mainfoodid.HasValue)
                mainfoodidParam.Value = System.DBNull.Value;

            var menuOptionIDsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@MenuOptionIDs", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = menuOptionIDs, Size = 1000 };
            if (menuOptionIDsParam.Value == null)
                menuOptionIDsParam.Value = System.DBNull.Value;

            var subProductIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@SubProductID", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = subProductId, Size = 1000 };
            if (subProductIdParam.Value == null)
                subProductIdParam.Value = System.DBNull.Value;

            var quantityParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Quantity", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = quantity.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!quantity.HasValue)
                quantityParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_ShoppingCart_ADD] @customerID, @customerSessionID, @CreatedOn, @UpdateOn, @shopid, @ProductID, @mainfoodid, @MenuOptionIDs, @SubProductID, @Quantity", customerIdParam, customerSessionIdParam, createdOnParam, updateOnParam, shopidParam, productIdParam, mainfoodidParam, menuOptionIDsParam, subProductIdParam, quantityParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShoppingCartUpdate(int? cartid, int? customerId, string customerSessionId, System.DateTime? updateOn, int? quantity, int? productId, string subProductId, string opt)
        {
            var cartidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cartid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cartid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cartid.HasValue)
                cartidParam.Value = System.DBNull.Value;

            var customerIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@customerID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = customerId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!customerId.HasValue)
                customerIdParam.Value = System.DBNull.Value;

            var customerSessionIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@customerSessionID", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = customerSessionId, Size = 50 };
            if (customerSessionIdParam.Value == null)
                customerSessionIdParam.Value = System.DBNull.Value;

            var updateOnParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@UpdateOn", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = updateOn.GetValueOrDefault() };
            if (!updateOn.HasValue)
                updateOnParam.Value = System.DBNull.Value;

            var quantityParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Quantity", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = quantity.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!quantity.HasValue)
                quantityParam.Value = System.DBNull.Value;

            var productIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ProductID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = productId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!productId.HasValue)
                productIdParam.Value = System.DBNull.Value;

            var subProductIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@SubProductID", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = subProductId, Size = 500 };
            if (subProductIdParam.Value == null)
                subProductIdParam.Value = System.DBNull.Value;

            var optParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@opt", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = opt, Size = 1 };
            if (optParam.Value == null)
                optParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_ShoppingCart_Update] @cartid, @customerID, @customerSessionID, @UpdateOn, @Quantity, @ProductID, @SubProductID, @opt", cartidParam, customerIdParam, customerSessionIdParam, updateOnParam, quantityParam, productIdParam, subProductIdParam, optParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpShopunjz(System.DateTime? frdt, System.DateTime? todt, decimal? stdcommrate, string shoploginname, string createUser, out string ret)
        {
            var frdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@frdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = frdt.GetValueOrDefault() };
            if (!frdt.HasValue)
                frdtParam.Value = System.DBNull.Value;

            var todtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@todt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = todt.GetValueOrDefault() };
            if (!todt.HasValue)
                todtParam.Value = System.DBNull.Value;

            var stdcommrateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@stdcommrate", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = stdcommrate.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!stdcommrate.HasValue)
                stdcommrateParam.Value = System.DBNull.Value;

            var shoploginnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shoploginname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = shoploginname, Size = 50 };
            if (shoploginnameParam.Value == null)
                shoploginnameParam.Value = System.DBNull.Value;

            var createUserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createUser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = createUser, Size = 30 };
            if (createUserParam.Value == null)
                createUserParam.Value = System.DBNull.Value;

            var retParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ret", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 50 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_shopunjz] @frdt, @todt, @stdcommrate, @shoploginname, @createUser, @ret OUTPUT", frdtParam, todtParam, stdcommrateParam, shoploginnameParam, createUserParam, retParam, procResultParam);
            if (IsSqlParameterNull(retParam))
                ret = default(string);
            else
                ret = (string)retParam.Value;

            return (int)procResultParam.Value;
        }

        public int SpSysLogAdd(string userid, string actstr, System.DateTime? actdt, string priority)
        {
            var useridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@userid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = userid, Size = 50 };
            if (useridParam.Value == null)
                useridParam.Value = System.DBNull.Value;

            var actstrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@actstr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = actstr, Size = 800 };
            if (actstrParam.Value == null)
                actstrParam.Value = System.DBNull.Value;

            var actdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@actdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = actdt.GetValueOrDefault() };
            if (!actdt.HasValue)
                actdtParam.Value = System.DBNull.Value;

            var priorityParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@priority", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = priority, Size = 10 };
            if (priorityParam.Value == null)
                priorityParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_sysLog_ADD] @userid, @actstr, @actdt, @priority", useridParam, actstrParam, actdtParam, priorityParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpUserCreditInfoAdd(int? shopid, int? userid, string moneydirection, decimal? amt, string comment, string orderid, System.DateTime? createdt)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var useridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@userid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = userid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!userid.HasValue)
                useridParam.Value = System.DBNull.Value;

            var moneydirectionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@moneydirection", SqlDbType = System.Data.SqlDbType.NChar, Direction = System.Data.ParameterDirection.Input, Value = moneydirection, Size = 2 };
            if (moneydirectionParam.Value == null)
                moneydirectionParam.Value = System.DBNull.Value;

            var amtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@amt", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = amt.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!amt.HasValue)
                amtParam.Value = System.DBNull.Value;

            var commentParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comment", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comment, Size = 500 };
            if (commentParam.Value == null)
                commentParam.Value = System.DBNull.Value;

            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var createdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createdt.GetValueOrDefault() };
            if (!createdt.HasValue)
                createdtParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_UserCreditInfo_Add] @shopid, @userid, @moneydirection, @amt, @comment, @orderid, @createdt", shopidParam, useridParam, moneydirectionParam, amtParam, commentParam, orderidParam, createdtParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpUserregChangeCredits(int? sid, int? uid, string act)
        {
            var sidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = sid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!sid.HasValue)
                sidParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var actParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@act", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = act, Size = 1 };
            if (actParam.Value == null)
                actParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_userreg_ChangeCredits] @sid, @uid, @act", sidParam, uidParam, actParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpUserregChangeScore(int? sid, int? uid, string act)
        {
            var sidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = sid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!sid.HasValue)
                sidParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var actParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@act", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = act, Size = 1 };
            if (actParam.Value == null)
                actParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_userreg_ChangeScore] @sid, @uid, @act", sidParam, uidParam, actParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<SpUserRegExistReturnModel> SpUserRegExist(string email)
        {
            int procResult;
            return SpUserRegExist(email, out procResult);
        }

        public System.Collections.Generic.List<SpUserRegExistReturnModel> SpUserRegExist(string email, out int procResult)
        {
            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<SpUserRegExistReturnModel>("EXEC @procResult = [dbo].[sp_UserReg_Exist] @email", emailParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int SpUserregUpdateutype(string upwd, string utype, int? uid)
        {
            var upwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@upwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = upwd, Size = 50 };
            if (upwdParam.Value == null)
                upwdParam.Value = System.DBNull.Value;

            var utypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@utype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = utype, Size = 1 };
            if (utypeParam.Value == null)
                utypeParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_userreg_updateutype] @upwd, @utype, @uid", upwdParam, utypeParam, uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int SpViewtelAdd(int? shopid, System.DateTime? actdt)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var actdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@actdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = actdt.GetValueOrDefault() };
            if (!actdt.HasValue)
                actdtParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[sp_viewtel_ADD] @shopid, @actdt", shopidParam, actdtParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpCreateShopUser(string utype, string pwd, out int? uid, out string email)
        {
            var utypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@utype", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = utype, Size = 15 };
            if (utypeParam.Value == null)
                utypeParam.Value = System.DBNull.Value;

            var pwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwd, Size = 50 };
            if (pwdParam.Value == null)
                pwdParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 100 };
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_CreateShopUser] @utype, @pwd, @uid OUTPUT, @email OUTPUT", utypeParam, pwdParam, uidParam, emailParam, procResultParam);
            if (IsSqlParameterNull(uidParam))
                uid = null;
            else
                uid = (int)uidParam.Value;
            if (IsSqlParameterNull(emailParam))
                email = default(string);
            else
                email = (string)emailParam.Value;

            return (int)procResultParam.Value;
        }

        public int UpCreditCardAdd(int? uid, string acct, string acctType, string street, string city, string state, string country, string zip, int? cardIssue, string cardStart, string expDate, string firstName, string lastName, string cvv2)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var acctParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ACCT", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acct, Size = 50 };
            if (acctParam.Value == null)
                acctParam.Value = System.DBNull.Value;

            var acctTypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@AcctType", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acctType, Size = 50 };
            if (acctTypeParam.Value == null)
                acctTypeParam.Value = System.DBNull.Value;

            var streetParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Street", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = street, Size = 100 };
            if (streetParam.Value == null)
                streetParam.Value = System.DBNull.Value;

            var cityParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@city", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = city, Size = 50 };
            if (cityParam.Value == null)
                cityParam.Value = System.DBNull.Value;

            var stateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@state", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = state, Size = 50 };
            if (stateParam.Value == null)
                stateParam.Value = System.DBNull.Value;

            var countryParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@country", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = country, Size = 50 };
            if (countryParam.Value == null)
                countryParam.Value = System.DBNull.Value;

            var zipParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@zip", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = zip, Size = 20 };
            if (zipParam.Value == null)
                zipParam.Value = System.DBNull.Value;

            var cardIssueParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardIssue", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cardIssue.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cardIssue.HasValue)
                cardIssueParam.Value = System.DBNull.Value;

            var cardStartParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardStart", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cardStart, Size = 15 };
            if (cardStartParam.Value == null)
                cardStartParam.Value = System.DBNull.Value;

            var expDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@expDate", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = expDate, Size = 50 };
            if (expDateParam.Value == null)
                expDateParam.Value = System.DBNull.Value;

            var firstNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@firstName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = firstName, Size = 50 };
            if (firstNameParam.Value == null)
                firstNameParam.Value = System.DBNull.Value;

            var lastNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@lastName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = lastName, Size = 50 };
            if (lastNameParam.Value == null)
                lastNameParam.Value = System.DBNull.Value;

            var cvv2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@CVV2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cvv2, Size = 10 };
            if (cvv2Param.Value == null)
                cvv2Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_creditCard_ADD] @uid, @ACCT, @AcctType, @Street, @city, @state, @country, @zip, @cardIssue, @cardStart, @expDate, @firstName, @lastName, @CVV2", uidParam, acctParam, acctTypeParam, streetParam, cityParam, stateParam, countryParam, zipParam, cardIssueParam, cardStartParam, expDateParam, firstNameParam, lastNameParam, cvv2Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpCreditCardDelete(int? cardid, int? uid)
        {
            var cardidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cardid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cardid.HasValue)
                cardidParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_creditCard_Delete] @cardid, @uid", cardidParam, uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpCreditCardGetListReturnModel> UpCreditCardGetList(int? uid)
        {
            int procResult;
            return UpCreditCardGetList(uid, out procResult);
        }

        public System.Collections.Generic.List<UpCreditCardGetListReturnModel> UpCreditCardGetList(int? uid, out int procResult)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpCreditCardGetListReturnModel>("EXEC @procResult = [dbo].[UP_creditCard_GetList] @uid", uidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpCreditCardUpdate(int? cardid, int? uid, string acct, string acctType, string street, string city, string state, string country, string zip, int? cardIssue, string cardStart, string expDate, string firstName, string lastName, string cvv2)
        {
            var cardidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cardid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cardid.HasValue)
                cardidParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var acctParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ACCT", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acct, Size = 50 };
            if (acctParam.Value == null)
                acctParam.Value = System.DBNull.Value;

            var acctTypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@AcctType", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acctType, Size = 50 };
            if (acctTypeParam.Value == null)
                acctTypeParam.Value = System.DBNull.Value;

            var streetParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Street", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = street, Size = 100 };
            if (streetParam.Value == null)
                streetParam.Value = System.DBNull.Value;

            var cityParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@city", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = city, Size = 50 };
            if (cityParam.Value == null)
                cityParam.Value = System.DBNull.Value;

            var stateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@state", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = state, Size = 50 };
            if (stateParam.Value == null)
                stateParam.Value = System.DBNull.Value;

            var countryParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@country", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = country, Size = 50 };
            if (countryParam.Value == null)
                countryParam.Value = System.DBNull.Value;

            var zipParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@zip", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = zip, Size = 20 };
            if (zipParam.Value == null)
                zipParam.Value = System.DBNull.Value;

            var cardIssueParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardIssue", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = cardIssue.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!cardIssue.HasValue)
                cardIssueParam.Value = System.DBNull.Value;

            var cardStartParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cardStart", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cardStart, Size = 15 };
            if (cardStartParam.Value == null)
                cardStartParam.Value = System.DBNull.Value;

            var expDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@expDate", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = expDate, Size = 50 };
            if (expDateParam.Value == null)
                expDateParam.Value = System.DBNull.Value;

            var firstNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@firstName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = firstName, Size = 50 };
            if (firstNameParam.Value == null)
                firstNameParam.Value = System.DBNull.Value;

            var lastNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@lastName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = lastName, Size = 50 };
            if (lastNameParam.Value == null)
                lastNameParam.Value = System.DBNull.Value;

            var cvv2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@CVV2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cvv2, Size = 10 };
            if (cvv2Param.Value == null)
                cvv2Param.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_creditCard_Update] @cardid, @uid, @ACCT, @AcctType, @Street, @city, @state, @country, @zip, @cardIssue, @cardStart, @expDate, @firstName, @lastName, @CVV2", cardidParam, uidParam, acctParam, acctTypeParam, streetParam, cityParam, stateParam, countryParam, zipParam, cardIssueParam, cardStartParam, expDateParam, firstNameParam, lastNameParam, cvv2Param, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpCustomerReviewAdd(int? uid, string email, decimal? rate1, decimal? rate2, decimal? rate3, decimal? rate4, System.DateTime? reviewDate, string reviewtype, int? objid, string orderid, string comment, string replyMsg)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 50 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var rate1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@rate1", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = rate1.GetValueOrDefault(), Precision = 2, Scale = 1 };
            if (!rate1.HasValue)
                rate1Param.Value = System.DBNull.Value;

            var rate2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@rate2", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = rate2.GetValueOrDefault(), Precision = 2, Scale = 1 };
            if (!rate2.HasValue)
                rate2Param.Value = System.DBNull.Value;

            var rate3Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@rate3", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = rate3.GetValueOrDefault(), Precision = 2, Scale = 1 };
            if (!rate3.HasValue)
                rate3Param.Value = System.DBNull.Value;

            var rate4Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@rate4", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = rate4.GetValueOrDefault(), Precision = 2, Scale = 1 };
            if (!rate4.HasValue)
                rate4Param.Value = System.DBNull.Value;

            var reviewDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@reviewDate", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = reviewDate.GetValueOrDefault() };
            if (!reviewDate.HasValue)
                reviewDateParam.Value = System.DBNull.Value;

            var reviewtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@reviewtype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = reviewtype, Size = 1 };
            if (reviewtypeParam.Value == null)
                reviewtypeParam.Value = System.DBNull.Value;

            var objidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@objid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = objid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!objid.HasValue)
                objidParam.Value = System.DBNull.Value;

            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var commentParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comment", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comment, Size = 500 };
            if (commentParam.Value == null)
                commentParam.Value = System.DBNull.Value;

            var replyMsgParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@replyMsg", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = replyMsg, Size = 500 };
            if (replyMsgParam.Value == null)
                replyMsgParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_customerReview_ADD] @uid, @email, @rate1, @rate2, @rate3, @rate4, @reviewDate, @reviewtype, @objid, @orderid, @comment, @replyMsg", uidParam, emailParam, rate1Param, rate2Param, rate3Param, rate4Param, reviewDateParam, reviewtypeParam, objidParam, orderidParam, commentParam, replyMsgParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpCustomerReviewDelete(int? reviewid, int? shopid)
        {
            var reviewidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@reviewid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = reviewid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!reviewid.HasValue)
                reviewidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_customerReview_Delete] @reviewid, @shopid", reviewidParam, shopidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpCustomerReviewForMealAdd(int? uid, string email, decimal? rate1, System.DateTime? reviewDate, string reviewtype, int? objid, string orderid)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 50 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var rate1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@rate1", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = rate1.GetValueOrDefault(), Precision = 2, Scale = 1 };
            if (!rate1.HasValue)
                rate1Param.Value = System.DBNull.Value;

            var reviewDateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@reviewDate", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = reviewDate.GetValueOrDefault() };
            if (!reviewDate.HasValue)
                reviewDateParam.Value = System.DBNull.Value;

            var reviewtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@reviewtype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = reviewtype, Size = 1 };
            if (reviewtypeParam.Value == null)
                reviewtypeParam.Value = System.DBNull.Value;

            var objidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@objid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = objid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!objid.HasValue)
                objidParam.Value = System.DBNull.Value;

            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_customerReviewForMeal_ADD] @uid, @email, @rate1, @reviewDate, @reviewtype, @objid, @orderid", uidParam, emailParam, rate1Param, reviewDateParam, reviewtypeParam, objidParam, orderidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpDeliveryAddrAdd(out int? addrid, int? uid, string username, string addrname, string addr1, string addr2, string addr3, string cityname, string postcode1, string postcode2, string tel, string comments, string flag, string mobile)
        {
            var addridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addrid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var usernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@username", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = username, Size = 100 };
            if (usernameParam.Value == null)
                usernameParam.Value = System.DBNull.Value;

            var addrnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addrname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addrname, Size = 100 };
            if (addrnameParam.Value == null)
                addrnameParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var addr2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr2, Size = 100 };
            if (addr2Param.Value == null)
                addr2Param.Value = System.DBNull.Value;

            var addr3Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr3", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr3, Size = 100 };
            if (addr3Param.Value == null)
                addr3Param.Value = System.DBNull.Value;

            var citynameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cityname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cityname, Size = 100 };
            if (citynameParam.Value == null)
                citynameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 10 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 10 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var telParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel, Size = 100 };
            if (telParam.Value == null)
                telParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 100 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var mobileParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mobile", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mobile, Size = 50 };
            if (mobileParam.Value == null)
                mobileParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_deliveryAddr_ADD] @addrid OUTPUT, @uid, @username, @addrname, @addr1, @addr2, @addr3, @cityname, @postcode1, @postcode2, @tel, @comments, @flag, @mobile", addridParam, uidParam, usernameParam, addrnameParam, addr1Param, addr2Param, addr3Param, citynameParam, postcode1Param, postcode2Param, telParam, commentsParam, flagParam, mobileParam, procResultParam);
            if (IsSqlParameterNull(addridParam))
                addrid = null;
            else
                addrid = (int)addridParam.Value;

            return (int)procResultParam.Value;
        }

        public int UpDeliveryAddrDelete(int? addrid, int? uid)
        {
            var addridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addrid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = addrid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!addrid.HasValue)
                addridParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_deliveryAddr_Delete] @addrid, @uid", addridParam, uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpDeliveryAddrGetListReturnModel> UpDeliveryAddrGetList(int? uid)
        {
            int procResult;
            return UpDeliveryAddrGetList(uid, out procResult);
        }

        public System.Collections.Generic.List<UpDeliveryAddrGetListReturnModel> UpDeliveryAddrGetList(int? uid, out int procResult)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpDeliveryAddrGetListReturnModel>("EXEC @procResult = [dbo].[UP_deliveryAddr_GetList] @uid", uidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public System.Collections.Generic.List<UpDeliveryAddrGetModelByIdReturnModel> UpDeliveryAddrGetModelById(int? addrid)
        {
            int procResult;
            return UpDeliveryAddrGetModelById(addrid, out procResult);
        }

        public System.Collections.Generic.List<UpDeliveryAddrGetModelByIdReturnModel> UpDeliveryAddrGetModelById(int? addrid, out int procResult)
        {
            var addridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addrid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = addrid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!addrid.HasValue)
                addridParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpDeliveryAddrGetModelByIdReturnModel>("EXEC @procResult = [dbo].[up_deliveryAddr_GetModelById] @addrid", addridParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpDeliveryAddrUpdate(int? addrid, int? uid, string username, string addrname, string addr1, string addr2, string addr3, string cityname, string postcode1, string postcode2, string tel, string comments, string flag, string mobile)
        {
            var addridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addrid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = addrid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!addrid.HasValue)
                addridParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var usernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@username", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = username, Size = 100 };
            if (usernameParam.Value == null)
                usernameParam.Value = System.DBNull.Value;

            var addrnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addrname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addrname, Size = 100 };
            if (addrnameParam.Value == null)
                addrnameParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var addr2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr2, Size = 100 };
            if (addr2Param.Value == null)
                addr2Param.Value = System.DBNull.Value;

            var addr3Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr3", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr3, Size = 100 };
            if (addr3Param.Value == null)
                addr3Param.Value = System.DBNull.Value;

            var citynameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cityname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cityname, Size = 100 };
            if (citynameParam.Value == null)
                citynameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 10 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 10 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var telParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel, Size = 100 };
            if (telParam.Value == null)
                telParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 100 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 1 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var mobileParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mobile", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mobile, Size = 50 };
            if (mobileParam.Value == null)
                mobileParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_deliveryAddr_Update] @addrid, @uid, @username, @addrname, @addr1, @addr2, @addr3, @cityname, @postcode1, @postcode2, @tel, @comments, @flag, @mobile", addridParam, uidParam, usernameParam, addrnameParam, addr1Param, addr2Param, addr3Param, citynameParam, postcode1Param, postcode2Param, telParam, commentsParam, flagParam, mobileParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpDeliveryCostAdd(int? shopid, string costtype, int? basicDistance, decimal? basicPrice, decimal? freeAmount, decimal? unitRate)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var costtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@costtype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = costtype, Size = 1 };
            if (costtypeParam.Value == null)
                costtypeParam.Value = System.DBNull.Value;

            var basicDistanceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicDistance", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = basicDistance.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!basicDistance.HasValue)
                basicDistanceParam.Value = System.DBNull.Value;

            var basicPriceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicPrice", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = basicPrice.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!basicPrice.HasValue)
                basicPriceParam.Value = System.DBNull.Value;

            var freeAmountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@freeAmount", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = freeAmount.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!freeAmount.HasValue)
                freeAmountParam.Value = System.DBNull.Value;

            var unitRateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@unitRate", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = unitRate.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!unitRate.HasValue)
                unitRateParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_deliveryCost_ADD] @shopid, @costtype, @basicDistance, @basicPrice, @freeAmount, @unitRate", shopidParam, costtypeParam, basicDistanceParam, basicPriceParam, freeAmountParam, unitRateParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpFavouritesAdd(out int? fid, int? uid, string ftype, int? shopid, int? mid, System.DateTime? createDt, string flag)
        {
            var fidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var ftypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ftype", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ftype, Size = 10 };
            if (ftypeParam.Value == null)
                ftypeParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var midParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = mid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!mid.HasValue)
                midParam.Value = System.DBNull.Value;

            var createDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createDt.GetValueOrDefault() };
            if (!createDt.HasValue)
                createDtParam.Value = System.DBNull.Value;

            var flagParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@flag", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = flag, Size = 50 };
            if (flagParam.Value == null)
                flagParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_favourites_ADD] @fid OUTPUT, @uid, @ftype, @shopid, @mid, @createDT, @flag", fidParam, uidParam, ftypeParam, shopidParam, midParam, createDtParam, flagParam, procResultParam);
            if (IsSqlParameterNull(fidParam))
                fid = null;
            else
                fid = (int)fidParam.Value;

            return (int)procResultParam.Value;
        }

        public int UpFavouritesDelete(int? fid, int? uid)
        {
            var fidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = fid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!fid.HasValue)
                fidParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_favourites_Delete] @fid, @uid", fidParam, uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpFavouritesGetModelReturnModel> UpFavouritesGetModel(int? fid)
        {
            int procResult;
            return UpFavouritesGetModel(fid, out procResult);
        }

        public System.Collections.Generic.List<UpFavouritesGetModelReturnModel> UpFavouritesGetModel(int? fid, out int procResult)
        {
            var fidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = fid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!fid.HasValue)
                fidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpFavouritesGetModelReturnModel>("EXEC @procResult = [dbo].[UP_favourites_GetModel] @fid", fidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public UpGetUserEmailReturnModel UpGetUserEmail(string utype)
        {
            var utypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@utype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = utype, Size = 1 };
            if (utypeParam.Value == null)
                utypeParam.Value = System.DBNull.Value;


            var procResultData = new UpGetUserEmailReturnModel();
            var cmd = Database.Connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[UP_GetUserEmail]";
            cmd.Parameters.Add(utypeParam);

            try
            {
                Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;

                procResultData.ResultSet1 = objectContext.Translate<UpGetUserEmailReturnModel.ResultSetModel1>(reader).ToList();
                reader.NextResult();

                procResultData.ResultSet2 = objectContext.Translate<UpGetUserEmailReturnModel.ResultSetModel2>(reader).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
            return procResultData;
        }

        public int UpMenuCatAdd(int? shopid, string catName, string catName2, string description, string description2, string servicePeriod, string displayweekday, string pcsetting, System.DateTime? createDt, decimal? indexnum, string logostr)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var catNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catName, Size = 100 };
            if (catNameParam.Value == null)
                catNameParam.Value = System.DBNull.Value;

            var catName2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@catName2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catName2, Size = 100 };
            if (catName2Param.Value == null)
                catName2Param.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 500 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var description2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@description2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description2, Size = 500 };
            if (description2Param.Value == null)
                description2Param.Value = System.DBNull.Value;

            var servicePeriodParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@servicePeriod", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = servicePeriod, Size = 1 };
            if (servicePeriodParam.Value == null)
                servicePeriodParam.Value = System.DBNull.Value;

            var displayweekdayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@displayweekday", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = displayweekday, Size = 50 };
            if (displayweekdayParam.Value == null)
                displayweekdayParam.Value = System.DBNull.Value;

            var pcsettingParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pcsetting", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pcsetting, Size = 50 };
            if (pcsettingParam.Value == null)
                pcsettingParam.Value = System.DBNull.Value;

            var createDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = createDt.GetValueOrDefault() };
            if (!createDt.HasValue)
                createDtParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var logostrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@logostr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = logostr, Size = 80 };
            if (logostrParam.Value == null)
                logostrParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_menuCat_ADD] @shopid, @catName, @catName2, @description, @description2, @servicePeriod, @displayweekday, @pcsetting, @createDT, @indexnum, @logostr", shopidParam, catNameParam, catName2Param, descriptionParam, description2Param, servicePeriodParam, displayweekdayParam, pcsettingParam, createDtParam, indexnumParam, logostrParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpMenuCatDelete(out string logostr, int? shopid, int? catid)
        {
            var logostrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@logostr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Output, Size = 80 };
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var catidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = catid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!catid.HasValue)
                catidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_menuCat_Delete] @logostr OUTPUT, @shopid, @catid", logostrParam, shopidParam, catidParam, procResultParam);
            if (IsSqlParameterNull(logostrParam))
                logostr = default(string);
            else
                logostr = (string)logostrParam.Value;

            return (int)procResultParam.Value;
        }

        public int UpMenuCatUpdate(int? catid, int? shopid, string catName, string catName2, string description, string description2, string servicePeriod, string displayweekday, string pcsetting, System.DateTime? modifiedDt, decimal? indexnum, string logostr)
        {
            var catidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = catid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!catid.HasValue)
                catidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var catNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@catName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catName, Size = 100 };
            if (catNameParam.Value == null)
                catNameParam.Value = System.DBNull.Value;

            var catName2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@catName2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = catName2, Size = 100 };
            if (catName2Param.Value == null)
                catName2Param.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 500 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var description2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@description2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description2, Size = 500 };
            if (description2Param.Value == null)
                description2Param.Value = System.DBNull.Value;

            var servicePeriodParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@servicePeriod", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = servicePeriod, Size = 1 };
            if (servicePeriodParam.Value == null)
                servicePeriodParam.Value = System.DBNull.Value;

            var displayweekdayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@displayweekday", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = displayweekday, Size = 50 };
            if (displayweekdayParam.Value == null)
                displayweekdayParam.Value = System.DBNull.Value;

            var pcsettingParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pcsetting", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pcsetting, Size = 50 };
            if (pcsettingParam.Value == null)
                pcsettingParam.Value = System.DBNull.Value;

            var modifiedDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@modifiedDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = modifiedDt.GetValueOrDefault() };
            if (!modifiedDt.HasValue)
                modifiedDtParam.Value = System.DBNull.Value;

            var indexnumParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@indexnum", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = indexnum.GetValueOrDefault(), Precision = 8, Scale = 1 };
            if (!indexnum.HasValue)
                indexnumParam.Value = System.DBNull.Value;

            var logostrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@logostr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = logostr, Size = 80 };
            if (logostrParam.Value == null)
                logostrParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_menuCat_Update] @catid, @shopid, @catName, @catName2, @description, @description2, @servicePeriod, @displayweekday, @pcsetting, @modifiedDT, @indexnum, @logostr", catidParam, shopidParam, catNameParam, catName2Param, descriptionParam, description2Param, servicePeriodParam, displayweekdayParam, pcsettingParam, modifiedDtParam, indexnumParam, logostrParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpOnlineUserAdd(int? uid, string urealname, System.DateTime? loginTime, System.DateTime? lastUpdateTime, string utype)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var urealnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@urealname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = urealname, Size = 50 };
            if (urealnameParam.Value == null)
                urealnameParam.Value = System.DBNull.Value;

            var loginTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@loginTime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = loginTime.GetValueOrDefault() };
            if (!loginTime.HasValue)
                loginTimeParam.Value = System.DBNull.Value;

            var lastUpdateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@lastUpdateTime", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = lastUpdateTime.GetValueOrDefault() };
            if (!lastUpdateTime.HasValue)
                lastUpdateTimeParam.Value = System.DBNull.Value;

            var utypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@utype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = utype, Size = 1 };
            if (utypeParam.Value == null)
                utypeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_onlineUser_ADD] @uid, @urealname, @loginTime, @lastUpdateTime, @utype", uidParam, urealnameParam, loginTimeParam, lastUpdateTimeParam, utypeParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpOrderczAdd(System.DateTime? czdt, string orderid, string comments, decimal? amt, string operateid)
        {
            var czdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@czdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = czdt.GetValueOrDefault() };
            if (!czdt.HasValue)
                czdtParam.Value = System.DBNull.Value;

            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 50 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 200 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var amtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@amt", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = amt.GetValueOrDefault(), Precision = 18, Scale = 2 };
            if (!amt.HasValue)
                amtParam.Value = System.DBNull.Value;

            var operateidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operateid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = operateid, Size = 50 };
            if (operateidParam.Value == null)
                operateidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_ordercz_ADD] @czdt, @orderid, @comments, @amt, @operateid", czdtParam, orderidParam, commentsParam, amtParam, operateidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpRecommendAdd(int? recUid, string recName, string shopname, string townname, string deliveryArea, string addr, string tel)
        {
            var recUidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@recUid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = recUid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!recUid.HasValue)
                recUidParam.Value = System.DBNull.Value;

            var recNameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@recName", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = recName, Size = 50 };
            if (recNameParam.Value == null)
                recNameParam.Value = System.DBNull.Value;

            var shopnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = shopname, Size = 100 };
            if (shopnameParam.Value == null)
                shopnameParam.Value = System.DBNull.Value;

            var townnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@townname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = townname, Size = 50 };
            if (townnameParam.Value == null)
                townnameParam.Value = System.DBNull.Value;

            var deliveryAreaParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@DeliveryArea", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = deliveryArea, Size = 50 };
            if (deliveryAreaParam.Value == null)
                deliveryAreaParam.Value = System.DBNull.Value;

            var addrParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr, Size = 200 };
            if (addrParam.Value == null)
                addrParam.Value = System.DBNull.Value;

            var telParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel, Size = 100 };
            if (telParam.Value == null)
                telParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_recommend_ADD] @recUid, @recName, @shopname, @townname, @DeliveryArea, @addr, @tel", recUidParam, recNameParam, shopnameParam, townnameParam, deliveryAreaParam, addrParam, telParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpRecommendDelete(int? recId)
        {
            var recIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@recID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = recId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!recId.HasValue)
                recIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_recommend_Delete] @recID", recIdParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpRecommendGetModelReturnModel> UpRecommendGetModel(int? recId)
        {
            int procResult;
            return UpRecommendGetModel(recId, out procResult);
        }

        public System.Collections.Generic.List<UpRecommendGetModelReturnModel> UpRecommendGetModel(int? recId, out int procResult)
        {
            var recIdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@recID", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = recId.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!recId.HasValue)
                recIdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpRecommendGetModelReturnModel>("EXEC @procResult = [dbo].[UP_recommend_GetModel] @recID", recIdParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpServiceTicketAdd(string orderid, int? userid, int? shopid, string tele, string email, string isnormal, string ismanager, string iscritical, string comments, string status, string createuser)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var useridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@userid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = userid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!userid.HasValue)
                useridParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var teleParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tele", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tele, Size = 50 };
            if (teleParam.Value == null)
                teleParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var isnormalParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isnormal", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isnormal, Size = 1 };
            if (isnormalParam.Value == null)
                isnormalParam.Value = System.DBNull.Value;

            var ismanagerParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ismanager", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = ismanager, Size = 1 };
            if (ismanagerParam.Value == null)
                ismanagerParam.Value = System.DBNull.Value;

            var iscriticalParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@iscritical", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = iscritical, Size = 1 };
            if (iscriticalParam.Value == null)
                iscriticalParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 1000 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var statusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@status", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = status, Size = 1 };
            if (statusParam.Value == null)
                statusParam.Value = System.DBNull.Value;

            var createuserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@createuser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = createuser, Size = 50 };
            if (createuserParam.Value == null)
                createuserParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_serviceTicket_ADD] @orderid, @userid, @shopid, @tele, @email, @isnormal, @ismanager, @iscritical, @comments, @status, @createuser", orderidParam, useridParam, shopidParam, teleParam, emailParam, isnormalParam, ismanagerParam, iscriticalParam, commentsParam, statusParam, createuserParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpServiceTicketUpdate(int? ticketid, string orderid, int? userid, int? shopid, string tele, string email, string isnormal, string ismanager, string iscritical, string comments, string status, string modifyuser)
        {
            var ticketidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ticketid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = ticketid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!ticketid.HasValue)
                ticketidParam.Value = System.DBNull.Value;

            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var useridParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@userid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = userid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!userid.HasValue)
                useridParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var teleParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tele", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tele, Size = 50 };
            if (teleParam.Value == null)
                teleParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var isnormalParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isnormal", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isnormal, Size = 1 };
            if (isnormalParam.Value == null)
                isnormalParam.Value = System.DBNull.Value;

            var ismanagerParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ismanager", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = ismanager, Size = 1 };
            if (ismanagerParam.Value == null)
                ismanagerParam.Value = System.DBNull.Value;

            var iscriticalParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@iscritical", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = iscritical, Size = 1 };
            if (iscriticalParam.Value == null)
                iscriticalParam.Value = System.DBNull.Value;

            var commentsParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@comments", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = comments, Size = 1000 };
            if (commentsParam.Value == null)
                commentsParam.Value = System.DBNull.Value;

            var statusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@status", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = status, Size = 1 };
            if (statusParam.Value == null)
                statusParam.Value = System.DBNull.Value;

            var modifyuserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@modifyuser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = modifyuser, Size = 50 };
            if (modifyuserParam.Value == null)
                modifyuserParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_serviceTicket_Update] @ticketid, @orderid, @userid, @shopid, @tele, @email, @isnormal, @ismanager, @iscritical, @comments, @status, @modifyuser", ticketidParam, orderidParam, useridParam, shopidParam, teleParam, emailParam, isnormalParam, ismanagerParam, iscriticalParam, commentsParam, statusParam, modifyuserParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpShopAdd(int? shopid, string sname, string sname2, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string cityname, string postcode1, string postcode2, string description, string acceptpay, string acceptorder, string bankname, string bankusername, string banksortcode, string bankno, decimal? webcommision, System.DateTime? expireddt, string alias)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var snameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname, Size = 100 };
            if (snameParam.Value == null)
                snameParam.Value = System.DBNull.Value;

            var sname2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@sname2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sname2, Size = 100 };
            if (sname2Param.Value == null)
                sname2Param.Value = System.DBNull.Value;

            var tel1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel1, Size = 50 };
            if (tel1Param.Value == null)
                tel1Param.Value = System.DBNull.Value;

            var tel2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@tel2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tel2, Size = 50 };
            if (tel2Param.Value == null)
                tel2Param.Value = System.DBNull.Value;

            var faxParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fax", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = fax, Size = 50 };
            if (faxParam.Value == null)
                faxParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var contactnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactname, Size = 50 };
            if (contactnameParam.Value == null)
                contactnameParam.Value = System.DBNull.Value;

            var contactTelParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@contactTel", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = contactTel, Size = 50 };
            if (contactTelParam.Value == null)
                contactTelParam.Value = System.DBNull.Value;

            var addr1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@addr1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = addr1, Size = 100 };
            if (addr1Param.Value == null)
                addr1Param.Value = System.DBNull.Value;

            var citynameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@cityname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = cityname, Size = 100 };
            if (citynameParam.Value == null)
                citynameParam.Value = System.DBNull.Value;

            var postcode1Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode1", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode1, Size = 50 };
            if (postcode1Param.Value == null)
                postcode1Param.Value = System.DBNull.Value;

            var postcode2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@postcode2", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = postcode2, Size = 50 };
            if (postcode2Param.Value == null)
                postcode2Param.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 3000 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var acceptpayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptpay", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptpay, Size = 10 };
            if (acceptpayParam.Value == null)
                acceptpayParam.Value = System.DBNull.Value;

            var acceptorderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@acceptorder", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = acceptorder, Size = 20 };
            if (acceptorderParam.Value == null)
                acceptorderParam.Value = System.DBNull.Value;

            var banknameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankname, Size = 50 };
            if (banknameParam.Value == null)
                banknameParam.Value = System.DBNull.Value;

            var bankusernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankusername", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankusername, Size = 50 };
            if (bankusernameParam.Value == null)
                bankusernameParam.Value = System.DBNull.Value;

            var banksortcodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@banksortcode", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = banksortcode, Size = 50 };
            if (banksortcodeParam.Value == null)
                banksortcodeParam.Value = System.DBNull.Value;

            var banknoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@bankno", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = bankno, Size = 50 };
            if (banknoParam.Value == null)
                banknoParam.Value = System.DBNull.Value;

            var webcommisionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@webcommision", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = webcommision.GetValueOrDefault(), Precision = 5, Scale = 2 };
            if (!webcommision.HasValue)
                webcommisionParam.Value = System.DBNull.Value;

            var expireddtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@expireddt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = expireddt.GetValueOrDefault() };
            if (!expireddt.HasValue)
                expireddtParam.Value = System.DBNull.Value;

            var aliasParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@alias", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = alias, Size = 100 };
            if (aliasParam.Value == null)
                aliasParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_shop_ADD] @shopid, @sname, @sname2, @tel1, @tel2, @fax, @email, @contactname, @contactTel, @addr1, @cityname, @postcode1, @postcode2, @description, @acceptpay, @acceptorder, @bankname, @bankusername, @banksortcode, @bankno, @webcommision, @expireddt, @alias", shopidParam, snameParam, sname2Param, tel1Param, tel2Param, faxParam, emailParam, contactnameParam, contactTelParam, addr1Param, citynameParam, postcode1Param, postcode2Param, descriptionParam, acceptpayParam, acceptorderParam, banknameParam, bankusernameParam, banksortcodeParam, banknoParam, webcommisionParam, expireddtParam, aliasParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpShopBgpicture(int? shopid, string logo)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var logoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@logo", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = logo, Size = 100 };
            if (logoParam.Value == null)
                logoParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_shop_bgpicture] @shopid, @logo", shopidParam, logoParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpShopChanglogo(int? shopid, string logo)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var logoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@logo", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = logo, Size = 100 };
            if (logoParam.Value == null)
                logoParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_shop_changlogo] @shopid, @logo", shopidParam, logoParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpShopGetModelReturnModel> UpShopGetModel(int? shopid)
        {
            int procResult;
            return UpShopGetModel(shopid, out procResult);
        }

        public System.Collections.Generic.List<UpShopGetModelReturnModel> UpShopGetModel(int? shopid, out int procResult)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpShopGetModelReturnModel>("EXEC @procResult = [dbo].[UP_shop_GetModel] @shopid", shopidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpShopdeliveryCostAdd(int? shopid, string costtype, int? basicDistance, decimal? basicPrice, int? unitDistance, decimal? unitRate, string isDiscount, int? basicDistance2, decimal? minOrderAmount, decimal? freeAmount)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var costtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@costtype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = costtype, Size = 1 };
            if (costtypeParam.Value == null)
                costtypeParam.Value = System.DBNull.Value;

            var basicDistanceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicDistance", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = basicDistance.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!basicDistance.HasValue)
                basicDistanceParam.Value = System.DBNull.Value;

            var basicPriceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicPrice", SqlDbType = System.Data.SqlDbType.Decimal, Direction = System.Data.ParameterDirection.Input, Value = basicPrice.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!basicPrice.HasValue)
                basicPriceParam.Value = System.DBNull.Value;

            var unitDistanceParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@unitDistance", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = unitDistance.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!unitDistance.HasValue)
                unitDistanceParam.Value = System.DBNull.Value;

            var unitRateParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@unitRate", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = unitRate.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!unitRate.HasValue)
                unitRateParam.Value = System.DBNull.Value;

            var isDiscountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isDiscount", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isDiscount, Size = 1 };
            if (isDiscountParam.Value == null)
                isDiscountParam.Value = System.DBNull.Value;

            var basicDistance2Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@basicDistance2", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = basicDistance2.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!basicDistance2.HasValue)
                basicDistance2Param.Value = System.DBNull.Value;

            var minOrderAmountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@minOrderAmount", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = minOrderAmount.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!minOrderAmount.HasValue)
                minOrderAmountParam.Value = System.DBNull.Value;

            var freeAmountParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@freeAmount", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = freeAmount.GetValueOrDefault(), Precision = 10, Scale = 2 };
            if (!freeAmount.HasValue)
                freeAmountParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_shopdeliveryCost_ADD] @shopid, @costtype, @basicDistance, @basicPrice, @unitDistance, @unitRate, @isDiscount, @basicDistance2, @minOrderAmount, @freeAmount", shopidParam, costtypeParam, basicDistanceParam, basicPriceParam, unitDistanceParam, unitRateParam, isDiscountParam, basicDistance2Param, minOrderAmountParam, freeAmountParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpShopdeliveryCostAdd2(int? shopid, string costtype)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var costtypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@costtype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = costtype, Size = 1 };
            if (costtypeParam.Value == null)
                costtypeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_shopdeliveryCost_ADD2] @shopid, @costtype", shopidParam, costtypeParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpShoppingHolidayAdd(int? shopid, System.DateTime? fromDt, System.DateTime? toDt)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var fromDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@fromDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = fromDt.GetValueOrDefault() };
            if (!fromDt.HasValue)
                fromDtParam.Value = System.DBNull.Value;

            var toDtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@toDT", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = toDt.GetValueOrDefault() };
            if (!toDt.HasValue)
                toDtParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_shoppingHoliday_ADD] @shopid, @fromDT, @toDT", shopidParam, fromDtParam, toDtParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpShoppingHolidayDelete(int? holidayid, int? shopid)
        {
            var holidayidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@holidayid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = holidayid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!holidayid.HasValue)
                holidayidParam.Value = System.DBNull.Value;

            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_shoppingHoliday_Delete] @holidayid, @shopid", holidayidParam, shopidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpShoppingHolidayGetListReturnModel> UpShoppingHolidayGetList(int? shopid)
        {
            int procResult;
            return UpShoppingHolidayGetList(shopid, out procResult);
        }

        public System.Collections.Generic.List<UpShoppingHolidayGetListReturnModel> UpShoppingHolidayGetList(int? shopid, out int procResult)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpShoppingHolidayGetListReturnModel>("EXEC @procResult = [dbo].[UP_shoppingHoliday_GetList] @shopid", shopidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpShopworktimeAdd(int? shopid, string monFrToA, string monFrToB, string tuesFrToA, string tuesFrToB, string wedFrToA, string wedFrToB, string thurFrToA, string thurFrToB, string friFrToA, string friFrToB, string satFrToA, string satFrToB, string sunFrToA, string sunFrToB, string wt001, string haslunch)
        {
            var shopidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@shopid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = shopid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!shopid.HasValue)
                shopidParam.Value = System.DBNull.Value;

            var monFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@monFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = monFrToA, Size = 80 };
            if (monFrToAParam.Value == null)
                monFrToAParam.Value = System.DBNull.Value;

            var monFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@monFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = monFrToB, Size = 80 };
            if (monFrToBParam.Value == null)
                monFrToBParam.Value = System.DBNull.Value;

            var tuesFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tuesFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tuesFrToA, Size = 80 };
            if (tuesFrToAParam.Value == null)
                tuesFrToAParam.Value = System.DBNull.Value;

            var tuesFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@tuesFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = tuesFrToB, Size = 80 };
            if (tuesFrToBParam.Value == null)
                tuesFrToBParam.Value = System.DBNull.Value;

            var wedFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@wedFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = wedFrToA, Size = 80 };
            if (wedFrToAParam.Value == null)
                wedFrToAParam.Value = System.DBNull.Value;

            var wedFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@wedFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = wedFrToB, Size = 80 };
            if (wedFrToBParam.Value == null)
                wedFrToBParam.Value = System.DBNull.Value;

            var thurFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@thurFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = thurFrToA, Size = 80 };
            if (thurFrToAParam.Value == null)
                thurFrToAParam.Value = System.DBNull.Value;

            var thurFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@thurFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = thurFrToB, Size = 80 };
            if (thurFrToBParam.Value == null)
                thurFrToBParam.Value = System.DBNull.Value;

            var friFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@friFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = friFrToA, Size = 80 };
            if (friFrToAParam.Value == null)
                friFrToAParam.Value = System.DBNull.Value;

            var friFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@friFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = friFrToB, Size = 80 };
            if (friFrToBParam.Value == null)
                friFrToBParam.Value = System.DBNull.Value;

            var satFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@satFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = satFrToA, Size = 80 };
            if (satFrToAParam.Value == null)
                satFrToAParam.Value = System.DBNull.Value;

            var satFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@satFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = satFrToB, Size = 80 };
            if (satFrToBParam.Value == null)
                satFrToBParam.Value = System.DBNull.Value;

            var sunFrToAParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sunFrToA", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sunFrToA, Size = 80 };
            if (sunFrToAParam.Value == null)
                sunFrToAParam.Value = System.DBNull.Value;

            var sunFrToBParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sunFrToB", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = sunFrToB, Size = 80 };
            if (sunFrToBParam.Value == null)
                sunFrToBParam.Value = System.DBNull.Value;

            var wt001Param = new System.Data.SqlClient.SqlParameter { ParameterName = "@wt001", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = wt001, Size = 50 };
            if (wt001Param.Value == null)
                wt001Param.Value = System.DBNull.Value;

            var haslunchParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@haslunch", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = haslunch, Size = 1 };
            if (haslunchParam.Value == null)
                haslunchParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_shopworktime_ADD] @shopid, @monFrToA, @monFrToB, @tuesFrToA, @tuesFrToB, @wedFrToA, @wedFrToB, @thurFrToA, @thurFrToB, @friFrToA, @friFrToB, @satFrToA, @satFrToB, @sunFrToA, @sunFrToB, @wt001, @haslunch", shopidParam, monFrToAParam, monFrToBParam, tuesFrToAParam, tuesFrToBParam, wedFrToAParam, wedFrToBParam, thurFrToAParam, thurFrToBParam, friFrToAParam, friFrToBParam, satFrToAParam, satFrToBParam, sunFrToAParam, sunFrToBParam, wt001Param, haslunchParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpSysMsgAdd(string msgtitle, string msgcontent, System.DateTime? msgdt, int? msgto)
        {
            var msgtitleParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgtitle", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = msgtitle, Size = 100 };
            if (msgtitleParam.Value == null)
                msgtitleParam.Value = System.DBNull.Value;

            var msgcontentParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgcontent", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = msgcontent, Size = 500 };
            if (msgcontentParam.Value == null)
                msgcontentParam.Value = System.DBNull.Value;

            var msgdtParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgdt", SqlDbType = System.Data.SqlDbType.DateTime, Direction = System.Data.ParameterDirection.Input, Value = msgdt.GetValueOrDefault() };
            if (!msgdt.HasValue)
                msgdtParam.Value = System.DBNull.Value;

            var msgtoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgto", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = msgto.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!msgto.HasValue)
                msgtoParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_sysMsg_ADD] @msgtitle, @msgcontent, @msgdt, @msgto", msgtitleParam, msgcontentParam, msgdtParam, msgtoParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpSysMsgDelete(int? msgid, int? msgto)
        {
            var msgidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = msgid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!msgid.HasValue)
                msgidParam.Value = System.DBNull.Value;

            var msgtoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgto", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = msgto.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!msgto.HasValue)
                msgtoParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_sysMsg_Delete] @msgid, @msgto", msgidParam, msgtoParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpSysMsgGetModelReturnModel> UpSysMsgGetModel(int? msgid)
        {
            int procResult;
            return UpSysMsgGetModel(msgid, out procResult);
        }

        public System.Collections.Generic.List<UpSysMsgGetModelReturnModel> UpSysMsgGetModel(int? msgid, out int procResult)
        {
            var msgidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = msgid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!msgid.HasValue)
                msgidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpSysMsgGetModelReturnModel>("EXEC @procResult = [dbo].[UP_sysMsg_GetModel] @msgid", msgidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpSysMsgUpdate(int? msgid, int? msgto)
        {
            var msgidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = msgid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!msgid.HasValue)
                msgidParam.Value = System.DBNull.Value;

            var msgtoParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@msgto", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = msgto.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!msgto.HasValue)
                msgtoParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_sysMsg_Update] @msgid, @msgto", msgidParam, msgtoParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUsercreditsAdd(int? uid, string operateuser, int? score, string operation, string scoretype, string description)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var operateuserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operateuser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = operateuser, Size = 50 };
            if (operateuserParam.Value == null)
                operateuserParam.Value = System.DBNull.Value;

            var scoreParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@score", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = score.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!score.HasValue)
                scoreParam.Value = System.DBNull.Value;

            var operationParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operation", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = operation, Size = 1 };
            if (operationParam.Value == null)
                operationParam.Value = System.DBNull.Value;

            var scoretypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@scoretype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = scoretype, Size = 1 };
            if (scoretypeParam.Value == null)
                scoretypeParam.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 200 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_usercredits_ADD] @uid, @operateuser, @score, @operation, @scoretype, @description", uidParam, operateuserParam, scoreParam, operationParam, scoretypeParam, descriptionParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserRegAdd(out int? uid, string utype, string gender, string realname, string email, string pwd, string pwdquestion, string pwdanswer, string birthday, string isnoticed)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output, Precision = 10, Scale = 0 };
            var utypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@utype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = utype, Size = 1 };
            if (utypeParam.Value == null)
                utypeParam.Value = System.DBNull.Value;

            var genderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@gender", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = gender, Size = 1 };
            if (genderParam.Value == null)
                genderParam.Value = System.DBNull.Value;

            var realnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@realname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = realname, Size = 100 };
            if (realnameParam.Value == null)
                realnameParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var pwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwd, Size = 50 };
            if (pwdParam.Value == null)
                pwdParam.Value = System.DBNull.Value;

            var pwdquestionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwdquestion", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwdquestion, Size = 200 };
            if (pwdquestionParam.Value == null)
                pwdquestionParam.Value = System.DBNull.Value;

            var pwdanswerParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwdanswer", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwdanswer, Size = 200 };
            if (pwdanswerParam.Value == null)
                pwdanswerParam.Value = System.DBNull.Value;

            var birthdayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@birthday", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = birthday, Size = 25 };
            if (birthdayParam.Value == null)
                birthdayParam.Value = System.DBNull.Value;

            var isnoticedParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isnoticed", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isnoticed, Size = 1 };
            if (isnoticedParam.Value == null)
                isnoticedParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_UserReg_ADD] @uid OUTPUT, @utype, @gender, @realname, @email, @pwd, @pwdquestion, @pwdanswer, @birthday, @isnoticed", uidParam, utypeParam, genderParam, realnameParam, emailParam, pwdParam, pwdquestionParam, pwdanswerParam, birthdayParam, isnoticedParam, procResultParam);
            if (IsSqlParameterNull(uidParam))
                uid = null;
            else
                uid = (int)uidParam.Value;

            return (int)procResultParam.Value;
        }

        public int UpUserregBlockUser(int? uid, string block)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var blockParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@block", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = block, Size = 1 };
            if (blockParam.Value == null)
                blockParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_userreg_BlockUser] @uid, @block", uidParam, blockParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserregChangeemail(int? uid, string newemail)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var newemailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@newemail", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = newemail, Size = 300 };
            if (newemailParam.Value == null)
                newemailParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_userreg_changeemail] @uid, @newemail", uidParam, newemailParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserregChangepwd(int? uid, string pwd)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var pwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwd, Size = 50 };
            if (pwdParam.Value == null)
                pwdParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_userreg_changepwd] @uid, @pwd", uidParam, pwdParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserRegDelete(int? uid)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_UserReg_Delete] @uid", uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpUserregGetInfoByUidReturnModel> UpUserregGetInfoByUid(int? uid)
        {
            int procResult;
            return UpUserregGetInfoByUid(uid, out procResult);
        }

        public System.Collections.Generic.List<UpUserregGetInfoByUidReturnModel> UpUserregGetInfoByUid(int? uid, out int procResult)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpUserregGetInfoByUidReturnModel>("EXEC @procResult = [dbo].[up_userreg_GetInfoByUid] @uid", uidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public System.Collections.Generic.List<UpUserregGetpwdByMailReturnModel> UpUserregGetpwdByMail(string email)
        {
            int procResult;
            return UpUserregGetpwdByMail(email, out procResult);
        }

        public System.Collections.Generic.List<UpUserregGetpwdByMailReturnModel> UpUserregGetpwdByMail(string email, out int procResult)
        {
            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpUserregGetpwdByMailReturnModel>("EXEC @procResult = [dbo].[up_userreg_GetpwdByMail] @email", emailParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public UpUserregGetPwdQuestionReturnModel UpUserregGetPwdQuestion(int? uid, string mail)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var mailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mail", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mail, Size = 100 };
            if (mailParam.Value == null)
                mailParam.Value = System.DBNull.Value;


            var procResultData = new UpUserregGetPwdQuestionReturnModel();
            var cmd = Database.Connection.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[up_userreg_GetPwdQuestion]";
            cmd.Parameters.Add(uidParam);
            cmd.Parameters.Add(mailParam);

            try
            {
                Database.Connection.Open();
                var reader = cmd.ExecuteReader();
                var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)this).ObjectContext;

                procResultData.ResultSet1 = objectContext.Translate<UpUserregGetPwdQuestionReturnModel.ResultSetModel1>(reader).ToList();
                reader.NextResult();

                procResultData.ResultSet2 = objectContext.Translate<UpUserregGetPwdQuestionReturnModel.ResultSetModel2>(reader).ToList();
            }
            finally
            {
                Database.Connection.Close();
            }
            return procResultData;
        }

        public int UpUserregLockuserByid(int? uid, string islocked)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var islockedParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@islocked", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = islocked, Size = 1 };
            if (islockedParam.Value == null)
                islockedParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_userreg_LockuserByid] @uid, @islocked", uidParam, islockedParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserRegUpdate(int? uid, string gender, string realname, string email, string pwd, string pwdquestion, string pwdanswer, string birthday, string isnoticed)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var genderParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@gender", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = gender, Size = 1 };
            if (genderParam.Value == null)
                genderParam.Value = System.DBNull.Value;

            var realnameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@realname", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = realname, Size = 100 };
            if (realnameParam.Value == null)
                realnameParam.Value = System.DBNull.Value;

            var emailParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@email", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = email, Size = 100 };
            if (emailParam.Value == null)
                emailParam.Value = System.DBNull.Value;

            var pwdParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwd", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwd, Size = 50 };
            if (pwdParam.Value == null)
                pwdParam.Value = System.DBNull.Value;

            var pwdquestionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwdquestion", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwdquestion, Size = 200 };
            if (pwdquestionParam.Value == null)
                pwdquestionParam.Value = System.DBNull.Value;

            var pwdanswerParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@pwdanswer", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = pwdanswer, Size = 200 };
            if (pwdanswerParam.Value == null)
                pwdanswerParam.Value = System.DBNull.Value;

            var birthdayParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@birthday", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = birthday, Size = 25 };
            if (birthdayParam.Value == null)
                birthdayParam.Value = System.DBNull.Value;

            var isnoticedParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isnoticed", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = isnoticed, Size = 1 };
            if (isnoticedParam.Value == null)
                isnoticedParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_UserReg_Update] @uid, @gender, @realname, @email, @pwd, @pwdquestion, @pwdanswer, @birthday, @isnoticed", uidParam, genderParam, realnameParam, emailParam, pwdParam, pwdquestionParam, pwdanswerParam, birthdayParam, isnoticedParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserregUpdatelogintimeIp(string ip, int? uid)
        {
            var ipParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@ip", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = ip, Size = 50 };
            if (ipParam.Value == null)
                ipParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[up_userreg_updatelogintimeIp] @ip, @uid", ipParam, uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserscoreAdd(int? uid, string operateuser, int? score, string operation, string scoretype, string description)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var operateuserParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operateuser", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = operateuser, Size = 50 };
            if (operateuserParam.Value == null)
                operateuserParam.Value = System.DBNull.Value;

            var scoreParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@score", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = score.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!score.HasValue)
                scoreParam.Value = System.DBNull.Value;

            var operationParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@operation", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = operation, Size = 1 };
            if (operationParam.Value == null)
                operationParam.Value = System.DBNull.Value;

            var scoretypeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@scoretype", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = scoretype, Size = 1 };
            if (scoretypeParam.Value == null)
                scoretypeParam.Value = System.DBNull.Value;

            var descriptionParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@description", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = description, Size = 200 };
            if (descriptionParam.Value == null)
                descriptionParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_userscore_ADD] @uid, @operateuser, @score, @operation, @scoretype, @description", uidParam, operateuserParam, scoreParam, operationParam, scoretypeParam, descriptionParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpUserscoreDelete(int? sid, int? isadmin, int? uid)
        {
            var sidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = sid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!sid.HasValue)
                sidParam.Value = System.DBNull.Value;

            var isadminParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@isadmin", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = isadmin.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!isadmin.HasValue)
                isadminParam.Value = System.DBNull.Value;

            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UP_userscore_Delete] @sid, @isadmin, @uid", sidParam, isadminParam, uidParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public System.Collections.Generic.List<UpUserscoreGetListReturnModel> UpUserscoreGetList(int? uid)
        {
            int procResult;
            return UpUserscoreGetList(uid, out procResult);
        }

        public System.Collections.Generic.List<UpUserscoreGetListReturnModel> UpUserscoreGetList(int? uid, out int procResult)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpUserscoreGetListReturnModel>("EXEC @procResult = [dbo].[UP_userscore_GetList] @uid", uidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public System.Collections.Generic.List<UpUserscoreGetModelReturnModel> UpUserscoreGetModel(int? sid)
        {
            int procResult;
            return UpUserscoreGetModel(sid, out procResult);
        }

        public System.Collections.Generic.List<UpUserscoreGetModelReturnModel> UpUserscoreGetModel(int? sid, out int procResult)
        {
            var sidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@sid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = sid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!sid.HasValue)
                sidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<UpUserscoreGetModelReturnModel>("EXEC @procResult = [dbo].[UP_userscore_GetModel] @sid", sidParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }

        public int UpdateBasicAddr(int? uid, string username, string mobile)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var usernameParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@username", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = username, Size = 100 };
            if (usernameParam.Value == null)
                usernameParam.Value = System.DBNull.Value;

            var mobileParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@mobile", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = mobile, Size = 50 };
            if (mobileParam.Value == null)
                mobileParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[updateBasicAddr] @uid, @username, @mobile", uidParam, usernameParam, mobileParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpdateOrderStatus(string orderid, string opt)
        {
            var orderidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@orderid", SqlDbType = System.Data.SqlDbType.NVarChar, Direction = System.Data.ParameterDirection.Input, Value = orderid, Size = 30 };
            if (orderidParam.Value == null)
                orderidParam.Value = System.DBNull.Value;

            var optParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@opt", SqlDbType = System.Data.SqlDbType.Char, Direction = System.Data.ParameterDirection.Input, Value = opt, Size = 1 };
            if (optParam.Value == null)
                optParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UpdateOrderStatus] @orderid, @opt", orderidParam, optParam, procResultParam);

            return (int)procResultParam.Value;
        }

        public int UpdateReferenceMember(int? uid)
        {
            var uidParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@uid", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Input, Value = uid.GetValueOrDefault(), Precision = 10, Scale = 0 };
            if (!uid.HasValue)
                uidParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            Database.ExecuteSqlCommand("EXEC @procResult = [dbo].[UpdateReferenceMember] @uid", uidParam, procResultParam);

            return (int)procResultParam.Value;
        }
    }

#endregion
}
