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

## 🚀 (Key Features)

### 👤 (Client-Side)
* **تصفح ذكي:** استعراض الأجهزة وتصفيتها وفلترتها حسب الماركة، السعر، والتصنيف.
* **سلة المشتريات:** إضافة، تعديل، وحذف المنتجات ديناميكياً قبل تأكيد الطلب.
* **إدارة الحسابات:** نظام تسجيل دخول وإنشاء حساب آمن بالكامل للمشترين.

### 📊 (Admin Dashboard)
* **إدارة المنتجات:** إضافة الأجهزة، تعديل الأسعار والمواصفات، وحذفها.
* **إدارة التصنيفات والماركات:** تنظيم المنتجات تحت فئات (Gaming, Business) وماركات (Dell, Lenovo).
* **معرض الصور:** دعم رفع وإدارة صور متعددة لكل جهاز لابتوب.

---

## 🛠️ (Tech Stack)

* ** (Backend):** C# | ASP.NET Core MVC
* ** (Database & ORM):** SQL Server | Entity Framework Core (Code-First)
* ** (Frontend):** HTML5 | CSS3 | Bootstrap | JavaScript / jQuery
* ** (Security):** ASP.NET Core Identity (Authentication & Authorization)

---

## 🏗️  (Project Structure)

تم تقسيم الأكواد داخل المشروع بناءً على المعايير الاحترافية إلى ثلاث طبقات أساسية:

### 1️⃣ LapShop.Core (طبقة البيانات والعمليات)
* **Entities:** تحتوي على موديلات قاعدة البيانات (مثل: `Item`, `Category`, `Brand`, `Order`) والتي تُحدد بنية وجداول المتجر.
* **Interfaces:** تحتوي على العقود والواجهات البرمجية (مثل: `IItemRepository`) لتطبيق نمط الـ **Repository Pattern** لضمان مرونة الكود.

### 2️⃣ LapShop.Infrastructure (طبقة البنية التحتية)
* **DbContext & Fluent API:** إعداد سياق قاعدة البيانات وتحديد العلاقات بين الجداول (مثل ربط اللابتوب بماركته وقسمه) وحماية الحقول.
* **Repositories:** تحتوي على كود الاستعلام الفعلي من قاعدة البيانات باستخدام **LINQ** و **EF Core**.

### 3️⃣ LapShop.Web (طبقة العرض والواجهات)
* **Areas/Admin:** لوحة تحكم كاملة معزولة وخاصة بمدير النظام فقط لإدارة المتجر والمنتجات.
* **Controllers & Views:** استقبال طلبات المستخدمين وعرض الصفحات بشكل ديناميكي تفاعلي عبر صفحات Razor.

---

## 🔒 (Security Principles)

* **صلاحيات الوصول (Role-Based Access):** فصل كامل في الصلاحيات بين حساب المدير (Admin) وحساب العميل (Customer).
* **حماية البيانات:** تشفير كلمات المرور تلقائياً وحماية الاستمارات ضد هجمات تزوير الطلبات عبر المواقع (Anti-Forgery Tokens).
* **استعلامات آمنة:** استخدام ميزات EF Core البرمجية لحماية قاعدة البيانات من ثغرات الحقن (SQL Injection).

---
