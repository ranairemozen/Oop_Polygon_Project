# Oop_Polygon_Project

This project is an interactive polygon drawing and simulation application developed using C# and Windows Forms, based on Object-Oriented Programming (OOP) principles.

## Features

* **Customizable Drawing:** Create dynamic polygons by defining center coordinates, edge length (between 3-9), and the number of edges (between 3-10).
* **Rotation:** Rotate the drawn polygon clockwise or counterclockwise by a specified angle (0-360°).
* **Dynamic Coloring:** Adjust the color of the polygon in real-time using trackbars for RGB values (0-255).
* **Coordinate Calculation:** Automatically calculates the Cartesian and polar coordinates of the polygon's vertices in the background and displays them instantly in the UI list.
* **Random Generation (Reset):** Generate a completely new polygon with randomized coordinates, size, color, and angle with a single click.

## Technologies

* **Language:** C#
* **Framework:** .NET 9.0 (Windows Forms)
* **Architecture:** Object-Oriented Programming (OOP)

## Project Structure & Classes

To ensure modularity, the project is built upon three core classes:

* **`Point2D`:** Holds the Cartesian (X, Y) and polar (radius, angle) coordinates of points and performs mathematical conversions between these coordinate systems.
* **`Polygon`:** Contains the polygon's center point, edge length, color, and vertex list. The calculation of vertex coordinates and trigonometric rotation operations are handled within this class.
* **`ColorRGB`:** Encapsulates the polygon's color data and ensures that the provided RGB values always remain within the valid range (0-255).

## Installation & Usage

1. Clone or download the repository.
2. Open the `OOP_Project.sln` file with Visual Studio.
3. Build and run the project (F5).
4. Enter values via the interface and test the application using the "Draw", "Rotate", or "Reset" buttons.