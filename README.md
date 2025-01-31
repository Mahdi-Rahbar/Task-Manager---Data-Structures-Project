
# Task Manager (Data Structures Final Project)

## 📌 Introduction  
This **Task Manager** project is the final assignment for the **Data Structures** course. The main focus is implementing a **task management system** using **trees** to handle tasks and subtasks efficiently.  

The application is built using **C#** and **Windows Forms**.  

## 🔧 Features  
- **Task Creation**: Users can add tasks and assign subtasks to them.  
- **Task Hierarchy**: Each task can have multiple subtasks, managed using a tree structure.  
- **Task Status Management**:  
  - Initially, all tasks are marked as **To Do**.  
  - A task is marked **Done** only when all its subtasks are completed.  
- **Deadline Tracking**: Tasks have a **deadline** using a `DateTimePicker` component.  
- **User Interface**:  
  - A **main menu** with two options:  
    1. **Add Task** – Opens a form to create tasks and subtasks.  
    2. **Show Tasks** – Displays tasks and subtasks in two `DataGridView` controls.  

## 🛠️ Technologies  
- **Language**: C#  
- **Framework**: Windows Forms  
- **Data Structure**: Tree (for task-subtask relationships)  

## 📥 Installation  
1. Clone the repository:  
   ```sh
   git clone https://github.com/your-repo/task-manager.git
   cd task-manager
   ```
2. Open the project in **Visual Studio**.  
3. Build and run the project.  

## 🚀 Usage  

### **Main Menu**  
Upon launching the application, the **main menu** appears with a **background image** related to task management and two buttons:  

1. **Add Task**:  
   - Opens a **task creation form** with the following fields:  
     - **Name**: Task or subtask name.  
     - **Description**: Details about the task/subtask.  
     - **Deadline**: Task/subtask due date.  
     - **Parent Task**: Assigns a task as a subtask of an existing task.  
   - Clicking **Create** adds the task or subtask.  

2. **Show Tasks**:  
   - Opens a **task display form** containing two `DataGridView` controls:  
     - **Top Grid**: Lists main tasks.  
     - **Bottom Grid**: Shows subtasks of the selected main task.  
   - Columns include **Name, Description, Deadline, and Status**.  
   - A **Done** button updates task status:  
     - If a subtask is marked **Done**, the main task remains **To Do** until all its subtasks are **Done**.  
     - Once all subtasks are **Done**, the main task is automatically marked **Done**.  

## 📸 Screenshots
Here are some screenshots from the project:

![Main Menu](https://github.com/Mahdi-Rahbar/Task-Manager---Data-Structures-Project/blob/main/screenshots/Screenshot%202025-01-31%20164417.png?raw=true.png)
![Add Task](https://github.com/Mahdi-Rahbar/Task-Manager---Data-Structures-Project/blob/main/screenshots/Screenshot%202025-01-31%20164530.png?raw=true.png)
![Add Subtask](https://github.com/Mahdi-Rahbar/Task-Manager---Data-Structures-Project/blob/main/screenshots/Screenshot%202025-01-31%20164618.png?raw=true.png)
![Show Task](https://github.com/Mahdi-Rahbar/Task-Manager---Data-Structures-Project/blob/main/screenshots/Screenshot%202025-01-31%20164639.png?raw=true.png)
![Show Subtask](https://github.com/Mahdi-Rahbar/Task-Manager---Data-Structures-Project/blob/main/screenshots/Screenshot%202025-01-31%20164651.png?raw=true.png)
