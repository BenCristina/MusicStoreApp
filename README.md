# MusicStoreApp

A Windows Forms application for a music store, built with .NET 9.0 (Windows only). It supports user and admin workflows: browsing products, managing a shopping cart, favorites, placing orders, and an admin panel for managing users, products, and orders. Data is backed by Microsoft SQL Server.

## Table of Contents
- Features
- Tech Stack
- Project Structure
- Getting Started
  - Prerequisites
  - Restore & Build
  - Run
- Configuration
  - Database Connection String
- Usage
  - User Flow
  - Admin Flow
- Architecture Overview
- Troubleshooting
- Roadmap / TODO
- Contributing
- License

## Features

User:
- Registration and login
- Browse products (CD, Vinyl, etc.)
- View product details
- Add to shopping cart
- Checkout flow (in progress)
- Manage favorites (mapping exists, persistence WIP)
- View order history (read from DB)

Admin:
- Login as admin
- Manage products (add, edit, delete)
- Manage orders
- Manage users (edit, update, reset password)

General:
- SQL Server–backed persistence
- Centralized data manager for in-memory state
- Windows Forms UI with separate Admin and User areas

## Tech Stack

- Language: C# 13.0
- Framework: .NET 9.0 (Windows)
- UI: Windows Forms
- Database: Microsoft SQL Server (Microsoft.Data.SqlClient)
- Packages:
  - Microsoft.Data.SqlClient
  - Microsoft.Data.SqlClient.SNI.runtime
  - Microsoft.SqlServer.Server

## Project Structure

- Program.cs — Application entry point
- MusicStoreApp.csproj — Project configuration
- gui/ — Windows Forms UI
  - LoginWindow, RegistrationWindow
  - user/ — User windows (Main, Cart, Checkout, Favorites, etc.)
  - admin/ — Admin windows (Panel, Manage Products/Orders/Users, etc.)
- data/ — Data layer and models
  - DatabaseHandler.cs — DB access, queries, data loading, auth
  - DataManager.cs — In-memory state (products, users, orders, cart, favorites)
  - Models: User, Product, Orders, Genre, ProductType, etc.
- images/ — App images (if used)
- data/Todo.cs — Open tasks list (if used for notes)

## Getting Started

### Prerequisites
- Windows 10/11
- .NET SDK 9.0 (Windows)
- Visual Studio 2022 (latest) or JetBrains Rider, or CLI
- Access to a Microsoft SQL Server instance (the project currently references a remote connection string in `data/DatabaseHandler.cs`)
