
using System.Data.Entity;
using BigFoodie.Model;
using BigFoodie.Model.StoredProceedureReturnClasses;

namespace BigFoodie.DataAccess.EntityFramework
{
    public interface IBFDbContext : System.IDisposable
    {
        DbSet<AdminAcc> AdminAccs { get; set; } // adminAcc
        System.Data.Entity.DbSet<Adv> Advs { get; set; } // adv
        System.Data.Entity.DbSet<Advsearch> Advsearches { get; set; } // advsearch
        System.Data.Entity.DbSet<AppUserInfo> AppUserInfoes { get; set; } // AppUserInfo
        System.Data.Entity.DbSet<AppUserSetting> AppUserSettings { get; set; } // AppUserSetting
        System.Data.Entity.DbSet<AppUserToDevice> AppUserToDevices { get; set; } // AppUserToDevice
        System.Data.Entity.DbSet<Blocklist> Blocklists { get; set; } // blocklist
        System.Data.Entity.DbSet<Cashreturn> Cashreturns { get; set; } // cashreturn
        System.Data.Entity.DbSet<Commission> Commissions { get; set; } // commission
        System.Data.Entity.DbSet<CreditCard> CreditCards { get; set; } // creditCard
        System.Data.Entity.DbSet<CustomerReview> CustomerReviews { get; set; } // customerReview
        System.Data.Entity.DbSet<DeliveryAddr> DeliveryAddrs { get; set; } // deliveryAddr
        System.Data.Entity.DbSet<Deviceinfo> Deviceinfoes { get; set; } // deviceinfo
        System.Data.Entity.DbSet<Favourite> Favourites { get; set; } // favourites
        System.Data.Entity.DbSet<Invitefriend> Invitefriends { get; set; } // invitefriend
        System.Data.Entity.DbSet<MemberCash> MemberCashes { get; set; } // memberCash
        System.Data.Entity.DbSet<Menu> Menus { get; set; } // menu
        System.Data.Entity.DbSet<Menubasic> Menubasics { get; set; } // menubasic
        System.Data.Entity.DbSet<MenuBasicTemplate> MenuBasicTemplates { get; set; } // MenuBasicTemplate
        System.Data.Entity.DbSet<MenuCat> MenuCats { get; set; } // menuCat
        System.Data.Entity.DbSet<MenuCatBasicMenu> MenuCatBasicMenus { get; set; } // menuCatBasicMenu
        System.Data.Entity.DbSet<Menucattemplate> Menucattemplates { get; set; } // menucattemplate
        System.Data.Entity.DbSet<Menuoptionalcat> Menuoptionalcats { get; set; } // menuoptionalcat
        System.Data.Entity.DbSet<MenuPrice> MenuPrices { get; set; } // menuPrice
        System.Data.Entity.DbSet<Menusideorder> Menusideorders { get; set; } // menusideorder
        System.Data.Entity.DbSet<MultilangMenu> MultilangMenus { get; set; } // multilangMenu
        System.Data.Entity.DbSet<Newshopregi> Newshopregis { get; set; } // newshopregis
        System.Data.Entity.DbSet<OnlineUser> OnlineUsers { get; set; } // onlineUser
        System.Data.Entity.DbSet<Order> Orders { get; set; } // orders
        System.Data.Entity.DbSet<Ordercomment> Ordercomments { get; set; } // ordercomments
        System.Data.Entity.DbSet<Ordercz> Orderczs { get; set; } // ordercz
        System.Data.Entity.DbSet<Orderdelivery> Orderdeliveries { get; set; } // orderdelivery
        System.Data.Entity.DbSet<Orderitem> Orderitems { get; set; } // orderitem
        System.Data.Entity.DbSet<Ordernotice> Ordernotices { get; set; } // ordernotice
        System.Data.Entity.DbSet<Orderoperation> Orderoperations { get; set; } // orderoperation
        System.Data.Entity.DbSet<Orderpayment> Orderpayments { get; set; } // orderpayment
        System.Data.Entity.DbSet<PushNoticeQueue> PushNoticeQueues { get; set; } // pushNoticeQueue
        System.Data.Entity.DbSet<Recommend> Recommends { get; set; } // recommend
        System.Data.Entity.DbSet<RecPaidAmountInfo> RecPaidAmountInfoes { get; set; } // RecPaidAmountInfo
        System.Data.Entity.DbSet<ServiceTicket> ServiceTickets { get; set; } // serviceTicket
        System.Data.Entity.DbSet<Shop> Shops { get; set; } // shop
        System.Data.Entity.DbSet<ShopDelieveryArea> ShopDelieveryAreas { get; set; } // shopDelieveryArea
        System.Data.Entity.DbSet<ShopdeliveryCost> ShopdeliveryCosts { get; set; } // shopdeliveryCost
        System.Data.Entity.DbSet<Shopdiscount> Shopdiscounts { get; set; } // shopdiscount
        System.Data.Entity.DbSet<ShopExtInfoForApp> ShopExtInfoForApps { get; set; } // ShopExtInfoForApp
        System.Data.Entity.DbSet<ShopJz> ShopJzs { get; set; } // shopJZ
        System.Data.Entity.DbSet<ShopJzDetail> ShopJzDetails { get; set; } // shopJZDetail
        System.Data.Entity.DbSet<ShoppingCart> ShoppingCarts { get; set; } // ShoppingCart
        System.Data.Entity.DbSet<ShoppingHoliday> ShoppingHolidays { get; set; } // shoppingHoliday
        System.Data.Entity.DbSet<ShopTicket> ShopTickets { get; set; } // shopTickets
        System.Data.Entity.DbSet<Shoptransactiondetail> Shoptransactiondetails { get; set; } // shoptransactiondetail
        System.Data.Entity.DbSet<Shopviewtelrecord> Shopviewtelrecords { get; set; } // shopviewtelrecord
        System.Data.Entity.DbSet<Shopworktime> Shopworktimes { get; set; } // shopworktime
        System.Data.Entity.DbSet<Submenu> Submenus { get; set; } // submenu
        System.Data.Entity.DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        System.Data.Entity.DbSet<SysLog> SysLogs { get; set; } // sysLog
        System.Data.Entity.DbSet<SysMsg> SysMsgs { get; set; } // sysMsg
        System.Data.Entity.DbSet<UserCreditInfo> UserCreditInfoes { get; set; } // UserCreditInfo
        System.Data.Entity.DbSet<UserReg> UserRegs { get; set; } // UserReg
        System.Data.Entity.DbSet<Userscore> Userscores { get; set; } // userscore
        System.Data.Entity.DbSet<Voucherinfo> Voucherinfoes { get; set; } // voucherinfo
        System.Data.Entity.DbSet<VwAppUserProfile> VwAppUserProfiles { get; set; } // vwAppUserProfile
        System.Data.Entity.DbSet<VwCustomerreview> VwCustomerreviews { get; set; } // vw_customerreview
        System.Data.Entity.DbSet<VwGetAppDeviceInfo> VwGetAppDeviceInfoes { get; set; } // vwGetAppDeviceInfo
        System.Data.Entity.DbSet<VwGetAppRestInfo> VwGetAppRestInfoes { get; set; } // vwGetAppRestInfo
        System.Data.Entity.DbSet<VwGetOrderInfo> VwGetOrderInfoes { get; set; } // vwGetOrderInfo
        System.Data.Entity.DbSet<VwGetOrderInfoForAdmin> VwGetOrderInfoForAdmins { get; set; } // vwGetOrderInfoForAdmin
        System.Data.Entity.DbSet<VwGetOrderListForApp> VwGetOrderListForApps { get; set; } // vwGetOrderListForApp
        System.Data.Entity.DbSet<VwGetShopInfo> VwGetShopInfoes { get; set; } // vwGetShopInfo
        System.Data.Entity.DbSet<VwGetShopInfo2> VwGetShopInfo2 { get; set; } // vwGetShopInfo2
        System.Data.Entity.DbSet<VwGetShopJzDetail> VwGetShopJzDetails { get; set; } // vwGetShopJZDetail
        System.Data.Entity.DbSet<VwGetUserBalanceSummary> VwGetUserBalanceSummaries { get; set; } // vwGetUserBalanceSummary
        System.Data.Entity.DbSet<VwGetUserFavShopInfo> VwGetUserFavShopInfoes { get; set; } // vwGetUserFavShopInfo
        System.Data.Entity.DbSet<VwGetUserInfo> VwGetUserInfoes { get; set; } // vwGetUserInfo
        System.Data.Entity.DbSet<VwOrdersValid> VwOrdersValids { get; set; } // vwOrdersValid
        System.Data.Entity.DbSet<VwShopOrder> VwShopOrders { get; set; } // vwShopOrders
        System.Data.Entity.DbSet<VwShopsValid> VwShopsValids { get; set; } // vwShopsValid
        System.Data.Entity.DbSet<VwSysMsg> VwSysMsgs { get; set; } // vwSysMsg
        System.Data.Entity.DbSet<VwUser2Device> VwUser2Device { get; set; } // vwUser2Device
        System.Data.Entity.DbSet<VwUserBalanceSummary> VwUserBalanceSummaries { get; set; } // vwUserBalanceSummary
        System.Data.Entity.DbSet<VwValidOrder> VwValidOrders { get; set; } // vwValidOrders
        System.Data.Entity.DbSet<VwValidShop> VwValidShops { get; set; } // vwValidShops
        System.Data.Entity.DbSet<Vwviewtel> Vwviewtels { get; set; } // vwviewtel

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);

