# 💻 LapShop - متجر إلكتروني لأجهزة اللابتوب

تطبيق ويب متكامل (E-commerce Platform) متخصص في عرض وبيع أجهزة اللابتوب ومستلزماتها. تم بناء المشروع باستخدام تقنيات **.NET** الحديثة مع اتباع أفضل الممارسات في التصميم وهندسة البرمجيات لفصل المهام وتسهيل التوسع مستقبلاً.

---

## 🚀 المميزات الرئيسية (Features)

* **إدارة المنتجات:** تصفح، تصفية (Filtering)، وعرض تفاصيل أجهزة اللابتوب والمواصفات التقنية.
* **نظام عربة التسوق:** إضافة الأجهزة إلى السلة، تعديل الكميات، وحساب الإجمالي تلقائياً.
* **لوحة تحكم الإدارة (Admin Dashboard):** لإدارة المنتجات، الأقسام، والمبيعات بسهولة.
* **تصميم متجاوب (Responsive Design):** واجهة مستخدم مريحة ومتوافقة مع جميع الشاشات (الهواتف، الأجهزة اللوحية، والحواسب).

---

## 🛠 التكنولوجيات المستخدمة (Tech Stack)

* **Backend:** .NET Core / ASP.NET Core MVC
* **Database:** Entity Framework Core
* **Frontend:** HTML5, CSS3, SCSS, JavaScript, Bootstrap
* **Architecture:** Domain-Driven Design (DDD) / Layered Architecture

---

## 📂 بنية المشروع (Project Structure)

تم تنظيم المشروع ليفصل بين كود الواجهات ومنطق العمل:
* **LapShop (Main Web Project):** يحتوي على المتحكمات (Controllers)، طرق العرض (Views)، والملفات الثابتة (CSS/JS).
* **Domain / Core Layers:** تحتوي على النماذج الأساسية (Models) ومنطق العمل (Business Logic) لضمان عزل البيانات.

---

## ⚙️ تشغيل المشروع محلياً (Setup & Installation)

لشغيل المشروع على جهازك الشخصي، اتبع الخطوات التالية:

### المتطلبات المسبقة:
* تثبيت حزمة [.NET SDK](https://dotnet.microsoft.com/download) (الإصدار المتوافق مع المشروع).
* تثبيت برنامج [Visual Studio](https://visualstudio.microsoft.com/) أو VS Code.

### الخطوات:
1. **استنساخ المستودع (Clone):**
   ```bash
   git clone [https://github.com/KareemAboElshekh/LapShop.git](https://github.com/KareemAboElshekh/LapShop.git)
