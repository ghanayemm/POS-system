# 🧾 Smart POS

**Smart POS** is a desktop-based Point of Sale (POS) system built specifically for small to medium-sized restaurants. The application provides essential tools for managing products, printing invoices, handling user permissions, and generating reports — all through a clean and responsive Windows Forms interface.

> ⚠️ **Note:** This application is currently under development and is not yet production-ready.

---

## 🚀 Key Features

- 🖨️ **Invoice Printing**  
  Instantly generate and print customer invoices with accurate transaction details.

- 📦 **Product Management**  
  Add, update, and organize restaurant items with real-time stock control.

- 🔐 **User Roles & Permissions**  
  Define user roles (e.g., Admin, Cashier) with secure access levels to protect sensitive operations.

- 📊 **Reports**  
  Generate daily, weekly, or monthly reports for sales and inventory performance.

---

## 🛠️ Tech Stack

- **Language**: C#
- **Framework**: Windows Forms (.NET)
- **Database**: SQL Server
- **Runtime**: .NET Core / .NET Framework (`dotnet run`)

---

## 💻 How to Run the Project Locally

### Prerequisites

- .NET SDK installed  
- SQL Server instance running

> ℹ️ You will need to configure the database connection by updating `App.config` or `appsettings.json` with your local SQL Server details.
1. **Clone the repository**
   ```bash
   git clone https://github.com/ghanayemm/smart-pos.git
   cd smart-pos

Configure the database connection

Open App.config or appsettings.json file and update the SQL Server connection string to match your local server configuration.

Create the database schema

Set up the required tables in SQL Server manually, or use Entity Framework migrations if supported (future feature).

Run the application

Use the following command:

bash

dotnet run
   
---

## 🧪 Demo Credentials

You can use the following credentials to log in as an administrator:

- **Username**: `admin`  
- **Password**: `admin123`

---

## 📌 Project Scope

Smart POS is tailored for the needs of restaurants and food service businesses. The current version focuses on core POS features, with potential to expand to:

- Barcode scanner integration  
- Touchscreen optimization  
- Multi-branch support  
- Customer loyalty and rewards system  
- Mobile version

---

## 👨‍💻 Developer

Developed by [Mohammad Ghanayem](https://github.com/ghanayemm)

- 💼 [LinkedIn Profile](https://www.linkedin.com/in/mohammed-ghanayem)

---

## 📄 License

This project is open source and licensed under the **MIT License**.  
You are free to use, modify, and distribute it for personal or commercial purposes.

---

## 🤝 Contributing

Contributions are welcome!  
To contribute:

1. Fork the repository  
2. Create a new feature branch  
3. Commit your changes  
4. Submit a pull request

For major changes, please open an issue first to discuss what you would like to improve.

---

## 📬 Contact

For questions, feedback, or ideas, feel free to connect on [LinkedIn](https://www.linkedin.com/in/mohammed-ghanayem) or open an issue on GitHub.


