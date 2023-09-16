# Memento Design Pattern

Memento is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.  

In the given Demo, A class library is implemented which can be used to track ,maintain and revert to the previous states of a string.  
Memento : TextAreaMemento - The class which stores the snapshot of the state of TextArea class.
Originator: TextArea - The class which contains the text to be displayed and taken snapshots from.
Caretaker: Editor - The class which is responsible for the manipulation of TextArea class and to restore it to older states when required by the user. It exposes the required properties to the user.
  ## UML Diagram
![uml](https://github.com/inglevinay/Software-Engineering_Personal-Project/assets/88585131/f3c811fa-1558-4fb5-9d89-def18de53306)

## Environment  
This project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
