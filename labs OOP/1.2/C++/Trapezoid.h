#ifndef TRAPEZOID_H
#define TRAPEZOID_H

#include <cmath>

struct Point {
    double x;
    double y;
};

class Trapezoid {
private:
    Point a, b, c, d;

public:

    Trapezoid();


    Trapezoid(Point a, Point b, Point c, Point d);


    Trapezoid(const Trapezoid& other);


    Trapezoid(Trapezoid&& other) noexcept;


    ~Trapezoid();


    double calculateArea() const;


    double calculatePerimeter() const;


    Point getA() const;
    Point getB() const;
    Point getC() const;
    Point getD() const;

private:

    double sideLength(Point p1, Point p2) const;
};

#endif