        // Stored Procedures
        int AddToBlockList(string orderid, string reason, string operateid);
        int CancelOrders(string orderid, string isCancelled, System.DateTime? orderCancelledDt, string cancelComments);
        int DeleAppDevice(int? deviceid);
        int Deleapprestanduser(int? shopid);
        int Deletejz(int? jzid);
        int GetAdvByCondition(string pc, string tn);
        int GetOrdersByCondition(string sqlwhere);
        int GetOrdersByUid(int? uid, int? shopid, string dtsql);
        int GetOrdersByUser(string email, int? shopid, string dtsql);
        System.Collections.Generic.List<GetShopByPostCodeReturnModel> GetShopByPostCode(string postcode);
        System.Collections.Generic.List<GetShopByPostCodeReturnModel> GetShopByPostCode(string postcode, out int procResult);
        int GetShopByTownName(string sn, string tn);
        int ImportCatFromTempl(int? shopid, string cats);
        int ImportPlFromTempl(int? shopid, string pls, string plcat);
        int IsInBlockList(string orderid, out string ret);
        int JzDetail(System.DateTime? frdt, System.DateTime? todt, int? shopid, decimal? stdcommrate, int? jzid, out string ret);
        int JzDetailtmp(System.DateTime? frdt, System.DateTime? todt, int? shopid, int? jzid, out string ret);
        int PfSysPageControl(string tableName, string tableFields, string sqlWhere, string orderFields, int? pageSize, int? pageIndex, out int? totalPage);
        int PfSysPageControl2000(string tablename, string tableFields, int? pageIndex, int? pageSize, string sqlWhere, string orderFields, bool? intOrder, out int? totalPage);
        int SpAdminAccAdd(string loginname, string loginpwd, System.DateTime? createtime, string rightcode, string isvalid, string isadmin);
        int SpAdminAccUpdate(string loginname, string loginpwd, string rightcode, string isvalid, string isadmin);
        int SpAdvpicAdd(int? advid, string pc, string townname, int? shopid, string shoploginname, System.DateTime? starttime, System.DateTime? endtime, string urllink, string advPic, int? indexno, int? clicknum);
        int SpAdvsearchAdd(string postcode, int? indexno, string shopid, System.DateTime? startdt, System.DateTime? enddt, System.DateTime? createdt, string createuser);
        int SpAppUserAdd(int? shopid, string password, string usertype, string username, string status, System.DateTime? createdt, string createuser, string loginstatus, out int? appuserid);
        int SpAppuserExit(string apptokenstr);
        int SpAppUserLogin(string loginname, string loginip, string apptokenstr, string devicetoken);
        int SpAppUserSettingAdd(string operatecode, int? appuserid);
        int SpDeleteOrder(string orderid);
        int SpGetMenuInfoOfSets(int? shopid, int? mid, int? catid);
        SpGetMenuInfosReturnModel SpGetMenuInfos(int? shopid, int? catid);
        SpGetPlInfoReturnModel SpGetPlInfo(string menutype1, string menutype2, int? shopid);
        int SpMenuAdd(int? shopid, string menuCat, string menuName, string menuName2, string menuDesc, string menuDesc2, decimal? price1, decimal? price2, string menutype, string menulogo, string discountway, string menucode, string servicePeriod, string displayweekday, string hasSideOrder, string hasPl, System.DateTime? createDt, string flag, decimal? indexnum, int? mealamt);
        int SpMenuUpdate(int? mid, int? shopid, string menuCat, string menuName, string menuName2, string menuDesc, string menuDesc2, decimal? price1, decimal? price2, string menutype, string menulogo, string menucode, string servicePeriod, string displayweekday, string hasSideOrder, string hasPl, System.DateTime? updateDt, string flag, decimal? indexnum, int? mealamt);
        int SpMenuBasicAdd(int? shopid, string menutype1, string menutype2, string mname, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001, decimal? indexnum);
        int SpMenuBasicDelete(int? basicmenuid, int? shopid);
        int SpMenuBasicUpdate(int? basicmenuid, int? shopid, string mname, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001, decimal? indexnum);
        int SpMenuBasicTemplateAdd(string menutype1, string menutype2, string mname, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001);
        int SpMenuBasicTemplateUpdate(int? basicmenuid, string mname2, decimal? price1, decimal? price2, string menudesc2, string menudesc, string menucode, string flag, string menu001);
        int SpMenuCatBasicMenuUpdate(int? catid, int? shopid, string menutype1, string menutype2, string basicmenuids);
        int SpMenucattemplateAdd(decimal? indexnum, string catname, string catname2, string cat001);
        int SpMenucattemplateUpdate(int? catid, decimal? indexnum, string catname, string catname2, string cat001);
        int SpMenuOptionCatAdd(int? shopid, string optionname, string optionname2, string flag, decimal? indexnum, string optiondesc);
        int SpMenuOptionCatDelete(int? optioncatid, int? shopid);
        int SpMenuOptionCatUpdate(decimal? optioncatid, int? shopid, string optionname, string optionname2, string flag, decimal? indexnum, string optiondesc);
        int SpMultilangmenuAdd(string menuname, string name1, string name2, string name3, string name4, string name5, string name6, string name7);
        int SpOrderdeliveryAdd(string orderid, string addr1, string addr2, string addr3, string townname, string postcode1, string postcode2, string contactname, string tel1, string tel2, System.DateTime? deliverdt, string deliverpeople, string comments);
        int SpOrderitemAdd(string orderid, int? mid, int? submenuid, string menucode, string menuName, string menuNameE, string menuName2, string menuName2E, int? amount, decimal? price1, decimal? discountprice, decimal? totalprice, string menulogo, string menutype);
        int SpOrderpaymentAdd(string orderid, string cardnumber, string cardtype, string name1, string name2, System.DateTime? paidtime, System.DateTime? applytime, decimal? paidamount, string isret);
        int SpOrdersAdd(out string orderId, int? shopid, int? uid, string useremail, string payway, string ispaid, string ticketnumber, int? ticketvalue, string deliveryway, string comments, string orderstatus, System.DateTime? ordercreatedt, string isCancelled, decimal? totalprice1, decimal? discountRate, decimal? afterdiscount, decimal? deliverycharge, decimal? serviceCharge, decimal? creditcardCharge, decimal? tips, string isjz, decimal? totalamount, string userIp, System.DateTime? pickupdt, decimal? commrate, string isnew, decimal? shopcardcharge, decimal? paidwithcredit, string vouchercode);
        int SpRefreshByDeviceTokenId(string devicetoken);
        int SpRefreshDeviceDt(string apptokenstr);
        int SpShopAdd(int? shopid, string sname, string sname2, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string cityname, string postcode1, string postcode2, string description, string acceptpay, string acceptorder, string bankname, string bankusername, string banksortcode, string bankno, decimal? webcommision, System.DateTime? expireddt);
        int SpShopAddDeliveryInfo(int? shopid, string serviceType, string serviceTypeL, string deliveryWay, string deliverytime, string deliveryLastOt, decimal? deliveryMinOrder);
        int SpShopChangeboard(string board, int? shopid);
        int SpShopUpdate(int? shopid, string sname, string sname2, string mealtype, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string addr2, string cityname, string postcode1, string postcode2, string logo, string description, System.DateTime? updateTime, string alias, string acceptpay, string orderlang, string acceptorder, string bankname, string bankusername, string banksortcode, string bankno, decimal? webcommision, System.DateTime? expireddt, string acceptCustomerOpt);
        int SpShopUpdate2(int? shopid, string sname, string sname2, string mealtype, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string addr2, string cityname, string postcode1, string postcode2, string description, System.DateTime? updateTime, string alias, string acceptpay, string orderlang, string acceptorder);
        int SpShopUpdate3(int? shopid, string description, System.DateTime? updateTime, string alias, string orderlang);
        int SpShopDelieveryAreaAdd(int? shopid, string postcode1, decimal? delieveryCost, string comments, System.DateTime? createDt, string flag1, string bak001);
        int SpShopDelieveryAreaUpdate(int? did, int? shopid, decimal? delieveryCost, string comments, string flag1, string bak001);
        int SpShopdiscountUpdate(int? shopid, string board, string discountway, decimal? minorderamt, int? discountrate);
        int SpShopJz(System.DateTime? frdt, System.DateTime? todt, decimal? stdcommrate, string shoploginname, string createUser, out string ret);
        int SpShoppingCartAdd(int? customerId, string customerSessionId, System.DateTime? createdOn, System.DateTime? updateOn, int? shopid, int? productId, int? mainfoodid, string menuOptionIDs, string subProductId, int? quantity);
        int SpShoppingCartUpdate(int? cartid, int? customerId, string customerSessionId, System.DateTime? updateOn, int? quantity, int? productId, string subProductId, string opt);
        int SpShopunjz(System.DateTime? frdt, System.DateTime? todt, decimal? stdcommrate, string shoploginname, string createUser, out string ret);
        int SpSysLogAdd(string userid, string actstr, System.DateTime? actdt, string priority);
        int SpUserCreditInfoAdd(int? shopid, int? userid, string moneydirection, decimal? amt, string comment, string orderid, System.DateTime? createdt);
        int SpUserregChangeCredits(int? sid, int? uid, string act);
        int SpUserregChangeScore(int? sid, int? uid, string act);
        System.Collections.Generic.List<SpUserRegExistReturnModel> SpUserRegExist(string email);
        System.Collections.Generic.List<SpUserRegExistReturnModel> SpUserRegExist(string email, out int procResult);
        int SpUserregUpdateutype(string upwd, string utype, int? uid);
        int SpViewtelAdd(int? shopid, System.DateTime? actdt);
        int UpCreateShopUser(string utype, string pwd, out int? uid, out string email);
        int UpCreditCardAdd(int? uid, string acct, string acctType, string street, string city, string state, string country, string zip, int? cardIssue, string cardStart, string expDate, string firstName, string lastName, string cvv2);
        int UpCreditCardDelete(int? cardid, int? uid);
        System.Collections.Generic.List<UpCreditCardGetListReturnModel> UpCreditCardGetList(int? uid);
        System.Collections.Generic.List<UpCreditCardGetListReturnModel> UpCreditCardGetList(int? uid, out int procResult);
        int UpCreditCardUpdate(int? cardid, int? uid, string acct, string acctType, string street, string city, string state, string country, string zip, int? cardIssue, string cardStart, string expDate, string firstName, string lastName, string cvv2);
        int UpCustomerReviewAdd(int? uid, string email, decimal? rate1, decimal? rate2, decimal? rate3, decimal? rate4, System.DateTime? reviewDate, string reviewtype, int? objid, string orderid, string comment, string replyMsg);
        int UpCustomerReviewDelete(int? reviewid, int? shopid);
        int UpCustomerReviewForMealAdd(int? uid, string email, decimal? rate1, System.DateTime? reviewDate, string reviewtype, int? objid, string orderid);
        int UpDeliveryAddrAdd(out int? addrid, int? uid, string username, string addrname, string addr1, string addr2, string addr3, string cityname, string postcode1, string postcode2, string tel, string comments, string flag, string mobile);
        int UpDeliveryAddrDelete(int? addrid, int? uid);
        System.Collections.Generic.List<UpDeliveryAddrGetListReturnModel> UpDeliveryAddrGetList(int? uid);
        System.Collections.Generic.List<UpDeliveryAddrGetListReturnModel> UpDeliveryAddrGetList(int? uid, out int procResult);
        System.Collections.Generic.List<UpDeliveryAddrGetModelByIdReturnModel> UpDeliveryAddrGetModelById(int? addrid);
        System.Collections.Generic.List<UpDeliveryAddrGetModelByIdReturnModel> UpDeliveryAddrGetModelById(int? addrid, out int procResult);
        int UpDeliveryAddrUpdate(int? addrid, int? uid, string username, string addrname, string addr1, string addr2, string addr3, string cityname, string postcode1, string postcode2, string tel, string comments, string flag, string mobile);
        int UpDeliveryCostAdd(int? shopid, string costtype, int? basicDistance, decimal? basicPrice, decimal? freeAmount, decimal? unitRate);
        int UpFavouritesAdd(out int? fid, int? uid, string ftype, int? shopid, int? mid, System.DateTime? createDt, string flag);
        int UpFavouritesDelete(int? fid, int? uid);
        System.Collections.Generic.List<UpFavouritesGetModelReturnModel> UpFavouritesGetModel(int? fid);
        System.Collections.Generic.List<UpFavouritesGetModelReturnModel> UpFavouritesGetModel(int? fid, out int procResult);
        UpGetUserEmailReturnModel UpGetUserEmail(string utype);
        int UpMenuCatAdd(int? shopid, string catName, string catName2, string description, string description2, string servicePeriod, string displayweekday, string pcsetting, System.DateTime? createDt, decimal? indexnum, string logostr);
        int UpMenuCatDelete(out string logostr, int? shopid, int? catid);
        int UpMenuCatUpdate(int? catid, int? shopid, string catName, string catName2, string description, string description2, string servicePeriod, string displayweekday, string pcsetting, System.DateTime? modifiedDt, decimal? indexnum, string logostr);
        int UpOnlineUserAdd(int? uid, string urealname, System.DateTime? loginTime, System.DateTime? lastUpdateTime, string utype);
        int UpOrderczAdd(System.DateTime? czdt, string orderid, string comments, decimal? amt, string operateid);
        int UpRecommendAdd(int? recUid, string recName, string shopname, string townname, string deliveryArea, string addr, string tel);
        int UpRecommendDelete(int? recId);
        System.Collections.Generic.List<UpRecommendGetModelReturnModel> UpRecommendGetModel(int? recId);
        System.Collections.Generic.List<UpRecommendGetModelReturnModel> UpRecommendGetModel(int? recId, out int procResult);
        int UpServiceTicketAdd(string orderid, int? userid, int? shopid, string tele, string email, string isnormal, string ismanager, string iscritical, string comments, string status, string createuser);
        int UpServiceTicketUpdate(int? ticketid, string orderid, int? userid, int? shopid, string tele, string email, string isnormal, string ismanager, string iscritical, string comments, string status, string modifyuser);
        int UpShopAdd(int? shopid, string sname, string sname2, string tel1, string tel2, string fax, string email, string contactname, string contactTel, string addr1, string cityname, string postcode1, string postcode2, string description, string acceptpay, string acceptorder, string bankname, string bankusername, string banksortcode, string bankno, decimal? webcommision, System.DateTime? expireddt, string alias);
        int UpShopBgpicture(int? shopid, string logo);
        int UpShopChanglogo(int? shopid, string logo);
        System.Collections.Generic.List<UpShopGetModelReturnModel> UpShopGetModel(int? shopid);
        System.Collections.Generic.List<UpShopGetModelReturnModel> UpShopGetModel(int? shopid, out int procResult);
        int UpShopdeliveryCostAdd(int? shopid, string costtype, int? basicDistance, decimal? basicPrice, int? unitDistance, decimal? unitRate, string isDiscount, int? basicDistance2, decimal? minOrderAmount, decimal? freeAmount);
        int UpShopdeliveryCostAdd2(int? shopid, string costtype);
        int UpShoppingHolidayAdd(int? shopid, System.DateTime? fromDt, System.DateTime? toDt);
        int UpShoppingHolidayDelete(int? holidayid, int? shopid);
        System.Collections.Generic.List<UpShoppingHolidayGetListReturnModel> UpShoppingHolidayGetList(int? shopid);
        System.Collections.Generic.List<UpShoppingHolidayGetListReturnModel> UpShoppingHolidayGetList(int? shopid, out int procResult);
        int UpShopworktimeAdd(int? shopid, string monFrToA, string monFrToB, string tuesFrToA, string tuesFrToB, string wedFrToA, string wedFrToB, string thurFrToA, string thurFrToB, string friFrToA, string friFrToB, string satFrToA, string satFrToB, string sunFrToA, string sunFrToB, string wt001, string haslunch);
        int UpSysMsgAdd(string msgtitle, string msgcontent, System.DateTime? msgdt, int? msgto);
        int UpSysMsgDelete(int? msgid, int? msgto);
        System.Collections.Generic.List<UpSysMsgGetModelReturnModel> UpSysMsgGetModel(int? msgid);
        System.Collections.Generic.List<UpSysMsgGetModelReturnModel> UpSysMsgGetModel(int? msgid, out int procResult);
        int UpSysMsgUpdate(int? msgid, int? msgto);
        int UpUsercreditsAdd(int? uid, string operateuser, int? score, string operation, string scoretype, string description);
        int UpUserRegAdd(out int? uid, string utype, string gender, string realname, string email, string pwd, string pwdquestion, string pwdanswer, string birthday, string isnoticed);
        int UpUserregBlockUser(int? uid, string block);
        int UpUserregChangeemail(int? uid, string newemail);
        int UpUserregChangepwd(int? uid, string pwd);
        int UpUserRegDelete(int? uid);
        System.Collections.Generic.List<UpUserregGetInfoByUidReturnModel> UpUserregGetInfoByUid(int? uid);
        System.Collections.Generic.List<UpUserregGetInfoByUidReturnModel> UpUserregGetInfoByUid(int? uid, out int procResult);
        System.Collections.Generic.List<UpUserregGetpwdByMailReturnModel> UpUserregGetpwdByMail(string email);
        System.Collections.Generic.List<UpUserregGetpwdByMailReturnModel> UpUserregGetpwdByMail(string email, out int procResult);
        UpUserregGetPwdQuestionReturnModel UpUserregGetPwdQuestion(int? uid, string mail);
        int UpUserregLockuserByid(int? uid, string islocked);
        int UpUserRegUpdate(int? uid, string gender, string realname, string email, string pwd, string pwdquestion, string pwdanswer, string birthday, string isnoticed);
        int UpUserregUpdatelogintimeIp(string ip, int? uid);
        int UpUserscoreAdd(int? uid, string operateuser, int? score, string operation, string scoretype, string description);
        int UpUserscoreDelete(int? sid, int? isadmin, int? uid);
        System.Collections.Generic.List<UpUserscoreGetListReturnModel> UpUserscoreGetList(int? uid);
        System.Collections.Generic.List<UpUserscoreGetListReturnModel> UpUserscoreGetList(int? uid, out int procResult);
        System.Collections.Generic.List<UpUserscoreGetModelReturnModel> UpUserscoreGetModel(int? sid);
        System.Collections.Generic.List<UpUserscoreGetModelReturnModel> UpUserscoreGetModel(int? sid, out int procResult);
        int UpdateBasicAddr(int? uid, string username, string mobile);
        int UpdateOrderStatus(string orderid, string opt);
        int UpdateReferenceMember(int? uid);
    }
}
