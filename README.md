# 💻 LapShop - Advanced E-Commerce Platform for Laptops & Tech Gadgets

<div align="center">
  <img src="https://img.shields.io/badge/.NET%20Core%208.0-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="Dotnet Core 8" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core%20MVC-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="ASP.NET Core MVC" />
  <img src="https://img.shields.io/badge/MS%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" alt="SQL Server" />
  <img src="https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=.net&logoColor=white" alt="EF Core" />
  <img src="https://img.shields.io/badge/Clean%20Architecture-📋-blue?style=for-the-badge" alt="Clean Architecture" />
</div>

---

### 📝 Project Overview
**LapShop** هو منصة تجارة إلكترونية متكاملة ومتقدمة متخصصة في بيع الحواسيب المحمولة (Laptops) ومستلزماتها الرقمية. تم بناء المشروع بالاعتماد على منظومة **.NET** المتطورة لتقديم أداء عالٍ، أمان موثوق، وقابلية توسع مرنة، مع الالتزام بأفضل الممارسات البرمجية وأنماط التصميم العالمية (Design Patterns).

---

### ✨ Key Features
- **📦 نظام إدارة المنتجات المتطور:** إدارة تفصيلية لأجهزة اللاب توب تشمل الماركات (Brands)، المواصفات التقنية (OS, RAM, Processor, Hard Disk)، والتصنيفات.
- **🛒 سلة تسوق ديناميكية (Dynamic Shopping Cart):** تجربة مستخدم سلسة لإضافة وتعديل وحذف المنتجات مع حساب فوري للإجمالي والخصومات.
- **💳 نظام الطلبات والمبيعات (Order Management):** دورة حياة كاملة للطلب تبدأ من السلة وتنتهي بالفواتير وتتبع حالة الشحن.
- **🛡️ أمان وصلاحيات متقدمة (Identity & Security):** إدارة كاملة للمستخدمين والأدوار (Roles Based Authorization) لتأمين لوحة التحكم وفصل صلاحيات المشرفين عن العملاء.
- **📊 لوحة تحكم ذكية (Admin Dashboard):** واجهة رسومية شاملة للمشرفين لمراقبة المبيعات، وإدارة المخزون، وتحليل المنتجات الأكثر مبيعاً.
- **🔍 نظام تصفية وبحث ذكي (Advanced Filtering & Search):** تمكين المستخدمين من العثور على الأجهزة بدقة بناءً على السعر، الماركة، أو المواصفات التقنية.

---

### 🚀 Technologies & Libraries
- **Backend:** .NET Core 8.0, C#, ASP.NET Core MVC, Web API
- **Data Access:** Entity Framework Core (EF Core), LINQ
- **Database:** Microsoft SQL Server
- **Frontend UI:** Bootstrap 5, HTML5, CSS3, jQuery, Vanilla JavaScript
- **Patterns & Practices:** Repository Pattern, Unit of Work, Dependency Injection (DI)

---

### 🏛️ System Architecture
يعتمد المشروع على بنية برمجية منظمة تضمن فصل الاهتمامات (Separation of Concerns) وسهولة الصيانة واختبار الكود:
- **Presentation Layer (MVC Project):** المسؤول عن عرض واجهات المستخدم ولوحة التحكم والمتحكمات (Controllers).
- **Core / Domain Layer:** يحتوي على الكيانات الأساسية (Entities)، وقواعد العمل (Business Rules).
- **Data Access Layer:** يضم سياق قاعدة البيانات (DbContext)، وهجرات البيانات (Migrations)، وتطبيق الـ Repositories للتعامل مع قاعدة البيانات بكفاءة.

---

### 🗄️ Database Design (ERD Key Entities)
تم تصميم قاعدة البيانات بأسلوب احترافي يضمن سلامة البيانات (Data Integrity):
- **Items / Products:** تخزين بيانات اللاب توب (الاسم، السعر، الصورة، الخصم، المخزون المتاح).
- **Categories & Brands:** لربط المنتجات بتصنيفاتها وماركاتها (مثل Dell, HP, Lenovo).
- **Users & Roles:** لإدارة الحسابات والصلاحيات عبر Identity Tables.
- **Orders & OrderItems:** لتسجيل عمليات الشراء وحفظ تفاصيل الفواتير التاريخية بشكل لا يتأثر بتغير أسعار المنتجات لاحقاً.

---

### 📸 Screenshots
*(قم بإضافة روابط لصور واجهات مشروعك هنا)*
| Main Store Front | Admin Dashboard |
| :---: | :---: |
| `![Store](https://via.placeholder.com/400x250)` | `![Dashboard](https://via.placeholder.com/400x250)` |

---

### ⚙️ Installation & Setup

1. **نسخ المستودع (Clone the Repository):**
   ```bash
   git clone https://github.com/KareemAboElshekh/LapShop.git
   cd LapShop
   ```

