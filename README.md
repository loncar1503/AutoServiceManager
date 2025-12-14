# 🚗 Auto Service Management System

A desktop-based software solution designed to support and streamline everyday operations in a vehicle service workshop.  
This application provides a centralized system for managing customers, vehicles, service orders, spare parts, and invoices, with a strong focus on data consistency, clarity, and real-world usability.

---

## ✨ About the Project

In many auto service workshops, critical business data is still stored across notebooks, paper documents, or basic spreadsheets. Over time, this approach becomes inefficient and error-prone, especially when tracking service history, customer records, or issued invoices.

This project was created to address those issues by introducing a structured, database-driven application that digitalizes the complete service workflow. The goal is not only to store data, but to make it easily accessible, logically connected, and reliable over time.

---

## 🏗️ Architecture Overview

The system is implemented as a layered desktop application using the .NET platform.  
The user interface is built with Windows Forms, while business logic and data access are clearly separated into dedicated layers.

Entity Framework Core is used as the Object–Relational Mapper, allowing the application to work with a SQL Server database through strongly typed domain models and relationships. This approach improves maintainability and makes the system easier to extend with additional features in the future.

---

## ⚙️ Core Functionality

The application enables employees to register customers and their vehicles, ensuring that each vehicle maintains a complete service history.  
For every vehicle, service orders can be created and updated, containing performed work and used spare parts.

Once a service order is completed, the system automatically generates an invoice based on recorded data. Generated invoices and service documents can be exported as PDF files, allowing easy printing, sharing, and long-term archiving.

---

## 🗄️ Data Model

The data model follows real auto service workflows and is built around a relational structure.

Customers are linked to vehicles, vehicles are linked to service orders, and service orders consist of service tasks and spare parts. Invoices are generated directly from completed service orders, ensuring consistency between performed services and billed amounts.

Entity Framework Core manages relationships, constraints, and migrations, preserving data integrity across the entire system.

---
