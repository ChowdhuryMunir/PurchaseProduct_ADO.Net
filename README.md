# Purchase Product Management System

This repository contains a Windows Forms application developed in C# using ADO.NET, designed for managing product purchases. The application employs a master-detail approach and is connected to a Microsoft SQL Server database.

## Features

- **Master-Detail Interface**: Provides a user-friendly interface for managing products and their purchase details. 
- **Product Management**: Add, update, and delete product records.
- **Purchase Tracking**: Track and manage purchase transactions with details linked to specific products.
- **Data Binding**: Utilizes ADO.NET for data access and binding to ensure seamless interaction with the SQL Server database.
- **SQL Server Integration**: Fully integrated with a SQL Server database for persistent data storage and retrieval.

## Project Structure

- **Windows Forms Application**: The main project is a C# Windows Forms application that provides a graphical interface for interacting with the database.
- **ADO.NET Implementation**: Uses ADO.NET for data access and manipulation.
- **Master-Detail Form**: Includes forms that allow users to view and manage product details and associated purchase records.

## Getting Started

### Prerequisites

- Microsoft Visual Studio
- Microsoft SQL Server
- .NET Framework (version specified in the project)

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ChowdhuryMunir/PurchaseProduct_ADO.Net.git
   cd PurchaseProduct_ADO.Net
   ```

2. **Open the Project**
   - Open the solution file (`.sln`) in Microsoft Visual Studio.

3. **Configure the Database**
   - Ensure that your SQL Server instance is running.
   - Update the connection string in the application to match your SQL Server configuration.

4. **Build and Run**
   - Build the project in Visual Studio.
   - Run the application to start managing product purchases.

## Usage

- **Product Management**: Use the Product form to add new products, edit existing ones, or remove products.
- **Purchase Records**: Use the Purchase form to add new purchase transactions and view detailed records associated with each product.

## Contributing

Contributions to enhance or fix the application are welcome. Please submit a pull request with your proposed changes, and include relevant details about your updates.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.

## Contact

For any questions or support, please contact the repository owner at [ChowdhuryMunir](https://github.com/ChowdhuryMunir).
