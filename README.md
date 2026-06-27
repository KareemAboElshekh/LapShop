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

* **العمليات الخلفية (Backend):** C# | ASP.NET Core MVC
* **قاعدة البيانات (Database & ORM):** SQL Server | Entity Framework Core (Code-First)
* **الواجهات الأمامية (Frontend):** HTML5 | CSS3 | Bootstrap | JavaScript / jQuery
* **نظام الأمان (Security):** ASP.NET Core Identity (Authentication & Authorization)

---

## 🏗️ (Project Structure & Architecture)

تم تقسيم النظام إلى ثلاثة مشاريع أساسية مترابطة، يمتلك كل مشروع منها مسؤولية برمجية محددة:

### 1️⃣ (Domain Project)
* **دور المشروع:** هو قلب النظام والنواة الصلبة التي لا تعتمد على أي مشروع آخر. مسؤول عن تعريف الهيكل البنائي والبيانات الأساسية للمتجر.
* **محتوياته:**
  * **Entities (الكيانات):** ملفات الكود التي تمثل جداول قاعدة البيانات (مثل: `Item` للابتوبات، `Category` للأقسام، `Brand` للماركات، و `Order` للطلبات).
  * **Interfaces (الواجهات):** تحديد العقود البرمجية للعمليات (Repository Contracts) دون الدخول في تفاصيل التنفيذ.

### 2️⃣ مشروع الـ BL (Business Logic & Infrastructure Project)
* **دور المشروع:** هو المحرك الذكي للمتجر والمسؤول عن تنفيذ منطق العمل (Business Logic) وإدارة البيانات. يربط بين مشروع الدومين وقاعدة البيانات الفعلية.
* **محتوياته:**
  * **DbContext:** إعداد سياق الاتصال بقاعدة البيانات (SQL Server) وتعديل خصائص الجداول والعلاقات عبر الـ Fluent API.
  * **Repositories (المستودعات):** التطبيق العملي للواجهات، حيث يتم هنا كتابة استعلامات **LINQ** الفعلية لجلب البيانات، تعديلها، أو حذفها من قاعدة البيانات باستخدام EF Core.

### 3️⃣ (LapShop Web Project)
* **دور المشروع:** هو طبقة العرض (Presentation Layer) والواجهة النهائية للمتجر. مسؤول عن استقبال طلبات المستخدمين، معالجتها عبر الـ Controllers، وعرض البيانات بشكل بصري تفاعلي.
* **محتوياته:**
  * **Areas/Admin:** لوحة تحكم كاملة معزولة وخاصة بمدير النظام لإدارة المنتجات والمخزون.
  * **Controllers & Views:** استقبال طلبات الزوار وعرض صفحات الـ HTML الديناميكية باستخدام محرك واجهات Razor.
  * **wwwroot:** الملفات الثابتة للموقع كملفات التنسيق (CSS)، الأكواد التفاعلية (JS)، وصور المنتجات المرفوعة.

---

## 🔒 (Security Principles)

* **صلاحيات الوصول (Role-Based Access):** فصل كامل في الصلاحيات بين حساب المدير (Admin) وحساب العميل (Customer).
* **حماية البيانات:** تشفير كلمات المرور تلقائياً وحماية الاستمارات ضد هجمات تزوير الطلبات عبر المواقع (Anti-Forgery Tokens).
* **استعلامات آمنة:** استخدام ميزات EF Core البرمجية لحماية قاعدة البيانات من ثغرات الحقن (SQL Injection).

---
