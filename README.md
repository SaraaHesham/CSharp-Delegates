# CSharp-Delegates

## 📌 Overview
This repository contains three C# projects that demonstrate advanced concepts of **Delegates, Anonymous Methods, Lambda Expressions, Multicast Delegates, Func/Action/Predicate, Events, and Covariance/Contravariance**. Each project showcases how these concepts can be applied to real-world applications.

---

## 📚 Student Grading System
### Description
The **Student Grading System** is a console-based application built in **C#** to evaluate student performance using delegates. The project showcases the practical use of **Func, Action, and Predicate** to process and analyze student grades efficiently.

### 🎯 Features
- **Student Data Management:** Add students and enter their grades.
- **Grade Calculation:** Compute students' average grades dynamically.
- **Pass/Fail Evaluation:** Determine students' results based on predefined grading criteria.
- **Flexible Delegates:** Uses **Func, Action, and Predicate** for efficient grade processing.
- **Console-Based Interface:** Simple and interactive user experience.

### 🛠️ Technologies Used
- **C#**
- **.NET Console Application**
- **Delegates (Func, Action, Predicate)**

### 📂 Project Structure
- `Program.cs` – Main entry point of the application.
- `Student.cs` – Represents student data including name, grades.
- `GradingSystem.cs` – Implements delegate-based grade processing logic.

---

## 🌡️ Temperature Sensor System  
### Description  
The **Temperature Sensor System** is a real-time console-based application designed to simulate a temperature monitoring system. It is implemented using two different architectural approaches:  

- **Observer Pattern (Initial Version)** – Uses events and delegates for real-time temperature updates.
- **Publish/Subscribe Pattern (Refactored Version)** – Introduces a broker to decouple publishers and subscribers for improved flexibility.  

This system enables users to set temperature thresholds, monitor changes, and trigger alarms when the temperature exceeds predefined limits.  

### 🎯 Features 
- **Real-Time Temperature Monitoring:** Users can input and track temperature changes dynamically.  
- **Alarm Notification System:** Automatically triggers an alert if the temperature exceeds a user-defined threshold.  
- **Live Temperature Display:** Continuously updates and displays the current temperature.  
- **Event-Driven Architecture:**  
  - **Observer Pattern (Initial Version):** Uses events and delegates for real-time updates.  
  - **Publish/Subscribe Pattern (Refactored Version):** Implements a broker for decoupled messaging and flexible event handling.  
- **User-Friendly Console Interface:** Simple and interactive experience for setting and monitoring temperature values.  

### 🛠️ Technologies Used  
- **C#**  
- **.NET Console Application**  
- **Events & Delegates (Old Version - Observer Pattern)**  
- **Publish/Subscribe Pattern (New Version - Refactored)**  

### 🗂 Project Structure  

#### **Observer Pattern Version (Initial Implementation)**  
- `Program.cs` – Main entry point of the application.  
- `Sensor.cs` – Represents the temperature sensor and raises events when temperature changes.  
- `TempArgs.cs` – Custom event arguments to pass temperature values.  
- `Display.cs` – Displays real-time temperature updates.  
- `Alarm.cs` – Triggers an alert when the temperature exceeds the threshold.  

#### **Publish/Subscribe Version (Refactored Implementation)**  
- `Program.cs` – Main entry point; initializes components and handles user interaction.  
- `Sensor.cs` – Publishes temperature updates to the broker instead of raising direct events.  
- `TempArgs.cs` – Stores temperature values passed between components.  
- `Display.cs` – Subscribes to temperature updates and displays them.  
- `Alarm.cs` – Subscribes to temperature updates and triggers an alert when necessary.  
- `Broker.cs` – **Acts as a central messaging hub that manages event subscriptions and dispatches temperature updates to all subscribers, implementing a decoupled Publish/Subscribe architecture.**  

---

## 📖 Topics Covered  

### **Observer Pattern (Before Update) & Publish/Subscribe Pattern (After Update)**  
- Implementing a **decoupled event-driven architecture**.  

### **Delegates in C#**  
- **Func:** Used to calculate student averages dynamically.  
- **Predicate:** Determines whether a student passes or fails.  
- **Action:** Displays formatted student results.  

### **Events & Event Handling (Before Update)**  
- **EventHandler:** Used to manage temperature changes.  
- **Custom Event Arguments:** Passing temperature values through events.  

### **Publish/Subscribe Pattern (After Update)**  
- **Broker-based message distribution:** Decoupling publishers and subscribers.  
- **Flexible and extensible subscription model.**  

### **Console Application Development**  
- Creating **user-friendly CLI applications** with real-time updates.  

---

## 🎓 Learning Journey
This project is part of my **C# and .NET learning journey**, focusing on **delegates and console applications**. Through this project, I have:

- Strengthened my understanding of **delegates** and their real-world applications.
- Implemented efficient grading logic using **functional programming** concepts.
- Improved **code structure, modularity, and reusability**.

This project is a practical exercise in applying **C# delegates and functional programming** to a real-world scenario.

---

## 📬 Contact  
For any questions, suggestions, or collaboration opportunities, feel free to connect with me on **[LinkedIn](https://www.linkedin.com/in/sarahesham/)**.

---

**💡 Developed as a learning project to explore and implement C# Delegates effectively.**
