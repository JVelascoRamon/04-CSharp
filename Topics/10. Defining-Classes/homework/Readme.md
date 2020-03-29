## Defining Classes - Part I

1. Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). Define 3 separate classes (class `GSM` holding instances of the classes `Battery` and `Display`).
2. Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.
3. Add an enumeration `BatteryType` (Li-Ion, NiMH, NiCd, ...) and use it as a new field for the batteries.
4. Add a method in the `GSM` class for displaying all information about it. Try to override `ToString()`.
5. Use properties to encapsulate the data fields inside the `GSM`, `Battery` and `Display` classes. Ensure all fields hold correct data at any given time.
6. Add a static field and a property `IPhone4S` in the `GSM` class to hold the information about iPhone 4S.
7. Create a class `Call` to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).
8. Add a property `CallHistory` in the `GSM` class to hold a list of the performed calls. Try to use the system class `List<Call>`.
9. Add methods in the `GSM` class for adding and deleting calls from the calls history. Add a method to clear the call history.
10. Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and is provided as a parameter.
11. Create a structure `Point3D` to hold a 3D-coordinate `{X, Y, Z}` in the Euclidian 3D space. Implement the `ToString()` to enable printing a 3D point.
12. Add a **private static read-only field** to hold the start of the coordinate system - the point `O = {0, 0, 0}`. Add a **static property** to return the point `O`.
13. Write a **static class** with a **static method** to calculate the distance between two points in the 3D space.
14. Create a class `Path` to hold a sequence of points in the 3D space. Create a static class `PathStorage` with static methods to save and load paths from a text file. Use a file format of your choice.
