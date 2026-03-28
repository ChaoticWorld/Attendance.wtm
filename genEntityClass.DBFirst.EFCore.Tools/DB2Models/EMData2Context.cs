using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace em_wtm.DB2Models
{
    public partial class EMData2Context : DbContext
    {
        public EMData2Context()
        {
        }

        public EMData2Context(DbContextOptions<EMData2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionLog> ActionLogs { get; set; }
        public virtual DbSet<Attendance2DayType> Attendance2DayTypes { get; set; }
        public virtual DbSet<Attendance2EmployeeRefSchemeClass> Attendance2EmployeeRefSchemeClasses { get; set; }
        public virtual DbSet<Attendance2EventDeclared> Attendance2EventDeclareds { get; set; }
        public virtual DbSet<Attendance2FeeCalculator> Attendance2FeeCalculators { get; set; }
        public virtual DbSet<Attendance2Holiday> Attendance2Holidays { get; set; }
        public virtual DbSet<Attendance2PlanRefClass> Attendance2PlanRefClasses { get; set; }
        public virtual DbSet<Attendance2PlanTime> Attendance2PlanTimes { get; set; }
        public virtual DbSet<Attendance2Record> Attendance2Records { get; set; }
        public virtual DbSet<Attendance2SchemeClass> Attendance2SchemeClasses { get; set; }
        public virtual DbSet<DataPrivilege> DataPrivileges { get; set; }
        public virtual DbSet<FileAttachment> FileAttachments { get; set; }
        public virtual DbSet<FrameworkGroup> FrameworkGroups { get; set; }
        public virtual DbSet<FrameworkMenu> FrameworkMenus { get; set; }
        public virtual DbSet<FrameworkRole> FrameworkRoles { get; set; }
        public virtual DbSet<FrameworkTenant> FrameworkTenants { get; set; }
        public virtual DbSet<FrameworkUser> FrameworkUsers { get; set; }
        public virtual DbSet<FrameworkUserGroup> FrameworkUserGroups { get; set; }
        public virtual DbSet<FrameworkUserRole> FrameworkUserRoles { get; set; }
        public virtual DbSet<FunctionPrivilege> FunctionPrivileges { get; set; }
        public virtual DbSet<ReportDataPrepareScript> ReportDataPrepareScripts { get; set; }
        public virtual DbSet<ReportMain> ReportMains { get; set; }
        public virtual DbSet<ReportParam> ReportParams { get; set; }
        public virtual DbSet<ReportParamOperatorEnum> ReportParamOperatorEnums { get; set; }
        public virtual DbSet<ReportPermission> ReportPermissions { get; set; }
        public virtual DbSet<ReportScriptParam> ReportScriptParams { get; set; }
        public virtual DbSet<ReportScriptTypeEnum> ReportScriptTypeEnums { get; set; }
        public virtual DbSet<VAttendanceEmployee> VAttendanceEmployees { get; set; }
        public virtual DbSet<VAttendanceReport> VAttendanceReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DB;Initial Catalog=EMData2;User ID=sa;Password=dfl_DB;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActionLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActionName).HasMaxLength(255);

                entity.Property(e => e.ActionUrl).HasMaxLength(250);

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasMaxLength(50)
                    .HasColumnName("IP");

                entity.Property(e => e.Itcode)
                    .HasMaxLength(50)
                    .HasColumnName("ITCode");

                entity.Property(e => e.ModuleName).HasMaxLength(255);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);
            });

            modelBuilder.Entity<Attendance2DayType>(entity =>
            {
                entity.HasKey(e => e.DayTypeId)
                    .HasName("PK__Attendan__8E02B0143FC63DF9");

                entity.ToTable("Attendance2_DayType");

                entity.HasComment("日期类型");

                entity.Property(e => e.DayTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("DayTypeID")
                    .HasComment("ID");

                entity.Property(e => e.DayTypeCaption)
                    .HasMaxLength(64)
                    .HasComment("显示");

                entity.Property(e => e.DayTypeName)
                    .HasMaxLength(64)
                    .HasComment("名称");
            });

            modelBuilder.Entity<Attendance2EmployeeRefSchemeClass>(entity =>
            {
                entity.HasKey(e => e.Autoid)
                    .HasName("PK__Attendan__3853EA80E0210866");

                entity.ToTable("Attendance2_EmployeeRefSchemeClass");

                entity.HasComment("员工班次");

                entity.Property(e => e.Autoid)
                    .HasColumnName("autoid")
                    .HasComment("序号");

                entity.Property(e => e.ClassId)
                    .HasColumnName("classID")
                    .HasComment("方案班次ID");

                entity.Property(e => e.EffDate)
                    .HasColumnType("datetime")
                    .HasComment("生效日期");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("考勤机员工ID");

                entity.Property(e => e.EmployeeName).HasMaxLength(64);

                entity.Property(e => e.ExpDate)
                    .HasColumnType("datetime")
                    .HasComment("失效日期");

                entity.Property(e => e.PeriodNo)
                    .HasColumnName("periodNo")
                    .HasComment("最后设定日期对应的记录周期号");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasComment("userID - guid");
            });

            modelBuilder.Entity<Attendance2EventDeclared>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__Attendan__385EFE686A173C2C");

                entity.ToTable("Attendance2_EventDeclared");

                entity.Property(e => e.EventId).HasComment("事件序号");

                entity.Property(e => e.CheckMan)
                    .HasMaxLength(128)
                    .HasColumnName("checkMan")
                    .HasComment("审核人");

                entity.Property(e => e.EventDescription).HasComment("事件描述");

                entity.Property(e => e.Fee)
                    .HasColumnType("decimal(18, 2)")
                    .HasComment("其它费用");

                entity.Property(e => e.IsBeginTime).HasColumnName("isBeginTime");

                entity.Property(e => e.Manager)
                    .HasMaxLength(128)
                    .HasComment("经理签字");

                entity.Property(e => e.Memo).HasComment("备注");

                entity.Property(e => e.RecordId).HasColumnName("recordID");
            });

            modelBuilder.Entity<Attendance2FeeCalculator>(entity =>
            {
                entity.HasKey(e => e.FeeId)
                    .HasName("PK__Attendan__B387B2291949B50B");

                entity.ToTable("Attendance2_FeeCalculator");

                entity.HasComment("费用计算");

                entity.Property(e => e.FeeId).HasComment("序号");

                entity.Property(e => e.DayTypeId)
                    .HasMaxLength(64)
                    .HasColumnName("DayTypeID")
                    .HasComment("日期类型ID");

                entity.Property(e => e.RangeA)
                    .HasColumnName("rangeA")
                    .HasComment("时长范围A,A > x >= B");

                entity.Property(e => e.RangeB)
                    .HasColumnName("rangeB")
                    .HasComment("时长范围B,A > x >= B");

                entity.Property(e => e.RangePrice)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rangePrice")
                    .HasComment("金额");
            });

            modelBuilder.Entity<Attendance2Holiday>(entity =>
            {
                entity.HasKey(e => e.Autoid)
                    .HasName("PK__Attendan__5B72A4425642308C");

                entity.ToTable("Attendance2_Holiday");

                entity.HasComment("假日调休");

                entity.Property(e => e.Autoid)
                    .HasColumnName("autoid")
                    .HasComment("序号");

                entity.Property(e => e.BTime)
                    .HasColumnName("bTime")
                    .HasComment("上班时间字符串-hh:mm:ss.nnn");

                entity.Property(e => e.ETime)
                    .HasColumnName("eTime")
                    .HasComment("下班时间字符串-hh:mm:ss.nnn");

                entity.Property(e => e.IYear)
                    .HasColumnName("iYear")
                    .HasComment("年份");

                entity.Property(e => e.SDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sDate")
                    .HasComment("日期字符串yyyy-MM-dd");

                entity.Property(e => e.SDescription)
                    .HasColumnName("sDescription")
                    .HasComment("节假日描述");

                entity.Property(e => e.SName)
                    .HasMaxLength(128)
                    .HasColumnName("sName")
                    .HasComment("节假日名称");
            });

            modelBuilder.Entity<Attendance2PlanRefClass>(entity =>
            {
                entity.HasKey(e => e.Autoid)
                    .HasName("PK__planRefC__3853EA80F17E1B25");

                entity.ToTable("Attendance2_PlanRefClass");

                entity.HasComment("排班标准时间与班次关联表");

                entity.Property(e => e.Autoid).HasColumnName("autoid");

                entity.Property(e => e.Classid)
                    .HasColumnName("classid")
                    .HasComment("班次ID");

                entity.Property(e => e.PeriodNo)
                    .HasColumnName("periodNo")
                    .HasComment("周期序号");

                entity.Property(e => e.Planid)
                    .HasColumnName("planid")
                    .HasComment("计划ID");
            });

            modelBuilder.Entity<Attendance2PlanTime>(entity =>
            {
                entity.HasKey(e => e.Planid)
                    .HasName("PK__Attendan__A29531D0EDB443B6");

                entity.ToTable("Attendance2_PlanTime");

                entity.HasComment("排班标准时间");

                entity.Property(e => e.Planid)
                    .HasColumnName("planid")
                    .HasComment("计划id");

                entity.Property(e => e.BTime)
                    .HasColumnName("bTime")
                    .HasComment("开始时间");

                entity.Property(e => e.DayTypeId)
                    .HasColumnName("DayTypeID")
                    .HasComment("日期类型id");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasComment("描述");

                entity.Property(e => e.ETime)
                    .HasColumnName("eTime")
                    .HasComment("结束时间");

                entity.Property(e => e.PlanName)
                    .HasMaxLength(16)
                    .HasColumnName("planName")
                    .HasComment("计划名");
            });

            modelBuilder.Entity<Attendance2Record>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__Attendan__3853EA802CB38284");

                entity.ToTable("Attendance2_Records");

                entity.Property(e => e.RecordId)
                    .HasColumnName("recordId")
                    .HasComment("序号");

                entity.Property(e => e.BAttTime)
                    .HasColumnName("bAttTime")
                    .HasComment("b上班考勤时间字符串-hh:mm:ss.000");

                entity.Property(e => e.BOffset)
                    .HasColumnName("bOffset")
                    .HasComment("b上班考勤偏移量（单位分钟：正为加班，负为早退）");

                entity.Property(e => e.BOffsetFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bOffsetFee");

                entity.Property(e => e.BTime)
                    .HasColumnName("bTime")
                    .HasComment("开始时间");

                entity.Property(e => e.ClassId)
                    .HasColumnName("classID")
                    .HasComment("方案班次ID");

                entity.Property(e => e.DayTypeId)
                    .HasColumnName("dayTypeID")
                    .HasComment("日期类型ID");

                entity.Property(e => e.EAttTime)
                    .HasColumnName("eAttTime")
                    .HasComment("e下班考勤时间字符串-hh:mm:ss.000");

                entity.Property(e => e.EOffset)
                    .HasColumnName("eOffset")
                    .HasComment("e下班考勤偏移量（单位分钟：正为加班，负为早退）");

                entity.Property(e => e.EOffsetFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("eOffsetFee");

                entity.Property(e => e.ETime)
                    .HasColumnName("eTime")
                    .HasComment("结束时间");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasComment("考勤机员工ID");

                entity.Property(e => e.PeriodNo)
                    .HasColumnName("periodNo")
                    .HasComment("周期内次序号");

                entity.Property(e => e.Planid)
                    .HasColumnName("planid")
                    .HasComment("计划ID");

                entity.Property(e => e.SDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sDate")
                    .HasComment("日期字符串:yyyy-MM-dd");
            });

            modelBuilder.Entity<Attendance2SchemeClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Attendance2_SchemeClass");

                entity.HasComment("班次信息");

                entity.Property(e => e.ClassDescription)
                    .HasMaxLength(255)
                    .HasColumnName("classDescription")
                    .HasComment("班次描述");

                entity.Property(e => e.ClassId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("classId")
                    .HasComment("班次id");

                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .HasColumnName("className")
                    .HasComment("班次名");

                entity.Property(e => e.ClassPeriods)
                    .HasColumnName("classPeriods")
                    .HasComment("班次内周期");

                entity.Property(e => e.Periods)
                    .HasColumnName("periods")
                    .HasComment("总排班数");
            });

            modelBuilder.Entity<DataPrivilege>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);
            });

            modelBuilder.Entity<FileAttachment>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FileExt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FileName).IsRequired();

                entity.Property(e => e.TenantCode).HasMaxLength(50);
            });

            modelBuilder.Entity<FrameworkGroup>(entity =>
            {
                entity.HasIndex(e => e.ParentId, "IX_FrameworkGroups_ParentId");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<FrameworkMenu>(entity =>
            {
                entity.HasIndex(e => e.ParentId, "IX_FrameworkMenus_ParentId");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<FrameworkRole>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);
            });

            modelBuilder.Entity<FrameworkTenant>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.Tcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TCode");

                entity.Property(e => e.Tdb).HasColumnName("TDb");

                entity.Property(e => e.TdbType).HasColumnName("TDbType");

                entity.Property(e => e.Tdomain)
                    .HasMaxLength(50)
                    .HasColumnName("TDomain");

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TName");

                entity.Property(e => e.UpdateBy).HasMaxLength(50);
            });

            modelBuilder.Entity<FrameworkUser>(entity =>
            {
                entity.HasIndex(e => e.PhotoId, "IX_FrameworkUsers_PhotoId");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .HasComment("地址");

                entity.Property(e => e.CellPhone).HasComment("手机");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasComment("邮箱");

                entity.Property(e => e.Gender).HasComment("性别");

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(30)
                    .HasComment("座机");

                entity.Property(e => e.Itcode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("ITCode");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasComment("邮编");

                entity.HasOne(d => d.Photo)
                    .WithMany(p => p.FrameworkUsers)
                    .HasForeignKey(d => d.PhotoId);
            });

            modelBuilder.Entity<FrameworkUserGroup>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FrameworkUserRole>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<FunctionPrivilege>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreateBy).HasMaxLength(50);

                entity.Property(e => e.TenantCode).HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportDataPrepareScript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_DataPrepareScript");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ReportId).HasColumnName("reportID");

                entity.Property(e => e.Script)
                    .HasMaxLength(128)
                    .HasColumnName("script")
                    .HasComment("脚本");

                entity.Property(e => e.ScriptOrder)
                    .HasColumnName("scriptOrder")
                    .HasComment("脚本执行顺序");

                entity.Property(e => e.ScriptTypeId)
                    .HasColumnName("scriptTypeID")
                    .HasComment("脚本类型ID");
            });

            modelBuilder.Entity<ReportMain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_Main");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .HasComment("描述");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.ReportId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("reportID");

                entity.Property(e => e.Title)
                    .HasMaxLength(128)
                    .HasComment("标题");
            });

            modelBuilder.Entity<ReportParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_Params");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(64)
                    .HasColumnName("defaultValue")
                    .HasComment("缺省值");

                entity.Property(e => e.Description)
                    .HasMaxLength(128)
                    .HasColumnName("description")
                    .HasComment("描述");

                entity.Property(e => e.Field)
                    .HasMaxLength(64)
                    .HasColumnName("field")
                    .HasComment("对应数据表字段");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.ParamOperator)
                    .HasMaxLength(16)
                    .HasColumnName("paramOperator")
                    .HasComment("操作符");

                entity.Property(e => e.ReportId).HasColumnName("reportID");
            });

            modelBuilder.Entity<ReportParamOperatorEnum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_ParamOperatorEnum");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Operator)
                    .HasMaxLength(64)
                    .HasColumnName("operator")
                    .HasComment("操作符");

                entity.Property(e => e.OperatorTips)
                    .HasMaxLength(128)
                    .HasColumnName("operatorTips")
                    .HasComment("提示");
            });

            modelBuilder.Entity<ReportPermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_Permissions");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ReportId).HasColumnName("reportID");

                entity.Property(e => e.UserId).HasColumnName("userID");
            });

            modelBuilder.Entity<ReportScriptParam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_ScriptParams");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ParamId).HasColumnName("paramID");

                entity.Property(e => e.ScriptId).HasColumnName("scriptID");
            });

            modelBuilder.Entity<ReportScriptTypeEnum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Report_ScriptTypeEnum");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Module)
                    .HasMaxLength(128)
                    .HasColumnName("module")
                    .HasComment("拼接参数的方法名");

                entity.Property(e => e.Name)
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<VAttendanceEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AttendanceEmployee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VAttendanceReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_AttendanceReport");

                entity.Property(e => e.BAttTime).HasColumnName("bAttTime");

                entity.Property(e => e.BOffset).HasColumnName("bOffset");

                entity.Property(e => e.BOffsetFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bOffsetFee");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.EAttTime).HasColumnName("eAttTime");

                entity.Property(e => e.EOffset).HasColumnName("eOffset");

                entity.Property(e => e.EOffsetFee)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("eOffsetFee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Event).HasColumnName("event");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecordId).HasColumnName("recordId");

                entity.Property(e => e.SDate)
                    .HasColumnType("datetime")
                    .HasColumnName("sDate");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
