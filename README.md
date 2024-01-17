# CompanyManagement
Technical merit:
1. The code provided implements a simple inheritance hierarchy of employees, managers, part-time and general workers. It also includes a partial class DetailForm, which is a form that allows users to add, edit and delete employees.
2. Inheritance: The code makes use of inheritance, which allows for code reusability and abstraction. The base class Person contains the common properties shared by all employees, while the derived classes Employee, Manager, PartTime, and GeneralWorker add specific properties relevant to their respective employee types.
3. Polymorphism: The ToString method is overridden in each derived class, allowing for polymorphic behavior. This means that when an object of a derived class is printed to the console or converted to a string, the appropriate implementation of ToString will be called.
4.Encapsulation: The properties of the Employee, Manager, PartTime, and GeneralWorker classes are encapsulated, meaning they are accessed through getter and setter methods. This allows for greater control over access to the data, ensuring that it is only modified in ways that are intended.
5. Data Binding: The DetailForm class makes use of data binding to display a list of employees in a DataGridView. This allows for easy and efficient updating of the UI as the data changes.
6. DataTables: The DetailForm class also uses a DataTable to convert the list of employees to a format that can be bound to the DataGridView. This allows for sorting and filtering of the data, making it easier for users to find the information they need.
