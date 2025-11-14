# TODO 待辦事項系統

這是一個使用 .NET 9 MVC 框架與 In-Memory 資料庫建立的待辦事項管理系統。

## 技術架構

- **.NET 9.0** - 最新的 .NET 框架
- **ASP.NET Core MVC** - Model-View-Controller 架構模式
- **Entity Framework Core 9.0** - ORM 資料存取框架
- **In-Memory Database** - 記憶體內資料庫（適合開發與測試）
- **Bootstrap 5** - 響應式前端框架
- **Bootstrap Icons** - 圖示庫

## 功能特色

### ✅ 完整的 CRUD 操作
- **新增 (Create)** - 建立新的待辦事項
- **讀取 (Read)** - 檢視所有待辦事項清單
- **更新 (Update)** - 編輯現有的待辦事項
- **刪除 (Delete)** - 刪除不需要的待辦事項

### ✅ 狀態管理
- 快速切換完成/未完成狀態
- 自動追蹤建立時間
- 自動追蹤完成時間
- 即時統計顯示（總計、已完成、未完成）

### ✅ 使用者介面
- 繁體中文介面
- 響應式設計（支援各種裝置）
- 直覺的操作流程
- 視覺化狀態指示
- Bootstrap Icons 圖示支援

### ✅ 資料驗證
- 標題欄位必填驗證
- 欄位長度限制
- 防止 CSRF 攻擊

## 專案結構

```
TodoApp/
├── Controllers/
│   ├── TodoController.cs       # 待辦事項控制器
│   └── HomeController.cs       # 首頁控制器
├── Data/
│   └── TodoDbContext.cs        # 資料庫上下文
├── Models/
│   ├── TodoItem.cs             # 待辦事項模型
│   └── ErrorViewModel.cs       # 錯誤視圖模型
├── Views/
│   ├── Todo/
│   │   ├── Index.cshtml        # 清單頁面
│   │   ├── Create.cshtml       # 新增頁面
│   │   ├── Edit.cshtml         # 編輯頁面
│   │   └── Delete.cshtml       # 刪除確認頁面
│   └── Shared/
│       └── _Layout.cshtml      # 共用版面配置
├── wwwroot/                    # 靜態資源
├── Program.cs                  # 應用程式進入點
└── TodoApp.csproj              # 專案檔案
```

## 如何執行

### 前置需求
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) 或更新版本

### 步驟

1. **還原相依套件**
   ```bash
   dotnet restore
   ```

2. **建置專案**
   ```bash
   dotnet build
   ```

3. **執行應用程式**
   ```bash
   dotnet run
   ```

4. **開啟瀏覽器**
   - 預設網址：`https://localhost:5001` 或 `http://localhost:5000`
   - 或查看終端機輸出的實際網址

## 資料模型

### TodoItem

| 欄位 | 型別 | 說明 |
|------|------|------|
| Id | int | 主鍵（自動產生）|
| Title | string | 標題（必填，最長 200 字元）|
| Description | string? | 描述（選填，最長 1000 字元）|
| IsCompleted | bool | 是否已完成 |
| CreatedAt | DateTime | 建立時間 |
| CompletedAt | DateTime? | 完成時間 |

## 種子資料

應用程式啟動時會自動載入三筆範例資料：
1. 學習 .NET 9（未完成）
2. 建立 MVC 專案（已完成）
3. 實作 TODO 功能（未完成）

## In-Memory 資料庫說明

此專案使用 Entity Framework Core 的 In-Memory 資料庫提供者：

### 優點
- ✅ 不需要安裝資料庫伺服器
- ✅ 快速啟動與測試
- ✅ 適合開發與展示
- ✅ 零設定需求

### 限制
- ⚠️ 資料只存在於記憶體中
- ⚠️ 應用程式重啟後資料會遺失
- ⚠️ 不適合正式環境使用

### 切換到持久化資料庫

如果需要將資料永久儲存，可以修改 `Program.cs` 中的資料庫設定，改用 SQL Server、PostgreSQL 或 SQLite：

```csharp
// 改用 SQLite
builder.Services.AddDbContext<TodoDbContext>(options =>
    options.UseSqlite("Data Source=todo.db"));

// 改用 SQL Server
builder.Services.AddDbContext<TodoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

## 開發資訊

- **開發框架**: .NET 9.0
- **專案類型**: ASP.NET Core Web App (Model-View-Controller)
- **目標框架**: net9.0
- **語言版本**: C# 12

## 授權

此專案為示範專案，可自由使用與修改。

## 相關資源

- [.NET 9 文件](https://learn.microsoft.com/dotnet/core/whats-new/dotnet-9)
- [ASP.NET Core MVC](https://learn.microsoft.com/aspnet/core/mvc/overview)
- [Entity Framework Core](https://learn.microsoft.com/ef/core/)
- [Bootstrap 5](https://getbootstrap.com/)
