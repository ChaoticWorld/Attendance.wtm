using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using em_wtm.Model._Business.Attendance;

namespace em_wtm.Model._Business.Disable;

public partial class AppDataContext : DbContext
{
    public AppDataContext()
    {
    }

    public AppDataContext(DbContextOptions<AppDataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Attendance2DayType> Attendance2DayTypes { get; set; }

    public virtual DbSet<Attendance2EmployeeRefSchemeClass> Attendance2EmployeeRefSchemeClasses { get; set; }

    public virtual DbSet<Attendance2FeeCalculator> Attendance2FeeCalculators { get; set; }

    public virtual DbSet<Attendance2Holiday> Attendance2Holidays { get; set; }

    public virtual DbSet<Attendance2Log> Attendance2Logs { get; set; }

    public virtual DbSet<Attendance2PlanRefClass> Attendance2PlanRefClasses { get; set; }

    public virtual DbSet<Attendance2PlanTime> Attendance2PlanTimes { get; set; }

    public virtual DbSet<Attendance2SchemeClass> Attendance2SchemeClasses { get; set; }

    public virtual DbSet<AttendanceClassPlan> AttendanceClassPlans { get; set; }

    public virtual DbSet<AttendanceEmployeeRefSchemeClass> AttendanceEmployeeRefSchemeClasses { get; set; }

    public virtual DbSet<Attendance2EventDeclared> AttendanceEventDeclareds { get; set; }

    public virtual DbSet<AttendanceFeeCalculator> AttendanceFeeCalculators { get; set; }

    public virtual DbSet<AttendanceHoliday> AttendanceHolidays { get; set; }

    public virtual DbSet<AttendanceLog> AttendanceLogs { get; set; }

    public virtual DbSet<Attendance2Record> AttendanceRecords { get; set; }

    public virtual DbSet<AttendanceScheme> AttendanceSchemes { get; set; }

    public virtual DbSet<AttendanceSchemeClass> AttendanceSchemeClasses { get; set; }

    public virtual DbSet<HrwebPageExtendInfo> HrwebPageExtendInfos { get; set; }

    public virtual DbSet<InvClsStdConvertRate> InvClsStdConvertRates { get; set; }

    public virtual DbSet<LocationRecord> LocationRecords { get; set; }

    public virtual DbSet<LogisticsDetail> LogisticsDetails { get; set; }

    public virtual DbSet<LogisticsEnterprise> LogisticsEnterprises { get; set; }

    public virtual DbSet<LogisticsEnumReason> LogisticsEnumReasons { get; set; }

    public virtual DbSet<LogisticsMain> LogisticsMains { get; set; }

    public virtual DbSet<LogisticsMainExtend> LogisticsMainExtends { get; set; }

    public virtual DbSet<LogisticsMainImageAttach> LogisticsMainImageAttaches { get; set; }

    public virtual DbSet<LogisticsMainInfo> LogisticsMainInfos { get; set; }

    public virtual DbSet<LogisticsOperator> LogisticsOperators { get; set; }

    public virtual DbSet<LogisticsReceipt> LogisticsReceipts { get; set; }

    public virtual DbSet<Metum> Meta { get; set; }

    public virtual DbSet<ModifySaleCustomer> ModifySaleCustomers { get; set; }

    public virtual DbSet<ModifySaleDispatchCustomer> ModifySaleDispatchCustomers { get; set; }

    public virtual DbSet<ModifySaleOrderCustomer> ModifySaleOrderCustomers { get; set; }

    public virtual DbSet<Omcdr> Omcdrs { get; set; }

    public virtual DbSet<Omevent> Omevents { get; set; }

    public virtual DbSet<Omlog> Omlogs { get; set; }

    public virtual DbSet<PermRefRole> PermRefRoles { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Phone2Mac> Phone2Macs { get; set; }

    public virtual DbSet<Phone2User> Phone2Users { get; set; }

    public virtual DbSet<PhoneCommNumber> PhoneCommNumbers { get; set; }

    public virtual DbSet<PhoneContact> PhoneContacts { get; set; }

    public virtual DbSet<PhoneEnterprise> PhoneEnterprises { get; set; }

    public virtual DbSet<PhoneRecord> PhoneRecords { get; set; }

    public virtual DbSet<PoareaT> PoareaTs { get; set; }

    public virtual DbSet<PublicProvince> PublicProvinces { get; set; }

    public virtual DbSet<Pudispatch> Pudispatches { get; set; }

    public virtual DbSet<PuorderDetail> PuorderDetails { get; set; }

    public virtual DbSet<PuorderMain> PuorderMains { get; set; }

    public virtual DbSet<QcClass> QcClasses { get; set; }

    public virtual DbSet<QcCodeIdentity> QcCodeIdentities { get; set; }

    public virtual DbSet<QcDetail> QcDetails { get; set; }

    public virtual DbSet<QcDetailClass> QcDetailClasses { get; set; }

    public virtual DbSet<QcMain> QcMains { get; set; }

    public virtual DbSet<QcReply> QcReplys { get; set; }

    public virtual DbSet<QcTxtContent> QcTxtContents { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportClass> ReportClasses { get; set; }

    public virtual DbSet<ReportField> ReportFields { get; set; }

    public virtual DbSet<ReportFilter> ReportFilters { get; set; }

    public virtual DbSet<ReportModule> ReportModules { get; set; }

    public virtual DbSet<ReportOrder> ReportOrders { get; set; }

    public virtual DbSet<ReportPermission> ReportPermissions { get; set; }

    public virtual DbSet<ReportPivotView> ReportPivotViews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleRefUser> RoleRefUsers { get; set; }

    public virtual DbSet<SigeInfo> SigeInfos { get; set; }

    public virtual DbSet<SqlQuery> SqlQueries { get; set; }

    public virtual DbSet<StoreCurrent> StoreCurrents { get; set; }

    public virtual DbSet<StoreDetail> StoreDetails { get; set; }

    public virtual DbSet<StoreMain> StoreMains { get; set; }

    public virtual DbSet<StrategyDetail> StrategyDetails { get; set; }

    public virtual DbSet<StrategyLog> StrategyLogs { get; set; }

    public virtual DbSet<StrategyMain> StrategyMains { get; set; }

    public virtual DbSet<TaxBillDetail> TaxBillDetails { get; set; }

    public virtual DbSet<TaxBillMain> TaxBillMains { get; set; }

    public virtual DbSet<TaxEairesult> TaxEairesults { get; set; }

    public virtual DbSet<TaxRefErp> TaxRefErps { get; set; }

    public virtual DbSet<UserInfo> UserInfos { get; set; }

    public virtual DbSet<VAttendance> VAttendances { get; set; }

    public virtual DbSet<VAttendanceEvent> VAttendanceEvents { get; set; }

    public virtual DbSet<VLogisticsMx> VLogisticsMxes { get; set; }

    public virtual DbSet<VPetitionList> VPetitionLists { get; set; }

    public virtual DbSet<VPurchaseOrder> VPurchaseOrders { get; set; }

    public virtual DbSet<VReportPermission> VReportPermissions { get; set; }

    public virtual DbSet<VTaxEaiResult> VTaxEaiResults { get; set; }

    public virtual DbSet<VTaxInvoice> VTaxInvoices { get; set; }

    public virtual DbSet<VouchType> VouchTypes { get; set; }

    public virtual DbSet<VwStrategy> VwStrategies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DB;Initial Catalog=AppData;User ID=sa;Password=dfl_DB;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Attendance2DayType>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Attendan__8E02B0143FC63DF9");

            entity.ToTable("Attendance2_DayType", tb => tb.HasComment("日期类型"));

            entity.Property(e => e.ID)
                .ValueGeneratedNever()
                .HasComment("ID")
                .HasColumnName("DayTypeID");
            entity.Property(e => e.DayTypeCaption)
                .HasMaxLength(64)
                .HasComment("显示");
            entity.Property(e => e.DayTypeName)
                .HasMaxLength(64)
                .HasComment("名称");
        });

        modelBuilder.Entity<Attendance2EmployeeRefSchemeClass>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Attendan__3853EA80E0210866");

            entity.ToTable("Attendance2_EmployeeRefSchemeClass", tb => tb.HasComment("员工班次"));

            entity.Property(e => e.ID)
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.ClassId)
                .HasComment("方案班次ID")
                .HasColumnName("classID");
            entity.Property(e => e.EffDate)
                .HasComment("生效日期")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId)
                .HasComment("考勤机员工ID")
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(64);
            entity.Property(e => e.ExpDate)
                .HasComment("失效日期")
                .HasColumnType("datetime");
            entity.Property(e => e.PeriodNo)
                .HasComment("最后设定日期对应的记录周期号")
                .HasColumnName("periodNo");
            entity.Property(e => e.UserId)
                .HasComment("用户号")
                .HasColumnName("UserID");
        });
        modelBuilder.Entity<Attendance2FeeCalculator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance2_FeeCalculator", tb => tb.HasComment("费用计算"));

            entity.Property(e => e.DayTypeId)
                .HasMaxLength(64)
                .HasComment("日期类型ID")
                .HasColumnName("DayTypeID");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasComment("序号")
                .HasColumnName("id");
            entity.Property(e => e.RangeA)
                .HasComment("时长范围A,A > x >= B")
                .HasColumnName("rangeA");
            entity.Property(e => e.RangeB)
                .HasComment("时长范围B,A > x >= B")
                .HasColumnName("rangeB");
            entity.Property(e => e.RangePrice)
                .HasComment("金额")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("rangePrice");
        });

        modelBuilder.Entity<Attendance2Holiday>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance2_Holiday", tb => tb.HasComment("假日调休"));

            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.BTime)
                .HasComment("上班时间字符串-hh:mm:ss.nnn")
                .HasColumnName("bTime");
            entity.Property(e => e.ETime)
                .HasComment("下班时间字符串-hh:mm:ss.nnn")
                .HasColumnName("eTime");
            entity.Property(e => e.IYear)
                .HasComment("年份")
                .HasColumnName("iYear");
            entity.Property(e => e.SDate)
                .HasComment("日期字符串yyyy-MM-dd")
                .HasColumnType("datetime")
                .HasColumnName("sDate");
            entity.Property(e => e.SDescription)
                .HasComment("节假日描述")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(128)
                .HasComment("节假日名称")
                .HasColumnName("sName");
        });

        modelBuilder.Entity<Attendance2Log>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance2_Logs", tb => tb.HasComment("日志"));

            entity.Property(e => e.CException)
                .HasMaxLength(2048)
                .HasComment("异常")
                .HasColumnName("cException");
            entity.Property(e => e.CLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("级别")
                .HasColumnName("cLevel");
            entity.Property(e => e.CParams)
                .HasMaxLength(1024)
                .HasComment("参数")
                .HasColumnName("cParams");
            entity.Property(e => e.CReturn)
                .HasMaxLength(2048)
                .HasComment("返回值")
                .HasColumnName("cReturn");
            entity.Property(e => e.CSource)
                .HasComment("来源")
                .HasColumnName("cSource");
            entity.Property(e => e.CUserName)
                .HasMaxLength(128)
                .HasComment("用户名")
                .HasColumnName("cUserName");
            entity.Property(e => e.CWorkStation)
                .HasMaxLength(128)
                .HasComment("用户工作站")
                .HasColumnName("cWorkStation");
            entity.Property(e => e.DLogDate)
                .HasComment("日志日期")
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.ILogId)
                .ValueGeneratedOnAdd()
                .HasComment("日志ID")
                .HasColumnName("iLogId");
            entity.Property(e => e.IUserId)
                .HasComment("用户Id")
                .HasColumnName("iUserID");
        });

        modelBuilder.Entity<Attendance2PlanRefClass>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__planRefC__3853EA80F17E1B25");

            entity.ToTable("Attendance2_PlanRefClass", tb => tb.HasComment("排班标准时间与班次关联表"));

            entity.Property(e => e.ID).HasColumnName("autoid");
            entity.Property(e => e.ClassId)
                .HasComment("班次ID")
                .HasColumnName("classid");
            entity.Property(e => e.PeriodNo)
                .HasComment("周期序号")
                .HasColumnName("periodNo");
            entity.Property(e => e.PlanId)
                .HasComment("计划ID")
                .HasColumnName("planid");
        });

        modelBuilder.Entity<Attendance2PlanTime>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Attendan__A29531D0EDB443B6");

            entity.ToTable("Attendance2_PlanTime", tb => tb.HasComment("排班标准时间"));

            entity.Property(e => e.ID)
                .HasComment("计划id")
                .HasColumnName("planid");
            entity.Property(e => e.BTime)
                .HasComment("开始时间")
                .HasColumnName("bTime");
            entity.Property(e => e.DayTypeId)
                .HasComment("日期类型id")
                .HasColumnName("DayTypeID");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("描述")
                .HasColumnName("description");
            entity.Property(e => e.ETime)
                .HasComment("结束时间")
                .HasColumnName("eTime");
            entity.Property(e => e.PlanName)
                .HasMaxLength(16)
                .HasComment("计划名")
                .HasColumnName("planName");
        });

        modelBuilder.Entity<Attendance2SchemeClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance2_SchemeClass", tb => tb.HasComment("班次信息"));

            entity.Property(e => e.ClassDescription)
                .HasMaxLength(255)
                .HasComment("班次描述")
                .HasColumnName("classDescription");
            entity.Property(e => e.ID)
                .ValueGeneratedOnAdd()
                .HasComment("班次id")
                .HasColumnName("classId");
            entity.Property(e => e.ClassName)
                .HasMaxLength(255)
                .HasComment("班次名")
                .HasColumnName("className");
            entity.Property(e => e.ClassPeriods)
                .HasComment("班次内周期")
                .HasColumnName("classPeriods");
            entity.Property(e => e.Periods)
                .HasComment("总排班数")
                .HasColumnName("periods");
        });

        modelBuilder.Entity<AttendanceClassPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_ClassPlan");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoid");
            entity.Property(e => e.BTime)
                .HasMaxLength(14)
                .HasComment("上班时间字符串-hh:mm:ss.nnn")
                .HasColumnName("bTime");
            entity.Property(e => e.ClassId)
                .HasComment("班次号")
                .HasColumnName("classId");
            entity.Property(e => e.ETime)
                .HasMaxLength(14)
                .HasComment("下班时间字符串-hh:mm:ss.nnn")
                .HasColumnName("eTime");
            entity.Property(e => e.PeriodNo)
                .HasComment("周期序号，从０开始，小于０的为班次调班")
                .HasColumnName("periodNo");
            entity.Property(e => e.Sdate)
                .HasColumnType("datetime")
                .HasColumnName("sdate");
            entity.Property(e => e.UpTime)
                .HasMaxLength(14)
                .HasComment("计算加班起始量")
                .HasColumnName("upTime");
        });

        modelBuilder.Entity<AttendanceEmployeeRefSchemeClass>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__Attendan__3853EA80B83EB5B4");

            entity.ToTable("Attendance_EmployeeRefSchemeClass", tb => tb.HasComment("员工班次"));

            entity.Property(e => e.Autoid)
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.ClassId)
                .HasComment("方案班次ID")
                .HasColumnName("classID");
            entity.Property(e => e.EffDate)
                .HasComment("生效日期")
                .HasColumnType("datetime");
            entity.Property(e => e.EmployeeId)
                .HasComment("考勤机员工ID")
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(64);
            entity.Property(e => e.ExpDate)
                .HasComment("失效日期")
                .HasColumnType("datetime");
            entity.Property(e => e.IsVaild).HasColumnName("isVaild");
            entity.Property(e => e.PeriodNo)
                .HasComment("最后设定日期对应的记录周期号")
                .HasColumnName("periodNo");
            entity.Property(e => e.UserId)
                .HasComment("用户号")
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<Attendance2EventDeclared>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Attendan__385EFE686A173C2C");

            entity.ToTable("Attendance_EventDeclared");

            entity.Property(e => e.ID)
                .HasComment("事件序号")
                .HasColumnName("autoID");
            entity.Property(e => e.CheckMan)
                .HasMaxLength(128)
                .HasComment("审核人")
                .HasColumnName("checkMan");
            entity.Property(e => e.EventDescription).HasComment("事件描述");

            entity.Property(e => e.Fee)
                .HasComment("其它费用")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsBeginTime).HasColumnName("isBeginTime");
            entity.Property(e => e.Manager)
                .HasMaxLength(128)
                .HasComment("经理签字");
            entity.Property(e => e.Memo).HasComment("备注");
            entity.Property(e => e.RecordId).HasColumnName("recordID");
        });

        modelBuilder.Entity<AttendanceFeeCalculator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_FeeCalculator");

            entity.Property(e => e.ClassId)
                .HasComment("班次Id")
                .HasColumnName("classId");
            entity.Property(e => e.DateEnum)
                .HasMaxLength(64)
                .HasColumnName("dateEnum");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("序号")
                .HasColumnName("id");
            entity.Property(e => e.MaxFee)
                .HasComment("费用最大值")
                .HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Unit).HasComment("计费单位(分钟)");
            entity.Property(e => e.UnitFee)
                .HasComment("单位时间费用")
                .HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<AttendanceHoliday>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__Attendan__3853EA80B14E02B7");

            entity.ToTable("Attendance_Holiday");

            entity.Property(e => e.Autoid)
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.IYear)
                .HasComment("年份")
                .HasColumnName("iYear");
            entity.Property(e => e.SDate)
                .HasComment("日期字符串yyyy-MM-dd")
                .HasColumnType("datetime")
                .HasColumnName("sDate");
            entity.Property(e => e.SDescription)
                .HasComment("节假日描述")
                .HasColumnName("sDescription");
            entity.Property(e => e.SName)
                .HasMaxLength(128)
                .HasComment("节假日名称")
                .HasColumnName("sName");
        });

        modelBuilder.Entity<AttendanceLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_Logs");

            entity.Property(e => e.CBeforeValue)
                .HasComment("原值")
                .HasColumnName("cBeforeValue");
            entity.Property(e => e.CClass)
                .HasMaxLength(128)
                .HasComment("类名")
                .HasColumnName("cClass");
            entity.Property(e => e.CException)
                .HasMaxLength(2048)
                .HasComment("异常")
                .HasColumnName("cException");
            entity.Property(e => e.CFunction)
                .HasMaxLength(128)
                .HasComment("函数")
                .HasColumnName("cFunction");
            entity.Property(e => e.CIp)
                .HasMaxLength(24)
                .HasComment("用户IP")
                .HasColumnName("cIP");
            entity.Property(e => e.CLevel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("级别")
                .HasColumnName("cLevel");
            entity.Property(e => e.CModule)
                .HasMaxLength(128)
                .HasComment("模块")
                .HasColumnName("cModule");
            entity.Property(e => e.CParams)
                .HasMaxLength(1024)
                .HasComment("参数")
                .HasColumnName("cParams");
            entity.Property(e => e.CReturn)
                .HasMaxLength(2048)
                .HasComment("返回值")
                .HasColumnName("cReturn");
            entity.Property(e => e.CThread)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("线程")
                .HasColumnName("cThread");
            entity.Property(e => e.CUserName)
                .HasMaxLength(128)
                .HasComment("用户名")
                .HasColumnName("cUserName");
            entity.Property(e => e.CWorkStation)
                .HasMaxLength(128)
                .HasComment("用户工作站")
                .HasColumnName("cWorkStation");
            entity.Property(e => e.DLogDate)
                .HasComment("日志日期")
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.ILogId)
                .ValueGeneratedOnAdd()
                .HasComment("日志ID")
                .HasColumnName("iLogId");
            entity.Property(e => e.IUserId)
                .HasComment("用户Id")
                .HasColumnName("iUserID");
        });

        modelBuilder.Entity<Attendance2Record>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK__Attendan__3853EA802CB38284");

            entity.ToTable("Attendance_Records");

            entity.Property(e => e.ID)
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.BAttTimeStr)
                .HasMaxLength(16)
                .HasComment("b上班考勤时间字符串-hh:mm:ss.000")
                .HasColumnName("bAttTimeStr");
            entity.Property(e => e.BOffset)
                .HasComment("b上班考勤偏移量（单位分钟：正为加班，负为早退）")
                .HasColumnName("bOffset");
            entity.Property(e => e.BOffsetFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("bOffsetFee");
            entity.Property(e => e.BTime)
                .HasComment("开始时间")
                .HasColumnName("bTime");
            entity.Property(e => e.ClassId)
                .HasComment("方案班次ID")
                .HasColumnName("classID");
            entity.Property(e => e.ClassId)
                .HasComment("classID 2")
                .HasColumnName("classID");
            entity.Property(e => e.DayTypeId)
                .HasMaxLength(63)
                .HasComment("工作日期类型:null 工作日,DayOff 休息日,Holiday 节假日")
                .HasColumnName("dateType");
            entity.Property(e => e.DayTypeId)
                .HasComment("日期类型ID")
                .HasColumnName("dayTypeID");
            entity.Property(e => e.EAttTimeStr)
                .HasMaxLength(16)
                .HasComment("e下班考勤时间字符串-hh:mm:ss.000")
                .HasColumnName("eAttTimeStr");
            entity.Property(e => e.EOffset)
                .HasComment("e下班考勤偏移量（单位分钟：正为加班，负为早退）")
                .HasColumnName("eOffset");
            entity.Property(e => e.EOffsetFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("eOffsetFee");
            entity.Property(e => e.ETime)
                .HasComment("结束时间")
                .HasColumnName("eTime");
            entity.Property(e => e.EmployeeId)
                .HasComment("考勤机员工ID")
                .HasColumnName("EmployeeID");
            entity.Property(e => e.PeriodNo)
                .HasComment("周期内次序号")
                .HasColumnName("periodNo");
            entity.Property(e => e.PlanId)
                .HasComment("计划ID")
                .HasColumnName("planid");
            entity.Property(e => e.SDate)
                .HasComment("日期字符串:yyyy-MM-dd")
                .HasColumnType("datetime")
                .HasColumnName("sDate");
        });

        modelBuilder.Entity<AttendanceScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Attendance_Scheme");

            entity.Property(e => e.Classs)
                .HasComment("班次数")
                .HasColumnName("classs");
            entity.Property(e => e.Periods)
                .HasComment("周期数")
                .HasColumnName("periods");
            entity.Property(e => e.SchemeDescription)
                .HasMaxLength(512)
                .HasComment("描述")
                .HasColumnName("schemeDescription");
            entity.Property(e => e.SchemeId)
                .ValueGeneratedOnAdd()
                .HasComment("方案号")
                .HasColumnName("schemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(256)
                .HasComment("方案名")
                .HasColumnName("schemeName");
        });

        modelBuilder.Entity<AttendanceSchemeClass>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__Attendan__7577347EEC523B78");

            entity.ToTable("Attendance_SchemeClass");

            entity.Property(e => e.ClassId)
                .HasComment("班次id")
                .HasColumnName("classId");
            entity.Property(e => e.ClassDescription)
                .HasMaxLength(255)
                .HasComment("班次描述")
                .HasColumnName("classDescription");
            entity.Property(e => e.ClassName)
                .HasMaxLength(255)
                .HasComment("班次名")
                .HasColumnName("className");
            entity.Property(e => e.Periods)
                .HasComment("排班数")
                .HasColumnName("periods");
            entity.Property(e => e.SchemeId)
                .HasComment("方案号")
                .HasColumnName("schemeId");
        });

        modelBuilder.Entity<HrwebPageExtendInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HRWebPag__D7D4BCDF4F722633");

            entity.ToTable("HRWebPageExtendInfo", tb => tb.HasComment("网站扩展信息表"));

            entity.Property(e => e.Id)
                .HasComment("序号")
                .HasColumnName("ID");
            entity.Property(e => e.BirthYear)
                .HasComment("出生年")
                .HasColumnName("birthYear");
            entity.Property(e => e.Gender)
                .HasMaxLength(4)
                .HasComment("性别")
                .HasColumnName("gender");
            entity.Property(e => e.Infoid)
                .HasMaxLength(18)
                .HasComment("人员ID");
            entity.Property(e => e.Memo)
                .HasMaxLength(256)
                .HasComment("备注");
            entity.Property(e => e.Name)
                .HasMaxLength(24)
                .HasComment("姓名");
            entity.Property(e => e.Phone)
                .HasMaxLength(24)
                .HasComment("电话");
            entity.Property(e => e.Resumeid)
                .HasMaxLength(128)
                .HasComment("简历ID");
            entity.Property(e => e.WebPage)
                .HasComment("页面")
                .HasColumnName("webPage");
            entity.Property(e => e.WebUri)
                .HasMaxLength(1024)
                .HasComment("URL")
                .HasColumnName("webURI");
        });

        modelBuilder.Entity<InvClsStdConvertRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InvClsStdConvertRate");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoid");
            entity.Property(e => e.InvClsId).HasColumnName("invClsID");
            entity.Property(e => e.InvClsName)
                .HasMaxLength(255)
                .HasColumnName("invClsName");
            entity.Property(e => e.InvStd)
                .HasMaxLength(255)
                .HasColumnName("invStd");
            entity.Property(e => e.PriceRate)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("priceRate");
        });

        modelBuilder.Entity<LocationRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3213E83F61C1D041");

            entity.ToTable("LocationRecord", tb => tb.HasComment("位置记录"));

            entity.Property(e => e.Id)
                .HasComment("序号")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasComment("操作")
                .HasColumnName("action");
            entity.Property(e => e.COperator)
                .HasMaxLength(255)
                .HasComment("操作员")
                .HasColumnName("cOperator");
            entity.Property(e => e.Latitude)
                .HasComment("纬度")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasComment("经度")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("longitude");
            entity.Property(e => e.Module)
                .HasMaxLength(255)
                .HasComment("模块")
                .HasColumnName("module");
        });

        modelBuilder.Entity<LogisticsDetail>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK_LogisticsDetails_autoid");

            entity.ToTable(tb => tb.HasComment("物流子表"));

            entity.Property(e => e.Autoid)
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.DlQuantity)
                .HasComment("单据数量")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("dlQuantity");
            entity.Property(e => e.Dlid)
                .HasComment("erpDLID")
                .HasColumnName("dlid");
            entity.Property(e => e.Idlsid)
                .HasComment("erpDLidlsid")
                .HasColumnName("idlsid");
            entity.Property(e => e.InvCode)
                .HasMaxLength(32)
                .HasComment("存货编码")
                .HasColumnName("invCode");
            entity.Property(e => e.InvName)
                .HasMaxLength(64)
                .HasComment("存货名称")
                .HasColumnName("invName");
            entity.Property(e => e.InvStd)
                .HasMaxLength(64)
                .HasComment("存货型号")
                .HasColumnName("invStd");
            entity.Property(e => e.Lid)
                .HasComment("主表序号")
                .HasColumnName("lid");
            entity.Property(e => e.ReceivDifferenceReason)
                .HasMaxLength(1024)
                .HasComment("收货差异原因")
                .HasColumnName("receivDifferenceReason");
            entity.Property(e => e.ReceivQuantity)
                .HasComment("收货数量")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("receivQuantity");
            entity.Property(e => e.Sender)
                .HasMaxLength(24)
                .HasComment("送货人")
                .HasColumnName("sender");
            entity.Property(e => e.SenderId)
                .HasComment("送货人ID")
                .HasColumnName("senderID");
            entity.Property(e => e.ShipDifferenceReason)
                .HasMaxLength(1024)
                .HasComment("装车差异原因")
                .HasColumnName("shipDifferenceReason");
            entity.Property(e => e.ShipQuantity)
                .HasComment("装车数量")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("shipQuantity");
        });

        modelBuilder.Entity<LogisticsEnterprise>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Logistic__3214EC07CC26337E");

            entity.ToTable("LogisticsEnterprise", tb => tb.HasComment("物流企业"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("序号");
            entity.Property(e => e.AbbName)
                .HasMaxLength(255)
                .HasComment("简称")
                .HasColumnName("abbName");
            entity.Property(e => e.ContentName)
                .HasMaxLength(64)
                .HasComment("联系人")
                .HasColumnName("contentName");
            entity.Property(e => e.ContentPhone)
                .HasMaxLength(64)
                .HasComment("联系电话")
                .HasColumnName("contentPhone");
            entity.Property(e => e.DefaultTruckNumber)
                .HasMaxLength(10)
                .HasComment("默认车牌号")
                .HasColumnName("defaultTruckNumber");
            entity.Property(e => e.DefaultTruckPhone)
                .HasMaxLength(64)
                .HasComment("默认随车电话")
                .HasColumnName("defaultTruckPhone");
            entity.Property(e => e.Memo)
                .HasMaxLength(2048)
                .HasComment("备注")
                .HasColumnName("memo");
            entity.Property(e => e.Name)
                .HasMaxLength(512)
                .HasComment("名称")
                .HasColumnName("name");
            entity.Property(e => e.PreCode)
                .HasMaxLength(4)
                .HasComment("企业前缀")
                .HasColumnName("preCode");
        });

        modelBuilder.Entity<LogisticsEnumReason>(entity =>
        {
            entity.HasKey(e => e.ReasonId).HasName("PK_enumReason_reasonID");

            entity.ToTable("LogisticsEnumReason", tb => tb.HasComment("原因表"));

            entity.Property(e => e.ReasonId)
                .HasComment("原因序号")
                .HasColumnName("reasonID");
            entity.Property(e => e.Reason)
                .HasMaxLength(1024)
                .HasComment("原因")
                .HasColumnName("reason");
            entity.Property(e => e.ReasonType)
                .HasMaxLength(24)
                .HasComment("类型")
                .HasColumnName("reasonType");
        });

        modelBuilder.Entity<LogisticsMain>(entity =>
        {
            entity.HasKey(e => new { e.Lid, e.Dlid }).HasName("PK_LogisticsMain_LID");

            entity.ToTable("LogisticsMain", tb => tb.HasComment("物流主表"));

            entity.Property(e => e.Lid)
                .ValueGeneratedOnAdd()
                .HasComment("序号")
                .HasColumnName("lid");
            entity.Property(e => e.Dlid)
                .HasComment("erpDLID")
                .HasColumnName("dlid");
            entity.Property(e => e.BPayoff)
                .HasComment("收款完成")
                .HasColumnName("bPayoff");
            entity.Property(e => e.BSended)
                .HasComment("送货完成")
                .HasColumnName("bSended");
            entity.Property(e => e.DDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("物流日期")
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.DlCode)
                .HasMaxLength(32)
                .HasComment("发货单号")
                .HasColumnName("dlCode");
            entity.Property(e => e.LogisticsVouchCode)
                .HasMaxLength(64)
                .HasComment("物流单号")
                .HasColumnName("logisticsVouchCode");
            entity.Property(e => e.Payee)
                .HasMaxLength(64)
                .HasComment("收款人")
                .HasColumnName("payee");
            entity.Property(e => e.Sender)
                .HasMaxLength(64)
                .HasComment("送货人")
                .HasColumnName("sender");
            entity.Property(e => e.State)
                .HasMaxLength(8)
                .HasComment("执行状态:\r\n分配/装车/签收/退回/收款")
                .HasColumnName("state");
        });

        modelBuilder.Entity<LogisticsMainExtend>(entity =>
        {
            entity.HasKey(e => e.Lid).HasName("PK__Logistic__C65557219D477AD8");

            entity.ToTable("LogisticsMainExtend", tb => tb.HasComment("物流企业发货信息"));

            entity.Property(e => e.Lid)
                .ValueGeneratedNever()
                .HasComment("物流主表id")
                .HasColumnName("lid");
            entity.Property(e => e.LogisticsEnterpriseAbbName)
                .HasMaxLength(255)
                .HasComment("物流企业简称")
                .HasColumnName("logisticsEnterpriseAbbName");
            entity.Property(e => e.LogisticsEnterpriseId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("物流企业id")
                .HasColumnName("logisticsEnterpriseId");
            entity.Property(e => e.LogisticsEnterpriseTruckNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("物流车牌")
                .HasColumnName("logisticsEnterpriseTruckNumber");
            entity.Property(e => e.LogisticsEnterpriseTruckPhone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("物流随车电话")
                .HasColumnName("logisticsEnterpriseTruckPhone");
        });

        modelBuilder.Entity<LogisticsMainImageAttach>(entity =>
        {
            entity.HasKey(e => e.Lid).HasName("PK__Logistic__C65557219D477AD8_copy1");

            entity.ToTable("LogisticsMainImageAttach", tb => tb.HasComment("物流单据附加图片"));

            entity.Property(e => e.Lid)
                .ValueGeneratedNever()
                .HasComment("物流主表id")
                .HasColumnName("lid");
            entity.Property(e => e.AttachDescription)
                .HasMaxLength(512)
                .HasComment("附加说明")
                .HasColumnName("attachDescription");
            entity.Property(e => e.AttachImage)
                .HasComment("附加图片")
                .HasColumnType("image")
                .HasColumnName("attachImage");
        });

        modelBuilder.Entity<LogisticsMainInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LogisticsMainInfo", tb => tb.HasComment("主表信息"));

            entity.Property(e => e.ContactName)
                .HasMaxLength(64)
                .HasComment("联系人")
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(128)
                .HasComment("联系电话")
                .HasColumnName("contactPhone");
            entity.Property(e => e.DlCode)
                .HasMaxLength(24)
                .HasComment("DLCode")
                .HasColumnName("dlCode");
            entity.Property(e => e.DlDate)
                .HasComment("单据日期")
                .HasColumnType("datetime")
                .HasColumnName("dlDate");
            entity.Property(e => e.Dlid)
                .HasComment("erpDLID")
                .HasColumnName("dlid");
            entity.Property(e => e.DwAbbName)
                .HasMaxLength(128)
                .HasComment("客户简称")
                .HasColumnName("dwAbbName");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(64)
                .HasComment("客户经理")
                .HasColumnName("employeeName");
            entity.Property(e => e.Money)
                .HasComment("金额")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("money");
            entity.Property(e => e.ShipAddress)
                .HasMaxLength(1024)
                .HasComment("地址")
                .HasColumnName("shipAddress");
            entity.Property(e => e.VouchMemo)
                .HasMaxLength(1024)
                .HasComment("单据备注")
                .HasColumnName("vouchMemo");
        });

        modelBuilder.Entity<LogisticsOperator>(entity =>
        {
            entity.HasKey(e => e.OperatorName).HasName("PK_operatorName");

            entity.ToTable("LogisticsOperator", tb => tb.HasComment("操作人员表"));

            entity.Property(e => e.OperatorName)
                .HasMaxLength(128)
                .HasComment("操作员姓名")
                .HasColumnName("operatorName");
            entity.Property(e => e.IsPayee)
                .HasComment("是否收款人")
                .HasColumnName("isPayee");
            entity.Property(e => e.IsSender)
                .HasComment("是否送货人")
                .HasColumnName("isSender");
            entity.Property(e => e.IsWarehouseManager)
                .HasComment("是否库管")
                .HasColumnName("isWarehouseManager");
            entity.Property(e => e.OperatorId)
                .HasMaxLength(4)
                .HasComment("操作员编码")
                .HasColumnName("operatorID");
            entity.Property(e => e.OperatorPhone)
                .HasMaxLength(64)
                .HasComment("电话")
                .HasColumnName("operatorPhone");
            entity.Property(e => e.OrderIndex)
                .HasComment("显示排序")
                .HasColumnName("orderIndex");
        });

        modelBuilder.Entity<LogisticsReceipt>(entity =>
        {
            entity.HasKey(e => e.ArId).HasName("PK_LogisticsAR_ARID");

            entity.ToTable("LogisticsReceipt", tb => tb.HasComment("收款表"));

            entity.Property(e => e.ArId)
                .HasComment("应收序号")
                .HasColumnName("arID");
            entity.Property(e => e.CollectionMoney)
                .HasComment("收款金额")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("collectionMoney");
            entity.Property(e => e.DDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("日期")
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.DifferenceReason)
                .HasMaxLength(1024)
                .HasComment("差异原因")
                .HasColumnName("differenceReason");
            entity.Property(e => e.DlCode)
                .HasMaxLength(32)
                .HasComment("发货单号")
                .HasColumnName("dlCode");
            entity.Property(e => e.DlMoney)
                .HasComment("发货金额")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("dlMoney");
            entity.Property(e => e.Dlid)
                .HasComment("发货单dlid")
                .HasColumnName("dlid");
            entity.Property(e => e.PayMethod)
                .HasMaxLength(32)
                .HasComment("收款方式")
                .HasColumnName("payMethod");
            entity.Property(e => e.Payee)
                .HasMaxLength(24)
                .HasComment("收款人")
                .HasColumnName("payee");
            entity.Property(e => e.PayeeId)
                .HasComment("收款人ID")
                .HasColumnName("payeeID");
        });

        modelBuilder.Entity<Metum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_meta_Id");

            entity.ToTable("meta", tb => tb.HasComment("Meta"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.ActiveMenu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("activeMenu")
                .HasColumnName("activeMenu");
            entity.Property(e => e.CustomIcon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("自定义图标")
                .HasColumnName("customIcon");
            entity.Property(e => e.From)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("来自哪个表的Meta");
            entity.Property(e => e.Hide)
                .HasComment("hide")
                .HasColumnName("hide");
            entity.Property(e => e.Href)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("href")
                .HasColumnName("href");
            entity.Property(e => e.Icon)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("图标")
                .HasColumnName("icon");
            entity.Property(e => e.MulitTab)
                .HasComment("mulitTab")
                .HasColumnName("mulitTab");
            entity.Property(e => e.Order)
                .HasComment("order")
                .HasColumnName("order");
            entity.Property(e => e.RequiresAuth)
                .HasComment("需要认证")
                .HasColumnName("requiresAuth");
            entity.Property(e => e.SingleLayout)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("singleLayout")
                .HasColumnName("singleLayout");
            entity.Property(e => e.Title)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("title")
                .HasColumnName("title");
        });

        modelBuilder.Entity<ModifySaleCustomer>(entity =>
        {
            entity.HasKey(e => e.ILogId).HasName("iLogId");

            entity.ToTable("ModifySaleCustomer");

            entity.Property(e => e.ILogId).HasColumnName("iLogId");
            entity.Property(e => e.CBeforeValue).HasColumnName("cBeforeValue");
            entity.Property(e => e.CClass)
                .HasMaxLength(128)
                .HasColumnName("cClass");
            entity.Property(e => e.CException)
                .HasMaxLength(2048)
                .HasColumnName("cException");
            entity.Property(e => e.CFunction)
                .HasMaxLength(128)
                .HasColumnName("cFunction");
            entity.Property(e => e.CIp)
                .HasMaxLength(24)
                .HasColumnName("cIP");
            entity.Property(e => e.CModule)
                .HasMaxLength(128)
                .HasColumnName("cModule");
            entity.Property(e => e.CParams)
                .HasMaxLength(1024)
                .HasColumnName("cParams");
            entity.Property(e => e.CReturn)
                .HasMaxLength(2048)
                .HasColumnName("cReturn");
            entity.Property(e => e.CUserName)
                .HasMaxLength(128)
                .HasColumnName("cUserName");
            entity.Property(e => e.CWorkStation)
                .HasMaxLength(128)
                .HasColumnName("cWorkStation");
            entity.Property(e => e.DLogDate)
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.IUserId).HasColumnName("iUserID");
        });

        modelBuilder.Entity<ModifySaleDispatchCustomer>(entity =>
        {
            entity.HasKey(e => e.ILogId).HasName("PK__ModifySa__BBE56A583BE20282");

            entity.ToTable("ModifySaleDispatchCustomer");

            entity.Property(e => e.ILogId).HasColumnName("iLogId");
            entity.Property(e => e.CBeforeValue).HasColumnName("cBeforeValue");
            entity.Property(e => e.CClass)
                .HasMaxLength(128)
                .HasColumnName("cClass");
            entity.Property(e => e.CException)
                .HasMaxLength(2048)
                .HasColumnName("cException");
            entity.Property(e => e.CFunction)
                .HasMaxLength(128)
                .HasColumnName("cFunction");
            entity.Property(e => e.CIp)
                .HasMaxLength(24)
                .HasColumnName("cIP");
            entity.Property(e => e.CModule)
                .HasMaxLength(128)
                .HasColumnName("cModule");
            entity.Property(e => e.CParams)
                .HasMaxLength(1024)
                .HasColumnName("cParams");
            entity.Property(e => e.CReturn)
                .HasMaxLength(2048)
                .HasColumnName("cReturn");
            entity.Property(e => e.CUserName)
                .HasMaxLength(128)
                .HasColumnName("cUserName");
            entity.Property(e => e.CWorkStation)
                .HasMaxLength(128)
                .HasColumnName("cWorkStation");
            entity.Property(e => e.DLogDate)
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.IUserId).HasColumnName("iUserID");
        });

        modelBuilder.Entity<ModifySaleOrderCustomer>(entity =>
        {
            entity.HasKey(e => e.ILogId).HasName("PK__ModifySa__BBE56A587C0A3676");

            entity.ToTable("ModifySaleOrderCustomer");

            entity.Property(e => e.ILogId).HasColumnName("iLogId");
            entity.Property(e => e.CBeforeValue).HasColumnName("cBeforeValue");
            entity.Property(e => e.CClass)
                .HasMaxLength(128)
                .HasColumnName("cClass");
            entity.Property(e => e.CException)
                .HasMaxLength(2048)
                .HasColumnName("cException");
            entity.Property(e => e.CFunction)
                .HasMaxLength(128)
                .HasColumnName("cFunction");
            entity.Property(e => e.CIp)
                .HasMaxLength(24)
                .HasColumnName("cIP");
            entity.Property(e => e.CModule)
                .HasMaxLength(128)
                .HasColumnName("cModule");
            entity.Property(e => e.CParams)
                .HasMaxLength(1024)
                .HasColumnName("cParams");
            entity.Property(e => e.CReturn)
                .HasMaxLength(2048)
                .HasColumnName("cReturn");
            entity.Property(e => e.CUserName)
                .HasMaxLength(128)
                .HasColumnName("cUserName");
            entity.Property(e => e.CWorkStation)
                .HasMaxLength(128)
                .HasColumnName("cWorkStation");
            entity.Property(e => e.DLogDate)
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.IUserId).HasColumnName("iUserID");
        });

        modelBuilder.Entity<Omcdr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OMCDR__3213E83FB1247619");

            entity.ToTable("OMCDR");

            entity.Property(e => e.Id)
                .HasMaxLength(32)
                .HasColumnName("id");
            entity.Property(e => e.Caller).HasMaxLength(16);
            entity.Property(e => e.Cdpn)
                .HasMaxLength(64)
                .HasColumnName("CDPN");
            entity.Property(e => e.Cpn)
                .HasMaxLength(64)
                .HasColumnName("CPN");
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.Recording).HasMaxLength(128);
            entity.Property(e => e.Route).HasMaxLength(4);
            entity.Property(e => e.TimeEnd).HasMaxLength(64);
            entity.Property(e => e.TimeStart).HasMaxLength(64);
            entity.Property(e => e.TrunkNumber).HasMaxLength(64);
            entity.Property(e => e.Type).HasMaxLength(4);
        });

        modelBuilder.Entity<Omevent>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__OMEvent__3853EA8062FF632E");

            entity.ToTable("OMEvent");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.Attribute).HasMaxLength(64);
            entity.Property(e => e.Caller).HasMaxLength(16);
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.From).HasMaxLength(64);
            entity.Property(e => e.Reason).HasMaxLength(64);
            entity.Property(e => e.To).HasMaxLength(64);
            entity.Property(e => e.Trunk).HasMaxLength(64);
        });

        modelBuilder.Entity<Omlog>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__OMLogs__3853EA80691A8B70");

            entity.ToTable("OMLogs");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.BSend)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bSend");
            entity.Property(e => e.COmdevice)
                .HasMaxLength(128)
                .HasColumnName("cOMDevice");
            entity.Property(e => e.COmmessage).HasColumnName("cOMMessage");
            entity.Property(e => e.DLogDate)
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
        });

        modelBuilder.Entity<PermRefRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_permRefRole_Id");

            entity.ToTable("permRefRole", tb => tb.HasComment("权限关联角色"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.PermissionId)
                .HasComment("")
                .HasColumnName("permissionId");
            entity.Property(e => e.RoleId)
                .HasComment("")
                .HasColumnName("roleId");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_permission_Id");

            entity.ToTable("permission", tb => tb.HasComment("权限"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("组件")
                .HasColumnName("component");
            entity.Property(e => e.MetaId)
                .HasComment("metaId")
                .HasColumnName("metaId");
            entity.Property(e => e.ParentPermissionId)
                .HasComment("父权限Id")
                .HasColumnName("parentPermissionId");
            entity.Property(e => e.Path)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("路径")
                .HasColumnName("path");
            entity.Property(e => e.PermissionDescription)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("描述")
                .HasColumnName("permissionDescription");
            entity.Property(e => e.PermissionName)
                .HasMaxLength(36)
                .HasComment("权限名")
                .HasColumnName("permissionName");
        });

        modelBuilder.Entity<Phone2Mac>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__Phone2Ma__3853EA801C002689");

            entity.ToTable("Phone2Mac");

            entity.Property(e => e.Autoid)
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("描述");
            entity.Property(e => e.ExtId).HasComment("分机号");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(255)
                .HasComment("ip地址")
                .HasColumnName("IPAddress");
            entity.Property(e => e.IsLocal)
                .HasComment("是否本地")
                .HasColumnName("isLocal");
            entity.Property(e => e.IsRemoteExt)
                .HasDefaultValueSql("((0))")
                .HasComment("是否远程分机")
                .HasColumnName("isRemoteExt");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(12)
                .HasComment("mac地址");
        });

        modelBuilder.Entity<Phone2User>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Phone2User");

            entity.Property(e => e.ChId)
                .HasComment("通道ID")
                .HasColumnName("chId");
            entity.Property(e => e.PhoneNumber).HasComment("电话号码");
            entity.Property(e => e.UserId).HasComment("用户ID");
            entity.Property(e => e.UserIp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("IP地址")
                .HasColumnName("UserIP");
        });

        modelBuilder.Entity<PhoneCommNumber>(entity =>
        {
            entity.HasKey(e => e.CommId).HasName("PK__Phone_Co__5C84F6098675C10D");

            entity.ToTable("Phone_CommNumber");

            entity.Property(e => e.CommId)
                .HasComment("通信ID")
                .HasColumnName("commID");
            entity.Property(e => e.CommCode)
                .HasMaxLength(1024)
                .HasComment("通信号码")
                .HasColumnName("commCode");
            entity.Property(e => e.CommLastDate)
                .HasComment("最后通信时间")
                .HasColumnType("datetime")
                .HasColumnName("commLastDate");
            entity.Property(e => e.ContactId)
                .HasComment("联系人ID")
                .HasColumnName("contactID");
        });

        modelBuilder.Entity<PhoneContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PK__Phone_Co__7121FD15940757C2");

            entity.ToTable("Phone_Contact");

            entity.Property(e => e.ContactId)
                .HasComment("联系人ID")
                .HasColumnName("contactID");
            entity.Property(e => e.ContactEnterpriseDepartment)
                .HasMaxLength(255)
                .HasComment("企业部门")
                .HasColumnName("contactEnterpriseDepartment");
            entity.Property(e => e.ContactEnterprisePosition)
                .HasMaxLength(255)
                .HasComment("企业职位")
                .HasColumnName("contactEnterprisePosition");
            entity.Property(e => e.ContactGender)
                .HasComment("性别")
                .HasColumnName("contactGender");
            entity.Property(e => e.ContactMemo)
                .HasComment("备注")
                .HasColumnName("contactMemo");
            entity.Property(e => e.ContactName)
                .HasMaxLength(64)
                .HasComment("姓名")
                .HasColumnName("contactName");
            entity.Property(e => e.ContactRefEnterprises)
                .HasComment("关联企业")
                .HasColumnName("contactRefEnterprises");
        });

        modelBuilder.Entity<PhoneEnterprise>(entity =>
        {
            entity.HasKey(e => e.EnterpriseId).HasName("PK__Phone_En__C8C70C01AAD99F13");

            entity.ToTable("Phone_Enterprise");

            entity.Property(e => e.EnterpriseId)
                .HasComment("企业ID")
                .HasColumnName("enterpriseID");
            entity.Property(e => e.EnterpriseAbbName)
                .HasMaxLength(255)
                .HasComment("简称")
                .HasColumnName("enterpriseAbbName");
            entity.Property(e => e.EnterpriseAddress)
                .HasMaxLength(1024)
                .HasComment("地址")
                .HasColumnName("enterpriseAddress");
            entity.Property(e => e.EnterpriseCode)
                .HasMaxLength(64)
                .HasComment("编码")
                .HasColumnName("enterpriseCode");
            entity.Property(e => e.EnterpriseMemo)
                .HasComment("备注")
                .HasColumnName("enterpriseMemo");
            entity.Property(e => e.EnterpriseName)
                .HasMaxLength(255)
                .HasComment("名称")
                .HasColumnName("enterpriseName");
            entity.Property(e => e.EnterpriseNumber)
                .HasMaxLength(24)
                .HasComment("信息代码")
                .HasColumnName("enterpriseNumber");
            entity.Property(e => e.EnterpriseProduct)
                .HasMaxLength(1024)
                .HasComment("产品")
                .HasColumnName("enterpriseProduct");
            entity.Property(e => e.EnterpriseType)
                .HasMaxLength(64)
                .HasComment("类型")
                .HasColumnName("enterpriseType");
        });

        modelBuilder.Entity<PhoneRecord>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__Phone_Re__3853EA80990DA31F");

            entity.ToTable("Phone_Records");

            entity.Property(e => e.Autoid)
                .HasComment("通信记录ID")
                .HasColumnName("autoid");
            entity.Property(e => e.CommContent)
                .HasComment("内容")
                .HasColumnName("commContent");
            entity.Property(e => e.CommDate)
                .HasComment("日期时间")
                .HasColumnType("datetime")
                .HasColumnName("commDate");
            entity.Property(e => e.CommNumber)
                .HasMaxLength(255)
                .HasComment("通信号码")
                .HasColumnName("commNumber");
            entity.Property(e => e.CommOut)
                .HasDefaultValueSql("((0))")
                .HasComment("呼入:0,呼出:1")
                .HasColumnName("commOut");
            entity.Property(e => e.ContactName)
                .HasMaxLength(64)
                .HasComment("联系人")
                .HasColumnName("contactName");
            entity.Property(e => e.ContactRefEnterprise)
                .HasMaxLength(255)
                .HasComment("关联企业")
                .HasColumnName("contactRefEnterprise");
        });

        modelBuilder.Entity<PoareaT>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("POAreaT");

            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .HasColumnName("area");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<PublicProvince>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PpFid).HasColumnName("PP_Fid");
            entity.Property(e => e.PpId).HasColumnName("PP_Id");
            entity.Property(e => e.PpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PP_Name");
            entity.Property(e => e.PpSort).HasColumnName("PP_Sort");
        });

        modelBuilder.Entity<Pudispatch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PUDispatch");

            entity.Property(e => e.DispatchId).HasMaxLength(128);
            entity.Property(e => e.DispatchMoney).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DispatchQuantity).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DispatchWeight).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.PodId).HasColumnName("podId");
        });

        modelBuilder.Entity<PuorderDetail>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__PUOrderD__3853EA80D52FC4FE");

            entity.ToTable("PUOrderDetail");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InvBrand).HasMaxLength(255);
            entity.Property(e => e.InvCode).HasMaxLength(128);
            entity.Property(e => e.InvLevel).HasMaxLength(255);
            entity.Property(e => e.InvName).HasMaxLength(255);
            entity.Property(e => e.InvStd).HasMaxLength(255);
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.Pack).HasColumnName("pack");
            entity.Property(e => e.Pomoney)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POMoney");
            entity.Property(e => e.Poprice)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POPrice");
            entity.Property(e => e.Poquantity)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POQuantity");
            entity.Property(e => e.Poweight)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POWeight");
        });

        modelBuilder.Entity<PuorderMain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PUOrderM__3213E83F5EA76EB7");

            entity.ToTable("PUOrderMain");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Area)
                .HasMaxLength(64)
                .HasColumnName("area");
            entity.Property(e => e.BizPoOrder)
                .HasMaxLength(128)
                .HasColumnName("bizPoOrder");
            entity.Property(e => e.Consignee).HasMaxLength(255);
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.Factory)
                .HasMaxLength(128)
                .HasColumnName("factory");
            entity.Property(e => e.FactoryPoOrder)
                .HasMaxLength(128)
                .HasColumnName("factoryPoOrder");
            entity.Property(e => e.Memo).HasMaxLength(1024);
            entity.Property(e => e.Receiver).HasMaxLength(64);
            entity.Property(e => e.ReceivingAddress).HasMaxLength(512);
            entity.Property(e => e.ReceivingPhone).HasMaxLength(128);
        });

        modelBuilder.Entity<QcClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_Class");

            entity.Property(e => e.CClsFlag)
                .HasMaxLength(8)
                .HasComment("分类标识")
                .HasColumnName("cClsFlag");
            entity.Property(e => e.CClsName)
                .HasMaxLength(64)
                .HasComment("分类名")
                .HasColumnName("cClsName");
            entity.Property(e => e.DToDay)
                .HasComment("当前日期")
                .HasColumnType("datetime")
                .HasColumnName("dToDay");
            entity.Property(e => e.IClsAutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("iClsAutoId");
            entity.Property(e => e.IToDayMax)
                .HasComment("当天最大值")
                .HasColumnName("iToDayMax");
        });

        modelBuilder.Entity<QcCodeIdentity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_CodeIdentity");

            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoID");
            entity.Property(e => e.CClsFlag)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("cClsFlag");
            entity.Property(e => e.CManager)
                .HasMaxLength(20)
                .HasColumnName("cManager");
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.ISn).HasColumnName("iSN");
        });

        modelBuilder.Entity<QcDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_Details");

            entity.Property(e => e.BDaiShouKuan)
                .HasDefaultValueSql("((0))")
                .HasColumnName("bDaiShouKuan");
            entity.Property(e => e.CInvCode)
                .HasMaxLength(24)
                .HasColumnName("cInvCode");
            entity.Property(e => e.CInvName)
                .HasMaxLength(32)
                .HasColumnName("cInvName");
            entity.Property(e => e.CInvStd)
                .HasMaxLength(64)
                .HasColumnName("cInvStd");
            entity.Property(e => e.CMemo)
                .HasMaxLength(512)
                .HasComment("Memo")
                .HasColumnName("cMemo");
            entity.Property(e => e.DSaleSumFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("dSaleSumFinishDate");
            entity.Property(e => e.DSaleSumStartDate)
                .HasColumnType("datetime")
                .HasColumnName("dSaleSumStartDate");
            entity.Property(e => e.IPrice)
                .HasColumnType("money")
                .HasColumnName("iPrice");
            entity.Property(e => e.IQuentity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("iQuentity");
            entity.Property(e => e.ISum)
                .HasColumnType("money")
                .HasColumnName("iSum");
            entity.Property(e => e.QcAutoid)
                .ValueGeneratedOnAdd()
                .HasComment("签呈记录id")
                .HasColumnName("QC_Autoid");
            entity.Property(e => e.QcMainId).HasColumnName("QC_MainID");
            entity.Property(e => e.QcOrderCode)
                .HasMaxLength(24)
                .HasColumnName("QC_OrderCode");
            entity.Property(e => e.QcRcid).HasColumnName("QC_RCID");
        });

        modelBuilder.Entity<QcDetailClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_DetailClass");

            entity.Property(e => e.QcRcdescription)
                .HasMaxLength(128)
                .HasComment("签呈分类描述")
                .HasColumnName("QC_RCDescription");
            entity.Property(e => e.QcRcid)
                .ValueGeneratedOnAdd()
                .HasColumnName("QC_RCID");
            entity.Property(e => e.QcRcindex)
                .HasComment("排序权重")
                .HasColumnName("QC_RCIndex");
            entity.Property(e => e.QcRcname)
                .HasMaxLength(64)
                .HasComment("签呈分类名称")
                .HasColumnName("QC_RCName");
        });

        modelBuilder.Entity<QcMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_Main");

            entity.Property(e => e.CClsFlag)
                .HasMaxLength(8)
                .HasColumnName("cClsFlag");
            entity.Property(e => e.CCode)
                .HasMaxLength(24)
                .HasComment("签呈编号")
                .HasColumnName("cCode");
            entity.Property(e => e.CCreateMan)
                .HasMaxLength(16)
                .HasComment("创建人")
                .HasColumnName("cCreateMan");
            entity.Property(e => e.CCusCode)
                .HasMaxLength(24)
                .HasColumnName("cCusCode");
            entity.Property(e => e.CCusManager)
                .HasMaxLength(16)
                .HasComment("客户经理")
                .HasColumnName("cCusManager");
            entity.Property(e => e.CCusName)
                .HasMaxLength(64)
                .HasColumnName("cCusName");
            entity.Property(e => e.CCusPerson)
                .HasMaxLength(16)
                .HasColumnName("cCusPerson");
            entity.Property(e => e.CMemo)
                .HasMaxLength(1024)
                .HasColumnName("cMemo");
            entity.Property(e => e.CModifyMan)
                .HasMaxLength(16)
                .HasComment("修改人")
                .HasColumnName("cModifyMan");
            entity.Property(e => e.CResult)
                .HasMaxLength(255)
                .HasColumnName("cResult");
            entity.Property(e => e.CSubject)
                .HasMaxLength(255)
                .HasDefaultValueSql("('关于 xx 政策申请')")
                .HasComment("主题")
                .HasColumnName("cSubject");
            entity.Property(e => e.CVouchCode)
                .HasMaxLength(255)
                .HasColumnName("cVouchCode");
            entity.Property(e => e.DCreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("创建日期")
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DEffDate)
                .HasColumnType("datetime")
                .HasColumnName("dEffDate");
            entity.Property(e => e.DExpDate)
                .HasComment("失效期")
                .HasColumnType("datetime")
                .HasColumnName("dExpDate");
            entity.Property(e => e.DModifyDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("修改日期")
                .HasColumnType("datetime")
                .HasColumnName("dModifyDate");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<QcReply>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_Replys");

            entity.Property(e => e.AutoId).ValueGeneratedOnAdd();
            entity.Property(e => e.QcMainId)
                .HasComment("签呈主ID")
                .HasColumnName("QC_MainID");
            entity.Property(e => e.QcNextId)
                .HasDefaultValueSql("('')")
                .HasComment("转交他人批复的AutoID")
                .HasColumnName("QC_NextID");
            entity.Property(e => e.QcReplyContent)
                .HasMaxLength(128)
                .HasDefaultValueSql("('')")
                .HasComment("批复内容")
                .HasColumnName("QC_ReplyContent");
            entity.Property(e => e.QcReplyDate)
                .HasComment("批复日期")
                .HasColumnType("datetime")
                .HasColumnName("QC_ReplyDate");
            entity.Property(e => e.QcReplyMan)
                .HasMaxLength(16)
                .HasComment("批复人")
                .HasColumnName("QC_ReplyMan");
            entity.Property(e => e.QcReplyPass)
                .HasComment("签呈是否通过")
                .HasColumnName("QC_ReplyPass");
            entity.Property(e => e.QcSubmitDate)
                .HasComment("提交日期")
                .HasColumnType("datetime")
                .HasColumnName("QC_SubmitDate");
            entity.Property(e => e.QcSubmitMan)
                .HasMaxLength(16)
                .HasComment("提交人")
                .HasColumnName("QC_SubmitMan");
            entity.Property(e => e.ReplyMan)
                .HasMaxLength(16)
                .HasColumnName("replyMan");
            entity.Property(e => e.SubmitMan)
                .HasMaxLength(16)
                .HasColumnName("submitMan");
        });

        modelBuilder.Entity<QcTxtContent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QC_txtContent");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoid");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Plan).HasColumnName("plan");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ClsId).HasColumnName("clsID");
            entity.Property(e => e.CustPermission)
                .HasDefaultValueSql("((0))")
                .HasComment("客户权限控制")
                .HasColumnName("custPermission");
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.ErpVisitFieldId).HasColumnName("ErpVisitFieldID");
            entity.Property(e => e.IsProcessWithParams)
                .HasDefaultValueSql("((0))")
                .HasComment("是否带参数的存储过程")
                .HasColumnName("isProcessWithParams");
            entity.Property(e => e.ModuleId).HasColumnName("moduleID");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.ReportId)
                .ValueGeneratedOnAdd()
                .HasColumnName("reportID");
            entity.Property(e => e.Title).HasMaxLength(128);
        });

        modelBuilder.Entity<ReportClass>(entity =>
        {
            entity.HasKey(e => e.ClsId).HasName("PK__report_C__3214EC273DB75E9E");

            entity.ToTable("report_Class");

            entity.Property(e => e.ClsId).HasColumnName("clsID");
            entity.Property(e => e.ClsDescription)
                .HasMaxLength(1024)
                .HasColumnName("clsDescription");
            entity.Property(e => e.ClsName)
                .HasMaxLength(128)
                .HasColumnName("clsName");
        });

        modelBuilder.Entity<ReportField>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_Fields");

            entity.Property(e => e.FieldId)
                .ValueGeneratedOnAdd()
                .HasColumnName("fieldID");
            entity.Property(e => e.FieldIndex).HasColumnName("fieldIndex");
            entity.Property(e => e.FieldName)
                .HasMaxLength(256)
                .HasColumnName("fieldName");
            entity.Property(e => e.FieldNameCompute)
                .HasMaxLength(255)
                .HasColumnName("fieldNameCompute");
            entity.Property(e => e.FieldTitle)
                .HasMaxLength(128)
                .HasColumnName("fieldTitle");
            entity.Property(e => e.IsDisplay)
                .HasDefaultValueSql("((1))")
                .HasColumnName("isDisplay");
            entity.Property(e => e.IsErpEmployeeVisit)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isErpEmployeeVisit");
            entity.Property(e => e.IsParam)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isParam");
            entity.Property(e => e.ReportId).HasColumnName("reportID");
        });

        modelBuilder.Entity<ReportFilter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_Filter");

            entity.Property(e => e.ComparisonOperator)
                .HasMaxLength(128)
                .HasColumnName("comparisonOperator");
            entity.Property(e => e.FieldId).HasColumnName("fieldID");
            entity.Property(e => e.FieldName)
                .HasMaxLength(256)
                .HasColumnName("fieldName");
            entity.Property(e => e.FilterId)
                .ValueGeneratedOnAdd()
                .HasColumnName("filterID");
            entity.Property(e => e.FilterIndex).HasColumnName("filterIndex");
            entity.Property(e => e.LogicOperator)
                .HasMaxLength(128)
                .HasColumnName("logicOperator");
            entity.Property(e => e.ReportId).HasColumnName("reportID");
            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<ReportModule>(entity =>
        {
            entity.HasKey(e => e.ModuleId).HasName("PK__report_M__8EEC8E3747272FF6");

            entity.ToTable("report_Module");

            entity.Property(e => e.ModuleId).HasColumnName("moduleID");
            entity.Property(e => e.ModuleDescription)
                .HasMaxLength(1024)
                .HasColumnName("moduleDescription");
            entity.Property(e => e.ModuleName)
                .HasMaxLength(128)
                .HasColumnName("moduleName");
        });

        modelBuilder.Entity<ReportOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("report_Order");

            entity.Property(e => e.FieldId).HasColumnName("fieldID");
            entity.Property(e => e.FieldName)
                .HasMaxLength(128)
                .HasColumnName("fieldName");
            entity.Property(e => e.IsAsc)
                .HasDefaultValueSql("((1))")
                .HasComment("1:升序；0:降序")
                .HasColumnName("isAsc");
            entity.Property(e => e.OrderId)
                .ValueGeneratedOnAdd()
                .HasColumnName("orderID");
            entity.Property(e => e.OrderIndex).HasColumnName("orderIndex");
            entity.Property(e => e.OrderString).HasColumnName("orderString");
            entity.Property(e => e.ReportId).HasColumnName("reportID");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<ReportPermission>(entity =>
        {
            entity.HasKey(e => e.AutoId).HasName("PK__report_P__6B232965C6528A3C");

            entity.ToTable("report_Permissions");

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.ReportId).HasColumnName("reportID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ReportPivotView>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("PK__report_P__3853EA80F7F735F4");

            entity.ToTable("report_PivotView");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.IsLast)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isLast");
            entity.Property(e => e.PivotName)
                .HasMaxLength(255)
                .HasColumnName("pivotName");
            entity.Property(e => e.PivotParams).HasColumnName("pivotParams");
            entity.Property(e => e.ReportId).HasColumnName("reportID");
            entity.Property(e => e.UserId).HasColumnName("userID");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_role_Id");

            entity.ToTable("role", tb => tb.HasComment("角色"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.RoleDescription)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("角色描述")
                .HasColumnName("roleDescription");
            entity.Property(e => e.RoleName)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("角色名")
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<RoleRefUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_roleRefUser_Id");

            entity.ToTable("roleRefUser", tb => tb.HasComment("角色关联用户"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.RoleId)
                .HasComment("角色ID")
                .HasColumnName("roleID");
            entity.Property(e => e.UserId)
                .HasComment("用户ID")
                .HasColumnName("userID");
        });

        modelBuilder.Entity<SigeInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sigeInfo_Id");

            entity.ToTable("sigeInfo", tb => tb.HasComment("登录信息"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("email")
                .HasColumnName("eMail");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("用户名");
            entity.Property(e => e.NickName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("昵称");
            entity.Property(e => e.Phone)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("phone")
                .HasColumnName("phone");
            entity.Property(e => e.Pw)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("pw")
                .HasColumnName("pw");
        });

        modelBuilder.Entity<SqlQuery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sqlQuery");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasComment("序号")
                .HasColumnName("autoid");
            entity.Property(e => e.SMemo).HasColumnName("sMemo");
            entity.Property(e => e.SQueryGroup)
                .HasComment("查询分组")
                .HasColumnName("sQueryGroup");
            entity.Property(e => e.SQueryMain)
                .HasComment("查寻主句, 替换关键字{0}")
                .HasColumnName("sQueryMain");
            entity.Property(e => e.SQueryName)
                .HasMaxLength(128)
                .HasComment("查询名称")
                .HasColumnName("sQueryName");
            entity.Property(e => e.SQueryOrder)
                .HasComment("查询排序")
                .HasColumnName("sQueryOrder");
            entity.Property(e => e.SQueryWhere)
                .HasComment("查寻条件, 替换关键字{0}")
                .HasColumnName("sQueryWhere");
        });

        modelBuilder.Entity<StoreCurrent>(entity =>
        {
            entity.HasKey(e => e.Autoid).HasName("autoid");

            entity.ToTable("StoreCurrent");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.InventoryCode)
                .HasMaxLength(16)
                .HasColumnName("inventoryCode");
            entity.Property(e => e.Iquantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iquantity");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(16)
                .HasColumnName("warehouseCode");
        });

        modelBuilder.Entity<StoreDetail>(entity =>
        {
            entity.HasKey(e => e.DId).HasName("dId");

            entity.Property(e => e.DId).HasColumnName("dId");
            entity.Property(e => e.CInvCode)
                .HasMaxLength(16)
                .HasColumnName("cInvCode");
            entity.Property(e => e.CMemo)
                .HasMaxLength(1024)
                .HasColumnName("cMemo");
            entity.Property(e => e.CWhcode)
                .HasMaxLength(16)
                .HasColumnName("cWHCode");
            entity.Property(e => e.IQuantity)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("iQuantity");
            entity.Property(e => e.MId).HasColumnName("mId");
        });

        modelBuilder.Entity<StoreMain>(entity =>
        {
            entity.HasKey(e => e.MId).HasName("mId");

            entity.ToTable("StoreMain");

            entity.Property(e => e.MId).HasColumnName("mId");
            entity.Property(e => e.BFlag).HasColumnName("bFlag");
            entity.Property(e => e.CCode)
                .HasMaxLength(64)
                .HasColumnName("cCode");
            entity.Property(e => e.CCusCode)
                .HasMaxLength(16)
                .HasColumnName("cCusCode");
            entity.Property(e => e.CMemo).HasColumnName("cMemo");
            entity.Property(e => e.CShipAddress).HasColumnName("cShipAddress");
            entity.Property(e => e.CVenCode)
                .HasMaxLength(16)
                .HasColumnName("cVenCode");
            entity.Property(e => e.ContactMan)
                .HasMaxLength(16)
                .HasColumnName("contactMan");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(32)
                .HasColumnName("contactPhone");
            entity.Property(e => e.CreateDate)
                .HasColumnType("date")
                .HasColumnName("createDate");
            entity.Property(e => e.CreateMan)
                .HasMaxLength(16)
                .HasColumnName("createMan");
            entity.Property(e => e.DDate)
                .HasColumnType("date")
                .HasColumnName("dDate");
            entity.Property(e => e.ModifyDate)
                .HasColumnType("date")
                .HasColumnName("modifyDate");
            entity.Property(e => e.ModifyMan)
                .HasMaxLength(16)
                .HasColumnName("modifyMan");
        });

        modelBuilder.Entity<StrategyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strategyDetail");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoid");
            entity.Property(e => e.CinvAcode)
                .HasMaxLength(255)
                .HasColumnName("cinvACode");
            entity.Property(e => e.CinvAname)
                .HasMaxLength(255)
                .HasColumnName("cinvAName");
            entity.Property(e => e.CinvAstd)
                .HasMaxLength(512)
                .HasColumnName("cinvAStd");
            entity.Property(e => e.CinvBcode)
                .HasMaxLength(255)
                .HasColumnName("cinvBCode");
            entity.Property(e => e.CinvBname)
                .HasMaxLength(255)
                .HasColumnName("cinvBName");
            entity.Property(e => e.CinvBstd)
                .HasMaxLength(512)
                .HasColumnName("cinvBStd");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvAprice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("invAPrice");
            entity.Property(e => e.InvAquantity)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invAQuantity");
            entity.Property(e => e.InvArate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invARate");
            entity.Property(e => e.InvBprice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("money")
                .HasColumnName("invBPrice");
            entity.Property(e => e.InvBquantity)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invBQuantity");
            entity.Property(e => e.InvBrate)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invBRate");
        });

        modelBuilder.Entity<StrategyLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strategyLogs");

            entity.Property(e => e.CClass)
                .HasMaxLength(128)
                .HasColumnName("cClass");
            entity.Property(e => e.CException)
                .HasMaxLength(2048)
                .HasColumnName("cException");
            entity.Property(e => e.CFunction)
                .HasMaxLength(128)
                .HasColumnName("cFunction");
            entity.Property(e => e.CIp)
                .HasMaxLength(24)
                .HasComment("用户IP")
                .HasColumnName("cIP");
            entity.Property(e => e.CLastValue)
                .HasComment("修改后的值")
                .HasColumnName("cLastValue");
            entity.Property(e => e.CModule)
                .HasMaxLength(128)
                .HasColumnName("cModule");
            entity.Property(e => e.CParams)
                .HasMaxLength(1024)
                .HasColumnName("cParams");
            entity.Property(e => e.CReturn)
                .HasMaxLength(2048)
                .HasColumnName("cReturn");
            entity.Property(e => e.CUserName)
                .HasMaxLength(128)
                .HasColumnName("cUserName");
            entity.Property(e => e.CWorkStation)
                .HasMaxLength(128)
                .HasComment("用户工作站")
                .HasColumnName("cWorkStation");
            entity.Property(e => e.DLogDate)
                .HasComment("日志日期")
                .HasColumnType("datetime")
                .HasColumnName("dLogDate");
            entity.Property(e => e.IActionId)
                .HasComment("动作Id")
                .HasColumnName("iActionId");
            entity.Property(e => e.IFunctionId)
                .HasComment("功能Id")
                .HasColumnName("iFunctionId");
            entity.Property(e => e.ILogId)
                .ValueGeneratedOnAdd()
                .HasComment("日志ID")
                .HasColumnName("iLogId");
            entity.Property(e => e.IUserId)
                .HasComment("用户Id")
                .HasColumnName("iUserID");
        });

        modelBuilder.Entity<StrategyMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("strategyMain");

            entity.Property(e => e.CDcname)
                .HasMaxLength(128)
                .HasColumnName("cDCName");
            entity.Property(e => e.CDwcode)
                .HasMaxLength(128)
                .HasColumnName("cDWCode");
            entity.Property(e => e.CDwcontact)
                .HasMaxLength(64)
                .HasColumnName("cDWcontact");
            entity.Property(e => e.CDwname)
                .HasMaxLength(255)
                .HasColumnName("cDWName");
            entity.Property(e => e.CLevel)
                .HasMaxLength(255)
                .HasColumnName("cLevel");
            entity.Property(e => e.CMemo)
                .HasMaxLength(1024)
                .HasColumnName("cMemo");
            entity.Property(e => e.CModifier)
                .HasMaxLength(64)
                .HasColumnName("cModifier");
            entity.Property(e => e.CSourceCode)
                .HasMaxLength(255)
                .HasColumnName("cSourceCode");
            entity.Property(e => e.CSourceType)
                .HasMaxLength(255)
                .HasColumnName("cSourceType");
            entity.Property(e => e.CVouchCode)
                .HasMaxLength(255)
                .HasColumnName("cVouchCode");
            entity.Property(e => e.CVouchType)
                .HasMaxLength(255)
                .HasColumnName("cVouchType");
            entity.Property(e => e.DEffDate)
                .HasColumnType("datetime")
                .HasColumnName("dEffDate");
            entity.Property(e => e.DExpDate)
                .HasColumnType("datetime")
                .HasColumnName("dExpDate");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        });

        modelBuilder.Entity<TaxBillDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("taxBillDetails");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoid");
            entity.Property(e => e.Dj)
                .HasComment("单价")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Ggxh)
                .HasMaxLength(96)
                .HasComment("规格型号");
            entity.Property(e => e.Id)
                .HasComment("发票主表ID")
                .HasColumnName("ID");
            entity.Property(e => e.Je)
                .HasComment("金额")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Jldw)
                .HasMaxLength(64)
                .HasComment("计量单位");
            entity.Property(e => e.Lslbz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("零税率标识");
            entity.Property(e => e.Qyspbm)
                .HasMaxLength(48)
                .HasComment("企业商品编码");
            entity.Property(e => e.Se)
                .HasComment("税额")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Sl)
                .HasComment("数量")
                .HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Slv)
                .HasComment("税率")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Spbm)
                .HasMaxLength(48)
                .HasComment("商品编码");
            entity.Property(e => e.Spmc)
                .HasMaxLength(255)
                .HasComment("商品名称");
            entity.Property(e => e.Syyhzcbz).HasComment("优惠政策标识");
            entity.Property(e => e.Xh).HasComment("序号");
            entity.Property(e => e.Yhzcsm)
                .HasMaxLength(128)
                .HasComment("优惠政策说明");
        });

        modelBuilder.Entity<TaxBillMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("taxBillMain");

            entity.Property(e => e.Bz)
                .HasMaxLength(512)
                .HasComment("备注");
            entity.Property(e => e.Djh)
                .HasMaxLength(32)
                .HasComment("单据号");
            entity.Property(e => e.Fhr)
                .HasMaxLength(16)
                .HasComment("复核人");
            entity.Property(e => e.Fphm)
                .HasMaxLength(10)
                .HasComment("发票号码");
            entity.Property(e => e.Fpzl)
                .HasMaxLength(16)
                .HasComment("发票种类");
            entity.Property(e => e.Gfdzdh)
                .HasMaxLength(255)
                .HasComment("购方地址电话");
            entity.Property(e => e.Gfmc)
                .HasMaxLength(255)
                .HasComment("购方名称");
            entity.Property(e => e.Gfsh)
                .HasMaxLength(24)
                .HasComment("购方税号");
            entity.Property(e => e.Gfyhzh)
                .HasMaxLength(255)
                .HasComment("购方银行帐号");
            entity.Property(e => e.Hjje)
                .HasComment("合计金额")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hjse)
                .HasComment("合计税额")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hsbz).HasComment("含税标志");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Kpr)
                .HasMaxLength(16)
                .HasComment("开票人");
            entity.Property(e => e.Kprq)
                .HasComment("开票日期")
                .HasColumnType("datetime");
            entity.Property(e => e.Lbdm)
                .HasMaxLength(16)
                .HasComment("类别代码");
            entity.Property(e => e.Skr)
                .HasMaxLength(16)
                .HasComment("收款人");
            entity.Property(e => e.Spbmbbh)
                .HasMaxLength(32)
                .HasComment("商品编码版本号");
            entity.Property(e => e.Xfdzdh)
                .HasMaxLength(255)
                .HasComment("销方地址电话");
            entity.Property(e => e.Xfmc)
                .HasMaxLength(255)
                .HasComment("销方名称");
            entity.Property(e => e.Xfsh)
                .HasMaxLength(24)
                .HasComment("销方税号");
            entity.Property(e => e.Xfyhzh)
                .HasMaxLength(255)
                .HasComment("销方银行帐号");
            entity.Property(e => e.Zfbz)
                .HasDefaultValueSql("((0))")
                .HasComment("作废标志")
                .HasColumnName("zfbz");
        });

        modelBuilder.Entity<TaxEairesult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("taxEAIResult");

            entity.Property(e => e.DDate)
                .HasDefaultValueSql("(getdate())")
                .HasComment("处理时间")
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.EaiResult)
                .HasComment("导入结果")
                .HasColumnName("eaiResult");
            entity.Property(e => e.EaiState)
                .HasDefaultValueSql("((-1))")
                .HasComment("导入状态码")
                .HasColumnName("eaiState");
            entity.Property(e => e.TaxFphm)
                .HasMaxLength(8)
                .HasComment("发票号码")
                .HasColumnName("taxFphm");
            entity.Property(e => e.TaxLbdm)
                .HasMaxLength(16)
                .HasComment("发票代码")
                .HasColumnName("taxLbdm");
        });

        modelBuilder.Entity<TaxRefErp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("taxRefErp");

            entity.Property(e => e.BVerification)
                .HasDefaultValueSql("((0))")
                .HasComment("核销")
                .HasColumnName("bVerification");
            entity.Property(e => e.ErpCode)
                .HasMaxLength(64)
                .HasComment("ERP单据编码")
                .HasColumnName("erpCode");
            entity.Property(e => e.ErpCusAbbName)
                .HasMaxLength(255)
                .HasComment("ERP客户简称")
                .HasColumnName("erpCusAbbName");
            entity.Property(e => e.ErpCusContact)
                .HasMaxLength(64)
                .HasComment("ERP联系人")
                .HasColumnName("erpCusContact");
            entity.Property(e => e.ErpCusName)
                .HasMaxLength(255)
                .HasComment("ERP客户名称")
                .HasColumnName("erpCusName");
            entity.Property(e => e.ErpDate)
                .HasComment("ERP单据日期")
                .HasColumnType("datetime")
                .HasColumnName("erpDate");
            entity.Property(e => e.ErpJe)
                .HasComment("ERP单据金额")
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("erpJe");
            entity.Property(e => e.ErpMainId)
                .HasComment("ERP主表ID")
                .HasColumnName("erpMainID");
            entity.Property(e => e.ErpVouchType)
                .HasMaxLength(64)
                .HasComment("ERP单据类型")
                .HasColumnName("erpVouchType");
            entity.Property(e => e.Fphm)
                .HasMaxLength(16)
                .HasComment("发票编码")
                .HasColumnName("fphm");
            entity.Property(e => e.TaxDate)
                .HasComment("发票日期")
                .HasColumnType("datetime")
                .HasColumnName("taxDate");
            entity.Property(e => e.TaxErpCode)
                .HasMaxLength(255)
                .HasComment("发票备注ERP单据简码")
                .HasColumnName("taxErpCode");
            entity.Property(e => e.TaxId)
                .HasComment("发票主表ID")
                .HasColumnName("taxID");
        });

        modelBuilder.Entity<UserInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_userInfo_Id");

            entity.ToTable("userInfo", tb => tb.HasComment("用户信息"));

            entity.Property(e => e.Id).HasComment("1");
            entity.Property(e => e.CardId)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("证件号")
                .HasColumnName("cardID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("email")
                .HasColumnName("email");
            entity.Property(e => e.Male)
                .HasComment("性别")
                .HasColumnName("male");
            entity.Property(e => e.Memo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("备注")
                .HasColumnName("memo");
            entity.Property(e => e.Phone)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasComment("联系方式")
                .HasColumnName("phone");
            entity.Property(e => e.SignId)
                .HasComment("登录id")
                .HasColumnName("signId");
        });

        modelBuilder.Entity<VAttendance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Attendance");

            entity.Property(e => e.Autoid)
                .ValueGeneratedOnAdd()
                .HasColumnName("autoid");
            entity.Property(e => e.BAttTimeStr)
                .HasMaxLength(16)
                .HasColumnName("bAttTimeStr");
            entity.Property(e => e.BOffset).HasColumnName("bOffset");
            entity.Property(e => e.BOffsetFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("bOffsetFee");
            entity.Property(e => e.EAttTimeStr)
                .HasMaxLength(16)
                .HasColumnName("eAttTimeStr");
            entity.Property(e => e.EOffset).HasColumnName("eOffset");
            entity.Property(e => e.EOffsetFee)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("eOffsetFee");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.PeriodNo).HasColumnName("periodNo");
            entity.Property(e => e.SDate)
                .HasColumnType("datetime")
                .HasColumnName("sDate");
        });

        modelBuilder.Entity<VAttendanceEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AttendanceEvent");

            entity.Property(e => e.AutoId).HasColumnName("autoID");
            entity.Property(e => e.BAttTimeStr)
                .HasMaxLength(16)
                .HasColumnName("bAttTimeStr");
            entity.Property(e => e.BOffset).HasColumnName("bOffset");
            entity.Property(e => e.BTime)
                .HasMaxLength(14)
                .HasColumnName("bTime");
            entity.Property(e => e.CheckMan)
                .HasMaxLength(128)
                .HasColumnName("checkMan");
            entity.Property(e => e.EAttTimeStr)
                .HasMaxLength(16)
                .HasColumnName("eAttTimeStr");
            entity.Property(e => e.EOffset).HasColumnName("eOffset");
            entity.Property(e => e.ETime)
                .HasMaxLength(14)
                .HasColumnName("eTime");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.FeeCar).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FeeMeals).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.FeeOther).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.IsBeginTime).HasColumnName("isBeginTime");
            entity.Property(e => e.IsCar).HasColumnName("isCar");
            entity.Property(e => e.Manager).HasMaxLength(128);
            entity.Property(e => e.PeriodNo).HasColumnName("periodNo");
            entity.Property(e => e.RecordId).HasColumnName("recordID");
            entity.Property(e => e.SDate)
                .HasColumnType("datetime")
                .HasColumnName("sDate");
        });

        modelBuilder.Entity<VLogisticsMx>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_LogisticsMX");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.ContactName)
                .HasMaxLength(64)
                .HasColumnName("contactName");
            entity.Property(e => e.ContactPhone)
                .HasMaxLength(128)
                .HasColumnName("contactPhone");
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.DlCode)
                .HasMaxLength(24)
                .HasColumnName("dlCode");
            entity.Property(e => e.DlDate)
                .HasColumnType("datetime")
                .HasColumnName("dlDate");
            entity.Property(e => e.DlQuantity)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("dlQuantity");
            entity.Property(e => e.Dlid).HasColumnName("dlid");
            entity.Property(e => e.DwAbbName)
                .HasMaxLength(128)
                .HasColumnName("dwAbbName");
            entity.Property(e => e.EmployeeName)
                .HasMaxLength(64)
                .HasColumnName("employeeName");
            entity.Property(e => e.Idlsid).HasColumnName("idlsid");
            entity.Property(e => e.InvCode)
                .HasMaxLength(32)
                .HasColumnName("invCode");
            entity.Property(e => e.InvName)
                .HasMaxLength(64)
                .HasColumnName("invName");
            entity.Property(e => e.InvStd)
                .HasMaxLength(64)
                .HasColumnName("invStd");
            entity.Property(e => e.Lid).HasColumnName("lid");
            entity.Property(e => e.Money).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Sender)
                .HasMaxLength(64)
                .HasColumnName("sender");
            entity.Property(e => e.ShipAddress)
                .HasMaxLength(1024)
                .HasColumnName("shipAddress");
            entity.Property(e => e.ShipQuantity)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("shipQuantity");
            entity.Property(e => e.State)
                .HasMaxLength(8)
                .HasColumnName("state");
            entity.Property(e => e.VouchMemo)
                .HasMaxLength(1024)
                .HasColumnName("vouchMemo");
        });

        modelBuilder.Entity<VPetitionList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_petitionList");

            entity.Property(e => e.BDaiShouKuan).HasColumnName("bDaiShouKuan");
            entity.Property(e => e.CCode)
                .HasMaxLength(24)
                .HasColumnName("cCode");
            entity.Property(e => e.CCreateMan)
                .HasMaxLength(16)
                .HasColumnName("cCreateMan");
            entity.Property(e => e.CCusCode)
                .HasMaxLength(24)
                .HasColumnName("cCusCode");
            entity.Property(e => e.CCusManager)
                .HasMaxLength(16)
                .HasColumnName("cCusManager");
            entity.Property(e => e.CCusName)
                .HasMaxLength(64)
                .HasColumnName("cCusName");
            entity.Property(e => e.CCusPerson)
                .HasMaxLength(16)
                .HasColumnName("cCusPerson");
            entity.Property(e => e.CInvCode)
                .HasMaxLength(24)
                .HasColumnName("cInvCode");
            entity.Property(e => e.CInvName)
                .HasMaxLength(32)
                .HasColumnName("cInvName");
            entity.Property(e => e.CInvStd)
                .HasMaxLength(64)
                .HasColumnName("cInvStd");
            entity.Property(e => e.CModifyMan)
                .HasMaxLength(16)
                .HasColumnName("cModifyMan");
            entity.Property(e => e.DCreateDate)
                .HasColumnType("datetime")
                .HasColumnName("dCreateDate");
            entity.Property(e => e.DEffDate)
                .HasColumnType("datetime")
                .HasColumnName("dEffDate");
            entity.Property(e => e.DExpDate)
                .HasColumnType("datetime")
                .HasColumnName("dExpDate");
            entity.Property(e => e.DModifyDate)
                .HasColumnType("datetime")
                .HasColumnName("dModifyDate");
            entity.Property(e => e.DSaleSumFinishDate)
                .HasColumnType("datetime")
                .HasColumnName("dSaleSumFinishDate");
            entity.Property(e => e.DSaleSumStartDate)
                .HasColumnType("datetime")
                .HasColumnName("dSaleSumStartDate");
            entity.Property(e => e.DetailsMemo)
                .HasMaxLength(512)
                .HasColumnName("detailsMemo");
            entity.Property(e => e.IPrice)
                .HasColumnType("money")
                .HasColumnName("iPrice");
            entity.Property(e => e.IQuentity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("iQuentity");
            entity.Property(e => e.ISum)
                .HasColumnType("money")
                .HasColumnName("iSum");
            entity.Property(e => e.MainMemo)
                .HasMaxLength(1024)
                .HasColumnName("mainMemo");
            entity.Property(e => e.QcNextId).HasColumnName("QC_NextID");
            entity.Property(e => e.QcOrderCode)
                .HasMaxLength(24)
                .HasColumnName("QC_OrderCode");
            entity.Property(e => e.QcRcid).HasColumnName("QC_RCID");
            entity.Property(e => e.QcReplyContent)
                .HasMaxLength(128)
                .HasColumnName("QC_ReplyContent");
            entity.Property(e => e.QcReplyDate)
                .HasColumnType("datetime")
                .HasColumnName("QC_ReplyDate");
            entity.Property(e => e.QcReplyMan)
                .HasMaxLength(16)
                .HasColumnName("QC_ReplyMan");
            entity.Property(e => e.QcReplyPass).HasColumnName("QC_ReplyPass");
            entity.Property(e => e.QcSubmitDate)
                .HasColumnType("datetime")
                .HasColumnName("QC_SubmitDate");
            entity.Property(e => e.QcSubmitMan)
                .HasMaxLength(16)
                .HasColumnName("QC_SubmitMan");
            entity.Property(e => e.ReplyMan)
                .HasMaxLength(16)
                .HasColumnName("replyMan");
            entity.Property(e => e.SubmitMan)
                .HasMaxLength(16)
                .HasColumnName("submitMan");
        });

        modelBuilder.Entity<VPurchaseOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_PurchaseOrder");

            entity.Property(e => e.Area)
                .HasMaxLength(64)
                .HasColumnName("area");
            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.BizPoOrder)
                .HasMaxLength(128)
                .HasColumnName("bizPoOrder");
            entity.Property(e => e.Consignee).HasMaxLength(255);
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.Factory)
                .HasMaxLength(128)
                .HasColumnName("factory");
            entity.Property(e => e.FactoryPoOrder)
                .HasMaxLength(128)
                .HasColumnName("factoryPoOrder");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InvBrand).HasMaxLength(255);
            entity.Property(e => e.InvCode).HasMaxLength(128);
            entity.Property(e => e.InvLevel).HasMaxLength(255);
            entity.Property(e => e.InvName).HasMaxLength(255);
            entity.Property(e => e.InvStd).HasMaxLength(255);
            entity.Property(e => e.Memo).HasMaxLength(1024);
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.Pack).HasColumnName("pack");
            entity.Property(e => e.Pomoney)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POMoney");
            entity.Property(e => e.Poprice)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POPrice");
            entity.Property(e => e.Poquantity)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("POQuantity");
            entity.Property(e => e.Poweight)
                .HasColumnType("decimal(23, 11)")
                .HasColumnName("POWeight");
            entity.Property(e => e.PumId).HasColumnName("pumId");
            entity.Property(e => e.Receiver).HasMaxLength(64);
            entity.Property(e => e.ReceivingAddress).HasMaxLength(512);
            entity.Property(e => e.ReceivingPhone).HasMaxLength(128);
        });

        modelBuilder.Entity<VReportPermission>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_reportPermissions");

            entity.Property(e => e.ClsId).HasColumnName("clsID");
            entity.Property(e => e.Description).HasMaxLength(1024);
            entity.Property(e => e.ModuleId).HasColumnName("moduleID");
            entity.Property(e => e.Name).HasMaxLength(128);
            entity.Property(e => e.ReportId).HasColumnName("reportID");
            entity.Property(e => e.Title).HasMaxLength(128);
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<VTaxEaiResult>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TaxEaiResult");

            entity.Property(e => e.Bz).HasMaxLength(512);
            entity.Property(e => e.DDate)
                .HasColumnType("datetime")
                .HasColumnName("dDate");
            entity.Property(e => e.EaiResult).HasColumnName("eaiResult");
            entity.Property(e => e.EaiState).HasColumnName("eaiState");
            entity.Property(e => e.Fphm).HasMaxLength(10);
            entity.Property(e => e.Gfmc).HasMaxLength(255);
            entity.Property(e => e.Hjje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hjse).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kprq).HasColumnType("datetime");
            entity.Property(e => e.Lbdm).HasMaxLength(16);
            entity.Property(e => e.Selected).HasColumnName("selected");
        });

        modelBuilder.Entity<VTaxInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_TaxInvoice");

            entity.Property(e => e.BVerification).HasColumnName("bVerification");
            entity.Property(e => e.Bz).HasMaxLength(512);
            entity.Property(e => e.Dj).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Fhr).HasMaxLength(16);
            entity.Property(e => e.Fphm).HasMaxLength(10);
            entity.Property(e => e.Fpzl).HasMaxLength(16);
            entity.Property(e => e.Gfdzdh).HasMaxLength(255);
            entity.Property(e => e.Gfmc).HasMaxLength(255);
            entity.Property(e => e.Gfsh).HasMaxLength(24);
            entity.Property(e => e.Gfyhzh).HasMaxLength(255);
            entity.Property(e => e.Ggxh).HasMaxLength(96);
            entity.Property(e => e.Hjje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hjse).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Je).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Jldw).HasMaxLength(64);
            entity.Property(e => e.Kpr).HasMaxLength(16);
            entity.Property(e => e.Kprq).HasColumnType("datetime");
            entity.Property(e => e.Lbdm).HasMaxLength(16);
            entity.Property(e => e.Qyspbm).HasMaxLength(48);
            entity.Property(e => e.Se).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Skr).HasMaxLength(16);
            entity.Property(e => e.Sl).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Slv).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Spbm).HasMaxLength(48);
            entity.Property(e => e.Spmc).HasMaxLength(255);
            entity.Property(e => e.TaxId).HasColumnName("taxID");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("total");
            entity.Property(e => e.Zfbz).HasColumnName("zfbz");
        });

        modelBuilder.Entity<VouchType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vouchType");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Key)
                .HasMaxLength(255)
                .HasColumnName("KEY");
            entity.Property(e => e.VouchClass)
                .HasMaxLength(255)
                .HasColumnName("vouchClass");
            entity.Property(e => e.VouchName)
                .HasMaxLength(255)
                .HasColumnName("vouchName");
            entity.Property(e => e.VouchOrder).HasColumnName("vouchOrder");
            entity.Property(e => e.VouchType1)
                .HasMaxLength(255)
                .HasColumnName("vouchType");
        });

        modelBuilder.Entity<VwStrategy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_strategy");

            entity.Property(e => e.Autoid).HasColumnName("autoid");
            entity.Property(e => e.CDcname)
                .HasMaxLength(128)
                .HasColumnName("cDCName");
            entity.Property(e => e.CDwcode)
                .HasMaxLength(128)
                .HasColumnName("cDWCode");
            entity.Property(e => e.CDwcontact)
                .HasMaxLength(64)
                .HasColumnName("cDWcontact");
            entity.Property(e => e.CDwname)
                .HasMaxLength(255)
                .HasColumnName("cDWName");
            entity.Property(e => e.CLevel)
                .HasMaxLength(255)
                .HasColumnName("cLevel");
            entity.Property(e => e.CMemo)
                .HasMaxLength(1024)
                .HasColumnName("cMemo");
            entity.Property(e => e.CSourceCode)
                .HasMaxLength(255)
                .HasColumnName("cSourceCode");
            entity.Property(e => e.CSourceType)
                .HasMaxLength(255)
                .HasColumnName("cSourceType");
            entity.Property(e => e.CVouchCode)
                .HasMaxLength(255)
                .HasColumnName("cVouchCode");
            entity.Property(e => e.CVouchType)
                .HasMaxLength(255)
                .HasColumnName("cVouchType");
            entity.Property(e => e.CinvAcode)
                .HasMaxLength(255)
                .HasColumnName("cinvACode");
            entity.Property(e => e.CinvAname)
                .HasMaxLength(255)
                .HasColumnName("cinvAName");
            entity.Property(e => e.CinvAstd)
                .HasMaxLength(512)
                .HasColumnName("cinvAStd");
            entity.Property(e => e.CinvBcode)
                .HasMaxLength(255)
                .HasColumnName("cinvBCode");
            entity.Property(e => e.CinvBname)
                .HasMaxLength(255)
                .HasColumnName("cinvBName");
            entity.Property(e => e.CinvBstd)
                .HasMaxLength(512)
                .HasColumnName("cinvBStd");
            entity.Property(e => e.DEffDate)
                .HasColumnType("datetime")
                .HasColumnName("dEffDate");
            entity.Property(e => e.DExpDate)
                .HasColumnType("datetime")
                .HasColumnName("dExpDate");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InvAprice)
                .HasColumnType("money")
                .HasColumnName("invAPrice");
            entity.Property(e => e.InvAquantity)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invAQuantity");
            entity.Property(e => e.InvArate)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invARate");
            entity.Property(e => e.InvBprice)
                .HasColumnType("money")
                .HasColumnName("invBPrice");
            entity.Property(e => e.InvBquantity)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invBQuantity");
            entity.Property(e => e.InvBrate)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("invBRate");
            entity.Property(e => e.Mid).HasColumnName("mid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