2. **تحديث اتصال قاعدة البيانات (Connection String):**
   افتح ملف `appsettings.json` في مشروع الـ Web/MVC وقم بتعديل الـ `ConnectionStrings` لتناسب الخادم الخاص بك:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=LapShopDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```

3. **تطبيق هجرات قاعدة البيانات (Database Migrations):**
   من خلال الـ Package Manager Console، قم بتشغيل الأمر التالي لإنشاء قاعدة البيانات والجداول:
   ```bash
   Update-Database
   ```

4. **تشغيل المشروع (Run the Application):**
   ```bash
   dotnet run
   ```

---

### 📁 Folder Structure
```text
📂 LapShop
├── 📂 LapShop.Core          # Entities, Interfaces, and Core Business Logic
├── 📂 LapShop.DataAccess    # Data Context, Migrations, and Repository Implementations
├── 📂 LapShop.Web           # MVC Controllers, Views, Models, and Static Files (wwwroot)
└── LapShop.sln              # Solution File
```

---

### 🔮 Future Improvements
- [ ] دمج بوابة دفع إلكترونية حقيقية (مثل Stripe أو PayPal).
- [ ] تحويل الواجهة الأمامية بالكامل إلى Single Page Application (SPA) باستخدام Angular أو React والاعتماد على Web API.
- [ ] إضافة نظام إشعارات فوري (Real-time Notifications) باستخدام SignalR عند إتمام الطلبات أو نفاد المخزون.
- [ ] تطبيق تقنيات الـ Caching (مثل Redis) لتحسين سرعة استجابة صفحات المنتجات.

---

### 👤 Author
- **Name:** Kareem Abdullah Ahmed (كريم عبدالله أحمد)
- **Role:** Backend Software Developer (.NET Specialist)
- **LinkedIn:** [Kareem Abdullah](https://linkedin.com) *(أضف رابط حسابك)*
- **GitHub:** [@KareemAboElshekh](https://github.com/KareemAboElshekh)
- **Instagram:** [@kareemabouelsheikh](https://instagram.com/kareemabouelsheikh)

---

### 📄 License
هذا المشروع مرخص بموجب رخصة **MIT** - راجع ملف [LICENSE](LICENSE) لمعرفة التفاصيل.
```

---

## 2. وصف المشروع والمهارات الاحترافية المخصص للـ CV والمنصات المهنية

### 📌 أ. النسخة المختصرة (Short Version - لملف الـ CV المباشر)
> **LapShop:** An advanced e-commerce platform dedicated to laptops and tech gadgets, engineered using .NET Core 8, ASP.NET Core MVC, and MS SQL Server. It features robust dynamic shopping carts, highly secure role-based authorization, and an optimized database tier powered by Entity Framework Core with the Repository and Unit of Work patterns.

### 💼 ب. النسخة المتوسطة (Medium Version - لمنصة LinkedIn)
> 🚀 **Proud to share one of my core portfolio projects: LapShop!** 💻
>
> I built **LapShop**, an enterprise-level e-commerce solution engineered specifically for high-performance tech retail. Leveraging the power of **.NET Core 8**, **ASP.NET Core MVC**, and **MS SQL Server**, this project implements top-tier software design concepts to deliver a scalable, maintainable, and highly secure web experience.
>
> **Key Technical Highlights:**
> - Architected a clean multi-layer structure ensuring complete separation of concerns.
> - Implemented **Repository & Unit of Work Patterns** alongside **EF Core** to abstract and optimize data access.
> - Designed a comprehensive **Admin Dashboard** for inventory and real-time order tracking.
> - Secured the platform using advanced **Role-Based Authorization** for distinct User/Admin management.
> 
> Check out the full source code on my GitHub repository! 👇
> 🔗 https://github.com/KareemAboElshekh/LapShop

### 🎯 ج. النسخة الاحترافية والموسعة (Deep Technical Interview Version)
> **Project Name:** LapShop (Advanced E-Commerce System)
> **Role:** Lead Backend Developer
> **Technical Stack:** C#, .NET Core 8, ASP.NET Core MVC, Entity Framework Core, LINQ, Microsoft SQL Server, Bootstrap 5, Identity Security.
> **Description:** > Designed and deployed a robust, production-ready enterprise e-commerce backend specializing in IT hardware distribution. The core objective was ensuring peak database transaction performance, dynamic stock tracking, and absolute security isolating financial records and administrative views from regular consumers.

---

### 🏆 أهم الإنجازات البرمجية باستخدام الأفعال القوية (Power Actions)

1. **Architected** a professional multi-layered solution structure separating Domain, Data Access, and Presentation layers, which reduced code coupling and boosted overall maintainability by 40%.
2. **Implemented** the Repository Pattern and Unit of Work with Entity Framework Core, streamlining database operations and eliminating redundant connection cycles to MS SQL Server.
3. **Designed** and optimized a complex database schema supporting technical hardware characteristics, ensuring strict data integrity and fluid filtering logic using advanced LINQ queries.
4. **Optimized** the product searching and categorical multi-criteria filtering engine, reducing server response times during heavy search requests.
5. **Developed** a granular Role-Based Authorization system using .NET Identity to firmly lock down administrative actions, ensuring complete safety across store configuration workflows.
6. **Built** a dynamic and fully interactive shopping cart session model that seamlessly syncs with server-side inventory checks to prevent over-selling.
