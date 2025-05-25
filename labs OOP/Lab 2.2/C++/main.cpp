#include <iostream>
#include "Trapezoid.h" 


int main() {

    Trapezoid t1;
    std::cout << "Trapezoid 1):" << std::endl;
    std::cout << "Area: " << t1.calculateArea() << ", Perimeter: " << t1.calculatePerimeter() << std::endl;


    Point p1{ 1, 1 }, p2{ 4, 1 }, p3{ 3, 3 }, p4{ 2, 3 };
    Trapezoid t2(p1, p2, p3, p4);
    std::cout << "\nTrapezoid 2):" << std::endl;
    std::cout << "Area: " << t2.calculateArea() << ", Perimeter: " << t2.calculatePerimeter() << std::endl;


    Trapezoid t3 = t2;
    std::cout << "\nTrapezoid 3 (Copy of Trapezoid 2):" << std::endl;
    std::cout << "Area: " << t3.calculateArea() << ", Perimeter: " << t3.calculatePerimeter() << std::endl;


    Trapezoid t4(std::move(t3));
    std::cout << "\nTrapezoid 4 (Moved from Trapezoid 3):" << std::endl;
    std::cout << "Area: " << t4.calculateArea() << ", Perimeter: " << t4.calculatePerimeter() << std::endl;


    return 0;
}