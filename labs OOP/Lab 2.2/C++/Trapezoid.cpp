#include "Trapezoid.h"
#include <iostream>


Trapezoid::Trapezoid() : a{ 0.0, 0.0 }, b{ 0.0, 0.0 }, c{ 0.0, 0.0 }, d{ 0.0, 0.0 } {

}


Trapezoid::Trapezoid(Point a, Point b, Point c, Point d) : a(a), b(b), c(c), d(d) {

}


Trapezoid::Trapezoid(const Trapezoid& other) : a(other.a), b(other.b), c(other.c), d(other.d) {

}


Trapezoid::Trapezoid(Trapezoid&& other) noexcept : a(std::move(other.a)), b(std::move(other.b)), c(std::move(other.c)), d(std::move(other.d))
{

}


Trapezoid::~Trapezoid() {

}


double Trapezoid::calculateArea() const {
    return 0.5 * std::abs((a.x * b.y + b.x * c.y + c.x * d.y + d.x * a.y) -
        (b.x * a.y + c.x * b.y + d.x * c.y + a.x * d.y));
}


double Trapezoid::calculatePerimeter() const {
    return sideLength(a, b) + sideLength(b, c) + sideLength(c, d) + sideLength(d, a);
}


Point Trapezoid::getA() const { return a; }
Point Trapezoid::getB() const { return b; }
Point Trapezoid::getC() const { return c; }
Point Trapezoid::getD() const { return d; }


double Trapezoid::sideLength(Point p1, Point p2) const {
    return std::sqrt(std::pow(p2.x - p1.x, 2) + std::pow(p2.y - p1.y, 2));
}