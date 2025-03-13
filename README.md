# WinForms Chat Application

## Overview
This is a **WinForms-based chat application** consisting of **two separate projects**: a **server** and a **client**. The client connects to the server via **HTTP** and allows real-time messaging between multiple users.

---

![image](https://github.com/user-attachments/assets/48e58b41-d23b-4139-ada0-410a3a789042)


## Features
### **Client Application**
- **User-friendly Chat UI**: Messages appear in a structured chat format.
- **Real-time Messaging**: Messages are sent and received via **TCP sockets**.
- **Authentication**: Users must provide a username and key to connect.
- **Connection Management**:
  - Connects to the server via **IP and port**.
  - Displays connection status.
  - Allows users to **disconnect** at any time.
- **Keyboard Shortcuts**:
  - Press `Enter` to send messages.
  - Uses a menu for connection and disconnection options.
- **Auto-scrolling chat panel** for better user experience.

### **Server Application**
- **Handles multiple client connections** via `TcpListener`.
- **User Authentication**: Only users with the correct key can connect.
- **Message Broadcasting**: Messages from one client are sent to all connected clients.
- **Client List Management**:
  - Keeps track of connected clients.
  - Allows the admin to **disconnect users**.
  - Displays a real-time list of active users.
- **Logging System**:
  - Server logs all chat activity.
  - Messages appear with timestamps.
  - Supports log clearing for easy maintenance.
- **Server Control Panel**:
  - Start/Stop the server.
  - Broadcast messages to all users.
  - Disconnect all users at once.

---

## Installation & Usage
### **1. Running the Server**
1. **Compile and run** `ChatServer.exe`.
2. Enter the **IP address, port, and security key**.
3. Click **Start** to begin listening for client connections.
4. The log window will show new connections and messages.

### **2. Running the Client**
1. **Compile and run** `ChatClient.exe`.
2. Click **Connect** and enter:
   - Server IP Address
   - Port Number
   - Username
   - Security Key (must match server’s key)
3. Start chatting! Messages appear in real-time.
4. To **disconnect**, use the menu option or close the application.

---

## Technical Details
- **Developed with**: C# and **WinForms**.
- **Networking**: Uses `TcpClient` and `TcpListener` for server-client communication.
- **Serialization**: Messages are serialized using **JSON (`System.Text.Json`)**.
- **UI Handling**: Uses **Panels, Labels, and ListView** to manage messages.
- **Multithreading**: Server handles multiple clients using **asynchronous tasks (`Task.Run`)**.
- **Security**: Clients must authenticate with a **shared key** before sending messages.
